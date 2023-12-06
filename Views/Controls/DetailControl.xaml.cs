using StarBuddy.Models;

namespace StarBuddy.Views.Controls;

public partial class DetailControl : ContentView
{
	public event EventHandler<string> OnError;
	public event EventHandler<EventArgs> OnSave;
	public event EventHandler<EventArgs> OnCancel;
	public DetailControl()
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

	public string Image
	{
		get
		{
			return groupImage.Source.ToString();
		}
		set
		{
			groupImage.Source = value;
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

		OnSave?.Invoke(sender, e);
	}

	private void btnCancel_Clicked(object sender, EventArgs e)
	{
		OnCancel?.Invoke(sender, e);
	}
}