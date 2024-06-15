using System;
using StateMachine.StateMachines.Interfaces;
using StateMachine.Variables.Interfaces;

namespace StateMachine.StateMachines.Realizations
{
    public class WaitState : BaseState, IEnter, IExit
    {
        private readonly float _delay;
        private DateTime _start;
        private float _deltaTime;

        public WaitState(IVariable<int> stateId, int nextStateId, float delay) : base(stateId, nextStateId)
        {
            _delay = delay;
            _start = DateTime.Now;
            _delay = delay;
            _deltaTime = 0;
        }

        public void Enter()
        {
            _start = DateTime.Now;
        }

        public override void Update()
        {
            var timeNow = DateTime.Now;
            _deltaTime += (timeNow.Ticks - _start.Ticks) / 10000000f;
            _start = timeNow;

            if (_deltaTime >= _delay)
                TransitToNext();
        }

        public void Exit()
        {
            _deltaTime = 0;
        }
    }
}