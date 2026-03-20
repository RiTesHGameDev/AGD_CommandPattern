using System;

public abstract class UnitCommand : ICommand
{
    public int ActorUnitID;
    public int TargetUnitID;

    public int ActorPlayerID;
    public int TargetPlayerID;
    public abstract void Execute();
    public abstract bool WillHitTarget();
}
