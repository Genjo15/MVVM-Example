using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MVVM_Techdays.Model.Service
{
    public static class ProduitService
    {
        public static IEnumerable<Produit> GetProduits()
        {
            XDocument dataDoc = XDocument.Load(@"C:\Users\Anthony\Documents\Visual Studio 2013\Projects\_MVVM\MVVM Techdays\Data.xml");
            return from produit in dataDoc.Descendants("Produit")
                   select new Produit
                   {
                       Nom = produit.Attribute("Nom").Value,
                       Categorie = produit.Attribute("Categorie").Value,
                       QuantiteDispo = int.Parse(produit.Attribute("QuantiteDispo").Value),
                       QuantiteCommande = int.Parse(produit.Attribute("QuantiteCommande").Value)
                   };
        }

        public static void AjouterProduit(Produit produit)
        {
            if(produit.QuantiteCommande == 0)
            {
                throw new QuantiteCommandeException();
            }

            if(produit.QuantiteCommande>produit.QuantiteDispo)
            {
                throw new QuantiteDispoException();
            }

            XDocument dataDoc = XDocument.Load(@"C:\Users\Anthony\Documents\Visual Studio 2013\Projects\_MVVM\MVVM Techdays\Data.xml");
            dataDoc.Element("Produits")
                .Add(new XElement("Produit",
                    new XAttribute("Nom", produit.Nom),
                    new XAttribute("Categorie", produit.Categorie),
                    new XAttribute("QuantiteDispo", produit.QuantiteDispo),
                    new XAttribute("QuantiteCommande", produit.QuantiteCommande)));
            dataDoc.Save(@"C:\Users\Anthony\Documents\Visual Studio 2013\Projects\_MVVM\MVVM Techdays\Data.xml");
        }
    }
}