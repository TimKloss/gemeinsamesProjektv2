using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gemeinsamesPROJEKTv2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //txtEingabe, txtAusgabe, btnUmwandeln;
        }

        private void BtnUmwandeln_Click(object sender, EventArgs e)
        {
            int zaehler = int.Parse(txtEingabe.Text.Substring(0, txtEingabe.Text.IndexOf("/")));
            int nenner = int.Parse(txtEingabe.Text.Substring(txtEingabe.Text.IndexOf("/") + 1));
            if (zaehler % nenner < 1)
            {
                txtAusgabe.Text = (zaehler / nenner).ToString();
            }
            else if (ggT(zaehler, nenner) > 1)
            {
                int teiler = ggT(zaehler, nenner);
                zaehler = zaehler / teiler;
                nenner = nenner / teiler;
                txtAusgabe.Text = zaehler.ToString() + "/" + nenner.ToString();
            }
            else
            {
                txtAusgabe.Text = txtEingabe.Text;
            }
        }

        public int ggT(int pZahl1, int pZahl2)
        {
            int ergebnis = 1;
            if (pZahl1 > pZahl2)
            {
                for (int i = pZahl2; i > 0; i--)
                {
                    if (pZahl2 % i < 1 & pZahl1 % i < 1)
                    {
                        ergebnis = i;
                        i = 0;
                    }
                }
            }
            else
            {
                for (int i = pZahl1; i > 0; i--)
                {
                    if (pZahl2 % i < 1 & pZahl1 % i < 1)
                    {
                        ergebnis = i;
                        i = 0;
                    }
                }
            }
            return ergebnis;
        }
    }
}
