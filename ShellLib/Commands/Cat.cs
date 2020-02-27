using System;
using System.IO;

namespace ShellLib
{
	public partial class ShellController
	{
		//TODO: Cat
		internal static int CommandCat(string[] args, StreamWriter Out, StreamReader In, StreamWriter Err = null)
		{

			//cat -
			string line = "";
			while(true)
			{
				line = In.ReadLine();
				if (line is null)
					break;
				Out.WriteLine(line);
			}

			return 0;
		}
	}
}
