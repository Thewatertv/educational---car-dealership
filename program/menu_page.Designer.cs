
namespace DB_Car_Dealership
{
    partial class menu_page
    {

        public string get_index
        {

            get { return textBox_id_index.Text; }
            set { textBox_id_index.Text = value; }

        }


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu_page));
            this.label1 = new System.Windows.Forms.Label();
            this.label_FCS = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Charts = new System.Windows.Forms.GroupBox();
            this.button_Charts_by_model = new System.Windows.Forms.Button();
            this.button_Charts_by_month = new System.Windows.Forms.Button();
            this.textBox_id_index = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.Charts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(254, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Пользователь:";
            // 
            // label_FCS
            // 
            this.label_FCS.AutoSize = true;
            this.label_FCS.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_FCS.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_FCS.Location = new System.Drawing.Point(374, 9);
            this.label_FCS.Name = "label_FCS";
            this.label_FCS.Size = new System.Drawing.Size(103, 26);
            this.label_FCS.TabIndex = 1;
            this.label_FCS.Text = "label_FCS";
            this.label_FCS.Click += new System.EventHandler(this.label_FCS_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Добавить пользователя";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(101, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Пользователи";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Список пользователей";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Charts
            // 
            this.Charts.Controls.Add(this.button_Charts_by_model);
            this.Charts.Controls.Add(this.button_Charts_by_month);
            this.Charts.Location = new System.Drawing.Point(407, 61);
            this.Charts.Name = "Charts";
            this.Charts.Size = new System.Drawing.Size(200, 100);
            this.Charts.TabIndex = 5;
            this.Charts.TabStop = false;
            this.Charts.Text = "Графики";
            // 
            // button_Charts_by_model
            // 
            this.button_Charts_by_model.Location = new System.Drawing.Point(24, 58);
            this.button_Charts_by_model.Name = "button_Charts_by_model";
            this.button_Charts_by_model.Size = new System.Drawing.Size(147, 23);
            this.button_Charts_by_model.TabIndex = 4;
            this.button_Charts_by_model.Text = "График по моделям";
            this.button_Charts_by_model.UseVisualStyleBackColor = true;
            this.button_Charts_by_model.Click += new System.EventHandler(this.button_Charts_by_model_Click);
            // 
            // button_Charts_by_month
            // 
            this.button_Charts_by_month.Location = new System.Drawing.Point(24, 29);
            this.button_Charts_by_month.Name = "button_Charts_by_month";
            this.button_Charts_by_month.Size = new System.Drawing.Size(147, 23);
            this.button_Charts_by_month.TabIndex = 3;
            this.button_Charts_by_month.Text = "График по месяцам";
            this.button_Charts_by_month.UseVisualStyleBackColor = true;
            this.button_Charts_by_month.Click += new System.EventHandler(this.button_Charts_by_month_Click);
            // 
            // textBox_id_index
            // 
            this.textBox_id_index.Location = new System.Drawing.Point(12, 2);
            this.textBox_id_index.Name = "textBox_id_index";
            this.textBox_id_index.Size = new System.Drawing.Size(100, 20);
            this.textBox_id_index.TabIndex = 6;
            this.textBox_id_index.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(659, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(277, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(207, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Продажи";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(15, 66);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(176, 28);
            this.button4.TabIndex = 5;
            this.button4.Text = "Новая продажа";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 32);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 28);
            this.button3.TabIndex = 4;
            this.button3.Text = "Список продаж";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // menu_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 333);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox_id_index);
            this.Controls.Add(this.Charts);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_FCS);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "menu_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menu_page";
            this.Load += new System.EventHandler(this.menu_page_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.Charts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_FCS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox Charts;
        private System.Windows.Forms.Button button_Charts_by_model;
        private System.Windows.Forms.Button button_Charts_by_month;
        public System.Windows.Forms.TextBox textBox_id_index;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}