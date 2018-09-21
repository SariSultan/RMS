using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Calcium_RMS.Entities;
using Calcium_RMS.Management;
using Calcium_RMS.Text;

namespace Calcium_RMS
{
    public partial class ListUsers : Form
    {
        public ListUsers()
        {
            InitializeComponent();
            TranslateUI();
        }

        private void ListUsersBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int RowNum = 0;
                DataTable UsersTable = UsersMgmt.SelectAllUsers();
                if (UsersTable == null)
                {
                    MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [ListUsers:DB-ERROR  UsersTable=null] \n  \n", MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (UsersTable.Rows.Count > 0)
                {
                    RowNum = 0;
                    ListUsersDgView.Rows.Clear();
                    foreach (DataRow r in UsersTable.Rows)
                    {
                        ListUsersDgView.Rows.Add();
                        ListUsersDgView.Rows[RowNum].Cells["Namecol"].Value = UsersTable.Rows[RowNum]["Name"].ToString();
                        ListUsersDgView.Rows[RowNum].Cells["Address"].Value = UsersTable.Rows[RowNum]["Address"].ToString();
                        ListUsersDgView.Rows[RowNum].Cells["Phone1"].Value = UsersTable.Rows[RowNum]["Phone1"].ToString();
                        ListUsersDgView.Rows[RowNum].Cells["Phone2"].Value = UsersTable.Rows[RowNum]["Phone2"].ToString();
                        ListUsersDgView.Rows[RowNum].Cells["UserName"].Value = UsersTable.Rows[RowNum]["UserName"].ToString();
                        ListUsersDgView.Rows[RowNum].Cells["Password"].Value = UsersTable.Rows[RowNum]["Password"].ToString();
                        ListUsersDgView.Rows[RowNum].Cells["Description"].Value = UsersTable.Rows[RowNum]["Description"].ToString();
                        RowNum++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [ListUsersBtn_Click] \n Exception: \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void ListUsersDgView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.EditUsers) == EventStatus.Permit)
                {
                    Users aUserDataRow = new Users();
                    aUserDataRow.User_Name = ListUsersDgView.Rows[e.RowIndex].Cells["Namecol"].Value.ToString();
                    aUserDataRow.User_Address = ListUsersDgView.Rows[e.RowIndex].Cells["Address"].Value.ToString();
                    aUserDataRow.User_Phone1 = ListUsersDgView.Rows[e.RowIndex].Cells["Phone1"].Value.ToString();
                    aUserDataRow.User_Phone2 = ListUsersDgView.Rows[e.RowIndex].Cells["Phone2"].Value.ToString();
                    aUserDataRow.User_UserName = ListUsersDgView.Rows[e.RowIndex].Cells["UserName"].Value.ToString();
                    aUserDataRow.User_Password = ListUsersDgView.Rows[e.RowIndex].Cells["Password"].Value.ToString();
                    aUserDataRow.User_Description = ListUsersDgView.Rows[e.RowIndex].Cells["Description"].Value.ToString();
                    EditUser aEditUser = new EditUser();
                    aEditUser.ControlBox = true;
                    aEditUser.MaximizeBox = true;
                    aEditUser.FormBorderStyle = FormBorderStyle.Fixed3D;
                    aEditUser.Show();
                    aEditUser.UpdateVariables(ListUsersDgView.Rows[e.RowIndex].Cells["UserName"].Value.ToString());
                }
                else
                {
                    MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [ListUsers:ListUsersDgView_CellDoubleClick()] \n Exception: \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        private void TranslateUI()
        {
            try
            {
                this.Text = FormsNames.ListUsersFormName;

                ListUsersBtn.Text = UiText.LstUsrListUsersBtn;
                ListUsersLbl.Text = UiText.LstUsrListUsersLbl;
            }
            catch (Exception ex)
            {

                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [TranslateUI] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        //Garbage Collector
        protected override void OnClosed(EventArgs e)
        {
            try
            {
                foreach (object obj in this.Controls)
                {
                    if (obj is IDisposable)
                    {
                        (obj as IDisposable).Dispose();
                    }
                }
                base.OnClosed(e);
                base.Dispose();
                this.Dispose();
                GC.Collect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [OnClosed] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }

    }
}
