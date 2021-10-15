using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Web;
using SAB_B1connection;
using SAPbobsCOM;


namespace _PrimeiroWebService.Models
{
    public class ItemModel
    {
        [Controllers.ModelController(ColumnName = "ItemCode")]
        public string ItemCode { get; set; }

        [Controllers.ModelController(ColumnName = "ItemName")]
        public string ItemName { get; set; }

   
    }

}