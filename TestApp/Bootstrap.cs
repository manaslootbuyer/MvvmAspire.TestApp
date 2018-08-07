
using MvvmAspire;
using MvvmAspire.Services;
using MvvmAspire.Unity;
using TestApp.Repository;
using TestApp.Repository.Interfaces;
using TestApp.ViewModel;
using TestApp.Views;
using Unity;
using Unity.Lifetime;

namespace TestApp {
    public static class AppBootstrap {
        static UnityContainer container;

        public static UnityDependencyResolver Init (bool forBackgroundService = false) {
            container = new UnityContainer ();
            var resolver = new UnityDependencyResolver (container);
            container.RegisterType<IUserRepository, UserRepository>(new ContainerControlledLifetimeManager());

            if (!forBackgroundService) {
                Resolver.SetResolver (resolver);
                container.RegisterInstance<INavigation> (RegisterNavigation ());
                RegisterMapping ();
            }
            return resolver;
        }

        public static void RegisterOverrides () {
            RegisterOverrides (Resolver.Current);
        }

        public static void RegisterOverrides (IDependencyResolver resolver) {
            resolver.GetContainer ();
        }

        /// <summary>
        /// Registration of Navigation MVVM
        /// </summary>
        /// <returns></returns>
        public static INavigation RegisterNavigation () {
            var navigation = new XamarinFormsNavigation (() => App.Current);
            navigation.Register<TestViewModel, TestPage>();
            navigation.Register<AboutViewModel, AboutPage>();
            navigation.Register<RepositoryTestViewModel, MarcelloDbPage>();
            return navigation;
        }

        /// <summary>
        /// Mapping DataModels
        /// </summary>
        static void RegisterMapping () {

        }
    }
}