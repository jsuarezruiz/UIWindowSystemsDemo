using UIWindowSystemsDemo.Maui.Controls;
using UIWindowSystemsDemo.Maui.Handlers;

namespace UIWindowSystemsDemo.Maui.Extensions
{
    public static class AppBuilderExtensions
    {
        public static MauiAppBuilder UseMauiEvergine(this MauiAppBuilder builder)
        {
            builder.ConfigureMauiHandlers(h =>
            {
                h.AddHandler<EvergineView, EvergineViewHandler>();
            });

            return builder;
        }
    }
}