using System.Threading.Tasks;
using Xamarin.CommunityToolkit.ObjectModel;
using Xamarin.Forms;

namespace Demo_CustomControl.ViewModels
{
    public class DemoViewModel : BaseViewModel
    {
        private bool isToggled;

        public AsyncCommand DemoCommand { get; set; }

        public bool IsToggled { get => isToggled; set { isToggled = value; DemoCommand.RaiseCanExecuteChanged(); } }
        public DemoViewModel()
        {
            DemoCommand = new AsyncCommand(Demo, CanDemo);
        }
        private bool CanDemo(object arg)
        {
            return IsToggled;
        }

        private async Task Demo()
        {
            await Application.Current.MainPage.DisplayAlert("Test", "", "Ok");
        }
    }
}
