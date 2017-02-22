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

namespace Tehtävä02
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

        /// <summary>
        /// Euromuunnokset
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void euroButton_Click(object sender, RoutedEventArgs e)
        {
           double value = double.Parse(euroTextBox.Text); // ottaa tekstilaatiokosta arvon...

            double markat;
            markat = value / 5.94573; // muunnos euroiksi

            string markat1 = markat.ToString("0.00"); // pyöristys kahden desimaalin tarkkuudelle

            string muuttuja = markat1.ToString();
            euroTextBlock.Text = (muuttuja + " eur"); // ... ja tunkee sen muunnettuna tekstikenttään
        }

        /// <summary>
        /// Markkamuunnokset
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void markkaButton_Click(object sender, RoutedEventArgs e)
        {
            double value = double.Parse(markkaTextBox.Text); // ottaa tekstilaatiokosta arvon...

            double eurot;
            eurot = value * 5.94573; // muunnos markoiksi

            string eurot1 = eurot.ToString("0.00"); // pyöristys kahden desimaalin tarkkuudelle

            string muuttuja = eurot1.ToString();
            markkaTextBlock.Text = (muuttuja + " mk"); // ... ja tunkee sen muunnettuna tekstikenttään
        }
    }
}
