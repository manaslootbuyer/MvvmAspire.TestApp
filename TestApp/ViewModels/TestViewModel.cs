using MvvmAspire;
using Xamarin.Forms;
namespace TestApp.ViewModel
{
    public class TestViewModel : AppViewModel
    {
        public RelayCommand GoToNextPageCommand { get; set; }
       
        public TestViewModel()
        {
            GoToNextPageCommand = new RelayCommand(GoToNextPage);
        }

        async void GoToNextPage()
        {
            GoToNextPageCommand.CanRun = false;
            await Navigation.PushAsync<TestViewModel>();
            GoToNextPageCommand.CanRun = true;

        }
	}
}
