using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Editors;
using DevExpress.Mvvm;
using DevExpress.Mvvm.UI;

namespace ManufacturerCode.ViewModel
{
    public class ManufacturerViewModel : ViewModelBase
    {
        public ManufacturerViewModel()
        {
            this.Manufacturers = new ObservableCollection<Manufacturer>(Manufacturer.GetManufacturers());
            this.ChildManufacturers = new List<ChildManufacturer>();
        }

        public ObservableCollection<Manufacturer> Manufacturers { get; set; }

        public List<ChildManufacturer> ChildManufacturers { get; set; }

        public void SelectedItemChanged(object editValue)
        {
            this.ChildManufacturers = ChildManufacturer.GetChildManufacturers();
        }

        //public ICommand _selectedItemChangedOnManufacturer;
        //public ICommand SelectedItemChangedOnManufacturer
        //{

        //    get
        //    {
        //        if (_selectedItemChangedOnManufacturer == null)
        //            _selectedItemChangedOnManufacturer = new DelegateCommand<string>(OnShowProductFormCommandExecute);
        //        return _selectedItemChangedOnManufacturer;
        //    }

        //}



    }
}
