using Windows.UI.ViewManagement;
using Windows.UI.Xaml;

namespace Shell {
    public sealed partial class Start : Microsoft.Toolkit.Win32.UI.XamlHost.XamlApplication {
        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public Start() {
            this.Initialize();
            // this.InitializeComponent();
            //this.Suspending += this.OnSuspending;
            DetermineAppTheme();
        }

        private void DetermineAppTheme() {
            //AutoDetectTheme
            UISettings uiSettings = new UISettings();
            var backgroundColor = uiSettings.GetColorValue(UIColorType.Background);
            bool isDarkMode = false;
            if (backgroundColor == Windows.UI.Colors.Black)
                isDarkMode = true;
            if (isDarkMode)
                this.RequestedTheme = ApplicationTheme.Dark;
        }
    }
}
