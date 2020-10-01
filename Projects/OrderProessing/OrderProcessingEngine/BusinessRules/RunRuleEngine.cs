using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingEngine.BusinessRules
{
    public class RunRuleEngine
    {


        public List<TypeOfActionAgainstOrder> RunRules(TypeOfProduct product)
        {
            List<TypeOfActionAgainstOrder> result = null;
            var physicalProductRule = new ProcessPhysicalProduct(null, product);
            result = physicalProductRule.VerifyRuleAndProcess();
            return result;

        }
    }
}
