using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Harrison_CourseProject_Part2
{
    public partial class MainForm : Form
    {
        public int EmployeesListBoxSelectedIndex { get; private set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // add item to the Employee listbox
            InputForm frmInput = new InputForm();

            using (frmInput)
            {
                DialogResult result = frmInput.ShowDialog();

                // see if input form was cancelled
                if (result == DialogResult.Cancel)
                    return;       // end the method since cancelled

                // get user's input and create Employee object
                string fName = frmInput.FirstNameTextBox.Text;
                string lName = frmInput.LastNameTextBox.Text;
                string ssn = frmInput.SSNTextBox.Text;
                string date = frmInput.HireDateTextBox.Text;
                DateTime hireDate = DateTime.Parse(date);
                string healthIns = frmInput.HealthInsuranceTextBox.Text;
                int lifeIns = int.Parse(frmInput.LifeInsuranceTextBox.Text);
                int vacation = int.Parse(frmInput.VacationDaysTextBox.Text);

                Benefits ben = new Benefits(healthIns, lifeIns, vacation);
                Employee emp = new Employee(fName,lName,ssn,hireDate, ben);

                // add the Employee object to the Employee list box
                EmployeesListBox.Items.Add(fName);
                EmployeesListBox.Items.Add(lName);
                EmployeesListBox.Items.Add(ssn);
                EmployeesListBox.Items.Add(date);

                // write all data to the file
                WriteEmpsToFile();

            }
        }

        private void WriteEmpsToFile()
        {
            string filename = "Employees.csv";

            StreamWriter sw = new StreamWriter(filename);

            foreach(Employee emp in EmployeesListBox.Items)
            {
                sw.WriteLine(emp.FirstName + ','
                    + emp.LastName + ','
                    + emp.SSN + ','
                    + emp.HireDate.ToShortDateString() + ','
                    + emp.BenefitsEmp.HealthInsurance + ','
                    + emp.BenefitsEmp.LifeInsurance + ','
                    + emp.BenefitsEmp.Vacation);
            }
            sw.Close();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            // remove the selected item from the Employee listbox
            int itemNumber = EmployeesListBoxSelectedIndex;

            if(itemNumber > -1)
            {
                EmployeesListBox.Items.RemoveAt(itemNumber);
                WriteEmpsToFile();
            }
            else
            {
                MessageBox.Show("Please select employee to remove.");
            }
        }

        private ListView GetEmployeesListBox()
        {
            return EmployeesListBox;
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            // clear the Employee listbox
            EmployeesListBox.Items.Clear();

            // read employees from the file
            string filename = "Employee.csv";
            StreamReader sr = new StreamReader(filename);

            while(sr.Peek() > -1)
            {
                string line = sr.ReadLine();
                string[] parts = line.Split(',');
                string firstName = parts[0];
                string lastName = parts[1];
                string ssn = parts[2];
                DateTime hireDate = DateTime.Parse(parts[3]);
                string healthIns = parts[4];
                int lifeIns = int.Parse(parts[5]);
                int vacation = int.Parse(parts[6]);

                Benefits ben = new Benefits(healthIns, lifeIns, vacation);
                Employee emp = new Employee(firstName, lastName, ssn, hireDate, ben);
                EmployeesListBox.Items.Add(emp);
                

            }
            sr.Close();
        }

        private void PrintPaycheckButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printing paychecks for all employees...");
        }

        private void EmployeesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
