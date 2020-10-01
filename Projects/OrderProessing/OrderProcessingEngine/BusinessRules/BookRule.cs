using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingEngine.BusinessRules
{
    class BookRule : ProcessOrder
    {
        internal BookRule(ProcessOrder processOrder, TypeOfProduct typeOfProduct) : base(processOrder, typeOfProduct)
        {

        }

        protected override TypeOfProduct TypeOfRule { get; set; } = TypeOfProduct.Book;

        protected override List<TypeOfActionAgainstOrder> Process()
        {
            var result = new List<TypeOfActionAgainstOrder>();
            result.Add(TypeOfActionAgainstOrder.DuplicatePackaingSlip);
            result.Add(TypeOfActionAgainstOrder.GenerateCommission);

            return result;
        }
    }
}
