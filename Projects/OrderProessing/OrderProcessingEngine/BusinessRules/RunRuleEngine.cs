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
            var bookRule = new BookRule(null, product);
            var ruleChain = new PhysicalProductRule(bookRule, product);
            result = ruleChain.VerifyRuleAndProcess();
            return result;

        }
    }
}
