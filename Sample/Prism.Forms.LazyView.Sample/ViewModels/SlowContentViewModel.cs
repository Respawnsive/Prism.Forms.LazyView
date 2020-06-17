using System;
using System.Threading;
using Prism.Commands;
using Prism.Forms.LazyView.Sample.Views;
using Prism.Navigation;

namespace Prism.Forms.LazyView.Sample.ViewModels
{
    public class SlowContentViewModel : ViewModelBase
    {
        private Timer _timer;

        public SlowContentViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Lazy";
            Description = "Default view on screen while lazy loading slow content view in background thread";
        }

        private DelegateCommand _navigateCommand;
        public DelegateCommand NavigateCommand =>
            _navigateCommand ?? (_navigateCommand = new DelegateCommand(ExecuteCommandName));

        async void ExecuteCommandName()
        {
            await NavigationService.NavigateAsync($"{nameof(OtherPage)}");
        }

        private int _counter;
        public int Counter
        {
            get => _counter;
            set => SetProperty(ref _counter, value);
        }

        public override void OnAppearing()
        {
            base.OnAppearing();
            Counter = 0;
            _timer = new Timer(OnTimerTick, null, 0, 1000);
        }

        private void OnTimerTick(object state)
        {
            if(_counter < 10)
                Counter++;
            else
            {
                _timer.Dispose();
            }
        }

        public override void OnDisappearing()
        {
            base.OnDisappearing();
            _timer?.Dispose();
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
        }

        public override void OnNavigatedFrom(INavigationParameters parameters)
        {
            base.OnNavigatedFrom(parameters);
        }
    }
}
