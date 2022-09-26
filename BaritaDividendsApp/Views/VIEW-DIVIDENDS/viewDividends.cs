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
using System.Security;
using BaritaDividendsApp.Controllers;
using BaritaDividendsApp.Models;

namespace BaritaDividendsApp
{
    public partial class viewDividends : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=NITRO5;Initial Catalog=Dividends_DB;Persist Security Info=True;User ID=root;Password=root;MultipleActiveResultSets=true");

        New_Dividend_Controller dividend_Controller = new New_Dividend_Controller();
        Dividends_Model dividends = new Dividends_Model();

        public viewDividends()
        {
            InitializeComponent();//loads everything
            fillSecurityComboBox(); //populates the dropdown menu
            fillStatusComboBox(); //populate dropdown menu

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)//CLICKED ELEMENT
        {
            newDividends f2 = new newDividends();
            f2.Show(this);
            Visible = false; //CREATED FIRST FORM OBKECT AND HIDE THE ORIGINAL FORM
        }

        private void closebtn1_Click(object sender, EventArgs e)//CLICKED ELEMENT
        {
            this.Close();//CLOSE FORM
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void fillSecurityComboBox() //load the dropdown menu with data from DB
        {
            try
            {
                connection.Open(); //open connection
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT  DISTINCT CAST(s.[description] AS varchar) from [dividends] d RIGHT JOIN  [securities]s on s.symbol_code = d.symbol_code"; //showing distinct records in description
                SqlDataReader sqlReader = cmd.ExecuteReader(); // gets results from query

                while (sqlReader.Read()) //read all returned rows in the DB
                {
                    String securityDesc = sqlReader.GetString(0);
                    securityComboBox.Items.Add(securityDesc);//add items to the dropdown list
                    this.securityComboBox.SelectedIndex = 0; //sets the first value of the dropdown list

                }

                sqlReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cannot Load Security Dropdown Menu"); //error catch
            }
            connection.Close();
        }

        private void fillStatusComboBox()
        {
            try
            {
                connection.Open(); //open connection
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select  distinct Cast(s.status_name as varchar) from [dividends] d LEFT JOIN  [status_codes] s on s.[status_id] =d.[status_id] and s.status_id is not null;\r\n"; //showing distinct records in description
                SqlDataReader sqlReader = cmd.ExecuteReader(); // gets results from query

                while (sqlReader.Read())//read all returned rows in the DB
                {
                    String securityStatus = sqlReader.GetString(0);
                    statusComboBox.Items.Add(securityStatus);//add items to the dropdown list
                    this.statusComboBox.SelectedIndex = 0;//sets the first value of the dropdown list

                }

                sqlReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cannot Load status Dropdown Menu");//error catch
            }
            connection.Close();
        }

        private void securityComboBox_SelectedIndexChanged(object sender, EventArgs e) //Click Event
        {
            String securityDesc = securityComboBox.SelectedItem.ToString(); //stores the item in the dropdown list
            securityComboBox.Text = securityDesc; //store description
        }

        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String securityStatus = statusComboBox.SelectedItem.ToString(); //stores the item in the dropdown list
            statusComboBox.Text = securityStatus; //store description
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (securityComboBox.Text == null || securityComboBox.Text == "") //Validation Check
            {
                MessageBox.Show("Please select a security,", "Required Field"); // show validation error message
            }
            else if (statusComboBox.Text == null || statusComboBox.Text == "")
            {
                MessageBox.Show("Please select status ", "Required Field"); // sshow validation error message
            }
            else
            {
                String securityDesc = securityComboBox.SelectedItem.ToString(); //Store the result from the combo box
                String startDate = startDateTimePicker.Value.ToShortDateString(); //store payment date from date picker
                String endDate = endDateTimePicker.Value.ToShortDateString(); //store payment date from date picker
                String securityStatus = statusComboBox.SelectedItem.ToString(); //Store the result from the combo box


  
                try
                {
                    connection.Open(); //open connection
                    SqlCommand cmd1 = connection.CreateCommand();
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = "SELECT [symbol_code] FROM [securities]  WHERE  CAST([description] AS VARCHAR) = CAST('" + securityDesc + "'AS VARCHAR)"; //showing the description
                    SqlDataReader sqlReader = cmd1.ExecuteReader(); // gets results from query
                    sqlReader.Read();
                    String securityCode = sqlReader.GetString(0);
                    sqlReader.Close();
                    //connection.Open(); //open connection
                    SqlCommand cmd2 = connection.CreateCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = "SELECT [status_id] FROM [status_codes] WHERE CAST([status_name] as VARCHAR) = CAST('" + securityStatus + "'as VARCHAR) --    CAST([description] AS VARCHAR) = CAST('" + securityDesc + "'AS VARCHAR)"; //showing the description
                    SqlDataReader sqlReader2 = cmd2.ExecuteReader(); // gets results from query
                    sqlReader2.Read();
                    int securityId = sqlReader2.GetInt32(0);
                    sqlReader2.Close();
                    ////displayData(0);//show data in the grid
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT d.div_id, s.description, d.payment_date, record_date,c.status_name FROM dividends d left join securities s  on s.symbol_code = d.symbol_code  left join status_codes c on c.status_id = d.status_id where s.symbol_code = '" + securityCode + "' and d.payment_date = '" + startDate + "' and d.record_date =  '" + endDate + "' and d.status_id = '" + securityId + "'";
                    cmd.ExecuteNonQuery(); 
                    DataTable dividends = new DataTable();
                    SqlDataAdapter dataAdapt = new SqlDataAdapter(cmd);
                    dataAdapt.Fill(dividends);
                    dividendDataGrid.DataSource = dividends;
                    connection.Close();

                    
                   

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex + "\nData Not saved.", "Fail"); //exception message
                }
            }
        }

        public void displayData(int status) //selects different queries based on the status of the security
        {
            if (status == 1) //status pending
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT d.div_id, s.description, d.payment_date, record_date,c.status_name from dividends d left join securities s  on s.symbol_code = d.symbol_code left join status_codes c on c.status_id = d.status_id WHERE c.status_id = '"+status+"' ";
                cmd.ExecuteNonQuery();
                DataTable dividends = new DataTable();
                SqlDataAdapter dataAdapt = new SqlDataAdapter(cmd);
                dataAdapt.Fill(dividends);
                dividendDataGrid.DataSource = dividends;
                connection.Close();
            }
            else if (status == 2)//status active
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT d.div_id, s.description, d.payment_date, record_date,c.status_name from dividends d left join securities s  on s.symbol_code = d.symbol_code left join status_codes c on c.status_id = d.status_id WHERE c.status_id = '" + status + "' ";
                cmd.ExecuteNonQuery();
                DataTable dividends = new DataTable();
                SqlDataAdapter dataAdapt = new SqlDataAdapter(cmd);
                dataAdapt.Fill(dividends);
                dividendDataGrid.DataSource = dividends;
                connection.Close();
            }
            else if(status == 3)//status canceled
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT d.div_id, s.description, d.payment_date, record_date,c.status_name from dividends d left join securities s  on s.symbol_code = d.symbol_code left join status_codes c on c.status_id = d.status_id WHERE c.status_id = '" + status + "' ";
                cmd.ExecuteNonQuery();
                DataTable dividends = new DataTable();
                SqlDataAdapter dataAdapt = new SqlDataAdapter(cmd);
                dataAdapt.Fill(dividends);
                dividendDataGrid.DataSource = dividends;
                connection.Close();
            }else if(status == 0) //all status
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT d.div_id, s.description, d.payment_date, record_date,c.status_name from dividends d left join securities s  on s.symbol_code = d.symbol_code left join status_codes c on c.status_id = d.status_id";
                cmd.ExecuteNonQuery();
                DataTable dividends = new DataTable();
                SqlDataAdapter dataAdapt = new SqlDataAdapter(cmd);
                dataAdapt.Fill(dividends);
                dividendDataGrid.DataSource = dividends;
                connection.Close();
            }

        }

        private void editLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            
            
            try
            {

                displayData(1);//show data in the grid
                connection.Open();
                String securityDesc = securityComboBox.SelectedItem.ToString(); //Store the result from the combo box
                String startDate = startDateTimePicker.Value.ToShortDateString(); //store payment date from date picker
                String endDate = endDateTimePicker.Value.ToShortDateString(); //store payment date from date picker
                String securityStatus = statusComboBox.SelectedItem.ToString(); //Store the result from the combo box


                SqlCommand cmd = connection.CreateCommand(); //creating a new command
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT d.div_id, s.description, d.payment_date, record_date,c.status_name from dividends d left join securities s  on s.symbol_code = d.symbol_code left join status_codes c on c.status_id = d.status_id where c.status_id = 1";
                cmd.ExecuteNonQuery(); //Exectue Query


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "\nData Not saved.", "Fail"); //exception message
            }
            connection.Close();
            displayData(1);//show data in the grid
        }

        private void DeleteLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            displayData(1);//show data in the grid
            connection.Open();


            String securityDesc = securityComboBox.SelectedItem.ToString(); //Store the result from the combo box
            String startDate = startDateTimePicker.Value.ToShortDateString(); //store payment date from date picker
            String endDate = endDateTimePicker.Value.ToShortDateString(); //store payment date from date picker
            String securityStatus = statusComboBox.SelectedItem.ToString(); //Store the result from the combo box

            

            dividend_Controller.DeleteDividends(dividends, securityDesc, startDate, endDate); //run the delete commands


            SqlCommand cmd = connection.CreateCommand(); //creating a new command
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT d.div_id, s.description, d.payment_date, record_date,c.status_name from dividends d left join securities s  on s.symbol_code = d.symbol_code left join status_codes c on c.status_id = d.status_id  where c.status_id = 1";
            cmd.ExecuteNonQuery(); //Exectue Query
            connection.Close();
            displayData(1);//show data in the grid
        }

        private void approveLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            displayData(1);//show data in the grid
            connection.Open();
            String securityDesc = securityComboBox.SelectedItem.ToString(); //Store the result from the combo box
            String startDate = startDateTimePicker.Value.ToShortDateString(); //store payment date from date picker
            String endDate = endDateTimePicker.Value.ToShortDateString(); //store payment date from date picker
            String securityStatus = statusComboBox.SelectedItem.ToString(); //Store the result from the combo box

            dividend_Controller.ApproveDividends(dividends, securityDesc, startDate, endDate);

            SqlCommand cmd = connection.CreateCommand(); //creating a new command
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT d.div_id, s.description, d.payment_date, record_date,c.status_name from dividends d left join securities s  on s.symbol_code = d.symbol_code left join status_codes c on c.status_id = d.status_id where c.status_id = 1";
            cmd.ExecuteNonQuery(); //Exectue Query
            connection.Close();
            displayData(1);
        }

        private void cancelLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)//click event
        {
            displayData(2);//show data in the grid
            //connection.Open();

            

            String securityDesc = securityComboBox.SelectedItem.ToString(); //Store the result from the combo box
            String startDate = startDateTimePicker.Value.ToShortDateString(); //store payment date from date picker
            String endDate = endDateTimePicker.Value.ToShortDateString(); //store payment date from date picker
            String securityStatus = statusComboBox.SelectedItem.ToString(); //Store the result from the combo box

            dividend_Controller.CancelDividends(dividends, securityDesc, startDate, endDate); //run the  dividend Controller cancel
            displayData(2);//show data in the grid
        }

        private void dividendDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
