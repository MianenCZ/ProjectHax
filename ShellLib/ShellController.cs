using ShellLib.Enums;
using System;

namespace ShellLib
{
	public partial class ShellController
	{
		public ShellController()
		{

		}

		/// <summary>
		/// Gets one line of command and resolve 
		/// </summary>
		/// <param name="line"></param>
		/// <returns></returns>
		public string ResolveLine(string Line)
		{
			string commandName = "";
			string[] args = { };
			CommandName name = ResolveCommandName(commandName);
			
			switch (name)
			{
				case CommandName.Empty:
					break;
				case CommandName.alias:
					return this.CommandAlias(args);
				case CommandName.cat:
					return this.CommandCat(args);
				case CommandName.cd:
					return this.CommandCd(args);
				case CommandName.clear:
					return this.CommandClear(args);
				case CommandName.cp:
					return this.CommandCp(args);
				case CommandName.diff:
					return this.CommandDiff(args);
				case CommandName.echo:
					return this.CommandEcho(args);
				case CommandName.grep:
					return this.CommandGrep(args);
				case CommandName.head:
					return this.CommandHead(args);
				case CommandName.ls:
					return this.CommandLs(args);
				case CommandName.man:
					return this.CommandMan(args);
				case CommandName.mkdir:
					return this.CommandMkdir(args);
				case CommandName.mv:
					return this.CommandMv(args);
				case CommandName.pwd:
					return this.CommandPwd(args);
				case CommandName.rm:
					return this.CommandRm(args);
				case CommandName.rmdir:
					return this.CommandRmdir(args);
				case CommandName.source:
					return this.CommandSource(args);
				case CommandName.tail:
					return this.CommandTail(args);
				case CommandName.touch:
					return this.CommandTouch(args);
				case CommandName.tr:
					return this.CommandTr(args);
				case CommandName.tty:
					return this.CommandTty(args);
				case CommandName.wc:
					return this.CommandWc(args);
			}



			return null;
		}

		internal CommandName ResolveCommandName(string Name)
		{
			return CommandName.Empty;
		}
	}



}
