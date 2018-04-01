namespace HW_less2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnAddnew = new System.Windows.Forms.Button();
            this.txtBname = new System.Windows.Forms.TextBox();
            this.txtBsurname = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.btnLook = new System.Windows.Forms.Button();
            this.chBUkPr = new System.Windows.Forms.CheckBox();
            this.chBimport = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 153);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 87);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(119, 153);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnAddnew
            // 
            this.btnAddnew.Location = new System.Drawing.Point(200, 153);
            this.btnAddnew.Name = "btnAddnew";
            this.btnAddnew.Size = new System.Drawing.Size(75, 23);
            this.btnAddnew.TabIndex = 4;
            this.btnAddnew.Text = "Add new photo";
            this.btnAddnew.UseVisualStyleBackColor = true;
            this.btnAddnew.Click += new System.EventHandler(this.btnAddnew_Click);
            // 
            // txtBname
            // 
            this.txtBname.Location = new System.Drawing.Point(15, 25);
            this.txtBname.Name = "txtBname";
            this.txtBname.Size = new System.Drawing.Size(179, 20);
            this.txtBname.TabIndex = 5;
            // 
            // txtBsurname
            // 
            this.txtBsurname.Location = new System.Drawing.Point(15, 64);
            this.txtBsurname.Name = "txtBsurname";
            this.txtBsurname.Size = new System.Drawing.Size(179, 20);
            this.txtBsurname.TabIndex = 6;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 13);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Category";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(12, 48);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(44, 13);
            this.lblSurname.TabIndex = 8;
            this.lblSurname.Text = "Product";
            // 
            // btnLook
            // 
            this.btnLook.Location = new System.Drawing.Point(529, 198);
            this.btnLook.Name = "btnLook";
            this.btnLook.Size = new System.Drawing.Size(75, 23);
            this.btnLook.TabIndex = 9;
            this.btnLook.Text = "Look";
            this.btnLook.UseVisualStyleBackColor = true;
            this.btnLook.Click += new System.EventHandler(this.btnLook_Click);
            // 
            // chBUkPr
            // 
            this.chBUkPr.AutoSize = true;
            this.chBUkPr.Location = new System.Drawing.Point(15, 90);
            this.chBUkPr.Name = "chBUkPr";
            this.chBUkPr.Size = new System.Drawing.Size(114, 17);
            this.chBUkPr.TabIndex = 0;
            this.chBUkPr.Text = "ukraine production";
            this.chBUkPr.UseVisualStyleBackColor = true;
            // 
            // chBimport
            // 
            this.chBimport.AutoSize = true;
            this.chBimport.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chBimport.Location = new System.Drawing.Point(15, 113);
            this.chBimport.Name = "chBimport";
            this.chBimport.Size = new System.Drawing.Size(54, 17);
            this.chBimport.TabIndex = 1;
            this.chBimport.Text = "import";
            this.chBimport.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(370, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(392, 164);
            this.dataGridView1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 249);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLook);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtBsurname);
            this.Controls.Add(this.txtBname);
            this.Controls.Add(this.btnAddnew);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chBimport);
            this.Controls.Add(this.chBUkPr);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnAddnew;
        private System.Windows.Forms.TextBox txtBname;
        private System.Windows.Forms.TextBox txtBsurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Button btnLook;
        private System.Windows.Forms.CheckBox chBUkPr;
        private System.Windows.Forms.CheckBox chBimport;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

