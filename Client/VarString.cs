namespace Eternar.Core
{
    using static Natives.Natives;

    public class VarString
    {
        public long Text { get; internal set; }

        public VarString(long l)
        {
            this.Text = l;
        }

        public static implicit operator long(VarString vs) => vs.Text;
        public static implicit operator VarString(long l) => new VarString(l);
    }

    public static class VarStringExt
    {
        public static VarString ToVarString(this string text)
            => CreateVarString(text);
    }
}