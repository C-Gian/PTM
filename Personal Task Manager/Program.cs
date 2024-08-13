using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Personal_Task_Manager.Configuration;
using Personal_Task_Manager.NavigationManager;
using Personal_Task_Manager.Presenters.LoginPresenter;
using Personal_Task_Manager.Presenters.SignupPresenter;
using Personal_Task_Manager.Presenters.TasksPresenter;
using Personal_Task_Manager.Repositories.TasksRepository;
using Personal_Task_Manager.Repositories.UserRepository;
using Personal_Task_Manager.Views.LoginForm;
using Personal_Task_Manager.Views.SignupForm;
using Personal_Task_Manager.Views.TasksForm;

namespace Personal_Task_Manager
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var serviceCollection = new ServiceCollection();

            //Repositories
            serviceCollection.AddSingleton<IUserRepository, UserRepository>();
            serviceCollection.AddSingleton<ITasksRepository, TasksRepository>();

            //Views
            serviceCollection.AddSingleton<ILoginView, LoginView>();
            serviceCollection.AddSingleton<ITasksView, TasksView>();
            serviceCollection.AddSingleton<ISignupView, SignupView>();

            //Presenters
            serviceCollection.AddSingleton<ILoginPresenter, LoginPresenter>();
            serviceCollection.AddSingleton<ITasksPresenter, TasksPresenter>();
            serviceCollection.AddSingleton<ISignupPresenter, SignupPresenter>();


            //Navigation Manager
            serviceCollection.AddSingleton<INavigationManager, NavigationManager.NavigationManager>();

            var builder = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile(Path.Combine("Configuration", "appsettings.json"), optional: false, reloadOnChange: true);
            var _configuration = builder.Build();
            serviceCollection.AddSingleton(_configuration.GetSection("ConnectionStrings").Get<MySettings>());


            var serviceProvider = serviceCollection.BuildServiceProvider();

            var navigationManager = serviceProvider.GetRequiredService<INavigationManager>();
            navigationManager.ShowLoginView();

            Application.Run(navigationManager._currentForm);

            //var presenter = serviceProvider.GetRequiredService<ILoginPresenter>();
                
            //Application.Run((Form)presenter._loginView);
        }
    }
}