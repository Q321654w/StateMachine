using StateMachine.StateMachines.Interfaces;
using StateMachine.Variables.Interfaces;

namespace StateMachine.StateMachines.Realizations
{
    public abstract class BaseState : IState
    {
        protected readonly IVariable<int> StateId;
        protected readonly int NextStateId;

        protected BaseState(IVariable<int> stateId, int nextStateId)
        {
            StateId = stateId;
            NextStateId = nextStateId;
        }

        protected void TransitTo(int id)
        {
            StateId.Set(id);
        }

        protected void TransitToNext()
        {
            TransitTo(NextStateId);
        }

        public abstract void Update();
    }
}