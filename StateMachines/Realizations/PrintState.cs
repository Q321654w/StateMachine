using System;
using StateMachine.Variables.Interfaces;

namespace StateMachine.StateMachines.Realizations
{
    public class PrintState : BaseState
    {
        private readonly string _message;

        public PrintState(IVariable<int> stateId, int nextStateId, string message) : base(stateId, nextStateId)
        {
            _message = message;
        }

        public override void Update()
        {
            Console.WriteLine(_message);
            TransitToNext();
        }
    }
}