using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HraRPR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        HerniPostava postava1 = new HerniPostava("John");
        Hrac hrac1 = new Hrac("Kouzelnik", 0, "John", Oblicej.VelkyNos, Vlasy.Drdol, BarvaVlasu.Blond);
        NPC npc1 = new NPC(Prace.Nepritel, "john");

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(hrac1.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hrac1.PridejXP(20);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(npc1.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            npc1.ZmenaPozice();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            postava1.ZmenaPozice();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(postava1.ToString());
        }
    }
}
