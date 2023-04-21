using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HraRPR
{
    internal class HerniPostava
    {

        private string jmeno;
        public string Jmeno { get { return jmeno; } set { jmeno = value; } }

        protected int level = 1;
        public double PoziceX { get; protected set; }
        public double PoziceY { get; protected set; }

        public HerniPostava(string jmeno)
        {
            this.jmeno = jmeno;
        }

        public bool statickaPozice = false;

        public virtual void ZmenaPozice()
        {
            if (!statickaPozice) {
            this.PoziceX += 5;
            this.PoziceY += 5;
            }
        }

        public override string ToString()
        {
            return "Jméno: " + this.Jmeno
                + "\nLevel: " + this.level
                + "\nPozice X: " + this.PoziceX
                + "\nPozice Y: " + this.PoziceY;
        }
    }
}
