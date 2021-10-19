using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        
/*        [SetUp]
        public void Setup()
        {
            // Insertá tu código de inicialización aquí
        }
*/
        [Test]
        public void TestName() // Cambiá el nombre para indicar qué estás probando
        {
            Person nacho = new Person("Nacho", "4.928.322-7", "19-04-1991");
            string expected = "Nacho";
            Assert.AreEqual(expected, nacho.Name);
            // Insertá tu código  de pruebaaquí
        }

        [Test]
        public void TestID() // Cambiá el nombre para indicar qué estás probando
        {
            Person nacho = new Person("Nacho", "4.928.322-7", "19-04-1991");
            string expected = "4.928.322-7";
            Assert.AreEqual(expected, nacho.ID);
            // Insertá tu código  de pruebaaquí
        }
        [Test]
        public void TestDate() // Cambiá el nombre para indicar qué estás probando
        {
            Person nacho = new Person("Nacho", "4.928.322-7", "19-04-1991");
            string expected = "19-04-1991";
            Assert.AreEqual(expected, nacho.Birthday);
            // Insertá tu código  de pruebaaquí
        }


    }
}