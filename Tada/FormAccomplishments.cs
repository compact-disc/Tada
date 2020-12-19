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
using System.IO;

namespace Tada
{
    public partial class FormAccomplishments : Form
    {
        public FormAccomplishments()
        {
            //Constructor for the accomplishments form window
            InitializeComponent();

            //Get the stats of the user and set them on the screen
            GetStats();
        }

        private void GetStats()
        {
            //Method that calls the counting methods and sets the labels in the window to the given numbers

            //Integer week set by a method that return the number of accomplishments in the last week
            int week = CountData(7);

            //Integer month set by a method that return the number of accomplishments in the last month
            int month = CountData(30);

            //Set the label to the number of accomplishments
            LabelWeekNumber.Text = week.ToString();
            LabelMonthNumber.Text = month.ToString();
        }

        private int CountData(int days)
        {
            //Get the current time and date, set it to now
            DateTime currentDate = DateTime.Now;

            //Format a string in the proper file format
            string currentDateString = currentDate.ToString("MM-dd-yyyy");

            //String to capture the data read by the StreamReaders
            string data;

            //Integer to keep track of the number of accomplishments
            int total = 0;

            //For loop to run the number of days passed
            for(int i = 0; i < days; i++)
            {
                //Try-catch statement because we are reading from a file and there could be errors
                try
                {
                    //Set the StreamReader to the proper file
                    using StreamReader habitsReader = new StreamReader(@".\data\habits\" + currentDateString + ".txt");

                    //Read while the file has data
                    while (!habitsReader.EndOfStream)
                    {
                        //Set the data string to the line captured
                        data = habitsReader.ReadLine();

                        //If there is a true, that means that a task has been complete, add it to the total accomplishments
                        if (string.Equals(data, "true", StringComparison.OrdinalIgnoreCase))
                        {
                            total++;
                        }
                    }
                }
                catch (FileNotFoundException) //If there is no file, that means there is no data for that day, skip to the next for iteration.
                {
                    continue;
                }
                catch (Exception) //If there is another error it is likely going to break the window. Tell the user, quit the accomplishments window.
                {
                    MessageBox.Show("Critical error showing accomplishments!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }

                //Move the date one day backwards from today
                currentDate = currentDate.AddDays(-1);

                //Set the date string to the proper format for usage
                currentDateString = currentDate.ToString("MM-dd-yyyy");
            }

            //Get the current time and date, set it to now
            currentDate = DateTime.Now;

            //Format a string in the proper file format
            currentDateString = currentDate.ToString("MM-dd-yyyy");

            //For loop to run the number of days passed
            for (int i = 0; i < days; i++)
            {
                //Try-catch statement because we are reading from a file and there could be errors
                try
                {
                    //Set the StreamReader to the proper file
                    using StreamReader dailyReader = new StreamReader(@".\data\daily\" + currentDateString + ".txt");

                    //Read while the file has data
                    while (!dailyReader.EndOfStream)
                    {
                        //Set the data string to the line captured
                        data = dailyReader.ReadLine();

                        //If there is a true, that means that a task has been complete, add it to the total accomplishments
                        if (string.Equals(data, "true", StringComparison.OrdinalIgnoreCase))
                        {
                            total++;
                        }
                    }
                }
                catch (FileNotFoundException) //If there is no file, that means there is no data for that day, skip to the next for iteration.
                {
                    continue;
                }
                catch (Exception) //If there is another error it is likely going to break the window. Tell the user, quit the accomplishments window.
                {
                    MessageBox.Show("Critical error showing accomplishments!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }

                //Move the date one day backwards from today
                currentDate = currentDate.AddDays(-1);

                //Set the date string to the proper format for usage
                currentDateString = currentDate.ToString("MM-dd-yyyy");
            }

            //Get the current time and date, set it to now
            currentDate = DateTime.Now;

            //Format a string in the proper file format
            currentDateString = currentDate.ToString("MM-dd-yyyy");

            //For loop to run the number of days passed
            for (int i = 0; i < days; i++)
            {
                //Try-catch statement because we are reading from a file and there could be errors
                try
                {
                    //Set the StreamReader to the proper file
                    using StreamReader todoReader = new StreamReader(@".\data\todo\" + currentDateString + ".txt");

                    //Read while the file has data
                    while (!todoReader.EndOfStream)
                    {
                        //Set the data string to the line captured
                        data = todoReader.ReadLine();

                        //If there is a true, that means that a task has been complete, add it to the total accomplishments
                        if (string.Equals(data, "true", StringComparison.OrdinalIgnoreCase))
                        {
                            total++;
                        }
                    }
                }
                catch (FileNotFoundException) //If there is no file, that means there is no data for that day, skip to the next for iteration.
                {
                    continue;
                }
                catch (Exception) //If there is another error it is likely going to break the window. Tell the user, quit the accomplishments window.
                {
                    MessageBox.Show("Critical error showing accomplishments!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }

                //Move the date one day backwards from today
                currentDate = currentDate.AddDays(-1);

                //Set the date string to the proper format for usage
                currentDateString = currentDate.ToString("MM-dd-yyyy");
            }

            //Return the total number of accomplishments
            return total;
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            //The close button to close the window
            Close();
        }
    }
}
