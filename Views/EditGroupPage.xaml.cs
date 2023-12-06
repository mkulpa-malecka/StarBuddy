using StarBuddy.Models;
using Group = StarBuddy.Models.Group;

namespace StarBuddy.Views;

public partial class EditGroupPage : ContentPage
{
	private Group group;
	public EditGroupPage()
	{
		InitializeComponent();
	}

	private void btnCancel_Clicked(object sender, EventArgs e)
	{
		// go back to parent
		Shell.Current.GoToAsync("..");
	}

	public string GroupId
	{
		set
		{
			group = GroupRepository.GetGroupById(int.Parse(value));

			if (group != null)
			{
				groupCtrl.Name = group.Name;
				groupCtrl.Description = group.Description;
				groupCtrl.Type = group.Type;
			}
		}
	}

	private void btnUpdate_Clicked(object sender, EventArgs e)
	{
		group.Name = groupCtrl.Name;
		group.Description = groupCtrl.Description;
		group.Type = groupCtrl.Type;

		GroupRepository.UpdateGroup(group.GroupId, group);
		// go back to parent
		Shell.Current.GoToAsync("..");
	}

	private void groupCtrl_OnError(object sender, string e)
	{
		DisplayAlert("Error", e, "OK");
	}
}