using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingEngine.BusinessRules
{
    class LearningToSkiVideoRule : ProcessOrder
    {
        internal LearningToSkiVideoRule(ProcessOrder processOrder, TypeOfProduct typeOfProduct) : base(processOrder, typeOfProduct)
        {

        }

        protected override TypeOfProduct TypeOfRule { get; set; } = TypeOfProduct.LearningToSkiVideo;

        protected override List<TypeOfActionAgainstOrder> Process()
        {
            var result = new List<TypeOfActionAgainstOrder>();
            result.Add(TypeOfActionAgainstOrder.AddFreeAidVideoToPackagingSlip);
            return result;
        }
    }
}
