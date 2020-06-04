using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSalesMVC.Models {
    public class Department {

        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();
        #endregion

        #region Constructors
        public Department() {
        }

        public Department(int id, string name) {
            Id = id;
            Name = name;
            
        }
        #endregion


        #region Methods
        
        public void AddSeller(Seller seller) {
            Sellers.Add(seller);
        }

        public double TotalSales(DateTime initial, DateTime final) {
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }

        #endregion
    }
}
