using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaritaDividendsApp.Controllers
{
    internal class New_Dividend_Controller : Models.Dividends_Model
    {
        SqlConnection connection = new SqlConnection("Data Source=NITRO5;Initial Catalog=Dividends_DB;Persist Security Info=True;User ID=root;Password=root;MultipleActiveResultSets=true");
        public bool SaveDividends(Models.Dividends_Model dividends, string securityDesc, string paymentDate) //Save dividends actions
        {
            

        connection.Open();
            
                try
                {

                    SqlCommand cmd = connection.CreateCommand(); //creating a new command
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO [dividends] (symbol_code,payment_date,record_date,status_id)  SELECT symbol_code[symbol_code],'" + paymentDate + "'[payment_date],'" + DateTime.Now + "'[record_date],1[status_id] FROM [securities] WHERE cast([description]as varchar) =cast('" + securityDesc + "'as varchar);";
                    cmd.ExecuteNonQuery(); //Exectue Query
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex + "\nData Not saved.", "Fail"); //exception message
                }
            connection.Close();
 

            return true;
        }

        public bool DeleteDividends(Models.Dividends_Model dividends, string securityDesc, string paymentDate, string recordDate)//delete dividends action
        {

            connection.Open();

            try
            {
                SqlCommand cmd = connection.CreateCommand(); //create an SQL command
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM [dividends] WHERE [symbol_code] = (SELECT [symbol_code] FROM [securities] WHERE cast([description] as varchar) = cast('" + securityDesc + "' as varchar) AND [payment_date] = '" + paymentDate + "'AND [record_date]  = '"+recordDate+"')";
                int rowCount = cmd.ExecuteNonQuery(); //execute query
                if (rowCount <= 0) //checking the return result of the row
                {
                    MessageBox.Show("Security does not exisit. Try adding it first", "Delete Error"); //validation error
                }
                else
                {
                    MessageBox.Show("Data Deleted Sucessfully", "Successful"); //validation Message
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "\nData Not saved.", "Fail");
            }

            connection.Close();
            return true;
        }

        public bool ApproveDividends(Models.Dividends_Model dividends, string securityDesc, string paymentDate, string recordDate) //approve Dividens action
        {

            connection.Open();

            try
            {

                SqlCommand cmd = connection.CreateCommand(); //create an SQL command
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE [dividends] SET [status_id] = 2 WHERE [symbol_code] = (SELECT [symbol_code] FROM [securities] WHERE cast([description] as varchar) = cast('" + securityDesc + "' as varchar) AND [payment_date] = '" + paymentDate + "'AND [record_date]  = '" + recordDate + "')";
        int rowCount = cmd.ExecuteNonQuery(); //execute SQL query
                if (rowCount <= 0)
                {
                    MessageBox.Show("Security does not exisit. Try adding it first", "Delete Error"); //validation error
                }
                else
                {
                    MessageBox.Show("Security is now active.", "Successful"); //validation Message
                }

            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex + "\nData Not saved.", "Fail");
            }

            connection.Close();
            return true;
        }

        public bool CancelDividends(Models.Dividends_Model dividends, string securityDesc, string paymentDate, string recordDate)//cancel dividends actions
        {

            connection.Open();

            try
            {

                SqlCommand cmd = connection.CreateCommand();//create an SQL command
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE [dividends] SET [status_id] = 3 WHERE [symbol_code] = (SELECT [symbol_code] FROM [securities] WHERE cast([description] as varchar) = cast('" + securityDesc + "' as varchar) AND [payment_date] = '" + paymentDate + "' AND [record_date]  = '"+recordDate+"')";
                int rowCount = cmd.ExecuteNonQuery();//execute SQL query
                if (rowCount <= 0)
                {
                    MessageBox.Show("Security does not exisit. Try adding it first", "Delete Error"); //validation error
                }
                else
                {
                    MessageBox.Show("Security is now canceled.", "Successful"); //validation Message
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Security Field Empty\n" + ex, "Invalid Entry");
            }

            connection.Close();
            return true;
        }

    }
}
