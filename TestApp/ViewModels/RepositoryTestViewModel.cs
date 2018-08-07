using System;
using MvvmAspire;
using TestApp.Repository.Interfaces;
using Xamarin.Forms;
namespace TestApp.ViewModel
{
    public class RepositoryTestViewModel : AppViewModel
    {

        public RepositoryTestViewModel(IUserRepository userRepository)
        {
            //Save model
            userRepository.Add(new Models.UserModel
            {
                Age= 18,
                FirstName = "John",
                MiddleIntial = "L",
                Lastname = "Doe",
                UserId = Guid.NewGuid(),
            });


            var user = userRepository.Get();
        }
	}
}
