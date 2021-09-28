namespace Eternar.Core
{
    using CitizenFX.Core;

    public interface ISpatial
    {
        Vector3 Position { get; set; }
        Vector3 Rotation { get; set; }
    }
}