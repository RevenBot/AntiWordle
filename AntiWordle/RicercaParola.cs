using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AntiWordle
{
    class RicercaParola : CreaClassfromFile
    {
        private char[] nonNellaParola = new char[0];
        private char[] letteraTrovataG = new char[5];
        private char[] parolaTrovataV = new char[5];
        public List<Parola> parolePossibili = new List<Parola>();
        public RicercaParola(StreamReader streamReader)
        {
            base.StreamReader = streamReader;
        }

        public char[] NonNellaParola { get => nonNellaParola; set => nonNellaParola = value; }
        public char[] LetteraTrovataG { get => letteraTrovataG; set => letteraTrovataG = value; }
        public char[] ParolaTrovataV { get => parolaTrovataV; set => parolaTrovataV = value; }
        public void AggiungiLetteraNon(char no)
        {
            char[] temp = NonNellaParola;
            NonNellaParola = new char[temp.Length + 1];
            for (int i = 0; i < temp.Length; i++)
            {
                NonNellaParola[i] = temp[i];
            }
            NonNellaParola[NonNellaParola.Length - 1] = no;
        }
        public void AggiungiLetteraTrovataG(char sni, int noposition)
        {
            LetteraTrovataG[noposition] = sni;
        }
        public void AggiungiLetteraTrovataV(char si, int position)
        {
            ParolaTrovataV[position] = si;
        }
        public void Ricerca()
        {
            //ricerca sse stata trovata lettera 
            EscludiNo();
            bool esisteG=false;
            bool esisteV=false;
            foreach (var carG in LetteraTrovataG)
            {
                if(carG!='\0')
                {
                    esisteG = true;
                    break;
                }
            }
            if (esisteG == true)
            {
            EscludiGialle();

            }
            foreach (var carV in LetteraTrovataG)
            {
                if (carV != '\0')
                {
                    esisteV = true;
                    break;
                }
            }
            if (esisteV == true)
            {
                
            PosizioneVerde();

            }
        }
        private void EscludiNo()
        {

            //Le dimensioni cambiano quindi non va bene; Provare
            //1 crea nuova lista e copio gli elementi che mi servono ma sole prima volta dopo modifico quella creatante controllo se e' vuoto copio se non opero ssu di lei
            //2 Eliminazione della parola fuori il ciclo memoriazzare la posizione della parola da eliminare; fori
            //Array chiamo paroleChiavi se parolePossibili nullo faccio operazione su parolechiavi se non faccio operazione su Parolepossibili
            //Per ogni elemento nell'array se contiene il i 5 o meno caratteri escludi 
            //se contiene parola non copio nel array temp 
            //se non contiene copio nel array temp ma devo avere bool true che prova che quella parola se 
            //copia solo dopo il controllo come faccio bool controllo se dopo il for chars e true copio altrimenti non cop
            //
            if (parolePossibili.Count <= 0)
            {
                parolePossibili = paroleChiavi;
            }
            List<Parola> temp = new List<Parola>();
            foreach (Parola parolaP in paroleChiavi)
            {
                bool contieneC = false;
                foreach (char carattere in NonNellaParola)
                {
                    if (parolaP.ParolaChiave.Contains(carattere))
                    {
                        contieneC = true;
                        break;
                    }
                }
                if (contieneC == false)
                {
                    temp.Add(parolaP);
                }
            }
            parolePossibili = temp;
            //foreach (Parola item in paroleChiavi)
            //{
            //    foreach (var item1 in NonNellaParola)
            //    {
            //        if (!item.ParolaChiave.Contains(item1, StringComparison.OrdinalIgnoreCase))
            //        {


            //        }

            //    }
            //}

            //Se Contiene una parola con lettera esclusa elimina parola

        }
        private void EscludiGialle()
        {
            //se trovata la parola deve contenere la lettera
            //NON VA la parola restituita non contiene la lettera
            List<Parola> temp = new List<Parola>();
            foreach (var paroleG in parolePossibili)
            {
                bool giallaInParola = false;
                for (int i = 0; i < LetteraTrovataG.Length; i++)
                {
                    if (LetteraTrovataG[i] != '\0')
                    {
                        if (!paroleG.ParolaChiave.Contains(LetteraTrovataG[i]))
                        {
                            giallaInParola = true;
                            break;
                        }else if (paroleG.ParolaChiave[i].Equals(LetteraTrovataG[i]))
                        {
                            giallaInParola = true;
                        }
                    }
                }
                if (giallaInParola == false)
                {
                    temp.Add(paroleG);
                }
            }
            parolePossibili = temp;
            //for in posizione se la lettera escludi

        }
        private void PosizioneVerde()
        {
            List<Parola> temp = new List<Parola>();
            foreach (var paroleV in parolePossibili)
            {
                bool verdeNonCoincide = false;
                for (int i = 0; i < ParolaTrovataV.Length; i++)
                {
                    if (ParolaTrovataV[i] != '\0')
                    {

                        if (!paroleV.ParolaChiave[i].Equals(ParolaTrovataV[i]))
                        {
                            verdeNonCoincide = true;
                            break;
                        }
                    }
                }
                if (verdeNonCoincide == false)
                {
                    temp.Add(paroleV);
                }
            }
            parolePossibili = temp;
            //for in posizione se la lettera coincide tiene altrimenti elminia
            //foreach (var item in ParoleChiavi)
            //{
            //    for (int i = 0; i < ParolaTrovata.Length; i++)
            //    {
            //        if (ParolaTrovata[i] !='\0')
            //        {
            //            if (!item.ParolaChiave[i].Equals(ParolaTrovata[i]))
            //            {
            //                EliminaParola(item);
            //            }
            //        }
            //    }
            //}
        }
    }
}
