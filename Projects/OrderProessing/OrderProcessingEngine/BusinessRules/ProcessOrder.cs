using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingEngine.BusinessRules
{
    abstract class ProcessOrder
    {

        protected ProcessOrder(ProcessOrder nextRule, TypeOfProduct typeOfProduct)
        {
            TypeofProduct = typeOfProduct;
            NextRule = nextRule;
        }

        protected TypeOfProduct TypeofProduct { get; }

        protected abstract void Process();

        protected ProcessOrder NextRule { get; }
    }
}
