using StarBuddy.Models;

namespace StarBuddy.Views.Controls;

public partial class GroupControl : ContentView
{
	public event EventHandler<string> OnError;
	public event EventHandler<EventArgs> OnSave;
	public event EventHandler<EventArgs> OnCancel;
	public GroupControl()
	{
		InitializeComponent();
	}

	public string Name
	{
		get
		{
			return groupName.Text;
		}
		set
		{
			groupName.Text = value;
		}
	}

	public string Description
	{
		get
		{
			return groupDescription.Text;
		}
		set
		{
			groupDescription.Text = value;
		}
	}
	public GroupTypeEnum Type
	{
		get
		{
			Enum.TryParse(groupType.Text, out GroupTypeEnum type);
			return type;
		}
		set
		{
			groupType.Text = value.ToString();
		}
	}

	private void btnSave_Clicked(object sender, EventArgs e)
	{
		if (nameValidator.IsNotValid)
		{
			OnError?.Invoke(sender, "Name is required.");
			return;
		}

		OnSave?.Invoke(sender, e);
	}

	private void btnCancel_Clicked(object sender, EventArgs e)
	{
		OnCancel?.Invoke(sender, e);
	}
}