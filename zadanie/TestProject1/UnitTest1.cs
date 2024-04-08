using LegacyApp;

namespace TestProject1;

public class UnitTest1
{
    [Fact]
    public void EmailContainsAtAndDot()
    {
        var us = new UserService();
        
        string firstName = "fn";
        string lastName = "ln";
        DateTime birthDate = new DateTime(1990, 10, 10);
        int clientId = 1;
        string email = "xyz";
        //string email = "xyz@xd.net";

        bool b = us.AddUser(firstName, lastName, email, birthDate, clientId);
        Assert.Equal(false, b);
    }

    [Fact]
    public void NameIsNotNull()
    {
        var us = new UserService();
        
        string firstName = "fn";
        string lastName = "ln";
        DateTime birthDate = new DateTime(1990, 10, 10);
        int clientId = 1;
        string email = "xyz@xyz.com";
        
        bool fn = us.AddUser(null, lastName, email, birthDate, clientId);
        bool ln = us.AddUser(firstName, null, email, birthDate, clientId);
        bool fln = us.AddUser(null, null, email, birthDate, clientId);
        
        Assert.Equal(false, fn);
        Assert.Equal(false, ln);
        Assert.Equal(false, fln);
    }
}