using Revision.Models;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Revision
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Pie> pies;
        public MainWindow()
        {
            InitializeComponent();
            pies = GetPies();
            PieOverviewList.ItemsSource = pies;
        }
        private ObservableCollection<Pie> GetPies()
        {
            var result = new ObservableCollection<Pie> //zelfde properties als een lijst, voordeel update de front-end automatisch
            {
                new Pie(1, "Franchipane"),
                new Pie(2, "Aardbeien"),
                new Pie(3, "Crumble"),
                new Pie(4, "American Pie"),
                new Pie(5, "Cheesecake"),
                new Pie(6, "Apple Pie"),
                new Pie(7, "Smurfentaart"),
                new Pie(8, "Confituurtaart"),
            };
            return result;
        }
        private void AddPie_Click(object sender, EventArgs e)
        {
            pies.Add(new Pie(9, "Rabarber"));
        }

        private void ListViewItem_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            //extract selected Pie from ListView
            var listItem = sender as ListViewItem;
            Pie pie = listItem.Content as Pie;

            Pie selectedPie = pies.Where(pie => pie.ID == 5).FirstOrDefault();
            //hier nu 'pie' ipv 'x' ook een manier: Pie selectedPie = pies.FirstOrDefault(pie => pie.ID == 5);
            if (pie != null)
            {
                var detailView = new PieDetailView(pie);
                detailView.ShowDialog();
            }
        }
    }
}
