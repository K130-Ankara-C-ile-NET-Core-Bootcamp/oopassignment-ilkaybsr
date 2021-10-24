using OOPAssignment.Interfaces;

namespace OOPAssignment.Class
{
    public class CarCommandExecutorBase
    {
        protected readonly ICarCommand CarCommand;

        public CarCommandExecutorBase(ICarCommand carCommand)
        {
            CarCommand = carCommand;
        }
    }
}
