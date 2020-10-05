using OrderProcessingEngine;
using System;
using System.Collections.Generic;

namespace OrderProessing
{
    class Program
    {
        static void Main(string[] args)
        {
            RunRuleAndGenerateActions("LearningToSkiVideo");
            RunRuleAndGenerateActions("book");
            RunRuleAndGenerateActions("membership");
            RunRuleAndGenerateActions("PhysicalProduct");
            RunRuleAndGenerateActions("UpgradeMembership");

        }


        static void RunRuleAndGenerateActions(string product)
        {
            var productproces = new ProcessProduct();
            var actions = productproces.Process(product);
            Console.WriteLine($"For product {product} below actions were taken -");

            foreach (var action in actions)
            {
                switch (action)
                {
                    case TypeOfActionAgainstOrder.ActivateMembership:
                        Console.WriteLine("Activating the membership");
                        break;
                    case TypeOfActionAgainstOrder.AddFreeAidVideoToPackagingSlip:
                        Console.WriteLine("Adding free “First Aid” video to the packing slip ");
                        break;


                    case TypeOfActionAgainstOrder.DuplicatePackaingSlip:
                        Console.WriteLine("Creating a duplicate packing slip for the royalty department.");
                        break;
                    case TypeOfActionAgainstOrder.GenerateCommission:
                        Console.WriteLine("Generating a commission payment to the agent.");
                        break;
                    case TypeOfActionAgainstOrder.GeneratePackagingSlip:
                        Console.WriteLine("Generating a packing slip for shipping.");
                        break;
                    case TypeOfActionAgainstOrder.SendEmail:
                        Console.WriteLine("Sending email for activation/upgrade.");
                        break;
                    case TypeOfActionAgainstOrder.UpgradeMembership:
                        Console.WriteLine("Upgrading the membership.");
                        break;
                }

            }
            Console.WriteLine(Environment.NewLine);

        }
    }
}
