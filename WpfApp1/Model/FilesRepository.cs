using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
	public class FilesRepository
	{
		public ObservableCollection<ExplorerNode> GetRootItems()
		{
			var drives = Directory.GetLogicalDrives();

			var entries = new ObservableCollection<ExplorerNode>();
			foreach (var drive in drives)
			{
				var entry = new ExplorerNode();
				entry.Path = drive;

				entries.Add(entry);
			}

			return entries;
		}

		public ObservableCollection<ExplorerNode> GetFolderItems(string path)
		{
			var items = Directory.GetFileSystemEntries(path);
			var entries = new ObservableCollection<ExplorerNode>();

			foreach (var item in items)
			{
				var entry = new ExplorerNode();
				entry.Path = item;
				entry.IsLoaded = false;
				entry.Attributes = File.GetAttributes(path);

				entries.Add(entry);
			}

			return entries;
		}
	}
}
