using Ahorcado.App;
using NUnit.Framework;

namespace Ahorcado.Test
{
    [TestFixture]
    public class TestGame
    {
        Game game = new Game();

        [SetUp]
        public void init()
        {
            game = new Game();
        }

        [TestCase("palabratest", ExpectedResult = true)]
        [TestCase("palabratestt", ExpectedResult = false)]
        public bool TestArriesgaPalabra(string palabra)
        {
            game.PalabraAdivinar = "palabratest";
            return game.arriegaPalabra(palabra);
        }
        
        [Test]
        public void TestInitPalabraMostrada()
        {
            game.PalabraAdivinar = "palabratest";
            game.initPalabraMostrada();
            StringAssert.AreEqualIgnoringCase("***********", game.PalabraMostrada);
        }

        [TestCase('p', ExpectedResult = true)]
        [TestCase('o', ExpectedResult = true)]
        [TestCase('z', ExpectedResult = false)]
        [TestCase('w', ExpectedResult = false)]
        public bool TestContieneLetra(char letra)
        {
            game.PalabraAdivinar = "probando";
            return game.contieneLetra(letra);
        }

        [Test]
        public void TestSetPalabraAdivinar()
        {
            game.setPalabraAdivinar("palabraAdivinar");
            StringAssert.AreEqualIgnoringCase("palabraAdivinar", game.PalabraAdivinar);
        }

        [Test]
        public void TestActualizaPalabraMostrada()
        {
            game.PalabraAdivinar = "probandooo";
            game.initPalabraMostrada();
            game.actualizaPalabraMostrada('o');
            StringAssert.AreEqualIgnoringCase("**o****ooo", game.PalabraMostrada);
        }

    }
}
