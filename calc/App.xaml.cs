using Calc.MVVM;

namespace Calc
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CalcView();
        }
    }
}
