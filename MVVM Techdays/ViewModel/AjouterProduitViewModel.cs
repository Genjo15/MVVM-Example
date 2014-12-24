using MVVM_Techdays.Helpers;
using MVVM_Techdays.Model;
using MVVM_Techdays.Model.Service;
using MVVM_Techdays.ViewModel.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MVVM_Techdays.ViewModel
{
    public class AjouterProduitViewModel
    {
        public AjouterProduitViewModel()
        {
            Produit = new Produit();
            Produit.PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler(Produit_PropertyChanged);
            ValiderCommand = new ValiderProduitCommand(ValiderProduit);
        }

        void Produit_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            /* Reevaluer le changement */
            ((ValiderProduitCommand)ValiderCommand).RaiseCanExecuteChanged();

        }

        public Produit Produit { get; set; }

        public ICommand ValiderCommand { get; set; }

        private void ValiderProduit()
        {
            ///TODO
            ProduitService.AjouterProduit(Produit);
        }


    }
}
