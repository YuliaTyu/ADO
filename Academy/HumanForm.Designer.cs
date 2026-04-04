namespace Academy
{
    partial class HumanForm
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
            this.labelLastName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.rtbLastName = new System.Windows.Forms.RichTextBox();
            this.rtbFirstName = new System.Windows.Forms.RichTextBox();
            this.rtbMiddleName = new System.Windows.Forms.RichTextBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.buttonPhoto = new System.Windows.Forms.Button();
            this.rtbEmail = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbPhone = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLastName.Location = new System.Drawing.Point(55, 84);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(73, 18);
            this.labelLastName.TabIndex = 0;
            this.labelLastName.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(102, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirstName.Location = new System.Drawing.Point(90, 120);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(38, 18);
            this.labelFirstName.TabIndex = 2;
            this.labelFirstName.Text = "Имя";
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMiddleName.Location = new System.Drawing.Point(53, 159);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(75, 18);
            this.labelMiddleName.TabIndex = 3;
            this.labelMiddleName.Text = "Отчество";
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBirthDate.Location = new System.Drawing.Point(12, 194);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(116, 18);
            this.labelBirthDate.TabIndex = 4;
            this.labelBirthDate.Text = "Дата рождения";
            // 
            // rtbLastName
            // 
            this.rtbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbLastName.Location = new System.Drawing.Point(134, 71);
            this.rtbLastName.Multiline = false;
            this.rtbLastName.Name = "rtbLastName";
            this.rtbLastName.Size = new System.Drawing.Size(356, 31);
            this.rtbLastName.TabIndex = 5;
            this.rtbLastName.Text = "";
            // 
            // rtbFirstName
            // 
            this.rtbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbFirstName.Location = new System.Drawing.Point(134, 108);
            this.rtbFirstName.Multiline = false;
            this.rtbFirstName.Name = "rtbFirstName";
            this.rtbFirstName.Size = new System.Drawing.Size(356, 31);
            this.rtbFirstName.TabIndex = 6;
            this.rtbFirstName.Text = "";
            // 
            // rtbMiddleName
            // 
            this.rtbMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbMiddleName.Location = new System.Drawing.Point(134, 145);
            this.rtbMiddleName.Multiline = false;
            this.rtbMiddleName.Name = "rtbMiddleName";
            this.rtbMiddleName.Size = new System.Drawing.Size(356, 33);
            this.rtbMiddleName.TabIndex = 7;
            this.rtbMiddleName.Text = "";
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDate.Location = new System.Drawing.Point(134, 184);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(200, 31);
            this.dtpBirthDate.TabIndex = 8;
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.Location = new System.Drawing.Point(568, 24);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(210, 273);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPhoto.TabIndex = 9;
            this.pictureBoxPhoto.TabStop = false;
            this.pictureBoxPhoto.Click += new System.EventHandler(this.pictureBoxPhoto_Click);
            // 
            // buttonPhoto
            // 
            this.buttonPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPhoto.Location = new System.Drawing.Point(616, 303);
            this.buttonPhoto.Name = "buttonPhoto";
            this.buttonPhoto.Size = new System.Drawing.Size(119, 36);
            this.buttonPhoto.TabIndex = 10;
            this.buttonPhoto.Text = "Обзор";
            this.buttonPhoto.UseVisualStyleBackColor = true;
            // 
            // rtbEmail
            // 
            this.rtbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbEmail.Location = new System.Drawing.Point(134, 235);
            this.rtbEmail.Multiline = false;
            this.rtbEmail.Name = "rtbEmail";
            this.rtbEmail.Size = new System.Drawing.Size(356, 33);
            this.rtbEmail.TabIndex = 11;
            this.rtbEmail.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(73, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Email";
            // 
            // rtbPhone
            // 
            this.rtbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbPhone.Location = new System.Drawing.Point(134, 274);
            this.rtbPhone.Multiline = false;
            this.rtbPhone.Name = "rtbPhone";
            this.rtbPhone.Size = new System.Drawing.Size(356, 33);
            this.rtbPhone.TabIndex = 13;
            this.rtbPhone.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(46, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Телефон";
            // 
            // HumanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 422);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtbPhone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbEmail);
            this.Controls.Add(this.buttonPhoto);
            this.Controls.Add(this.pictureBoxPhoto);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.rtbMiddleName);
            this.Controls.Add(this.rtbFirstName);
            this.Controls.Add(this.rtbLastName);
            this.Controls.Add(this.labelBirthDate);
            this.Controls.Add(this.labelMiddleName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelLastName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "HumanForm";
            this.Text = "Human";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelMiddleName;
        protected System.Windows.Forms.Label labelBirthDate;
        public System.Windows.Forms.Button buttonPhoto;
        protected System.Windows.Forms.RichTextBox rtbLastName;
        protected System.Windows.Forms.RichTextBox rtbFirstName;
        protected System.Windows.Forms.RichTextBox rtbMiddleName;
        protected System.Windows.Forms.DateTimePicker dtpBirthDate;
        protected System.Windows.Forms.PictureBox pictureBoxPhoto;
        protected System.Windows.Forms.RichTextBox rtbEmail;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.RichTextBox rtbPhone;
        protected System.Windows.Forms.Label label3;
    }
}