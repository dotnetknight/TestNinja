using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class HtmlFormatterTest
    {
        public void FormatAsBold_WhenCalled_ShouldEncloseTheStringWithStrongElement()
        {
            var formatter = new HtmlFormatter();

            var result = formatter.FormatAsBold("ABC");

            //specific assertion
            Assert.That(result, Is.EqualTo("<string>ABC</strong>"));

            ////general assertion
            //Assert.That(result, Does.StartWith("<strong>"));
            //Assert.That(result, Does.EndWith("</strong>"));
            //Assert.That(result, Does.Contain("ABC"));
        }
    }
}
