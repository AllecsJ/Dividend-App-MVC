using BaritaDividendsApp.Controllers;
using BaritaDividendsApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BaritaDividendsApp
{
    public partial class newDividends : Form 
    {
        SqlConnection connection = new SqlConnection("Data Source=NITRO5;Initial Catalog=Dividends_DB;Persist Security Info=True;User ID=root;Password=root");
        New_Dividend_Controller dividend_Controller = new New_Dividend_Controller();
        Dividends_Model dividends = new Dividends_Model();


        public newDividends()
        {
            InitializeComponent();
            fillSecuritylistBox();
        }

        private void fillSecuritylistBox() //load the dropdown menu with data from DB
        {
            try
            {
                connection.Open(); //open connection
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT [description] FROM [securities]"; //showing the description
                SqlDataReader sqlReader = cmd.ExecuteReader(); // gets results from query

                while (sqlReader.Read())
                {
                    String securityDesc = sqlReader.GetString(0);
                    securityComboBox.Items.Add(securityDesc);
                    this.securityComboBox.SelectedIndex = 0;
                }

                sqlReader.Close();
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message, "Cannot Load Security Dropdown Menu");
            }
            
        }

        private void f2linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)//Click event
        {
            Form   f1 = new viewDividends();
            f1.Show(this);//show View dividend form
            Visible = false;//hide current form
        }

        private void CloseBtn_Click(object sender, EventArgs e) //click event
        {
            this.Close(); //close form
        }

        private void dividendsBindingNavigatorSaveItem_Click(object sender, EventArgs e) //Binding event
        {
            this.Validate();
            this.dividendsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dividends_DBDataSet);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            deleteBtn.Hide();
            approveBtn.Hide();
            cancelBtn.Hide();

        }

        private void securityComboBox_SelectedIndexChanged(object sender, EventArgs e)//Item in the dropdown selected
        {
            String securityDesc = securityComboBox.SelectedItem.ToString(); //stores the item in the dropdown list
            securityLabel.Text = securityDesc; //store description
        }

        private void saveBtn_Click(object sender, EventArgs e)//Button click event
        {
            var confirmResult = MessageBox.Show("Are you sure to Save this item ??",
                                     "Confirm Save!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
             
                String securityDesc = securityComboBox.SelectedItem.ToString(); //Store the result from the combo box
                String paymentDate = paymentDateTimePicker.Value.ToShortDateString(); //store payment date from date picke

                if (securityComboBox.Text == null || securityComboBox.Text == "") //Validation Check
                {
                    MessageBox.Show("Please select a security,", "Required Field"); // show validation error message
                }
                else if (paymentDateTimePicker.Text == null || paymentDateTimePicker.Text == "")
                {
                    MessageBox.Show("Please select a Payment Date", "Required Field"); // sshow validation error message
                }
                else
                {
                    if (dividend_Controller.SaveDividends(dividends, securityDesc, paymentDate) )
                    {
                        MessageBox.Show("Record Saved Sucessfully", "Successful");
                    }
                    else
                    { 
                        MessageBox.Show(this, "Dividend Did not save", "ERROR");
                    }
                    Form f1 = new viewDividends();
                    f1.Show(this);//show View dividend form
                    Visible = false;//hide current form

                }      
            }
            else
            {
                
            }


        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

            var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
            
            String securityDesc = securityComboBox.SelectedItem.ToString(); //store selection from combo box

                String paymentDate = paymentDateTimePicker.Value.ToShortDateString(); //store selection from date picker

                if (securityComboBox.Text == null || securityComboBox.Text == "") //Validation Check
                {
                    MessageBox.Show("Please select a security,", "Required Field"); // show validation error message
                }
                else if (paymentDateTimePicker.Text == null || paymentDateTimePicker.Text == "")
                {
                    MessageBox.Show("Please select a Payment Date", "Required Field"); // show validation error message
                }
                else
                {
                    if (dividend_Controller.DeleteDividends(dividends, securityDesc, paymentDate, DateTime.Now.ToString()))
                    {
                        MessageBox.Show("Record Deleted Sucessfully", "Successful");
                    }
                    else
                    {
                        MessageBox.Show(this, "Dividend was not deleted", "ERROR");
                    }
                    Form f1 = new viewDividends();
                    f1.Show(this);//show View dividend form
                    Visible = false;//hide current form
                }
            }
            else
            {
                MessageBox.Show(this, "Operation did not delete", "ERROR");
            }
        }

        private void approveBtn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to approve this item ??",
                                     "Confirm Approve!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                
                if (securityComboBox.Text == null || securityComboBox.Text == "") //Validation Check
                {
                    MessageBox.Show("Please select a security,", "Required Field"); // show validation error message
                }
                else if (paymentDateTimePicker.Text == null || paymentDateTimePicker.Text == "")
                {
                    MessageBox.Show("Please select a Payment Date", "Required Field"); // sshow validation error message
                }
                else
                {
                    String securityDesc = securityComboBox.SelectedItem.ToString(); //store selection from combo box

                    String paymentDate = paymentDateTimePicker.Value.ToShortDateString(); //store selection from date picker

                    if (dividend_Controller.ApproveDividends(dividends, securityDesc, paymentDate, DateTime.Now.ToString()))
                    {
                        MessageBox.Show("Record Approved Sucessfully", "Successful");
                    }
                    else
                    {
                        MessageBox.Show(this, "Dividend was not approved", "ERROR");
                    }

                }
            }
            else
            {
                MessageBox.Show(this, "Operation did not Approve", "ERROR");

            }

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to Cancel this item ??",
                                     "Confirm Cancel!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {

                if (securityComboBox.Text == null || securityComboBox.Text == "") //Validation Check
                {
                    MessageBox.Show("Please select a security,", "Required Field"); // show validation error message
                }
                else if (paymentDateTimePicker.Text == null || paymentDateTimePicker.Text == "")
                {
                    MessageBox.Show("Please select a Payment Date", "Required Field"); // sshow validation error message
                }
                else
                {
                    String securityDesc = securityComboBox.SelectedItem.ToString();//store selection from combo box
                    String paymentDate = paymentDateTimePicker.Value.ToShortDateString();//store selection from date picker

                    if (dividend_Controller.CancelDividends(dividends, securityDesc, paymentDate, DateTime.Now.ToString()))
                    {
                        MessageBox.Show("Record Cancelled Sucessfully", "Successful");
                    }
                    else
                    {
                        MessageBox.Show(this, "Dividend was not approved", "ERROR");
                    }

                }

            }
            else
            {
                MessageBox.Show(this, "Operation did not cancel", "ERROR");
            }
        }
    }
}
