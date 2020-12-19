
namespace Tada
{
    partial class FormAccomplishments
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
            this.ButtonClose = new System.Windows.Forms.Button();
            this.LabelWeekTitle = new System.Windows.Forms.Label();
            this.LabelWeekNumber = new System.Windows.Forms.Label();
            this.LabelMonth = new System.Windows.Forms.Label();
            this.LabelMonthNumber = new System.Windows.Forms.Label();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonClose
            // 
            this.ButtonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ButtonClose.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonClose.Location = new System.Drawing.Point(12, 186);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(310, 45);
            this.ButtonClose.TabIndex = 0;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.UseVisualStyleBackColor = false;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // LabelWeekTitle
            // 
            this.LabelWeekTitle.AutoSize = true;
            this.LabelWeekTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelWeekTitle.Location = new System.Drawing.Point(89, 76);
            this.LabelWeekTitle.Name = "LabelWeekTitle";
            this.LabelWeekTitle.Size = new System.Drawing.Size(113, 21);
            this.LabelWeekTitle.TabIndex = 1;
            this.LabelWeekTitle.Text = "The last week:";
            // 
            // LabelWeekNumber
            // 
            this.LabelWeekNumber.AutoSize = true;
            this.LabelWeekNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelWeekNumber.Location = new System.Drawing.Point(208, 76);
            this.LabelWeekNumber.Name = "LabelWeekNumber";
            this.LabelWeekNumber.Size = new System.Drawing.Size(37, 21);
            this.LabelWeekNumber.TabIndex = 2;
            this.LabelWeekNumber.Text = "000";
            this.LabelWeekNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelMonth
            // 
            this.LabelMonth.AutoSize = true;
            this.LabelMonth.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelMonth.Location = new System.Drawing.Point(89, 138);
            this.LabelMonth.Name = "LabelMonth";
            this.LabelMonth.Size = new System.Drawing.Size(122, 21);
            this.LabelMonth.TabIndex = 3;
            this.LabelMonth.Text = "The last month:";
            // 
            // LabelMonthNumber
            // 
            this.LabelMonthNumber.AutoSize = true;
            this.LabelMonthNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelMonthNumber.Location = new System.Drawing.Point(208, 138);
            this.LabelMonthNumber.Name = "LabelMonthNumber";
            this.LabelMonthNumber.Size = new System.Drawing.Size(37, 21);
            this.LabelMonthNumber.TabIndex = 4;
            this.LabelMonthNumber.Text = "000";
            this.LabelMonthNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelTitle.Location = new System.Drawing.Point(17, 9);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(300, 30);
            this.LabelTitle.TabIndex = 7;
            this.LabelTitle.Text = "What you have accomplished!";
            // 
            // FormAccomplishments
            // 
            this.AcceptButton = this.ButtonClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.CancelButton = this.ButtonClose;
            this.ClientSize = new System.Drawing.Size(334, 243);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.LabelMonthNumber);
            this.Controls.Add(this.LabelMonth);
            this.Controls.Add(this.LabelWeekNumber);
            this.Controls.Add(this.LabelWeekTitle);
            this.Controls.Add(this.ButtonClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAccomplishments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accomplishments";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Label LabelWeekTitle;
        private System.Windows.Forms.Label LabelWeekNumber;
        private System.Windows.Forms.Label LabelMonth;
        private System.Windows.Forms.Label LabelMonthNumber;
        private System.Windows.Forms.Label LabelTitle;
    }
}