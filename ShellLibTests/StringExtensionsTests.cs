using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShellLib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShellLib.Tests
{
	[TestClass()]
	public class StringExtensionsTests
	{
		[TestMethod()]
		public void DllTest()
		{
			string line = "hallo world";
			var res = line.SplitToArgs();
		}

		[TestMethod()]
		public void SplitTest_Basic()
		{
			SplitTest("hallo world", "hallo", "world");
		}

		[TestMethod()]
		public void SplitTest_Basic2()
		{
			SplitTest("");
		}

		[TestMethod()]
		public void SplitTest_Basic3()
		{
			SplitTest("a", "a");
		}

		[TestMethod()]
		public void SplitTest_Basic4()
		{
			SplitTest(" abc ", "abc");
		}

		[TestMethod()]
		public void SplitTest_Basic5()
		{
			SplitTest("a b ", "a", "b");
		}

		[TestMethod()]
		public void SplitTest_Basic6()
		{
			SplitTest("a b \"c d\"", "a", "b", "c d");
		}

		[TestMethod()]
		public void SplitTest_Basic7()
		{
			SplitTest("-t \"Hallo World\"", "-t", "Hallo World");
		}

		[TestMethod()]
		public void SplitTest_Basic8()
		{
			SplitTest("\"Hallo World\" \"Hallo World\"", 
				"Hallo World", "Hallo World");
		}

		[TestMethod()]
		public void SplitTest_Big()
		{
			SplitTest(@"/src:""C:\tmp\Some Folder\Sub Folder"" /users:""abcdefg@hijkl.com"" tasks:""SomeTask,Some Other Task"" -someParam",
			 @"/src:""C:\tmp\Some Folder\Sub Folder""",
			 @"/users:""abcdefg@hijkl.com""",
			 @"tasks:""SomeTask,Some Other Task""",
			 @"-someParam");
		}

		[TestMethod()]
		public void SplitTest_Global()
		{
			SplitTest("");
			SplitTest("a", "a");
			SplitTest(" abc ", "abc");
			SplitTest("a b ", "a", "b");
			SplitTest("a b \"c d\"", "a", "b", "c d");
			SplitTest(@"/src:""C:\tmp\Some Folder\Sub Folder"" /users:""abcdefg@hijkl.com"" tasks:""SomeTask,Some Other Task"" -someParam",
			 @"/src:""C:\tmp\Some Folder\Sub Folder""", 
			 @"/users:""abcdefg@hijkl.com""", 
			 @"tasks:""SomeTask,Some Other Task""", 
			 @"-someParam");
		}

		public static void SplitTest(string cmdLine, params string[] args)
		{
			string[] split = cmdLine.SplitToArgs();

			Assert.IsTrue(split.Length == args.Length);

			for (int n = 0; n < split.Length; n++)
			{
				Assert.IsTrue(split[n] == args[n]);
				Console.WriteLine("{0} | {1} | {2}", split[n] == args[n], split[n],  args[n]);
			}
		}

	}
}
