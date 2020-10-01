using System;

namespace OrderProcessingEngine
{
    //This should come from database
    public enum TypeOfProduct
    {
        Book,
        PhysicalProduct,
        //Although Membership and UpgradeMembership are type of services
        //But for sake of simplicity I am keeping them here
        Membership,
        UpgradeMembership,
        LearningToSkiVideo

    }



    public class ProductDetail
    {
        public TypeOfProduct? GetTypeOfProductFromName(string productName)
        {
            if (Enum.TryParse(typeof(TypeOfProduct), productName, true, out object result))
            {
                return (TypeOfProduct?)result;
            }
            return null;
        }
    }
}
