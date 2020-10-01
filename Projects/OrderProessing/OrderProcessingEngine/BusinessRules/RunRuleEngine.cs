using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingEngine.BusinessRules
{
    public class RunRuleEngine
    {
        public List<TypeOfActionAgainstOrder> RunRules(TypeOfProduct product)
        {
            var learningToSkiVideoRule = new LearningToSkiVideoRule(null, product);
            var upgradeMembershipRule = new UpgradeMembershipRule(learningToSkiVideoRule, product);
            var newMembershipRule = new NewMembershipRule(upgradeMembershipRule, product);
            var bookRule = new BookRule(newMembershipRule, product);
            var ruleChain = new PhysicalProductRule(bookRule, product);
            return ruleChain.VerifyRuleAndProcess();

        }
    }
}
