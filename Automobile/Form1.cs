using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automobile
{
    public partial class Form1 : Form
    {
        class Auto
        {
            public string _motore { get; set; }
            public int _pedale { get; set; }
            public int marcia { get; set; }

            public void AccSpe(bool a)
            {
                if(a == false)
                {
                    _motore = "SPENTO";
                }
                else
                {
                    _motore = "ACCESO";
                }

            }
        }

        bool a = true;
        Auto auto = new Auto();
        public Form1()
        {
            InitializeComponent();
        }

        private void ACCENDI_Click(object sender, EventArgs e)
        {
            a = true; 
            auto.AccSpe(a);
            T1.Text = auto._motore;
        }

        private void SPEGNI_Click(object sender, EventArgs e)
        {
            a = false;
            auto.AccSpe(a);
            T1.Text = auto._motore;

        }

        private void ACC_Click(object sender, EventArgs e)
        {

        }

        private void FRENO_Click(object sender, EventArgs e)
        {

        }
    }
}
