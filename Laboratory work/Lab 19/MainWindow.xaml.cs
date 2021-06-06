using System.IO;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;

namespace Lab_19
{
    public partial class MainWindow
    {
        private const string SettingsPath = @"settings.json";
        
        private SettingsContainer _settingsContainer;
        
        public MainWindow()
        {
            InitializeComponent();
            LoadOrInitSettings();
        }

        private void LoadOrInitSettings()
        {
            if (!TryLoadAndSetSettings())
            {
                _settingsContainer = new SettingsContainer();
            }
        }
        
        private bool TryLoadAndSetSettings()
        {
            if (!File.Exists(SettingsPath))
            {
                return false;
            }
            
            using (StreamReader streamReader = new StreamReader(SettingsPath))
            {
                string settingsJson = streamReader.ReadToEnd();
                SettingsContainer settings = JsonSerializer.Deserialize<SettingsContainer>(settingsJson);
                _settingsContainer = settings;
                SetSettings(settings);
            }
              
            return true;
        }

        private void SetSettings(SettingsContainer settings)
        {
            if (Application.Current.MainWindow != null)
            {
                Application.Current.MainWindow.Height = settings.HeightWindow;
                Application.Current.MainWindow.Width = settings.WidthWindow;
            }

            FirstCheckBox.IsChecked = settings.FirstCheckBoxChecked;
            SecondCheckBox.IsChecked = settings.SecondCheckBoxChecked;
            
            TextBox.Text = settings.TextBoxContent;
        }

        private void MainWindow_OnSizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (Application.Current.MainWindow == null)
            {
                return;
            }
            
            _settingsContainer.HeightWindow = Application.Current.MainWindow.Height;
            _settingsContainer.WidthWindow = Application.Current.MainWindow.Width;

            Save();
        }

        private void TextBox_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                _settingsContainer.TextBoxContent = textBox.Text;
            }

            Save();
        }

        private void FirstCheckBox_OnClick(object sender, RoutedEventArgs e)
        {
            bool? isChecked = (sender as CheckBox)?.IsChecked;
            if (isChecked != null)
            {
                _settingsContainer.FirstCheckBoxChecked = isChecked.Value;
            }

            Save();
        }

        private void SecondCheckBox_OnClick(object sender, RoutedEventArgs e)
        {
            bool? isChecked = (sender as CheckBox)?.IsChecked;
            if (isChecked != null)
            {
                _settingsContainer.SecondCheckBoxChecked = isChecked.Value;
            }

            Save();
        }

        private void Save()
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(SettingsPath))
                {
                    string settingsJson = JsonSerializer.Serialize(_settingsContainer);
                    streamWriter.Write(settingsJson);
                }
            }
            catch
            {
                // ignored
            }
        }
    }
}