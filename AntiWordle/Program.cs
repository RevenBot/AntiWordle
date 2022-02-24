namespace AntiWordle
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            //StreamReader file = new StreamReader("../../../nuovo1234567890.txt");
            //var a = new RicercaParola(file);
            //a.LettoreFile();
            //a.AggiungiLetteraNon('S');
            //a.AggiungiLetteraNon('O');
            //a.AggiungiLetteraNon('T');

            //a.AggiungiLetteraTrovataG('H', 1);
            //a.AggiungiLetteraTrovataG('R', 3);

            ////a.AggiungiLetteraTrovataV('E', 1);
            ////a.AggiungiLetteraTrovataV('S', 4);

            //a.Ricerca();
            //                                            //Doppia stampa
            ////2Riga
            //a.AggiungiLetteraNon('W');
            //a.AggiungiLetteraNon('I');
            //a.AggiungiLetteraNon('P');

            //a.AggiungiLetteraTrovataG('R', 4);


            //a.Ricerca();
            ////3 rigas

            //a.AggiungiLetteraNon('B');
            //a.AggiungiLetteraNon('G');
            //a.AggiungiLetteraTrovataG('R', 2);
            //a.AggiungiLetteraTrovataV('E', 1);
            //a.AggiungiLetteraTrovataV('H', 4);

            //a.Ricerca();


            //Console.WriteLine(a.parolePossibili.Count);
            //foreach (var item in a.parolePossibili)
            //{
            //    Console.WriteLine(item.ParolaChiave);
            //}
        }
    }
}