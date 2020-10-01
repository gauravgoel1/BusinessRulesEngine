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


        [TestMethod]
        public void VerifyPhysicalProductOrder()
        {
            var runRuleEngine = new RunRuleEngine();
            var result = runRuleEngine.RunRules(TypeOfProduct.PhysicalProduct);

            Assert.IsTrue(result.Count == 2);

            Assert.IsTrue(result.Contains(TypeOfActionAgainstOrder.GenerateCommission));
            Assert.IsTrue(result.Contains(TypeOfActionAgainstOrder.GeneratePackagingSlip));
        }



        [TestMethod]
        public void VerifyBookOrder()
        {
            var runRuleEngine = new RunRuleEngine();
            var result = runRuleEngine.RunRules(TypeOfProduct.Book);

            Assert.IsTrue(result.Count == 2);

            Assert.IsTrue(result.Contains(TypeOfActionAgainstOrder.GenerateCommission));
            Assert.IsTrue(result.Contains(TypeOfActionAgainstOrder.DuplicatePackaingSlip));
        }


        [TestMethod]
        public void VerifyNewMembershipOrder()
        {
            var runRuleEngine = new RunRuleEngine();
            var result = runRuleEngine.RunRules(TypeOfProduct.Membership);

            Assert.IsTrue(result.Count == 2);

            Assert.IsTrue(result.Contains(TypeOfActionAgainstOrder.ActivateMembership));
            Assert.IsTrue(result.Contains(TypeOfActionAgainstOrder.SendEmail));
        }




        [TestMethod]
        public void VerifyUpgadeMembershipOrder()
        {
            var runRuleEngine = new RunRuleEngine();
            var result = runRuleEngine.RunRules(TypeOfProduct.UpgradeMembership);

            Assert.IsTrue(result.Count == 2);
            Assert.IsTrue(result.Contains(TypeOfActionAgainstOrder.UpgradeMembership));
            Assert.IsTrue(result.Contains(TypeOfActionAgainstOrder.SendEmail));
        }


        [TestMethod]
        public void VerifyVideoOrder()
        {
            var runRuleEngine = new RunRuleEngine();
            var result = runRuleEngine.RunRules(TypeOfProduct.LearningToSkiVideo);

            Assert.IsTrue(result.Count == 1);
            Assert.IsTrue(result.Contains(TypeOfActionAgainstOrder.AddFreeAidVideoToPackagingSlip));
        }
    }
}
