using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH01_CodeSmells.SolutionMS
{
    internal class ProductInfo
    {
        public required string ProductName { get; set; }
        public required string Category { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public required string SupplierName { get; set; }
        public required string SupplierContact { get; set; }

    }

    internal class Excercise1
    {
        public void RegisterProduct(ProductInfo productInfo)
        {
            // Rejestracja produktu
            Console.WriteLine($"Product: {productInfo.ProductName}, Category: {productInfo.Category}, Price: {productInfo.Price:C}, Stock: {productInfo.Stock}, Supplier: {productInfo.SupplierName}, Contact: {productInfo.SupplierContact}");
        }
    }
}
