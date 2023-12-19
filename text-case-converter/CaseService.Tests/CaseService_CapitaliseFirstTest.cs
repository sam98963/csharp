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
    }
}