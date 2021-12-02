using NUnit.Framework;
using Exercice_2;
using System;

namespace Exercice_2_Test
{
    public class Tests
    {
        Compte client1;
        Compte client2;

        [SetUp]
        public void Setup()
        {
            int soldeDepart1 = 14;
            int soldeDepart2 = 0;
            Compte client1 = new Compte(new Client(150224, "Durant", "Toto"), soldeDepart1); 
            Compte client2 = new Compte(new Client(150225, "Dupond", "Tata"), soldeDepart2);
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

        [Test]
        public void Credit_MontantValide()
        {

            int montantCrediter = 2;
            int attendu = 16;


            client1.Crediter(montantCrediter);

            int soldeActuel = client1.Solde;
            Assert.AreEqual(attendu, soldeActuel, 0.001, "Compte mal Credité");
        }

        [Test]
        public void Credit_MontantNegatif()
        {
            int montantCrediter = -2;

            Assert.Throws<ArgumentOutOfRangeException>(() => client1.Crediter(montantCrediter));
        }

        [Test]
        public void Credit_MontantSuperieurSolde()
        {
            int montantCrediter = -20;

            Assert.Throws<ArgumentOutOfRangeException>(() => client1.Crediter(montantCrediter));
        }


        [Test]
        public void Debiter_MontantValide()
        {

            int montantDebite = 2;
            int attendu1 = 12;
            int attendu2 = 2;


            client1.Debiter(montantDebite, client2);

            int soldeActuel1 = client1.Solde;
            int soldeActuel2 = client1.Solde;
            Assert.AreEqual(attendu1, soldeActuel1, 0.001, "Compte mal débité");
            Assert.AreEqual(attendu2, soldeActuel2, 0.001, "Compte mal crédité");
        }

        [Test]
        public void Debiter_MontantNegatif()
        {
            int montantDebite = -2;

            Assert.Throws<ArgumentOutOfRangeException>(() => client1.Debiter(montantDebite, client2));
        }

        [Test]
        public void Debiter_MontantSuperieurSolde()
        {
            int montantDebite = -20;

            Assert.Throws<ArgumentOutOfRangeException>(() => client1.Debiter(montantDebite, client2));
        }

        [Test]
        public void Crediter_MontantValide()
        {

            int montantCrediter = 2;
            int attendu1 = 16;
            int attendu2 = -2;


            client1.Crediter(montantCrediter, client2);

            int soldeActuel1 = client1.Solde;
            int soldeActuel2 = client1.Solde;
            Assert.AreEqual(attendu1, soldeActuel1, 0.001, "Compte mal Credité");
            Assert.AreEqual(attendu2, soldeActuel2, 0.001, "Compte mal Débité");
        }

        [Test]
        public void Crediter_MontantNegatif()
        {
            int montantCrediter = -2;

            Assert.Throws<ArgumentOutOfRangeException>(() => client1.Crediter(montantCrediter, client2));
        }

        [Test]
        public void Crediter_MontantSuperieurSolde()
        {
            int montantCrediter = -20;

            Assert.Throws<ArgumentOutOfRangeException>(() => client1.Crediter(montantCrediter, client2));
        }
    }
}