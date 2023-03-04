using Microsoft.UI.Xaml;

namespace UIWindowSystemsDemo.Maui;

public partial class MainPage : ContentPage
{
    InteractionService _interactionService;

    public MainPage()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        // Create app
        MyApplication application = new MyApplication();

        _interactionService = new InteractionService();
        application.Container.RegisterInstance(_interactionService);

        EvergineViewl.Application = EvergineView2.Application = application;
    }

    void OnEvergineViewPointerPressed(object sender, EventArgs e)
    {
        ((FrameworkElement)sender).ReleasePointerCaptures();
    }

    void OnResetCameraClicked(object sender, EventArgs e)
    {
        _interactionService.ResetCamera();
    }

    void OnDisplacementChanged(object sender, ValueChangedEventArgs e)
    {
        _interactionService.Displacement = (float)e.NewValue;
    }
}