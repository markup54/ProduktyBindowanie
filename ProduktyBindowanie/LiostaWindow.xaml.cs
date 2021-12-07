using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Logika interakcji dla klasy LiostaWindow.xaml
    /// </summary>
    public partial class LiostaWindow : Window
    {
        private ObservableCollection<Produkt> ListaProduktow = null;
        public LiostaWindow()
        {
            InitializeComponent();
            PrzygotujWiazanie();
        }

        private void PrzygotujWiazanie()
        {
            ListaProduktow = new ObservableCollection<Produkt>();
            ListaProduktow.Add(new Produkt("ch", "chlebek", 200, "Zabrze"));
            ListaProduktow.Add(new Produkt("ok", "ogórki kiszone", 100, "Zabrze"));
            ListaProduktow.Add(new Produkt("ok", "papryka", 50, "Zabrze"));
            ListaProduktow.Add(new Produkt("st", "serek topiony", 150, "Gliwice"));
            listaProd.ItemsSource = ListaProduktow;
        }
    }
}
