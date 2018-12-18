namespace TAScheduler
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.removeLabBtn = new System.Windows.Forms.Button();
            this.addLabBtn = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.fridayBx = new System.Windows.Forms.TextBox();
            this.thursdayBx = new System.Windows.Forms.TextBox();
            this.wednesdayBx = new System.Windows.Forms.TextBox();
            this.tuesdayBx = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mondayBx = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.removeTABtn = new System.Windows.Forms.Button();
            this.addTABtn = new System.Windows.Forms.Button();
            this.displayCurrentTAs = new System.Windows.Forms.TextBox();
            this.hoursAvailableChkList = new System.Windows.Forms.CheckedListBox();
            this.apprenticeChk = new System.Windows.Forms.CheckBox();
            this.seniorChk = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LastNameInput = new System.Windows.Forms.TextBox();
            this.firstNameInput = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1016, 602);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.checkedListBox1);
            this.tabPage1.Controls.Add(this.removeLabBtn);
            this.tabPage1.Controls.Add(this.addLabBtn);
            this.tabPage1.Controls.Add(this.dateTimePicker2);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1008, 576);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Weekly Lab Times";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.checkedListBox1.Location = new System.Drawing.Point(305, 472);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(582, 94);
            this.checkedListBox1.TabIndex = 8;
            // 
            // removeLabBtn
            // 
            this.removeLabBtn.Location = new System.Drawing.Point(151, 534);
            this.removeLabBtn.Name = "removeLabBtn";
            this.removeLabBtn.Size = new System.Drawing.Size(98, 23);
            this.removeLabBtn.TabIndex = 7;
            this.removeLabBtn.Text = "Remove";
            this.removeLabBtn.UseVisualStyleBackColor = true;
            // 
            // addLabBtn
            // 
            this.addLabBtn.Location = new System.Drawing.Point(7, 534);
            this.addLabBtn.Name = "addLabBtn";
            this.addLabBtn.Size = new System.Drawing.Size(98, 23);
            this.addLabBtn.TabIndex = 6;
            this.addLabBtn.Text = "Add";
            this.addLabBtn.UseVisualStyleBackColor = true;
            this.addLabBtn.Click += new System.EventHandler(this.addLabBtn_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "HH\':\'mm";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(151, 489);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(104, 20);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "HH\':\'mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(7, 489);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(98, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(154, 472);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "End Time";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 472);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Start Time";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.30547F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.30547F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.30547F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.30547F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.30547F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.381742F));
            this.tableLayoutPanel1.Controls.Add(this.fridayBx, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.thursdayBx, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.wednesdayBx, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.tuesdayBx, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label9, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.mondayBx, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.77778F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(996, 465);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // fridayBx
            // 
            this.fridayBx.Location = new System.Drawing.Point(741, 106);
            this.fridayBx.Multiline = true;
            this.fridayBx.Name = "fridayBx";
            this.fridayBx.ReadOnly = true;
            this.fridayBx.Size = new System.Drawing.Size(156, 356);
            this.fridayBx.TabIndex = 12;
            // 
            // thursdayBx
            // 
            this.thursdayBx.Location = new System.Drawing.Point(579, 106);
            this.thursdayBx.Multiline = true;
            this.thursdayBx.Name = "thursdayBx";
            this.thursdayBx.ReadOnly = true;
            this.thursdayBx.Size = new System.Drawing.Size(156, 356);
            this.thursdayBx.TabIndex = 11;
            // 
            // wednesdayBx
            // 
            this.wednesdayBx.Location = new System.Drawing.Point(417, 106);
            this.wednesdayBx.Multiline = true;
            this.wednesdayBx.Name = "wednesdayBx";
            this.wednesdayBx.ReadOnly = true;
            this.wednesdayBx.Size = new System.Drawing.Size(156, 356);
            this.wednesdayBx.TabIndex = 10;
            // 
            // tuesdayBx
            // 
            this.tuesdayBx.Location = new System.Drawing.Point(255, 106);
            this.tuesdayBx.Multiline = true;
            this.tuesdayBx.Name = "tuesdayBx";
            this.tuesdayBx.ReadOnly = true;
            this.tuesdayBx.Size = new System.Drawing.Size(156, 356);
            this.tuesdayBx.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(903, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 103);
            this.label9.TabIndex = 6;
            this.label9.Text = "Saturday";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(741, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 103);
            this.label8.TabIndex = 5;
            this.label8.Text = "Friday";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(579, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 103);
            this.label7.TabIndex = 4;
            this.label7.Text = "Thursday";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(417, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 103);
            this.label6.TabIndex = 3;
            this.label6.Text = "Wednesday";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(93, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 103);
            this.label4.TabIndex = 1;
            this.label4.Text = "Monday";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(255, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 103);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tuesday";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 103);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sunday";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mondayBx
            // 
            this.mondayBx.Location = new System.Drawing.Point(93, 106);
            this.mondayBx.Multiline = true;
            this.mondayBx.Name = "mondayBx";
            this.mondayBx.ReadOnly = true;
            this.mondayBx.Size = new System.Drawing.Size(156, 356);
            this.mondayBx.TabIndex = 7;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.removeTABtn);
            this.tabPage2.Controls.Add(this.addTABtn);
            this.tabPage2.Controls.Add(this.displayCurrentTAs);
            this.tabPage2.Controls.Add(this.hoursAvailableChkList);
            this.tabPage2.Controls.Add(this.apprenticeChk);
            this.tabPage2.Controls.Add(this.seniorChk);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.LastNameInput);
            this.tabPage2.Controls.Add(this.firstNameInput);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1008, 576);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add/Remove TA";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // removeTABtn
            // 
            this.removeTABtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeTABtn.Location = new System.Drawing.Point(14, 486);
            this.removeTABtn.Name = "removeTABtn";
            this.removeTABtn.Size = new System.Drawing.Size(172, 49);
            this.removeTABtn.TabIndex = 19;
            this.removeTABtn.Text = "REMOVE TA";
            this.removeTABtn.UseVisualStyleBackColor = true;
            // 
            // addTABtn
            // 
            this.addTABtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTABtn.Location = new System.Drawing.Point(663, 486);
            this.addTABtn.Name = "addTABtn";
            this.addTABtn.Size = new System.Drawing.Size(219, 50);
            this.addTABtn.TabIndex = 18;
            this.addTABtn.Text = "ADD TA";
            this.addTABtn.UseVisualStyleBackColor = true;
            // 
            // displayCurrentTAs
            // 
            this.displayCurrentTAs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.displayCurrentTAs.Location = new System.Drawing.Point(14, 85);
            this.displayCurrentTAs.Multiline = true;
            this.displayCurrentTAs.Name = "displayCurrentTAs";
            this.displayCurrentTAs.ReadOnly = true;
            this.displayCurrentTAs.Size = new System.Drawing.Size(593, 364);
            this.displayCurrentTAs.TabIndex = 17;
            // 
            // hoursAvailableChkList
            // 
            this.hoursAvailableChkList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hoursAvailableChkList.FormattingEnabled = true;
            this.hoursAvailableChkList.Location = new System.Drawing.Point(663, 40);
            this.hoursAvailableChkList.Name = "hoursAvailableChkList";
            this.hoursAvailableChkList.Size = new System.Drawing.Size(309, 409);
            this.hoursAvailableChkList.TabIndex = 16;
            // 
            // apprenticeChk
            // 
            this.apprenticeChk.AutoSize = true;
            this.apprenticeChk.Location = new System.Drawing.Point(513, 28);
            this.apprenticeChk.Name = "apprenticeChk";
            this.apprenticeChk.Size = new System.Drawing.Size(94, 17);
            this.apprenticeChk.TabIndex = 15;
            this.apprenticeChk.Text = "Apprentice TA";
            this.apprenticeChk.UseVisualStyleBackColor = true;
            // 
            // seniorChk
            // 
            this.seniorChk.AutoSize = true;
            this.seniorChk.Location = new System.Drawing.Point(414, 28);
            this.seniorChk.Name = "seniorChk";
            this.seniorChk.Size = new System.Drawing.Size(73, 17);
            this.seniorChk.TabIndex = 14;
            this.seniorChk.Text = "Senior TA";
            this.seniorChk.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "First Name";
            // 
            // LastNameInput
            // 
            this.LastNameInput.Location = new System.Drawing.Point(222, 28);
            this.LastNameInput.Name = "LastNameInput";
            this.LastNameInput.Size = new System.Drawing.Size(166, 20);
            this.LastNameInput.TabIndex = 11;
            // 
            // firstNameInput
            // 
            this.firstNameInput.Location = new System.Drawing.Point(14, 28);
            this.firstNameInput.Name = "firstNameInput";
            this.firstNameInput.Size = new System.Drawing.Size(172, 20);
            this.firstNameInput.TabIndex = 10;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1008, 576);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Generate Schedule";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 627);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Scheduler";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button removeTABtn;
        private System.Windows.Forms.Button addTABtn;
        private System.Windows.Forms.TextBox displayCurrentTAs;
        private System.Windows.Forms.CheckedListBox hoursAvailableChkList;
        private System.Windows.Forms.CheckBox apprenticeChk;
        private System.Windows.Forms.CheckBox seniorChk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LastNameInput;
        private System.Windows.Forms.TextBox firstNameInput;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fridayBx;
        private System.Windows.Forms.TextBox thursdayBx;
        private System.Windows.Forms.TextBox wednesdayBx;
        private System.Windows.Forms.TextBox tuesdayBx;
        private System.Windows.Forms.TextBox mondayBx;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button removeLabBtn;
        private System.Windows.Forms.Button addLabBtn;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}

