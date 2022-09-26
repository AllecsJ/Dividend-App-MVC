using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaritaDividendsApp.Models
{
    internal class Dividends_Model
    {
        private int div_Id;
       private string symbol_Code;
        private DateTime payment_Date;
        private DateTime record_Date;
        private int status_Id;
        private string security_Desc;

       public int divId { get => div_Id; set => div_Id = value; }
       public string symbolCode { get => symbol_Code; set => symbol_Code = value; }
       public DateTime paymentDate { get => payment_Date; set => payment_Date = value; }
       public DateTime recordDate { get => record_Date; set => record_Date = value; }
       public int statusId { get => status_Id; set => status_Id = value; }
        
       public string securityDesc { get => security_Desc; set => security_Desc = value; }


    }
}
