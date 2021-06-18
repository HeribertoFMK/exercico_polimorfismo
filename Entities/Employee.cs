namespace exercicioherpoli.Entities
{
    public class Employee
    {
        public string Name{get;set;}
        public int Hours{get;set;}
        public double ValuePerHours{get;set;}

        public Employee(string name,int hours, double valueperhours){

            Name = name;
            Hours = hours;
            ValuePerHours = valueperhours;

        }

        public virtual double Payment(){

            return ValuePerHours * Hours;


        }

    }
}
