namespace Eternar.Core
{
    using System;

    using CitizenFX.Core.Native;

    public abstract class PoolObject : INativeValue, IDeletable, IDisposable
    {
        public int Handle { get; protected set; }

        protected PoolObject(int handle)
        {
            this.Handle = handle;
        }

        public override ulong NativeValue
        {
            get { return (ulong)this.Handle; }
            set { this.Handle = unchecked((int)value); }
        }

        public abstract bool Exists();

        public abstract void Delete();

        public void Dispose()
        {
            Delete();
        }
    }
}