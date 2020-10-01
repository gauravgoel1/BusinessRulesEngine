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
            var upgradeMembershipRule = new UpgradeMembershipRule(null, product);
            var newMembershipRule = new NewMembershipRule(upgradeMembershipRule, product);
            var bookRule = new BookRule(newMembershipRule, product);
            var ruleChain = new PhysicalProductRule(bookRule, product);
            result = ruleChain.VerifyRuleAndProcess();
            return result;

        }
    }
}
