using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSalesMVC.Models.Enums;

namespace WebSalesMVC.Models {
    public class SalesRecord {
       
        #region Properties
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Double Amount { get; set; }
        public SaleStatus Status { get; set; }
        public Seller Seller { get; set; }
        #endregion

        #region Constructors
        public SalesRecord() {
        }
        public SalesRecord(int id, DateTime date, double amount, SaleStatus status, Seller seller) {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
        #endregion




    }
}
