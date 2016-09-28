using GreatFriends.Module.Home;

namespace GreatFriends.Facade
{
    public class HelloWorld : IHelloWorld
    {
        public string Say(string name)
        {
            return $"Hello {name}";
        }
    }
}
