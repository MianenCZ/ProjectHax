using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.CodeAnalysis.CSharp;

namespace ShellLib.Extensions
{
	public static class StringExtensions
	{
		public static string[] SplitToArgs(this string line)
		{
            if (string.IsNullOrWhiteSpace(line))
                return new string[0];

            return  CSharpCommandLineParser.SplitCommandLineIntoArguments(line.Trim(), true).ToArray();
		}




    }
}
