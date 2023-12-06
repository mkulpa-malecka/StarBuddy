namespace StarBuddy.Models
{
	public class GroupRepository
	{
		public static List<Group> _groups =
		[
			new Group() { GroupId = 1, Name="Engineering 101", Type=GroupTypeEnum.Study, Description= "Learn about all the Engineering!! Prepared is me marianne pleasure likewise debating. Wonder an unable except better stairs do ye admire. His and eat secure sex called esteem praise. So moreover as speedily differed branched ignorant. Tall are her knew poor now does then. Procured to contempt oh he raptures amounted occasion. One boy assure income spirit lovers set.", Image= "https://cdn.pixabay.com/photo/2017/03/23/09/34/artificial-intelligence-2167835_640.jpg" },
			new Group() { GroupId = 2, Name="Software Development", Type = GroupTypeEnum.Study, Description = "SOLID programming Prepared is me marianne pleasure likewise debating. Wonder an unable except better stairs do ye admire. His and eat secure sex called esteem praise. So moreover as speedily differed branched ignorant. Tall are her knew poor now does then. Procured to contempt oh he raptures amounted occasion. One boy assure income spirit lovers set.", Image = "https://cdn.pixabay.com/photo/2016/11/08/05/10/students-1807505_1280.jpg" },
			new Group() { GroupId = 3, Name="Model Plane Buiders", Type = GroupTypeEnum.Social, Description = "Build planes and stuff. Prepared is me marianne pleasure likewise debating. Wonder an unable except better stairs do ye admire. His and eat secure sex called esteem praise. So moreover as speedily differed branched ignorant. Tall are her knew poor now does then. Procured to contempt oh he raptures amounted occasion. One boy assure income spirit lovers set.", Image= "https://cdn.pixabay.com/photo/2017/03/27/13/03/airbus-2178588_640.jpg" },
			new Group() { GroupId = 4, Name="Accountants Party", Type = GroupTypeEnum.Event, Description = "Get on down with money counters. Prepared is me marianne pleasure likewise debating. Wonder an unable except better stairs do ye admire. His and eat secure sex called esteem praise. So moreover as speedily differed branched ignorant. Tall are her knew poor now does then. Procured to contempt oh he raptures amounted occasion. One boy assure income spirit lovers set.", Image= "https://cdn.pixabay.com/photo/2017/12/01/17/44/christmas-2991369_640.jpg" },
		];

		public static List<Group> GetGroups() => _groups;

		public static Group GetGroupById(int groupId)
		{
			var group = _groups.FirstOrDefault(x => x.GroupId == groupId);
			if (group != null)
			{
				return new Group
				{
					GroupId = groupId,
					Name = group.Name,
					Description = group.Description,
					Type = group.Type,
					Image = group.Image,
				};
			}

			return null;
		}

		public static Group UpdateGroup(int groupId, Group group)
		{
			var groupToUpdate = _groups.FirstOrDefault(x => x.GroupId == groupId);
			if (groupToUpdate != null)
			{
				groupToUpdate.Name = group.Name;
				groupToUpdate.Description = group.Description;
				groupToUpdate.Type = group.Type;
				groupToUpdate.Image = group.Image;
			}

			return group;
		}

		public static void AddGroup(Group group)
		{
			var maxId = _groups.Max(x => x.GroupId);
			group.GroupId = maxId + 1;
			_groups.Add(group);
		}

		public static void DeleteGroup(int groupId)
		{
			var group = _groups.FirstOrDefault(x => x.GroupId == groupId);

			if (group != null)
			{
				_groups.Remove(group);
			}
		}

		public static List<Group> SearchGroups(string filterText)
		{
			return _groups.Where(x => !string.IsNullOrWhiteSpace(x.Name) && x.Name.Contains(filterText, StringComparison.OrdinalIgnoreCase)).ToList();
		}
	}
}
