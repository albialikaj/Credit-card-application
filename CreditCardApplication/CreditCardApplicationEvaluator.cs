namespace CreditCardApplication
{
    public partial class CreditCardApplicationEvaluator
    {
        public interface IFrequentFlyerNumberValidator
        {
            bool isValid(string frequentFlyerNumber);
            bool IsValid(string frequentFlyerNumber, out bool isValid);
        }

    }
}
