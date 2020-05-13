using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrismAppTest1.ViewModels
{
    public class PrismContentPage1ViewModel : BindableBase
    {
        public PrismContentPage1ViewModel()
        {
            NextText = "Next Page";
        }

        private string _nextText = string.Empty;
        public string NextText
        {
            get { return _nextText; }
            set { SetProperty(ref _nextText, value); }
        }
    }
}
