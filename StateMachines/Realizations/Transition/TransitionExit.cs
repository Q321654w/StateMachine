using StateMachine.StateMachines.Interfaces;
using StateMachine.Variables.Interfaces;

namespace StateMachine.StateMachines.Realizations.Transition
{
    public class TransitionExit : BaseState
    {
        private readonly IExit _from;

        public TransitionExit(IVariable<int> stateId, int nextStateId, IExit from) : base(stateId, nextStateId)
        {
            _from = from;
        }

        public override void Update()
        {
            _from.Exit();
            TransitToNext();
        }
    }
}