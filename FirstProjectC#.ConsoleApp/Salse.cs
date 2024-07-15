
namespace FirstProjectC_.ConsoleApp
{
    public class Salse : Employye
    {
        protected decimal SalseVolume { get; set; }
        protected decimal Comission {  get; set; }

        public Salse(int id, string name, decimal loggedHoures, decimal wage, decimal salseVolume, decimal comission) : base(id, name, loggedHoures, wage)
        {
            this.SalseVolume = salseVolume;
            this.Comission = comission;
        }
        protected decimal Calculate()
        {
          
            return base.Calculate() + CalculateBonus();
        } 
        private  decimal CalculateBonus()
        {
          
            return SalseVolume * Comission;
        }
      
        public override string ToString()
        {
            return base.ToString() +
                $"\nComission    : ${Comission}"+
                $"\nBonus        : ${CalculateBonus()}"+
                $"\nNet Salary   : {this.Calculate()}";

        }
    }  }
