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
using WpfApp1.Models;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Mobile> mobiles = new List<Mobile>();
        public MainWindow()
        {
            InitializeComponent();

            mobiles.Add(new Mobile { Model = "S8", Price = 17500, Producer = "Samsung" });
            mobiles.Add(new Mobile { Model = "S10", Price = 30500, Producer = "Samsung" });
            mobiles.Add(new Mobile { Model = "X", Price = 30500, Producer = "Apple" });
            mobiles.Add(new Mobile { Model = "S7+", Price = 30500, Producer = "Apple" });
            mobiles.Add(new Mobile { Model = "Redmi Note 5", Price = 30500, Producer = "Xaomi" });
            mobiles.Add(new Mobile { Model = "Lumia 8", Price = 30500, Producer = "Nokia" });
            mobiles.Add(new Mobile { Model = "Expiria 2", Price = 30500, Producer = "Sony" });
            mobiles.Add(new Mobile { Model = "ZenPhone MaxPro(M.2)", Price = 30500, Producer = "Asus" });

            listBox.ItemsSource = mobiles;

            int a = 10;
        }
    }
}
