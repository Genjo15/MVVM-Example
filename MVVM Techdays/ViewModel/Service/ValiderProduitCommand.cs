using MVVM_Techdays.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Techdays.ViewModel.Service
{
    public class ValiderProduitCommand : SimpleCommand // ok
    {
        public ValiderProduitCommand(Action action) : base(action)
        {

        }

        public override bool CanExecute(object parameter)
        {
            AjouterProduitViewModel produitVm = parameter as AjouterProduitViewModel;

            if(produitVm != null)
            {
                return !string.IsNullOrWhiteSpace(produitVm.Produit.Nom) &&
                       !string.IsNullOrWhiteSpace(produitVm.Produit.Categorie);
            }

            return false;
        }


    }
}
