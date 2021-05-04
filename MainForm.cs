using EFCoreExamApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFCoreExamApp
{
    public partial class MainForm : Form
    {
        #region Methods
        private void AddDataToAccountList(string inUserID, string inName, string inPassword, string inPhone, string inRole, string inRegDTM)
        {
            ListViewItem lvi;
            ListViewItem.ListViewSubItem lvsi;
            lvi = new ListViewItem();
            lvi.Text = inUserID;

            lvsi = new ListViewItem.ListViewSubItem();
            lvsi.Text = inName.TrimEnd();
            lvi.SubItems.Add(lvsi);

            lvsi = new ListViewItem.ListViewSubItem();
            lvsi.Text = inPassword.TrimEnd();
            lvi.SubItems.Add(lvsi);

            lvsi = new ListViewItem.ListViewSubItem();
            lvsi.Text = inPhone.TrimEnd();
            lvi.SubItems.Add(lvsi);

            lvsi = new ListViewItem.ListViewSubItem();
            lvsi.Text = inRole.TrimEnd();
            lvi.SubItems.Add(lvsi);

            lvsi = new ListViewItem.ListViewSubItem();
            lvsi.Text = inRegDTM.TrimEnd();
            lvi.SubItems.Add(lvsi);

            this.lvAccountLst.Items.Add(lvi);
        }

        private void InitControls()
        {
            this.cbxRole.SelectedIndex = 2;
        }

        private void LoadAccount()
        {
            TestSrvDbContext dbContext = new TestSrvDbContext();

            var accountList = from accounts in dbContext.Accounts
                              join accountRole in dbContext.AccountRoleDtl
                              on accounts.RoleID equals accountRole.RoleID
                              select new { UserID = accounts.UserID, Name = accounts.Name, Password = accounts.Password, Phone = accounts.Phone, RoleDesc = accountRole.RoleDesc, accounts.RegDTM };

            foreach (var item in accountList)
            {
                AddDataToAccountList(item.UserID, item.Name, item.Password, item.Phone, item.RoleDesc, item.RegDTM.ToLongDateString());
            }
        }
        #endregion

        public MainForm()
        {
            InitializeComponent();
            InitControls();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadAccount();
        }

        private void OnSignUp_Click(object sender, EventArgs e)
        {
            TestSrvDbContext dbContext = new TestSrvDbContext();

            var accounts = dbContext.Accounts.Where(p => p.UserID == this.tbxUserID.Text);
            
            if (accounts.ToList<TAccountMst>().Count > 0)
            {
                MessageBox.Show("UserID exists.");
                return;
            }

            TAccountMst accountMst = new TAccountMst
            {
                UserID = this.tbxUserID.Text,
                Name = this.tbxUserName.Text,
                Password = this.tbxPassword.Text,
                Phone = this.tbxPhone.Text,
                RoleID = this.cbxRole.SelectedIndex + 1,
                State = 0,
                RegDTM = DateTime.Now,
                ModDTM = DateTime.Now
            };

            dbContext.Accounts.Add(accountMst);
            dbContext.SaveChanges();

            LoadAccount();
        }
    }
}
