using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abdullah_Hassan_Abdo_Hassan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // طول النص كامل 
        private void btnAllLength_Click(object sender, EventArgs e)
        {
            txtShowAll.Text =txtAll_text.Text.Trim().Length.ToString();
        }

        //  طول النص المحدد
        private void btnSelectLength_Click(object sender, EventArgs e)
        {
            if(txtAll_text.SelectedText.Length > 0)
            {
                txtSelect_Length.Text = txtAll_text.SelectionLength.ToString();
            }
            else
            {
                MessageBox.Show("First Select The Text");
                txtSelect_Length.Text = null;
            }
        }
        //   عدد الكلمات في النص
        private void btnLengthWord_Click(object sender, EventArgs e)
        {
            if(txtAll_text.Text != null)
            {
                int x = 1;
                for (int i = 0; i < txtAll_text.Text.Length; i++)
                {
                    if (txtAll_text.Text[i] == ' ' && txtAll_text.Text[i+1] != ' ')
                        x++;
                }
                txtLengthWord.Text = x.ToString();
            }
        }

        private void btnDeleteSelectionTxt_Click(object sender, EventArgs e)
        {
            if( txtAll_text.SelectionLength > 0)
            {
                txtAll_text.SelectedText = null;
            }
            else
            {
                MessageBox.Show("قم بتحديد النص");
            }
        }

        private void btnNoSelect_Click(object sender, EventArgs e)
        {
            txtAll_text.SelectionLength = 0;
        }

        string myselectedtext = " ";
        private void btnCopy_Click(object sender, EventArgs e)
        {
            if(txtAll_text.SelectedText.Length > 0)
            {
                myselectedtext = txtAll_text.SelectedText;
            }
            else
            {
                MessageBox.Show("لا يوجد نص محدد");
            }
        }

        private void btnCut_Click(object sender, EventArgs e)
        {
            if (txtAll_text.SelectedText.Length > 0)
            {
                myselectedtext = txtAll_text.SelectedText;
                txtAll_text.SelectedText = null;
            }
            else
            {
                MessageBox.Show("لا يوجد نص محدد");
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtAll_text.Clear();
        }

        private void btnPast_Click(object sender, EventArgs e)
        {
            txtCopyPast.Text += myselectedtext.Trim();
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            txtAll_text.Undo();
            txtCopyPast.Undo();
        }

        private void btnLengthNoSpace_Click(object sender, EventArgs e)
        {
            int x = 0;
            for (int i = 0; i < txtAll_text.Text.Length; i++)
            {
                if (txtAll_text.Text[i] != ' ')
                    x++;
            }
            MessageBox.Show(x.ToString());
        }

        private void btnLengthSelected_Click(object sender, EventArgs e)
        {
            int x = 0;
            for (int i = 0; i < txtAll_text.SelectedText.Length; i++)
            {
                if (txtAll_text.SelectedText[i] != ' ')
                    x++;
            }
            MessageBox.Show(x.ToString());
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            if(txtAll_text.SelectionLength > 0)
            {
                if(txtedite.Text.Trim() != " ")
                {
                    txtAll_text.SelectedText = txtedite.Text;
                }
                else
                {
                    MessageBox.Show("ادخل النص الجديد");
                }
            }
            else
            {
                MessageBox.Show("ادخل النص المراد تعديله ");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtsearch.Text.Trim() !=" ")
            {
                int index = txtAll_text.Text.IndexOf(txtsearch.Text,0);
                if(index > -1)
                {
                    txtAll_text.SelectionStart = index;
                    txtAll_text.SelectionLength = txtsearch.Text.Length;
                    txtAll_text.Focus();
                }
                else
                {
                    MessageBox.Show("not found");
                }
            }
            else
            {
                MessageBox.Show("enter the text to search");
                txtsearch.Focus();
            }
        }

        private void btnSearchAfter_Click(object sender, EventArgs e)
        {
            if (txtsearch.Text.Trim() != " ")
            {
                int index = txtAll_text.Text.IndexOf( txtsearch.Text, 
                                                      txtAll_text.SelectionStart + 
                                                      txtAll_text.SelectionLength);

                if (index > -1)
                {
                    txtAll_text.Focus();
                    txtAll_text.Select(index,txtsearch.Text.Length);
                }
                else
                {
                    MessageBox.Show("not found");
                }
            }
            else
            {
                MessageBox.Show("enter the text to search");
                txtsearch.Focus();
            }
        }

        private void btnSearchBefor_Click(object sender, EventArgs e)
        {
            if (txtsearch.Text.Trim() != " ")
            {
                int index = txtAll_text.Text.LastIndexOf(txtsearch.Text,
                                                      txtAll_text.SelectionStart +
                                                      txtAll_text.SelectionLength);

                if (index > -1)
                {
                    txtAll_text.Focus();
                    txtAll_text.Select(index, txtsearch.Text.Length);
                }
                else
                {
                    MessageBox.Show("not found");
                }
            }
            else
            {
                MessageBox.Show("enter the text to search");
                txtsearch.Focus();
            }
        }

        private void btnShowLeters_Click(object sender, EventArgs e)
        {
            listBoxShowChar.Items.Clear();

            string s = txtAll_text.SelectedText;
            char[] cha = s.ToCharArray();
            for (int i = 0; i < cha.Length; i++)
            {
                listBoxShowChar.Items.Add(cha[i]);
            }
        }

        private void btnShowWords_Click(object sender, EventArgs e)
        {
            listBoxShowWord.Items.Clear();

            string []s = txtAll_text.SelectedText.Split(' ');
           
            for (int i = 0; i < s.Length; i++)
            {
                listBoxShowWord.Items.Add(s[i]);
            }
        }
    }
}
