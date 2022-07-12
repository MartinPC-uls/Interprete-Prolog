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
using Antlr4.Runtime.Tree;
using System.Collections.Generic;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class prologParser : Parser {
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
	public const int
		RULE_p_text = 0, RULE_directive = 1, RULE_clause = 2, RULE_termlist = 3, 
		RULE_term = 4, RULE_operator_ = 5, RULE_atom = 6, RULE_integer = 7;
	public static readonly string[] ruleNames = {
		"p_text", "directive", "clause", "termlist", "term", "operator_", "atom", 
		"integer"
	};

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

	public override string SerializedAtn { get { return _serializedATN; } }

	public prologParser(ITokenStream input)
		: base(input)
	{
		_interp = new ParserATNSimulator(this,_ATN);
	}
	public partial class P_textContext : ParserRuleContext {
		public string l = "";
		public string r = "";
		public P_textContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_p_text; } }
	 
		public P_textContext() { }
		public virtual void CopyFrom(P_textContext context) {
			base.CopyFrom(context);
			this.l = context.l;
			this.r = context.r;
		}
	}
	public partial class PrologContext : P_textContext {
		public ClauseContext c;
		public ClauseContext clist;
		public DirectiveContext d;
		public DirectiveContext dlist;
		public ITerminalNode Eof() { return GetToken(prologParser.Eof, 0); }
		public ClauseContext[] clause() {
			return GetRuleContexts<ClauseContext>();
		}
		public ClauseContext clause(int i) {
			return GetRuleContext<ClauseContext>(i);
		}
		public DirectiveContext[] directive() {
			return GetRuleContexts<DirectiveContext>();
		}
		public DirectiveContext directive(int i) {
			return GetRuleContext<DirectiveContext>(i);
		}
		public PrologContext(P_textContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IprologListener typedListener = listener as IprologListener;
			if (typedListener != null) typedListener.EnterProlog(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IprologListener typedListener = listener as IprologListener;
			if (typedListener != null) typedListener.ExitProlog(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IprologVisitor<TResult> typedVisitor = visitor as IprologVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitProlog(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public P_textContext p_text() {
		P_textContext _localctx = new P_textContext(_ctx, State);
		EnterRule(_localctx, 0, RULE_p_text);
		int _la;
		try {
			int _alt;
			_localctx = new PrologContext(_localctx);
			EnterOuterAlt(_localctx, 1);
			{
			State = 16; ((PrologContext)_localctx).c = clause();
			((PrologContext)_localctx).r = ((PrologContext)_localctx).c.texto;
			State = 23;
			_errHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(_input,0,_ctx);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.InvalidAltNumber ) {
				if ( _alt==1 ) {
					{
					{
					State = 18; ((PrologContext)_localctx).clist = clause();
					((PrologContext)_localctx).r = _localctx.r+"&"+((PrologContext)_localctx).clist.texto;
					}
					} 
				}
				State = 25;
				_errHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(_input,0,_ctx);
			}
			State = 26; ((PrologContext)_localctx).d = directive();
			((PrologContext)_localctx).l = ((PrologContext)_localctx).d.texto;
			State = 33;
			_errHandler.Sync(this);
			_la = _input.La(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__11) | (1L << T__45) | (1L << T__47) | (1L << T__49) | (1L << LETTER_DIGIT) | (1L << GRAPHIC_TOKEN) | (1L << QUOTED) | (1L << DOUBLE_QUOTED_LIST) | (1L << BACK_QUOTED_STRING))) != 0)) {
				{
				{
				State = 28; ((PrologContext)_localctx).dlist = directive();
				((PrologContext)_localctx).l = _localctx.l+"&"+((PrologContext)_localctx).dlist.texto;
				}
				}
				State = 35;
				_errHandler.Sync(this);
				_la = _input.La(1);
			}
			State = 36; Match(Eof);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class DirectiveContext : ParserRuleContext {
		public string texto;
		public string t = "";
		public DirectiveContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_directive; } }
	 
		public DirectiveContext() { }
		public virtual void CopyFrom(DirectiveContext context) {
			base.CopyFrom(context);
			this.texto = context.texto;
			this.t = context.t;
		}
	}
	public partial class DirectivaContext : DirectiveContext {
		public TermContext left;
		public TermContext center;
		public TermContext right;
		public TermContext[] term() {
			return GetRuleContexts<TermContext>();
		}
		public TermContext term(int i) {
			return GetRuleContext<TermContext>(i);
		}
		public DirectivaContext(DirectiveContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IprologListener typedListener = listener as IprologListener;
			if (typedListener != null) typedListener.EnterDirectiva(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IprologListener typedListener = listener as IprologListener;
			if (typedListener != null) typedListener.ExitDirectiva(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IprologVisitor<TResult> typedVisitor = visitor as IprologVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDirectiva(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public DirectiveContext directive() {
		DirectiveContext _localctx = new DirectiveContext(_ctx, State);
		EnterRule(_localctx, 2, RULE_directive);
		int _la;
		try {
			_localctx = new DirectivaContext(_localctx);
			EnterOuterAlt(_localctx, 1);
			{
			State = 38; ((DirectivaContext)_localctx).left = term();
			State = 39; Match(T__0);
			State = 40; ((DirectivaContext)_localctx).center = term();
			((DirectivaContext)_localctx).t = ((DirectivaContext)_localctx).left.texto+"|"+((DirectivaContext)_localctx).center.texto;
			State = 48;
			_errHandler.Sync(this);
			_la = _input.La(1);
			while (_la==T__1) {
				{
				{
				State = 42; Match(T__1);
				State = 43; ((DirectivaContext)_localctx).right = term();
				((DirectivaContext)_localctx).t = _localctx.t+"|"+((DirectivaContext)_localctx).right.texto;
				}
				}
				State = 50;
				_errHandler.Sync(this);
				_la = _input.La(1);
			}
			State = 51; Match(T__2);
			((DirectivaContext)_localctx).texto = _localctx.t;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ClauseContext : ParserRuleContext {
		public string texto;
		public ClauseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_clause; } }
	 
		public ClauseContext() { }
		public virtual void CopyFrom(ClauseContext context) {
			base.CopyFrom(context);
			this.texto = context.texto;
		}
	}
	public partial class ClausulaContext : ClauseContext {
		public TermContext left;
		public TermContext term() {
			return GetRuleContext<TermContext>(0);
		}
		public ClausulaContext(ClauseContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IprologListener typedListener = listener as IprologListener;
			if (typedListener != null) typedListener.EnterClausula(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IprologListener typedListener = listener as IprologListener;
			if (typedListener != null) typedListener.ExitClausula(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IprologVisitor<TResult> typedVisitor = visitor as IprologVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitClausula(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ClauseContext clause() {
		ClauseContext _localctx = new ClauseContext(_ctx, State);
		EnterRule(_localctx, 4, RULE_clause);
		try {
			_localctx = new ClausulaContext(_localctx);
			EnterOuterAlt(_localctx, 1);
			{
			State = 54; ((ClausulaContext)_localctx).left = term();
			State = 55; Match(T__2);
			((ClausulaContext)_localctx).texto = ((ClausulaContext)_localctx).left.texto;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TermlistContext : ParserRuleContext {
		public string texto;
		public string t = "";
		public TermlistContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_termlist; } }
	 
		public TermlistContext() { }
		public virtual void CopyFrom(TermlistContext context) {
			base.CopyFrom(context);
			this.texto = context.texto;
			this.t = context.t;
		}
	}
	public partial class Lista_termvarContext : TermlistContext {
		public IToken left;
		public IToken right;
		public ITerminalNode[] VARIABLE() { return GetTokens(prologParser.VARIABLE); }
		public ITerminalNode VARIABLE(int i) {
			return GetToken(prologParser.VARIABLE, i);
		}
		public Lista_termvarContext(TermlistContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IprologListener typedListener = listener as IprologListener;
			if (typedListener != null) typedListener.EnterLista_termvar(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IprologListener typedListener = listener as IprologListener;
			if (typedListener != null) typedListener.ExitLista_termvar(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IprologVisitor<TResult> typedVisitor = visitor as IprologVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitLista_termvar(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class Lista_termContext : TermlistContext {
		public AtomContext left;
		public AtomContext right;
		public AtomContext[] atom() {
			return GetRuleContexts<AtomContext>();
		}
		public AtomContext atom(int i) {
			return GetRuleContext<AtomContext>(i);
		}
		public Lista_termContext(TermlistContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IprologListener typedListener = listener as IprologListener;
			if (typedListener != null) typedListener.EnterLista_term(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IprologListener typedListener = listener as IprologListener;
			if (typedListener != null) typedListener.ExitLista_term(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IprologVisitor<TResult> typedVisitor = visitor as IprologVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitLista_term(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public TermlistContext termlist() {
		TermlistContext _localctx = new TermlistContext(_ctx, State);
		EnterRule(_localctx, 6, RULE_termlist);
		int _la;
		try {
			State = 82;
			_errHandler.Sync(this);
			switch (_input.La(1)) {
			case T__11:
			case T__45:
			case T__47:
			case T__49:
			case LETTER_DIGIT:
			case GRAPHIC_TOKEN:
			case QUOTED:
			case DOUBLE_QUOTED_LIST:
			case BACK_QUOTED_STRING:
				_localctx = new Lista_termContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				State = 58; ((Lista_termContext)_localctx).left = atom();
				((Lista_termContext)_localctx).t = (((Lista_termContext)_localctx).left!=null?_input.GetText(((Lista_termContext)_localctx).left.start,((Lista_termContext)_localctx).left.stop):null);
				State = 66;
				_errHandler.Sync(this);
				_la = _input.La(1);
				while (_la==T__1) {
					{
					{
					State = 60; Match(T__1);
					State = 61; ((Lista_termContext)_localctx).right = atom();
					((Lista_termContext)_localctx).t = _localctx.t+" "+(((Lista_termContext)_localctx).right!=null?_input.GetText(((Lista_termContext)_localctx).right.start,((Lista_termContext)_localctx).right.stop):null);
					}
					}
					State = 68;
					_errHandler.Sync(this);
					_la = _input.La(1);
				}
				((Lista_termContext)_localctx).texto = _localctx.t;
				}
				break;
			case VARIABLE:
				_localctx = new Lista_termvarContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				State = 71; ((Lista_termvarContext)_localctx).left = Match(VARIABLE);
				((Lista_termvarContext)_localctx).t = (((Lista_termvarContext)_localctx).left!=null?((Lista_termvarContext)_localctx).left.Text:null);
				State = 78;
				_errHandler.Sync(this);
				_la = _input.La(1);
				while (_la==T__1) {
					{
					{
					State = 73; Match(T__1);
					State = 74; ((Lista_termvarContext)_localctx).right = Match(VARIABLE);
					((Lista_termvarContext)_localctx).t = _localctx.t+" "+(((Lista_termvarContext)_localctx).right!=null?((Lista_termvarContext)_localctx).right.Text:null);
					}
					}
					State = 80;
					_errHandler.Sync(this);
					_la = _input.La(1);
				}
				((Lista_termvarContext)_localctx).texto = _localctx.t;
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TermContext : ParserRuleContext {
		public string texto;
		public string t = "";
		public TermContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_term; } }
	 
		public TermContext() { }
		public virtual void CopyFrom(TermContext context) {
			base.CopyFrom(context);
			this.texto = context.texto;
			this.t = context.t;
		}
	}
	public partial class Compound_termContext : TermContext {
		public AtomContext left;
		public TermlistContext right;
		public AtomContext atom() {
			return GetRuleContext<AtomContext>(0);
		}
		public TermlistContext termlist() {
			return GetRuleContext<TermlistContext>(0);
		}
		public Compound_termContext(TermContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IprologListener typedListener = listener as IprologListener;
			if (typedListener != null) typedListener.EnterCompound_term(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IprologListener typedListener = listener as IprologListener;
			if (typedListener != null) typedListener.ExitCompound_term(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IprologVisitor<TResult> typedVisitor = visitor as IprologVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitCompound_term(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public TermContext term() {
		TermContext _localctx = new TermContext(_ctx, State);
		EnterRule(_localctx, 8, RULE_term);
		try {
			_localctx = new Compound_termContext(_localctx);
			EnterOuterAlt(_localctx, 1);
			{
			State = 84; ((Compound_termContext)_localctx).left = atom();
			State = 85; Match(T__3);
			State = 86; ((Compound_termContext)_localctx).right = termlist();
			State = 87; Match(T__4);
			((Compound_termContext)_localctx).t = (((Compound_termContext)_localctx).left!=null?_input.GetText(((Compound_termContext)_localctx).left.start,((Compound_termContext)_localctx).left.stop):null)+"///"+(((Compound_termContext)_localctx).right!=null?_input.GetText(((Compound_termContext)_localctx).right.start,((Compound_termContext)_localctx).right.stop):null); ((Compound_termContext)_localctx).texto = _localctx.t;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Operator_Context : ParserRuleContext {
		public Operator_Context(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_operator_; } }
		public override void EnterRule(IParseTreeListener listener) {
			IprologListener typedListener = listener as IprologListener;
			if (typedListener != null) typedListener.EnterOperator_(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IprologListener typedListener = listener as IprologListener;
			if (typedListener != null) typedListener.ExitOperator_(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IprologVisitor<TResult> typedVisitor = visitor as IprologVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitOperator_(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Operator_Context operator_() {
		Operator_Context _localctx = new Operator_Context(_ctx, State);
		EnterRule(_localctx, 10, RULE_operator_);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 90;
			_la = _input.La(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__5) | (1L << T__6) | (1L << T__7) | (1L << T__8) | (1L << T__9) | (1L << T__10) | (1L << T__11) | (1L << T__12) | (1L << T__13) | (1L << T__14) | (1L << T__15) | (1L << T__16) | (1L << T__17) | (1L << T__18) | (1L << T__19) | (1L << T__20) | (1L << T__21) | (1L << T__22) | (1L << T__23) | (1L << T__24) | (1L << T__25) | (1L << T__26) | (1L << T__27) | (1L << T__28) | (1L << T__29) | (1L << T__30) | (1L << T__31) | (1L << T__32) | (1L << T__33) | (1L << T__34) | (1L << T__35) | (1L << T__36) | (1L << T__37) | (1L << T__38) | (1L << T__39) | (1L << T__40) | (1L << T__41) | (1L << T__42) | (1L << T__43) | (1L << T__44))) != 0)) ) {
			_errHandler.RecoverInline(this);
			} else {
				if (_input.La(1) == TokenConstants.Eof) {
					matchedEOF = true;
				}

				_errHandler.ReportMatch(this);
				Consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class AtomContext : ParserRuleContext {
		public AtomContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_atom; } }
	 
		public AtomContext() { }
		public virtual void CopyFrom(AtomContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class Backq_stringContext : AtomContext {
		public ITerminalNode BACK_QUOTED_STRING() { return GetToken(prologParser.BACK_QUOTED_STRING, 0); }
		public Backq_stringContext(AtomContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IprologListener typedListener = listener as IprologListener;
			if (typedListener != null) typedListener.EnterBackq_string(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IprologListener typedListener = listener as IprologListener;
			if (typedListener != null) typedListener.ExitBackq_string(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IprologVisitor<TResult> typedVisitor = visitor as IprologVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitBackq_string(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class CutContext : AtomContext {
		public CutContext(AtomContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IprologListener typedListener = listener as IprologListener;
			if (typedListener != null) typedListener.EnterCut(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IprologListener typedListener = listener as IprologListener;
			if (typedListener != null) typedListener.ExitCut(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IprologVisitor<TResult> typedVisitor = visitor as IprologVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitCut(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class Empty_bracesContext : AtomContext {
		public Empty_bracesContext(AtomContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IprologListener typedListener = listener as IprologListener;
			if (typedListener != null) typedListener.EnterEmpty_braces(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IprologListener typedListener = listener as IprologListener;
			if (typedListener != null) typedListener.ExitEmpty_braces(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IprologVisitor<TResult> typedVisitor = visitor as IprologVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitEmpty_braces(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class Dq_stringContext : AtomContext {
		public ITerminalNode DOUBLE_QUOTED_LIST() { return GetToken(prologParser.DOUBLE_QUOTED_LIST, 0); }
		public Dq_stringContext(AtomContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IprologListener typedListener = listener as IprologListener;
			if (typedListener != null) typedListener.EnterDq_string(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IprologListener typedListener = listener as IprologListener;
			if (typedListener != null) typedListener.ExitDq_string(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IprologVisitor<TResult> typedVisitor = visitor as IprologVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDq_string(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class NameContext : AtomContext {
		public ITerminalNode LETTER_DIGIT() { return GetToken(prologParser.LETTER_DIGIT, 0); }
		public NameContext(AtomContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IprologListener typedListener = listener as IprologListener;
			if (typedListener != null) typedListener.EnterName(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IprologListener typedListener = listener as IprologListener;
			if (typedListener != null) typedListener.ExitName(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IprologVisitor<TResult> typedVisitor = visitor as IprologVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitName(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class Quoted_stringContext : AtomContext {
		public ITerminalNode QUOTED() { return GetToken(prologParser.QUOTED, 0); }
		public Quoted_stringContext(AtomContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IprologListener typedListener = listener as IprologListener;
			if (typedListener != null) typedListener.EnterQuoted_string(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IprologListener typedListener = listener as IprologListener;
			if (typedListener != null) typedListener.ExitQuoted_string(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IprologVisitor<TResult> typedVisitor = visitor as IprologVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitQuoted_string(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class Empty_listContext : AtomContext {
		public Empty_listContext(AtomContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IprologListener typedListener = listener as IprologListener;
			if (typedListener != null) typedListener.EnterEmpty_list(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IprologListener typedListener = listener as IprologListener;
			if (typedListener != null) typedListener.ExitEmpty_list(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IprologVisitor<TResult> typedVisitor = visitor as IprologVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitEmpty_list(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class GraphicContext : AtomContext {
		public ITerminalNode GRAPHIC_TOKEN() { return GetToken(prologParser.GRAPHIC_TOKEN, 0); }
		public GraphicContext(AtomContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IprologListener typedListener = listener as IprologListener;
			if (typedListener != null) typedListener.EnterGraphic(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IprologListener typedListener = listener as IprologListener;
			if (typedListener != null) typedListener.ExitGraphic(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IprologVisitor<TResult> typedVisitor = visitor as IprologVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitGraphic(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class SemicolonContext : AtomContext {
		public SemicolonContext(AtomContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IprologListener typedListener = listener as IprologListener;
			if (typedListener != null) typedListener.EnterSemicolon(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IprologListener typedListener = listener as IprologListener;
			if (typedListener != null) typedListener.ExitSemicolon(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IprologVisitor<TResult> typedVisitor = visitor as IprologVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitSemicolon(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public AtomContext atom() {
		AtomContext _localctx = new AtomContext(_ctx, State);
		EnterRule(_localctx, 12, RULE_atom);
		try {
			State = 103;
			_errHandler.Sync(this);
			switch (_input.La(1)) {
			case T__45:
				_localctx = new Empty_listContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				State = 92; Match(T__45);
				State = 93; Match(T__46);
				}
				break;
			case T__47:
				_localctx = new Empty_bracesContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				State = 94; Match(T__47);
				State = 95; Match(T__48);
				}
				break;
			case LETTER_DIGIT:
				_localctx = new NameContext(_localctx);
				EnterOuterAlt(_localctx, 3);
				{
				State = 96; Match(LETTER_DIGIT);
				}
				break;
			case GRAPHIC_TOKEN:
				_localctx = new GraphicContext(_localctx);
				EnterOuterAlt(_localctx, 4);
				{
				State = 97; Match(GRAPHIC_TOKEN);
				}
				break;
			case QUOTED:
				_localctx = new Quoted_stringContext(_localctx);
				EnterOuterAlt(_localctx, 5);
				{
				State = 98; Match(QUOTED);
				}
				break;
			case DOUBLE_QUOTED_LIST:
				_localctx = new Dq_stringContext(_localctx);
				EnterOuterAlt(_localctx, 6);
				{
				State = 99; Match(DOUBLE_QUOTED_LIST);
				}
				break;
			case BACK_QUOTED_STRING:
				_localctx = new Backq_stringContext(_localctx);
				EnterOuterAlt(_localctx, 7);
				{
				State = 100; Match(BACK_QUOTED_STRING);
				}
				break;
			case T__11:
				_localctx = new SemicolonContext(_localctx);
				EnterOuterAlt(_localctx, 8);
				{
				State = 101; Match(T__11);
				}
				break;
			case T__49:
				_localctx = new CutContext(_localctx);
				EnterOuterAlt(_localctx, 9);
				{
				State = 102; Match(T__49);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class IntegerContext : ParserRuleContext {
		public ITerminalNode DECIMAL() { return GetToken(prologParser.DECIMAL, 0); }
		public ITerminalNode CHARACTER_CODE_CONSTANT() { return GetToken(prologParser.CHARACTER_CODE_CONSTANT, 0); }
		public ITerminalNode BINARY() { return GetToken(prologParser.BINARY, 0); }
		public ITerminalNode OCTAL() { return GetToken(prologParser.OCTAL, 0); }
		public ITerminalNode HEX() { return GetToken(prologParser.HEX, 0); }
		public IntegerContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_integer; } }
		public override void EnterRule(IParseTreeListener listener) {
			IprologListener typedListener = listener as IprologListener;
			if (typedListener != null) typedListener.EnterInteger(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IprologListener typedListener = listener as IprologListener;
			if (typedListener != null) typedListener.ExitInteger(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IprologVisitor<TResult> typedVisitor = visitor as IprologVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitInteger(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public IntegerContext integer() {
		IntegerContext _localctx = new IntegerContext(_ctx, State);
		EnterRule(_localctx, 14, RULE_integer);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 105;
			_la = _input.La(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << DECIMAL) | (1L << BINARY) | (1L << OCTAL) | (1L << HEX) | (1L << CHARACTER_CODE_CONSTANT))) != 0)) ) {
			_errHandler.RecoverInline(this);
			} else {
				if (_input.La(1) == TokenConstants.Eof) {
					matchedEOF = true;
				}

				_errHandler.ReportMatch(this);
				Consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x3\x43n\x4\x2\t\x2"+
		"\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x4\t\t"+
		"\t\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\a\x2\x18\n\x2\f\x2\xE\x2\x1B\v\x2\x3"+
		"\x2\x3\x2\x3\x2\x3\x2\x3\x2\a\x2\"\n\x2\f\x2\xE\x2%\v\x2\x3\x2\x3\x2\x3"+
		"\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\a\x3\x31\n\x3\f\x3\xE\x3"+
		"\x34\v\x3\x3\x3\x3\x3\x3\x3\x3\x4\x3\x4\x3\x4\x3\x4\x3\x5\x3\x5\x3\x5"+
		"\x3\x5\x3\x5\x3\x5\a\x5\x43\n\x5\f\x5\xE\x5\x46\v\x5\x3\x5\x3\x5\x3\x5"+
		"\x3\x5\x3\x5\x3\x5\x3\x5\a\x5O\n\x5\f\x5\xE\x5R\v\x5\x3\x5\x5\x5U\n\x5"+
		"\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\a\x3\a\x3\b\x3\b\x3\b\x3\b\x3"+
		"\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x5\bj\n\b\x3\t\x3\t\x3\t\x2\x2\x2\n\x2"+
		"\x2\x4\x2\x6\x2\b\x2\n\x2\f\x2\xE\x2\x10\x2\x2\x4\x4\x2\x3\x4\b/\x3\x2"+
		"\x37;s\x2\x12\x3\x2\x2\x2\x4(\x3\x2\x2\x2\x6\x38\x3\x2\x2\x2\bT\x3\x2"+
		"\x2\x2\nV\x3\x2\x2\x2\f\\\x3\x2\x2\x2\xEi\x3\x2\x2\x2\x10k\x3\x2\x2\x2"+
		"\x12\x13\x5\x6\x4\x2\x13\x19\b\x2\x1\x2\x14\x15\x5\x6\x4\x2\x15\x16\b"+
		"\x2\x1\x2\x16\x18\x3\x2\x2\x2\x17\x14\x3\x2\x2\x2\x18\x1B\x3\x2\x2\x2"+
		"\x19\x17\x3\x2\x2\x2\x19\x1A\x3\x2\x2\x2\x1A\x1C\x3\x2\x2\x2\x1B\x19\x3"+
		"\x2\x2\x2\x1C\x1D\x5\x4\x3\x2\x1D#\b\x2\x1\x2\x1E\x1F\x5\x4\x3\x2\x1F"+
		" \b\x2\x1\x2 \"\x3\x2\x2\x2!\x1E\x3\x2\x2\x2\"%\x3\x2\x2\x2#!\x3\x2\x2"+
		"\x2#$\x3\x2\x2\x2$&\x3\x2\x2\x2%#\x3\x2\x2\x2&\'\a\x2\x2\x3\'\x3\x3\x2"+
		"\x2\x2()\x5\n\x6\x2)*\a\x3\x2\x2*+\x5\n\x6\x2+\x32\b\x3\x1\x2,-\a\x4\x2"+
		"\x2-.\x5\n\x6\x2./\b\x3\x1\x2/\x31\x3\x2\x2\x2\x30,\x3\x2\x2\x2\x31\x34"+
		"\x3\x2\x2\x2\x32\x30\x3\x2\x2\x2\x32\x33\x3\x2\x2\x2\x33\x35\x3\x2\x2"+
		"\x2\x34\x32\x3\x2\x2\x2\x35\x36\a\x5\x2\x2\x36\x37\b\x3\x1\x2\x37\x5\x3"+
		"\x2\x2\x2\x38\x39\x5\n\x6\x2\x39:\a\x5\x2\x2:;\b\x4\x1\x2;\a\x3\x2\x2"+
		"\x2<=\x5\xE\b\x2=\x44\b\x5\x1\x2>?\a\x4\x2\x2?@\x5\xE\b\x2@\x41\b\x5\x1"+
		"\x2\x41\x43\x3\x2\x2\x2\x42>\x3\x2\x2\x2\x43\x46\x3\x2\x2\x2\x44\x42\x3"+
		"\x2\x2\x2\x44\x45\x3\x2\x2\x2\x45G\x3\x2\x2\x2\x46\x44\x3\x2\x2\x2GH\b"+
		"\x5\x1\x2HU\x3\x2\x2\x2IJ\a\x36\x2\x2JP\b\x5\x1\x2KL\a\x4\x2\x2LM\a\x36"+
		"\x2\x2MO\b\x5\x1\x2NK\x3\x2\x2\x2OR\x3\x2\x2\x2PN\x3\x2\x2\x2PQ\x3\x2"+
		"\x2\x2QS\x3\x2\x2\x2RP\x3\x2\x2\x2SU\b\x5\x1\x2T<\x3\x2\x2\x2TI\x3\x2"+
		"\x2\x2U\t\x3\x2\x2\x2VW\x5\xE\b\x2WX\a\x6\x2\x2XY\x5\b\x5\x2YZ\a\a\x2"+
		"\x2Z[\b\x6\x1\x2[\v\x3\x2\x2\x2\\]\t\x2\x2\x2]\r\x3\x2\x2\x2^_\a\x30\x2"+
		"\x2_j\a\x31\x2\x2`\x61\a\x32\x2\x2\x61j\a\x33\x2\x2\x62j\a\x35\x2\x2\x63"+
		"j\a=\x2\x2\x64j\a>\x2\x2\x65j\a?\x2\x2\x66j\a@\x2\x2gj\a\xE\x2\x2hj\a"+
		"\x34\x2\x2i^\x3\x2\x2\x2i`\x3\x2\x2\x2i\x62\x3\x2\x2\x2i\x63\x3\x2\x2"+
		"\x2i\x64\x3\x2\x2\x2i\x65\x3\x2\x2\x2i\x66\x3\x2\x2\x2ig\x3\x2\x2\x2i"+
		"h\x3\x2\x2\x2j\xF\x3\x2\x2\x2kl\t\x3\x2\x2l\x11\x3\x2\x2\x2\t\x19#\x32"+
		"\x44PTi";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace Interprete