using Xamarin.Forms;

namespace Counting
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new NumberViewModel(
                1, 
                Navigation
            ); 
        }

        public MainPage(NumberViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }
    }
}