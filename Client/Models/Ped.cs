namespace Eternar.Core
{
    public sealed class Ped : Entity
    {
        public Ped(int handle) : base(handle)
            { }

        public override int NetHandle
        {
            get => Natives.PedToNet(this.Handle);
        }

        public override bool Exists()
            => base.Exists() && Natives.GetEntityType(this.Handle) == EntityType.Ped;

        public static bool Exists(Ped ped)
            => !ReferenceEquals(ped, null) && ped.Exists();
    }
}