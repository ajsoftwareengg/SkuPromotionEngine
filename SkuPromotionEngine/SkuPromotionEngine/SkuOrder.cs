using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkuPromotionEngine
{
    public class SkuOrder
    {
        #region Declaration
        public int OrderID  { get; set; }
        public List<Product> SkuList { get; set; }
        #endregion

        #region List Of Sku With OrderId
        public SkuOrder(int numOrderId, List<Product> LiSkuList)
        {
            this.OrderID = numOrderId;
            this.SkuList = LiSkuList;
        }
        #endregion

    }
}
