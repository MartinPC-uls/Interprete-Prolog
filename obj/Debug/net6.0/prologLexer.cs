//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\ghanv\source\repos\Interprete\Interprete\prolog.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Interprete {
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class prologLexer : Lexer {
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, T__16=17, 
		T__17=18, T__18=19, T__19=20, T__20=21, T__21=22, T__22=23, T__23=24, 
		T__24=25, T__25=26, T__26=27, T__27=28, T__28=29, T__29=30, T__30=31, 
		T__31=32, T__32=33, T__33=34, T__34=35, T__35=36, T__36=37, T__37=38, 
		T__38=39, T__39=40, T__40=41, T__41=42, T__42=43, T__43=44, T__44=45, 
		T__45=46, T__46=47, T__47=48, T__48=49, T__49=50, LETTER_DIGIT=51, VARIABLE=52, 
		DECIMAL=53, BINARY=54, OCTAL=55, HEX=56, CHARACTER_CODE_CONSTANT=57, FLOAT=58, 
		GRAPHIC_TOKEN=59, QUOTED=60, DOUBLE_QUOTED_LIST=61, BACK_QUOTED_STRING=62, 
		WS=63, COMMENT=64, MULTILINE_COMMENT=65;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"T__9", "T__10", "T__11", "T__12", "T__13", "T__14", "T__15", "T__16", 
		"T__17", "T__18", "T__19", "T__20", "T__21", "T__22", "T__23", "T__24", 
		"T__25", "T__26", "T__27", "T__28", "T__29", "T__30", "T__31", "T__32", 
		"T__33", "T__34", "T__35", "T__36", "T__37", "T__38", "T__39", "T__40", 
		"T__41", "T__42", "T__43", "T__44", "T__45", "T__46", "T__47", "T__48", 
		"T__49", "LETTER_DIGIT", "VARIABLE", "DECIMAL", "BINARY", "OCTAL", "HEX", 
		"CHARACTER_CODE_CONSTANT", "FLOAT", "GRAPHIC_TOKEN", "GRAPHIC", "SINGLE_QUOTED_CHARACTER", 
		"DOUBLE_QUOTED_CHARACTER", "BACK_QUOTED_CHARACTER", "NON_QUOTE_CHAR", 
		"META_ESCAPE", "CONTROL_ESCAPE", "OCTAL_ESCAPE", "HEX_ESCAPE", "QUOTED", 
		"DOUBLE_QUOTED_LIST", "BACK_QUOTED_STRING", "CONTINUATION_ESCAPE", "ALPHANUMERIC", 
		"ALPHA", "SMALL_LETTER", "CAPITAL_LETTER", "DIGIT", "HEX_DIGIT", "SOLO", 
		"WS", "COMMENT", "MULTILINE_COMMENT"
	};


	public prologLexer(ICharStream input)
		: base(input)
	{
		_interp = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, "':-'", "','", "'.'", "'('", "')'", "'-->'", "'?-'", "'dynamic'", 
		"'multifile'", "'discontiguous'", "'public'", "';'", "'->'", "'\\+'", 
		"'='", "'\\='", "'=='", "'\\=='", "'@<'", "'@=<'", "'@>'", "'@>='", "'=..'", 
		"'is'", "'=:='", "'=\\='", "'<'", "'=<'", "'>'", "'>='", "':'", "'+'", 
		"'-'", "'/\\'", "'\\/'", "'*'", "'/'", "'//'", "'rem'", "'mod'", "'<<'", 
		"'>>'", "'**'", "'^'", "'\\'", "'['", "']'", "'{'", "'}'", "'!'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, "LETTER_DIGIT", "VARIABLE", "DECIMAL", "BINARY", "OCTAL", 
		"HEX", "CHARACTER_CODE_CONSTANT", "FLOAT", "GRAPHIC_TOKEN", "QUOTED", 
		"DOUBLE_QUOTED_LIST", "BACK_QUOTED_STRING", "WS", "COMMENT", "MULTILINE_COMMENT"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[System.Obsolete("Use Vocabulary instead.")]
	public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

	private static string[] GenerateTokenNames(IVocabulary vocabulary, int length) {
		string[] tokenNames = new string[length];
		for (int i = 0; i < tokenNames.Length; i++) {
			tokenNames[i] = vocabulary.GetLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = vocabulary.GetSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}

		return tokenNames;
	}

	[System.Obsolete("Use IRecognizer.Vocabulary instead.")]
	public override string[] TokenNames
	{
		get
		{
			return tokenNames;
		}
	}

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "prolog.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2\x43\x228\b\x1\x4"+
		"\x2\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b"+
		"\x4\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4"+
		"\x10\t\x10\x4\x11\t\x11\x4\x12\t\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15"+
		"\t\x15\x4\x16\t\x16\x4\x17\t\x17\x4\x18\t\x18\x4\x19\t\x19\x4\x1A\t\x1A"+
		"\x4\x1B\t\x1B\x4\x1C\t\x1C\x4\x1D\t\x1D\x4\x1E\t\x1E\x4\x1F\t\x1F\x4 "+
		"\t \x4!\t!\x4\"\t\"\x4#\t#\x4$\t$\x4%\t%\x4&\t&\x4\'\t\'\x4(\t(\x4)\t"+
		")\x4*\t*\x4+\t+\x4,\t,\x4-\t-\x4.\t.\x4/\t/\x4\x30\t\x30\x4\x31\t\x31"+
		"\x4\x32\t\x32\x4\x33\t\x33\x4\x34\t\x34\x4\x35\t\x35\x4\x36\t\x36\x4\x37"+
		"\t\x37\x4\x38\t\x38\x4\x39\t\x39\x4:\t:\x4;\t;\x4<\t<\x4=\t=\x4>\t>\x4"+
		"?\t?\x4@\t@\x4\x41\t\x41\x4\x42\t\x42\x4\x43\t\x43\x4\x44\t\x44\x4\x45"+
		"\t\x45\x4\x46\t\x46\x4G\tG\x4H\tH\x4I\tI\x4J\tJ\x4K\tK\x4L\tL\x4M\tM\x4"+
		"N\tN\x4O\tO\x4P\tP\x4Q\tQ\x4R\tR\x4S\tS\x3\x2\x3\x2\x3\x2\x3\x3\x3\x3"+
		"\x3\x4\x3\x4\x3\x5\x3\x5\x3\x6\x3\x6\x3\a\x3\a\x3\a\x3\a\x3\b\x3\b\x3"+
		"\b\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\n\x3\n\x3\n\x3\n\x3\n\x3"+
		"\n\x3\n\x3\n\x3\n\x3\n\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3"+
		"\v\x3\v\x3\v\x3\v\x3\v\x3\f\x3\f\x3\f\x3\f\x3\f\x3\f\x3\f\x3\r\x3\r\x3"+
		"\xE\x3\xE\x3\xE\x3\xF\x3\xF\x3\xF\x3\x10\x3\x10\x3\x11\x3\x11\x3\x11\x3"+
		"\x12\x3\x12\x3\x12\x3\x13\x3\x13\x3\x13\x3\x13\x3\x14\x3\x14\x3\x14\x3"+
		"\x15\x3\x15\x3\x15\x3\x15\x3\x16\x3\x16\x3\x16\x3\x17\x3\x17\x3\x17\x3"+
		"\x17\x3\x18\x3\x18\x3\x18\x3\x18\x3\x19\x3\x19\x3\x19\x3\x1A\x3\x1A\x3"+
		"\x1A\x3\x1A\x3\x1B\x3\x1B\x3\x1B\x3\x1B\x3\x1C\x3\x1C\x3\x1D\x3\x1D\x3"+
		"\x1D\x3\x1E\x3\x1E\x3\x1F\x3\x1F\x3\x1F\x3 \x3 \x3!\x3!\x3\"\x3\"\x3#"+
		"\x3#\x3#\x3$\x3$\x3$\x3%\x3%\x3&\x3&\x3\'\x3\'\x3\'\x3(\x3(\x3(\x3(\x3"+
		")\x3)\x3)\x3)\x3*\x3*\x3*\x3+\x3+\x3+\x3,\x3,\x3,\x3-\x3-\x3.\x3.\x3/"+
		"\x3/\x3\x30\x3\x30\x3\x31\x3\x31\x3\x32\x3\x32\x3\x33\x3\x33\x3\x34\x3"+
		"\x34\a\x34\x150\n\x34\f\x34\xE\x34\x153\v\x34\x3\x35\x3\x35\a\x35\x157"+
		"\n\x35\f\x35\xE\x35\x15A\v\x35\x3\x35\x3\x35\x6\x35\x15E\n\x35\r\x35\xE"+
		"\x35\x15F\x3\x35\x5\x35\x163\n\x35\x3\x36\x6\x36\x166\n\x36\r\x36\xE\x36"+
		"\x167\x3\x37\x3\x37\x3\x37\x3\x37\x6\x37\x16E\n\x37\r\x37\xE\x37\x16F"+
		"\x3\x38\x3\x38\x3\x38\x3\x38\x6\x38\x176\n\x38\r\x38\xE\x38\x177\x3\x39"+
		"\x3\x39\x3\x39\x3\x39\x6\x39\x17E\n\x39\r\x39\xE\x39\x17F\x3:\x3:\x3:"+
		"\x3:\x3;\x3;\x3;\x6;\x189\n;\r;\xE;\x18A\x3;\x3;\x3;\x5;\x190\n;\x3<\x3"+
		"<\x6<\x194\n<\r<\xE<\x195\x3=\x5=\x199\n=\x3>\x3>\x3>\x3>\x5>\x19F\n>"+
		"\x3?\x3?\x3?\x3?\x3?\x5?\x1A6\n?\x3@\x3@\x3@\x3@\x5@\x1AC\n@\x3\x41\x3"+
		"\x41\x3\x41\x3\x41\x3\x41\x3\x41\x3\x41\x3\x41\x5\x41\x1B6\n\x41\x3\x42"+
		"\x3\x42\x3\x42\x3\x43\x3\x43\x3\x43\x3\x44\x3\x44\x6\x44\x1C0\n\x44\r"+
		"\x44\xE\x44\x1C1\x3\x44\x3\x44\x3\x45\x3\x45\x3\x45\x3\x45\x6\x45\x1CA"+
		"\n\x45\r\x45\xE\x45\x1CB\x3\x45\x3\x45\x3\x46\x3\x46\x3\x46\a\x46\x1D3"+
		"\n\x46\f\x46\xE\x46\x1D6\v\x46\x3\x46\x3\x46\x3G\x3G\x3G\aG\x1DD\nG\f"+
		"G\xEG\x1E0\vG\x3G\x3G\x3H\x3H\x3H\aH\x1E7\nH\fH\xEH\x1EA\vH\x3H\x3H\x3"+
		"I\x3I\x3I\x3J\x3J\x5J\x1F3\nJ\x3K\x3K\x3K\x5K\x1F8\nK\x3L\x3L\x3M\x3M"+
		"\x3N\x3N\x3O\x3O\x3P\x5P\x203\nP\x3Q\x6Q\x206\nQ\rQ\xEQ\x207\x3Q\x3Q\x3"+
		"R\x3R\aR\x20E\nR\fR\xER\x211\vR\x3R\x5R\x214\nR\x3R\x3R\x3S\x3S\x3S\x3"+
		"S\x3S\aS\x21D\nS\fS\xES\x220\vS\x3S\x3S\x3S\x5S\x225\nS\x3S\x3S\x6\x1D4"+
		"\x1DE\x1E8\x21E\x2\x2T\x3\x2\x3\x5\x2\x4\a\x2\x5\t\x2\x6\v\x2\a\r\x2\b"+
		"\xF\x2\t\x11\x2\n\x13\x2\v\x15\x2\f\x17\x2\r\x19\x2\xE\x1B\x2\xF\x1D\x2"+
		"\x10\x1F\x2\x11!\x2\x12#\x2\x13%\x2\x14\'\x2\x15)\x2\x16+\x2\x17-\x2\x18"+
		"/\x2\x19\x31\x2\x1A\x33\x2\x1B\x35\x2\x1C\x37\x2\x1D\x39\x2\x1E;\x2\x1F"+
		"=\x2 ?\x2!\x41\x2\"\x43\x2#\x45\x2$G\x2%I\x2&K\x2\'M\x2(O\x2)Q\x2*S\x2"+
		"+U\x2,W\x2-Y\x2.[\x2/]\x2\x30_\x2\x31\x61\x2\x32\x63\x2\x33\x65\x2\x34"+
		"g\x2\x35i\x2\x36k\x2\x37m\x2\x38o\x2\x39q\x2:s\x2;u\x2<w\x2=y\x2\x2{\x2"+
		"\x2}\x2\x2\x7F\x2\x2\x81\x2\x2\x83\x2\x2\x85\x2\x2\x87\x2\x2\x89\x2\x2"+
		"\x8B\x2>\x8D\x2?\x8F\x2@\x91\x2\x2\x93\x2\x2\x95\x2\x2\x97\x2\x2\x99\x2"+
		"\x2\x9B\x2\x2\x9D\x2\x2\x9F\x2\x2\xA1\x2\x41\xA3\x2\x42\xA5\x2\x43\x3"+
		"\x2\x13\x3\x2\x32\x33\x3\x2\x32\x39\x3\x2\x32;\x4\x2GGgg\x4\x2--//\n\x2"+
		"%&((,-/\x31<<>\x42``\x80\x80\x4\x2$$\x62\x62\x4\x2$$))\x6\x2$$))^^\x62"+
		"\x62\b\x2\x63\x64hhppttvvxx\x4\x2\x61\x61\x63|\x3\x2\x43\\\x5\x2\x32;"+
		"\x43H\x63h\n\x2##\'\'*+..==]]__}\x7F\x5\x2\v\f\xF\xF\"\"\x4\x2\f\f\xF"+
		"\xF\x4\x3\f\f\xF\xF\x241\x2\x3\x3\x2\x2\x2\x2\x5\x3\x2\x2\x2\x2\a\x3\x2"+
		"\x2\x2\x2\t\x3\x2\x2\x2\x2\v\x3\x2\x2\x2\x2\r\x3\x2\x2\x2\x2\xF\x3\x2"+
		"\x2\x2\x2\x11\x3\x2\x2\x2\x2\x13\x3\x2\x2\x2\x2\x15\x3\x2\x2\x2\x2\x17"+
		"\x3\x2\x2\x2\x2\x19\x3\x2\x2\x2\x2\x1B\x3\x2\x2\x2\x2\x1D\x3\x2\x2\x2"+
		"\x2\x1F\x3\x2\x2\x2\x2!\x3\x2\x2\x2\x2#\x3\x2\x2\x2\x2%\x3\x2\x2\x2\x2"+
		"\'\x3\x2\x2\x2\x2)\x3\x2\x2\x2\x2+\x3\x2\x2\x2\x2-\x3\x2\x2\x2\x2/\x3"+
		"\x2\x2\x2\x2\x31\x3\x2\x2\x2\x2\x33\x3\x2\x2\x2\x2\x35\x3\x2\x2\x2\x2"+
		"\x37\x3\x2\x2\x2\x2\x39\x3\x2\x2\x2\x2;\x3\x2\x2\x2\x2=\x3\x2\x2\x2\x2"+
		"?\x3\x2\x2\x2\x2\x41\x3\x2\x2\x2\x2\x43\x3\x2\x2\x2\x2\x45\x3\x2\x2\x2"+
		"\x2G\x3\x2\x2\x2\x2I\x3\x2\x2\x2\x2K\x3\x2\x2\x2\x2M\x3\x2\x2\x2\x2O\x3"+
		"\x2\x2\x2\x2Q\x3\x2\x2\x2\x2S\x3\x2\x2\x2\x2U\x3\x2\x2\x2\x2W\x3\x2\x2"+
		"\x2\x2Y\x3\x2\x2\x2\x2[\x3\x2\x2\x2\x2]\x3\x2\x2\x2\x2_\x3\x2\x2\x2\x2"+
		"\x61\x3\x2\x2\x2\x2\x63\x3\x2\x2\x2\x2\x65\x3\x2\x2\x2\x2g\x3\x2\x2\x2"+
		"\x2i\x3\x2\x2\x2\x2k\x3\x2\x2\x2\x2m\x3\x2\x2\x2\x2o\x3\x2\x2\x2\x2q\x3"+
		"\x2\x2\x2\x2s\x3\x2\x2\x2\x2u\x3\x2\x2\x2\x2w\x3\x2\x2\x2\x2\x8B\x3\x2"+
		"\x2\x2\x2\x8D\x3\x2\x2\x2\x2\x8F\x3\x2\x2\x2\x2\xA1\x3\x2\x2\x2\x2\xA3"+
		"\x3\x2\x2\x2\x2\xA5\x3\x2\x2\x2\x3\xA7\x3\x2\x2\x2\x5\xAA\x3\x2\x2\x2"+
		"\a\xAC\x3\x2\x2\x2\t\xAE\x3\x2\x2\x2\v\xB0\x3\x2\x2\x2\r\xB2\x3\x2\x2"+
		"\x2\xF\xB6\x3\x2\x2\x2\x11\xB9\x3\x2\x2\x2\x13\xC1\x3\x2\x2\x2\x15\xCB"+
		"\x3\x2\x2\x2\x17\xD9\x3\x2\x2\x2\x19\xE0\x3\x2\x2\x2\x1B\xE2\x3\x2\x2"+
		"\x2\x1D\xE5\x3\x2\x2\x2\x1F\xE8\x3\x2\x2\x2!\xEA\x3\x2\x2\x2#\xED\x3\x2"+
		"\x2\x2%\xF0\x3\x2\x2\x2\'\xF4\x3\x2\x2\x2)\xF7\x3\x2\x2\x2+\xFB\x3\x2"+
		"\x2\x2-\xFE\x3\x2\x2\x2/\x102\x3\x2\x2\x2\x31\x106\x3\x2\x2\x2\x33\x109"+
		"\x3\x2\x2\x2\x35\x10D\x3\x2\x2\x2\x37\x111\x3\x2\x2\x2\x39\x113\x3\x2"+
		"\x2\x2;\x116\x3\x2\x2\x2=\x118\x3\x2\x2\x2?\x11B\x3\x2\x2\x2\x41\x11D"+
		"\x3\x2\x2\x2\x43\x11F\x3\x2\x2\x2\x45\x121\x3\x2\x2\x2G\x124\x3\x2\x2"+
		"\x2I\x127\x3\x2\x2\x2K\x129\x3\x2\x2\x2M\x12B\x3\x2\x2\x2O\x12E\x3\x2"+
		"\x2\x2Q\x132\x3\x2\x2\x2S\x136\x3\x2\x2\x2U\x139\x3\x2\x2\x2W\x13C\x3"+
		"\x2\x2\x2Y\x13F\x3\x2\x2\x2[\x141\x3\x2\x2\x2]\x143\x3\x2\x2\x2_\x145"+
		"\x3\x2\x2\x2\x61\x147\x3\x2\x2\x2\x63\x149\x3\x2\x2\x2\x65\x14B\x3\x2"+
		"\x2\x2g\x14D\x3\x2\x2\x2i\x162\x3\x2\x2\x2k\x165\x3\x2\x2\x2m\x169\x3"+
		"\x2\x2\x2o\x171\x3\x2\x2\x2q\x179\x3\x2\x2\x2s\x181\x3\x2\x2\x2u\x185"+
		"\x3\x2\x2\x2w\x193\x3\x2\x2\x2y\x198\x3\x2\x2\x2{\x19E\x3\x2\x2\x2}\x1A5"+
		"\x3\x2\x2\x2\x7F\x1AB\x3\x2\x2\x2\x81\x1B5\x3\x2\x2\x2\x83\x1B7\x3\x2"+
		"\x2\x2\x85\x1BA\x3\x2\x2\x2\x87\x1BD\x3\x2\x2\x2\x89\x1C5\x3\x2\x2\x2"+
		"\x8B\x1CF\x3\x2\x2\x2\x8D\x1D9\x3\x2\x2\x2\x8F\x1E3\x3\x2\x2\x2\x91\x1ED"+
		"\x3\x2\x2\x2\x93\x1F2\x3\x2\x2\x2\x95\x1F7\x3\x2\x2\x2\x97\x1F9\x3\x2"+
		"\x2\x2\x99\x1FB\x3\x2\x2\x2\x9B\x1FD\x3\x2\x2\x2\x9D\x1FF\x3\x2\x2\x2"+
		"\x9F\x202\x3\x2\x2\x2\xA1\x205\x3\x2\x2\x2\xA3\x20B\x3\x2\x2\x2\xA5\x217"+
		"\x3\x2\x2\x2\xA7\xA8\a<\x2\x2\xA8\xA9\a/\x2\x2\xA9\x4\x3\x2\x2\x2\xAA"+
		"\xAB\a.\x2\x2\xAB\x6\x3\x2\x2\x2\xAC\xAD\a\x30\x2\x2\xAD\b\x3\x2\x2\x2"+
		"\xAE\xAF\a*\x2\x2\xAF\n\x3\x2\x2\x2\xB0\xB1\a+\x2\x2\xB1\f\x3\x2\x2\x2"+
		"\xB2\xB3\a/\x2\x2\xB3\xB4\a/\x2\x2\xB4\xB5\a@\x2\x2\xB5\xE\x3\x2\x2\x2"+
		"\xB6\xB7\a\x41\x2\x2\xB7\xB8\a/\x2\x2\xB8\x10\x3\x2\x2\x2\xB9\xBA\a\x66"+
		"\x2\x2\xBA\xBB\a{\x2\x2\xBB\xBC\ap\x2\x2\xBC\xBD\a\x63\x2\x2\xBD\xBE\a"+
		"o\x2\x2\xBE\xBF\ak\x2\x2\xBF\xC0\a\x65\x2\x2\xC0\x12\x3\x2\x2\x2\xC1\xC2"+
		"\ao\x2\x2\xC2\xC3\aw\x2\x2\xC3\xC4\an\x2\x2\xC4\xC5\av\x2\x2\xC5\xC6\a"+
		"k\x2\x2\xC6\xC7\ah\x2\x2\xC7\xC8\ak\x2\x2\xC8\xC9\an\x2\x2\xC9\xCA\ag"+
		"\x2\x2\xCA\x14\x3\x2\x2\x2\xCB\xCC\a\x66\x2\x2\xCC\xCD\ak\x2\x2\xCD\xCE"+
		"\au\x2\x2\xCE\xCF\a\x65\x2\x2\xCF\xD0\aq\x2\x2\xD0\xD1\ap\x2\x2\xD1\xD2"+
		"\av\x2\x2\xD2\xD3\ak\x2\x2\xD3\xD4\ai\x2\x2\xD4\xD5\aw\x2\x2\xD5\xD6\a"+
		"q\x2\x2\xD6\xD7\aw\x2\x2\xD7\xD8\au\x2\x2\xD8\x16\x3\x2\x2\x2\xD9\xDA"+
		"\ar\x2\x2\xDA\xDB\aw\x2\x2\xDB\xDC\a\x64\x2\x2\xDC\xDD\an\x2\x2\xDD\xDE"+
		"\ak\x2\x2\xDE\xDF\a\x65\x2\x2\xDF\x18\x3\x2\x2\x2\xE0\xE1\a=\x2\x2\xE1"+
		"\x1A\x3\x2\x2\x2\xE2\xE3\a/\x2\x2\xE3\xE4\a@\x2\x2\xE4\x1C\x3\x2\x2\x2"+
		"\xE5\xE6\a^\x2\x2\xE6\xE7\a-\x2\x2\xE7\x1E\x3\x2\x2\x2\xE8\xE9\a?\x2\x2"+
		"\xE9 \x3\x2\x2\x2\xEA\xEB\a^\x2\x2\xEB\xEC\a?\x2\x2\xEC\"\x3\x2\x2\x2"+
		"\xED\xEE\a?\x2\x2\xEE\xEF\a?\x2\x2\xEF$\x3\x2\x2\x2\xF0\xF1\a^\x2\x2\xF1"+
		"\xF2\a?\x2\x2\xF2\xF3\a?\x2\x2\xF3&\x3\x2\x2\x2\xF4\xF5\a\x42\x2\x2\xF5"+
		"\xF6\a>\x2\x2\xF6(\x3\x2\x2\x2\xF7\xF8\a\x42\x2\x2\xF8\xF9\a?\x2\x2\xF9"+
		"\xFA\a>\x2\x2\xFA*\x3\x2\x2\x2\xFB\xFC\a\x42\x2\x2\xFC\xFD\a@\x2\x2\xFD"+
		",\x3\x2\x2\x2\xFE\xFF\a\x42\x2\x2\xFF\x100\a@\x2\x2\x100\x101\a?\x2\x2"+
		"\x101.\x3\x2\x2\x2\x102\x103\a?\x2\x2\x103\x104\a\x30\x2\x2\x104\x105"+
		"\a\x30\x2\x2\x105\x30\x3\x2\x2\x2\x106\x107\ak\x2\x2\x107\x108\au\x2\x2"+
		"\x108\x32\x3\x2\x2\x2\x109\x10A\a?\x2\x2\x10A\x10B\a<\x2\x2\x10B\x10C"+
		"\a?\x2\x2\x10C\x34\x3\x2\x2\x2\x10D\x10E\a?\x2\x2\x10E\x10F\a^\x2\x2\x10F"+
		"\x110\a?\x2\x2\x110\x36\x3\x2\x2\x2\x111\x112\a>\x2\x2\x112\x38\x3\x2"+
		"\x2\x2\x113\x114\a?\x2\x2\x114\x115\a>\x2\x2\x115:\x3\x2\x2\x2\x116\x117"+
		"\a@\x2\x2\x117<\x3\x2\x2\x2\x118\x119\a@\x2\x2\x119\x11A\a?\x2\x2\x11A"+
		">\x3\x2\x2\x2\x11B\x11C\a<\x2\x2\x11C@\x3\x2\x2\x2\x11D\x11E\a-\x2\x2"+
		"\x11E\x42\x3\x2\x2\x2\x11F\x120\a/\x2\x2\x120\x44\x3\x2\x2\x2\x121\x122"+
		"\a\x31\x2\x2\x122\x123\a^\x2\x2\x123\x46\x3\x2\x2\x2\x124\x125\a^\x2\x2"+
		"\x125\x126\a\x31\x2\x2\x126H\x3\x2\x2\x2\x127\x128\a,\x2\x2\x128J\x3\x2"+
		"\x2\x2\x129\x12A\a\x31\x2\x2\x12AL\x3\x2\x2\x2\x12B\x12C\a\x31\x2\x2\x12C"+
		"\x12D\a\x31\x2\x2\x12DN\x3\x2\x2\x2\x12E\x12F\at\x2\x2\x12F\x130\ag\x2"+
		"\x2\x130\x131\ao\x2\x2\x131P\x3\x2\x2\x2\x132\x133\ao\x2\x2\x133\x134"+
		"\aq\x2\x2\x134\x135\a\x66\x2\x2\x135R\x3\x2\x2\x2\x136\x137\a>\x2\x2\x137"+
		"\x138\a>\x2\x2\x138T\x3\x2\x2\x2\x139\x13A\a@\x2\x2\x13A\x13B\a@\x2\x2"+
		"\x13BV\x3\x2\x2\x2\x13C\x13D\a,\x2\x2\x13D\x13E\a,\x2\x2\x13EX\x3\x2\x2"+
		"\x2\x13F\x140\a`\x2\x2\x140Z\x3\x2\x2\x2\x141\x142\a^\x2\x2\x142\\\x3"+
		"\x2\x2\x2\x143\x144\a]\x2\x2\x144^\x3\x2\x2\x2\x145\x146\a_\x2\x2\x146"+
		"`\x3\x2\x2\x2\x147\x148\a}\x2\x2\x148\x62\x3\x2\x2\x2\x149\x14A\a\x7F"+
		"\x2\x2\x14A\x64\x3\x2\x2\x2\x14B\x14C\a#\x2\x2\x14C\x66\x3\x2\x2\x2\x14D"+
		"\x151\x5\x97L\x2\x14E\x150\x5\x93J\x2\x14F\x14E\x3\x2\x2\x2\x150\x153"+
		"\x3\x2\x2\x2\x151\x14F\x3\x2\x2\x2\x151\x152\x3\x2\x2\x2\x152h\x3\x2\x2"+
		"\x2\x153\x151\x3\x2\x2\x2\x154\x158\x5\x99M\x2\x155\x157\x5\x93J\x2\x156"+
		"\x155\x3\x2\x2\x2\x157\x15A\x3\x2\x2\x2\x158\x156\x3\x2\x2\x2\x158\x159"+
		"\x3\x2\x2\x2\x159\x163\x3\x2\x2\x2\x15A\x158\x3\x2\x2\x2\x15B\x15D\a\x61"+
		"\x2\x2\x15C\x15E\x5\x93J\x2\x15D\x15C\x3\x2\x2\x2\x15E\x15F\x3\x2\x2\x2"+
		"\x15F\x15D\x3\x2\x2\x2\x15F\x160\x3\x2\x2\x2\x160\x163\x3\x2\x2\x2\x161"+
		"\x163\a\x61\x2\x2\x162\x154\x3\x2\x2\x2\x162\x15B\x3\x2\x2\x2\x162\x161"+
		"\x3\x2\x2\x2\x163j\x3\x2\x2\x2\x164\x166\x5\x9BN\x2\x165\x164\x3\x2\x2"+
		"\x2\x166\x167\x3\x2\x2\x2\x167\x165\x3\x2\x2\x2\x167\x168\x3\x2\x2\x2"+
		"\x168l\x3\x2\x2\x2\x169\x16A\a\x32\x2\x2\x16A\x16B\a\x64\x2\x2\x16B\x16D"+
		"\x3\x2\x2\x2\x16C\x16E\t\x2\x2\x2\x16D\x16C\x3\x2\x2\x2\x16E\x16F\x3\x2"+
		"\x2\x2\x16F\x16D\x3\x2\x2\x2\x16F\x170\x3\x2\x2\x2\x170n\x3\x2\x2\x2\x171"+
		"\x172\a\x32\x2\x2\x172\x173\aq\x2\x2\x173\x175\x3\x2\x2\x2\x174\x176\t"+
		"\x3\x2\x2\x175\x174\x3\x2\x2\x2\x176\x177\x3\x2\x2\x2\x177\x175\x3\x2"+
		"\x2\x2\x177\x178\x3\x2\x2\x2\x178p\x3\x2\x2\x2\x179\x17A\a\x32\x2\x2\x17A"+
		"\x17B\az\x2\x2\x17B\x17D\x3\x2\x2\x2\x17C\x17E\x5\x9DO\x2\x17D\x17C\x3"+
		"\x2\x2\x2\x17E\x17F\x3\x2\x2\x2\x17F\x17D\x3\x2\x2\x2\x17F\x180\x3\x2"+
		"\x2\x2\x180r\x3\x2\x2\x2\x181\x182\a\x32\x2\x2\x182\x183\a)\x2\x2\x183"+
		"\x184\x5{>\x2\x184t\x3\x2\x2\x2\x185\x186\x5k\x36\x2\x186\x188\a\x30\x2"+
		"\x2\x187\x189\t\x4\x2\x2\x188\x187\x3\x2\x2\x2\x189\x18A\x3\x2\x2\x2\x18A"+
		"\x188\x3\x2\x2\x2\x18A\x18B\x3\x2\x2\x2\x18B\x18F\x3\x2\x2\x2\x18C\x18D"+
		"\t\x5\x2\x2\x18D\x18E\t\x6\x2\x2\x18E\x190\x5k\x36\x2\x18F\x18C\x3\x2"+
		"\x2\x2\x18F\x190\x3\x2\x2\x2\x190v\x3\x2\x2\x2\x191\x194\x5y=\x2\x192"+
		"\x194\a^\x2\x2\x193\x191\x3\x2\x2\x2\x193\x192\x3\x2\x2\x2\x194\x195\x3"+
		"\x2\x2\x2\x195\x193\x3\x2\x2\x2\x195\x196\x3\x2\x2\x2\x196x\x3\x2\x2\x2"+
		"\x197\x199\t\a\x2\x2\x198\x197\x3\x2\x2\x2\x199z\x3\x2\x2\x2\x19A\x19F"+
		"\x5\x81\x41\x2\x19B\x19C\a)\x2\x2\x19C\x19F\a)\x2\x2\x19D\x19F\t\b\x2"+
		"\x2\x19E\x19A\x3\x2\x2\x2\x19E\x19B\x3\x2\x2\x2\x19E\x19D\x3\x2\x2\x2"+
		"\x19F|\x3\x2\x2\x2\x1A0\x1A6\x5\x81\x41\x2\x1A1\x1A6\a)\x2\x2\x1A2\x1A3"+
		"\a$\x2\x2\x1A3\x1A6\a$\x2\x2\x1A4\x1A6\a\x62\x2\x2\x1A5\x1A0\x3\x2\x2"+
		"\x2\x1A5\x1A1\x3\x2\x2\x2\x1A5\x1A2\x3\x2\x2\x2\x1A5\x1A4\x3\x2\x2\x2"+
		"\x1A6~\x3\x2\x2\x2\x1A7\x1AC\x5\x81\x41\x2\x1A8\x1AC\t\t\x2\x2\x1A9\x1AA"+
		"\a\x62\x2\x2\x1AA\x1AC\a\x62\x2\x2\x1AB\x1A7\x3\x2\x2\x2\x1AB\x1A8\x3"+
		"\x2\x2\x2\x1AB\x1A9\x3\x2\x2\x2\x1AC\x80\x3\x2\x2\x2\x1AD\x1B6\x5y=\x2"+
		"\x1AE\x1B6\x5\x93J\x2\x1AF\x1B6\x5\x9FP\x2\x1B0\x1B6\a\"\x2\x2\x1B1\x1B6"+
		"\x5\x83\x42\x2\x1B2\x1B6\x5\x85\x43\x2\x1B3\x1B6\x5\x87\x44\x2\x1B4\x1B6"+
		"\x5\x89\x45\x2\x1B5\x1AD\x3\x2\x2\x2\x1B5\x1AE\x3\x2\x2\x2\x1B5\x1AF\x3"+
		"\x2\x2\x2\x1B5\x1B0\x3\x2\x2\x2\x1B5\x1B1\x3\x2\x2\x2\x1B5\x1B2\x3\x2"+
		"\x2\x2\x1B5\x1B3\x3\x2\x2\x2\x1B5\x1B4\x3\x2\x2\x2\x1B6\x82\x3\x2\x2\x2"+
		"\x1B7\x1B8\a^\x2\x2\x1B8\x1B9\t\n\x2\x2\x1B9\x84\x3\x2\x2\x2\x1BA\x1BB"+
		"\a^\x2\x2\x1BB\x1BC\t\v\x2\x2\x1BC\x86\x3\x2\x2\x2\x1BD\x1BF\a^\x2\x2"+
		"\x1BE\x1C0\t\x3\x2\x2\x1BF\x1BE\x3\x2\x2\x2\x1C0\x1C1\x3\x2\x2\x2\x1C1"+
		"\x1BF\x3\x2\x2\x2\x1C1\x1C2\x3\x2\x2\x2\x1C2\x1C3\x3\x2\x2\x2\x1C3\x1C4"+
		"\a^\x2\x2\x1C4\x88\x3\x2\x2\x2\x1C5\x1C6\a^\x2\x2\x1C6\x1C7\az\x2\x2\x1C7"+
		"\x1C9\x3\x2\x2\x2\x1C8\x1CA\x5\x9DO\x2\x1C9\x1C8\x3\x2\x2\x2\x1CA\x1CB"+
		"\x3\x2\x2\x2\x1CB\x1C9\x3\x2\x2\x2\x1CB\x1CC\x3\x2\x2\x2\x1CC\x1CD\x3"+
		"\x2\x2\x2\x1CD\x1CE\a^\x2\x2\x1CE\x8A\x3\x2\x2\x2\x1CF\x1D4\a)\x2\x2\x1D0"+
		"\x1D3\x5\x91I\x2\x1D1\x1D3\x5{>\x2\x1D2\x1D0\x3\x2\x2\x2\x1D2\x1D1\x3"+
		"\x2\x2\x2\x1D3\x1D6\x3\x2\x2\x2\x1D4\x1D5\x3\x2\x2\x2\x1D4\x1D2\x3\x2"+
		"\x2\x2\x1D5\x1D7\x3\x2\x2\x2\x1D6\x1D4\x3\x2\x2\x2\x1D7\x1D8\a)\x2\x2"+
		"\x1D8\x8C\x3\x2\x2\x2\x1D9\x1DE\a$\x2\x2\x1DA\x1DD\x5\x91I\x2\x1DB\x1DD"+
		"\x5}?\x2\x1DC\x1DA\x3\x2\x2\x2\x1DC\x1DB\x3\x2\x2\x2\x1DD\x1E0\x3\x2\x2"+
		"\x2\x1DE\x1DF\x3\x2\x2\x2\x1DE\x1DC\x3\x2\x2\x2\x1DF\x1E1\x3\x2\x2\x2"+
		"\x1E0\x1DE\x3\x2\x2\x2\x1E1\x1E2\a$\x2\x2\x1E2\x8E\x3\x2\x2\x2\x1E3\x1E8"+
		"\a\x62\x2\x2\x1E4\x1E7\x5\x91I\x2\x1E5\x1E7\x5\x7F@\x2\x1E6\x1E4\x3\x2"+
		"\x2\x2\x1E6\x1E5\x3\x2\x2\x2\x1E7\x1EA\x3\x2\x2\x2\x1E8\x1E9\x3\x2\x2"+
		"\x2\x1E8\x1E6\x3\x2\x2\x2\x1E9\x1EB\x3\x2\x2\x2\x1EA\x1E8\x3\x2\x2\x2"+
		"\x1EB\x1EC\a\x62\x2\x2\x1EC\x90\x3\x2\x2\x2\x1ED\x1EE\a^\x2\x2\x1EE\x1EF"+
		"\a\f\x2\x2\x1EF\x92\x3\x2\x2\x2\x1F0\x1F3\x5\x95K\x2\x1F1\x1F3\x5\x9B"+
		"N\x2\x1F2\x1F0\x3\x2\x2\x2\x1F2\x1F1\x3\x2\x2\x2\x1F3\x94\x3\x2\x2\x2"+
		"\x1F4\x1F8\a\x61\x2\x2\x1F5\x1F8\x5\x97L\x2\x1F6\x1F8\x5\x99M\x2\x1F7"+
		"\x1F4\x3\x2\x2\x2\x1F7\x1F5\x3\x2\x2\x2\x1F7\x1F6\x3\x2\x2\x2\x1F8\x96"+
		"\x3\x2\x2\x2\x1F9\x1FA\t\f\x2\x2\x1FA\x98\x3\x2\x2\x2\x1FB\x1FC\t\r\x2"+
		"\x2\x1FC\x9A\x3\x2\x2\x2\x1FD\x1FE\t\x4\x2\x2\x1FE\x9C\x3\x2\x2\x2\x1FF"+
		"\x200\t\xE\x2\x2\x200\x9E\x3\x2\x2\x2\x201\x203\t\xF\x2\x2\x202\x201\x3"+
		"\x2\x2\x2\x203\xA0\x3\x2\x2\x2\x204\x206\t\x10\x2\x2\x205\x204\x3\x2\x2"+
		"\x2\x206\x207\x3\x2\x2\x2\x207\x205\x3\x2\x2\x2\x207\x208\x3\x2\x2\x2"+
		"\x208\x209\x3\x2\x2\x2\x209\x20A\bQ\x2\x2\x20A\xA2\x3\x2\x2\x2\x20B\x20F"+
		"\a\'\x2\x2\x20C\x20E\n\x11\x2\x2\x20D\x20C\x3\x2\x2\x2\x20E\x211\x3\x2"+
		"\x2\x2\x20F\x20D\x3\x2\x2\x2\x20F\x210\x3\x2\x2\x2\x210\x213\x3\x2\x2"+
		"\x2\x211\x20F\x3\x2\x2\x2\x212\x214\t\x12\x2\x2\x213\x212\x3\x2\x2\x2"+
		"\x214\x215\x3\x2\x2\x2\x215\x216\bR\x3\x2\x216\xA4\x3\x2\x2\x2\x217\x218"+
		"\a\x31\x2\x2\x218\x219\a,\x2\x2\x219\x21E\x3\x2\x2\x2\x21A\x21D\x5\xA5"+
		"S\x2\x21B\x21D\v\x2\x2\x2\x21C\x21A\x3\x2\x2\x2\x21C\x21B\x3\x2\x2\x2"+
		"\x21D\x220\x3\x2\x2\x2\x21E\x21F\x3\x2\x2\x2\x21E\x21C\x3\x2\x2\x2\x21F"+
		"\x224\x3\x2\x2\x2\x220\x21E\x3\x2\x2\x2\x221\x222\a,\x2\x2\x222\x225\a"+
		"\x31\x2\x2\x223\x225\a\x2\x2\x3\x224\x221\x3\x2\x2\x2\x224\x223\x3\x2"+
		"\x2\x2\x225\x226\x3\x2\x2\x2\x226\x227\bS\x3\x2\x227\xA6\x3\x2\x2\x2%"+
		"\x2\x151\x158\x15F\x162\x167\x16F\x177\x17F\x18A\x18F\x193\x195\x198\x19E"+
		"\x1A5\x1AB\x1B5\x1C1\x1CB\x1D2\x1D4\x1DC\x1DE\x1E6\x1E8\x1F2\x1F7\x202"+
		"\x207\x20F\x213\x21C\x21E\x224\x4\b\x2\x2\x2\x3\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace Interprete
