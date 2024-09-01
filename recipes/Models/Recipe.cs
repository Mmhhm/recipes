namespace recipes.Models
{
	public class Recipe
	{
		public int id { get; set; }
		public string name { get; set; } = string.Empty;
		public List<string> Ingredients { get; set; } = new List<string>();
		public List<string> Phases { get; set; } = new List<string>();
	}
}
