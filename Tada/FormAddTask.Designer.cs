
namespace Tada
{
    partial class FormAddTask
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
            this.TextBoxEnterTask = new System.Windows.Forms.TextBox();
            this.LabelTask = new System.Windows.Forms.Label();
            this.CheckBoxComplete = new System.Windows.Forms.CheckBox();
            this.ButtonFinish = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxEnterTask
            // 
            this.TextBoxEnterTask.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxEnterTask.Location = new System.Drawing.Point(12, 82);
            this.TextBoxEnterTask.Name = "TextBoxEnterTask";
            this.TextBoxEnterTask.Size = new System.Drawing.Size(460, 29);
            this.TextBoxEnterTask.TabIndex = 0;
            // 
            // LabelTask
            // 
            this.LabelTask.AutoSize = true;
            this.LabelTask.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelTask.Location = new System.Drawing.Point(109, 29);
            this.LabelTask.Name = "LabelTask";
            this.LabelTask.Size = new System.Drawing.Size(267, 30);
            this.LabelTask.TabIndex = 1;
            this.LabelTask.Text = "Enter your new task below";
            // 
            // CheckBoxComplete
            // 
            this.CheckBoxComplete.AutoSize = true;
            this.CheckBoxComplete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CheckBoxComplete.Location = new System.Drawing.Point(156, 140);
            this.CheckBoxComplete.Name = "CheckBoxComplete";
            this.CheckBoxComplete.Size = new System.Drawing.Size(173, 25);
            this.CheckBoxComplete.TabIndex = 2;
            this.CheckBoxComplete.Text = "Already Complete?";
            this.CheckBoxComplete.UseVisualStyleBackColor = true;
            // 
            // ButtonFinish
            // 
            this.ButtonFinish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ButtonFinish.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonFinish.Location = new System.Drawing.Point(332, 204);
            this.ButtonFinish.Name = "ButtonFinish";
            this.ButtonFinish.Size = new System.Drawing.Size(140, 45);
            this.ButtonFinish.TabIndex = 3;
            this.ButtonFinish.Text = "Finish";
            this.ButtonFinish.UseVisualStyleBackColor = false;
            this.ButtonFinish.Click += new System.EventHandler(this.ButtonFinish_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ButtonCancel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonCancel.Location = new System.Drawing.Point(12, 207);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(140, 45);
            this.ButtonCancel.TabIndex = 4;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = false;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // FormAddTask
            // 
            this.AcceptButton = this.ButtonFinish;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.CancelButton = this.ButtonCancel;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonFinish);
            this.Controls.Add(this.CheckBoxComplete);
            this.Controls.Add(this.LabelTask);
            this.Controls.Add(this.TextBoxEnterTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxEnterTask;
        private System.Windows.Forms.Label LabelTask;
        private System.Windows.Forms.CheckBox CheckBoxComplete;
        private System.Windows.Forms.Button ButtonFinish;
        private System.Windows.Forms.Button ButtonCancel;
    }
}