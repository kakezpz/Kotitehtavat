using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4_5
{
    class Radio
    {
        private const int VolumeMin = 0;
        private const int VolumeMax = 9;
        private const double FrequencyMin = 2000.0;
        private const double FrequencyMax = 26000.0;

        public bool IsOpen { get; set; }

        private int volume;
        public int Volume
        {
            get { return volume; }
            set
            {
                if (!IsOpen)
                {
                    Console.WriteLine("Please, turn the radio ON before setting the volume.");
                    return;
                }
                if (value < VolumeMin)
                {
                    Console.WriteLine("The volume is too low {0}, setting volume to minimum!", value);
                    volume = VolumeMin;
                }
                else if (value > VolumeMax)
                {
                    Console.WriteLine("The volume is too high {0}, setting the volume to maximum!", value);
                    volume = VolumeMax;
                }
                else volume = value;
            }
        }

        private double frequency;
        public double Frequency
        {
            get { return frequency; }
            set
            {
                if (!IsOpen)
                {
                    Console.WriteLine("Please, turn the radio ON before setting the frequency.");
                    return;
                }
                if (value < FrequencyMin)
                {
                    Console.WriteLine("The frequency is too low {0}, setting the frequency to minimium!", value);
                    frequency = FrequencyMin;
                }
                else if (value > FrequencyMax)
                {
                    Console.WriteLine("The frequency is too high {0}, setting frequency to maximum!", value);
                    frequency = FrequencyMax;
                }
                else frequency = value;
            }
        }

        public Radio()
        {
            IsOpen = false;
            volume = VolumeMin;
            frequency = FrequencyMin;
        }


        public override string ToString()
        {
            return "Radio is on: " + IsOpen + " -Volume: " + Volume + " -Frequency: " + Frequency;
        }

    }
}
