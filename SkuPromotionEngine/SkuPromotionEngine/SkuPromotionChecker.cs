using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkuPromotionEngine
{
    public static class SkuPromotionChecker
    {

        #region Get the total price with promotion amount calculation
        public static decimal GetTotalPrice(SkuOrder skuorder, SkuPromotion skupromotion)
        {
            decimal d = 0;
            decimal numActualPrice = skuorder.SkuList.Where(x =>skupromotion.SkuInfo.Any(y=>y.Key==x.Id)).Select(x => x.Price).ElementAt(0);
             
                 
            //get count of promoted products in order
            var copp = skuorder.SkuList
                .GroupBy(x => x.Id)
                .Where(grp => skupromotion.SkuInfo.Any(y => grp.Key == y.Key && grp.Count() >= y.Value))
                .Select(grp => grp.Count())
                .Sum();
            //get count of promoted products from promotion
            int ppc = skupromotion.SkuInfo.Sum(kvp => kvp.Value);
            while (copp >= ppc)
            {
                d += skupromotion.PromotionPrice;
                copp -= ppc;
            }
            if (copp != 0)
            {
                d += copp * numActualPrice;
            }
            
            return d;
        }
        #endregion

    }
}
