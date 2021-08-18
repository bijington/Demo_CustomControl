using System;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo_CustomControl
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomControl : ContentView
    {
        public CustomControl()
        {
            InitializeComponent();
        }

        public static readonly BindableProperty ButtonCommandProperty = BindableProperty.Create(nameof(ButtonCommand), typeof(ICommand), typeof(Button));
        public ICommand ButtonCommand
        {
            get { return (ICommand)GetValue(ButtonCommandProperty); }
            set { SetValue(ButtonCommandProperty, value); }
        }

        private void BtnCommand_Clicked(object sender, EventArgs e)
        {
            ButtonCommand?.Execute(null);
        }

    }
}