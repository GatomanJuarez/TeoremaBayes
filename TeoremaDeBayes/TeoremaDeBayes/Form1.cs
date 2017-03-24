using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeoremaDeBayes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double aux = 0,aux2 = 0, Total = 0;
            try
            {
                if (txtPA.Text == "")
                {
                    aux = double.Parse(txtPB.Text);
                    aux2 = double.Parse(txtPC.Text);
                    Total = 1 - (aux + aux2);
                    txtPA.Text = Total.ToString();
                }
                else if (txtPB.Text == "")
                {
                    aux = double.Parse(txtPA.Text);
                    aux2 = double.Parse(txtPC.Text);
                    Total = 1 - (aux + aux2);
                    txtPB.Text = Total.ToString();
                }
                else
                {
                    aux = double.Parse(txtPB.Text);
                    aux2 = double.Parse(txtPA.Text);
                    Total = 1 - (aux + aux2);
                    txtPC.Text = Total.ToString();
                }
                
            }
            catch (Exception s)
            {
                MessageBox.Show("Introdusca solo numeros "+s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            double aux = 0, total = 0;
            try
            {
                if (txtaf.Text == "")
                {
                    aux = double.Parse(txtaff.Text);
                    total = 1 - aux;
                    txtaf.Text = total.ToString();
                }
                else
                {
                    aux = double.Parse(txtaf.Text);
                    total = 1 - aux;
                    txtaff.Text = total.ToString();
                }
                if (txtbf.Text == "")
                {
                    aux = double.Parse(txtbff.Text);
                    total = 1 - aux;
                    txtbf.Text = total.ToString();
                }
                else 
                {
                    aux = double.Parse(txtbf.Text);
                    total = 1 - aux;
                    txtbff.Text = total.ToString();
                }
                if (txtcf.Text == "")
                {
                    aux = double.Parse(txtcff.Text);
                    total = 1 - aux;
                    txtcf.Text = total.ToString();
                }
                else
                {
                    aux = double.Parse(txtcf.Text);
                    total = 1 - aux;
                    txtcff.Text = total.ToString();
                }
            }
            catch (Exception s)
            {
                MessageBox.Show("Introdusca solo numeros " + s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A un cliente se le asigne una habitación en que le falle la plomeria", "Problema A", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            label12.Text = "Formula  P(RI) * P(F|RI) + P(SH)*P(F|SH) + P(LML)*P(F|LML)";
            double RIFRI, aux, aux3;
            aux = 0; aux3 = 0;
            aux = double.Parse(txtaf.Text);
            aux3 = double.Parse(txtPA.Text);
            RIFRI = aux * aux3;
            aux = 0; aux3 = 0;
            aux = double.Parse(txtbf.Text);
            aux3 = double.Parse(txtPB.Text);
            double SH = aux * aux3;
            aux = 0; aux3 = 0;
            aux = double.Parse(txtcf.Text);
            aux3 = double.Parse(txtPC.Text);
            double LML = aux * aux3;
            double total = (RIFRI + SH + LML)*100;
            textBox11.Text = total.ToString() + "%";
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A un cliente se le asigne una habitación en que le no falle la plomeria", "Problema B", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            label12.Text = "Formula  P(RI) * P(F'|RI) + P(SH)*P(F'|SH) + P(LML)*P(F'|LML)";
            double RIFRI, aux, aux3;
            aux = 0; aux3 = 0;
            aux = double.Parse(txtaff.Text);
            aux3 = double.Parse(txtPA.Text);
            RIFRI = aux * aux3;
            aux = 0; aux3 = 0;
            aux = double.Parse(txtbff.Text);
            aux3 = double.Parse(txtPB.Text);
            double SH = aux * aux3;
            aux = 0; aux3 = 0;
            aux = double.Parse(txtcff.Text);
            aux3 = double.Parse(txtPC.Text);
            double LML = aux * aux3;
            double total = (RIFRI + SH + LML)*100;
            textBox11.Text = total.ToString()+ "%";
            double total2 = RIFRI / total;
        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A una persona que ocupa una habitacion en el que falle la plomeria se le haya hospedado " +
            "en el Ramada Inn? Lakevie Motor Lodge? Sheraton?", "Problema C", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            label12.Text = "Formula  P(RI) * P(F|RI) / P(RI)*P(F|RI) + P(SH)*P(F|SH) + P(LML)*P(F|LML)";
            double RIFRI, aux, aux3;
            aux = 0; aux3 = 0;
            aux = double.Parse(txtaf.Text);
            aux3 = double.Parse(txtPA.Text);
            RIFRI = aux * aux3;
            textBox1.Text = RIFRI.ToString();
            aux = 0; aux3 = 0;
            aux = double.Parse(txtbf.Text);
            aux3 = double.Parse(txtPB.Text);
            double SH = aux * aux3;
            aux = 0; aux3 = 0;
            aux = double.Parse(txtcf.Text);
            aux3 = double.Parse(txtPC.Text);
            double LML = aux * aux3;
            double total = RIFRI + SH + LML;
            textBox3.Text = total.ToString();
            double total2 = RIFRI / total;
            textBox2.Text = "P(RI|FP): " + total2.ToString();
            ///////////////////////////////////////////////////////
            double totalsh = SH / total;
            textBox6.Text = SH.ToString();
            textBox4.Text = total.ToString();
            textBox5.Text = "P(SH|FP): " + totalsh;
            double totallml = LML / total;
            textBox9.Text = LML.ToString();
            textBox7.Text = total.ToString();
            textBox8.Text = "P(LML|FP): " + totallml;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
