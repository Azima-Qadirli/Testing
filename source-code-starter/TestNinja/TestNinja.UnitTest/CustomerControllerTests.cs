using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using TestNinja.Fundamentals;
using Assert = NUnit.Framework.Assert;

namespace TestNinja.UnitTest
{
    [TestFixture]
    public class CustomerControllerTests
    {
        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {
            var controller = new CustomerController();
            var result = controller.GetCustomer(0);
            Assert.That(result, Is.TypeOf<NotFound>());
            //Assert.That(result,Is.InstanceOf<NotFound>());
            //Here we can write each of them, but of course there is difference between them. TypeOf is used to check that result is not 
            //found exactly itself. But InstanceOf is used to check, if one of the derivatives of the result is not found.
        }

        [Test]
        public void GetCustomer_IdIsNotZero_ReturnOk()
        {
            var controller = new CustomerController();
            var result = controller.GetCustomer(1);
            Assert.That(result, Is.TypeOf<Ok>());
        }
    }
}