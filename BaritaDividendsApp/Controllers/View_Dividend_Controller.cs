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

namespace BaritaDividendsApp.Controllers {
    internal class View_Dividend_Controller : Models.Dividends_Model    {
        SqlConnection connection = new SqlConnection("Data Source=NITRO5;Initial Catalog=Dividends_DB;Persist Security Info=True;User ID=root;Password=root;MultipleActiveResultSets=true");


        public bool SearchAllDividends(Models.Dividends_Model dividends, string securityDesc,string securityStatus,string startDate, string endDate)
        {
            
      
            return true;
        }

        public bool ViewEditDividends(Models.Dividends_Model dividends, string securityDesc, string securityStatus, string startDate, string endDate)
        {


            return true;
        }
        public bool ViewDeleteDividends(Models.Dividends_Model dividends, string securityDesc, string securityStatus, string startDate, string endDate)
        {


            return true;
        }

        public bool ViewApproveDividends(Models.Dividends_Model dividends, string securityDesc, string securityStatus, string startDate, string endDate)
        {


            return true;
        }

        public bool ViewCancelDividends(Models.Dividends_Model dividends, string securityDesc, string securityStatus, string startDate, string endDate)
        {


            return true;
        }
    }
}
