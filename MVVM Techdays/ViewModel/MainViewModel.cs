using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using MVVM_Techdays.Model;
using MVVM_Techdays.Model.Service;
using System.Windows.Input;
using MVVM_Techdays.Helpers;

namespace MVVM_Techdays.ViewModel
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            Produits = new ObservableCollection<Produit>(ProduitService.GetProduits());
            AjouterProduitCommand = new SimpleCommand(AjouterProduit);
        }

        public ObservableCollection<Produit> Produits { get; set; }

        public ICommand AjouterProduitCommand { get; set; }

        public void AjouterProduit()
        {
            AjouterProduitViewModel vm = new AjouterProduitViewModel();
            if(ModalWindowService.Show(vm) == true)
            {
                Produits.Add(vm.Produit);
            }
        }
    }
}
