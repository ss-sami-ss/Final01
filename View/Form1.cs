using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class Form1 : Form
    {
        #region [- ctor -]
        public Form1()
        {
            InitializeComponent();
            Ref_PersonViewModel = new ViewModel.PersonViewModel();
        }
        #endregion

        #region [- props -]
        public ViewModel.PersonViewModel Ref_PersonViewModel { get; set; } 
        #endregion

        #region [- Form1_Load -]
        private void Form1_Load(object sender, EventArgs e)
        {
            FillGrid();
        }
        #endregion

        #region [- btnRefresh_Click -]
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FillGrid();
        } 
        #endregion

        #region [- FillGrid() -]
        private void FillGrid()
        {
            dgvPerson.DataSource = Ref_PersonViewModel.FillGrid();
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtIdentityCode.Text = string.Empty;
            txtTelNumber.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;
            txtFirstName.Focus();
        }

        #endregion

        #region [- btnSave_Click -]
        private void btnSave_Click(object sender, EventArgs e)
        {
            Ref_PersonViewModel.Save(txtFirstName.Text, txtLastName.Text,txtIdentityCode.Text,
                txtTelNumber.Text,txtPhoneNumber.Text);
            MessageBox.Show("Your Contact Are Expanded");
        } 
        #endregion
    }
}
