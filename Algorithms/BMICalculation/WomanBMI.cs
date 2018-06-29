using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMICalculation.Model;

namespace BMICalculation
{
    public class WomanBMI : BMIBase
    {
        protected override int Max { get; set; } = 22;

        protected override int Min { get; set; } = 18;
    }
}
