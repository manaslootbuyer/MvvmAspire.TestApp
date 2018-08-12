
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TestApp.Models;
using TestApp.ViewModel;
using Xamarin.Forms;


namespace MvvmAspire.ViewModel
{
    public class ListViewWithCacheViewModel : AppViewModel
    {
        

        ObservableCollection<UserModel> _userList;
        public ObservableCollection<UserModel> UserList
        {
            get => _userList;
            set => SetProperty(ref _userList, value);
        }
        public ListViewWithCacheViewModel()
        {
            UserList = new ObservableCollection<UserModel>();
        }


       
        public  override void Init()
        {
            base.Init();
            var templist = new ObservableCollection<UserModel>();
            templist.Add(new UserModel
            {
                FirstName = "John",
                Lastname = "Doe",
                Address="North Korea",
                ImageUrl="https://www.wikihow.com/images/f/ff/Draw-a-Cute-Cartoon-Person-Step-14.jpg"

            });

            templist.Add(new UserModel
            {
                FirstName = "Scooby",
                Lastname = "Doo",
                Address = "United States",
                ImageUrl = "https://pbs.twimg.com/profile_images/815785432248188928/cfYoIt5-_400x400.jpg"

            });
            templist.Add(new UserModel
            {
                FirstName = "John",
                Lastname = "Doe",
                Address = "North Korea",
                ImageUrl = "https://www.wikihow.com/images/f/ff/Draw-a-Cute-Cartoon-Person-Step-14.jpg"

            });

            templist.Add(new UserModel
            {
                FirstName = "Scooby",
                Lastname = "Doo",
                Address = "United States",
                ImageUrl = "https://pbs.twimg.com/profile_images/815785432248188928/cfYoIt5-_400x400.jpg"

            });
            templist.Add(new UserModel
            {
                FirstName = "John",
                Lastname = "Doe",
                Address = "North Korea",
                ImageUrl = "https://www.wikihow.com/images/f/ff/Draw-a-Cute-Cartoon-Person-Step-14.jpg"

            });

            templist.Add(new UserModel
            {
                FirstName = "Scooby",
                Lastname = "Doo",
                Address = "United States",
                ImageUrl = "https://pbs.twimg.com/profile_images/815785432248188928/cfYoIt5-_400x400.jpg"

            });
            templist.Add(new UserModel
            {
                FirstName = "John",
                Lastname = "Doe",
                Address = "North Korea",
                ImageUrl = "https://www.wikihow.com/images/f/ff/Draw-a-Cute-Cartoon-Person-Step-14.jpg"

            });

            templist.Add(new UserModel
            {
                FirstName = "Scooby",
                Lastname = "Doo",
                Address = "United States",
                ImageUrl = "https://pbs.twimg.com/profile_images/815785432248188928/cfYoIt5-_400x400.jpg"

            });
            templist.Add(new UserModel
            {
                FirstName = "John",
                Lastname = "Doe",
                Address = "North Korea",
                ImageUrl = "https://www.wikihow.com/images/f/ff/Draw-a-Cute-Cartoon-Person-Step-14.jpg"

            });

            templist.Add(new UserModel
            {
                FirstName = "Scooby",
                Lastname = "Doo",
                Address = "United States",
                ImageUrl = "https://pbs.twimg.com/profile_images/815785432248188928/cfYoIt5-_400x400.jpg"

            });

            templist.Add(new UserModel
            {
                FirstName = "John",
                Lastname = "Doe",
                Address = "North Korea",
                ImageUrl = "https://www.wikihow.com/images/f/ff/Draw-a-Cute-Cartoon-Person-Step-14.jpg"

            });

            templist.Add(new UserModel
            {
                FirstName = "Scooby",
                Lastname = "Doo",
                Address = "United States",
                ImageUrl = "https://pbs.twimg.com/profile_images/815785432248188928/cfYoIt5-_400x400.jpg"

            });

            templist.Add(new UserModel
            {
                FirstName = "John",
                Lastname = "Doe",
                Address = "North Korea",
                ImageUrl = "https://www.wikihow.com/images/f/ff/Draw-a-Cute-Cartoon-Person-Step-14.jpg"

            });

            templist.Add(new UserModel
            {
                FirstName = "Scooby",
                Lastname = "Doo",
                Address = "United States",
                ImageUrl = "https://pbs.twimg.com/profile_images/815785432248188928/cfYoIt5-_400x400.jpg"

            });


            templist.Add(new UserModel
            {
                FirstName = "John",
                Lastname = "Doe",
                Address = "North Korea",
                ImageUrl = "https://www.wikihow.com/images/f/ff/Draw-a-Cute-Cartoon-Person-Step-14.jpg"

            });

            templist.Add(new UserModel
            {
                FirstName = "Scooby",
                Lastname = "Doo",
                Address = "United States",
                ImageUrl = "https://pbs.twimg.com/profile_images/815785432248188928/cfYoIt5-_400x400.jpg"

            });


            templist.Add(new UserModel
            {
                FirstName = "John",
                Lastname = "Doe",
                Address = "North Korea",
                ImageUrl = "https://www.wikihow.com/images/f/ff/Draw-a-Cute-Cartoon-Person-Step-14.jpg"

            });

            templist.Add(new UserModel
            {
                FirstName = "Scooby",
                Lastname = "Doo",
                Address = "United States",
                ImageUrl = "https://pbs.twimg.com/profile_images/815785432248188928/cfYoIt5-_400x400.jpg"

            });




            templist.Add(new UserModel
            {
                FirstName = "John",
                Lastname = "Doe",
                Address = "North Korea",
                ImageUrl = "https://www.wikihow.com/images/f/ff/Draw-a-Cute-Cartoon-Person-Step-14.jpg"

            });

            templist.Add(new UserModel
            {
                FirstName = "Scooby",
                Lastname = "Doo",
                Address = "United States",
                ImageUrl = "https://pbs.twimg.com/profile_images/815785432248188928/cfYoIt5-_400x400.jpg"

            });


            templist.Add(new UserModel
            {
                FirstName = "John",
                Lastname = "Doe",
                Address = "North Korea",
                ImageUrl = "https://www.wikihow.com/images/f/ff/Draw-a-Cute-Cartoon-Person-Step-14.jpg"

            });

            templist.Add(new UserModel
            {
                FirstName = "Scooby",
                Lastname = "Doo",
                Address = "United States",
                ImageUrl = "https://pbs.twimg.com/profile_images/815785432248188928/cfYoIt5-_400x400.jpg"

            });
          

            UserList = templist;
        }
	}
}
