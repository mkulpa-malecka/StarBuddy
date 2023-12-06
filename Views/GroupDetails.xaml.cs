using StarBuddy.Models;
using Group = StarBuddy.Models.Group;

namespace StarBuddy.Views;

[QueryProperty(nameof(GroupId), "Id")]
public partial class GroupDetails : ContentPage
{
	private Group group;
	public GroupDetails()
	{
		InitializeComponent();
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
				groupCtrl.Image = group.Image;
			}
		}
	}

	private void groupCtrl_OnSave(object sender, EventArgs e)
	{
		DisplayAlert("Success", "You joined group", "OK");
		Shell.Current.GoToAsync("..");
	}

	private void groupCtrl_OnCancel(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync("..");
	}

	private void groupCtrl_OnError(object sender, string e)
	{
		DisplayAlert("Error", e, "OK");
	}
}