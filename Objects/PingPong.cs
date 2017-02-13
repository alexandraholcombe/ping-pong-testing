namespace PingPong
{
  public class PingPong
  {
    public string IsPingPong(int number)
    {
      if (number % 15 == 0)
      {
        return "ping-pong";
      }
      return null;
    }
  }
}
