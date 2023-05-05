namespace App;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        Content = new StackLayout
        {
            Spacing = 20,
            Margin = 10,
            Children = {
                new Border {
                    Stroke = Brush.Black,
                    StrokeThickness = 3,
                    Content = new Label { Text = "Without StrokeDashOffset" },
                    Padding = 10,

                    StrokeDashArray = new DoubleCollection { 2, 1 },
                    },
                new Border {
                    Stroke = Brush.Black,
                    StrokeThickness = 3,
                    Content = new Label { Text = "With StrokeDashOffset" },
                    Padding = 10,

                    StrokeDashArray = new DoubleCollection { 2, 1 },
                    StrokeDashOffset = 1,
                },
            }
        };
    }
}


