using System;
using System.Collections.Generic;

namespace StandaloneDatabase.Models
{
    public partial class SaleProduct
    {
        public string Id { get; set; }
        public string SaleId { get; set; }
        public string ProductId { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double TotalPrice { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
        public bool Active { get; set; }
        public string CategoryId { get; set; }
        public string SupplierCategoryId { get; set; }
        public string ProductName { get; set; }
        public int Box { get; set; }
        public double Squarefit { get; set; }
        public int DueBox { get; set; }
        public int DueQuantity { get; set; }
        public double DueSquarefit { get; set; }
        public int Status { get; set; }
        public DateTime Date { get; set; }
        public string BranchId { get; set; }
        public string SubcategoryId { get; set; }
        public int Order { get; set; }
        public double SaleProfit { get; set; }
        public bool IsProfitCalculated { get; set; }

        public virtual Category Category { get; set; }
        public virtual Product Product { get; set; }
        public virtual Sale Sale { get; set; }
        public virtual Subcategory Subcategory { get; set; }
    }
}
