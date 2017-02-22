using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Ikkunahomma
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void laske_Click(object sender, RoutedEventArgs e)
        {
            double value = double.Parse(ilev1.Text);
            double value2 = double.Parse(ikor1.Text);
            double value3 = double.Parse(kale1.Text);

            double iala = (value * value2) / 10;
            double lala = ((value - (value3 * 2)) * (value2 - (value3 * 2))) / 10;
            double kpii = ((value * 2) + (value2 * 2)) / 10;

            iala1.Text = iala.ToString()+" cm^2";
            lala1.Text = lala.ToString() + " cm^2";
            kpii1.Text = kpii.ToString() + " cm";
        }
    }
}
