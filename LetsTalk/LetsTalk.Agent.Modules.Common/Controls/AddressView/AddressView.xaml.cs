namespace LetsTalk.Agent.Modules.Common.Controls
{
    using System.Windows;
    using System.Windows.Controls;

    using LetsTalk.Core.Common.Contracts.Entities;

    /// <summary>
    /// Interaction logic for AddressView.xaml
    /// </summary>
    public partial class AddressView : UserControl
    {
        public static readonly DependencyProperty AddressProperty = DependencyProperty.Register(
            "Address",
            typeof(IAddress),
            typeof(AddressView),
            new PropertyMetadata(default(IAddress)));

        public AddressView()
        {
            InitializeComponent();
        }

        /// <summary>Invoked whenever the effective value of any dependency property on this <see cref="T:System.Windows.FrameworkElement" /> has been updated. The specific dependency property that changed is reported in the arguments parameter. Overrides <see cref="M:System.Windows.DependencyObject.OnPropertyChanged(System.Windows.DependencyPropertyChangedEventArgs)" />.</summary>
        /// <param name="e">The event data that describes the property that changed, as well as old and new values.</param>
        protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
        {
            base.OnPropertyChanged(e);
            
        }

        public IAddress Address
        {
            get
            {
                return (IAddress)GetValue(AddressProperty);
            }
            set
            {
                
                SetValue(AddressProperty, value);
            }
        }
    }
}
