using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace NUnit_Auto_2022.FrameworkArchitecture.DataModels
{
    [XmlRoot(ElementName = "Credentials")]
    public class Credentials2
    {
        [XmlElement(ElementName = "username")]
        public string Username { get; set; }

        [XmlElement(ElementName = "password")]
        public string Password { get; set; }

        [XmlElement(ElementName = "confirmPassword")]
        public string ConfirmPassword { get; set; }

        [XmlElement(ElementName = "firstName")]
        public string FirstName { get; set; }

        [XmlElement(ElementName = "lastName")]
        public string LastName { get; set; }

        [XmlElement(ElementName = "email")]
        public string Email { get; set; }

        [XmlElement(ElementName = "dob")]
        public string Dob { get; set; }

        [XmlElement(ElementName = "nationality")]
        public string Nationality { get; set; }
    }
}
