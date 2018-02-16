using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Toolkit;

namespace WpfApp1.Model
{
	public class ExplorerNode
	{
		public ObservableCollection<ExplorerNode> Items { get; } = new ObservableCollection<ExplorerNode>();

		public ObservableCollection<ExplorerNode> SubFolders
		{
			get
			{
				return new ObservableCollection<ExplorerNode>(Items.Where(i => i.IsFolder));
			}
		}

		public bool IsLoaded { get; set; }

		public FileAttributes Attributes { get; set; }

		public string Path { get; set; }

		public long Size { get; set; }

		public DateTime DateCreated { get; set; }

		public DateTime DateModified { get; set; }

		public bool IsLogicalDrive { get; set; }

		public bool IsFolder => Attributes.HasFlag(FileAttributes.Directory);

		public string Icon => IconHelper.GetIconPath(this);

		public string Name
		{
			get
			{
				if (IsLogicalDrive)
					return Path;

				//if (IsFolder)
				//	return Directory;

				return System.IO.Path.GetFileName(Path);
			}
		}

		public string Extension => System.IO.Path.GetExtension(Path);

		public string Directory => System.IO.Path.GetDirectoryName(Path);
	}
}
