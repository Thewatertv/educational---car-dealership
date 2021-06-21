
namespace DB_Car_Dealership
{
    partial class Sale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sale));
            this.comboBox_data = new System.Windows.Forms.ComboBox();
            this.comboBox_castomer = new System.Windows.Forms.ComboBox();
            this.comboBox_staff = new System.Windows.Forms.ComboBox();
            this.comboBox_car = new System.Windows.Forms.ComboBox();
            this.lada_AvtosalonDataSet = new DB_Car_Dealership.Lada_AvtosalonDataSet();
            this.ladaAvtosalonDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffTableAdapter = new DB_Car_Dealership.Lada_AvtosalonDataSetTableAdapters.StaffTableAdapter();
            this.lada_AvtosalonDataSet3 = new DB_Car_Dealership.Lada_AvtosalonDataSet3();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new DB_Car_Dealership.Lada_AvtosalonDataSet3TableAdapters.CustomerTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lada_AvtosalonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladaAvtosalonDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lada_AvtosalonDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_data
            // 
            this.comboBox_data.FormattingEnabled = true;
            this.comboBox_data.Items.AddRange(new object[] {
            "Январь",
            "Февраль",
            "Март",
            "Апрель",
            "Март",
            "Июнь",
            "Июль",
            "Август",
            "Сентябрь",
            "Октябрь",
            "Ноябрь",
            "Декабрь"});
            this.comboBox_data.Location = new System.Drawing.Point(159, 110);
            this.comboBox_data.Name = "comboBox_data";
            this.comboBox_data.Size = new System.Drawing.Size(121, 21);
            this.comboBox_data.TabIndex = 0;
            // 
            // comboBox_castomer
            // 
            this.comboBox_castomer.FormattingEnabled = true;
            this.comboBox_castomer.Location = new System.Drawing.Point(159, 27);
            this.comboBox_castomer.Name = "comboBox_castomer";
            this.comboBox_castomer.Size = new System.Drawing.Size(121, 21);
            this.comboBox_castomer.TabIndex = 1;
            // 
            // comboBox_staff
            // 
            this.comboBox_staff.FormattingEnabled = true;
            this.comboBox_staff.Location = new System.Drawing.Point(159, 70);
            this.comboBox_staff.Name = "comboBox_staff";
            this.comboBox_staff.Size = new System.Drawing.Size(121, 21);
            this.comboBox_staff.TabIndex = 2;
            // 
            // comboBox_car
            // 
            this.comboBox_car.FormattingEnabled = true;
            this.comboBox_car.Location = new System.Drawing.Point(159, 153);
            this.comboBox_car.Name = "comboBox_car";
            this.comboBox_car.Size = new System.Drawing.Size(121, 21);
            this.comboBox_car.TabIndex = 3;
            // 
            // lada_AvtosalonDataSet
            // 
            this.lada_AvtosalonDataSet.DataSetName = "Lada_AvtosalonDataSet";
            this.lada_AvtosalonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ladaAvtosalonDataSetBindingSource
            // 
            this.ladaAvtosalonDataSetBindingSource.DataSource = this.lada_AvtosalonDataSet;
            this.ladaAvtosalonDataSetBindingSource.Position = 0;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.ladaAvtosalonDataSetBindingSource;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // lada_AvtosalonDataSet3
            // 
            this.lada_AvtosalonDataSet3.DataSetName = "Lada_AvtosalonDataSet3";
            this.lada_AvtosalonDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.lada_AvtosalonDataSet3;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Менеджер по продажам";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Покупатель";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Месяц покупки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Автомобиль";
            // 
            // Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 250);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox_car);
            this.Controls.Add(this.comboBox_staff);
            this.Controls.Add(this.comboBox_castomer);
            this.Controls.Add(this.comboBox_data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sale";
            this.Load += new System.EventHandler(this.Sale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lada_AvtosalonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladaAvtosalonDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lada_AvtosalonDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_data;
        private System.Windows.Forms.ComboBox comboBox_castomer;
        private System.Windows.Forms.ComboBox comboBox_staff;
        private System.Windows.Forms.ComboBox comboBox_car;
        private Lada_AvtosalonDataSet lada_AvtosalonDataSet;
        private System.Windows.Forms.BindingSource ladaAvtosalonDataSetBindingSource;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private Lada_AvtosalonDataSetTableAdapters.StaffTableAdapter staffTableAdapter;
        private Lada_AvtosalonDataSet3 lada_AvtosalonDataSet3;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private Lada_AvtosalonDataSet3TableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}