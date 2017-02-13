using Xunit;
namespace PingPong
{
  public class PingPongTest
  {
    [Fact]
    public void IsPingPong_ForNumberDivisibleByFifteen_ping_pong()
    {
      PingPong testPingPong = new PingPong();
      Assert.Equal("ping-pong", testPingPong.IsPingPong(30));
    }
  }
}
