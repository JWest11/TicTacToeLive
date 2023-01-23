using TicTacToeLive.Models;

namespace TicTacToeLive.Data
{
	public class GameState
	{
		public Game Game { get; }

		public GameState()
		{
			Game = new Game();
		}
	}
}
