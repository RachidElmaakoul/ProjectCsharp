
namespace FirstProjectC_.ConsoleApp
{
    public class Manager : Employye
    {
        private const decimal AllowanceRate = 0.05m;
        public Manager(int id, string name, decimal loggedHoures, decimal wage ) :base(id, name, loggedHoures, wage)
        {
        }
        protected override decimal Calculate()
        {
          
            return base.Calculate() + CalculateAllowance() ;
        }
        private  decimal CalculateAllowance()
        {
          
            return base.Calculate() * AllowanceRate;
        }
        public override string ToString()
        {
            return base.ToString() +
                $"\nAllowance    : ${CalculateAllowance()}"+
                $"\nNet Salary   : {this.Calculate()}";

        }
    } 
}
