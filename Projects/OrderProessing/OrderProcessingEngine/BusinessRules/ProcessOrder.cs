using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingEngine.BusinessRules
{
    public abstract class ProcessOrder
    {

        protected ProcessOrder(ProcessOrder nextRule, TypeOfProduct typeOfProduct)
        {
            TypeofProduct = typeOfProduct;
            NextRule = nextRule;
        }

        protected TypeOfProduct TypeofProduct { get; }
        protected abstract TypeOfProduct TypeOfRule { get; set; }


        internal List<TypeOfActionAgainstOrder> VerifyRuleAndProcess()
        {
            var listOFActions = new List<TypeOfActionAgainstOrder>();
            if(TypeofProduct == TypeOfRule)
            {
                listOFActions= this.Process();
            }
            else if(NextRule != null)
            {
                listOFActions= NextRule.VerifyRuleAndProcess();
            }
            return listOFActions;
        }

        protected abstract List<TypeOfActionAgainstOrder> Process();

        protected ProcessOrder NextRule { get; }
    }
}
