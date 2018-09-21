using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Calcium_RMS.Text;
namespace Calcium_RMS
{
    public partial class ConnStringFrm : Form
    {
        bool ConnStringOK = false;
        public ConnStringFrm()
        {
            InitializeComponent();
        }

        private void LoadConnString()
        {
            ConnStringTxtBox.Text = ConfigurationHelper.GetConnString();
        }

        private void TestBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ConnStringTxtBox.Text.Trim() !="")
                {
                    SqlConnection aTestCon = new SqlConnection(ConnStringTxtBox.Text);
                    aTestCon.Open();
                    aTestCon.Close();
                    ConnStringOK = true;
                    MessageBox.Show(MsgTxt.CheckedSuccesfullyTxt, MsgTxt.CheckedSuccesfullyTxt, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    ConnStringOK = false;
                }
            }
            catch (Exception ex)
            {
                ConnStringOK = false;
                MessageBox.Show("Connection String Is Bad" + ex.Message, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (ConnStringOK)
            {
                ConfigurationHelper.UpdateConnString(ConnStringTxtBox.Text);
                MessageBox.Show(MsgTxt.UpdateSuccessfully, MsgTxt.UpdateSuccessfully, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please test Connection String First", MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ConnStringFrm_Load(object sender, EventArgs e)
        {
            LoadConnString();
        }

        private void ConnStringTxtBox_TextChanged(object sender, EventArgs e)
        {
            ConnStringOK = false;
        }
    }
}
