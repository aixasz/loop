using Microsoft.AspNetCore.Mvc;

namespace GreatFriends.Module.Home
{
    [Route("/")]
    public class RootController : Controller
    {
        private readonly IHelloWorld HelloWorld;

        public RootController(IHelloWorld helloWorld)
        {
            HelloWorld = helloWorld;
        }

        [HttpGet()]
        public IActionResult Home()
        {
            return new ObjectResult(HelloWorld.Say("Loop !"));
        }
    }
}
