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
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="prologParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface IprologListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>Prolog</c>
	/// labeled alternative in <see cref="prologParser.p_text"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProlog([NotNull] prologParser.PrologContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Prolog</c>
	/// labeled alternative in <see cref="prologParser.p_text"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProlog([NotNull] prologParser.PrologContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>atom_term</c>
	/// labeled alternative in <see cref="prologParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAtom_term([NotNull] prologParser.Atom_termContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>atom_term</c>
	/// labeled alternative in <see cref="prologParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAtom_term([NotNull] prologParser.Atom_termContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>binary_operator</c>
	/// labeled alternative in <see cref="prologParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBinary_operator([NotNull] prologParser.Binary_operatorContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>binary_operator</c>
	/// labeled alternative in <see cref="prologParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBinary_operator([NotNull] prologParser.Binary_operatorContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>unary_operator</c>
	/// labeled alternative in <see cref="prologParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnary_operator([NotNull] prologParser.Unary_operatorContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>unary_operator</c>
	/// labeled alternative in <see cref="prologParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnary_operator([NotNull] prologParser.Unary_operatorContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>braced_term</c>
	/// labeled alternative in <see cref="prologParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBraced_term([NotNull] prologParser.Braced_termContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>braced_term</c>
	/// labeled alternative in <see cref="prologParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBraced_term([NotNull] prologParser.Braced_termContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>list_term</c>
	/// labeled alternative in <see cref="prologParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterList_term([NotNull] prologParser.List_termContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>list_term</c>
	/// labeled alternative in <see cref="prologParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitList_term([NotNull] prologParser.List_termContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>variable</c>
	/// labeled alternative in <see cref="prologParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariable([NotNull] prologParser.VariableContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>variable</c>
	/// labeled alternative in <see cref="prologParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariable([NotNull] prologParser.VariableContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>float</c>
	/// labeled alternative in <see cref="prologParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFloat([NotNull] prologParser.FloatContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>float</c>
	/// labeled alternative in <see cref="prologParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFloat([NotNull] prologParser.FloatContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>compound_term</c>
	/// labeled alternative in <see cref="prologParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompound_term([NotNull] prologParser.Compound_termContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>compound_term</c>
	/// labeled alternative in <see cref="prologParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompound_term([NotNull] prologParser.Compound_termContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>integer_term</c>
	/// labeled alternative in <see cref="prologParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInteger_term([NotNull] prologParser.Integer_termContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>integer_term</c>
	/// labeled alternative in <see cref="prologParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInteger_term([NotNull] prologParser.Integer_termContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>curly_bracketed_term</c>
	/// labeled alternative in <see cref="prologParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCurly_bracketed_term([NotNull] prologParser.Curly_bracketed_termContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>curly_bracketed_term</c>
	/// labeled alternative in <see cref="prologParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCurly_bracketed_term([NotNull] prologParser.Curly_bracketed_termContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>backq_string</c>
	/// labeled alternative in <see cref="prologParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBackq_string([NotNull] prologParser.Backq_stringContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>backq_string</c>
	/// labeled alternative in <see cref="prologParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBackq_string([NotNull] prologParser.Backq_stringContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>cut</c>
	/// labeled alternative in <see cref="prologParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCut([NotNull] prologParser.CutContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>cut</c>
	/// labeled alternative in <see cref="prologParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCut([NotNull] prologParser.CutContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>empty_braces</c>
	/// labeled alternative in <see cref="prologParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEmpty_braces([NotNull] prologParser.Empty_bracesContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>empty_braces</c>
	/// labeled alternative in <see cref="prologParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEmpty_braces([NotNull] prologParser.Empty_bracesContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>dq_string</c>
	/// labeled alternative in <see cref="prologParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDq_string([NotNull] prologParser.Dq_stringContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>dq_string</c>
	/// labeled alternative in <see cref="prologParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDq_string([NotNull] prologParser.Dq_stringContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>name</c>
	/// labeled alternative in <see cref="prologParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterName([NotNull] prologParser.NameContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>name</c>
	/// labeled alternative in <see cref="prologParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitName([NotNull] prologParser.NameContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>quoted_string</c>
	/// labeled alternative in <see cref="prologParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQuoted_string([NotNull] prologParser.Quoted_stringContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>quoted_string</c>
	/// labeled alternative in <see cref="prologParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQuoted_string([NotNull] prologParser.Quoted_stringContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>empty_list</c>
	/// labeled alternative in <see cref="prologParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEmpty_list([NotNull] prologParser.Empty_listContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>empty_list</c>
	/// labeled alternative in <see cref="prologParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEmpty_list([NotNull] prologParser.Empty_listContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>graphic</c>
	/// labeled alternative in <see cref="prologParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGraphic([NotNull] prologParser.GraphicContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>graphic</c>
	/// labeled alternative in <see cref="prologParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGraphic([NotNull] prologParser.GraphicContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>semicolon</c>
	/// labeled alternative in <see cref="prologParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSemicolon([NotNull] prologParser.SemicolonContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>semicolon</c>
	/// labeled alternative in <see cref="prologParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSemicolon([NotNull] prologParser.SemicolonContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="prologParser.p_text"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterP_text([NotNull] prologParser.P_textContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="prologParser.p_text"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitP_text([NotNull] prologParser.P_textContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="prologParser.directive"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDirective([NotNull] prologParser.DirectiveContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="prologParser.directive"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDirective([NotNull] prologParser.DirectiveContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="prologParser.clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClause([NotNull] prologParser.ClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="prologParser.clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClause([NotNull] prologParser.ClauseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="prologParser.termlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTermlist([NotNull] prologParser.TermlistContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="prologParser.termlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTermlist([NotNull] prologParser.TermlistContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="prologParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTerm([NotNull] prologParser.TermContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="prologParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTerm([NotNull] prologParser.TermContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="prologParser.operator_"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOperator_([NotNull] prologParser.Operator_Context context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="prologParser.operator_"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOperator_([NotNull] prologParser.Operator_Context context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="prologParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAtom([NotNull] prologParser.AtomContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="prologParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAtom([NotNull] prologParser.AtomContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="prologParser.integer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInteger([NotNull] prologParser.IntegerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="prologParser.integer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInteger([NotNull] prologParser.IntegerContext context);
}
} // namespace Interprete
