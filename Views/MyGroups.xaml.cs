using System.Collections.ObjectModel;
using StarBuddy.Models;
using Group = StarBuddy.Models.Group;

namespace StarBuddy.Views;

public partial class MyGroups : ContentPage
{
	public MyGroups()
	{
		InitializeComponent();
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();

		LoadGroups();
	}

	//logic here
	private async void listGroups_ItemSelected(object sender, SelectedItemChangedEventArgs e)
	{
		if (listGroups.SelectedItem != null)
		{
			await Shell.Current.GoToAsync($"{nameof(GroupDetails)}?Id={((Group)listGroups.SelectedItem).GroupId}");
		}
	}

	// deselection here
	private void listGroups_ItemTapped(object sender, ItemTappedEventArgs e)
	{
		listGroups.SelectedItem = null;
	}

	private void btnAdd_Clicked(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync(nameof(AddGroup));
	}

	private void DeleteItem_Clicked(object sender, EventArgs e)
	{
		var menuItem = sender as MenuItem;
		var group = menuItem.CommandParameter as Group;
		GroupRepository.DeleteGroup(group.GroupId);

		LoadGroups();
	}

	private void LoadGroups()
	{
		var groups = new ObservableCollection<Group>(GroupRepository.GetGroups());
		listGroups.ItemsSource = groups.Where(x=>x.MyGroup==true);
	}
}