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

        public Gender Gender
        {
            get => Natives.IsPedMale(this.Handle) ? Gender.Male : Gender.Female;
        }

        public override bool Exists()
            => base.Exists() && Natives.GetEntityType(this.Handle) == EntityType.Ped;

        public static bool Exists(Ped ped)
            => ped is object && ped.Exists();
    }
}