using StateMachine.StateMachines.Interfaces;
using StateMachine.Variables.Interfaces;

namespace StateMachine.StateMachines
{
    public class FiniteStateMachine : IState
    {
        private readonly IVariable<int> _stateId;
        private readonly IState[] _states;

        public FiniteStateMachine(IState[] states, IVariable<int> stateId)
        {
            _states = states;
            _stateId = stateId;
        }

        public void Update()
        {
            var state = _states[_stateId.Value()];
            state.Update();
        }
    }
}