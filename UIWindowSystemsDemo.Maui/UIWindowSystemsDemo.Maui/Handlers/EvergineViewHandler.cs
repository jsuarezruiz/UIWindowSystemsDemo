#if IOS || MACCATALYST
using PlatformView = System.Object;
#elif ANDROID
using PlatformView = System.Object;
#elif WINDOWS
using PlatformView = Microsoft.UI.Xaml.Controls.SwapChainPanel;
#elif NETSTANDARD || !PLATFORM || (NET6_0_OR_GREATER && !IOS && !ANDROID)
using PlatformView = System.Object;
#endif

using Microsoft.Maui.Handlers;
using UIWindowSystemsDemo.Maui.Controls;

namespace UIWindowSystemsDemo.Maui.Handlers
{
    public partial class EvergineViewHandler
    {
        public static IPropertyMapper<EvergineView, EvergineViewHandler> PropertyMapper = new PropertyMapper<EvergineView, EvergineViewHandler>(ViewMapper)
        {
            [nameof(EvergineView.Application)] = MapApplication,
        };

        public static CommandMapper<EvergineView, EvergineViewHandler> CommandMapper = new(ViewCommandMapper);

        public EvergineViewHandler() : base(PropertyMapper, CommandMapper)
        {
        }
    }
}
