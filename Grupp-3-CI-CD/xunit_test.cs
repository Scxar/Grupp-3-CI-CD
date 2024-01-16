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
        public void checkPersonNummer()
        {
            // mikael
            // Given
        
            // When
        
            // Then
        }

        

        [Fact]
        public void Gender()
        {
            // oscar
            string pers_nr = "9606234221";
            string result = opersion.Gender(pers_nr);

            // funktion funkar korekt
            Assert.True(result.Equals("Man") || result.Equals("Kvinna"));

            //Assert.Equal("Man", result);
            Assert.Equal("Kvinna", result);

        }
    }
}