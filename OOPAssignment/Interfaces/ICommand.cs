namespace OOPAssignment.Interfaces
{
    public interface ICommand<T>
        where T : class
    {
        public void ExecuteCommand(T commandObject);
    }
}
