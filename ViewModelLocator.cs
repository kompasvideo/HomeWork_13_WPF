using Microsoft.Extensions.DependencyInjection;
//using HomeWork_13_WPF.Services;
using HomeWork_13_WPF.ViewModel;

namespace HomeWork_13_WPF
{
    public class ViewModelLocator
    {
        private static ServiceProvider _provider;

        public static void Init()
        {
            var services = new ServiceCollection();

            services.AddTransient<AddAccountViewModel>();
            services.AddTransient<AddDepositCapitalizeViewModel>();
            services.AddTransient<AddDepositNoCapitalizeViewModel>();
            services.AddTransient<MoveMoneyViewModel>();
            services.AddTransient<RateViewModel>();

            services.AddSingleton<MainViewModel>();



            _provider = services.BuildServiceProvider();

            foreach (var item in services)
            {
                _provider.GetRequiredService(item.ServiceType);
            }
        }

        public MainViewModel MainViewModel => _provider.GetRequiredService<MainViewModel>();
        public AddAccountViewModel AddAccountViewModel => _provider.GetRequiredService<AddAccountViewModel>();
        public AddDepositCapitalizeViewModel AddDepositCapitalizeViewModel => _provider.GetRequiredService<AddDepositCapitalizeViewModel>();
        public AddDepositNoCapitalizeViewModel AddDepositNoCapitalizeViewModel => _provider.GetRequiredService<AddDepositNoCapitalizeViewModel>();
        public MoveMoneyViewModel MoveMoneyViewModel => _provider.GetRequiredService<MoveMoneyViewModel>();
        public RateViewModel RateViewModel => _provider.GetRequiredService<RateViewModel>();
    }
}
