using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void zero_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            label2.Text += bt.Text; 
        }

        private void one_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            label2.Text += bt.Text;
        }

        private void two_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            label2.Text += bt.Text;
        }
        private void three_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            label2.Text += bt.Text;
        }

        private void four_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            label2.Text += bt.Text;
        }

        private void five_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            label2.Text += bt.Text;
        }

        private void six_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            label2.Text += bt.Text;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            label2.Text += bt.Text;
        }

        private void eghit_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            label2.Text += bt.Text;
        }
        private void nine_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            label2.Text += bt.Text;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            label1.Text = "";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            label2.Text += bt.Text;
        }

        private void plus_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            label2.Text += bt.Text;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            label2.Text += bt.Text;
        }

        private void multi_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            label2.Text += bt.Text;
        }

        private void equl_Click(object sender, EventArgs e)
        {
            string[] plusSplit = label2.Text.Split('+');
            double result = 0;
            
            for(int i = 0; i < plusSplit.Length; i++)
            {

                string[] minusSplit = plusSplit[i].Split('-');

                double minusSplitresult = 0;

                for (int j = 0; j < minusSplit.Length; j++)
                {

                    string[] multiSplit = minusSplit[j].Split('*');

                    double multiSplitresult = 0;

                    for (int k = 0; k < multiSplit.Length; k++)
                    {

                        string[] divSplit = multiSplit[k].Split('/');

                        double divSplitresult = 0;

                        for (int l = 0; l < divSplit.Length; l++)
                        {
                            if (l == 0) divSplitresult += Convert.ToDouble(divSplit[l]);
                            else divSplitresult /= Convert.ToDouble(divSplit[l]);
                        }
                        multiSplit[k] = Convert.ToString(divSplitresult);

                        if (k == 0) multiSplitresult += Convert.ToDouble(multiSplit[k]);
                        else multiSplitresult *= Convert.ToDouble(multiSplit[k]);
                    }

                    minusSplit[j] = Convert.ToString(multiSplitresult);

                    if (j == 0) minusSplitresult += Convert.ToDouble(minusSplit[j]);
                    else minusSplitresult -= Convert.ToDouble(minusSplit[j]);

                }
                plusSplit[i] = Convert.ToString(minusSplitresult);

                result += Convert.ToDouble(plusSplit[i]);
            }

            label1.Text = Convert.ToString(result);
        }


    }
}
