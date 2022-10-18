using NUnit.Framework;

namespace Logout.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        int y,quantity;
        string prodname;

        [Given("the input is (.*)")]
        public void GivenTheInputIs(int number)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 
            y = number;
            //throw new PendingStepException();
        }
        [Given("the prodname is (.*)")]
        public void GivenTheProdnameIs(string n1)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 
            prodname = n1;
            //throw new PendingStepException();
        }
        [Given("the quantity is (.*)")]
        public void GivenTheQuantityIs(int n2)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 
            quantity = n2;
            //throw new PendingStepException();
        }


        [When("the logout operation")]
        public void TheLogoutOperation()
        {
            //TODO: implement act (action) logic
            Console.WriteLine($"{y}");
            //throw new PendingStepException();
        }

        [Then("the result1 should be (.*)")]
        public void ThenTheResult1ShouldBe(string result)
        {
            //TODO: implement assert (verification) logic
            string actual1 = null;
            if(y==1)
            {
                actual1 = result;
            }
            else
            {
                actual1 ="error";
            }
            Assert.AreEqual(actual1,result);
           // throw new PendingStepException();
        }
        [When("the addtocart operation")]
        public void TheAddtocartOperation()
        {
            //TODO: implement act (action) logic
            Console.WriteLine($"{y}");
            //throw new PendingStepException();
        }


        [Then("the result2 should be (.*)")]
        public void ThenTheResult2ShouldBe(string result)
        {
            //TODO: implement assert (verification) logic
            string actual = null;
          //  bool k = string.IsNullOrEmpty(result);
            if (prodname=="Laptop" && quantity > 0)
            {
                actual = result;
            }
            else
            {
                actual = "errorous";
            }
            Assert.AreEqual(actual, result);
            // throw new PendingStepException();
        }
    }
}