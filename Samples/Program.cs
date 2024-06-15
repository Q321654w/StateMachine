using StateMachine.StateMachines;
using StateMachine.StateMachines.Interfaces;
using StateMachine.StateMachines.Realizations;
using StateMachine.StateMachines.Realizations.Transition;
using StateMachine.Variables.Realization;

namespace StateMachine.Samples
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var stateId = new IntVariable(0);

            var state0 = new PrintState(stateId, 1, "1");
            var state1 = new PrintState(stateId, 3, "2");
            var state2 = new PrintState(stateId, 0, "####################");

            var state4 = new WaitState(stateId, 5, 4f);
            var state3 = new TransitionEnter(stateId, 4, state4);
            var state5 = new TransitionExit(stateId, 2, state4);

            var states = new IState[]
            {
                state0,
                state1,
                state2,
                state3,
                state4,
                state5,
            };

            var stateMachine = new FiniteStateMachine(states, stateId);

            while (true)
            {
                stateMachine.Update();
            }
        }
    }
}