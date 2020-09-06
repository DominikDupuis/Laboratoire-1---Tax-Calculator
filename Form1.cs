using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratoire_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var c in new Label[] { lbl_ttc, lbl_tps, lbl_ht, lbl_tvq })
                c.Visible = true;
            if(txtbox_prix.Text=="" || txtbox_quantite.Text == "")
            {
                txtbox_prix.Text = "0";
                txtbox_quantite.Text = "0";
            }
            Decimal mt_ht = Decimal.Parse(txtbox_prix.Text) * Decimal.Parse(txtbox_quantite.Text);
            string str_mt_ht = string.Format("{0:0.00}", mt_ht) + "$" ;
            lbl_mt_ht.Text = str_mt_ht;
            Decimal mt_tps =mt_ht * 0.05m;
            string str_mt_tps = string.Format("{0:0.00}", mt_tps) + "$";
            lbl_mt_tps.Text = str_mt_tps;
            Decimal mt_tvq = decimal.Round((mt_ht * 0.09975m), 2, MidpointRounding.AwayFromZero);
            string str_mt_tvq = string.Format("{0:0.00}", mt_tvq) + "$";
            lbl_mt_tvq.Text = str_mt_tvq;
            string str_mt_ttc = string.Format("{0:0.00}", mt_ht + (mt_tps + mt_tvq)) + "$";
            lbl_mt_ttc.Text = str_mt_ttc;
        }

        private void txtbox_prix_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtbox_quantite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)){
                e.Handled = true;
            }
        }
    }
}
