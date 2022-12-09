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

        [Theory]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        public void testInférieurA9(int x)
        {
            //ETANT DONNE un nombre 4<x<9
            //QUAND on le convertit en nombre romain
            var resultat = ConvertisseurNombreRomain.Convertir(x);
            //ON obtient V+(x-5)*I
            var attendu = new string('I', x - 5);
            Assert.Equal($"V{attendu}",resultat);

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
        public void Test9()
        {
            // ETANT DONNE LE NOMBRE 9
            const int nombrearabe = 9;

            // QUAND ON CONVERTIT EN NOMBRE ROMAIN
            var resultat = ConvertisseurNombreRomain.Convertir(nombrearabe);
            // ALORS ON OBTIENT IX
            Assert.Equal("IX", resultat);
        }
        [Fact]
        public void Test10()
        {
            // ETANT DONNE LE NOMBRE 10
            const int nombrearabe = 10;

            // QUAND ON CONVERTIT EN NOMBRE ROMAIN
            var resultat = ConvertisseurNombreRomain.Convertir(nombrearabe);
            // ALORS ON OBTIENT X
            Assert.Equal("X", resultat);
        }
        [Fact]
        public void Test11()
        {
            // ETANT DONNE LE NOMBRE 11
            const int nombrearabe = 11;

            // QUAND ON CONVERTIT EN NOMBRE ROMAIN
            var resultat = ConvertisseurNombreRomain.Convertir(nombrearabe);
            // ALORS ON OBTIENT XI
            Assert.Equal("XI", resultat);
        }
        [Fact]
        public void Test12()
        {
            // ETANT DONNE LE NOMBRE 12
            const int nombrearabe = 12;

            // QUAND ON CONVERTIT EN NOMBRE ROMAIN
            var resultat = ConvertisseurNombreRomain.Convertir(nombrearabe);
            // ALORS ON OBTIENT XII
            Assert.Equal("XII", resultat);
        }

    }
}

        
