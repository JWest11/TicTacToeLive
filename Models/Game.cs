namespace TicTacToeLive.Models
{
	public class Game
	{
		public List<Square> Squares { get; }
		public string Id { get; }
		public bool IsXTurn { get; set; }
		public SquareValueEnum? Victory { get; set; }
		public Game()
		{
			Id = Guid.NewGuid().ToString();
			Squares = new List<Square>();
			ResetGame();
			
		}
		public void ResetGame()
		{
			Squares.Clear();
			for (int i=0; i<9; i++)
			{
				Squares.Add(new Square(i));
			}
			IsXTurn = true;
			Victory = null;
		}
		public void Move(Square square)
		{
			square.Value = IsXTurn ? SquareValueEnum.X : SquareValueEnum.O;

			if (WinCheck())
			{
				Victory = IsXTurn ? SquareValueEnum.X : SquareValueEnum.O;
			}
			else
			{
				IsXTurn = !IsXTurn;
			}
		}
		public bool WinCheck()
		{
			if (Squares[0].Value == Squares[1].Value && Squares[1].Value == Squares[2].Value && Squares[0].Value != null) { return true; }
			else if (Squares[3].Value == Squares[4].Value && Squares[4].Value == Squares[5].Value && Squares[3].Value != null) { return true; }
			else if (Squares[6].Value == Squares[7].Value && Squares[7].Value == Squares[8].Value && Squares[6].Value != null) { return true; }
			else if (Squares[0].Value == Squares[4].Value && Squares[4].Value == Squares[8].Value && Squares[0].Value != null) { return true; }
			else if (Squares[2].Value == Squares[4].Value && Squares[6].Value == Squares[4].Value && Squares[2].Value != null) { return true; }
			return false;
		}
	}
}
