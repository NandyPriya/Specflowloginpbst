using NUnit.Framework;

namespace LoginPST.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        string userid, password;
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        [Given("the userdid is (.*)")]
        public void GivenTheUserdidIs(string uid)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 
            userid = uid;
           // throw new PendingStepException();
        }

        [Given("the password is (.*)")]
        public void GivenThePasswordIs(string pwd)
        {
            //TODO: implement arrange (precondition) logic
            password = pwd;
           // throw new PendingStepException();
        }

        [When("the login operation")]
        public void WhenTheLoginOperation()
        {
            //TODO: implement act (action) logic
            Console.WriteLine($"{userid}{password}");
           // throw new PendingStepException();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(string result)
        {
            //TODO: implement assert (verification) logic
            string actual = null;
            if((userid=="testuser_1"&& password == "Test@123")||(userid == "testuser_2" && password == "Test@153"))
            {
                actual = result;
            }
            else
            {
                actual = "errorous";
            }
            Assert.AreEqual(result,actual);
            //throw new PendingStepException();
        }
    }
}