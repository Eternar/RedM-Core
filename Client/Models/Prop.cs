namespace Eternar.Core
{
    public sealed class Prop : Entity
    {
        public Prop(int handle) : base(handle)
            { }

        public override bool Exists()
            => base.Exists() && Natives.GetEntityType(this.Handle) == EntityType.Object;

        public static bool Exists(Prop prop)
            => !ReferenceEquals(prop, null) && prop.Exists();
    }
}