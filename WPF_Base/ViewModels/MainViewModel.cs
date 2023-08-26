using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF_Base.Commands;
using WPF_Base.Services;

namespace WPF_Base.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly IViewService _viewService;
        public MainViewModel(IViewService viewService)
        {
            _viewService = viewService;
        }
        public ICommand ShowSettingViewCommand => new RelayCommand<object>(ShowSettingView);

        private void ShowSettingView(object obj)
        {
            _viewService.ShowSettingView();
        }
    }
}
