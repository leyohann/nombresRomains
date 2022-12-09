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
        public void testInf�rieurA9(int x)
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


    }
}

        
