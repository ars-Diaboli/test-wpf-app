using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Interactivity;

namespace WpfApp1.Toolkit
{
	public class TreeViewCommandsBehavior : Behavior<TreeView>
	{
		private TreeViewItem _selectedTreeViewItem;

		protected override void OnAttached()
		{
			AssociatedObject.AddHandler(TreeViewItem.SelectedEvent, new RoutedEventHandler(TreeViewItem_Selected));
			AssociatedObject.CommandBindings.Add(new CommandBinding(ApplicationCommands.Open, CommandExecuted));
			AssociatedObject.CommandBindings.Add(new CommandBinding(ApplicationCommands.Close, CommandExecuted));
		}

		private void TreeViewItem_Selected(object sender, RoutedEventArgs e)
		{
			_selectedTreeViewItem = e.OriginalSource as TreeViewItem;
		}

		private void CommandExecuted(object sender, ExecutedRoutedEventArgs e)
		{
			bool expand = e.Command == ApplicationCommands.Open;
			if (_selectedTreeViewItem != null)
				_selectedTreeViewItem.IsExpanded = expand;
		}
	}
}
