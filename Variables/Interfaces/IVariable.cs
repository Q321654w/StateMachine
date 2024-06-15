namespace StateMachine.Variables.Interfaces
{
    public interface IVariable<T> : IReadOnlyVariable<T>
    {
        void Set(T value);
    }
}