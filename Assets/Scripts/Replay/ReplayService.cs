using Command.Main;
using System.Collections.Generic;
using Command.Commands;
using UnityEngine;
using System.Collections;

namespace Replay
{
    public class ReplayService
    {
        private Stack<ICommand> replayCommandStack;
        public ReplayState replayState { get; private set; }

        public ReplayService() => SetReplayState(ReplayState.DEACTIVE);
        public void SetReplayState(ReplayState stateToSet) => replayState = stateToSet;

        public void SetCommandStack(Stack<ICommand> commandToSet) => replayCommandStack = new Stack<ICommand>(commandToSet);

        public IEnumerator ExecuteNext()
        {
            yield return new WaitForSeconds(1);

            if (replayCommandStack.Count > 0)
                GameService.Instance.ProcessUnitCommand(replayCommandStack.Pop());
        }
    }

    public enum ReplayState
    {
        ACTIVE,
        DEACTIVE
    }
}