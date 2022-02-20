using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(5, 5, 2, 4.898979485566356)]
        [InlineData(1, 1, 1, 0.4330127018922193)]
        [InlineData(1, 2, 1, 0)]
        [InlineData(3, 3, 4, 4.47213595499958)]
        [InlineData(4, 3, 3, 4.47213595499958)]
        [InlineData(3, 4, 3, 4.47213595499958)]
        [InlineData(1, 8, 8, 3.992179855667828)]
        [InlineData(11, 8, 4, 12.285662375305614)]
        [InlineData(5.1, 8.1, 3.5, 5.73621990077089)]
        [InlineData(1.9879879, 1.44678, 2, 1.3441202841073705)]
        [InlineData(10.0001, 11.1, 13.1, 53.980447432320545)]
        [InlineData(11.11, 14.14, 18.18, 78.52741130019106)]
        [InlineData(200, 150, 160, 11827.906619516405)]
        [InlineData(5.123213, 1.34343, 4, 1.6626698673856968)]
        [InlineData(2.3434, 1.33, 3.3434, 1.2120716689602147)]
        [InlineData(6.1, 4.333, 4.333, 9.387060171986755)]
        [InlineData(3.11111, 3.1111111, 3.1, 4.181125748229145)]
        [InlineData(5555.5555, 4444.4444, 2222.2222, 4690951.805431168)]
        [InlineData(14.0000000001, 11.00000000004, 10.000000004, 54.64373250609807)]
        [InlineData(44, 22, 33, 351.47323866832306)]
        public void Test1(double _side1, double _side2, double _side3, double res)
        {
            double act = Class1.GetAreaT(_side1,_side2, _side3);
            Assert.Equal(res, act);
        }
    }
    //Hello world!
}