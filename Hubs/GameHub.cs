using Microsoft.AspNetCore.SignalR;
using TicTacToeLive.Data;
using TicTacToeLive.Models;

namespace TicTacToeLive.Hubs
{
	public class GameHub : Hub
	{
		private GameState _gameContext;

		public GameHub(GameState gameContext)
		{
			_gameContext = gameContext;
		}

		public async Task UpdateGame()
		{
			Game game = _gameContext.Game;
			await Clients.All.SendAsync("UpdateGame", game);
		}
	}
}
