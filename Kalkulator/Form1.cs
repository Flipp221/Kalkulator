﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        int day = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonschot_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(label1.Text);
            if (a >= 500000)
            {
                MessageBox.Show("Более 500тысяч не даём!");
                Application.Restart();
            }
            day = Convert.ToInt32(label2.Text);
            if (day > 0 && day < 6)
            {
                comboBox1.Text = "До 5-ти дней 0.9%";
            }

            else if (day > 5 && day < 11)
            {
                comboBox1.Text = "С 6 по 10 день 0.7%";
            }

            else if (day > 10 && day < 366)
            {
                comboBox1.Text = "После 11 дня 0.6%";
            }
            else
            {
                MessageBox.Show("Неправильное кол-во дней!");
            }
            switch (comboBox1.Text)
            {
                case "До 5-ти дней 0.9%":

                    if (day > 0 && day < 6)
                    {
                        result.Text = Convert.ToString((a / 100) * 0.9 * day + a);
                        break;
                    }
                    MessageBox.Show("Принимает дни от 1 до 5!");
                    Application.Restart();
                    break;
                case "С 6 по 10 день 0.7%":
                    if (day > 5 && day < 11)
                    {
                        result.Text = Convert.ToString(((a / 100) * 0.9 * 5) + ((a / 100) * 0.7 * (day - 5) + a));
                        break;
                    }
                    MessageBox.Show("Принимает дни от 6 до 10!");
                    Application.Restart();
                    break;
                case "После 11 дня 0.6%":
                    if (day > 10 && day < 366)
                    {
                        double d = ((a / 100) * 0.9 * 5) + ((a / 100) * 0.7 * 5) + ((a / 100) * 0.6 * (day - 10) + a);

                        if ((a * 2.5) < d)
                        {
                            d = a * 2.5;
                        }
                        result.Text = Convert.ToString(d);
                        break;
                    }
                    MessageBox.Show("Принимает дни от 11 до года!");
                    Application.Restart();
                    break;
            }
        }
        private void buttonclear_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            result.Text = "";
            comboBox1.Text = "";
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }
    }
}