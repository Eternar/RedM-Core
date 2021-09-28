namespace Eternar.Core
{
    using CitizenFX.Core;

    /// <summary>
    /// Represents a <see cref="Blip"/>.
    /// </summary>
    public static class Screen
    {
        public const float Width = 1280f;
        public const float Height = 720f;

        public const float AspectRatio = Width / Height;

        public const float ScaledWidth = Width * AspectRatio;

        /// <summary>
        /// Hardcoded to always set x to 1280 and y to 720.
        /// </summary>
        public static Vector2 Resolution
        {
            get
            {
                int height = 0, width = 0;
                Natives.GetScreenResolution(ref width, ref height);
                return new Vector2(width, height);
            }
        }

        public static bool IsFadingIn
            => Natives.IsScreenFadingIn();
        public static bool IsFadingOut
            => Natives.IsScreenFadingOut();

        public static void FadeIn(int time)
            => Natives.DoScreenFadeIn(time);

        public static void FadeOut(int time)
            => Natives.DoScreenFadeOut(time);
    }
}