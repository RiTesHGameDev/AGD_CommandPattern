using Command.Main;

namespace Command.Commands
{
    public class BeserkerAttackCommand : UnitCommand
    {
        private bool willHitTarget;
        public BeserkerAttackCommand(CommandData commandData)
        {
            this.commandData = commandData;
            willHitTarget = WillHitTarget();
        }

        public override bool WillHitTarget() => true;

        public override void Execute() => GameService.Instance.ActionService.GetActionByType(CommandType.BerserkAttack).PerformAction(actorUnit, targetUnit, willHitTarget);
    }
}