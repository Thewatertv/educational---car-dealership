
namespace DB_Car_Dealership
{
    partial class List_users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(List_users));
            this.dataGridView_staff = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middlenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.staffBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ladaAvtosalonDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lada_AvtosalonDataSet2 = new DB_Car_Dealership.Lada_AvtosalonDataSet2();
            this.change = new System.Windows.Forms.Button();
            this.lada_AvtosalonDataSet = new DB_Car_Dealership.Lada_AvtosalonDataSet();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffTableAdapter = new DB_Car_Dealership.Lada_AvtosalonDataSetTableAdapters.StaffTableAdapter();
            this.staffBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.staffTableAdapter1 = new DB_Car_Dealership.Lada_AvtosalonDataSet2TableAdapters.StaffTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_staff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladaAvtosalonDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lada_AvtosalonDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lada_AvtosalonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_staff
            // 
            this.dataGridView_staff.AllowUserToAddRows = false;
            this.dataGridView_staff.AutoGenerateColumns = false;
            this.dataGridView_staff.ColumnHeadersHeight = 65;
            this.dataGridView_staff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.middlenameDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.fotoDataGridViewImageColumn});
            this.dataGridView_staff.DataSource = this.staffBindingSource1;
            this.dataGridView_staff.Location = new System.Drawing.Point(46, 28);
            this.dataGridView_staff.Name = "dataGridView_staff";
            this.dataGridView_staff.ReadOnly = true;
            this.dataGridView_staff.RowTemplate.Height = 50;
            this.dataGridView_staff.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_staff.Size = new System.Drawing.Size(746, 364);
            this.dataGridView_staff.TabIndex = 0;
            this.dataGridView_staff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_staff_CellClick);
            this.dataGridView_staff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_staff_CellContentClick);
            this.dataGridView_staff.Resize += new System.EventHandler(this.dataGridView_staff_Resize);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // middlenameDataGridViewTextBoxColumn
            // 
            this.middlenameDataGridViewTextBoxColumn.DataPropertyName = "Middle_name";
            this.middlenameDataGridViewTextBoxColumn.HeaderText = "Middle_name";
            this.middlenameDataGridViewTextBoxColumn.Name = "middlenameDataGridViewTextBoxColumn";
            this.middlenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fotoDataGridViewImageColumn
            // 
            this.fotoDataGridViewImageColumn.DataPropertyName = "foto";
            this.fotoDataGridViewImageColumn.HeaderText = "foto";
            this.fotoDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.fotoDataGridViewImageColumn.Name = "fotoDataGridViewImageColumn";
            this.fotoDataGridViewImageColumn.ReadOnly = true;
            // 
            // staffBindingSource1
            // 
            this.staffBindingSource1.DataMember = "Staff";
            this.staffBindingSource1.DataSource = this.ladaAvtosalonDataSet2BindingSource;
            // 
            // ladaAvtosalonDataSet2BindingSource
            // 
            this.ladaAvtosalonDataSet2BindingSource.DataSource = this.lada_AvtosalonDataSet2;
            this.ladaAvtosalonDataSet2BindingSource.Position = 0;
            // 
            // lada_AvtosalonDataSet2
            // 
            this.lada_AvtosalonDataSet2.DataSetName = "Lada_AvtosalonDataSet2";
            this.lada_AvtosalonDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // change
            // 
            this.change.Location = new System.Drawing.Point(374, 397);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(75, 23);
            this.change.TabIndex = 1;
            this.change.Text = "Изменить";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // lada_AvtosalonDataSet
            // 
            this.lada_AvtosalonDataSet.DataSetName = "Lada_AvtosalonDataSet";
            this.lada_AvtosalonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.lada_AvtosalonDataSet;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // staffBindingSource2
            // 
            this.staffBindingSource2.DataMember = "Staff";
            this.staffBindingSource2.DataSource = this.ladaAvtosalonDataSet2BindingSource;
            // 
            // staffTableAdapter1
            // 
            this.staffTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(569, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // List_users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 432);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.change);
            this.Controls.Add(this.dataGridView_staff);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "List_users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List_users";
            this.Activated += new System.EventHandler(this.List_users_Activated);
            this.Load += new System.EventHandler(this.List_users_Load);
            this.Enter += new System.EventHandler(this.List_users_Activated);
            this.Leave += new System.EventHandler(this.List_users_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_staff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladaAvtosalonDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lada_AvtosalonDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lada_AvtosalonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_staff;
        private System.Windows.Forms.Button change;
        private Lada_AvtosalonDataSet lada_AvtosalonDataSet;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private Lada_AvtosalonDataSetTableAdapters.StaffTableAdapter staffTableAdapter;
        private System.Windows.Forms.BindingSource ladaAvtosalonDataSet2BindingSource;
        private Lada_AvtosalonDataSet2 lada_AvtosalonDataSet2;
        private System.Windows.Forms.BindingSource staffBindingSource1;
        private Lada_AvtosalonDataSet2TableAdapters.StaffTableAdapter staffTableAdapter1;
        private System.Windows.Forms.BindingSource staffBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middlenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn fotoDataGridViewImageColumn;
        private System.Windows.Forms.Button button1;
    }
}