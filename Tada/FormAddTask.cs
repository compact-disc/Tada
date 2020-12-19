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
    public partial class FormAddTask : Form
    {

        //Instance variable for the main form to call functions inside of it
        private FormTada mainForm;

        //Get the name of the sender button, this is to get the right column
        private string senderButton;

        public FormAddTask(FormTada form, string button)
        {
            //Constructor for the add task window
            //Takes in a copy of the main form and the name of the button that was clicked
            InitializeComponent();

            //Set the instance variable for the main form to the passed copy
            mainForm = form;

            //Set the instance variable for the button to the passed copy
            senderButton = button;
        }

        private void ButtonFinish_Click(object sender, EventArgs e)
        {
            //Event method for the finish button

            //String that holds on the task, gets the string from what was entered in the text box
            string task = TextBoxEnterTask.Text;

            //Get the complete status from the checkbox in the form
            Boolean complete = CheckBoxComplete.Checked;

            //Call the add task method inside of the main form object, passing the task, complete status, and what button sent it
            mainForm.AddTask(task, complete, senderButton);

            //Close the add task window
            Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            //Cancel button that just closes the form
            Close();
        }
    }
}
