namespace TicTacToeLive.Models
{
	public class Square
	{
		public int Id { get; }
		public SquareValueEnum? Value { get; set; }
		public Square(int id)
		{
			Id = id;
		} 
	}
}
