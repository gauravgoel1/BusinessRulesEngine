using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingEngine.BusinessRules
{
    class UpgradeMembershipRule : ProcessOrder
    {
        internal UpgradeMembershipRule(ProcessOrder processOrder, TypeOfProduct typeOfProduct) : base(processOrder, typeOfProduct)
        {

        }

        protected override TypeOfProduct TypeOfRule { get; set; } = TypeOfProduct.UpgradeMembership;

        protected override List<TypeOfActionAgainstOrder> Process()
        {
            var result = new List<TypeOfActionAgainstOrder>();
            result.Add(TypeOfActionAgainstOrder.UpgradeMembership);
            result.Add(TypeOfActionAgainstOrder.SendEmail);

            return result;
        }
    }
}
