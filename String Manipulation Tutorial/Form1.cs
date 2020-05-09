using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String_Manipulation_Tutorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//Remove Button
        {
            string strSubString = txtSubstring.Text;// The Substring Textbox
            string strString = txtString.Text;//the quick brown Fox Textbox
            int SubString_Length = strSubString.Length;//The Length It Pulls Out Of The Substring Textbox
            int NS_INdex = strString.IndexOf(strSubString);
            if(SubString_Length == 0)
            {
                MessageBox.Show("You Need To Type In A Sub-String!");

            }
            else if (NS_INdex == -1)
            {
                MessageBox.Show("SubString Not Found In String!");
            }
            else
            {
                txtSubstring.Text = strString.Remove(NS_INdex, SubString_Length);
                txtSubstring.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strSubString = txtSubstring.Text;
            string strReplaceString = txtReplaceWith.Text;
            string strString = txtString.Text;
            int nsslength = strSubString.Length;
            int nsrlength = strReplaceString.Length;
            int nsindex = strString.IndexOf(strSubString);
            if(nsslength == 0)
            {
                MessageBox.Show("You Need To Type In A Sub-String!");
            }
            else if (nsindex == -1)
            {
                MessageBox.Show("SubString Not Found In String!");
            }
            else if (nsrlength == 0)
            {
                MessageBox.Show("You Need To Type In a Replace String!");
            }
            else
            {
                txtString.Text = strString.Replace(strSubString, strReplaceString);
                txtSubstring.Clear();
                txtReplaceWith.Clear();
            }



        }
    }
}
