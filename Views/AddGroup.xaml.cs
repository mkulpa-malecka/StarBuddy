using StarBuddy.Models;
using Group = StarBuddy.Models.Group;

namespace StarBuddy.Views;

public partial class AddGroup : ContentPage
{
	public AddGroup()
	{
		InitializeComponent();
	}

	private void groupCtrl_OnSave(object sender, EventArgs e)
	{
		GroupRepository.AddGroup(new Group
		{
			Name = groupCtrl.Name,
			Description = groupCtrl.Description,
			Type = groupCtrl.Type,
		});

		Shell.Current.GoToAsync($"//{nameof(GroupPage)}");
	}

	private void groupCtrl_OnError(object sender, string e)
	{
		DisplayAlert("Error", e, "OK");
	}

	private void groupCtrl_OnCancel(object sender, EventArgs e)
	{
		// go back to parent - can use this or ("..")
		Shell.Current.GoToAsync($"//{nameof(GroupPage)}");
	}
}