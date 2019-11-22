namespace SwimTrackerApp
{
    partial class FormSwimmers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSwimmers));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtSwimmerPhone = new System.Windows.Forms.TextBox();
            this.lblSwimmerPhone = new System.Windows.Forms.Label();
            this.lblClubAddText = new System.Windows.Forms.Label();
            this.btnAddSwimmer = new System.Windows.Forms.Button();
            this.txtSwimmerPost = new System.Windows.Forms.TextBox();
            this.txtSwimmerProv = new System.Windows.Forms.TextBox();
            this.txtSwimmerCity = new System.Windows.Forms.TextBox();
            this.txtSwimmerStreet = new System.Windows.Forms.TextBox();
            this.txtSwimmerName = new System.Windows.Forms.TextBox();
            this.lblSwimmerPost = new System.Windows.Forms.Label();
            this.lblSwimmerProv = new System.Windows.Forms.Label();
            this.lblSwimmerCity = new System.Windows.Forms.Label();
            this.lblSwimmerStreet = new System.Windows.Forms.Label();
            this.lblSwimmerDOB = new System.Windows.Forms.Label();
            this.lblSwimmerName = new System.Windows.Forms.Label();
            this.btnSaveSwimmers = new System.Windows.Forms.Button();
            this.btnLoadSwimmers = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lsbSwimmers = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblSwimmerInfo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Swimmers Manager";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpDOB);
            this.groupBox1.Controls.Add(this.txtSwimmerPhone);
            this.groupBox1.Controls.Add(this.lblSwimmerPhone);
            this.groupBox1.Controls.Add(this.lblClubAddText);
            this.groupBox1.Controls.Add(this.btnAddSwimmer);
            this.groupBox1.Controls.Add(this.txtSwimmerPost);
            this.groupBox1.Controls.Add(this.txtSwimmerProv);
            this.groupBox1.Controls.Add(this.txtSwimmerCity);
            this.groupBox1.Controls.Add(this.txtSwimmerStreet);
            this.groupBox1.Controls.Add(this.txtSwimmerName);
            this.groupBox1.Controls.Add(this.lblSwimmerPost);
            this.groupBox1.Controls.Add(this.lblSwimmerProv);
            this.groupBox1.Controls.Add(this.lblSwimmerCity);
            this.groupBox1.Controls.Add(this.lblSwimmerStreet);
            this.groupBox1.Controls.Add(this.lblSwimmerDOB);
            this.groupBox1.Controls.Add(this.lblSwimmerName);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 365);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Swimmer";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(137, 89);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(231, 22);
            this.dtpDOB.TabIndex = 15;
            // 
            // txtSwimmerPhone
            // 
            this.txtSwimmerPhone.Location = new System.Drawing.Point(137, 267);
            this.txtSwimmerPhone.Name = "txtSwimmerPhone";
            this.txtSwimmerPhone.Size = new System.Drawing.Size(231, 22);
            this.txtSwimmerPhone.TabIndex = 14;
            // 
            // lblSwimmerPhone
            // 
            this.lblSwimmerPhone.AutoSize = true;
            this.lblSwimmerPhone.Location = new System.Drawing.Point(31, 270);
            this.lblSwimmerPhone.Name = "lblSwimmerPhone";
            this.lblSwimmerPhone.Size = new System.Drawing.Size(45, 17);
            this.lblSwimmerPhone.TabIndex = 13;
            this.lblSwimmerPhone.Text = "Phone";
            // 
            // lblClubAddText
            // 
            this.lblClubAddText.AutoSize = true;
            this.lblClubAddText.Location = new System.Drawing.Point(53, 326);
            this.lblClubAddText.Name = "lblClubAddText";
            this.lblClubAddText.Size = new System.Drawing.Size(0, 17);
            this.lblClubAddText.TabIndex = 1;
            // 
            // btnAddSwimmer
            // 
            this.btnAddSwimmer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSwimmer.Location = new System.Drawing.Point(87, 306);
            this.btnAddSwimmer.Name = "btnAddSwimmer";
            this.btnAddSwimmer.Size = new System.Drawing.Size(206, 28);
            this.btnAddSwimmer.TabIndex = 12;
            this.btnAddSwimmer.Text = "Add Swimmer";
            this.btnAddSwimmer.UseVisualStyleBackColor = true;
            this.btnAddSwimmer.Click += new System.EventHandler(this.btnAddSwimmer_Click);
            // 
            // txtSwimmerPost
            // 
            this.txtSwimmerPost.Location = new System.Drawing.Point(137, 229);
            this.txtSwimmerPost.Name = "txtSwimmerPost";
            this.txtSwimmerPost.Size = new System.Drawing.Size(231, 22);
            this.txtSwimmerPost.TabIndex = 11;
            // 
            // txtSwimmerProv
            // 
            this.txtSwimmerProv.Location = new System.Drawing.Point(137, 194);
            this.txtSwimmerProv.Name = "txtSwimmerProv";
            this.txtSwimmerProv.Size = new System.Drawing.Size(231, 22);
            this.txtSwimmerProv.TabIndex = 10;
            // 
            // txtSwimmerCity
            // 
            this.txtSwimmerCity.Location = new System.Drawing.Point(137, 159);
            this.txtSwimmerCity.Name = "txtSwimmerCity";
            this.txtSwimmerCity.Size = new System.Drawing.Size(231, 22);
            this.txtSwimmerCity.TabIndex = 9;
            // 
            // txtSwimmerStreet
            // 
            this.txtSwimmerStreet.Location = new System.Drawing.Point(137, 126);
            this.txtSwimmerStreet.Name = "txtSwimmerStreet";
            this.txtSwimmerStreet.Size = new System.Drawing.Size(231, 22);
            this.txtSwimmerStreet.TabIndex = 8;
            // 
            // txtSwimmerName
            // 
            this.txtSwimmerName.Location = new System.Drawing.Point(137, 46);
            this.txtSwimmerName.Name = "txtSwimmerName";
            this.txtSwimmerName.Size = new System.Drawing.Size(231, 22);
            this.txtSwimmerName.TabIndex = 6;
            // 
            // lblSwimmerPost
            // 
            this.lblSwimmerPost.AutoSize = true;
            this.lblSwimmerPost.Location = new System.Drawing.Point(31, 232);
            this.lblSwimmerPost.Name = "lblSwimmerPost";
            this.lblSwimmerPost.Size = new System.Drawing.Size(80, 17);
            this.lblSwimmerPost.TabIndex = 5;
            this.lblSwimmerPost.Text = "Postal Code";
            // 
            // lblSwimmerProv
            // 
            this.lblSwimmerProv.AutoSize = true;
            this.lblSwimmerProv.Location = new System.Drawing.Point(31, 197);
            this.lblSwimmerProv.Name = "lblSwimmerProv";
            this.lblSwimmerProv.Size = new System.Drawing.Size(61, 17);
            this.lblSwimmerProv.TabIndex = 4;
            this.lblSwimmerProv.Text = "Province";
            // 
            // lblSwimmerCity
            // 
            this.lblSwimmerCity.AutoSize = true;
            this.lblSwimmerCity.Location = new System.Drawing.Point(31, 162);
            this.lblSwimmerCity.Name = "lblSwimmerCity";
            this.lblSwimmerCity.Size = new System.Drawing.Size(31, 17);
            this.lblSwimmerCity.TabIndex = 3;
            this.lblSwimmerCity.Text = "City";
            // 
            // lblSwimmerStreet
            // 
            this.lblSwimmerStreet.AutoSize = true;
            this.lblSwimmerStreet.Location = new System.Drawing.Point(31, 129);
            this.lblSwimmerStreet.Name = "lblSwimmerStreet";
            this.lblSwimmerStreet.Size = new System.Drawing.Size(45, 17);
            this.lblSwimmerStreet.TabIndex = 2;
            this.lblSwimmerStreet.Text = "Street";
            // 
            // lblSwimmerDOB
            // 
            this.lblSwimmerDOB.AutoSize = true;
            this.lblSwimmerDOB.Location = new System.Drawing.Point(30, 89);
            this.lblSwimmerDOB.Name = "lblSwimmerDOB";
            this.lblSwimmerDOB.Size = new System.Drawing.Size(34, 17);
            this.lblSwimmerDOB.TabIndex = 1;
            this.lblSwimmerDOB.Text = "DOB";
            // 
            // lblSwimmerName
            // 
            this.lblSwimmerName.AutoSize = true;
            this.lblSwimmerName.Location = new System.Drawing.Point(30, 49);
            this.lblSwimmerName.Name = "lblSwimmerName";
            this.lblSwimmerName.Size = new System.Drawing.Size(44, 17);
            this.lblSwimmerName.TabIndex = 0;
            this.lblSwimmerName.Text = "Name";
            // 
            // btnSaveSwimmers
            // 
            this.btnSaveSwimmers.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSwimmers.Location = new System.Drawing.Point(27, 581);
            this.btnSaveSwimmers.Name = "btnSaveSwimmers";
            this.btnSaveSwimmers.Size = new System.Drawing.Size(238, 55);
            this.btnSaveSwimmers.TabIndex = 16;
            this.btnSaveSwimmers.Text = "Save Swimmers to File";
            this.btnSaveSwimmers.UseVisualStyleBackColor = true;
            this.btnSaveSwimmers.Click += new System.EventHandler(this.btnSaveSwimmers_Click);
            // 
            // btnLoadSwimmers
            // 
            this.btnLoadSwimmers.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadSwimmers.Location = new System.Drawing.Point(27, 493);
            this.btnLoadSwimmers.Name = "btnLoadSwimmers";
            this.btnLoadSwimmers.Size = new System.Drawing.Size(238, 55);
            this.btnLoadSwimmers.TabIndex = 15;
            this.btnLoadSwimmers.Text = "Load Swimmers from File";
            this.btnLoadSwimmers.UseVisualStyleBackColor = true;
            this.btnLoadSwimmers.Click += new System.EventHandler(this.btnLoadSwimmers_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lsbSwimmers);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(457, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 509);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Swimmers";
            // 
            // lsbSwimmers
            // 
            this.lsbSwimmers.FormattingEnabled = true;
            this.lsbSwimmers.ItemHeight = 17;
            this.lsbSwimmers.Location = new System.Drawing.Point(7, 34);
            this.lsbSwimmers.Name = "lsbSwimmers";
            this.lsbSwimmers.Size = new System.Drawing.Size(272, 463);
            this.lsbSwimmers.TabIndex = 0;
            this.lsbSwimmers.SelectedIndexChanged += new System.EventHandler(this.lsbSwimmers_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblSwimmerInfo);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(780, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(204, 681);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Swimmer Info";
            // 
            // lblSwimmerInfo
            // 
            this.lblSwimmerInfo.AutoSize = true;
            this.lblSwimmerInfo.Location = new System.Drawing.Point(21, 34);
            this.lblSwimmerInfo.Name = "lblSwimmerInfo";
            this.lblSwimmerInfo.Size = new System.Drawing.Size(0, 17);
            this.lblSwimmerInfo.TabIndex = 0;
            // 
            // FormSwimmers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(984, 681);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSaveSwimmers);
            this.Controls.Add(this.btnLoadSwimmers);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSwimmers";
            this.Text = "Swimmers Manager";
            this.Load += new System.EventHandler(this.FormSwimmers_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblClubAddText;
        private System.Windows.Forms.Button btnAddSwimmer;
        private System.Windows.Forms.TextBox txtSwimmerPost;
        private System.Windows.Forms.TextBox txtSwimmerProv;
        private System.Windows.Forms.TextBox txtSwimmerCity;
        private System.Windows.Forms.TextBox txtSwimmerStreet;
        private System.Windows.Forms.TextBox txtSwimmerName;
        private System.Windows.Forms.Label lblSwimmerPost;
        private System.Windows.Forms.Label lblSwimmerProv;
        private System.Windows.Forms.Label lblSwimmerCity;
        private System.Windows.Forms.Label lblSwimmerStreet;
        private System.Windows.Forms.Label lblSwimmerDOB;
        private System.Windows.Forms.Label lblSwimmerName;
        private System.Windows.Forms.Button btnSaveSwimmers;
        private System.Windows.Forms.Button btnLoadSwimmers;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lsbSwimmers;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox txtSwimmerPhone;
        private System.Windows.Forms.Label lblSwimmerPhone;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblSwimmerInfo;
    }
}