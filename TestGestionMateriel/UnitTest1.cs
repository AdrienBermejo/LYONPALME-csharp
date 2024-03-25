using CreditSio.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestGestionMateriel
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void testAdd()
        {
            string idMateriel, marque, libelle, etat;

            idMateriel = "MA031";
            marque = "adidas";
            libelle = "tuba";
            etat = "piteux etat";
            MaterielModel materiel = new MaterielModel(idMateriel, marque, libelle, etat);
        }
    }
}
