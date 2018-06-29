using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMICalculation.Model;

namespace BMICalculation
{
    public abstract class BMIBase
    {
        protected Person _person;
        protected abstract int Max { get; set; }
        protected abstract int Min { get; set; }

        protected BMIBase()
        {
            _person = new Person();
        }

        public int BMICal(float height, int weight)
        {
            if (height < 0 || weight < 0)
                return 0;
            _person.Height = height;
            _person.Weight = weight;
            _person.BMI = Convert.ToInt32(_person.Weight / (_person.Height * _person.Height));
            return _person.BMI;
        }

        public string GetMessage()
        {
            if (_person.BMI == 0)
            {
                return "請先計算";
            }
            string RetunMessage = Message.Normal;
            if (_person.BMI < Min)
            {
                RetunMessage = Message.Skinny;
            }
            if (_person.BMI > Max)
            {
                RetunMessage = Message.Fat;
            }
            return RetunMessage;
        }


    }
}
