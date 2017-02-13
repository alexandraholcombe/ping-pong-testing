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
      else if (number % 5 == 0)
      {
        return "pong";
      }
      else if (number % 3 == 0)
      {
        return "ping";
      }
      return null;
    }
  }
}
