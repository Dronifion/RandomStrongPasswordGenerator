using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//Application Used Library
using System.Text.RegularExpressions;

namespace StrongPassword
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTestRegex_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Regex.IsMatch(txtPassword.Text, txtRegex.Text).ToString());
        }

        private void btnGetRan_Click(object sender, EventArgs e)
        {
            txtPassword.Text = getRandomPassword();
        }

        public string getRandomPassword()
        {
            string sPassword = string.Empty;
            string sNewPasswordRegex = txtRegex.Text;
            int iLength = 0;
            string sTemp = string.Empty;
            int iIndex = 0;
            char[] cFirst = new char[] { '+', '/' };
            string sFirst = string.Empty;
            char[] cSecond = new char[] { 'A', 'B', 'C', 'D', 'E', 'F' };
            string sSecond = string.Empty;
            char[] cThird = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            string sThird = string.Empty;
            string sReplace = string.Empty;
            try
            {
                byte[] bPassword = new byte[8];
                Random rnd = new Random();
                rnd.NextBytes(bPassword);
                sPassword = Convert.ToBase64String(bPassword);
                sPassword = sPassword.Replace("=", string.Empty);
                iLength = sPassword.Length;

                if (!Regex.IsMatch(sPassword, sNewPasswordRegex))
                {
                    iIndex = rnd.Next(iLength - 3);
                    sTemp = sPassword.Substring(iIndex, 3);

                    iIndex = rnd.Next(1);
                    sFirst = cFirst[iIndex].ToString();
                    iIndex = rnd.Next(5);
                    sSecond = cSecond[iIndex].ToString();
                    iIndex = rnd.Next(9);
                    sThird = cThird[iIndex].ToString();
                    sReplace = sFirst + sSecond + sThird;

                    sPassword = sPassword.Replace(sTemp, sReplace);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Source.ToString() + " : " + exc.TargetSite.ToString() + " : " + exc.Message, "Strong Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return sPassword;
        }
    }
}
