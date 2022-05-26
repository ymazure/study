using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Flyweight
{
	class TreeInfoFactory
	{
		private static HashSet<TreeInfo> trees { get; set; } = new HashSet<TreeInfo>();


		public int TreeInfoCount
		{
			get { return trees.Count; }
		}

		//public void ShowAllTrees()
		//{
		//	foreach (var t in trees.OrderBy(x => x.Mainland).ThenBy(x => x.TreeType).ThenBy(x => x.Color))
		//	{
		//		Console.WriteLine(t.Color + " " + t.TreeType + " " + t.Mainland);
		//	}
		//}

		public TreeInfo GetOrAdd(TreeInfo treeInfo)
		{
			trees.TryGetValue(treeInfo, out TreeInfo existingInfo);

			if (existingInfo != null)
			{
				return existingInfo;
			}

			trees.Add(treeInfo);
			return treeInfo;
		}
	}
}
