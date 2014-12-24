using MVVM_Techdays.ViewModel;
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

namespace MVVM_Techdays.View
{
    /// <summary>
    /// Interaction logic for AjouterProduitView.xaml
    /// </summary>
    public partial class AjouterProduitView : UserControl
    {
        public AjouterProduitView()
        {
            InitializeComponent();
            Loaded += new RoutedEventHandler(MainWindow_Loaded);
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            //DataContext = new AjouterProduitViewModel();
        }
    }
}
