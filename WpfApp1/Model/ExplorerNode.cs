using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
	public class ExplorerNode
	{
		public ObservableCollection<ExplorerNode> Items { get; set; }

		public IEnumerable<ExplorerNode> SubFolders => Items?.Where(i => i.IsFolder || i.IsDevice);

		public bool IsLoaded { get; set; }

		public FileAttributes Attributes { get; set; }

		public string Path { get; set; }

		public long Size { get; set; }

		public DateTime DateCreated { get; set; }

		public DateTime DateModified { get; set; }

		public bool IsFolder => Attributes.HasFlag(FileAttributes.Directory);

		public bool IsDevice => Attributes.HasFlag(FileAttributes.Device);

		public string Name => !IsDevice
			? System.IO.Path.GetFileName(Path) 
			: Path.Split(System.IO.Path.VolumeSeparatorChar).First();

		public string Extension => System.IO.Path.GetExtension(Path);

		public string Directory => System.IO.Path.GetDirectoryName(Path);
	}
}
