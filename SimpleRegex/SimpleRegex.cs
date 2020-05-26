using System;

namespace Devshop
{
    public class SimpleRegex
    {
        public static readonly string Econet = @"\b([\+]263)|07(7|8)\d{7}\b";
        public static readonly string Netone = @"\b([\+]263)|071\d{7}\b";
        public static readonly string Telecel = @"\b([\+]263)|073\d{7}\b";
        public static readonly string NumberPlate = @"\b[A-Za-z]{3}(\-|\s)\d{4}\b";
        public static readonly string DiplomaticNumberPlate = @"\b\d{2,3}(\-|\s)(?i)(CD\b|(CD|TCE|AD)(\-|\s)(\d{2,3})\b)";
        public static readonly string NationalID = @"\d{2}(\-|\s)\d{6,7}\s\d{2}\b";
        public static readonly string PassportNumber = @"\b[A-Za-z]{2}\d{6}\b";
        public static readonly string DriversLicence = @"\b\d{5}[a-zA-Z]{2}\b";
        public static readonly string SocialSecurityNumber = @"\b\d{7}[a-zA-z]{1}\b";

    }
}