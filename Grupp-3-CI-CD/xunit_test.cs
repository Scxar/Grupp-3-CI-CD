using Xunit;

namespace Grupp_3_CI_CD
{
    public class xunitTest
    {
        Opersion opersion = new Opersion();

        [Fact]
        public void personmmerToIntTest()
        {
            string pers_nr = "9004263597";
            long result1 = 9004263597;

            Assert.Equal(result1,opersion.personmmerToInt(pers_nr));
        }

        [Fact]
        public void TestName()
        {
            // Given
        
            // When
        
            // Then
        }

        [Fact]
        public void TestName2()
        {
            // Given
        
            // When
        
            // Then
        }



    }
}