using System;
using IniParser.Configuration;

namespace IniParser.Format
{
	public interface IIniDataFormatter
	{
		string Format(IniData iniData, IniFormattingConfiguration format);
	}
}
