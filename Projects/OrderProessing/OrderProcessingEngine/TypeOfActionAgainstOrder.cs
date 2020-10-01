using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingEngine
{

    //We may not need this enum while creating actual application, since its a prototype so 
    //to verify rules I will use below responses.
    public enum TypeOfActionAgainstOrder
    {
        GeneratePackagingSlip,
        DuplicatePackaingSlip,
        ActivateMembership,
        UpgradeMembership,
        SendEmail,
        AddFreeAidVideoToPackagingSlip,
        GenerateCommission
    }
}
