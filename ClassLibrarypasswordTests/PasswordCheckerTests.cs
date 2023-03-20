using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrarypassword;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarypassword.Tests
{
    [TestClass()]
    public class PasswordCheckerTests
    {
        [TestMethod()]
        public void Check_85ymbols_ReturnsTrue()
        {
            // Arrange.
            string password = "ASqw12$$";
            bool expected = true;

            // Act.
            bool actual = PasswordChecker.ValidatePassword(password);

            // Assert.
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Check_45ymbols_ReturnsFalse()
        {
            // Arrange.
            string password = "ASDQWE123$";
            bool expected = false;

            // Act.
            bool actual = PasswordChecker.ValidatePassword(password);

            // Assert.
            Assert.AreEqual(expected, actual);
        }
    }
}
    