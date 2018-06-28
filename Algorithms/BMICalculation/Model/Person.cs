using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculation.Model
{
    public class Person
    {
        public float Height { get; set; }
        public int Weight { get; set; }
        public int BMI { get; set; }
    }

    public enum Sex
    {
        Man,
        Woman
    }

    public class Message
    {
        public const string Skinny = "太瘦";

        public const string Normal = "適中";

        public const string Fat = "太胖";
    }
}
