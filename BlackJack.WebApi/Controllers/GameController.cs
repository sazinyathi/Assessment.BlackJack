using BlackJack.WebApi.Interface;
using BlackJack.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace BlackJack.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private IGame _game;
        public GameController(IGame game)
        {
            _game = game;
        }

        [HttpGet("StartGame")]
        [SwaggerOperation(Summary = "StartGame ", Description = "StartGame")]
        public GameCustomModel StartGame()
        {
            return _game.StartGame();
        }
    }
}
