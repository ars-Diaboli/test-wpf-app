using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;

namespace WpfApp1
{
	public class SelectedDirectory : INotifyPropertyChanged
	{
		private string _path;

		public DirectoryInfo CurrentDirectory => new DirectoryInfo(_path);

		public string DirectoryPath
		{
			get => _path;
			set
			{
				_path = value;
				OnPropertyChanged(nameof(DirectoryPath));
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public void OnPropertyChanged([CallerMemberName]string prop = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
		}
	}
}
