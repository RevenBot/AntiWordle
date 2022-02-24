
namespace AntiWordle
{
    /// <summary>
    /// Crea un Array di tipo <see cref="Parola"/> da un file.
    /// <br>Da fare che puoi creare una Classe con delegato obj</br>
    /// </summary>
    class CreaClassfromFile
    {
        //Attributi
       
        private StreamReader streamReader;
        public List<Parola> paroleChiavi=new List<Parola>();
        public CreaClassfromFile()
        {
        }
        /// <summary>
        /// Costructtore con paramettro <see cref="System.IO.StreamReader"/> scelto nel main
        /// </summary>
        /// <param name="streamReader"></param>
        public CreaClassfromFile(StreamReader streamReader)
        {
            this.StreamReader = streamReader;
        }
        /// <summary>
        /// Get and Set Array di Classe creata
        /// </summary>
        
        public StreamReader StreamReader { get => streamReader; set => streamReader = value; }
        internal List<Parola> ParoleChiavi { get => paroleChiavi; set => paroleChiavi = value; }

        /// <summary>
        /// Metodo Lettura File e Creazione Classe
        /// </summary>
        public void LettoreFile()
        {
            while (!StreamReader.EndOfStream)
            {

                ParoleChiavi.Add(new Parola(StreamReader.ReadLine()));    
                
            }
        }
        public void AggiungiParola(Parola aggiungiParola)
        {
            ParoleChiavi.Add(aggiungiParola);
        }
        public void EliminaParola(Parola rimovereParola)
        {
            var itemToRemove = ParoleChiavi.SingleOrDefault(r => r.ParolaChiave == rimovereParola.ParolaChiave);
            if (itemToRemove != null)
                ParoleChiavi.Remove(itemToRemove); 
        }

        



    }
}
