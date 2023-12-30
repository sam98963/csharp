using Xunit;
using Case.Services;

namespace Case.UnitTests.Services
{
    public class CaseService_CapitaliseFirstTest{
        [Fact]
        public void CapitaliseFirst_First_Char_Is_Upper(){
            var caseService = new CaseService();
            string result = caseService.capitaliseFirst("hello");
            Assert.Equal("Hello", result);
        }
        [Fact]
        public void CapitaliseFirst_Multiple_Strings_Char_Upper(){
            var caseService = new CaseService();
            string[] result = caseService.splitStrings("hello this is sam");
            Assert.Equal(["Hello", "This", "Is", "Sam"], result);
        }
        [Fact]
        public void TrainCase_Connect_Words_With_Dash(){
            var caseService = new CaseService();
            string result = caseService.connectStrings(["Hello", "This", "Is", "Sam"], "-");
            Assert.Equal("Hello-This-Is-Sam", result);
        }

        [Fact]
        public void TrainCase_Full_Conversion(){
            var caseService = new CaseService();
            string result = caseService.trainCase("Hello this is sam.");
            Assert.Equal("Hello-This-Is-Sam.", result);
        }
    }
}