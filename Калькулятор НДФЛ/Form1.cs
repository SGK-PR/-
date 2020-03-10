using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Калькулятор_НДФЛ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Vichislenie(object sender, EventArgs e)
        {
            double amount, differentrate;
            amount = Convert.ToDouble(Amount.Text);
            
            if (calculatetax.Checked)
            {
                if (ordinaryincome.Checked)
                {                   
                    interesttax.Text = "13";                    
                    amounttobepaid.Text = Convert.ToString(amount);                    
                    taxamount.Text = Convert.ToInt32(amount * 0.13 / 0.87).ToString();                   
                    totalamount.Text = Convert.ToInt32(amount + (amount * 0.13 / 0.87)).ToString();
                }                

                if (foreigners.Checked)
                {
                    interesttax.Text = "30";
                    amounttobepaid.Text = Convert.ToString(amount);
                    taxamount.Text = Convert.ToInt32((amount / 0.7) - amount).ToString();
                    totalamount.Text = Convert.ToInt32(amount / 0.7).ToString();
                }

                if (dividends.Checked)
                {
                    interesttax.Text = "9";
                    amounttobepaid.Text = Convert.ToString(amount);                
                    taxamount.Text = Convert.ToInt32((amount / 0.91) - amount).ToString();                
                    totalamount.Text = Convert.ToInt32(amount / 0.91).ToString();
                }

                if (this.differentrate.Checked)
                {
                    differentrate = Convert.ToDouble(interesttax.Text);
                    interesttax.Text = Convert.ToString(differentrate);
                    amounttobepaid.Text = Convert.ToString(amount);
                    double n = ((100 - differentrate) / 100);
                    taxamount.Text = Convert.ToInt32((amount / n) - amount).ToString();
                    totalamount.Text = Convert.ToInt32(amount / n).ToString();
                }


            }


            if (calculatepaymentandtax.Checked)
            {
                if (ordinaryincome.Checked)
                {
                    interesttax.Text = "13";
                    amounttobepaid.Text = Convert.ToInt32(amount - (amount / 100 * 13)).ToString();
                    taxamount.Text = Convert.ToInt32(amount / 100 * 13).ToString();
                    this.totalamount.Text = Convert.ToString(amount);
                }

                if (foreigners.Checked)
                {
                    interesttax.Text = "30";             
                    amounttobepaid.Text = Convert.ToInt32(amount - (amount / 100 * 30)).ToString();
                    taxamount.Text = Convert.ToInt32(amount / 100 * 30).ToString();
                    this.totalamount.Text = Convert.ToString(amount);

                }

                if (dividends.Checked)
                {
                    interesttax.Text = "9";                    
                    amounttobepaid.Text = Convert.ToInt32(amount - (amount / 100 * 9)).ToString();
                    taxamount.Text = Convert.ToInt32(amount / 100 * 9).ToString();
                    this.totalamount.Text = Convert.ToString(amount);
                }

                if (this.differentrate.Checked)
                {
                    differentrate = Convert.ToDouble(interesttax.Text);
                    interesttax.Text = Convert.ToString(differentrate);
                    amounttobepaid.Text = Convert.ToInt32(amount - (amount / 100 * differentrate)).ToString();
                    taxamount.Text = Convert.ToInt32(amount / 100 * differentrate).ToString();
                    this.totalamount.Text = Convert.ToString(amount);
                }
                
                
            }
        }

        private void Clear(object sender, EventArgs e)
        {
            Amount.Text = "";
            amounttobepaid.Text = "";
            taxamount.Text = "";
            totalamount.Text = "";
            interesttax.Text = "";
        }
    }
}
