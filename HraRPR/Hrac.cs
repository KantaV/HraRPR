using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HraRPR
{
    public enum Oblicej
    {
        VelkyNos,
        VelkeUsi,
        Make_up
    }

    public enum Vlasy
    {
        Drdol,
        Culik,
        Pleska
    }

    public enum BarvaVlasu
    {
        Kastanova,
        Blond,
        Cervena
    }
    internal class Hrac :HerniPostava
    {
        private string specializace;
        public string Specializace { get { return specializace; } set { specializace = value; } }

        public Oblicej Oblicej { get; set; }
        public Vlasy Vlasy { get; set; }

        public BarvaVlasu BarvaVlasu { get; set; }


        public int XP;

        public Hrac(string specializace, int xP,string jmeno, Oblicej oblicej, Vlasy vlasy, BarvaVlasu barvalasu) :base(jmeno)
        {
            Specializace = specializace;
            Specializace = specializace;
            XP = xP;
            this.Jmeno = jmeno;
            this.Oblicej = oblicej;
            this.Vlasy = vlasy;
            this.BarvaVlasu = barvalasu;
        }


        public void PridejXP(int xp)
        {
            XP += xp;
            if(XP == 100)
            {
                level += 1;
                XP = 0;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "\nSpecializace: " + specializace +  "\nOblicej: " + Oblicej + "\nVlasy: " + Vlasy + "\nBarva vlasu: " + BarvaVlasu
                + "\nXP: " + XP;

        }

    }
}
