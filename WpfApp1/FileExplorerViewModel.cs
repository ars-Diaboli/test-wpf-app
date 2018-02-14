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

namespace WpfApp1
{
	public class FileExplorerViewModel : INotifyPropertyChanged
	{
		private readonly ObservableCollection<ExplorerNode> _root;
		private readonly FilesRepository _filesRepository;

		public event PropertyChangedEventHandler PropertyChanged;

		public FileExplorerViewModel()
		{
			_filesRepository = new FilesRepository();
			_root = _filesRepository.GetRootItems();
		}

		[NotifyPropertyChangedInvocator]
		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
