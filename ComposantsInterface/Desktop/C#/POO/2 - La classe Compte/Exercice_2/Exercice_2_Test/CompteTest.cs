using NUnit.Framework;
using Exercice_2;
using System;

namespace Exercice_2_Test
{
    public class Tests
    {
        Compte client1;

        [SetUp]
        public void Setup()
        {
            int soldeDepart = 14;
            Compte client1 = new Compte(new Client(150224, "Durant", "Toto"), soldeDepart);
        }

        [Test]
        public void Debit_MontantValide()
        {
            
            int montantDebite = 2;
            int attendu = 12;
           

            client1.Debiter(montantDebite);

            int soldeActuel = client1.Solde;
            Assert.AreEqual(attendu, soldeActuel, 0.001, "Compte mal débité");
        }

        [Test]
        public void Debit_MontantNegatif()
        {
            int montantDebite = -2;

            Assert.Throws<ArgumentOutOfRangeException>(() => client1.Debiter(montantDebite));
        }

        [Test]
        public void Debit_MontantSuperieurSolde()
        {
            int montantDebite = -20;

            Assert.Throws<ArgumentOutOfRangeException>(() => client1.Debiter(montantDebite)); 
        }

    }
}