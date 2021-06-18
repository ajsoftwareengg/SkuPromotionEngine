using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkuPromotionEngine
{
    public class SkuPromotion
    {
        #region Declaration
        public int SkuPromotionID { get; set; }
        public Dictionary<string, int> SkuInfo { get; set; }
        public decimal PromotionPrice { get; set; }
        #endregion

        #region Sku Promotion List
        public SkuPromotion(int numPromoId, Dictionary<string, int> strSkuInfo, decimal numPromotionPrice)
        {
            this.SkuPromotionID = numPromoId;
            this.SkuInfo = strSkuInfo;
            this.PromotionPrice = numPromotionPrice;
        }
        #endregion
    }
}
