
namespace FirstProjectC_.ConsoleApp
{
    public class Maintanence : Employye
    {
        private const decimal MardShip = 100m;
        public Maintanence(int id, string name, decimal loggedHoures, decimal wage ) : base(id, name, loggedHoures, wage)
        {
        }
        protected override decimal Calculate()
        {
          
            return base.Calculate() + MardShip ;
        }
      
        public override string ToString()
        {
            return base.ToString() +
                $"\nMardShip     : ${MardShip}"+
                $"\nNet Salary   : {this.Calculate()}";

        }
    } 
}
