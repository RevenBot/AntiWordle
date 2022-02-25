using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntiWordle
{
    public class Bottone:System.Windows.Forms.Button
    {
        private int riga;
        private int colonna;

        public int Riga { get => riga; set => riga = value; }
        public int Colonna { get => colonna; set => colonna = value; }

        public Bottone()
        {
            this.Size = new Size(110, 30);
            this.ForeColor = Color.White;
            this.BackColor = Color.DarkGray;
        }
        
    }
}
