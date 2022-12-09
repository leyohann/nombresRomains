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
            var résultat = ConvertisseurNombreRomain.Convertir(nombrearabe);
            // ALORS on obtient 'I'
            Assert.Equal("I",résultat);
        }

        
