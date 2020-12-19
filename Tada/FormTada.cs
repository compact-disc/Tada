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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Tada
{
    public partial class FormTada : Form
    {

        //DateTime object that stores the current date and time of the system.
        //String that will store the current date in a MM-dd-yyyy format.
        private DateTime currentDate;
        private string currentDateString;

        //Array lists that will store the data for the current day of the program.
        //They will alternate between a string and boolean.
        private ArrayList habits = new ArrayList();
        private ArrayList daily = new ArrayList();
        private ArrayList todo = new ArrayList();

        public FormTada()
        {
            //Default Contstructor for the main FormTada

            InitializeComponent();

            //Set the current date using the DateTime structure, setting to Now, which gets the current system time/date.
            currentDate = DateTime.Now;

            //Set the current date string from the DateTime structure, formatting using the MM-dd-yyyy format.
            currentDateString = currentDate.ToString("MM-dd-yyyy");

            //Set the label for the date on the form to the current day.
            LabelDate.Text = currentDateString;

            //Check if the data directory exists, if it does not, create one
            if (!Directory.Exists(@".\data"))
            {
                Directory.CreateDirectory(@".\data");
            }

            //Check if the \data\habits directoy exists, if it does not, create one
            if (!Directory.Exists(@".\data\habits"))
            {
                Directory.CreateDirectory(@".\data\habits");
            }

            //Check if the \data\daily directoy exists, if it does not, create one
            if (!Directory.Exists(@".\data\daily"))
            {
                Directory.CreateDirectory(@".\data\daily");
            }

            //Check if the \data\todo directoy exists, if it does not, create one
            if (!Directory.Exists(@".\data\todo"))
            {
                Directory.CreateDirectory(@".\data\todo");
            }
        }

        private void CheckBox_MouseUp(object sender, MouseEventArgs e)
        {
            //CheckBox click event, this is triggered when the mouse is lifted up.
            //For some reason you can only differentiate right and left click using this event therefore I used it.

            //Create a CheckBox object, set it to the sender because the event is linked to the task checkboxes.
            //The sender has to be casted to a checkbox first to be able to properly use it.
            CheckBox taskCheckBox = (CheckBox)sender;

            //This string that is going to store the name of the task.
            string name;

            //Switch over the mouse button that is pressed
            switch (e.Button)
            {
                //Right click on the task case
                case MouseButtons.Right:
                    //Set the name string to the checkbox text
                    name = taskCheckBox.Text;

                    //This string will store the task type. It is categorized by the parent FlowLayoutPanel name
                    string type = taskCheckBox.Parent.Name.ToString();

                    //Boolean to store if the checkbox has been checked or not
                    Boolean check = taskCheckBox.Checked;

                    //Create a new FormEditTask object and Window, pass the name, check status, type of checkbox, and the main form object.
                    FormEditTask editTask = new FormEditTask(name, check, type, this);

                    //Show the newly created FormEditTask form.
                    editTask.Show();
                    break;

                //Left click on the task case
                case MouseButtons.Left:

                    //Integer for the task position in the arraylist
                    int taskPosition;

                    //Integer for the boolean to see if task is complete, but in the arraylist
                    int completePosition;

                    //Boolean to store the complete status of the task
                    Boolean complete;

                    //Set the name string to the checkbox text
                    name = taskCheckBox.Text;

                    //Switch over the current tasks parents FlowLayoutPanel name, which categorizes the tasks
                    switch (taskCheckBox.Parent.Name.ToString())
                    {
                        //Case for the Habits column
                        case "FlowLayoutPanelHabits":

                            //Get the position in the arraylist for the clicked task
                            taskPosition = habits.IndexOf(name);

                            //Set the position of the boolean for the task, which is always one more than the task
                            completePosition = taskPosition + 1;

                            //Set the complete status to whatever is at the current position
                            //Since the arraylist is generic, we must cast the object boolean to an actual boolean.
                            complete = (Boolean)habits[completePosition];

                            //Since this operation is to flip the check box
                            //If true, set to false
                            //If false, set to true
                            if (complete)
                            {
                                complete = false;
                            }
                            else if (!complete)
                            {
                                complete = true;
                            }

                            //Set the complete status in the arraylist to the newly flipped status
                            habits[completePosition] = complete;

                            break;
                        //Case for the Daily column
                        case "FlowLayoutPanelDaily":

                            //Get the position in the arraylist for the clicked task
                            taskPosition = daily.IndexOf(name);

                            //Set the position of the boolean for the task, which is always one more than the task
                            completePosition = taskPosition + 1;

                            //Set the complete status to whatever is at the current position
                            //Since the arraylist is generic, we must cast the object boolean to an actual boolean.
                            complete = (Boolean)daily[completePosition];

                            //Since this operation is to flip the check box
                            //If true, set to false
                            //If false, set to true
                            if (complete)
                            {
                                complete = false;
                            }
                            else if (!complete)
                            {
                                complete = true;
                            }

                            //Set the complete status in the arraylist to the newly flipped status
                            daily[completePosition] = complete;
                            break;
                        //Case for the Todo column
                        case "FlowLayoutPanelTodo":

                            //Get the position in the arraylist for the clicked task
                            taskPosition = todo.IndexOf(name);

                            //Set the position of the boolean for the task, which is always one more than the task
                            completePosition = taskPosition + 1;

                            //Set the complete status to whatever is at the current position
                            //Since the arraylist is generic, we must cast the object boolean to an actual boolean.
                            complete = (Boolean)todo[completePosition];

                            //Since this operation is to flip the check box
                            //If true, set to false
                            //If false, set to true
                            if (complete)
                            {
                                complete = false;
                            }
                            else if (!complete)
                            {
                                complete = true;
                            }

                            //Set the complete status in the arraylist to the newly flipped status
                            todo[completePosition] = complete;
                            break;
                    }
                    break;
            }

        }

        private void ButtonDateForward_Click(object sender, EventArgs e)
        {
            //Button that moves the current date of the program to a day ahead

            //Call the save function to save all the current data
            SaveData();

            //Clear out the arrays with the current days data
            ClearArrays();

            //Move the current day one day forward
            currentDate = currentDate.AddDays(1);

            //Set the current day string to the newly formatted date
            currentDateString = currentDate.ToString("MM-dd-yyyy");

            //Set the text of the window date to the formatted string
            LabelDate.Text = currentDateString;

            //Call the clear columns function to ready them for new data
            ClearColumns();

            //Load the new days data into the program
            LoadData();
        }
 
        private void ButtonDateBack_Click(object sender, EventArgs e)
        {
            //Button that moves the current date of the program to a day back

            //Call the save function to save all the current data
            SaveData();

            //Clear out the arrays with the current days data
            ClearArrays();

            //Move the current day one day forward
            currentDate = currentDate.AddDays(-1);

            //Set the current day string to the newly formatted date
            currentDateString = currentDate.ToString("MM-dd-yyyy");

            //Set the text of the window date to the formatted string
            LabelDate.Text = currentDateString;

            //Call the clear columns function to ready them for new data
            ClearColumns();

            //Load the new days data into the program
            LoadData();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //Button event for the add new task in each column

            //Get the sender data and then trim a string from it to get the type of task we are adding
            string button = sender.ToString().TrimStart("System.Windows.Forms.Button, Text: ".ToCharArray());

            //Create the new form object for a new task, pass this object and the button name
            FormAddTask newTask = new FormAddTask(this, button);

            //Show the new form
            newTask.Show();
        }

        private void FormTada_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Event for the form close button. This will prevent the program from not saving if the "X" button is pressed.
            SaveData();
        }

        private void FormTada_Load(object sender, EventArgs e)
        {
            //Event for the form load. This will load the current dates data (if any exists).
            LoadData();
        }

        private void ButtonAccomplishments_Click(object sender, EventArgs e)
        {
            //Button event for the accomplishments window to open

            //Save the data so any new entries can be calculated in the total.
            SaveData();

            //Create the object and form for the accomplishments window
            FormAccomplishments accomplishments = new FormAccomplishments();

            //Show the newly created form
            accomplishments.Show();
        }

        public void UpdateTask(string oldTask, string newTask, Boolean complete, string type)
        {
            //Method used to update the task that is passed from the FormEditTask form
            //It takes in the old task name, the new task name, the complete status, and the type of task

            //Integer positions for the task and complete status in the array lists
            int taskPosition;
            int completePosition;

            //Switch over the task type so we know where to put the task in the columns
            switch (type)
            {
                //Case for the habits column
                case "FlowLayoutPanelHabits":

                    //Get the position of the task we are editing
                    taskPosition = habits.IndexOf(oldTask);

                    //Set the position of the complete status, which is 1 more than the task name
                    completePosition = taskPosition + 1;

                    //Set the string of the new task to replace the old one. Just set it at the old tasks position
                    habits[taskPosition] = newTask;

                    //Set the complete status of the task at the position of the old one
                    habits[completePosition] = complete;

                    //Clear out the column to popluate the new data
                    FlowLayoutPanelHabits.Controls.Clear();

                    //For loop to run half the number of times as there are items in the arraylist
                    //This is because every iteration we are getting two items. So the count will increase by 2 every time
                    for(int i = 0; i < habits.Count; i += 2)
                    {
                        //Create a new CheckBox object using the arraylist to get the data
                        //Set other proper static things as well
                        CheckBox taskCheckBox = new CheckBox
                        {
                            //Set autosize to true so it fits properly
                            AutoSize = true,
                            
                            //Set the text to the task in the arraylist at the current position
                            Text = habits[i].ToString(),

                            //Set the complete status to the boolean value of the checked status in the arraylist. This is task + 1
                            Checked = (Boolean)habits[i + 1],

                            //Set the name of the CheckBox to the task as well, since it's dynamically added this is the easiest way to take care of this
                            Name = habits[i].ToString()
                        };

                        //Add the CheckBox mouse operation events to the newly created Checkbox
                        taskCheckBox.MouseUp += new MouseEventHandler(CheckBox_MouseUp);

                        //Add the newly created CheckBox to the FlowLayoutPanel
                        FlowLayoutPanelHabits.Controls.Add(taskCheckBox);
                    }

                    //Put the add button back into the column since it was cleared
                    PlaceAddButton(type);
                    break;
                case "FlowLayoutPanelDaily":

                    //Get the position of the task we are editing
                    taskPosition = daily.IndexOf(oldTask);

                    //Set the position of the complete status, which is 1 more than the task name
                    completePosition = taskPosition + 1;

                    //Set the string of the new task to replace the old one. Just set it at the old tasks position
                    daily[taskPosition] = newTask;

                    //Set the complete status of the task at the position of the old one
                    daily[completePosition] = complete;

                    //Clear out the column to popluate the new data
                    FlowLayoutPanelDaily.Controls.Clear();

                    //For loop to run half the number of times as there are items in the arraylist
                    //This is because every iteration we are getting two items. So the count will increase by 2 every time
                    for (int i = 0; i < daily.Count; i += 2)
                    {
                        //Create a new CheckBox object using the arraylist to get the data
                        //Set other proper static things as well
                        CheckBox taskCheckBox = new CheckBox
                        {
                            //Set autosize to true so it fits properly
                            AutoSize = true,

                            //Set the text to the task in the arraylist at the current position
                            Text = daily[i].ToString(),

                            //Set the complete status to the boolean value of the checked status in the arraylist. This is task + 1
                            Checked = (Boolean)daily[i + 1],

                            //Set the name of the CheckBox to the task as well, since it's dynamically added this is the easiest way to take care of this
                            Name = daily[i].ToString()
                        };

                        //Add the CheckBox mouse operation events to the newly created Checkbox
                        taskCheckBox.MouseUp += new MouseEventHandler(CheckBox_MouseUp);

                        //Add the newly created CheckBox to the FlowLayoutPanel
                        FlowLayoutPanelDaily.Controls.Add(taskCheckBox);
                    }

                    //Put the add button back into the column since it was cleared
                    PlaceAddButton(type);
                    break;
                case "FlowLayoutPanelTodo":

                    //Get the position of the task we are editing
                    taskPosition = todo.IndexOf(oldTask);

                    //Set the position of the complete status, which is 1 more than the task name
                    completePosition = taskPosition + 1;

                    //Set the string of the new task to replace the old one. Just set it at the old tasks position
                    todo[taskPosition] = newTask;

                    //Set the complete status of the task at the position of the old one
                    todo[completePosition] = complete;

                    //Clear out the column to popluate the new data
                    FlowLayoutPanelTodo.Controls.Clear();

                    //For loop to run half the number of times as there are items in the arraylist
                    //This is because every iteration we are getting two items. So the count will increase by 2 every time
                    for (int i = 0; i < todo.Count; i += 2)
                    {
                        //Create a new CheckBox object using the arraylist to get the data
                        //Set other proper static things as well
                        CheckBox taskCheckBox = new CheckBox
                        {
                            //Set autosize to true so it fits properly
                            AutoSize = true,

                            //Set the text to the task in the arraylist at the current position
                            Text = todo[i].ToString(),

                            //Set the complete status to the boolean value of the checked status in the arraylist. This is task + 1
                            Checked = (Boolean)todo[i + 1],

                            //Set the name of the CheckBox to the task as well, since it's dynamically added this is the easiest way to take care of this
                            Name = todo[i].ToString()
                        };

                        //Add the CheckBox mouse operation events to the newly created Checkbox
                        taskCheckBox.MouseUp += new MouseEventHandler(CheckBox_MouseUp);

                        //Add the newly created CheckBox to the FlowLayoutPanel
                        FlowLayoutPanelTodo.Controls.Add(taskCheckBox);
                    }

                    //Put the add button back into the column since it was cleared
                    PlaceAddButton(type);
                    break;
            }
        }

        public void DeleteTask(string task, string type)
        {
            //Method to remove the task that is clicked on
            //The current task and the task type are passed from the FormEditTask form

            //Integer positions for the task and complete status in the array lists
            int taskPosition;
            int completePosition;

            //Switch over the task type so we know where to put the task in the columns
            switch (type)
            {

                //Case for the Habits panel
                case "FlowLayoutPanelHabits":

                    //Get the position of the task we are deleting
                    taskPosition = habits.IndexOf(task);

                    //Set the position of the complete status, which is 1 more than the task name
                    completePosition = taskPosition + 1;

                    //Remove the complete status from the arraylist
                    habits.RemoveAt(completePosition);

                    //Remove the task from the arraylist
                    habits.RemoveAt(taskPosition);

                    //Clear out the column to popluate the new data
                    FlowLayoutPanelHabits.Controls.Clear();

                    //For loop to run half the number of times as there are items in the arraylist
                    //This is because every iteration we are getting two items. So the count will increase by 2 every time
                    for (int i = 0; i < habits.Count; i += 2)
                    {
                        //Create a new CheckBox object using the arraylist to get the data
                        //Set other proper static things as well
                        CheckBox taskCheckBox = new CheckBox
                        {
                            //Set autosize to true so it fits properly
                            AutoSize = true,

                            //Set the text to the task in the arraylist at the current position
                            Text = habits[i].ToString(),

                            //Set the complete status to the boolean value of the checked status in the arraylist. This is task + 1
                            Checked = (Boolean)habits[i + 1],

                            //Set the name of the CheckBox to the task as well, since it's dynamically added this is the easiest way to take care of this
                            Name = habits[i].ToString()
                        };

                        //Add the CheckBox mouse operation events to the newly created Checkbox
                        taskCheckBox.MouseUp += new MouseEventHandler(CheckBox_MouseUp);

                        //Add the newly created CheckBox to the FlowLayoutPanel
                        FlowLayoutPanelHabits.Controls.Add(taskCheckBox);
                    }

                    //Put the add button back into the column since it was cleared
                    PlaceAddButton(type);
                    break;
                //Case for the Daily panel
                case "FlowLayoutPanelDaily":

                    //Get the position of the task we are deleting
                    taskPosition = daily.IndexOf(task);

                    //Set the position of the complete status, which is 1 more than the task name
                    completePosition = taskPosition + 1;

                    //Remove the complete status from the arraylist
                    daily.RemoveAt(completePosition);

                    //Remove the task from the arraylist
                    daily.RemoveAt(taskPosition);

                    //Clear out the column to popluate the new data
                    FlowLayoutPanelDaily.Controls.Clear();

                    //For loop to run half the number of times as there are items in the arraylist
                    //This is because every iteration we are getting two items. So the count will increase by 2 every time
                    for (int i = 0; i < daily.Count; i += 2)
                    {
                        //Create a new CheckBox object using the arraylist to get the data
                        //Set other proper static things as well
                        CheckBox taskCheckBox = new CheckBox
                        {
                            //Set autosize to true so it fits properly
                            AutoSize = true,

                            //Set the text to the task in the arraylist at the current position
                            Text = daily[i].ToString(),

                            //Set the complete status to the boolean value of the checked status in the arraylist. This is task + 1
                            Checked = (Boolean)daily[i + 1],

                            //Set the name of the CheckBox to the task as well, since it's dynamically added this is the easiest way to take care of this
                            Name = daily[i].ToString()
                        };

                        //Add the CheckBox mouse operation events to the newly created Checkbox
                        taskCheckBox.MouseUp += new MouseEventHandler(CheckBox_MouseUp);

                        //Add the newly created CheckBox to the FlowLayoutPanel
                        FlowLayoutPanelDaily.Controls.Add(taskCheckBox);
                    }

                    //Put the add button back into the column since it was cleared
                    PlaceAddButton(type);
                    break;
                //Case for the Todo panel
                case "FlowLayoutPanelTodo":

                    //Get the position of the task we are deleting
                    taskPosition = todo.IndexOf(task);

                    //Set the position of the complete status, which is 1 more than the task name
                    completePosition = taskPosition + 1;

                    //Remove the complete status from the arraylist
                    todo.RemoveAt(completePosition);

                    //Remove the task from the arraylist
                    todo.RemoveAt(taskPosition);

                    //Clear out the column to popluate the new data
                    FlowLayoutPanelTodo.Controls.Clear();

                    //For loop to run half the number of times as there are items in the arraylist
                    //This is because every iteration we are getting two items. So the count will increase by 2 every time
                    for (int i = 0; i < todo.Count; i += 2)
                    {
                        //Create a new CheckBox object using the arraylist to get the data
                        //Set other proper static things as well
                        CheckBox taskCheckBox = new CheckBox
                        {
                            //Set autosize to true so it fits properly
                            AutoSize = true,

                            //Set the text to the task in the arraylist at the current position
                            Text = todo[i].ToString(),

                            //Set the complete status to the boolean value of the checked status in the arraylist. This is task + 1
                            Checked = (Boolean)todo[i + 1],

                            //Set the name of the CheckBox to the task as well, since it's dynamically added this is the easiest way to take care of this
                            Name = todo[i].ToString()
                        };

                        //Add the CheckBox mouse operation events to the newly created Checkbox
                        taskCheckBox.MouseUp += new MouseEventHandler(CheckBox_MouseUp);

                        //Add the newly created CheckBox to the FlowLayoutPanel
                        FlowLayoutPanelTodo.Controls.Add(taskCheckBox);
                    }

                    //Put the add button back into the column since it was cleared
                    PlaceAddButton(type);
                    break;
            }
        }

        public void AddTask(string task, Boolean complete, string type)
        {
            //Method to add a new task to a column
            //The task, complete status, and type of task are passed

            //Switch over the task type
            switch (type)
            {
                //Case for habits column
                case "Add Habit":

                    //Add the task to the arraylist
                    habits.Add(task);

                    //Add the complete status to the arraylist
                    habits.Add(complete);

                    //Clear the FlowLayoutPanel or the column to add the newly updated arraylist
                    FlowLayoutPanelHabits.Controls.Clear();

                    //For loop to run half the number of times as there are items in the arraylist
                    //This is because every iteration we are getting two items. So the count will increase by 2 every time
                    for (int i = 0; i < habits.Count; i += 2)
                    {
                        //Create a new CheckBox object using the arraylist to get the data
                        //Set other proper static things as well
                        CheckBox taskCheckBox = new CheckBox
                        {
                            //Set autosize to true so it fits properly
                            AutoSize = true,

                            //Set the text to the task in the arraylist at the current position
                            Text = habits[i].ToString(),

                            //Set the complete status to the boolean value of the checked status in the arraylist. This is task + 1
                            Checked = (Boolean)habits[i + 1],

                            //Set the name of the CheckBox to the task as well, since it's dynamically added this is the easiest way to take care of this
                            Name = habits[i].ToString()
                        };

                        //Add the CheckBox mouse operation events to the newly created Checkbox
                        taskCheckBox.MouseUp += new MouseEventHandler(CheckBox_MouseUp);

                        //Add the newly created CheckBox to the FlowLayoutPanel
                        FlowLayoutPanelHabits.Controls.Add(taskCheckBox);
                    }

                    //Put the add button back into the column since it was cleared
                    PlaceAddButton("FlowLayoutPanelHabits");
                    break;

                //Case for daily column
                case "Add Daily":

                    //Add the task to the arraylist
                    daily.Add(task);

                    //Add the complete status to the arraylist
                    daily.Add(complete);

                    //Clear the FlowLayoutPanel or the column to add the newly updated arraylist
                    FlowLayoutPanelDaily.Controls.Clear();

                    //For loop to run half the number of times as there are items in the arraylist
                    //This is because every iteration we are getting two items. So the count will increase by 2 every time
                    for (int i = 0; i < daily.Count; i += 2)
                    {
                        //Create a new CheckBox object using the arraylist to get the data
                        //Set other proper static things as well
                        CheckBox taskCheckBox = new CheckBox
                        {
                            //Set autosize to true so it fits properly
                            AutoSize = true,

                            //Set the text to the task in the arraylist at the current position
                            Text = daily[i].ToString(),

                            //Set the complete status to the boolean value of the checked status in the arraylist. This is task + 1
                            Checked = (Boolean)daily[i + 1],

                            //Set the name of the CheckBox to the task as well, since it's dynamically added this is the easiest way to take care of this
                            Name = daily[i].ToString()
                        };

                        //Add the CheckBox mouse operation events to the newly created Checkbox
                        taskCheckBox.MouseUp += new MouseEventHandler(CheckBox_MouseUp);

                        //Add the newly created CheckBox to the FlowLayoutPanel
                        FlowLayoutPanelDaily.Controls.Add(taskCheckBox);
                    }

                    //Put the add button back into the column since it was cleared
                    PlaceAddButton("FlowLayoutPanelDaily");
                    break;
                
                //Case for the todo column
                case "Add To-Do":

                    //Add the task to the arraylist
                    todo.Add(task);

                    //Add the complete status to the arraylist
                    todo.Add(complete);

                    //Clear the FlowLayoutPanel or the column to add the newly updated arraylist
                    FlowLayoutPanelTodo.Controls.Clear();

                    //For loop to run half the number of times as there are items in the arraylist
                    //This is because every iteration we are getting two items. So the count will increase by 2 every time
                    for (int i = 0; i < todo.Count; i += 2)
                    {
                        //Create a new CheckBox object using the arraylist to get the data
                        //Set other proper static things as well
                        CheckBox taskCheckBox = new CheckBox
                        {
                            //Set autosize to true so it fits properly
                            AutoSize = true,

                            //Set the text to the task in the arraylist at the current position
                            Text = todo[i].ToString(),

                            //Set the complete status to the boolean value of the checked status in the arraylist. This is task + 1
                            Checked = (Boolean)todo[i + 1],

                            //Set the name of the CheckBox to the task as well, since it's dynamically added this is the easiest way to take care of this
                            Name = todo[i].ToString()
                        };

                        //Add the CheckBox mouse operation events to the newly created Checkbox
                        taskCheckBox.MouseUp += new MouseEventHandler(CheckBox_MouseUp);

                        //Add the newly created CheckBox to the FlowLayoutPanel
                        FlowLayoutPanelTodo.Controls.Add(taskCheckBox);
                    }

                    //Put the add button back into the column since it was cleared
                    PlaceAddButton("FlowLayoutPanelTodo");
                    break;
                default:
                    MessageBox.Show("Error adding task " + task, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void PlaceAddButton(string type)
        {
            //Method to put an "Add" button back into a column by type

            //Switch over the button type
            switch (type)
            {
                //Case for the habits column
                case "FlowLayoutPanelHabits":

                    //Create a new Button object
                    //Set other proper static things as well
                    Button addButtonHabits = new Button
                    {
                        //Set the text to the respective column name
                        Text = "Add Habit",

                        //Set the width
                        Width = 370,

                        //Set the height
                        Height = 40,

                        //Set the color
                        BackColor = Color.White
                    };

                    //Add the handler to the button so that new tasks can be added using the Add Task form
                    addButtonHabits.Click += new EventHandler(AddButton_Click);

                    //Add the button to the FlowLayoutPanel
                    FlowLayoutPanelHabits.Controls.Add(addButtonHabits);
                    break;

                //Case for the daily column
                case "FlowLayoutPanelDaily":

                    //Create a new Button object
                    //Set other proper static things as well
                    Button addButtonDaily = new Button
                    {
                        //Set the text to the respective column name
                        Text = "Add Daily",

                        //Set the width
                        Width = 395,

                        //Set the height
                        Height = 40,

                        //Set the color
                        BackColor = Color.White
                    };

                    //Add the handler to the button so that new tasks can be added using the Add Task form
                    addButtonDaily.Click += new EventHandler(AddButton_Click);

                    //Add the button to the FlowLayoutPanel
                    FlowLayoutPanelDaily.Controls.Add(addButtonDaily);
                    break;

                //Case for the todo column
                case "FlowLayoutPanelTodo":

                    //Create a new Button object
                    //Set other proper static things as well
                    Button addButtonTodo = new Button
                    {
                        //Set the text to the respective column name
                        Text = "Add To-Do",

                        //Set the width
                        Width = 370,

                        //Set the height
                        Height = 40,

                        //Set the color
                        BackColor = Color.White
                    };

                    //Add the handler to the button so that new tasks can be added using the Add Task form
                    addButtonTodo.Click += new EventHandler(AddButton_Click);

                    //Add the button to the FlowLayoutPanel
                    FlowLayoutPanelTodo.Controls.Add(addButtonTodo);
                    break;
            }
        }

        private void ClearColumns()
        {
            //Method to clear out the columns in the main form
            //Each FlowLayoutPane Clear() function is called
            FlowLayoutPanelHabits.Controls.Clear();
            FlowLayoutPanelDaily.Controls.Clear();
            FlowLayoutPanelTodo.Controls.Clear();
        }

        private void ClearArrays()
        {
            //Method to clear out the arraylists for each of the columns
            //Each arraylists Clear() function is called
            habits.Clear();
            daily.Clear();
            todo.Clear();
        }

        private void LoadData()
        {
            //Function that loads the data for all 3 panels at the given date

            //String for the data collected on every iteration
            string data;

            //Since we are reading data, there needs to be a try-catch for any errors we may encounter with reading
            try
            {
                //Create the StreamReader object pointed at the file for the current date and column type
                using StreamReader habitsReader = new StreamReader(@".\data\habits\" + currentDateString + ".txt");

                //Have the StreamReader keep going until end of file is reached
                while (!habitsReader.EndOfStream)
                {
                    //Get, in a string format, the line from the file
                    data = habitsReader.ReadLine();

                    //If the data is a true or false, we need to parse it to a boolean because it is going to be used as one later
                    //Else just add the string as a task, which is used as a string
                    if (string.Equals(data, "true", StringComparison.OrdinalIgnoreCase) || string.Equals(data, "false", StringComparison.OrdinalIgnoreCase))
                    {
                        habits.Add(Boolean.Parse(data));
                    }
                    else
                    {
                        habits.Add(data);
                    }
                }

                //Clear the FlowLayoutPanel
                FlowLayoutPanelHabits.Controls.Clear();

                //For loop to run half the number of times as there are items in the arraylist
                //This is because every iteration we are getting two items. So the count will increase by 2 every time
                for (int i = 0; i < habits.Count; i += 2)
                {
                    //Create a new CheckBox object using the arraylist to get the data
                    //Set other proper static things as well
                    CheckBox taskCheckBox = new CheckBox
                    {
                        //Set autosize to true so it fits properly
                        AutoSize = true,

                        //Set the text to the task in the arraylist at the current position
                        Text = habits[i].ToString(),

                        //Set the complete status to the boolean value of the checked status in the arraylist. This is task + 1
                        Checked = (Boolean)habits[i + 1],

                        //Set the name of the CheckBox to the task as well, since it's dynamically added this is the easiest way to take care of this
                        Name = habits[i].ToString()
                    };

                    //Add the CheckBox mouse operation events to the newly created Checkbox
                    taskCheckBox.MouseUp += new MouseEventHandler(CheckBox_MouseUp);

                    //Add the newly created CheckBox to the FlowLayoutPanel
                    FlowLayoutPanelHabits.Controls.Add(taskCheckBox);
                }

                //Put the add button back into the column since it was cleared
                PlaceAddButton("FlowLayoutPanelHabits");
            }
            catch (FileNotFoundException) //catch a file not found exception
            {

                //Create a file with the current date
                using FileStream habitsFile = File.Create(@".\data\habits\" + currentDateString + ".txt");

                //We still need to place the button even if there is no data
                PlaceAddButton("FlowLayoutPanelHabits");
            }
            catch (Exception) //catch all other exceptions. This is likely due to a larger error that will make the program break. Tell user, quit.
            {
                MessageBox.Show("Critical Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }

            //Since we are reading data, there needs to be a try-catch for any errors we may encounter with reading
            try
            {
                //Create the StreamReader object pointed at the file for the current date and column type
                using StreamReader dailyReader = new StreamReader(@".\data\daily\" + currentDateString + ".txt");

                //Have the StreamReader keep going until end of file is reached
                while (!dailyReader.EndOfStream)
                {
                    //Get, in a string format, the line from the file
                    data = dailyReader.ReadLine();

                    //If the data is a true or false, we need to parse it to a boolean because it is going to be used as one later
                    //Else just add the string as a task, which is used as a string
                    if (string.Equals(data, "true", StringComparison.OrdinalIgnoreCase) || string.Equals(data, "false", StringComparison.OrdinalIgnoreCase))
                    {
                        daily.Add(Boolean.Parse(data));
                    }
                    else
                    {
                        daily.Add(data);
                    }
                }

                //Clear the FlowLayoutPanel
                FlowLayoutPanelDaily.Controls.Clear();

                //For loop to run half the number of times as there are items in the arraylist
                //This is because every iteration we are getting two items. So the count will increase by 2 every time
                for (int i = 0; i < daily.Count; i += 2)
                {
                    //Create a new CheckBox object using the arraylist to get the data
                    //Set other proper static things as well
                    CheckBox taskCheckBox = new CheckBox
                    {
                        //Set autosize to true so it fits properly
                        AutoSize = true,

                        //Set the text to the task in the arraylist at the current position
                        Text = daily[i].ToString(),

                        //Set the complete status to the boolean value of the checked status in the arraylist. This is task + 1
                        Checked = (Boolean)daily[i + 1],

                        //Set the name of the CheckBox to the task as well, since it's dynamically added this is the easiest way to take care of this
                        Name = daily[i].ToString()
                    };

                    //Add the CheckBox mouse operation events to the newly created Checkbox
                    taskCheckBox.MouseUp += new MouseEventHandler(CheckBox_MouseUp);

                    //Add the newly created CheckBox to the FlowLayoutPanel
                    FlowLayoutPanelDaily.Controls.Add(taskCheckBox);
                }

                //Put the add button back into the column since it was cleared
                PlaceAddButton("FlowLayoutPanelDaily");
            }
            catch (FileNotFoundException) //catch a file not found exception
            {

                //Create a file with the current date
                using FileStream dailyFile = File.Create(@".\data\daily\" + currentDateString + ".txt");

                //We still need to place the button even if there is no data
                PlaceAddButton("FlowLayoutPanelDaily");
            }
            catch (Exception) //catch all other exceptions. This is likely due to a larger error that will make the program break. Tell user, quit.
            {
                MessageBox.Show("Critical Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }

            //Since we are reading data, there needs to be a try-catch for any errors we may encounter with reading
            try
            {

                //Create the StreamReader object pointed at the file for the current date and column type
                using StreamReader todoReader = new StreamReader(@".\data\todo\" + currentDateString + ".txt");

                //Have the StreamReader keep going until end of file is reached
                while (!todoReader.EndOfStream)
                {
                    //Get, in a string format, the line from the file
                    data = todoReader.ReadLine();

                    //If the data is a true or false, we need to parse it to a boolean because it is going to be used as one later
                    //Else just add the string as a task, which is used as a string
                    if (string.Equals(data, "true", StringComparison.OrdinalIgnoreCase) || string.Equals(data, "false", StringComparison.OrdinalIgnoreCase))
                    {
                        todo.Add(Boolean.Parse(data));
                    }
                    else
                    {
                        todo.Add(data);
                    }
                }

                //Clear the FlowLayoutPanel
                FlowLayoutPanelTodo.Controls.Clear();

                //For loop to run half the number of times as there are items in the arraylist
                //This is because every iteration we are getting two items. So the count will increase by 2 every time
                for (int i = 0; i < todo.Count; i += 2)
                {
                    //Create a new CheckBox object using the arraylist to get the data
                    //Set other proper static things as well
                    CheckBox taskCheckBox = new CheckBox
                    {
                        //Set autosize to true so it fits properly
                        AutoSize = true,

                        //Set the text to the task in the arraylist at the current position
                        Text = todo[i].ToString(),

                        //Set the complete status to the boolean value of the checked status in the arraylist. This is task + 1
                        Checked = (Boolean)todo[i + 1],

                        //Set the name of the CheckBox to the task as well, since it's dynamically added this is the easiest way to take care of this
                        Name = todo[i].ToString()
                    };

                    //Add the CheckBox mouse operation events to the newly created Checkbox
                    taskCheckBox.MouseUp += new MouseEventHandler(CheckBox_MouseUp);

                    //Add the newly created CheckBox to the FlowLayoutPanel
                    FlowLayoutPanelTodo.Controls.Add(taskCheckBox);
                }

                //Put the add button back into the column since it was cleared
                PlaceAddButton("FlowLayoutPanelTodo");
            }
            catch (FileNotFoundException) //catch a file not found exception
            {
                //Create a file with the current date
                using FileStream todoFile = File.Create(@".\data\todo\" + currentDateString + ".txt");

                //We still need to place the button even if there is no data
                PlaceAddButton("FlowLayoutPanelTodo");
            }
            catch (Exception) //catch all other exceptions. This is likely due to a larger error that will make the program break. Tell user, quit.
            {
                MessageBox.Show("Critical Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void SaveData()
        {
            //Function that saves the data for all 3 panels at the given date

            //Since we are writing data, there needs to be a try-catch for any errors we may encounter with writing
            try
            {

                //Create the StreamWriter object pointed at the file for the current date and column type
                using StreamWriter habitsWriter = new StreamWriter(@".\data\habits\" + currentDateString + ".txt");

                //For loop to run half the number of times as there are items in the arraylist
                //This is because every iteration we are getting two items. So the count will increase by 2 every time
                for (int i = 0; i < habits.Count; i += 2)
                {
                    //Save the task on one line
                    habitsWriter.WriteLine(habits[i].ToString());

                    //Save the complete status on another line
                    habitsWriter.WriteLine(habits[i + 1].ToString());
                }
            }
            catch (Exception) //By this point there should be a file for the given date. If there is a bigger issue, it will cause issues. Tell user, quit.
            {
                MessageBox.Show("Critical Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }

            //Since we are writing data, there needs to be a try-catch for any errors we may encounter with writing
            try
            {
                //Create the StreamWriter object pointed at the file for the current date and column type
                using StreamWriter dailyWriter = new StreamWriter(@".\data\daily\" + currentDateString + ".txt");

                //For loop to run half the number of times as there are items in the arraylist
                //This is because every iteration we are getting two items. So the count will increase by 2 every time
                for (int i = 0; i < daily.Count; i += 2)
                {
                    //Save the task on one line
                    dailyWriter.WriteLine(daily[i].ToString());

                    //Save the complete status on another line
                    dailyWriter.WriteLine(daily[i + 1].ToString());
                }
            }
            catch (Exception) //By this point there should be a file for the given date. If there is a bigger issue, it will cause issues. Tell user, quit.
            {
                MessageBox.Show("Critical Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }

            //Since we are writing data, there needs to be a try-catch for any errors we may encounter with writing
            try
            {
                //Create the StreamWriter object pointed at the file for the current date and column type
                using StreamWriter todoWriter = new StreamWriter(@".\data\todo\" + currentDateString + ".txt");

                //For loop to run half the number of times as there are items in the arraylist
                //This is because every iteration we are getting two items. So the count will increase by 2 every time
                for (int i = 0; i < todo.Count; i += 2)
                {
                    //Save the task on one line
                    todoWriter.WriteLine(todo[i].ToString());

                    //Save the complete status on another line
                    todoWriter.WriteLine(todo[i + 1].ToString());
                }
            }
            catch (Exception) //By this point there should be a file for the given date. If there is a bigger issue, it will cause issues. Tell user, quit.
            {
                MessageBox.Show("Critical Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
    }
}
