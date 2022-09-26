using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaritaDividendsApp.Models
{
    internal class Status_Model
    {
        private int status_Id;
        private string status_Name;

        public int statusId { get => status_Id; set => status_Id = value; }
        public string statusName { get => status_Name; set => status_Name = value; }
    }
}
