using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingEngine.BusinessRules
{
    class NewMembershipRule : ProcessOrder
    {
        internal NewMembershipRule(ProcessOrder processOrder, TypeOfProduct typeOfProduct) : base(processOrder, typeOfProduct)
        {

        }

        protected override TypeOfProduct TypeOfRule { get; set; } = TypeOfProduct.Membership;

        protected override List<TypeOfActionAgainstOrder> Process()
        {
            var result = new List<TypeOfActionAgainstOrder>();
            result.Add(TypeOfActionAgainstOrder.ActivateMembership);
            result.Add(TypeOfActionAgainstOrder.SendEmail);

            return result;
        }
    }
}
