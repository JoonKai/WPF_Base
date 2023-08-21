using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WPF_Base.Services;

namespace WPF_Base
{
    /// <summary>
    /// App.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class App : Application
    {
        private readonly IServiceProvider _services = null;
        public App()
        {
            _services = ConfigureService();
        }

        private IServiceProvider ConfigureService()
        {
            
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            
        }
    }
}
