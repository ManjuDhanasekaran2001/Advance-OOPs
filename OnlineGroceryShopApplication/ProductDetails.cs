using System;

namespace OnlineGroceryShopApplication
{
    public class ProductDetails
    {
        private static int s_prroductID = 2000;
        public string ProductID{ get; }
        public string ProductName { get; set; }
        public int QuantityAvailable { get; set; }
        public double PricePerQuantity { get; set; }

        public ProductDetails(string productName,int quantityAvailable,double pricequantity){
            s_prroductID++;
            ProductID="PID"+s_prroductID;
            ProductName=productName;
            QuantityAvailable=quantityAvailable;
            PricePerQuantity=pricequantity;
        }

        public void ShowProductDetails(){
            Console.WriteLine($"{ProductID}{ProductName}{QuantityAvailable}{PricePerQuantity }");
        }
    }
}
