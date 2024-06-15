using StateMachine.StateMachines.Interfaces;
using StateMachine.Variables.Interfaces;

namespace StateMachine.StateMachines.Realizations.Transition
{
    public class TransitionEnterExit : BaseState
    {
        private readonly IExit _from;
        private readonly IEnter _to;

        public TransitionEnterExit(IVariable<int> stateId, int nextStateId, IExit from, IEnter to) : base(stateId,
            nextStateId)
        {
            _from = from;
            _to = to;
        }

        public override void Update()
        {
            _from.Exit();
            _to.Enter();
            TransitToNext();
        }
    }
}