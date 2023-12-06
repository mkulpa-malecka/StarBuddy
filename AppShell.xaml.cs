using StarBuddy.Views;

namespace StarBuddy
{
	// app shell provides app navigation
	public partial class AppShell : Shell
	{
		public AppShell()
		{
			InitializeComponent();

			Routing.RegisterRoute(nameof(GroupPage), typeof(GroupPage));
			Routing.RegisterRoute(nameof(EditGroupPage), typeof(EditGroupPage));
			Routing.RegisterRoute(nameof(AddGroup), typeof(AddGroup));
			Routing.RegisterRoute(nameof(GroupDetails), typeof(GroupDetails));
		}
	}
}
