namespace Eternar.Core
{
    public sealed class Ped : Entity
    {
        public Tasks Tasks { get; }

        public Ped(int handle) : base(handle)
            => this.Tasks = new Tasks(this);

        public override int NetHandle
        {
            get => Natives.PedToNet(this.Handle);
        }

        public Gender Gender
        {
            get => Natives.IsPedMale(this.Handle) ? Gender.Male : Gender.Female;
        }

        public bool IsFalling
        {
           get => Natives.IsPedFalling(this.Handle);
        }

        public bool IsStandStill
        {
            get => Natives.IsPedStill(this.Handle);
        }

        public bool IsOnFoot
        {
            get => Natives.IsPedOnFoot(this.Handle);
        }
        
        public bool IsStopped
        {
            get => Natives.IsPedStopped(this.Handle);
        }

        public float Scale
        {
            set => Natives.SetPedScale(this.Handle, value);
        }

        public Vehicle CurrentVehicle
        {
            get => FromHandle(Natives.GetVehiclePedIsIn(this.Handle, false)) as Vehicle;
        }

        public Vehicle LastVehicle
        {
            get => FromHandle(Natives.GetVehiclePedIsIn(this.Handle, true)) as Vehicle;
        }

        public int GetAttributeValue(PedAttribute attribute)
            => Natives.GetAttributeCoreValue(this.Handle, attribute);

        public void SetAttributeValue(PedAttribute attribute, int value)
            => Natives.SetAttributeCoreValue(this.Handle, attribute, value);

        public bool IsEnteringTransport(Entity transportEntity)
            => Natives.IsPedEnteringTransport(this.Handle, transportEntity.Handle, false);

        public void ResetScale()
            => this.Scale = 1.0f;

        public override bool Exists()
            => base.Exists() && Natives.GetEntityType(this.Handle) == EntityType.Ped;

        public static bool Exists(Ped ped)
            => ped is object && ped.Exists();
    }
}