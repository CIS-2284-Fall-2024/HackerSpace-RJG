using Microsoft.IdentityModel.Tokens;

namespace HackerSpace.Data.Models
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
