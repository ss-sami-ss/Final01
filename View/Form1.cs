﻿using System;
using System.Drawing;
using System.Windows.Forms;
using ViewModel;


namespace View
{
    public partial class Form1 : Form
    {
        #region [- ctor -]

        public Form1()
        {
            InitializeComponent();
            Ref_PersonViewModel = new PersonViewModel();
        }

        #endregion

        #region [- props -]

        public PersonViewModel Ref_PersonViewModel { get; set; }
  
        #endregion

        #region [- Form1_Load -]

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(980, 415);
            personTableAdapter.Fill(contactDataSet.Person);
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

        #region [- Clear() -]
        public void Clear()
        {
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
            Ref_PersonViewModel.Save(txtFirstName.Text, txtLastName.Text, txtIdentityCode.Text,
            txtTelNumber.Text, txtPhoneNumber.Text);
            FillGrid();
            MessageBox.Show("It's Done!");
        }

        #endregion

        #region [- btnExit_Click -]

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region [- btnDelete_Click -]

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            Ref_PersonViewModel.Delete(Ref_PersonViewModel.Person.Id,Ref_PersonViewModel.Person.FirstName,Ref_PersonViewModel.Person.LastName,Ref_PersonViewModel.Person.IdentityCode,Ref_PersonViewModel.Person.TelephoneNumber,Ref_PersonViewModel.Person.PhoneNumber);
            FillGrid();
        }

        #endregion

        #region [- dgvPerson_CellDoubleClick -]

        private void dgvPerson_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            Ref_PersonViewModel.Person.Id = Convert.ToInt32(dgvPerson.CurrentRow?.Cells[0].Value);
            Ref_PersonViewModel.Person.FirstName = dgvPerson.CurrentRow?.Cells[3].FormattedValue?.ToString();
            Ref_PersonViewModel.Person.LastName = dgvPerson.CurrentRow?.Cells[4].FormattedValue?.ToString();
            Ref_PersonViewModel.Person.PhoneNumber = dgvPerson.CurrentRow?.Cells[1].FormattedValue?.ToString();
            Ref_PersonViewModel.Person.TelephoneNumber = dgvPerson.CurrentRow?.Cells[2].FormattedValue?.ToString();
            Ref_PersonViewModel.Person.IdentityCode = dgvPerson.CurrentRow?.Cells[5].FormattedValue?.ToString();

            txtFirstName.Text = Ref_PersonViewModel.Person.FirstName;
            txtLastName.Text = Ref_PersonViewModel.Person.LastName;
            txtPhoneNumber.Text = Ref_PersonViewModel.Person.PhoneNumber;
            txtTelNumber.Text = Ref_PersonViewModel.Person.TelephoneNumber;
            txtIdentityCode.Text = Ref_PersonViewModel.Person.IdentityCode;
        } 
        #endregion

        #region [- btnEdit_Click -]
        private void btnEdit_Click(object sender, EventArgs e)
        {
            Ref_PersonViewModel.Edit(Ref_PersonViewModel.Person.Id, txtFirstName.Text, txtLastName.Text, txtIdentityCode.Text, txtTelNumber.Text, txtPhoneNumber.Text);
            FillGrid();
            MessageBox.Show("You Contact is Update.");
        }
        #endregion

        #region [- dgvPerson_CellMouseClick -]
        private void dgvPerson_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
        #endregion

        #region [- btnClear_Click -]
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        #endregion

        #region [- txtIdentityCode_TextChanged -]
        private void txtIdentityCode_TextChanged(object sender, EventArgs e)
        {
            txtIdentityCode.MaxLength = 10;
            if (System.Text.RegularExpressions.Regex.IsMatch(txtIdentityCode.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtIdentityCode.Text = txtIdentityCode.Text.Remove(txtIdentityCode.Text.Length - 1);
            }
        } 
        #endregion

        #region [- txtTelNumber_TextChanged -]
        private void txtTelNumber_TextChanged(object sender, EventArgs e)
        {
            txtTelNumber.MaxLength = 11;
            if (System.Text.RegularExpressions.Regex.IsMatch(txtTelNumber.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtTelNumber.Text = txtTelNumber.Text.Remove(txtTelNumber.Text.Length - 1);
            }
        } 
        #endregion

        #region [- txtPhoneNumber_TextChanged -]
        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            txtPhoneNumber.MaxLength = 11;
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPhoneNumber.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtPhoneNumber.Text = txtPhoneNumber.Text.Remove(txtPhoneNumber.Text.Length - 1);
            }

            
        } 
        #endregion
    }
}