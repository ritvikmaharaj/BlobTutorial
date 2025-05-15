using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Button
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetDefaultSelections();
        }
        /// Summary
        /// Sets default selections for the controls based on various conditions:
        /// Feature A: Randomly enabled with one of the two modes selected
        /// Feature B: Always enabled; mode is selected based on whether the current second is even
        /// Feature C: Disabled by default with a fixed default mode.
        /// </summary>
        /// 

        private void SetDefaultSelections()
        {
            Random rnd = new Random();

            // For Feature A: A randomly enable and choose a mode.
            bool FeatureAEnabled = rnd.Next(0, 2) == 0;
            rbFeatureA.IsChecked = FeatureAEnabled;
            if (FeatureAEnabled)
            {
                // Randomly select one of the two modes
                bool model = rnd.Next(0, 2) == 0;
                rbFeatureB_Mode1.IsChecked = model;
                rbFeatureB_Mode2.IsChecked = model;
            }
            else
            {
                rbFeatureB_Mode1.IsChecked = false;
                rbFeatureB_Mode2.IsChecked = false;
            }

            // For feature B: Always enabled, with mode based on current second (even/odd)
            rbFeatureC.IsChecked = true;
            if (DateTime.Now.Second % 2 == 0)
            {
                rbFeatureC_Mode1.IsChecked = true;
                rbFeatureC_Mode2.IsChecked = false;

            }
            else
            {
                rbFeatureC_Mode1.IsChecked = false;
                rbFeatureC_Mode2.IsChecked = true;
            }
            // For feature C: disabled by default with a fixed default mode
            rbFeatureC.IsChecked = false;
            rbFeatureC_Mode1.IsChecked = true;
            rbFeatureC_Mode2.IsChecked = false;
        }
    }
}
