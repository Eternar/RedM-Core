namespace Eternar.Core
{
    public sealed class Vehicle : Entity
    {
        public Vehicle(int handle) : base(handle)
            { }

        public override int NetHandle
        {
            get => Natives.VehToNet(this.Handle);
        }

        public override bool Exists()
            => base.Exists() && Natives.GetEntityType(this.Handle) == EntityType.Vehicle;

        public static bool Exists(Vehicle vehicle)
            => vehicle is object && vehicle.Exists();
    }
}