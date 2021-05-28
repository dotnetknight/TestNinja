using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class CustomerControllerTests
    {
        private CustomerController controller;

        [SetUp]
        public void Setup()
        {
            controller = new CustomerController();
        }

        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {
            var result = controller.GetCustomer(0);

            //Exactly a not found Object
            Assert.That(result, Is.TypeOf<NotFound>());

            ////NotFoundObject or one of it's derivates
            //Assert.That(result, Is.InstanceOf<NotFound>()); 
        }

        [Test]
        public void GetCustomer_IdIsNotZero_ReturnOk()
        {
            var result = controller.GetCustomer(1);

            Assert.That(result, Is.TypeOf<Ok>());
        }
    }
}
