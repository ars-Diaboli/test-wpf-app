using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Annotations;
using WpfApp1.Model;
using WpfApp1.Toolkit;

namespace WpfApp1
{
	public class FileExplorerViewModel : INotifyPropertyChanged
	{
		private readonly ExplorerNode _fakeNode = new ExplorerNode();
		private readonly FilesRepository _filesRepository;


		public FileExplorerViewModel()
		{
			_filesRepository = new FilesRepository();

			Root = _filesRepository.GetRootItems();
			AddFakeItems(Root);

			ExpandingCommand = new RelayCommand(ExpandSubTree, CanExpandSubTree);
		}

		public ObservableCollection<ExplorerNode> Root { get; }

		public RelayCommand ExpandingCommand { get; }

		private void ExpandSubTree(object obj)
		{
			if (obj is ExplorerNode node && !node.IsLoaded)
			{
				node.Items.Clear();

				var items = _filesRepository.GetFolderItems(node.Path);
				if (items.Any())
				{
					foreach (var entry in items)
					{
						if (entry.IsFolder)
						{
							AddFakeItems(entry.Items);
						}

						node.Items.Add(entry);
					}

					OnPropertyChanged(nameof(Root));
				}

				node.IsLoaded = true;
			}
		}

		private bool CanExpandSubTree(object obj)
		{
			return true;
		}

		public event PropertyChangedEventHandler PropertyChanged;

		[NotifyPropertyChangedInvocator]
		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		private void AddFakeItems(ObservableCollection<ExplorerNode> items)
		{
			foreach (var entry in items)
			{
				if (!entry.IsLoaded && entry.IsFolder)
				{
					entry.Items.Add(_fakeNode);
				}
			}
		}
	}
}
