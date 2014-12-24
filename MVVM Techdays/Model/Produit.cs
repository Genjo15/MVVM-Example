using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Techdays.Model
{
    public class Produit:INotifyPropertyChanged
    {
        private string nom;
        public string Nom
        {
            get { return nom; }
            set
            {
                nom = value;
                if(PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Nom"));
                }
            }
        }

        private string categorie;
        public string Categorie
        {
            get { return categorie; }
            set
            {
                categorie = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Categorie"));
                }
            }
        }

        private int quantiteDispo;
        public int QuantiteDispo
        {
            get { return quantiteDispo; }
            set
            {
                quantiteDispo = value;
            }
        }

        private int quantiteCommande;
        public int QuantiteCommande
        {
            get { return quantiteCommande; }
            set
            {
                quantiteCommande = value;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
