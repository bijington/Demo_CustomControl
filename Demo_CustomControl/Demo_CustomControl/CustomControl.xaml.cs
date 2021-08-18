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

        public static readonly BindableProperty ButtonCommandProperty = BindableProperty.Create(nameof(ButtonCommand), typeof(ICommand), typeof(Button), propertyChanged: OnButtonCommandChanged);

        public ICommand ButtonCommand
        {
            get { return (ICommand)GetValue(ButtonCommandProperty); }
            set { SetValue(ButtonCommandProperty, value); }
        }

        private static void OnButtonCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is CustomControl customControl)
            {
                customControl.BtnCommand.Command = (ICommand)newValue;
            }
        }
    }
}