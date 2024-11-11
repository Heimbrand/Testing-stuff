using System.Linq;
using testarskit.Övningar;

namespace UnitFörTestarSkit.TestClasses
{
    public class TddForStringConcatAndUserValidation
    {
        [Fact]
        public static void JoinStrings_WithValidInput_ConcateNatedString()
        {

            // arrange
            string[] strings = new string[] { "hej", "på", "dig" };
            string seperator = "-";


            // act
            string result = JoinStrings.JoinStringss(strings, seperator);
            // assert
            Assert.Equal("hej-på-dig", result);
        }
        [Fact]
        public static void ValidateUser_WithValidInput_ReturnsTrue()
        {
            // arrange
            string trueHotmail = "Olle.Heimbrand@hotmail.se";
            string truePassword = "admin";

            string falseHotmail = "Olle.Heimbrand@hotmailse";
            string falsePassword = "baj";

            // act
            bool result = UserValidation_.ValidateUser(trueHotmail, truePassword);

            // assert
            Assert.True(result);
        }
        [Fact]
        public static void ValidateUser_WithValidMailFormat_ReturnsTrue()
        {
            // arrange
            string trueHotmail = "Olle.Heimbrand@hotmail.se";
            string truePassword = "admin";

            string falseHotmail = "Olle.Heimbrand@hotmailse";
            string falsePassword = "baj";

            // act

            bool result = UserValidation_.ValidateHotmailFormat(trueHotmail);

            // assert
            Assert.True(result);

        }
        [Fact]
        public static void ValidateUser_WithValidPassword_ReturnsTrue()
        {
            // arrange
            string trueHotmail = "Olle.Heimbrand@hotmail.se";
            string truePassword = "admin";

            string falseHotmail = "Olle.Heimbrand@hotmailse";
            string falsePassword = "baj";

            // act

            bool result = UserValidation_.ValidatePasswordLength(truePassword);

            // assert
            Assert.True(result);
        }
    }
}