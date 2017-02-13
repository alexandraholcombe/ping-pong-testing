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
    [Fact]
    public void IsPingPong_ForNumberDivisibleByFive_pong()
    {
      PingPong testPingPong = new PingPong();
      Assert.Equal("pong", testPingPong.IsPingPong(20));
    }
    [Fact]
    public void IsPingPong_ForNumberDivisibleByThree_ping()
    {
      PingPong testPingPong = new PingPong();
      Assert.Equal("ping", testPingPong.IsPingPong(9));
    }
    [Fact]
    public void IsPingPong_ForNumber_number()
    {
      PingPong testPingPong = new PingPong();
      Assert.Equal("1", testPingPong.IsPingPong(1));
    }
  }
}
