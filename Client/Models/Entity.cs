namespace Eternar.Core
{
    using System;

    using CitizenFX.Core;

    public class Entity : PoolObject, IEquatable<Entity>, ISpatial
    {
        public Entity(int handle) : base(handle)
            { }

        public virtual Vector3 Position
        {
            get => Natives.GetEntityCoords(this.Handle, true, true);
            set => Natives.SetEntityCoords(this.Handle, value.X, value.Y, value.Z, false, false, false, true);
        }

        public virtual Vector3 Rotation
        {
            get => Natives.GetEntityRotation(this.Handle, 2);
            set => Natives.SetEntityRotation(this.Handle, value.X, value.Y, value.Z, 2, true);
        }

        public Blip Blip
        {
            get => new Blip(Natives.GetBlipFromEntity(this.Handle));
        }

        public override bool Exists()
            => Natives.DoesEntityExists(this.Handle);

        public override void Delete()
            => Natives.DeleteEntity(this.Handle);

        public bool Equals(Entity entity)
            => !ReferenceEquals(entity, null) && Handle == entity.Handle;

        public override bool Equals(object obj)
            => !ReferenceEquals(obj, null) && obj.GetType() == GetType() && Equals((Entity)obj);

        public override int GetHashCode()
            => Handle.GetHashCode();

        public static bool operator ==(Entity left, Entity right)
            => left?.Equals(right) ?? ReferenceEquals(right, null);

        public static bool operator !=(Entity left, Entity right)
            => !(left == right);
    }
}