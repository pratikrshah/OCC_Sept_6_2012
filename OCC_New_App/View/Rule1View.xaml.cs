using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OCC_New_App
{
    /// <summary>
    /// Interaction logic for Rule1View.xaml
    /// </summary>
    public partial class Rule1View : UserControl
    {
        public Rule1View()
        {
            InitializeComponent();
            var rule1vm = new Rule1ViewModel();
            DataContext = rule1vm;
        }
    }
}
