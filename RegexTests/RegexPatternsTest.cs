using Devshop;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;


namespace RegexTests
{
    [TestClass]
    public class RegexPatternsTest
    {
        [TestMethod]
        public void EconetNumberValidates()
        {
            bool econetValidates = Regex.IsMatch(MockConstants.EconetNumberValid, SimpleRegex.Econet);
            Assert.IsTrue(econetValidates);
        }

        [TestMethod]
        public void LongEconetNumberInvalidates()
        {
            bool econetInvalidatesLong = Regex.IsMatch(MockConstants.EconetNumberInvalidLong, SimpleRegex.Econet);
            Assert.IsFalse(econetInvalidatesLong);
        }
        [TestMethod]
        public void ShortEconetNumberInvalidates()
        {
            bool econetInvalidatesShort = Regex.IsMatch(MockConstants.EconetNumberInvalidShort, SimpleRegex.Econet);
            Assert.IsFalse(econetInvalidatesShort);
        }

        [TestMethod]
        public void NetoneNumberValidates()
        {
            bool netoneValidates = Regex.IsMatch(MockConstants.NetoneNumberValid, SimpleRegex.Netone);
            Assert.IsTrue(netoneValidates);
        }

        [TestMethod]
        public void ShortNetoneNumberIsInvalidates()
        {
            bool netoneValidates = Regex.IsMatch(MockConstants.NetoneNumberInvalidShort, SimpleRegex.Netone);
            Assert.IsFalse(netoneValidates);
        }
        [TestMethod]
        public void LongNetoneNumberIsInvalidates()
        {
            bool netoneValidates = Regex.IsMatch(MockConstants.NetoneNumberInvalidLong, SimpleRegex.Netone);
            Assert.IsFalse(netoneValidates);
        }
        [TestMethod]
        public void TelecelNumberValidates()
        {
            bool telecelValidates = Regex.IsMatch(MockConstants.TelecelNumberValid, SimpleRegex.Telecel);
            Assert.IsTrue(telecelValidates);
        }

        [TestMethod]
        public void LongTelecelNumberInvalidates()
        {
            bool telecelValidates = Regex.IsMatch(MockConstants.TelecelNumberInvalidLong, SimpleRegex.Telecel);
            Assert.IsFalse(telecelValidates);
        }

        [TestMethod]
        public void DriversLicenceValidates()
        {
            bool licenceValidates = Regex.IsMatch(MockConstants.DriversLicenseValid, SimpleRegex.DriversLicence);
            Assert.IsTrue(licenceValidates);
        }

        [TestMethod]
        public void InvalidDriversLicenceIsInvalid()
        {
            bool licenceValidates = Regex.IsMatch(MockConstants.DriversLicenseInvalid1, SimpleRegex.DriversLicence) 
                && Regex.IsMatch(MockConstants.DriversLicenseInvalid1, SimpleRegex.DriversLicence);
            Assert.IsFalse(licenceValidates);
        }

        [TestMethod]
        public void ShortDriversLicenceIsInvalid()
        {
            bool licenceValidates = Regex.IsMatch(MockConstants.DriversLicenseInvalidShort, SimpleRegex.DriversLicence);
            Assert.IsFalse(licenceValidates);
        }

        [TestMethod]
        public void SSNValidates()
        {
            bool ssnValidates = Regex.IsMatch(MockConstants.SSNValid, SimpleRegex.SocialSecurityNumber);
            Assert.IsTrue(ssnValidates);
        }

        [TestMethod]
        public void ShortSSNInvalidates()
        {
            bool ssnValidates = Regex.IsMatch(MockConstants.SSNInvalidShort, SimpleRegex.SocialSecurityNumber) ;
            Assert.IsFalse(ssnValidates);
        }

        [TestMethod]
        public void LongSSNInvalidates()
        {
            bool ssnValidates = Regex.IsMatch(MockConstants.SSNInvalidLong, SimpleRegex.SocialSecurityNumber);
            Assert.IsFalse(ssnValidates);
        }

        [TestMethod]
        public void InvalidSSNInvalidates()
        {
            bool ssnValidates = Regex.IsMatch(MockConstants.SSNInvalid, SimpleRegex.SocialSecurityNumber);
            Assert.IsFalse(ssnValidates);
        }
    }
}
