namespace Ucu.Poo.TestDateFormat;

public class DateFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestRightInputFormat()
    {
        //Default system date is MM/dd/yyyy
        string testDate = "10/11/1997";
        string expected = "1997-10-11";
        string newTestDate = DateFormatter.ChangeFormat(testDate);
        Assert.That(newTestDate, Is.EqualTo(expected));
    }
    [Test]
    public void TestWrongInputFormat()
    {
        string testDate = "10-11-97";
        string newTestDate = DateFormatter.ChangeFormat(testDate);
        Assert.That(newTestDate, Is.EqualTo("Formato incorrecto"));
    }

    [Test]
    public void TestBlankInput()
    {
        string testDate = "";
        string newTestDate = DateFormatter.ChangeFormat(testDate);
        Assert.That(newTestDate, Is.EqualTo("Formato incorrecto"));
    }
}