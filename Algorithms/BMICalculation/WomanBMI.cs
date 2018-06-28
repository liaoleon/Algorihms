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
        public override string GetMessage()
        {
            string RetunMessage = Message.Normal;
            if (_person.BMI < 18)
            {
                RetunMessage = Message.Skinny;
            }
            if (_person.BMI > 22)
            {
                RetunMessage = Message.Fat;
            }
            return RetunMessage;
        }
    }
}
