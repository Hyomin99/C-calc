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
        } //0

        private void one_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            label2.Text += bt.Text;
        } //1

        private void two_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            label2.Text += bt.Text;
        } //2
        private void three_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            label2.Text += bt.Text;
        } //3

        private void four_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            label2.Text += bt.Text;
        } //4

        private void five_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            label2.Text += bt.Text;
        } //5

        private void six_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            label2.Text += bt.Text;
        } //6

        private void seven_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            label2.Text += bt.Text;
        } //7

        private void eghit_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            label2.Text += bt.Text;
        } //8
        private void nine_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            label2.Text += bt.Text;
        } //9

        private void clear_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            result.Text = "";
        } // 초기화

        private void divide_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            label2.Text += bt.Text;
        } // 나누기

        private void plus_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            label2.Text += bt.Text;
        } // 더하기

        private void minus_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            label2.Text += bt.Text;
        } //빼기

        private void multi_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            label2.Text += bt.Text;
        } //곱하기

        private void equl_Click(object sender, EventArgs e)

            /** 만일 10 + 20 - 30 * 40 / 50 을 계산하려고 한다.**/
        {
            string[] plusSplit = label2.Text.Split('+'); //입력한 숫자와 연산자들중 + 를 기준으로 나누어 plusSplit[0] = 10 , plusSplit[1] = 20 - 30 * 40 / 50 
            double result = 0;
            
            for(int i = 0; i < plusSplit.Length; i++)
            {

                string[] minusSplit = plusSplit[i].Split('-'); // plusSplit[1]을 - 를 기준으로 나누어 minusSplit[0] = 20 , minusSplit[1] = 30 * 40 / 50 

                double minusSplitresult = 0;

                for (int j = 0; j < minusSplit.Length; j++)
                {

                    string[] multiSplit = minusSplit[j].Split('*'); // minusSplit[1]을 * 를 기준으로 나누어 multiSplit[0] = 30 , multiSplit[1] = 40 / 50

                    double multiSplitresult = 0;

                    for (int k = 0; k < multiSplit.Length; k++)
                    {

                        string[] divSplit = multiSplit[k].Split('/'); //multiSplit[1]을 / 를 기준으로 나누어 divSplit[0] = 40 , divSplit[1] = 50 
                        double divSplitresult = 0;

                        for (int l = 0; l < divSplit.Length; l++)
                        {
                            if (l == 0) divSplitresult += Convert.ToDouble(divSplit[l]); // divSplit[0] = 40 을 divSplitresult 값에 저장함 divSplitresult = 40

                            else divSplitresult /= Convert.ToDouble(divSplit[l]); // divSplitresult값에 저장되어 있는 값을 divSplit[1] 으로 나눠줌 40/50 = 0.8
                        }
                        multiSplit[k] = Convert.ToString(divSplitresult); //multiSplit[1] = 40 / 50 의 값의 값을 0.8로 바꿔 저장

                        if (k == 0) multiSplitresult += Convert.ToDouble(multiSplit[k]); // multiSplit[0] = 30 값을 multiSplitresult 값에 더해줌 multiSplitresult = 30

                        else multiSplitresult *= Convert.ToDouble(multiSplit[k]); // multiSplitresult 값과 0.8로 곱해준 값 24를 multiSplitresult에 다시 저장
                    }

                    minusSplit[j] = Convert.ToString(multiSplitresult); // minusSplit[1] = 30 * 40 / 50  의 값을 24로 바꿔 저장

                    if (j == 0) minusSplitresult += Convert.ToDouble(minusSplit[j]); // minusSplit[0] = 20 의 값을 minusSplitresult 에 더해줌 minusSplitresult = 20

                    else minusSplitresult -= Convert.ToDouble(minusSplit[j]); // minusSplitresult 과 minusSplit[1] 를 빼준뒤 minusSplitresult에 저장 20 - 24 = -4

                }
                plusSplit[i] = Convert.ToString(minusSplitresult);  // plusSplit[1] = 20 - 30 * 40 / 50 의 값을  -4로 바꿔 저장

                result += Convert.ToDouble(plusSplit[i]); // plusSplit[0] 과 plusSplit[1] 을 더한 값을 result에 저장 10 -4 = 6
            }

            this.result.Text = Convert.ToString(result); 
        }


    }
}
