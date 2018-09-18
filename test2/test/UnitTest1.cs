using System;
using Xunit;
using cons;

namespace test
{
    public class UnitTest1
    {
       [Fact(DisplayName = "add()")]
        public void Test1()
        {
            var x = new mick();
            var y = x.add(5, 2);
            Assert.Equal(7, y);

        }
        [Theory(DisplayName ="minus()")]
       [InlineData(3,2,1)]
       [InlineData(1,1,0)]
       [InlineData(9,2,7)]
       public void Test2(int p1,int p2, int expected){
           var x = new mick();
           var y = x.minus(p1,p2);
           Assert.Equal(expected, y);

       }
        
    }
}
