using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMICalculation.Model;

namespace BMICalculation.Factory
{
    public class BMIFactory
    {
        public BMIBase GetBMIEntity(Sex sex)
        {
            switch (sex)
            {
                case Sex.Man:
                    return new ManBMI();
                case Sex.Woman:
                    return new WomanBMI();
                default:
                    return null;
            }
        }
    }
}
