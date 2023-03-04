using Microsoft.Maui.Handlers;
using UIKit;
using UIWindowSystemsDemo.Maui.Controls;

namespace UIWindowSystemsDemo.Maui.Handlers
{
    public partial class EvergineViewHandler : ViewHandler<EvergineView, UIView>
    {
        protected override UIView CreatePlatformView() => throw new NotImplementedException();

        public static void MapApplication(EvergineViewHandler handler, EvergineView evergineView) => throw new NotImplementedException();
    }
}