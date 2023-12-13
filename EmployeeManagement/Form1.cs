using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EmployeeManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try {
                Computations computation = new Computations();
                dgvEmployee.DataSource = computation.GetAll();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Internal error occured");
            }
           
 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; 
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Computations computations = new Computations();
                Employee employee = new Employee()
                {
                    Employee_ID = txtEmployeeID.Text,
                    Name = txtName.Text,
                    Phone = txtCountryCode.Text + txtPhoneNumber.Text,
                    Region = txtRegion.Text,
                    City = txtCity.Text,
                    Sub_City = txtSubCity.Text,
                    Location_Special_Name = txtLocationSpecialName.Text,
                    Data_Update_Date = DateTime.MinValue.Date.ToString(),
                    Active_Ind = cmbActiveInd.Text == "TRUE" ? true : false
                };
                if (computations.CheckEmployeeDuplication(employee.Employee_ID))
                {
                    MessageBox.Show("Employee already exists!");
                }
                else
                {
                    computations.Add(employee);
                    dgvEmployee.DataSource = computations.GetAll();
                    MessageBox.Show("Regestered Successful!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Internal error occured");
            }
            
           
        }

        private void lblEmployeeID_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Computations computations = new Computations();
                Employee employee = new Employee()
                {
                    Employee_ID = labelOriginalEmployoeeID.Text,
                    Name = txtName.Text,
                    Phone = txtCountryCode.Text + txtPhoneNumber.Text,
                    Region = txtRegion.Text,
                    City = txtCity.Text,
                    Sub_City = txtSubCity.Text,
                    Location_Special_Name = txtLocationSpecialName.Text,
                    Data_Update_Date = DateTime.Now.Date.ToString(),
                    Active_Ind = cmbActiveInd.Text == "TRUE" ? true : false
                };
                computations.Update(employee);
                dgvEmployee.DataSource = computations.GetAll();
                MessageBox.Show("Update is Successful!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Internal error occured");
            }
         

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Computations computations = new Computations();
                dgvEmployee.DataSource = computations.GetByName(txtSearchByName.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Internal error occured");
            }
           

        }

        private void dgvEmployee_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtEmployeeID.Text = dgvEmployee.CurrentRow.Cells[0].Value.ToString();
                labelOriginalEmployoeeID.Text = dgvEmployee.CurrentRow.Cells[0].Value.ToString();
                txtName.Text = dgvEmployee.CurrentRow.Cells[1].Value.ToString();
                txtPhoneNumber.Text = dgvEmployee.CurrentRow.Cells[2].Value.ToString().Substring(4);
                txtRegion.Text = dgvEmployee.CurrentRow.Cells[3].Value.ToString();
                txtCity.Text = dgvEmployee.CurrentRow.Cells[4].Value.ToString();
                txtSubCity.Text = dgvEmployee.CurrentRow.Cells[5].Value.ToString();
                txtLocationSpecialName.Text = dgvEmployee.CurrentRow.Cells[6].Value.ToString();
                cmbActiveInd.Text = dgvEmployee.CurrentRow.Cells[8].Value.ToString() == "True" ? "TRUE" : "FALSE";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Internal error occured");
            }
           


        }
    }
}
