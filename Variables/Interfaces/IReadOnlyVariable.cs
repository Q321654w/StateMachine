namespace StateMachine.Variables.Interfaces
{
    public interface IReadOnlyVariable<out T>
    {
        T Value();
    }
}