namespace nombresRomains.test
{
    public class UnitTest1
    {
        [Fact]
        public void test1()
        {
            //ETANT DONNE le nombre 1
            const int nombrearabe = 1;
            // QUAND on le convertit en nombre romain
            var resultat = ConvertisseurNombreRomain.Convertir(nombrearabe);
            // ALORS on obtient 'I'
            Assert.Equal("I", resultat);
        }

        [Fact]
        public void test2()
        {
            //ETANT DONNE le nombre 2
            const int nombrearabe = 2;
            //QUAND on le convertit en nomnbre romain
            var resultat = ConvertisseurNombreRomain.Convertir(nombrearabe);
            //ALORS on obtient 'II'
            Assert.Equal("II", resultat);
        }
    }
}

        
