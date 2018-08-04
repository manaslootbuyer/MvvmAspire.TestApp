using MvvmAspire;
using Xamarin.Forms;
namespace TestApp.ViewModel
{
    public class TestViewModel : AppViewModel
    {
        public RelayCommand GoToNextPageCommand { get; set; }
       
        public string _buttonName;
        public string ButtonName
        {
            get => _buttonName;
            set =>SetProperty(ref _buttonName, value);
        }

        public TestViewModel()
        {
            GoToNextPageCommand = new RelayCommand(GoToNextPage);
            ButtonName = "Go To Next Page";
        }

        async void GoToNextPage()
        {
            GoToNextPageCommand.CanRun = false;
            await Navigation.PushAsync<AboutViewModel>();
            GoToNextPageCommand.CanRun = true;

        }
	}
}
