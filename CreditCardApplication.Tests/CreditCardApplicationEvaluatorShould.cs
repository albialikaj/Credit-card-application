using Xunit;

namespace CreditCardApplication.Tests
{
    public class CreditCardApplicationEvaluatorShould
    {
        [Fact]
        public void AcceptHighApplications()
        {
            var systemUnderTest = new CreditCardApplicationEvaluator();
            var application = new CreditCardApplication { GrossAnnualIncome = 100_000 };

            CreditCardApplicationDecision decision = systemUnderTest.Evaluate(application);

            Assert.Equal(CreditCardApplicationDecision.AutoAccepted, decision);
        }

        [Fact]
        public void ReferYoungApplications()
        {
            var systemUnderTest = new CreditCardApplicationEvaluator();
            var application = new CreditCardApplication { Age = 19 };

            CreditCardApplicationDecision decision = systemUnderTest.Evaluate(application);

            Assert.Equal(CreditCardApplicationDecision.ReferredToHuman, decision);
        }
    }
}
