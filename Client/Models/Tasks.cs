namespace Eternar.Core
{
    public sealed class Tasks
    {
        internal Ped Ped { get; }

        internal Tasks(Ped ped)
            => this.Ped = ped;

        public void StandStill(int duration)
            => Natives.TaskStandStill(this.Ped.Handle, duration);

        public void Jump()
            => Natives.TaskJump(this.Ped.Handle);

        public void Whistle()
            => Natives.TaskWhistle(this.Ped.Handle, 869278708, 1971704925);
    }
}