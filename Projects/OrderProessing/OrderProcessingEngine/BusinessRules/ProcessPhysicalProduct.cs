using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingEngine.BusinessRules
{
    class ProcessPhysicalProduct : ProcessOrder
    {
        internal ProcessPhysicalProduct(ProcessOrder processOrder, TypeOfProduct typeOfProduct):base(processOrder, typeOfProduct)
        {

        }
        protected override List<TypeOfActionAgainstOrder> Process()
        {
            return new List<TypeOfActionAgainstOrder>();
        }
    }
}
