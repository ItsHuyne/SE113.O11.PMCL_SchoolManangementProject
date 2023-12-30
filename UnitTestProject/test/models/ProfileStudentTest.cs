using Đồ_án.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject.test.models
{
    [TestClass]
    public class ProfileStudentTest
    {
        [TestMethod]
        public void ProfileStudentTest_ctor()
        {
            var profileStudent = new ProfileStudent(
                21522645,
                "C",
                "Male",
                "18/04/2003",
                "HCM",
                12345678,
                "HCM",
                0908114708,
                "Kinh",
                "A",
                "Teacher",
                "04/04/1963",
                "VietNam",
                123456789,
                "XXXXXXXXXX",
                090811111,
                "Kinh",
                "B",
                "Teacher",
                "26/10/1966",
                "VietNam",
                12345,
                "XXXXXXXXXX",
                09082222,
                "Kinh",
                "NK-Prison",
                123321,
                "Excellent",
                "CNPM",
                "Software Technology",
                "Software Engineering"
                );

            profileStudent.IdStudent = 31;
            profileStudent.NameStudent = "1231241";
            profileStudent.Gender = "1231241";
            profileStudent.DateOfBirth = "1231241";
            profileStudent.BirthPlace = "1231241";
            profileStudent.CCCD = 31241;
            profileStudent.PlaceCCCD = "1231241";
            profileStudent.PhoneNumber = 31241;
            profileStudent.Ethnic = "1231241";
            profileStudent.FName = "1231241";
            profileStudent.FOccupation = "1231241";
            profileStudent.FDateOfBirth = "1231241";
            profileStudent.FCountry = "1231241";
            profileStudent.FCCCD = 231;
            profileStudent.FAddress = "1231241";
            profileStudent.FPhoneNumber = 23124;
            profileStudent.FEthnic = "1231241";
            profileStudent.MName = "1231241";
            profileStudent.MOccupation = "1231241";
            profileStudent.MDateOfBirth = "1231241";
            profileStudent.MCountry = "1231241";
            profileStudent.MCCCD = 2312;
            profileStudent.MAddress = "1231241";
            profileStudent.MPhoneNumber = 2312;
            profileStudent.MEthnic = "1231241";
            profileStudent.SecondarySchool = "1231241";
            profileStudent.HealthInsuranceID = 23124;
            profileStudent.AcademicAchievement = "1231241";
            profileStudent.FacultyCode = "1231241";
            profileStudent.FacultyName = "1231241";
            profileStudent.Majors = "1231241";

            Assert.IsNotNull(profileStudent.IdStudent);
            Assert.IsNotNull(profileStudent.NameStudent);
            Assert.IsNotNull(profileStudent.Gender);
            Assert.IsNotNull(profileStudent.DateOfBirth);
            Assert.IsNotNull(profileStudent.BirthPlace);
            Assert.IsNotNull(profileStudent.CCCD);
            Assert.IsNotNull(profileStudent.PlaceCCCD);
            Assert.IsNotNull(profileStudent.PhoneNumber);
            Assert.IsNotNull(profileStudent.Ethnic);
            Assert.IsNotNull(profileStudent.FName);
            Assert.IsNotNull(profileStudent.FOccupation);
            Assert.IsNotNull(profileStudent.FDateOfBirth);
            Assert.IsNotNull(profileStudent.FCountry);
            Assert.IsNotNull(profileStudent.FCCCD);
            Assert.IsNotNull(profileStudent.FAddress);
            Assert.IsNotNull(profileStudent.FPhoneNumber);
            Assert.IsNotNull(profileStudent.FEthnic);
            Assert.IsNotNull(profileStudent.MName);
            Assert.IsNotNull(profileStudent.MOccupation);
            Assert.IsNotNull(profileStudent.MDateOfBirth);
            Assert.IsNotNull(profileStudent.MCountry);
            Assert.IsNotNull(profileStudent.MCCCD);
            Assert.IsNotNull(profileStudent.MAddress);
            Assert.IsNotNull(profileStudent.MPhoneNumber);
            Assert.IsNotNull(profileStudent.MEthnic);
            Assert.IsNotNull(profileStudent.SecondarySchool);
            Assert.IsNotNull(profileStudent.HealthInsuranceID);
            Assert.IsNotNull(profileStudent.AcademicAchievement);
            Assert.IsNotNull(profileStudent.FacultyCode);
            Assert.IsNotNull(profileStudent.FacultyName);
            Assert.IsNotNull(profileStudent.Majors);
        }
    }
}
