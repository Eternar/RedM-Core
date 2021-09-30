namespace Eternar.Core
{
    using System;

    using CitizenFX.Core.Native;

    public sealed class Player : INativeValue, IEquatable<Player>
    {
        public int Handle { get; private set; }

        private Ped Ped { get; set; }

        public Player(int handle)
            => this.Handle = handle;

        public override ulong NativeValue
        {
            get => (ulong)Handle;
            set => Handle = unchecked((int)value);
        }

        public Ped Character
        {
            get
            {
                if(this.Ped is object && this.Ped.Handle == this.Handle)
                    return this.Ped;

                this.Ped = new Ped(Natives.GetPlayerPed(this.Handle));
                return this.Ped;
            }
        }

        public bool Exists()
            => Natives.NetworkIsPlayerActive(this.Handle);

        public static bool Exists(Player player)
            => player is object && player.Exists();

        public bool Equals(Player other)
            => other != null && ReferenceEquals(this, other) && other.Handle == this.Handle;

        public override bool Equals(object obj)
            => obj is Player other && Equals(other);

        public override int GetHashCode()
            => this.Handle.GetHashCode();
    }
}