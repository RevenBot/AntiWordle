using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AntiWordle
{
    abstract class LetturaFile
    {
        //Attributi
        private int numeroRighe;
        private StreamReader lettoreFile;

        //Costruttori
        public LetturaFile(StreamReader lettoreFile = null)
        {
            this.lettoreFile = lettoreFile;
        }
        //Metodi
        public int NumeroRighe { get => numeroRighe; set => numeroRighe = value; }
        public StreamReader LettoreFile { get => lettoreFile; set => lettoreFile = value; }
        public void LetturaRighe()
        {
            int conta = 0;
            using StreamReader reader = lettoreFile;
            while (!reader.EndOfStream)
            {
                Console.WriteLine(reader.ReadLine().Split());
                conta++;
            }
                NumeroRighe = conta;
            Console.WriteLine("numeroRighe");
        }
        public abstract void ExtractLines();
    }
}
