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
using System.Windows.Shapes;

namespace ProduktyBindowanie
{
    /// <summary>
    /// Logika interakcji dla klasy Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private LiostaWindow listaWindow = null;
        public Window1()
        {
            InitializeComponent();
        }

        public Window1(LiostaWindow listaW)
        {
            InitializeComponent();
            this.listaWindow = listaW;
            PrzygotujWiazanie();

        }

        private void PrzygotujWiazanie()
        {
            Produkt produktZListy = listaWindow.listaProd.SelectedItem as Produkt;
            if (produktZListy != null)
            {
                gridProduktSzcz.DataContext = produktZListy;
            }
        }

    }
}
