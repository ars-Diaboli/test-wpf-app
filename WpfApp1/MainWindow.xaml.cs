using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private const string ThemeExt = ".baml";

		public MainWindow()
		{
			InitializeComponent();
			LoadThemes();

			DataContext = new FileExplorerViewModel();
		}

		private void LoadThemes()
		{
			var allThemeResources = GetAllThemes();

			foreach (var themeResource in allThemeResources)
			{
				var menuItem = new MenuItem();
				menuItem.Header = GetThemeName(themeResource);
				menuItem.Tag = themeResource;
				ThemeSelector.Items.Add(menuItem);
			}
		}

		private IEnumerable<string> GetAllThemes()
		{
			var assembly = Assembly.GetExecutingAssembly();
			var resourcesName = assembly.GetName().Name + ".g";
			var manager = new System.Resources.ResourceManager(resourcesName, assembly);
			var resourceSet = manager.GetResourceSet(CultureInfo.CurrentUICulture, true, true);

			return resourceSet
				.OfType<DictionaryEntry>()
				.Select(e => e.Key.ToString())
				.Where(e => e.StartsWith(@"themes/") && e.EndsWith(ThemeExt));
		}

		private static string GetThemeName(string resName)
		{
			return resName.ToLower()
				.Replace(@"themes/", "")
				.Replace("theme.baml", "")
				.Replace(".baml", "")
				.ToUpper();
		}

		private void ApplyTheme(object sender, SelectionChangedEventArgs e)
		{
			//ThemeSelector.Items

			string style = "DarkTheme";
			var uri = new Uri(style + ".xaml", UriKind.Relative);
			ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
			Application.Current.Resources.Clear();
			Application.Current.Resources.MergedDictionaries.Add(resourceDict);
		}
	}
}
