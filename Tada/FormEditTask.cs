/////////////////////////////////////////////
// Name: Christopher DeRoche
// Username: cderoche
// Date Modified: 12/10/2020
// Assignment: Final Project Phase 3
/////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tada
{
    public partial class FormEditTask : Form
    {

        //Instance string that holds the task
        private string task;

        //Instance string that holds the type of task
        private string type;

        //Instance boolean that holds the complete status of the task
        private Boolean check;

        //Instance variable for the main form so we can call methods inside of it when needed
        private FormTada parentForm;

        public FormEditTask(string task, Boolean check, string type, FormTada parentForm)
        {
            //Constructor for the edit task object
            //Passed the task, complete status, the type, and the main form object

            InitializeComponent();

            //Set all the instance variables to their passed equivalents
            this.task = task;
            this.type = type;
            this.check = check;
            this.parentForm = parentForm;

            //Set the text of the text box to the current task
            TextBoxTask.Text = task;

            //Set the checkbox of the current task to the proper status
            CheckBoxComplete.Checked = check;
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            //Method for the Update button event

            //Call the update task method inside of the parent form
            //Pass in the new information along with the old so we can find and replace the old task
            parentForm.UpdateTask(this.task, TextBoxTask.Text.ToString(), CheckBoxComplete.Checked, this.type);

            //Close the window
            Close();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            //method for the delete button event

            //Call the delete task method inside of the parent form
            //Pass in the task and type so we can delete the proper task
            parentForm.DeleteTask(this.task, this.type);

            //Close the window
            Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            //Cancel button that just closes the window
            Close();
        }
    }
}
