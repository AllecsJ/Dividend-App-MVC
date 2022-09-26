using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaritaDividendsApp.Models
{
     class Securities_Model
    {

        private string symbol_Code;
        private string description;
        private int status_Id;


        public string symbolCode { get => symbol_Code; set => symbol_Code = value; }
        public string securityDesc { get => description; set => description = value; }
        public int statusId { get => status_Id; set => status_Id = value; }

    }
}
