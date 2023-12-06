namespace StarBuddy.Models
{
	public class Group
	{
		public int GroupId { get; set; }
		public required string Name { get; set; }
		public required string Description { get; set; }

		public string Image { get; set; }

		public GroupTypeEnum Type { get; set; }
		public List<User> Administrators { get; set; } = new List<User>();
	}
}
