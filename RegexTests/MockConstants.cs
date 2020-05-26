using System;
using System.Collections.Generic;
using System.Text;

namespace RegexTests
{
    public static class MockConstants
    {
        public static readonly string EconetNumberValid = "0770000000";
        public static readonly string DriversLicenseInvalid1 = "00000AAA";
        public static readonly string DriversLicenseInvalid2 = "000000AA"; 
        public static readonly string SSNInvalid = "A0000000";
        public static readonly string EconetNumberInvalidLong = "07700000000";
        public static readonly string NetoneNumberInvalidLong = "07100000000";
        public static readonly string SSNInvalidLong = "00000000A";
        public static readonly string TelecelNumberInvalidLong = "07300000000";
        public static readonly string DriversLicenseValid = "00000AA";
        public static readonly string IDNumberValid = "00-000000A00";
        public static readonly string NumberPlateValid = "AAA-000";
        public static readonly string AmbassadorNumberPlateValid = "12 CD";
        public static readonly string AmbassadorNumberPlateInvalid = "1234 CD";
        public static readonly string DiplomatNumberPlateValid = "12 CD 345";
        public static readonly string DiplomatNumberPlateInvalid = "2 CD 3";
        public static readonly string AdminDiplomatNumberPlateValid = "12 AD 345";
        public static readonly string TechnicalDiplomatNumperPlateValid = "12 TCE 345";
        public static readonly string TecnhicalDiplomatNumberPlateInvalid = "12 TCE";
        public static readonly string PassportNumberValid = "AA000000";
        public static readonly string SSNValid = "0000000A";
        public static readonly string NetoneNumberValid = "0710000000";
        public static readonly string DriversLicenseInvalidShort = "000000A";
        public static readonly string EconetNumberInvalidShort = "077000000";
        public static readonly string NetoneNumberInvalidShort = "071000000";
        public static readonly string SSNInvalidShort = "00000A";
        public static readonly string TelecelNumberInvalidShort = "073000000";
        public static readonly string TelecelNumberValid = "0730000000";
    }
}

