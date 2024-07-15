
namespace FirstProjectC_.ConsoleApp
{
    public class Devloper : Employye
    {
        private const decimal Comission = 0.03m;
        protected bool TaskComplated {  get; set; }

        public Devloper(int id, string name, decimal loggedHoures, decimal wage, bool taskComplated) : base(id, name, loggedHoures, wage)
        {
            this.TaskComplated = taskComplated;
        }
        protected decimal Calculate()
        {
          
            return base.Calculate() + CalculateComission();
        } 
        private  decimal CalculateComission()
        {
            if (TaskComplated)
                return base.Calculate() * Comission;
            
            return 0;
        }
      
        public override string ToString()
        {
            return base.ToString() +
                $"\nTAskComplated: {(TaskComplated ? "Yes" : "NO") }"+
                $"\nBonus        : ${CalculateComission()}"+
                $"\nNet Salary   : {this.Calculate()}";

        }
    }
}
