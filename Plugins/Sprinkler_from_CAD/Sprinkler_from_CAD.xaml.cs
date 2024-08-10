using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
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

namespace Sprinkler_Plugins.Plugins.Sprinkler_from_CAD
{
    /// <summary>
    /// Interaction logic for Sprinkler_from_CAD.xaml
    /// </summary>
    public partial class Sprinkler_from_CAD : Window
    {
        public Sprinkler_from_CAD(UIDocument uidoc_From_plugin ,Document doc_From_plugin)
        {
            UIDocument uIDocument = uidoc_From_plugin;
            Document doc = doc_From_plugin;

            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TaskDialog.Show("ddw", "Mohamed");
        }
    }
}
