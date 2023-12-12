﻿using System;
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
            public int _marcia { get; set; }

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

        bool a = false;
        Auto auto = new Auto();
        public Form1()
        {
            InitializeComponent();
        }

        private void ACCENDI_Click(object sender, EventArgs e)
        {
            if (T1.Text != "ACCESO")
            {
                a = true;
                auto.AccSpe(a);
                T1.Text = auto._motore;
                T3.Text = "N";
                auto._marcia = 0;
            }
        }

        private void SPEGNI_Click(object sender, EventArgs e)
        {
            a = false;
            auto.AccSpe(a);
            T1.Text = auto._motore;
            auto._pedale = 0;
            T2.Text = auto._pedale.ToString();
            T3.Text = "N";
            auto._marcia = 0;
        }

        private void ACC_Click(object sender, EventArgs e)
        {
            if (a == true && T3.Text != "N")
            {
                auto._pedale += 5;
                T2.Text = auto._pedale.ToString();
            }
        }

        private void FRENO_Click(object sender, EventArgs e)
        {
            if (auto._pedale != 0)
                auto._pedale -= 5;
            T2.Text = auto._pedale.ToString();
            
        }

        private void AUM_Click(object sender, EventArgs e)
        {
            if (auto._marcia < 7)
            {
                auto._marcia++;
                T3.Text = auto._marcia.ToString();
            }
        }

        private void DIM_Click(object sender, EventArgs e)
        {
            if (auto._marcia == 1)
            {
                T3.Text = "N";
                auto._marcia--;
            }
            else if (auto._marcia != 0)
            {
                auto._marcia--;
                T3.Text = auto._marcia.ToString();
            }
            else if (T3.Text == "N")
                T3.Text = "R";
        }
    }
}
