namespace View
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtIdentityCode = new System.Windows.Forms.TextBox();
            this.txtTelNumber = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.dgvPerson = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identityCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactDataSet = new View.ContactDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.personTableAdapter = new View.ContactDataSetTableAdapters.PersonTableAdapter();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(318, 376);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(141, 33);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(171, 376);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(141, 33);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(465, 376);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(141, 33);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(612, 376);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(141, 33);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(109, 56);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(156, 20);
            this.txtFirstName.TabIndex = 4;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(109, 112);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(156, 20);
            this.txtLastName.TabIndex = 5;
            // 
            // txtIdentityCode
            // 
            this.txtIdentityCode.Location = new System.Drawing.Point(109, 167);
            this.txtIdentityCode.Name = "txtIdentityCode";
            this.txtIdentityCode.Size = new System.Drawing.Size(156, 20);
            this.txtIdentityCode.TabIndex = 6;
            this.txtIdentityCode.TextChanged += new System.EventHandler(this.txtIdentityCode_TextChanged);
            // 
            // txtTelNumber
            // 
            this.txtTelNumber.Location = new System.Drawing.Point(109, 223);
            this.txtTelNumber.Name = "txtTelNumber";
            this.txtTelNumber.Size = new System.Drawing.Size(156, 20);
            this.txtTelNumber.TabIndex = 7;
            this.txtTelNumber.TextChanged += new System.EventHandler(this.txtTelNumber_TextChanged);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(109, 282);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(156, 20);
            this.txtPhoneNumber.TabIndex = 8;
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.txtPhoneNumber_TextChanged);
            // 
            // dgvPerson
            // 
            this.dgvPerson.AllowUserToOrderColumns = true;
            this.dgvPerson.AutoGenerateColumns = false;
            this.dgvPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.telephoneNumberDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.identityCodeDataGridViewTextBoxColumn});
            this.dgvPerson.DataSource = this.personBindingSource;
            this.dgvPerson.Location = new System.Drawing.Point(271, 56);
            this.dgvPerson.Name = "dgvPerson";
            this.dgvPerson.Size = new System.Drawing.Size(636, 246);
            this.dgvPerson.TabIndex = 9;
            this.dgvPerson.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPerson_CellDoubleClick);
            this.dgvPerson.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPerson_CellMouseClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // telephoneNumberDataGridViewTextBoxColumn
            // 
            this.telephoneNumberDataGridViewTextBoxColumn.DataPropertyName = "TelephoneNumber";
            this.telephoneNumberDataGridViewTextBoxColumn.HeaderText = "TelephoneNumber";
            this.telephoneNumberDataGridViewTextBoxColumn.Name = "telephoneNumberDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // identityCodeDataGridViewTextBoxColumn
            // 
            this.identityCodeDataGridViewTextBoxColumn.DataPropertyName = "IdentityCode";
            this.identityCodeDataGridViewTextBoxColumn.HeaderText = "IdentityCode";
            this.identityCodeDataGridViewTextBoxColumn.Name = "identityCodeDataGridViewTextBoxColumn";
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataMember = "Person";
            this.personBindingSource.DataSource = this.contactDataSet;
            // 
            // contactDataSet
            // 
            this.contactDataSet.DataSetName = "ContactDataSet";
            this.contactDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "FirstName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "LastName:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "IdentityCode:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "TelephoneNumber:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "PhoneNumber:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(759, 376);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(141, 33);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // personTableAdapter
            // 
            this.personTableAdapter.ClearBeforeFill = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(21, 376);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(144, 33);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPerson);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtTelNumber);
            this.Controls.Add(this.txtIdentityCode);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRefresh);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtIdentityCode;
        private System.Windows.Forms.TextBox txtTelNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.DataGridView dgvPerson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn identityCodeDataGridViewTextBoxColumn;
        private View.ContactDataSetTableAdapters.PersonTableAdapter personTableAdapter;
        private View.ContactDataSet contactDataSet;
        private System.Windows.Forms.Button btnClear;
    }
}

