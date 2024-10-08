﻿using System.ComponentModel.DataAnnotations;

namespace HackerSpace.Client.Models
{
    public class SpeedFeed
    {
        
        private float rpm;
        [Required]
        [Range(100, float.MaxValue)]
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
        [Required]
        [Range(1, int.MaxValue)]
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
        [Required]
        [Range(0.0001, float.MaxValue)]
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
