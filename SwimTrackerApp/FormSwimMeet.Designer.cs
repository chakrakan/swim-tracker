namespace SwimTrackerApp
{
    partial class FormSwimMeet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSwimMeet));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.txtMeetName = new System.Windows.Forms.TextBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblMeetName = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lsbCourse = new System.Windows.Forms.ListBox();
            this.lblLanes = new System.Windows.Forms.Label();
            this.txtLanes = new System.Windows.Forms.TextBox();
            this.btnAddSwimMeet = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSeed = new System.Windows.Forms.Button();
            this.lsbSwimMeets = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lsbEvents = new System.Windows.Forms.ListBox();
            this.btnAssignEvent = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblMeetInfo = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Swim Meets Manager";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblError);
            this.groupBox1.Controls.Add(this.btnAddSwimMeet);
            this.groupBox1.Controls.Add(this.txtLanes);
            this.groupBox1.Controls.Add(this.lblLanes);
            this.groupBox1.Controls.Add(this.lsbCourse);
            this.groupBox1.Controls.Add(this.lblCourse);
            this.groupBox1.Controls.Add(this.dtpEnd);
            this.groupBox1.Controls.Add(this.lblEndDate);
            this.groupBox1.Controls.Add(this.dtpStart);
            this.groupBox1.Controls.Add(this.txtMeetName);
            this.groupBox1.Controls.Add(this.lblStartDate);
            this.groupBox1.Controls.Add(this.lblMeetName);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 413);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Swim Meet";
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(125, 84);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(119, 23);
            this.dtpStart.TabIndex = 19;
            // 
            // txtMeetName
            // 
            this.txtMeetName.Location = new System.Drawing.Point(125, 41);
            this.txtMeetName.Name = "txtMeetName";
            this.txtMeetName.Size = new System.Drawing.Size(119, 23);
            this.txtMeetName.TabIndex = 18;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(18, 84);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(73, 17);
            this.lblStartDate.TabIndex = 17;
            this.lblStartDate.Text = "Start Date";
            // 
            // lblMeetName
            // 
            this.lblMeetName.AutoSize = true;
            this.lblMeetName.Location = new System.Drawing.Point(18, 44);
            this.lblMeetName.Name = "lblMeetName";
            this.lblMeetName.Size = new System.Drawing.Size(48, 17);
            this.lblMeetName.TabIndex = 16;
            this.lblMeetName.Text = "Name";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(125, 125);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(119, 23);
            this.dtpEnd.TabIndex = 21;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(18, 130);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(68, 17);
            this.lblEndDate.TabIndex = 20;
            this.lblEndDate.Text = "End Date";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(18, 174);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(53, 17);
            this.lblCourse.TabIndex = 22;
            this.lblCourse.Text = "Course";
            // 
            // lsbCourse
            // 
            this.lsbCourse.FormattingEnabled = true;
            this.lsbCourse.ItemHeight = 17;
            this.lsbCourse.Items.AddRange(new object[] {
            "SCM",
            "SCY",
            "LCM"});
            this.lsbCourse.Location = new System.Drawing.Point(21, 212);
            this.lsbCourse.Name = "lsbCourse";
            this.lsbCourse.Size = new System.Drawing.Size(223, 55);
            this.lsbCourse.TabIndex = 23;
            // 
            // lblLanes
            // 
            this.lblLanes.AutoSize = true;
            this.lblLanes.Location = new System.Drawing.Point(18, 288);
            this.lblLanes.Name = "lblLanes";
            this.lblLanes.Size = new System.Drawing.Size(44, 17);
            this.lblLanes.TabIndex = 24;
            this.lblLanes.Text = "Lanes";
            // 
            // txtLanes
            // 
            this.txtLanes.Location = new System.Drawing.Point(125, 285);
            this.txtLanes.Name = "txtLanes";
            this.txtLanes.Size = new System.Drawing.Size(61, 23);
            this.txtLanes.TabIndex = 25;
            // 
            // btnAddSwimMeet
            // 
            this.btnAddSwimMeet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSwimMeet.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSwimMeet.Location = new System.Drawing.Point(52, 363);
            this.btnAddSwimMeet.Name = "btnAddSwimMeet";
            this.btnAddSwimMeet.Size = new System.Drawing.Size(134, 44);
            this.btnAddSwimMeet.TabIndex = 26;
            this.btnAddSwimMeet.Text = "Add Swim Meet";
            this.btnAddSwimMeet.UseVisualStyleBackColor = true;
            this.btnAddSwimMeet.Click += new System.EventHandler(this.btnAddSwimMeet_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lsbSwimMeets);
            this.groupBox2.Controls.Add(this.btnSeed);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(303, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(199, 413);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Swim Meet";
            // 
            // btnSeed
            // 
            this.btnSeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeed.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeed.Location = new System.Drawing.Point(40, 363);
            this.btnSeed.Name = "btnSeed";
            this.btnSeed.Size = new System.Drawing.Size(112, 44);
            this.btnSeed.TabIndex = 26;
            this.btnSeed.Text = "Seed Meets";
            this.btnSeed.UseVisualStyleBackColor = true;
            this.btnSeed.Click += new System.EventHandler(this.btnSeed_Click);
            // 
            // lsbSwimMeets
            // 
            this.lsbSwimMeets.FormattingEnabled = true;
            this.lsbSwimMeets.ItemHeight = 17;
            this.lsbSwimMeets.Location = new System.Drawing.Point(6, 41);
            this.lsbSwimMeets.Name = "lsbSwimMeets";
            this.lsbSwimMeets.Size = new System.Drawing.Size(183, 293);
            this.lsbSwimMeets.TabIndex = 27;
            this.lsbSwimMeets.SelectedIndexChanged += new System.EventHandler(this.lsbSwimMeets_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lsbEvents);
            this.groupBox3.Controls.Add(this.btnAssignEvent);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(517, 120);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(217, 413);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Swim Meet";
            // 
            // lsbEvents
            // 
            this.lsbEvents.FormattingEnabled = true;
            this.lsbEvents.ItemHeight = 17;
            this.lsbEvents.Location = new System.Drawing.Point(17, 41);
            this.lsbEvents.Name = "lsbEvents";
            this.lsbEvents.Size = new System.Drawing.Size(182, 293);
            this.lsbEvents.TabIndex = 27;
            // 
            // btnAssignEvent
            // 
            this.btnAssignEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignEvent.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignEvent.Location = new System.Drawing.Point(41, 363);
            this.btnAssignEvent.Name = "btnAssignEvent";
            this.btnAssignEvent.Size = new System.Drawing.Size(123, 44);
            this.btnAssignEvent.TabIndex = 26;
            this.btnAssignEvent.Text = "Assign Event to Meet";
            this.btnAssignEvent.UseVisualStyleBackColor = true;
            this.btnAssignEvent.Click += new System.EventHandler(this.btnAssignEvent_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblMeetInfo);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(740, 120);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(241, 413);
            this.groupBox4.TabIndex = 29;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Swim Meet Info";
            // 
            // lblMeetInfo
            // 
            this.lblMeetInfo.AutoSize = true;
            this.lblMeetInfo.Location = new System.Drawing.Point(16, 41);
            this.lblMeetInfo.Name = "lblMeetInfo";
            this.lblMeetInfo.Size = new System.Drawing.Size(0, 17);
            this.lblMeetInfo.TabIndex = 0;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(44, 330);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 17);
            this.lblError.TabIndex = 27;
            // 
            // FormSwimMeet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(984, 681);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSwimMeet";
            this.Text = "Swim Meet Manager";
            this.Load += new System.EventHandler(this.FormSwimMeet_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLanes;
        private System.Windows.Forms.Label lblLanes;
        private System.Windows.Forms.ListBox lsbCourse;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.TextBox txtMeetName;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblMeetName;
        private System.Windows.Forms.Button btnAddSwimMeet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lsbSwimMeets;
        private System.Windows.Forms.Button btnSeed;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lsbEvents;
        private System.Windows.Forms.Button btnAssignEvent;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblMeetInfo;
        private System.Windows.Forms.Label lblError;
    }
}