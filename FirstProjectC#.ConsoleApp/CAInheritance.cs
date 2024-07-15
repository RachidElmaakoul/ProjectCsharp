using System.Runtime.CompilerServices;

namespace FirstProjectC_.ConsoleApp
{
    public class Employye
    {

        private const int MinimunLoggendHours = 176;
        protected const decimal OverTimeRate = 1.25m;

        protected Employye(int id, string name, decimal loggedHoures, decimal wage)
        {
            Id = id;
            Name = name;
            LoggedHoures = loggedHoures;
            Wage = wage;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public decimal LoggedHoures { get; set; }

        public decimal Wage { get; set; }

        protected virtual decimal Calculate()
        {


            return CalcolateBaseSalary() + CalcolateOverTime();
        }
        private decimal CalcolateBaseSalary()
        {
            return LoggedHoures * Wage;

        } 
        private decimal CalcolateOverTime()
        {
            var AddictionalHoures = ((LoggedHoures - MinimunLoggendHours) > 0 ? LoggedHoures - MinimunLoggendHours : 0);
            return AddictionalHoures * Wage * OverTimeRate;

        }

        public override string ToString()
        {
            var Type = GetType().ToString().Replace("FirstProjectC_.ConsoleApp.", "");
            return $"\t{Type}\n"+
                   $"\nId           : {Id}" +
                   $"\nName         : {Name}" +
                   $"\nLoggedHoures : {LoggedHoures} Hr" +
                   $"\nWage         : {Wage} $/Hr"+
                   $"\nBase Salary  : ${CalcolateBaseSalary()}"+
                   $"\nOverTime     : ${CalcolateOverTime()}";
        }

    }
}
