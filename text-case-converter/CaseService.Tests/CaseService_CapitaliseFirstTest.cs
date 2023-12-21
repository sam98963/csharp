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
            string result = caseService.splitStrings("hello this is sam");
            Assert.Equal("Hello This Is Sam", result);
        }
    }
}