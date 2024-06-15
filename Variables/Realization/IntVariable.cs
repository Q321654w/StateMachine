using StateMachine.Variables.Interfaces;

namespace StateMachine.Variables.Realization
{
    public class IntVariable : IVariable<int>
    {
        private int _value;

        public IntVariable(int value)
        {
            _value = value;
        }

        public int Value()
        {
            return _value;
        }

        public void Set(int value)
        {
            _value = value;
        }
    }
}