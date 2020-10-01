using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using OrderProcessingEngine.BusinessRules;

namespace OrderProcessingEngine.Test
{
    [TestClass]
    public class VerifyBusinessRules
    {
        RunRuleEngine engine = null;
        [TestInitialize]
        public void Initialize()
        {
            engine = new RunRuleEngine();
        }

        [TestMethod]
        public void VerifyPhysicalProductOrder()
        {
            var result = engine.RunRules(TypeOfProduct.PhysicalProduct);

            Assert.IsTrue(result.Count == 2);

            Assert.IsTrue(result.Contains(TypeOfActionAgainstOrder.GenerateCommission));
            Assert.IsTrue(result.Contains(TypeOfActionAgainstOrder.GeneratePackagingSlip));
        }



        [TestMethod]
        public void VerifyBookOrder()
        {
            var result = engine.RunRules(TypeOfProduct.Book);

            Assert.IsTrue(result.Count == 2);

            Assert.IsTrue(result.Contains(TypeOfActionAgainstOrder.GenerateCommission));
            Assert.IsTrue(result.Contains(TypeOfActionAgainstOrder.DuplicatePackaingSlip));
        }


        [TestMethod]
        public void VerifyNewMembershipOrder()
        {
            var result = engine.RunRules(TypeOfProduct.Membership);

            Assert.IsTrue(result.Count == 2);

            Assert.IsTrue(result.Contains(TypeOfActionAgainstOrder.ActivateMembership));
            Assert.IsTrue(result.Contains(TypeOfActionAgainstOrder.SendEmail));
        }




        [TestMethod]
        public void VerifyUpgadeMembershipOrder()
        {
            var result = engine.RunRules(TypeOfProduct.UpgradeMembership);

            Assert.IsTrue(result.Count == 2);
            Assert.IsTrue(result.Contains(TypeOfActionAgainstOrder.UpgradeMembership));
            Assert.IsTrue(result.Contains(TypeOfActionAgainstOrder.SendEmail));
        }


        [TestMethod]
        public void VerifyVideoOrder()
        {
            var result = engine.RunRules(TypeOfProduct.LearningToSkiVideo);

            Assert.IsTrue(result.Count == 1);
            Assert.IsTrue(result.Contains(TypeOfActionAgainstOrder.AddFreeAidVideoToPackagingSlip));
        }
    }
}
