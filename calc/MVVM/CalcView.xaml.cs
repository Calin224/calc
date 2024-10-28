using Calc.MVVM.ViewModels;

namespace Calc.MVVM;

public partial class CalcView : ContentPage
{
	public CalcView()
	{
		InitializeComponent();

		BindingContext = new CalcViewModel();
	}
}