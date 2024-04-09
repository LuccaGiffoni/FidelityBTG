using FidelityBTG.MVVM.Views;

namespace FidelityBTG
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            RegisterForRoute<AddClientPage>();
            RegisterForRoute<UpdateClientPage>();
        }
        protected void RegisterForRoute<T>()
        {
            Routing.RegisterRoute(typeof(T).Name, typeof(T));
        }
    }
}
