using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using IniParser;
using IniParser.Configuration;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace IniParser.Format
{
	public interface IIniDataFormatter // TypeDefIndex: 37384
	{
		// Methods
		string Format(IniData iniData, IniFormattingConfiguration format);
	}
}
