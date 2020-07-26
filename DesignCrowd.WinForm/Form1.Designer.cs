namespace DesignCrowd.WinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTask3 = new System.Windows.Forms.Button();
            this.btnTask2 = new System.Windows.Forms.Button();
            this.btnTask1 = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnTask3);
            this.panel2.Controls.Add(this.btnTask2);
            this.panel2.Controls.Add(this.btnTask1);
            this.panel2.Controls.Add(this.lblResult);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dtEndDate);
            this.panel2.Controls.Add(this.dtStartDate);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(712, 450);
            this.panel2.TabIndex = 0;
            // 
            // btnTask3
            // 
            this.btnTask3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTask3.Location = new System.Drawing.Point(415, 294);
            this.btnTask3.Name = "btnTask3";
            this.btnTask3.Size = new System.Drawing.Size(75, 23);
            this.btnTask3.TabIndex = 4;
            this.btnTask3.Text = "Task 3";
            this.btnTask3.UseVisualStyleBackColor = true;
            this.btnTask3.Click += new System.EventHandler(this.btnTask3_Click);
            // 
            // btnTask2
            // 
            this.btnTask2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTask2.Location = new System.Drawing.Point(334, 294);
            this.btnTask2.Name = "btnTask2";
            this.btnTask2.Size = new System.Drawing.Size(75, 23);
            this.btnTask2.TabIndex = 4;
            this.btnTask2.Text = "Task 2";
            this.btnTask2.UseVisualStyleBackColor = true;
            this.btnTask2.Click += new System.EventHandler(this.btnTask2_Click);
            // 
            // btnTask1
            // 
            this.btnTask1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTask1.Location = new System.Drawing.Point(253, 294);
            this.btnTask1.Name = "btnTask1";
            this.btnTask1.Size = new System.Drawing.Size(75, 23);
            this.btnTask1.TabIndex = 4;
            this.btnTask1.Text = "Task 1";
            this.btnTask1.UseVisualStyleBackColor = true;
            this.btnTask1.Click += new System.EventHandler(this.btnTask1_Click);
            // 
            // lblResult
            // 
            this.lblResult.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(297, 249);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(12, 15);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "-";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Days :";
            // 
            // dtEndDate
            // 
            this.dtEndDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtEndDate.Location = new System.Drawing.Point(253, 193);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(255, 23);
            this.dtEndDate.TabIndex = 2;
            this.dtEndDate.Value = new System.DateTime(2013, 10, 9, 0, 0, 0, 0);
            // 
            // dtStartDate
            // 
            this.dtStartDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtStartDate.Location = new System.Drawing.Point(253, 140);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(255, 23);
            this.dtStartDate.TabIndex = 2;
            this.dtStartDate.Value = new System.DateTime(2013, 10, 7, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "End Date :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Start Date :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 450);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTask3;
        private System.Windows.Forms.Button btnTask2;
        private System.Windows.Forms.Button btnTask1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtEndDate;
    }
}

