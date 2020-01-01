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

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }
        private void FillGrid()
        {
            dgvPerson.DataSource = Ref_PersonViewModel.FillGrid();
        }
    }
}
