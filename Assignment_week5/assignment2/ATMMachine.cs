using System;

namespace assignment2
{
    public class ATMMachine
    {
        private int amountInMachine;
        private bool cardPresent;
        private bool correctPinCode;
        private bool noCard;
        private bool noCash;

        public int AmountInMachine
        {
            get { return amountInMachine; }
            set { amountInMachine = value; }
        }

        public ATMMachine(int amountInMachine)
        {
            AmountInMachine = amountInMachine;
        }

        public void 
    }
}
