using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrismAppTest1.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Main Page";
            LabelC = "Test";

            ButtonCCommand = new DelegateCommand(relayButtonC);
            ShowNextPageCommand = new DelegateCommand(relayShowNextPage);
        }

        private string _labelC = string.Empty;
        public string LabelC
        {
            get { return _labelC; }
            set { SetProperty(ref _labelC, value); }
        }

        public DelegateCommand ButtonCCommand { get; set; }
        public DelegateCommand ShowNextPageCommand { get; set; }

        private void relayButtonC()
        {
            LabelC = "EEE";
        }

        private void relayShowNextPage()
        {
            NavigationService.NavigateAsync(nameof(Views.PrismContentPage1));
        }
    }
}
