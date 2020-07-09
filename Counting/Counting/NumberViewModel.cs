using System.Threading.Tasks;
using Xamarin.Forms;

namespace Counting
{
    public class NumberViewModel
    {
        public NumberViewModel(
            int value, 
            INavigation navigation, 
            ColorScheme colors = null
        )
        {
            Number = value;
            Navigation = navigation;
            Colors = ColorScheme.Random(colors);
            NextCommand = new Command(async () => await Next());
        }

        private async Task Next()
        {
            var next = Number + 1;
            if (next > 9)
            {
                var number = 0;
                await Navigation.PopToRootAsync(true);
            }
            else
            {
                var vm = new NumberViewModel(
                    next, 
                    Navigation, 
                    ColorScheme.Random(Colors)
                );
                
                await Navigation.PushAsync(
                    new MainPage(vm), 
                    true
                );
            }
        }

        public ColorScheme Colors { get; set; }

        public Command NextCommand { get; set; }
        public int Number { get; set; }
        public INavigation Navigation { get; }
    }
}