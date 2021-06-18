using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkuPromotionEngine
{
    public class Program
    {
        #region List Of Sku Promotion
        public static List<SkuPromotion> fn_Promotion()
        {
            //create list of promotions
            //we need to add information about Product's count
            Dictionary<String, int> d1 = new Dictionary<String, int>();
            d1.Add("A", 3);
            Dictionary<String, int> d2 = new Dictionary<String, int>();
            d2.Add("B", 2);
            Dictionary<String, int> d3 = new Dictionary<String, int>();
            d3.Add("C", 1);
            d3.Add("D", 1);

            List<SkuPromotion> promotions = new List<SkuPromotion>()
            {
                new SkuPromotion(1, d1, 130),
                new SkuPromotion(2, d2, 45),
                new SkuPromotion(3, d3, 30)
            };
            return promotions;
        }
        #endregion

        #region Main Method
        public static void Main(string[] args)
        {
            Order1();
            Console.ReadLine();
            Order2();
            Console.ReadLine();
            Order3();
            Console.ReadLine();
        }
        #endregion

        #region 1 Order Senario
        public  static void Order1()
        {
            List<SkuOrder> orders = new List<SkuOrder>();
            SkuOrder order1 = new SkuOrder(1, new List<Product>() { new Product("A"), new Product("B"), new Product("C") });
            orders.AddRange(new SkuOrder[] { order1});
            foreach (SkuOrder ord in orders)
            {
                List<decimal> promoprices = fn_Promotion()
                    .Select(promo => SkuPromotionChecker.GetTotalPrice(ord, promo))
                    .ToList();
                decimal origprice = 0;
                if (ord.OrderID == 1)
                {
                    origprice = ord.SkuList.Sum(x => x.Price);
                }
                else
                {
                    origprice = promoprices.Sum();
                }
                Console.WriteLine("OrderID: {" + ord.OrderID + "} => Total Cart price: {" + origprice.ToString("0.00") + "}");
                //Console.ReadKey();
            }
        }
        #endregion

        #region 2 Order Senario
        public static void Order2()
        {
            List<SkuOrder> orders = new List<SkuOrder>();
            SkuOrder order2 = new SkuOrder(2, new List<Product>() { new Product("A"), new Product("A"), new Product("A"), new Product("A"), new Product("A"), new Product("B"), new Product("B"), new Product("B"), new Product("B"), new Product("B"), new Product("C") });
            orders.AddRange(new SkuOrder[] { order2 });
            foreach (SkuOrder ord in orders)
            {
                List<decimal> promoprices = fn_Promotion()
                    .Select(promo => SkuPromotionChecker.GetTotalPrice(ord, promo))
                    .ToList();
                decimal origprice = 0;
                if (ord.OrderID == 1)
                {
                    origprice = ord.SkuList.Sum(x => x.Price);
                }
                else
                {
                    origprice = promoprices.Sum();
                }
                Console.WriteLine("OrderID: {" + ord.OrderID + "} => Total Cart price: {" + origprice.ToString("0.00") + "}");
                //Console.ReadKey();
            }
        }
        #endregion

        #region 3 Order Senario
        public static void Order3()
        {
            List<SkuOrder> orders = new List<SkuOrder>();
            SkuOrder order3 = new SkuOrder(3, new List<Product>() { new Product("A"), new Product("A"), new Product("A"), new Product("C"), new Product("D"), new Product("B"), new Product("B"), new Product("B"), new Product("B"), new Product("B") });
            orders.AddRange(new SkuOrder[] { order3 });
            foreach (SkuOrder ord in orders)
            {
                List<decimal> promoprices = fn_Promotion()
                    .Select(promo => SkuPromotionChecker.GetTotalPrice(ord, promo))
                    .ToList();
                decimal origprice = 0;
                if (ord.OrderID == 1)
                {
                    origprice = ord.SkuList.Sum(x => x.Price);
                }
                else
                {
                    origprice = promoprices.Sum();
                }
                Console.WriteLine("OrderID: {" + ord.OrderID + "} => Total Cart price: {" + origprice.ToString("0.00") + "}");
                //Console.ReadKey();
            }
        }
        #endregion

    }
}
