namespace Drawing
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Black_Clicked(object sender, EventArgs e)
        {
            DrawingView.LineColor = Color.FromArgb("#000000");
            Selected.BackgroundColor = Color.FromArgb("#000000");
        }

        private void Blue_Clicked(object sender, EventArgs e)
        {
            DrawingView.LineColor = Color.FromArgb("#0000ff");
            Selected.BackgroundColor = Color.FromArgb("#0000ff");
        }
        private void Red_Clicked(object sender, EventArgs e)
        {
            DrawingView.LineColor = Color.FromArgb("#ff0000");
            Selected.BackgroundColor = Color.FromArgb("#ff0000");
        }
        private void Green_Clicked(object sender, EventArgs e)
        {
            DrawingView.LineColor = Color.FromArgb("#66aa66");
            Selected.BackgroundColor = Color.FromArgb("#66aa66");
        }

        private void Clear_Clicked(object sender, EventArgs e)
        {
            DrawingView.Clear();
        }
    }
}