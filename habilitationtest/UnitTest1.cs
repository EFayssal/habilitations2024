using System;
using habilitations2024.dal;
using habilitations2024.controller;
using habilitations2024.model;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace habilitationtest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetLesDeveloppeurs_ProfilAdmin_Retourne2Developpeurs()
        {
            // Arrange
            var controller = new FrmHabilitationsController();
            int idProfil = 3; //  l’ID du profil à tester
            int nombreAttendu = 4; // le nombre attendu

            // Act
            List<Developpeur> developpeurs = controller.GetLesDeveloppeurs(idProfil);

            // Assert
            Assert.AreEqual(nombreAttendu, developpeurs.Count);

        }
    
    [TestMethod]
        public void GetLesDeveloppeurs_AucunProfil_RetourneTousLesDeveloppeurs()
        {
            // Arrange
            var controller = new FrmHabilitationsController();
            int idProfil = 0; // Convention pour "aucun profil sélectionné"
            int nombreAttendu = 20; // le nombre total de développeurs dans ta base de test

            // Act
            List<Developpeur> developpeurs = controller.GetLesDeveloppeurs(idProfil);

            // Assert
            Assert.AreEqual(nombreAttendu, developpeurs.Count);
        }
    }
}