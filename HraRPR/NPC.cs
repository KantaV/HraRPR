using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HraRPR
{
    public enum Prace
    {
        Obchodnik,
        Nepritel,
        Obyvatel
    }
    internal class NPC:HerniPostava
    {
        public Prace Prace { get;set; }  
        public bool jeBoss;

        public NPC(bool jeBoss, Prace prace,string jmeno) :base(jmeno)
        {
            this.jeBoss = jeBoss;
            this.Prace = prace;
        }

        public NPC(Prace prace, string jmeno) : base(jmeno)
        {
            this.jeBoss = false;
            this.Prace = prace;
        }

        public override void ZmenaPozice()
        {
            base.ZmenaPozice();
            base.statickaPozice = true;
        }

        public override string ToString()
        {
            return base.ToString() +
                "\nJe boss: " + jeBoss +
                "\nPrace: " + Prace;
        }
    }
}
