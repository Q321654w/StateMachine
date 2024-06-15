using StateMachine.StateMachines.Interfaces;
using StateMachine.Variables.Interfaces;

namespace StateMachine.StateMachines.Realizations.Transition
{
    public class TransitionEnter : BaseState
    {
        private readonly IEnter _to;

        public TransitionEnter(IVariable<int> stateId, int nextStateId, IEnter to) : base(stateId, nextStateId)
        {
            _to = to;
        }

        public override void Update()
        {
            _to.Enter();
            TransitToNext();
        }
    }
}