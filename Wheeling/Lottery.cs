using System;

namespace Wheeling
{
    public class Lottery
    {
        private int lotteryId, numbersDrawn, maxNumber;
        public int ID
        {
            get => lotteryId;
            set => lotteryId = value;
        }
        public int NumbersDrawn
        {
            get => numbersDrawn;
            set => numbersDrawn = value;
        }
        public int MaxNumber
        {
            get => maxNumber;
            set => maxNumber = value;
        }
        private string lotteryName;
        public string Name
        {
            get => lotteryName;
            set => lotteryName = value;
        }
        private DateTime lotteryMinDate;
            public DateTime MinDrawDate
        {
            get => lotteryMinDate;
            set => lotteryMinDate = value;
        }
    }
}
