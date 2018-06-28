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
        protected Person _person = new Person();

        public void BMICal(float height, int weight)
        {
            _person.Height = height;
            _person.Weight = weight;
            _person.BMI = Convert.ToInt32(_person.Weight / (_person.Height * _person.Height));
        }

        public abstract string GetMessage();


    }
}
