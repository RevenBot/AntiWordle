using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntiWordle
{
    /// <summary>
    /// Classe di tipo <see cref="Parola"/>
    /// <br/>
    /// Implementa la possibilita di un delegato per trasformazione da String a Char
    /// <br/>
    /// Ritorna ogni Char
    /// </summary>
    class Parola
    {
        //Attributi
        private string parolaChiave;
        //Costruttore
        public Parola()
        {
        }
        /// <summary>
        /// Costruttore di Parola
        /// </summary>
        /// <param name="parolaChiave"></param>
        public Parola(string parolaChiave)
        {
            this.parolaChiave = parolaChiave;   
        }

        //Proprieta
       
        /// <summary>
        /// GET E SET String di parola
        /// </summary>
        public string ParolaChiave { get => parolaChiave; set => parolaChiave = value; }
        //Metodi
        //override di uguale
    }
}
