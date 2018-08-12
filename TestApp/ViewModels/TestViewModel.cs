using MvvmAspire;
using MvvmAspire.ViewModel;
using Xamarin.Forms;
namespace TestApp.ViewModel
{
    public class TestViewModel : AppViewModel
    {
        public RelayCommand GoToNextPageCommand { get; set; }
        public RelayCommand GoToTestRepositoryCommand { get; set; }
        public RelayCommand GoToListViewCommand { get; set; }
        public string _buttonName;
        public string ButtonName
        {
            get => _buttonName;
            set =>SetProperty(ref _buttonName, value);
        }

        public TestViewModel()
        {
            GoToNextPageCommand = new RelayCommand(GoToNextPage);
            GoToListViewCommand= new RelayCommand(GoToListView);
            GoToTestRepositoryCommand = new RelayCommand(GoToTestRepository);
            ButtonName = "MVVM Controls";
        }

        async void GoToNextPage()
        {
            GoToNextPageCommand.CanRun = false;
            await Navigation.PushAsync<AboutViewModel>();
            GoToNextPageCommand.CanRun = true;

        }

        async void GoToListView()
        {
            GoToNextPageCommand.CanRun = false;
            await Navigation.PushAsync<ListViewWithCacheViewModel>();
            GoToNextPageCommand.CanRun = true;

        }

        async void GoToTestRepository()
        {
            GoToTestRepositoryCommand.CanRun = false;
            await Navigation.PushAsync<RepositoryTestViewModel>();
            GoToTestRepositoryCommand.CanRun = true;

        }
	}
}
