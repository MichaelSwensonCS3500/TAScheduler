using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Teaching_Assistant;

namespace TAScheduler
{
    public partial class Form1 : Form
    {
        private static int idCounter = 0;
        private List<Labs> addedLabs = new List<Labs>();
        private StringBuilder mondaysb = new StringBuilder();
        private StringBuilder tuesdaysb = new StringBuilder();
        private StringBuilder wednesdaysb = new StringBuilder();
        private StringBuilder thursdaysb = new StringBuilder();
        private StringBuilder fridaysb = new StringBuilder();
        private StringBuilder saturdaysb = new StringBuilder();

        public Form1()
        {
            this.DoubleBuffered = true;
            InitializeComponent();
            
        }

        private void populateLabList()
        {
            foreach (Labs l in addedLabs.OrderBy(l => l.LabDay))
            {
                hoursAvailableChkList.Items.Add(l.ToString());
            }
        }

        private void addLabBtn_Click(object sender, EventArgs e)
        {
            DayOfWeek checkedDay = DayOfWeek.Sunday;
            foreach (int day in checkedListBox1.CheckedIndices)
            {
                switch (day)
                {
                    case 0:
                        checkedDay = DayOfWeek.Sunday;
                        break;
                    case 1:
                        checkedDay = DayOfWeek.Monday;
                        mondaysb.Append(String.Format("Start: {0:t}, End: {1:t}\n", dateTimePicker1.Value, dateTimePicker2.Value));
                        mondayBx.Text = mondaysb.ToString();
                        break;
                    case 2:
                        checkedDay = DayOfWeek.Tuesday;
                        tuesdaysb.Append(String.Format("Start: {0:t}, End: {1:t}\n", dateTimePicker1.Value, dateTimePicker2.Value));
                        tuesdayBx.Text = tuesdaysb.ToString();
                        break;
                    case 3:
                        checkedDay = DayOfWeek.Wednesday;
                        wednesdaysb.Append(String.Format("Start: {0:t}, End: {1:t}\n", dateTimePicker1.Value, dateTimePicker2.Value));
                        wednesdayBx.Text = wednesdaysb.ToString();
                        break;
                    case 4:
                        checkedDay = DayOfWeek.Thursday;
                        thursdaysb.Append(String.Format("Start: {0:t}, End: {1:t}\n", dateTimePicker1.Value, dateTimePicker2.Value));
                        thursdayBx.Text = thursdaysb.ToString();
                        break;
                    case 5:
                        checkedDay = DayOfWeek.Friday;
                        fridaysb.Append(String.Format("Start: {0:t}, End: {1:t}\n", dateTimePicker1.Value, dateTimePicker2.Value));
                        fridayBx.Text = fridaysb.ToString();
                        break;
                    case 6:
                        checkedDay = DayOfWeek.Saturday;
                        saturdaysb.Append(String.Format("Start: {0:t}, End: {1:t}\n", dateTimePicker1.Value, dateTimePicker2.Value));
                        break;
                    default:
                        MessageBox.Show("No boxes were Checked");
                        return;
                }
                addedLabs.Add(new Labs(checkedDay, dateTimePicker1.Value.TimeOfDay, dateTimePicker2.Value.TimeOfDay, idCounter));
            }
            //MethodInvoker checkboxInvoker = new MethodInvoker(() => hoursAvailableChkList.Invalidate());
            //checkboxInvoker.Invoke();
            idCounter++;
            populateLabList();
        }
    }
}
