namespace MyMauiStylesLibrary
{
    // All the code in this file is included in all platforms.
    public static class MauiProgramExtension
    {
        public static MauiAppBuilder UseMyStylesLibrary(this MauiAppBuilder builder)
        {
            builder.ConfigureFonts(fonts =>
            {
                fonts.AddFont("DMSans-Bold.ttf", "SharedDMSans");
            });


            return builder;
        }
    }
}
