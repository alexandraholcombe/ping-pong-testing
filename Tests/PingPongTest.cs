using Xunit;
namespace PingPong
{
  public class PingPongTest
  {
    [Fact]
    public void IsPingPong_ForNumberDivisibleByFifteen_true()
    {
      PingPong testPingPong = new PingPong();
      Assert.Equal(true, testPingPong.IsPingPong(30));
    }
  }
}
