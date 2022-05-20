using System;
namespace assignment2
{
    public class CardPresentState : IATMState;
    {
        public CardPresentState()
        {
        }

        public void EnterPincode()
        {
            throw new NotImplementedException();
        }

        public void InsertCard()
        {
            throw new NotImplementedException();
        }

        public void RejectCard()
        {
            throw new NotImplementedException();
        }

        public void WithdrawCash()
        {
            throw new NotImplementedException();
        }
    }
}
