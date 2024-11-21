namespace RGBPicker
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            Color color = Color.FromRgb(SliderRed.Value, SliderGreen.Value, SliderBlue.Value);
            Rectangle.Fill = new SolidColorBrush(color);
        }
    }
}
