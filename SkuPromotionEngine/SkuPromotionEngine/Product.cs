using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkuPromotionEngine
{
    public class Product
    {
        #region Declaration
        public string Id { get; set; }
        public decimal Price { get; set; }
        #endregion

        #region Sku Ids Function
        public Product(string SkuId)
        {
            this.Id = SkuId;
            switch (SkuId)  
            { 
                case "A":
                    this.Price = 50;
                    break;
                case "B":
                    this.Price = 30;

                    break;
                case "C":
                    this.Price = 20;

                    break;
                case "D":
                    this.Price = 15;
                    break;
            }
        }
    #endregion
    }
}
