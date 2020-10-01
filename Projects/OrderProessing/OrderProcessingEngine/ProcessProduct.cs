using OrderProcessingEngine.BusinessRules;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingEngine
{
    public class ProcessProduct
    {
        public List<TypeOfActionAgainstOrder> Process(string Product)
        {
            var productDetail = new ProductDetail();
            var product = productDetail.GetTypeOfProductFromName(Product);


            if (!product.HasValue)
                throw new Exception("Invalid product name");

            return (new RunRuleEngine()).RunRulesForProduct(product.Value);
        }


    }
}
