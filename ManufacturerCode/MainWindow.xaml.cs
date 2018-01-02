using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using DevExpress.Xpf.Core;
using ManufacturerCode.ViewModel;

namespace ManufacturerCode
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : DXWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            //ObservableCollection<Manufacturer> manufacturers = new ObservableCollection<Manufacturer>();

            //for(int i=0; i<=25; i++)
            //{
            //    manufacturers.Add(new Manufacturer { Code = i + "A", ManufacturerName = "Test" + i });
            //}

            //MlookUp.ItemsSource = manufacturers;
        }

   
    }
}
