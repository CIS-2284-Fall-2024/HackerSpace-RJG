namespace HackerSpace.Client.Models
{
    public class SpeedFeed
    {
        
        private float rpm;
        public float Rpm
        {
            get { return rpm; }
            set
            {
                rpm = value;
                Calc();
            }
        }

        private int teeth;
        public int Teeth
        {
            get { return teeth; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Teeth cannot be less than one.");
                }
                teeth = value;
                Calc();
            }
        }
        private float chipLoad;
        public float ChipLoad
        {
            get { return chipLoad; }
            set
            {
                chipLoad = value;
                Calc();
            }
        }

        public float FeedRate { get; private set; }

        private void Calc()
        {
            FeedRate = rpm * teeth * chipLoad;
        }

    }
}
