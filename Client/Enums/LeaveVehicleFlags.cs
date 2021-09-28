namespace Eternar.Core
{
    using System;

    [Flags]
    public enum LeaveVehicleFlags
    {
        None = 0,
        WarpOut = 16,
        LeaveDoorOpen = 256,
        BailOut = 4096,
        MoveFromPassenger = 262144
    };
}