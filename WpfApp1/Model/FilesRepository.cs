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
				entries.Add(Map(drive, true));
			}

			return entries;
		}

		public ObservableCollection<ExplorerNode> GetFolderItems(string path)
		{
			var entries = new ObservableCollection<ExplorerNode>();

			if (!Directory.Exists(path))
				return entries;

			try
			{
				var items = Directory.GetFileSystemEntries(path);
				foreach (var item in items)
				{
					entries.Add(Map(item));
				}
			}
			catch (UnauthorizedAccessException e)
			{
				return entries;
			}

			return entries;
		}

		private static ExplorerNode Map(string path, bool isLogicalDrive = false)
		{
			var entry = new ExplorerNode();
			entry.Path = path;
			entry.IsLoaded = false;
			entry.Attributes = File.GetAttributes(path);
			entry.IsLogicalDrive = isLogicalDrive;
			return entry;
		}
	}
}
