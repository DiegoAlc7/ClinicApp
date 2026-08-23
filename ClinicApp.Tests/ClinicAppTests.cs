namespace ClinicApp.Tests;

using ClinicApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class ClinicAppTests
{
    [TestMethod]
    public void Create_Patient_Should_Register_In_Singleton()
    {
        Patient patient = new Patient("John Doe", "john@email.com");
        int count = ClinicManager.GetInstance().AllPatients.Count;
        Assert.IsTrue(count >= 1);
    }

    [TestMethod]
    public void Create_Second_Patient_Should_Have_Exactly_One_Patient()
    {
        Patient patient2 = new Patient("Jane Doe", "jane@email.com");
        int count = ClinicManager.GetInstance().AllPatients.Count;
        Assert.AreEqual(1, count);
    }
}

