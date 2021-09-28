namespace Eternar.Core
{
    using System;

    using CitizenFX.Core;

    /// <summary>
    /// Represents a <see cref="Blip"/>.
    /// </summary>
    public sealed class Blip : PoolObject, IEquatable<Blip>
    {
        public Blip(int handle) : base(handle)
            { }

        /// <summary>
        /// Sets this blip Sprite.
        /// </summary>
        public BlipSprite Sprite
        {
            set => Natives.SetBlipSprite(this.Handle, (uint)value);
        }

        /// <summary>
        /// Sets this blip Scale.
        /// </summary>
        public float Scale
        {
            set => Natives.SetBlipScale(this.Handle, value);
        }

        /// <summary>
        /// Sets this blip Rotation.
        /// </summary>
        public int Rotation
        {
            set => Natives.SetBlipRotation(this.Handle, value);
        }

        /// <summary>
        /// Sets this blip Name.
        /// </summary>
        public VarString Name
        {
            set => Natives.SetBlipName(this.Handle, value);
        }

        /// <summary>
        /// Sets this blip flashing state.
        /// </summary>
        public bool IsFlashing
        {
            set => Natives.SetBlipFlashes(this.Handle, value);
        }

        /// <summary>
        /// Gets this blip minimap state.
        /// </summary>
        public bool IsOnMinimap
            => Natives.IsBlipOnMinimap(this.Handle);

        /// <summary>
        /// Gets this blip position.
        /// </summary>
        public Vector2 Position
            => (Vector2)Natives.GetBlipCoords(this.Handle);

        /// <summary>
        /// Gets a blip from the given entity.
        /// </summary>
        /// <param name="entity">Entity.</param>
        /// <returns></returns>
        public static Blip GetFromEntity(Entity entity)
            => entity.Blip;

        public override bool Exists()
            => Natives.DoesBlipExists(this.Handle);

        public override void Delete()
            => Natives.RemoveBlip(this.Handle);

        public bool Equals(Blip other)
            => other is object && other.Handle == this.Handle;

        public override bool Equals(object obj)
            => ReferenceEquals(this, obj) || obj is Blip other && Equals(other);

        public override int GetHashCode()
            => this.Handle.GetHashCode();
    }
}