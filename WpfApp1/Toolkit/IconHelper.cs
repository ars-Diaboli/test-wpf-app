using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Model;

namespace WpfApp1.Toolkit
{
	public static class IconHelper
	{
		public static string GetIconPath(ExplorerNode node)
		{
			if (node.IsLogicalDrive)
				return "img\\Hard-Drive-icon.png";

			if (node.IsFolder)
				return "img\\folder.png";

			return "img\\file.png";
		}
	}
}
