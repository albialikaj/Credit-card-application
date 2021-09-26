using System;

namespace CreditCardApplication
{
    public partial class CreditCardApplicationEvaluator
    {
        public class FrequentFlyerNumberValidator : IFrequentFlyerNumberValidator
        {
            public bool isValid(string frequentFlyerNumber)
            {
                throw new NotImplementedException("Simiulate this is real dependency being hard to use");
            }
            public bool IsValid(string frequentFlyerNumber, out bool isValid)
            {
                throw new NotImplementedException();
            }
        }

    }
}
