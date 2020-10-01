using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace OrderProcessingEngine.Test
{
    [TestClass]
    public class ProductTests
    {


        [TestMethod]
        public void ValidateProductParsing()
        {
            ProductDetail productDetail = new ProductDetail();
            var productType = productDetail.GetTypeOfProductFromName("Book");
            Assert.IsTrue(productType != null && productType == TypeOfProduct.Book);
        }



        [TestMethod]
        public void ValidateCaseInsensitiveProductParsing()
        {
            ProductDetail productDetail = new ProductDetail();
            var productType = productDetail.GetTypeOfProductFromName("membership");
            Assert.IsTrue(productType != null && productType == TypeOfProduct.Membership);
        }

        [TestMethod]
        public void VerifyInvalidProductParsing()
        {
            ProductDetail productDetail = new ProductDetail();
            var productType = productDetail.GetTypeOfProductFromName("");
            Assert.IsTrue(productType == null);

        }
    }
}