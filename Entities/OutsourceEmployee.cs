using System;
using exercicioherpoli.Entities;

namespace exercicioherpoli.Entities

{
    public class OutsourceEmployee : Employee
    {

       
        public double AdditionalCharge { get; set; }


        public OutsourceEmployee(string name, int hours, double valueperhours, double additionalCharge)
        : base(name, hours, valueperhours)
        {

            AdditionalCharge = additionalCharge;


        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
            
        }



    }
}
