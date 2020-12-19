
namespace Tada
{
    partial class FormEditTask
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
            this.TextBoxTask = new System.Windows.Forms.TextBox();
            this.LabelTask = new System.Windows.Forms.Label();
            this.CheckBoxComplete = new System.Windows.Forms.CheckBox();
            this.ButtonUpdate = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxTask
            // 
            this.TextBoxTask.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxTask.Location = new System.Drawing.Point(12, 82);
            this.TextBoxTask.Name = "TextBoxTask";
            this.TextBoxTask.Size = new System.Drawing.Size(460, 29);
            this.TextBoxTask.TabIndex = 0;
            // 
            // LabelTask
            // 
            this.LabelTask.AutoSize = true;
            this.LabelTask.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelTask.Location = new System.Drawing.Point(217, 29);
            this.LabelTask.Name = "LabelTask";
            this.LabelTask.Size = new System.Drawing.Size(50, 30);
            this.LabelTask.TabIndex = 1;
            this.LabelTask.Text = "Edit";
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
            // ButtonUpdate
            // 
            this.ButtonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ButtonUpdate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonUpdate.Location = new System.Drawing.Point(332, 204);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(140, 45);
            this.ButtonUpdate.TabIndex = 3;
            this.ButtonUpdate.Text = "Update";
            this.ButtonUpdate.UseVisualStyleBackColor = false;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ButtonDelete.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonDelete.Location = new System.Drawing.Point(172, 204);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(140, 45);
            this.ButtonDelete.TabIndex = 4;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.UseVisualStyleBackColor = false;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ButtonCancel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonCancel.Location = new System.Drawing.Point(12, 204);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(140, 45);
            this.ButtonCancel.TabIndex = 5;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = false;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // FormEditTask
            // 
            this.AcceptButton = this.ButtonUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.CancelButton = this.ButtonCancel;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonUpdate);
            this.Controls.Add(this.CheckBoxComplete);
            this.Controls.Add(this.LabelTask);
            this.Controls.Add(this.TextBoxTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEditTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxTask;
        private System.Windows.Forms.Label LabelTask;
        private System.Windows.Forms.CheckBox CheckBoxComplete;
        private System.Windows.Forms.Button ButtonUpdate;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonCancel;
    }
}