using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KATA1
{
    public class ChangeCalculator
    {
        private double[] denominations = { 30, 24, 12, 6, 3, 1, 0.5 };
        private string[] names = { "Half Crown", "Florin", "Shilling", "Sixpenny bit", "Threepenny bit", "Penny", "Halfpenny" };
        
        public IDictionary<string, int> Calculate(double shillingCount, double penceCount)
        {
            var change = new Dictionary<string, int>();
            var remainingChangeInPence = shillingCount * 12 + penceCount;
            var i = 0;
            
            while (remainingChangeInPence > 0)
            {
                if (remainingChangeInPence >= denominations[i])
                {
                    int ValuesDenominations = (int)(remainingChangeInPence / denominations[i]);
                    remainingChangeInPence = Math.Round(remainingChangeInPence - denominations[i] * ValuesDenominations, 2); //Odjęcie wypłaconych środków od reszty

                    change.Add(names[i], ValuesDenominations);
                }

                i++;
            }
            return change;
        }
    }
}
