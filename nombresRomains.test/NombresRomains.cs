namespace nombresRomains.test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void testInferieurA3(int x)
        {
            //ETANT DONNE un nombre x<=3
            //Quand on le convertit en nombre romain
            var resultat = ConvertisseurNombreRomain.Convertir(x);
            //On obtient x fois "I"
            var attendu = new string('I', x);
            Assert.Equal(attendu, resultat);
        }

        [Fact]
        public void Test4()
        {
            // ETANT DONNE LE NOMBRE 4
            const int nombrearabe = 4;

            // QUAND ON CONVERTIT EN NOMBRE ROMAIN
            var resultat = ConvertisseurNombreRomain.Convertir(nombrearabe);
            // ALORS ON OBTIENT IV
            Assert.Equal("IV", resultat);
        }
        [Fact]
        public void Test5()
        {
            // ETANT DONNE LE NOMBRE 5
            const int nombrearabe = 5;

            // QUAND ON CONVERTIT EN NOMBRE ROMAIN
            var resultat = ConvertisseurNombreRomain.Convertir(nombrearabe);
            // ALORS ON OBTIENT V
            Assert.Equal("V", resultat);
        }
        [Fact]
        public void Test6()
        {
            // ETANT DONNE LE NOMBRE 6
            const int nombrearabe = 6;

            // QUAND ON CONVERTIT EN NOMBRE ROMAIN
            var resultat = ConvertisseurNombreRomain.Convertir(nombrearabe);
            // ALORS ON OBTIENT VI
            Assert.Equal("VI", resultat);
        }
        [Fact]
        public void Test7()
        {
            // ETANT DONNE LE NOMBRE 7
            const int nombrearabe = 7;

            // QUAND ON CONVERTIT EN NOMBRE ROMAIN
            var resultat = ConvertisseurNombreRomain.Convertir(nombrearabe);
            // ALORS ON OBTIENT VII
            Assert.Equal("VII", resultat);
        }
    }
}

        
