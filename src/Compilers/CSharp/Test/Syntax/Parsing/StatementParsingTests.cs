// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp.Test.Utilities;
using Microsoft.CodeAnalysis.Test.Utilities;
using Roslyn.Test.Utilities;
using Xunit;
using Xunit.Abstractions;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests
{
    public class StatementParsingTests : ParsingTests
    {
        public StatementParsingTests(ITestOutputHelper output) : base(output) { }

        private StatementSyntax ParseStatement(string text, int offset = 0, ParseOptions options = null)
        {
            return SyntaxFactory.ParseStatement(text, offset, options);
        }

        [Fact]
        [WorkItem(17458, "https://github.com/dotnet/roslyn/issues/17458")]
        public void ParsePrivate()
        {
            UsingStatement("private",
                // (1,1): error CS1073: Unexpected token 'private'
                // private
                Diagnostic(ErrorCode.ERR_UnexpectedToken, "").WithArguments("private").WithLocation(1, 1),
                // (1,1): error CS1525: Invalid expression term 'private'
                // private
                Diagnostic(ErrorCode.ERR_InvalidExprTerm, "private").WithArguments("private").WithLocation(1, 1),
                // (1,1): error CS1002: ; expected
                // private
                Diagnostic(ErrorCode.ERR_SemicolonExpected, "private").WithLocation(1, 1)
                );
            M(SyntaxKind.ExpressionStatement);
            {
                M(SyntaxKind.IdentifierName);
                {
                    M(SyntaxKind.IdentifierToken);
                }
                M(SyntaxKind.SemicolonToken);
            }
            EOF();
        }

        [Fact]
        public void TestName()
        {
            var text = "a();";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.ExpressionStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var es = (ExpressionStatementSyntax)statement;
            CustomAssert.NotNull(es.Expression);
            CustomAssert.Equal(SyntaxKind.InvocationExpression, es.Expression.Kind());
            CustomAssert.Equal(SyntaxKind.IdentifierName, ((InvocationExpressionSyntax)es.Expression).Expression.Kind());
            CustomAssert.Equal("a()", es.Expression.ToString());
            CustomAssert.NotEqual(default, es.SemicolonToken);
            CustomAssert.False(es.SemicolonToken.IsMissing);
        }

        [Fact]
        public void TestDottedName()
        {
            var text = "a.b();";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.ExpressionStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var es = (ExpressionStatementSyntax)statement;
            CustomAssert.NotNull(es.Expression);
            CustomAssert.Equal(SyntaxKind.InvocationExpression, es.Expression.Kind());
            CustomAssert.Equal(SyntaxKind.SimpleMemberAccessExpression, ((InvocationExpressionSyntax)es.Expression).Expression.Kind());
            CustomAssert.Equal("a.b()", es.Expression.ToString());
            CustomAssert.NotEqual(default, es.SemicolonToken);
            CustomAssert.False(es.SemicolonToken.IsMissing);
        }

        [Fact]
        public void TestGenericName()
        {
            var text = "a<b>();";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.ExpressionStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);
            var es = (ExpressionStatementSyntax)statement;
            CustomAssert.NotNull(es.Expression);
            CustomAssert.Equal(SyntaxKind.InvocationExpression, es.Expression.Kind());
            CustomAssert.Equal(SyntaxKind.GenericName, ((InvocationExpressionSyntax)es.Expression).Expression.Kind());
            CustomAssert.Equal("a<b>()", es.Expression.ToString());
            CustomAssert.NotEqual(default, es.SemicolonToken);
            CustomAssert.False(es.SemicolonToken.IsMissing);
        }

        [Fact]
        public void TestGenericDotName()
        {
            var text = "a<b>.c();";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.ExpressionStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var es = (ExpressionStatementSyntax)statement;
            CustomAssert.NotNull(es.Expression);
            CustomAssert.Equal(SyntaxKind.InvocationExpression, es.Expression.Kind());
            CustomAssert.Equal(SyntaxKind.SimpleMemberAccessExpression, ((InvocationExpressionSyntax)es.Expression).Expression.Kind());
            CustomAssert.Equal("a<b>.c()", es.Expression.ToString());
            CustomAssert.NotEqual(default, es.SemicolonToken);
            CustomAssert.False(es.SemicolonToken.IsMissing);
        }

        [Fact]
        public void TestDotGenericName()
        {
            var text = "a.b<c>();";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.ExpressionStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var es = (ExpressionStatementSyntax)statement;
            CustomAssert.NotNull(es.Expression);
            CustomAssert.Equal(SyntaxKind.InvocationExpression, es.Expression.Kind());
            CustomAssert.Equal(SyntaxKind.SimpleMemberAccessExpression, ((InvocationExpressionSyntax)es.Expression).Expression.Kind());
            CustomAssert.Equal("a.b<c>()", es.Expression.ToString());
            CustomAssert.NotEqual(default, es.SemicolonToken);
            CustomAssert.False(es.SemicolonToken.IsMissing);
        }

        private void TestPostfixUnaryOperator(SyntaxKind kind, ParseOptions options = null)
        {
            var text = "a" + SyntaxFacts.GetText(kind) + ";";
            var statement = this.ParseStatement(text, options: options);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.ExpressionStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var es = (ExpressionStatementSyntax)statement;
            CustomAssert.NotNull(es.Expression);
            CustomAssert.NotEqual(default, es.SemicolonToken);
            CustomAssert.False(es.SemicolonToken.IsMissing);

            var opKind = SyntaxFacts.GetPostfixUnaryExpression(kind);
            CustomAssert.Equal(opKind, es.Expression.Kind());
            var us = (PostfixUnaryExpressionSyntax)es.Expression;
            CustomAssert.Equal("a", us.Operand.ToString());
            CustomAssert.Equal(kind, us.OperatorToken.Kind());
        }

        [Fact]
        public void TestPostfixUnaryOperators()
        {
            TestPostfixUnaryOperator(SyntaxKind.PlusPlusToken);
            TestPostfixUnaryOperator(SyntaxKind.MinusMinusToken);
            TestPostfixUnaryOperator(SyntaxKind.ExclamationToken, TestOptions.Regular8);
        }

        [Fact]
        public void TestLocalDeclarationStatement()
        {
            var text = "T a;";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.LocalDeclarationStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var ds = (LocalDeclarationStatementSyntax)statement;
            CustomAssert.Equal(0, ds.Modifiers.Count);
            CustomAssert.NotNull(ds.Declaration.Type);
            CustomAssert.Equal("T", ds.Declaration.Type.ToString());
            CustomAssert.Equal(1, ds.Declaration.Variables.Count);

            CustomAssert.NotEqual(default, ds.Declaration.Variables[0].Identifier);
            CustomAssert.Equal("a", ds.Declaration.Variables[0].Identifier.ToString());
            CustomAssert.Null(ds.Declaration.Variables[0].ArgumentList);
            CustomAssert.Null(ds.Declaration.Variables[0].Initializer);

            CustomAssert.NotEqual(default, ds.SemicolonToken);
            CustomAssert.False(ds.SemicolonToken.IsMissing);
        }

        [Fact]
        public void TestLocalDeclarationStatementWithVar()
        {
            // note: semantically this would require an initializer, but we don't know 
            // about var being special until we bind.
            var text = "var a;";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.LocalDeclarationStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var ds = (LocalDeclarationStatementSyntax)statement;
            CustomAssert.Equal(0, ds.Modifiers.Count);
            CustomAssert.NotNull(ds.Declaration.Type);
            CustomAssert.Equal("var", ds.Declaration.Type.ToString());
            CustomAssert.Equal(SyntaxKind.IdentifierName, ds.Declaration.Type.Kind());
            CustomAssert.Equal(SyntaxKind.IdentifierToken, ((IdentifierNameSyntax)ds.Declaration.Type).Identifier.Kind());
            CustomAssert.Equal(1, ds.Declaration.Variables.Count);

            CustomAssert.NotEqual(default, ds.Declaration.Variables[0].Identifier);
            CustomAssert.Equal("a", ds.Declaration.Variables[0].Identifier.ToString());
            CustomAssert.Null(ds.Declaration.Variables[0].ArgumentList);
            CustomAssert.Null(ds.Declaration.Variables[0].Initializer);

            CustomAssert.NotEqual(default, ds.SemicolonToken);
            CustomAssert.False(ds.SemicolonToken.IsMissing);
        }

        [Fact]
        public void TestLocalDeclarationStatementWithTuple()
        {
            var text = "(int, int) a;";
            var statement = this.ParseStatement(text, options: TestOptions.Regular);

            (text).ToString();

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.LocalDeclarationStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var ds = (LocalDeclarationStatementSyntax)statement;
            CustomAssert.Equal(0, ds.Modifiers.Count);
            CustomAssert.NotNull(ds.Declaration.Type);
            CustomAssert.Equal("(int, int)", ds.Declaration.Type.ToString());
            CustomAssert.Equal(SyntaxKind.TupleType, ds.Declaration.Type.Kind());

            var tt = (TupleTypeSyntax)ds.Declaration.Type;

            CustomAssert.Equal(SyntaxKind.PredefinedType, tt.Elements[0].Type.Kind());
            CustomAssert.Equal(SyntaxKind.None, tt.Elements[1].Identifier.Kind());
            CustomAssert.Equal(2, tt.Elements.Count);

            CustomAssert.NotEqual(default, ds.Declaration.Variables[0].Identifier);
            CustomAssert.Equal("a", ds.Declaration.Variables[0].Identifier.ToString());
            CustomAssert.Null(ds.Declaration.Variables[0].ArgumentList);
            CustomAssert.Null(ds.Declaration.Variables[0].Initializer);

            CustomAssert.NotEqual(default, ds.SemicolonToken);
            CustomAssert.False(ds.SemicolonToken.IsMissing);
        }

        [Fact]
        public void TestLocalDeclarationStatementWithNamedTuple()
        {
            var text = "(T x, (U k, V l, W m) y) a;";
            var statement = this.ParseStatement(text);

            (text).ToString();

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.LocalDeclarationStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var ds = (LocalDeclarationStatementSyntax)statement;
            CustomAssert.Equal(0, ds.Modifiers.Count);
            CustomAssert.NotNull(ds.Declaration.Type);
            CustomAssert.Equal("(T x, (U k, V l, W m) y)", ds.Declaration.Type.ToString());
            CustomAssert.Equal(SyntaxKind.TupleType, ds.Declaration.Type.Kind());

            var tt = (TupleTypeSyntax)ds.Declaration.Type;

            CustomAssert.Equal(SyntaxKind.IdentifierName, tt.Elements[0].Type.Kind());
            CustomAssert.Equal("y", tt.Elements[1].Identifier.ToString());
            CustomAssert.Equal(2, tt.Elements.Count);


            tt = (TupleTypeSyntax)tt.Elements[1].Type;

            CustomAssert.Equal("(U k, V l, W m)", tt.ToString());
            CustomAssert.Equal(SyntaxKind.IdentifierName, tt.Elements[0].Type.Kind());
            CustomAssert.Equal("l", tt.Elements[1].Identifier.ToString());
            CustomAssert.Equal(3, tt.Elements.Count);

            CustomAssert.NotEqual(default, ds.Declaration.Variables[0].Identifier);
            CustomAssert.Equal("a", ds.Declaration.Variables[0].Identifier.ToString());
            CustomAssert.Null(ds.Declaration.Variables[0].ArgumentList);
            CustomAssert.Null(ds.Declaration.Variables[0].Initializer);

            CustomAssert.NotEqual(default, ds.SemicolonToken);
            CustomAssert.False(ds.SemicolonToken.IsMissing);
        }

        [Fact]
        public void TestLocalDeclarationStatementWithDynamic()
        {
            // note: semantically this would require an initializer, but we don't know 
            // about dynamic being special until we bind.
            var text = "dynamic a;";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.LocalDeclarationStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var ds = (LocalDeclarationStatementSyntax)statement;
            CustomAssert.Equal(0, ds.Modifiers.Count);
            CustomAssert.NotNull(ds.Declaration.Type);
            CustomAssert.Equal("dynamic", ds.Declaration.Type.ToString());
            CustomAssert.Equal(SyntaxKind.IdentifierName, ds.Declaration.Type.Kind());
            CustomAssert.Equal(SyntaxKind.IdentifierToken, ((IdentifierNameSyntax)ds.Declaration.Type).Identifier.Kind());
            CustomAssert.Equal(1, ds.Declaration.Variables.Count);

            CustomAssert.NotEqual(default, ds.Declaration.Variables[0].Identifier);
            CustomAssert.Equal("a", ds.Declaration.Variables[0].Identifier.ToString());
            CustomAssert.Null(ds.Declaration.Variables[0].ArgumentList);
            CustomAssert.Null(ds.Declaration.Variables[0].Initializer);

            CustomAssert.NotEqual(default, ds.SemicolonToken);
            CustomAssert.False(ds.SemicolonToken.IsMissing);
        }

        [Fact]
        public void TestLocalDeclarationStatementWithGenericType()
        {
            var text = "T<a> b;";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.LocalDeclarationStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var ds = (LocalDeclarationStatementSyntax)statement;
            CustomAssert.Equal(0, ds.Modifiers.Count);
            CustomAssert.NotNull(ds.Declaration.Type);
            CustomAssert.Equal("T<a>", ds.Declaration.Type.ToString());
            CustomAssert.Equal(1, ds.Declaration.Variables.Count);

            CustomAssert.NotEqual(default, ds.Declaration.Variables[0].Identifier);
            CustomAssert.Equal("b", ds.Declaration.Variables[0].Identifier.ToString());
            CustomAssert.Null(ds.Declaration.Variables[0].ArgumentList);
            CustomAssert.Null(ds.Declaration.Variables[0].Initializer);

            CustomAssert.NotEqual(default, ds.SemicolonToken);
            CustomAssert.False(ds.SemicolonToken.IsMissing);
        }

        [Fact]
        public void TestLocalDeclarationStatementWithDottedType()
        {
            var text = "T.X.Y a;";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.LocalDeclarationStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var ds = (LocalDeclarationStatementSyntax)statement;
            CustomAssert.Equal(0, ds.Modifiers.Count);
            CustomAssert.NotNull(ds.Declaration.Type);
            CustomAssert.Equal("T.X.Y", ds.Declaration.Type.ToString());
            CustomAssert.Equal(1, ds.Declaration.Variables.Count);

            CustomAssert.NotEqual(default, ds.Declaration.Variables[0].Identifier);
            CustomAssert.Equal("a", ds.Declaration.Variables[0].Identifier.ToString());
            CustomAssert.Null(ds.Declaration.Variables[0].ArgumentList);
            CustomAssert.Null(ds.Declaration.Variables[0].Initializer);

            CustomAssert.NotEqual(default, ds.SemicolonToken);
            CustomAssert.False(ds.SemicolonToken.IsMissing);
        }

        [Fact]
        public void TestLocalDeclarationStatementWithMixedType()
        {
            var text = "T<t>.X<x>.Y<y> a;";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.LocalDeclarationStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var ds = (LocalDeclarationStatementSyntax)statement;
            CustomAssert.Equal(0, ds.Modifiers.Count);
            CustomAssert.NotNull(ds.Declaration.Type);
            CustomAssert.Equal("T<t>.X<x>.Y<y>", ds.Declaration.Type.ToString());
            CustomAssert.Equal(1, ds.Declaration.Variables.Count);

            CustomAssert.NotEqual(default, ds.Declaration.Variables[0].Identifier);
            CustomAssert.Equal("a", ds.Declaration.Variables[0].Identifier.ToString());
            CustomAssert.Null(ds.Declaration.Variables[0].ArgumentList);
            CustomAssert.Null(ds.Declaration.Variables[0].Initializer);

            CustomAssert.NotEqual(default, ds.SemicolonToken);
            CustomAssert.False(ds.SemicolonToken.IsMissing);
        }

        [Fact]
        public void TestLocalDeclarationStatementWithArrayType()
        {
            var text = "T[][,][,,] a;";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.LocalDeclarationStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var ds = (LocalDeclarationStatementSyntax)statement;
            CustomAssert.Equal(0, ds.Modifiers.Count);
            CustomAssert.NotNull(ds.Declaration.Type);
            CustomAssert.Equal("T[][,][,,]", ds.Declaration.Type.ToString());
            CustomAssert.Equal(1, ds.Declaration.Variables.Count);

            CustomAssert.NotEqual(default, ds.Declaration.Variables[0].Identifier);
            CustomAssert.Equal("a", ds.Declaration.Variables[0].Identifier.ToString());
            CustomAssert.Null(ds.Declaration.Variables[0].ArgumentList);
            CustomAssert.Null(ds.Declaration.Variables[0].Initializer);

            CustomAssert.NotEqual(default, ds.SemicolonToken);
            CustomAssert.False(ds.SemicolonToken.IsMissing);
        }

        [Fact]
        public void TestLocalDeclarationStatementWithPointerType()
        {
            var text = "T* a;";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.LocalDeclarationStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var ds = (LocalDeclarationStatementSyntax)statement;
            CustomAssert.Equal(0, ds.Modifiers.Count);
            CustomAssert.NotNull(ds.Declaration.Type);
            CustomAssert.Equal("T*", ds.Declaration.Type.ToString());
            CustomAssert.Equal(1, ds.Declaration.Variables.Count);

            CustomAssert.NotEqual(default, ds.Declaration.Variables[0].Identifier);
            CustomAssert.Equal("a", ds.Declaration.Variables[0].Identifier.ToString());
            CustomAssert.Null(ds.Declaration.Variables[0].ArgumentList);
            CustomAssert.Null(ds.Declaration.Variables[0].Initializer);

            CustomAssert.NotEqual(default, ds.SemicolonToken);
            CustomAssert.False(ds.SemicolonToken.IsMissing);
        }

        [Fact]
        public void TestLocalDeclarationStatementWithNullableType()
        {
            var text = "T? a;";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.LocalDeclarationStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var ds = (LocalDeclarationStatementSyntax)statement;
            CustomAssert.Equal(0, ds.Modifiers.Count);
            CustomAssert.NotNull(ds.Declaration.Type);
            CustomAssert.Equal("T?", ds.Declaration.Type.ToString());
            CustomAssert.Equal(1, ds.Declaration.Variables.Count);

            CustomAssert.NotEqual(default, ds.Declaration.Variables[0].Identifier);
            CustomAssert.Equal("a", ds.Declaration.Variables[0].Identifier.ToString());
            CustomAssert.Null(ds.Declaration.Variables[0].ArgumentList);
            CustomAssert.Null(ds.Declaration.Variables[0].Initializer);

            CustomAssert.NotEqual(default, ds.SemicolonToken);
            CustomAssert.False(ds.SemicolonToken.IsMissing);
        }

        [Fact]
        public void TestLocalDeclarationStatementWithMultipleVariables()
        {
            var text = "T a, b, c;";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.LocalDeclarationStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var ds = (LocalDeclarationStatementSyntax)statement;
            CustomAssert.Equal(0, ds.Modifiers.Count);
            CustomAssert.NotNull(ds.Declaration.Type);
            CustomAssert.Equal("T", ds.Declaration.Type.ToString());
            CustomAssert.Equal(3, ds.Declaration.Variables.Count);

            CustomAssert.NotEqual(default, ds.Declaration.Variables[0].Identifier);
            CustomAssert.Equal("a", ds.Declaration.Variables[0].Identifier.ToString());
            CustomAssert.Null(ds.Declaration.Variables[0].ArgumentList);
            CustomAssert.Null(ds.Declaration.Variables[0].Initializer);

            CustomAssert.NotEqual(default, ds.Declaration.Variables[1].Identifier);
            CustomAssert.Equal("b", ds.Declaration.Variables[1].Identifier.ToString());
            CustomAssert.Null(ds.Declaration.Variables[1].ArgumentList);
            CustomAssert.Null(ds.Declaration.Variables[1].Initializer);

            CustomAssert.NotEqual(default, ds.Declaration.Variables[2].Identifier);
            CustomAssert.Equal("c", ds.Declaration.Variables[2].Identifier.ToString());
            CustomAssert.Null(ds.Declaration.Variables[2].Initializer);

            CustomAssert.NotEqual(default, ds.SemicolonToken);
            CustomAssert.False(ds.SemicolonToken.IsMissing);
        }

        [Fact]
        public void TestLocalDeclarationStatementWithInitializer()
        {
            var text = "T a = b;";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.LocalDeclarationStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var ds = (LocalDeclarationStatementSyntax)statement;
            CustomAssert.Equal(0, ds.Modifiers.Count);
            CustomAssert.NotNull(ds.Declaration.Type);
            CustomAssert.Equal("T", ds.Declaration.Type.ToString());
            CustomAssert.Equal(1, ds.Declaration.Variables.Count);

            CustomAssert.NotEqual(default, ds.Declaration.Variables[0].Identifier);
            CustomAssert.Equal("a", ds.Declaration.Variables[0].Identifier.ToString());
            CustomAssert.Null(ds.Declaration.Variables[0].ArgumentList);
            CustomAssert.NotNull(ds.Declaration.Variables[0].Initializer);
            CustomAssert.NotEqual(default, ds.Declaration.Variables[0].Initializer.EqualsToken);
            CustomAssert.False(ds.Declaration.Variables[0].Initializer.EqualsToken.IsMissing);
            CustomAssert.NotNull(ds.Declaration.Variables[0].Initializer.Value);
            CustomAssert.Equal("b", ds.Declaration.Variables[0].Initializer.Value.ToString());

            CustomAssert.NotEqual(default, ds.SemicolonToken);
            CustomAssert.False(ds.SemicolonToken.IsMissing);
        }

        [Fact]
        public void TestLocalDeclarationStatementWithMultipleVariablesAndInitializers()
        {
            var text = "T a = va, b = vb, c = vc;";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.LocalDeclarationStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var ds = (LocalDeclarationStatementSyntax)statement;
            CustomAssert.Equal(0, ds.Modifiers.Count);
            CustomAssert.NotNull(ds.Declaration.Type);
            CustomAssert.Equal("T", ds.Declaration.Type.ToString());
            CustomAssert.Equal(3, ds.Declaration.Variables.Count);

            CustomAssert.NotEqual(default, ds.Declaration.Variables[0].Identifier);
            CustomAssert.Equal("a", ds.Declaration.Variables[0].Identifier.ToString());
            CustomAssert.Null(ds.Declaration.Variables[0].ArgumentList);
            CustomAssert.NotEqual(default, ds.Declaration.Variables[0].Initializer.EqualsToken);
            CustomAssert.False(ds.Declaration.Variables[0].Initializer.EqualsToken.IsMissing);
            CustomAssert.NotNull(ds.Declaration.Variables[0].Initializer.Value);
            CustomAssert.Equal("va", ds.Declaration.Variables[0].Initializer.Value.ToString());

            CustomAssert.NotEqual(default, ds.Declaration.Variables[1].Identifier);
            CustomAssert.Equal("b", ds.Declaration.Variables[1].Identifier.ToString());
            CustomAssert.Null(ds.Declaration.Variables[1].ArgumentList);
            CustomAssert.NotEqual(default, ds.Declaration.Variables[1].Initializer.EqualsToken);
            CustomAssert.False(ds.Declaration.Variables[1].Initializer.EqualsToken.IsMissing);
            CustomAssert.NotNull(ds.Declaration.Variables[1].Initializer.Value);
            CustomAssert.Equal("vb", ds.Declaration.Variables[1].Initializer.Value.ToString());

            CustomAssert.NotEqual(default, ds.Declaration.Variables[2].Identifier);
            CustomAssert.Equal("c", ds.Declaration.Variables[2].Identifier.ToString());
            CustomAssert.Null(ds.Declaration.Variables[2].ArgumentList);
            CustomAssert.NotEqual(default, ds.Declaration.Variables[2].Initializer.EqualsToken);
            CustomAssert.False(ds.Declaration.Variables[2].Initializer.EqualsToken.IsMissing);
            CustomAssert.NotNull(ds.Declaration.Variables[2].Initializer.Value);
            CustomAssert.Equal("vc", ds.Declaration.Variables[2].Initializer.Value.ToString());

            CustomAssert.NotEqual(default, ds.SemicolonToken);
            CustomAssert.False(ds.SemicolonToken.IsMissing);
        }

        [Fact]
        public void TestLocalDeclarationStatementWithArrayInitializer()
        {
            var text = "T a = {b, c};";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.LocalDeclarationStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var ds = (LocalDeclarationStatementSyntax)statement;
            CustomAssert.Equal(0, ds.Modifiers.Count);
            CustomAssert.NotNull(ds.Declaration.Type);
            CustomAssert.Equal("T", ds.Declaration.Type.ToString());
            CustomAssert.Equal(1, ds.Declaration.Variables.Count);

            CustomAssert.NotEqual(default, ds.Declaration.Variables[0].Identifier);
            CustomAssert.Equal("a", ds.Declaration.Variables[0].Identifier.ToString());
            CustomAssert.Null(ds.Declaration.Variables[0].ArgumentList);
            CustomAssert.NotNull(ds.Declaration.Variables[0].Initializer);
            CustomAssert.NotEqual(default, ds.Declaration.Variables[0].Initializer.EqualsToken);
            CustomAssert.False(ds.Declaration.Variables[0].Initializer.EqualsToken.IsMissing);
            CustomAssert.NotNull(ds.Declaration.Variables[0].Initializer.Value);
            CustomAssert.Equal(SyntaxKind.ArrayInitializerExpression, ds.Declaration.Variables[0].Initializer.Value.Kind());
            CustomAssert.Equal("{b, c}", ds.Declaration.Variables[0].Initializer.Value.ToString());

            CustomAssert.NotEqual(default, ds.SemicolonToken);
            CustomAssert.False(ds.SemicolonToken.IsMissing);
        }

        [Fact]
        public void TestConstLocalDeclarationStatement()
        {
            var text = "const T a = b;";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.LocalDeclarationStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var ds = (LocalDeclarationStatementSyntax)statement;
            CustomAssert.Equal(1, ds.Modifiers.Count);
            CustomAssert.Equal(SyntaxKind.ConstKeyword, ds.Modifiers[0].Kind());
            CustomAssert.NotNull(ds.Declaration.Type);
            CustomAssert.Equal("T", ds.Declaration.Type.ToString());
            CustomAssert.Equal(1, ds.Declaration.Variables.Count);

            CustomAssert.NotEqual(default, ds.Declaration.Variables[0].Identifier);
            CustomAssert.Equal("a", ds.Declaration.Variables[0].Identifier.ToString());
            CustomAssert.Null(ds.Declaration.Variables[0].ArgumentList);
            CustomAssert.NotNull(ds.Declaration.Variables[0].Initializer);
            CustomAssert.NotEqual(default, ds.Declaration.Variables[0].Initializer.EqualsToken);
            CustomAssert.False(ds.Declaration.Variables[0].Initializer.EqualsToken.IsMissing);
            CustomAssert.NotNull(ds.Declaration.Variables[0].Initializer.Value);
            CustomAssert.Equal("b", ds.Declaration.Variables[0].Initializer.Value.ToString());

            CustomAssert.NotEqual(default, ds.SemicolonToken);
            CustomAssert.False(ds.SemicolonToken.IsMissing);
        }

        [Fact]
        public void TestStaticLocalDeclarationStatement()
        {
            var text = "static T a = b;";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.LocalDeclarationStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(1, statement.Errors().Length);
            CustomAssert.Equal((int)ErrorCode.ERR_BadMemberFlag, statement.Errors()[0].Code);

            var ds = (LocalDeclarationStatementSyntax)statement;
            CustomAssert.Equal(1, ds.Modifiers.Count);
            CustomAssert.Equal(SyntaxKind.StaticKeyword, ds.Modifiers[0].Kind());
            CustomAssert.NotNull(ds.Declaration.Type);
            CustomAssert.Equal("T", ds.Declaration.Type.ToString());
            CustomAssert.Equal(1, ds.Declaration.Variables.Count);

            CustomAssert.NotEqual(default, ds.Declaration.Variables[0].Identifier);
            CustomAssert.Equal("a", ds.Declaration.Variables[0].Identifier.ToString());
            CustomAssert.Null(ds.Declaration.Variables[0].ArgumentList);
            CustomAssert.NotNull(ds.Declaration.Variables[0].Initializer);
            CustomAssert.NotEqual(default, ds.Declaration.Variables[0].Initializer.EqualsToken);
            CustomAssert.False(ds.Declaration.Variables[0].Initializer.EqualsToken.IsMissing);
            CustomAssert.NotNull(ds.Declaration.Variables[0].Initializer.Value);
            CustomAssert.Equal("b", ds.Declaration.Variables[0].Initializer.Value.ToString());

            CustomAssert.NotEqual(default, ds.SemicolonToken);
            CustomAssert.False(ds.SemicolonToken.IsMissing);
        }

        [Fact]
        public void TestReadOnlyLocalDeclarationStatement()
        {
            var text = "readonly T a = b;";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.LocalDeclarationStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(1, statement.Errors().Length);
            CustomAssert.Equal((int)ErrorCode.ERR_BadMemberFlag, statement.Errors()[0].Code);

            var ds = (LocalDeclarationStatementSyntax)statement;
            CustomAssert.Equal(1, ds.Modifiers.Count);
            CustomAssert.Equal(SyntaxKind.ReadOnlyKeyword, ds.Modifiers[0].Kind());
            CustomAssert.NotNull(ds.Declaration.Type);
            CustomAssert.Equal("T", ds.Declaration.Type.ToString());
            CustomAssert.Equal(1, ds.Declaration.Variables.Count);

            CustomAssert.NotEqual(default, ds.Declaration.Variables[0].Identifier);
            CustomAssert.Equal("a", ds.Declaration.Variables[0].Identifier.ToString());
            CustomAssert.Null(ds.Declaration.Variables[0].ArgumentList);
            CustomAssert.NotNull(ds.Declaration.Variables[0].Initializer);
            CustomAssert.NotEqual(default, ds.Declaration.Variables[0].Initializer.EqualsToken);
            CustomAssert.False(ds.Declaration.Variables[0].Initializer.EqualsToken.IsMissing);
            CustomAssert.NotNull(ds.Declaration.Variables[0].Initializer.Value);
            CustomAssert.Equal("b", ds.Declaration.Variables[0].Initializer.Value.ToString());

            CustomAssert.NotEqual(default, ds.SemicolonToken);
            CustomAssert.False(ds.SemicolonToken.IsMissing);
        }

        [Fact]
        public void TestVolatileLocalDeclarationStatement()
        {
            var text = "volatile T a = b;";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.LocalDeclarationStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(1, statement.Errors().Length);
            CustomAssert.Equal((int)ErrorCode.ERR_BadMemberFlag, statement.Errors()[0].Code);

            var ds = (LocalDeclarationStatementSyntax)statement;
            CustomAssert.Equal(1, ds.Modifiers.Count);
            CustomAssert.Equal(SyntaxKind.VolatileKeyword, ds.Modifiers[0].Kind());
            CustomAssert.NotNull(ds.Declaration.Type);
            CustomAssert.Equal("T", ds.Declaration.Type.ToString());
            CustomAssert.Equal(1, ds.Declaration.Variables.Count);

            CustomAssert.NotEqual(default, ds.Declaration.Variables[0].Identifier);
            CustomAssert.Equal("a", ds.Declaration.Variables[0].Identifier.ToString());
            CustomAssert.Null(ds.Declaration.Variables[0].ArgumentList);
            CustomAssert.NotNull(ds.Declaration.Variables[0].Initializer);
            CustomAssert.NotEqual(default, ds.Declaration.Variables[0].Initializer.EqualsToken);
            CustomAssert.False(ds.Declaration.Variables[0].Initializer.EqualsToken.IsMissing);
            CustomAssert.NotNull(ds.Declaration.Variables[0].Initializer.Value);
            CustomAssert.Equal("b", ds.Declaration.Variables[0].Initializer.Value.ToString());

            CustomAssert.NotEqual(default, ds.SemicolonToken);
            CustomAssert.False(ds.SemicolonToken.IsMissing);
        }

        [Fact]
        public void TestRefLocalDeclarationStatement()
        {
            var text = "ref T a;";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.LocalDeclarationStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var ds = (LocalDeclarationStatementSyntax)statement;
            CustomAssert.Equal(0, ds.Modifiers.Count);
            CustomAssert.NotNull(ds.Declaration.Type);
            CustomAssert.Equal("ref T", ds.Declaration.Type.ToString());
            CustomAssert.Equal(1, ds.Declaration.Variables.Count);

            CustomAssert.NotEqual(default, ds.Declaration.Variables[0].Identifier);
            CustomAssert.Equal("a", ds.Declaration.Variables[0].Identifier.ToString());
            CustomAssert.Null(ds.Declaration.Variables[0].ArgumentList);
            CustomAssert.Null(ds.Declaration.Variables[0].Initializer);

            CustomAssert.NotEqual(default, ds.SemicolonToken);
            CustomAssert.False(ds.SemicolonToken.IsMissing);
        }

        [Fact]
        public void TestRefLocalDeclarationStatementWithInitializer()
        {
            var text = "ref T a = ref b;";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.LocalDeclarationStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var ds = (LocalDeclarationStatementSyntax)statement;
            CustomAssert.Equal(0, ds.Modifiers.Count);
            CustomAssert.NotNull(ds.Declaration.Type);
            CustomAssert.Equal("ref T", ds.Declaration.Type.ToString());
            CustomAssert.Equal(1, ds.Declaration.Variables.Count);

            CustomAssert.NotEqual(default, ds.Declaration.Variables[0].Identifier);
            CustomAssert.Equal("a", ds.Declaration.Variables[0].Identifier.ToString());
            CustomAssert.Null(ds.Declaration.Variables[0].ArgumentList);
            var initializer = ds.Declaration.Variables[0].Initializer as EqualsValueClauseSyntax;
            CustomAssert.NotNull(initializer);
            CustomAssert.NotEqual(default, initializer.EqualsToken);
            CustomAssert.False(initializer.EqualsToken.IsMissing);
            CustomAssert.Equal(SyntaxKind.RefExpression, initializer.Value.Kind());
            CustomAssert.Equal("ref b", initializer.Value.ToString());

            CustomAssert.NotEqual(default, ds.SemicolonToken);
            CustomAssert.False(ds.SemicolonToken.IsMissing);
        }

        [Fact]
        public void TestRefLocalDeclarationStatementWithMultipleInitializers()
        {
            var text = "ref T a = ref b, c = ref d;";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.LocalDeclarationStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var ds = (LocalDeclarationStatementSyntax)statement;
            CustomAssert.Equal(0, ds.Modifiers.Count);
            CustomAssert.NotNull(ds.Declaration.Type);
            CustomAssert.Equal("ref T", ds.Declaration.Type.ToString());
            CustomAssert.Equal(2, ds.Declaration.Variables.Count);

            CustomAssert.NotEqual(default, ds.Declaration.Variables[0].Identifier);
            CustomAssert.Equal("a", ds.Declaration.Variables[0].Identifier.ToString());
            CustomAssert.Null(ds.Declaration.Variables[0].ArgumentList);
            var initializer = ds.Declaration.Variables[0].Initializer as EqualsValueClauseSyntax;
            CustomAssert.NotNull(initializer);
            CustomAssert.NotEqual(default, initializer.EqualsToken);
            CustomAssert.False(initializer.EqualsToken.IsMissing);
            CustomAssert.Equal(SyntaxKind.RefExpression, initializer.Value.Kind());
            CustomAssert.Equal("ref b", initializer.Value.ToString());

            CustomAssert.NotEqual(default, ds.Declaration.Variables[1].Identifier);
            CustomAssert.Equal("c", ds.Declaration.Variables[1].Identifier.ToString());
            CustomAssert.Null(ds.Declaration.Variables[1].ArgumentList);
            initializer = ds.Declaration.Variables[1].Initializer as EqualsValueClauseSyntax;
            CustomAssert.NotNull(initializer);
            CustomAssert.NotEqual(default, initializer.EqualsToken);
            CustomAssert.False(initializer.EqualsToken.IsMissing);
            CustomAssert.Equal(SyntaxKind.RefExpression, initializer.Value.Kind());
            CustomAssert.Equal("ref d", initializer.Value.ToString());

            CustomAssert.NotEqual(default, ds.SemicolonToken);
            CustomAssert.False(ds.SemicolonToken.IsMissing);
        }

        [Fact]
        public void TestFixedStatement()
        {
            var text = "fixed(T a = b) { }";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.FixedStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var fs = (FixedStatementSyntax)statement;
            CustomAssert.NotEqual(default, fs.FixedKeyword);
            CustomAssert.False(fs.FixedKeyword.IsMissing);
            CustomAssert.NotEqual(default, fs.OpenParenToken);
            CustomAssert.False(fs.FixedKeyword.IsMissing);
            CustomAssert.NotNull(fs.Declaration);
            CustomAssert.Equal(SyntaxKind.VariableDeclaration, fs.Declaration.Kind());
            CustomAssert.NotNull(fs.Declaration.Type);
            CustomAssert.Equal("T", fs.Declaration.Type.ToString());
            CustomAssert.Equal(1, fs.Declaration.Variables.Count);
            CustomAssert.Equal("a = b", fs.Declaration.Variables[0].ToString());
            CustomAssert.NotNull(fs.Statement);
            CustomAssert.Equal(SyntaxKind.Block, fs.Statement.Kind());
            CustomAssert.Equal("{ }", fs.Statement.ToString());
        }

        [Fact]
        public void TestFixedVarStatement()
        {
            var text = "fixed(var a = b) { }";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.FixedStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var fs = (FixedStatementSyntax)statement;
            CustomAssert.NotEqual(default, fs.FixedKeyword);
            CustomAssert.False(fs.FixedKeyword.IsMissing);
            CustomAssert.NotEqual(default, fs.OpenParenToken);
            CustomAssert.False(fs.FixedKeyword.IsMissing);
            CustomAssert.NotNull(fs.Declaration);
            CustomAssert.Equal(SyntaxKind.VariableDeclaration, fs.Declaration.Kind());
            CustomAssert.NotNull(fs.Declaration.Type);
            CustomAssert.Equal("var", fs.Declaration.Type.ToString());
            CustomAssert.True(fs.Declaration.Type.IsVar);
            CustomAssert.Equal(SyntaxKind.IdentifierName, fs.Declaration.Type.Kind());
            CustomAssert.Equal(SyntaxKind.IdentifierToken, ((IdentifierNameSyntax)fs.Declaration.Type).Identifier.Kind());
            CustomAssert.Equal(1, fs.Declaration.Variables.Count);
            CustomAssert.Equal("a = b", fs.Declaration.Variables[0].ToString());
            CustomAssert.NotNull(fs.Statement);
            CustomAssert.Equal(SyntaxKind.Block, fs.Statement.Kind());
            CustomAssert.Equal("{ }", fs.Statement.ToString());
        }

        [Fact]
        public void TestFixedStatementWithMultipleVariables()
        {
            var text = "fixed(T a = b, c = d) { }";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.FixedStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var fs = (FixedStatementSyntax)statement;
            CustomAssert.NotEqual(default, fs.FixedKeyword);
            CustomAssert.False(fs.FixedKeyword.IsMissing);
            CustomAssert.NotEqual(default, fs.OpenParenToken);
            CustomAssert.False(fs.FixedKeyword.IsMissing);
            CustomAssert.NotNull(fs.Declaration);
            CustomAssert.Equal(SyntaxKind.VariableDeclaration, fs.Declaration.Kind());
            CustomAssert.NotNull(fs.Declaration.Type);
            CustomAssert.Equal("T", fs.Declaration.Type.ToString());
            CustomAssert.Equal(2, fs.Declaration.Variables.Count);
            CustomAssert.Equal("a = b", fs.Declaration.Variables[0].ToString());
            CustomAssert.Equal("c = d", fs.Declaration.Variables[1].ToString());
            CustomAssert.NotNull(fs.Statement);
            CustomAssert.Equal(SyntaxKind.Block, fs.Statement.Kind());
            CustomAssert.Equal("{ }", fs.Statement.ToString());
        }

        [Fact]
        public void TestEmptyStatement()
        {
            var text = ";";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.EmptyStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var es = (EmptyStatementSyntax)statement;
            CustomAssert.NotEqual(default, es.SemicolonToken);
            CustomAssert.False(es.SemicolonToken.IsMissing);
        }

        [Fact]
        public void TestLabeledStatement()
        {
            var text = "label: ;";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.LabeledStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var ls = (LabeledStatementSyntax)statement;
            CustomAssert.NotEqual(default, ls.Identifier);
            CustomAssert.Equal("label", ls.Identifier.ToString());
            CustomAssert.NotEqual(default, ls.ColonToken);
            CustomAssert.Equal(SyntaxKind.ColonToken, ls.ColonToken.Kind());
            CustomAssert.NotNull(ls.Statement);
            CustomAssert.Equal(SyntaxKind.EmptyStatement, ls.Statement.Kind());
            CustomAssert.Equal(";", ls.Statement.ToString());
        }

        [Fact]
        public void TestBreakStatement()
        {
            var text = "break;";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.BreakStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var b = (BreakStatementSyntax)statement;
            CustomAssert.NotEqual(default, b.BreakKeyword);
            CustomAssert.False(b.BreakKeyword.IsMissing);
            CustomAssert.Equal(SyntaxKind.BreakKeyword, b.BreakKeyword.Kind());
            CustomAssert.NotEqual(default, b.SemicolonToken);
            CustomAssert.False(b.SemicolonToken.IsMissing);
        }

        [Fact]
        public void TestContinueStatement()
        {
            var text = "continue;";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.ContinueStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var cs = (ContinueStatementSyntax)statement;
            CustomAssert.NotEqual(default, cs.ContinueKeyword);
            CustomAssert.False(cs.ContinueKeyword.IsMissing);
            CustomAssert.Equal(SyntaxKind.ContinueKeyword, cs.ContinueKeyword.Kind());
            CustomAssert.NotEqual(default, cs.SemicolonToken);
            CustomAssert.False(cs.SemicolonToken.IsMissing);
        }

        [Fact]
        public void TestGotoStatement()
        {
            var text = "goto label;";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.GotoStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var gs = (GotoStatementSyntax)statement;
            CustomAssert.NotEqual(default, gs.GotoKeyword);
            CustomAssert.False(gs.GotoKeyword.IsMissing);
            CustomAssert.Equal(SyntaxKind.GotoKeyword, gs.GotoKeyword.Kind());
            CustomAssert.Equal(SyntaxKind.None, gs.CaseOrDefaultKeyword.Kind());
            CustomAssert.NotNull(gs.Expression);
            CustomAssert.Equal("label", gs.Expression.ToString());
            CustomAssert.NotEqual(default, gs.SemicolonToken);
            CustomAssert.False(gs.SemicolonToken.IsMissing);
        }

        [Fact]
        public void TestGotoCaseStatement()
        {
            var text = "goto case label;";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.GotoCaseStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var gs = (GotoStatementSyntax)statement;
            CustomAssert.NotEqual(default, gs.GotoKeyword);
            CustomAssert.False(gs.GotoKeyword.IsMissing);
            CustomAssert.Equal(SyntaxKind.GotoKeyword, gs.GotoKeyword.Kind());
            CustomAssert.NotEqual(default, gs.CaseOrDefaultKeyword);
            CustomAssert.False(gs.CaseOrDefaultKeyword.IsMissing);
            CustomAssert.Equal(SyntaxKind.CaseKeyword, gs.CaseOrDefaultKeyword.Kind());
            CustomAssert.NotNull(gs.Expression);
            CustomAssert.Equal("label", gs.Expression.ToString());
            CustomAssert.NotEqual(default, gs.SemicolonToken);
            CustomAssert.False(gs.SemicolonToken.IsMissing);
        }

        [Fact]
        public void TestGotoDefault()
        {
            var text = "goto default;";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.GotoDefaultStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var gs = (GotoStatementSyntax)statement;
            CustomAssert.NotEqual(default, gs.GotoKeyword);
            CustomAssert.False(gs.GotoKeyword.IsMissing);
            CustomAssert.Equal(SyntaxKind.GotoKeyword, gs.GotoKeyword.Kind());
            CustomAssert.NotEqual(default, gs.CaseOrDefaultKeyword);
            CustomAssert.False(gs.CaseOrDefaultKeyword.IsMissing);
            CustomAssert.Equal(SyntaxKind.DefaultKeyword, gs.CaseOrDefaultKeyword.Kind());
            CustomAssert.Null(gs.Expression);
            CustomAssert.NotEqual(default, gs.SemicolonToken);
            CustomAssert.False(gs.SemicolonToken.IsMissing);
        }

        [Fact]
        public void TestReturn()
        {
            var text = "return;";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.ReturnStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var rs = (ReturnStatementSyntax)statement;
            CustomAssert.NotEqual(default, rs.ReturnKeyword);
            CustomAssert.False(rs.ReturnKeyword.IsMissing);
            CustomAssert.Equal(SyntaxKind.ReturnKeyword, rs.ReturnKeyword.Kind());
            CustomAssert.Null(rs.Expression);
            CustomAssert.NotEqual(default, rs.SemicolonToken);
            CustomAssert.False(rs.SemicolonToken.IsMissing);
        }

        [Fact]
        public void TestReturnExpression()
        {
            var text = "return a;";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.ReturnStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var rs = (ReturnStatementSyntax)statement;
            CustomAssert.NotEqual(default, rs.ReturnKeyword);
            CustomAssert.False(rs.ReturnKeyword.IsMissing);
            CustomAssert.Equal(SyntaxKind.ReturnKeyword, rs.ReturnKeyword.Kind());
            CustomAssert.NotNull(rs.Expression);
            CustomAssert.Equal("a", rs.Expression.ToString());
            CustomAssert.NotEqual(default, rs.SemicolonToken);
            CustomAssert.False(rs.SemicolonToken.IsMissing);
        }

        [Fact]
        public void TestYieldReturnExpression()
        {
            var text = "yield return a;";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.YieldReturnStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var ys = (YieldStatementSyntax)statement;
            CustomAssert.NotEqual(default, ys.YieldKeyword);
            CustomAssert.False(ys.YieldKeyword.IsMissing);
            CustomAssert.Equal(SyntaxKind.YieldKeyword, ys.YieldKeyword.Kind());
            CustomAssert.NotEqual(default, ys.ReturnOrBreakKeyword);
            CustomAssert.False(ys.ReturnOrBreakKeyword.IsMissing);
            CustomAssert.Equal(SyntaxKind.ReturnKeyword, ys.ReturnOrBreakKeyword.Kind());
            CustomAssert.NotNull(ys.Expression);
            CustomAssert.Equal("a", ys.Expression.ToString());
            CustomAssert.NotEqual(default, ys.SemicolonToken);
            CustomAssert.False(ys.SemicolonToken.IsMissing);
        }

        [Fact]
        public void TestYieldBreakExpression()
        {
            var text = "yield break;";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.YieldBreakStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var ys = (YieldStatementSyntax)statement;
            CustomAssert.NotEqual(default, ys.YieldKeyword);
            CustomAssert.False(ys.YieldKeyword.IsMissing);
            CustomAssert.Equal(SyntaxKind.YieldKeyword, ys.YieldKeyword.Kind());
            CustomAssert.NotEqual(default, ys.ReturnOrBreakKeyword);
            CustomAssert.False(ys.ReturnOrBreakKeyword.IsMissing);
            CustomAssert.Equal(SyntaxKind.BreakKeyword, ys.ReturnOrBreakKeyword.Kind());
            CustomAssert.Null(ys.Expression);
            CustomAssert.NotEqual(default, ys.SemicolonToken);
            CustomAssert.False(ys.SemicolonToken.IsMissing);
        }

        [Fact]
        public void TestThrow()
        {
            var text = "throw;";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.ThrowStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var ts = (ThrowStatementSyntax)statement;
            CustomAssert.NotEqual(default, ts.ThrowKeyword);
            CustomAssert.False(ts.ThrowKeyword.IsMissing);
            CustomAssert.Equal(SyntaxKind.ThrowKeyword, ts.ThrowKeyword.ContextualKind());
            CustomAssert.Null(ts.Expression);
            CustomAssert.NotEqual(default, ts.SemicolonToken);
            CustomAssert.False(ts.SemicolonToken.IsMissing);
        }

        [Fact]
        public void TestThrowExpression()
        {
            var text = "throw a;";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.ThrowStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var ts = (ThrowStatementSyntax)statement;
            CustomAssert.NotEqual(default, ts.ThrowKeyword);
            CustomAssert.False(ts.ThrowKeyword.IsMissing);
            CustomAssert.Equal(SyntaxKind.ThrowKeyword, ts.ThrowKeyword.ContextualKind());
            CustomAssert.NotNull(ts.Expression);
            CustomAssert.Equal("a", ts.Expression.ToString());
            CustomAssert.NotEqual(default, ts.SemicolonToken);
            CustomAssert.False(ts.SemicolonToken.IsMissing);
        }

        [Fact]
        public void TestTryCatch()
        {
            var text = "try { } catch(T e) { }";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.TryStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var ts = (TryStatementSyntax)statement;
            CustomAssert.NotEqual(default, ts.TryKeyword);
            CustomAssert.False(ts.TryKeyword.IsMissing);
            CustomAssert.NotNull(ts.Block);

            CustomAssert.Equal(1, ts.Catches.Count);
            CustomAssert.NotEqual(default, ts.Catches[0].CatchKeyword);
            CustomAssert.NotNull(ts.Catches[0].Declaration);
            CustomAssert.NotEqual(default, ts.Catches[0].Declaration.OpenParenToken);
            CustomAssert.NotNull(ts.Catches[0].Declaration.Type);
            CustomAssert.Equal("T", ts.Catches[0].Declaration.Type.ToString());
            CustomAssert.NotEqual(default, ts.Catches[0].Declaration.Identifier);
            CustomAssert.Equal("e", ts.Catches[0].Declaration.Identifier.ToString());
            CustomAssert.NotEqual(default, ts.Catches[0].Declaration.CloseParenToken);
            CustomAssert.NotNull(ts.Catches[0].Block);

            CustomAssert.Null(ts.Finally);
        }

        [Fact]
        public void TestTryCatchWithNoExceptionName()
        {
            var text = "try { } catch(T) { }";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.TryStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var ts = (TryStatementSyntax)statement;
            CustomAssert.NotEqual(default, ts.TryKeyword);
            CustomAssert.False(ts.TryKeyword.IsMissing);
            CustomAssert.NotNull(ts.Block);

            CustomAssert.Equal(1, ts.Catches.Count);
            CustomAssert.NotEqual(default, ts.Catches[0].CatchKeyword);
            CustomAssert.NotNull(ts.Catches[0].Declaration);
            CustomAssert.NotEqual(default, ts.Catches[0].Declaration.OpenParenToken);
            CustomAssert.NotNull(ts.Catches[0].Declaration.Type);
            CustomAssert.Equal("T", ts.Catches[0].Declaration.Type.ToString());
            CustomAssert.Equal(SyntaxKind.None, ts.Catches[0].Declaration.Identifier.Kind());
            CustomAssert.NotEqual(default, ts.Catches[0].Declaration.CloseParenToken);
            CustomAssert.NotNull(ts.Catches[0].Block);

            CustomAssert.Null(ts.Finally);
        }

        [Fact]
        public void TestTryCatchWithNoExceptionDeclaration()
        {
            var text = "try { } catch { }";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.TryStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var ts = (TryStatementSyntax)statement;
            CustomAssert.NotEqual(default, ts.TryKeyword);
            CustomAssert.False(ts.TryKeyword.IsMissing);
            CustomAssert.NotNull(ts.Block);

            CustomAssert.Equal(1, ts.Catches.Count);
            CustomAssert.NotEqual(default, ts.Catches[0].CatchKeyword);
            CustomAssert.Null(ts.Catches[0].Declaration);
            CustomAssert.NotNull(ts.Catches[0].Block);

            CustomAssert.Null(ts.Finally);
        }

        [Fact]
        public void TestTryCatchWithMultipleCatches()
        {
            var text = "try { } catch(T e) { } catch(T2) { } catch { }";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.TryStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var ts = (TryStatementSyntax)statement;
            CustomAssert.NotEqual(default, ts.TryKeyword);
            CustomAssert.False(ts.TryKeyword.IsMissing);
            CustomAssert.NotNull(ts.Block);

            CustomAssert.Equal(3, ts.Catches.Count);

            CustomAssert.NotEqual(default, ts.Catches[0].CatchKeyword);
            CustomAssert.NotNull(ts.Catches[0].Declaration);
            CustomAssert.NotEqual(default, ts.Catches[0].Declaration.OpenParenToken);
            CustomAssert.NotNull(ts.Catches[0].Declaration.Type);
            CustomAssert.Equal("T", ts.Catches[0].Declaration.Type.ToString());
            CustomAssert.NotEqual(default, ts.Catches[0].Declaration.Identifier);
            CustomAssert.Equal("e", ts.Catches[0].Declaration.Identifier.ToString());
            CustomAssert.NotEqual(default, ts.Catches[0].Declaration.CloseParenToken);
            CustomAssert.NotNull(ts.Catches[0].Block);

            CustomAssert.NotEqual(default, ts.Catches[1].CatchKeyword);
            CustomAssert.NotNull(ts.Catches[1].Declaration);
            CustomAssert.NotEqual(default, ts.Catches[1].Declaration.OpenParenToken);
            CustomAssert.NotNull(ts.Catches[1].Declaration.Type);
            CustomAssert.Equal("T2", ts.Catches[1].Declaration.Type.ToString());
            CustomAssert.NotEqual(default, ts.Catches[1].Declaration.CloseParenToken);
            CustomAssert.NotNull(ts.Catches[1].Block);

            CustomAssert.NotEqual(default, ts.Catches[2].CatchKeyword);
            CustomAssert.Null(ts.Catches[2].Declaration);
            CustomAssert.NotNull(ts.Catches[2].Block);

            CustomAssert.Null(ts.Finally);
        }

        [Fact]
        public void TestTryFinally()
        {
            var text = "try { } finally { }";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.TryStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var ts = (TryStatementSyntax)statement;
            CustomAssert.NotEqual(default, ts.TryKeyword);
            CustomAssert.False(ts.TryKeyword.IsMissing);
            CustomAssert.NotNull(ts.Block);

            CustomAssert.Equal(0, ts.Catches.Count);

            CustomAssert.NotNull(ts.Finally);
            CustomAssert.NotEqual(default, ts.Finally.FinallyKeyword);
            CustomAssert.NotNull(ts.Finally.Block);
        }

        [Fact]
        public void TestTryCatchWithMultipleCatchesAndFinally()
        {
            var text = "try { } catch(T e) { } catch(T2) { } catch { } finally { }";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.TryStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var ts = (TryStatementSyntax)statement;
            CustomAssert.NotEqual(default, ts.TryKeyword);
            CustomAssert.False(ts.TryKeyword.IsMissing);
            CustomAssert.NotNull(ts.Block);

            CustomAssert.Equal(3, ts.Catches.Count);

            CustomAssert.NotEqual(default, ts.Catches[0].CatchKeyword);
            CustomAssert.NotNull(ts.Catches[0].Declaration);
            CustomAssert.NotEqual(default, ts.Catches[0].Declaration.OpenParenToken);
            CustomAssert.NotNull(ts.Catches[0].Declaration.Type);
            CustomAssert.Equal("T", ts.Catches[0].Declaration.Type.ToString());
            CustomAssert.NotEqual(default, ts.Catches[0].Declaration.Identifier);
            CustomAssert.Equal("e", ts.Catches[0].Declaration.Identifier.ToString());
            CustomAssert.NotEqual(default, ts.Catches[0].Declaration.CloseParenToken);
            CustomAssert.NotNull(ts.Catches[0].Block);

            CustomAssert.NotEqual(default, ts.Catches[1].CatchKeyword);
            CustomAssert.NotNull(ts.Catches[1].Declaration);
            CustomAssert.NotEqual(default, ts.Catches[1].Declaration.OpenParenToken);
            CustomAssert.NotNull(ts.Catches[1].Declaration.Type);
            CustomAssert.Equal("T2", ts.Catches[1].Declaration.Type.ToString());
            CustomAssert.NotEqual(default, ts.Catches[1].Declaration.CloseParenToken);
            CustomAssert.NotNull(ts.Catches[1].Block);

            CustomAssert.NotEqual(default, ts.Catches[2].CatchKeyword);
            CustomAssert.Null(ts.Catches[2].Declaration);
            CustomAssert.NotNull(ts.Catches[2].Block);

            CustomAssert.NotNull(ts.Finally);
            CustomAssert.NotEqual(default, ts.Finally.FinallyKeyword);
            CustomAssert.NotNull(ts.Finally.Block);
        }

        [Fact]
        public void TestChecked()
        {
            var text = "checked { }";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.CheckedStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var cs = (CheckedStatementSyntax)statement;
            CustomAssert.NotEqual(default, cs.Keyword);
            CustomAssert.Equal(SyntaxKind.CheckedKeyword, cs.Keyword.Kind());
            CustomAssert.NotNull(cs.Block);
        }

        [Fact]
        public void TestUnchecked()
        {
            var text = "unchecked { }";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.UncheckedStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var cs = (CheckedStatementSyntax)statement;
            CustomAssert.NotEqual(default, cs.Keyword);
            CustomAssert.Equal(SyntaxKind.UncheckedKeyword, cs.Keyword.Kind());
            CustomAssert.NotNull(cs.Block);
        }

        [Fact]
        public void TestUnsafe()
        {
            var text = "unsafe { }";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.UnsafeStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var us = (UnsafeStatementSyntax)statement;
            CustomAssert.NotEqual(default, us.UnsafeKeyword);
            CustomAssert.Equal(SyntaxKind.UnsafeKeyword, us.UnsafeKeyword.Kind());
            CustomAssert.NotNull(us.Block);
        }

        [Fact]
        public void TestWhile()
        {
            var text = "while(a) { }";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.WhileStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var ws = (WhileStatementSyntax)statement;
            CustomAssert.NotEqual(default, ws.WhileKeyword);
            CustomAssert.Equal(SyntaxKind.WhileKeyword, ws.WhileKeyword.Kind());
            CustomAssert.NotEqual(default, ws.OpenParenToken);
            CustomAssert.NotNull(ws.Condition);
            CustomAssert.NotEqual(default, ws.CloseParenToken);
            CustomAssert.Equal("a", ws.Condition.ToString());
            CustomAssert.NotNull(ws.Statement);
            CustomAssert.Equal(SyntaxKind.Block, ws.Statement.Kind());
        }

        [Fact]
        public void TestDoWhile()
        {
            var text = "do { } while (a);";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.DoStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var ds = (DoStatementSyntax)statement;
            CustomAssert.NotEqual(default, ds.DoKeyword);
            CustomAssert.Equal(SyntaxKind.DoKeyword, ds.DoKeyword.Kind());
            CustomAssert.NotNull(ds.Statement);
            CustomAssert.NotEqual(default, ds.WhileKeyword);
            CustomAssert.Equal(SyntaxKind.WhileKeyword, ds.WhileKeyword.Kind());
            CustomAssert.Equal(SyntaxKind.Block, ds.Statement.Kind());
            CustomAssert.NotEqual(default, ds.OpenParenToken);
            CustomAssert.NotNull(ds.Condition);
            CustomAssert.NotEqual(default, ds.CloseParenToken);
            CustomAssert.Equal("a", ds.Condition.ToString());
            CustomAssert.NotEqual(default, ds.SemicolonToken);
        }

        [Fact]
        public void TestFor()
        {
            var text = "for(;;) { }";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.ForStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var fs = (ForStatementSyntax)statement;
            CustomAssert.NotEqual(default, fs.ForKeyword);
            CustomAssert.False(fs.ForKeyword.IsMissing);
            CustomAssert.Equal(SyntaxKind.ForKeyword, fs.ForKeyword.Kind());
            CustomAssert.NotEqual(default, fs.OpenParenToken);
            CustomAssert.Null(fs.Declaration);
            CustomAssert.Equal(0, fs.Initializers.Count);
            CustomAssert.NotEqual(default, fs.FirstSemicolonToken);
            CustomAssert.Null(fs.Condition);
            CustomAssert.NotEqual(default, fs.SecondSemicolonToken);
            CustomAssert.Equal(0, fs.Incrementors.Count);
            CustomAssert.NotEqual(default, fs.CloseParenToken);
            CustomAssert.NotNull(fs.Statement);
        }

        [Fact]
        public void TestForWithVariableDeclaration()
        {
            var text = "for(T a = 0;;) { }";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.ForStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var fs = (ForStatementSyntax)statement;
            CustomAssert.NotEqual(default, fs.ForKeyword);
            CustomAssert.False(fs.ForKeyword.IsMissing);
            CustomAssert.Equal(SyntaxKind.ForKeyword, fs.ForKeyword.Kind());
            CustomAssert.NotEqual(default, fs.OpenParenToken);

            CustomAssert.NotNull(fs.Declaration);
            CustomAssert.NotNull(fs.Declaration.Type);
            CustomAssert.Equal("T", fs.Declaration.Type.ToString());
            CustomAssert.Equal(1, fs.Declaration.Variables.Count);
            CustomAssert.NotEqual(default, fs.Declaration.Variables[0].Identifier);
            CustomAssert.Equal("a", fs.Declaration.Variables[0].Identifier.ToString());
            CustomAssert.NotNull(fs.Declaration.Variables[0].Initializer);
            CustomAssert.NotEqual(default, fs.Declaration.Variables[0].Initializer.EqualsToken);
            CustomAssert.NotNull(fs.Declaration.Variables[0].Initializer.Value);
            CustomAssert.Equal("0", fs.Declaration.Variables[0].Initializer.Value.ToString());

            CustomAssert.Equal(0, fs.Initializers.Count);
            CustomAssert.NotEqual(default, fs.FirstSemicolonToken);
            CustomAssert.Null(fs.Condition);
            CustomAssert.NotEqual(default, fs.SecondSemicolonToken);
            CustomAssert.Equal(0, fs.Incrementors.Count);
            CustomAssert.NotEqual(default, fs.CloseParenToken);
            CustomAssert.NotNull(fs.Statement);
        }

        [Fact]
        public void TestForWithVarDeclaration()
        {
            var text = "for(var a = 0;;) { }";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.ForStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var fs = (ForStatementSyntax)statement;
            CustomAssert.NotEqual(default, fs.ForKeyword);
            CustomAssert.False(fs.ForKeyword.IsMissing);
            CustomAssert.Equal(SyntaxKind.ForKeyword, fs.ForKeyword.Kind());
            CustomAssert.NotEqual(default, fs.OpenParenToken);

            CustomAssert.NotNull(fs.Declaration);
            CustomAssert.NotNull(fs.Declaration.Type);
            CustomAssert.Equal("var", fs.Declaration.Type.ToString());
            CustomAssert.Equal(SyntaxKind.IdentifierName, fs.Declaration.Type.Kind());
            CustomAssert.Equal(SyntaxKind.IdentifierToken, ((IdentifierNameSyntax)fs.Declaration.Type).Identifier.Kind());
            CustomAssert.Equal(1, fs.Declaration.Variables.Count);
            CustomAssert.NotEqual(default, fs.Declaration.Variables[0].Identifier);
            CustomAssert.Equal("a", fs.Declaration.Variables[0].Identifier.ToString());
            CustomAssert.NotNull(fs.Declaration.Variables[0].Initializer);
            CustomAssert.NotEqual(default, fs.Declaration.Variables[0].Initializer.EqualsToken);
            CustomAssert.NotNull(fs.Declaration.Variables[0].Initializer.Value);
            CustomAssert.Equal("0", fs.Declaration.Variables[0].Initializer.Value.ToString());

            CustomAssert.Equal(0, fs.Initializers.Count);
            CustomAssert.NotEqual(default, fs.FirstSemicolonToken);
            CustomAssert.Null(fs.Condition);
            CustomAssert.NotEqual(default, fs.SecondSemicolonToken);
            CustomAssert.Equal(0, fs.Incrementors.Count);
            CustomAssert.NotEqual(default, fs.CloseParenToken);
            CustomAssert.NotNull(fs.Statement);
        }

        [Fact]
        public void TestForWithMultipleVariableDeclarations()
        {
            var text = "for(T a = 0, b = 1;;) { }";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.ForStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var fs = (ForStatementSyntax)statement;
            CustomAssert.NotEqual(default, fs.ForKeyword);
            CustomAssert.False(fs.ForKeyword.IsMissing);
            CustomAssert.Equal(SyntaxKind.ForKeyword, fs.ForKeyword.Kind());
            CustomAssert.NotEqual(default, fs.OpenParenToken);

            CustomAssert.NotNull(fs.Declaration);
            CustomAssert.NotNull(fs.Declaration.Type);
            CustomAssert.Equal("T", fs.Declaration.Type.ToString());
            CustomAssert.Equal(2, fs.Declaration.Variables.Count);

            CustomAssert.NotEqual(default, fs.Declaration.Variables[0].Identifier);
            CustomAssert.Equal("a", fs.Declaration.Variables[0].Identifier.ToString());
            CustomAssert.NotNull(fs.Declaration.Variables[0].Initializer);
            CustomAssert.NotEqual(default, fs.Declaration.Variables[0].Initializer.EqualsToken);
            CustomAssert.NotNull(fs.Declaration.Variables[0].Initializer.Value);
            CustomAssert.Equal("0", fs.Declaration.Variables[0].Initializer.Value.ToString());

            CustomAssert.NotEqual(default, fs.Declaration.Variables[1].Identifier);
            CustomAssert.Equal("b", fs.Declaration.Variables[1].Identifier.ToString());
            CustomAssert.NotNull(fs.Declaration.Variables[1].Initializer);
            CustomAssert.NotEqual(default, fs.Declaration.Variables[1].Initializer.EqualsToken);
            CustomAssert.NotNull(fs.Declaration.Variables[1].Initializer.Value);
            CustomAssert.Equal("1", fs.Declaration.Variables[1].Initializer.Value.ToString());

            CustomAssert.Equal(0, fs.Initializers.Count);
            CustomAssert.NotEqual(default, fs.FirstSemicolonToken);
            CustomAssert.Null(fs.Condition);
            CustomAssert.NotEqual(default, fs.SecondSemicolonToken);
            CustomAssert.Equal(0, fs.Incrementors.Count);
            CustomAssert.NotEqual(default, fs.CloseParenToken);
            CustomAssert.NotNull(fs.Statement);
        }

        [Fact, CompilerTrait(CompilerFeature.RefLocalsReturns)]
        public void TestForWithRefVariableDeclaration()
        {
            var text = "for(ref T a = ref b, c = ref d;;) { }";
            var statement = this.ParseStatement(text);

            UsingNode(statement);
            N(SyntaxKind.ForStatement);
            {
                N(SyntaxKind.ForKeyword);
                N(SyntaxKind.OpenParenToken);
                N(SyntaxKind.VariableDeclaration);
                {
                    N(SyntaxKind.RefType);
                    {
                        N(SyntaxKind.RefKeyword);
                        N(SyntaxKind.IdentifierName);
                        {
                            N(SyntaxKind.IdentifierToken, "T");
                        }
                    }
                    N(SyntaxKind.VariableDeclarator);
                    {
                        N(SyntaxKind.IdentifierToken, "a");
                        N(SyntaxKind.EqualsValueClause);
                        {
                            N(SyntaxKind.EqualsToken);
                            N(SyntaxKind.RefExpression);
                            {
                                N(SyntaxKind.RefKeyword);
                                N(SyntaxKind.IdentifierName);
                                {
                                    N(SyntaxKind.IdentifierToken, "b");
                                }
                            }
                        }
                    }
                    N(SyntaxKind.CommaToken);
                    N(SyntaxKind.VariableDeclarator);
                    {
                        N(SyntaxKind.IdentifierToken, "c");
                        N(SyntaxKind.EqualsValueClause);
                        {
                            N(SyntaxKind.EqualsToken);
                            N(SyntaxKind.RefExpression);
                            {
                                N(SyntaxKind.RefKeyword);
                                N(SyntaxKind.IdentifierName);
                                {
                                    N(SyntaxKind.IdentifierToken, "d");
                                }
                            }
                        }
                    }
                }
                N(SyntaxKind.SemicolonToken);
                N(SyntaxKind.SemicolonToken);
                N(SyntaxKind.CloseParenToken);
                N(SyntaxKind.Block);
                N(SyntaxKind.OpenBraceToken);
                N(SyntaxKind.CloseBraceToken);
            }
        }

        [Fact]
        public void TestForWithVariableInitializer()
        {
            var text = "for(a = 0;;) { }";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.ForStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var fs = (ForStatementSyntax)statement;
            CustomAssert.NotEqual(default, fs.ForKeyword);
            CustomAssert.False(fs.ForKeyword.IsMissing);
            CustomAssert.Equal(SyntaxKind.ForKeyword, fs.ForKeyword.Kind());
            CustomAssert.NotEqual(default, fs.OpenParenToken);

            CustomAssert.Null(fs.Declaration);
            CustomAssert.Equal(1, fs.Initializers.Count);
            CustomAssert.Equal("a = 0", fs.Initializers[0].ToString());

            CustomAssert.NotEqual(default, fs.FirstSemicolonToken);
            CustomAssert.Null(fs.Condition);
            CustomAssert.NotEqual(default, fs.SecondSemicolonToken);
            CustomAssert.Equal(0, fs.Incrementors.Count);
            CustomAssert.NotEqual(default, fs.CloseParenToken);
            CustomAssert.NotNull(fs.Statement);
        }

        [Fact]
        public void TestForWithMultipleVariableInitializers()
        {
            var text = "for(a = 0, b = 1;;) { }";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.ForStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var fs = (ForStatementSyntax)statement;
            CustomAssert.NotEqual(default, fs.ForKeyword);
            CustomAssert.False(fs.ForKeyword.IsMissing);
            CustomAssert.Equal(SyntaxKind.ForKeyword, fs.ForKeyword.Kind());
            CustomAssert.NotEqual(default, fs.OpenParenToken);

            CustomAssert.Null(fs.Declaration);
            CustomAssert.Equal(2, fs.Initializers.Count);
            CustomAssert.Equal("a = 0", fs.Initializers[0].ToString());
            CustomAssert.Equal("b = 1", fs.Initializers[1].ToString());

            CustomAssert.NotEqual(default, fs.FirstSemicolonToken);
            CustomAssert.Null(fs.Condition);
            CustomAssert.NotEqual(default, fs.SecondSemicolonToken);
            CustomAssert.Equal(0, fs.Incrementors.Count);
            CustomAssert.NotEqual(default, fs.CloseParenToken);
            CustomAssert.NotNull(fs.Statement);
        }

        [Fact]
        public void TestForWithCondition()
        {
            var text = "for(; a;) { }";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.ForStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var fs = (ForStatementSyntax)statement;
            CustomAssert.NotEqual(default, fs.ForKeyword);
            CustomAssert.False(fs.ForKeyword.IsMissing);
            CustomAssert.Equal(SyntaxKind.ForKeyword, fs.ForKeyword.Kind());
            CustomAssert.NotEqual(default, fs.OpenParenToken);

            CustomAssert.Null(fs.Declaration);
            CustomAssert.Equal(0, fs.Initializers.Count);
            CustomAssert.NotEqual(default, fs.FirstSemicolonToken);

            CustomAssert.NotNull(fs.Condition);
            CustomAssert.Equal("a", fs.Condition.ToString());

            CustomAssert.NotEqual(default, fs.SecondSemicolonToken);
            CustomAssert.Equal(0, fs.Incrementors.Count);
            CustomAssert.NotEqual(default, fs.CloseParenToken);
            CustomAssert.NotNull(fs.Statement);
        }

        [Fact]
        public void TestForWithIncrementor()
        {
            var text = "for(; ; a++) { }";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.ForStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var fs = (ForStatementSyntax)statement;
            CustomAssert.NotEqual(default, fs.ForKeyword);
            CustomAssert.False(fs.ForKeyword.IsMissing);
            CustomAssert.Equal(SyntaxKind.ForKeyword, fs.ForKeyword.Kind());
            CustomAssert.NotEqual(default, fs.OpenParenToken);

            CustomAssert.Null(fs.Declaration);
            CustomAssert.Equal(0, fs.Initializers.Count);
            CustomAssert.NotEqual(default, fs.FirstSemicolonToken);
            CustomAssert.Null(fs.Condition);
            CustomAssert.NotEqual(default, fs.SecondSemicolonToken);

            CustomAssert.Equal(1, fs.Incrementors.Count);
            CustomAssert.Equal("a++", fs.Incrementors[0].ToString());

            CustomAssert.NotEqual(default, fs.CloseParenToken);
            CustomAssert.NotNull(fs.Statement);
        }

        [Fact]
        public void TestForWithMultipleIncrementors()
        {
            var text = "for(; ; a++, b++) { }";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.ForStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var fs = (ForStatementSyntax)statement;
            CustomAssert.NotEqual(default, fs.ForKeyword);
            CustomAssert.False(fs.ForKeyword.IsMissing);
            CustomAssert.Equal(SyntaxKind.ForKeyword, fs.ForKeyword.Kind());
            CustomAssert.NotEqual(default, fs.OpenParenToken);

            CustomAssert.Null(fs.Declaration);
            CustomAssert.Equal(0, fs.Initializers.Count);
            CustomAssert.NotEqual(default, fs.FirstSemicolonToken);
            CustomAssert.Null(fs.Condition);
            CustomAssert.NotEqual(default, fs.SecondSemicolonToken);

            CustomAssert.Equal(2, fs.Incrementors.Count);
            CustomAssert.Equal("a++", fs.Incrementors[0].ToString());
            CustomAssert.Equal("b++", fs.Incrementors[1].ToString());

            CustomAssert.NotEqual(default, fs.CloseParenToken);
            CustomAssert.NotNull(fs.Statement);
        }

        [Fact]
        public void TestForWithDeclarationConditionAndIncrementor()
        {
            var text = "for(T a = 0; a < 10; a++) { }";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.ForStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var fs = (ForStatementSyntax)statement;
            CustomAssert.NotEqual(default, fs.ForKeyword);
            CustomAssert.False(fs.ForKeyword.IsMissing);
            CustomAssert.Equal(SyntaxKind.ForKeyword, fs.ForKeyword.Kind());
            CustomAssert.NotEqual(default, fs.OpenParenToken);

            CustomAssert.NotNull(fs.Declaration);
            CustomAssert.NotNull(fs.Declaration.Type);
            CustomAssert.Equal("T", fs.Declaration.Type.ToString());
            CustomAssert.Equal(1, fs.Declaration.Variables.Count);
            CustomAssert.NotEqual(default, fs.Declaration.Variables[0].Identifier);
            CustomAssert.Equal("a", fs.Declaration.Variables[0].Identifier.ToString());
            CustomAssert.NotNull(fs.Declaration.Variables[0].Initializer);
            CustomAssert.NotEqual(default, fs.Declaration.Variables[0].Initializer.EqualsToken);
            CustomAssert.NotNull(fs.Declaration.Variables[0].Initializer.Value);
            CustomAssert.Equal("0", fs.Declaration.Variables[0].Initializer.Value.ToString());

            CustomAssert.Equal(0, fs.Initializers.Count);

            CustomAssert.NotEqual(default, fs.FirstSemicolonToken);
            CustomAssert.NotNull(fs.Condition);
            CustomAssert.Equal("a < 10", fs.Condition.ToString());

            CustomAssert.NotEqual(default, fs.SecondSemicolonToken);

            CustomAssert.Equal(1, fs.Incrementors.Count);
            CustomAssert.Equal("a++", fs.Incrementors[0].ToString());

            CustomAssert.NotEqual(default, fs.CloseParenToken);
            CustomAssert.NotNull(fs.Statement);
        }

        [Fact]
        public void TestForEach()
        {
            var text = "foreach(T a in b) { }";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.ForEachStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var fs = (ForEachStatementSyntax)statement;
            CustomAssert.NotEqual(default, fs.ForEachKeyword);
            CustomAssert.Equal(SyntaxKind.ForEachKeyword, fs.ForEachKeyword.Kind());

            CustomAssert.NotEqual(default, fs.OpenParenToken);
            CustomAssert.NotNull(fs.Type);
            CustomAssert.Equal("T", fs.Type.ToString());
            CustomAssert.NotEqual(default, fs.Identifier);
            CustomAssert.Equal("a", fs.Identifier.ToString());
            CustomAssert.NotEqual(default, fs.InKeyword);
            CustomAssert.False(fs.InKeyword.IsMissing);
            CustomAssert.Equal(SyntaxKind.InKeyword, fs.InKeyword.Kind());
            CustomAssert.NotNull(fs.Expression);
            CustomAssert.Equal("b", fs.Expression.ToString());
            CustomAssert.NotEqual(default, fs.CloseParenToken);
            CustomAssert.NotNull(fs.Statement);
        }

        [Fact]
        public void TestForAsForEach()
        {
            var text = "for(T a in b) { }";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.ForEachStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(1, statement.Errors().Length);

            var fs = (ForEachStatementSyntax)statement;
            CustomAssert.NotEqual(default, fs.ForEachKeyword);
            CustomAssert.Equal(SyntaxKind.ForEachKeyword, fs.ForEachKeyword.Kind());
            CustomAssert.True(fs.ForEachKeyword.IsMissing);
            CustomAssert.Equal(1, fs.ForEachKeyword.TrailingTrivia.Count);
            CustomAssert.Equal(SyntaxKind.SkippedTokensTrivia, fs.ForEachKeyword.TrailingTrivia[0].Kind());
            CustomAssert.Equal("for", fs.ForEachKeyword.TrailingTrivia[0].ToString());

            CustomAssert.NotEqual(default, fs.OpenParenToken);
            CustomAssert.NotNull(fs.Type);
            CustomAssert.Equal("T", fs.Type.ToString());
            CustomAssert.NotEqual(default, fs.Identifier);
            CustomAssert.Equal("a", fs.Identifier.ToString());
            CustomAssert.NotEqual(default, fs.InKeyword);
            CustomAssert.False(fs.InKeyword.IsMissing);
            CustomAssert.Equal(SyntaxKind.InKeyword, fs.InKeyword.Kind());
            CustomAssert.NotNull(fs.Expression);
            CustomAssert.Equal("b", fs.Expression.ToString());
            CustomAssert.NotEqual(default, fs.CloseParenToken);
            CustomAssert.NotNull(fs.Statement);
        }

        [Fact]
        public void TestForEachWithVar()
        {
            var text = "foreach(var a in b) { }";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.ForEachStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var fs = (ForEachStatementSyntax)statement;
            CustomAssert.NotEqual(default, fs.ForEachKeyword);
            CustomAssert.Equal(SyntaxKind.ForEachKeyword, fs.ForEachKeyword.Kind());

            CustomAssert.NotEqual(default, fs.OpenParenToken);
            CustomAssert.NotNull(fs.Type);
            CustomAssert.Equal("var", fs.Type.ToString());
            CustomAssert.Equal(SyntaxKind.IdentifierName, fs.Type.Kind());
            CustomAssert.Equal(SyntaxKind.IdentifierToken, ((IdentifierNameSyntax)fs.Type).Identifier.Kind());
            CustomAssert.NotEqual(default, fs.Identifier);
            CustomAssert.Equal("a", fs.Identifier.ToString());
            CustomAssert.NotEqual(default, fs.InKeyword);
            CustomAssert.False(fs.InKeyword.IsMissing);
            CustomAssert.Equal(SyntaxKind.InKeyword, fs.InKeyword.Kind());
            CustomAssert.NotNull(fs.Expression);
            CustomAssert.Equal("b", fs.Expression.ToString());
            CustomAssert.NotEqual(default, fs.CloseParenToken);
            CustomAssert.NotNull(fs.Statement);
        }

        [Fact]
        public void TestIf()
        {
            var text = "if (a) { }";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.IfStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var ss = (IfStatementSyntax)statement;
            CustomAssert.NotEqual(default, ss.IfKeyword);
            CustomAssert.Equal(SyntaxKind.IfKeyword, ss.IfKeyword.Kind());
            CustomAssert.NotEqual(default, ss.OpenParenToken);
            CustomAssert.NotNull(ss.Condition);
            CustomAssert.Equal("a", ss.Condition.ToString());
            CustomAssert.NotEqual(default, ss.CloseParenToken);
            CustomAssert.NotNull(ss.Statement);

            CustomAssert.Null(ss.Else);
        }

        [Fact]
        public void TestIfElse()
        {
            var text = "if (a) { } else { }";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.IfStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var ss = (IfStatementSyntax)statement;
            CustomAssert.NotEqual(default, ss.IfKeyword);
            CustomAssert.Equal(SyntaxKind.IfKeyword, ss.IfKeyword.Kind());
            CustomAssert.NotEqual(default, ss.OpenParenToken);
            CustomAssert.NotNull(ss.Condition);
            CustomAssert.Equal("a", ss.Condition.ToString());
            CustomAssert.NotEqual(default, ss.CloseParenToken);
            CustomAssert.NotNull(ss.Statement);

            CustomAssert.NotNull(ss.Else);
            CustomAssert.NotEqual(default, ss.Else.ElseKeyword);
            CustomAssert.Equal(SyntaxKind.ElseKeyword, ss.Else.ElseKeyword.Kind());
            CustomAssert.NotNull(ss.Else.Statement);
        }

        [Fact]
        public void TestIfElseIf()
        {
            var text = "if (a) { } else if (b) { }";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.IfStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var ss = (IfStatementSyntax)statement;
            CustomAssert.NotEqual(default, ss.IfKeyword);
            CustomAssert.Equal(SyntaxKind.IfKeyword, ss.IfKeyword.Kind());
            CustomAssert.NotEqual(default, ss.OpenParenToken);
            CustomAssert.NotNull(ss.Condition);
            CustomAssert.Equal("a", ss.Condition.ToString());
            CustomAssert.NotEqual(default, ss.CloseParenToken);
            CustomAssert.NotNull(ss.Statement);

            CustomAssert.NotNull(ss.Else);
            CustomAssert.NotEqual(default, ss.Else.ElseKeyword);
            CustomAssert.Equal(SyntaxKind.ElseKeyword, ss.Else.ElseKeyword.Kind());
            CustomAssert.NotNull(ss.Else.Statement);

            var subIf = (IfStatementSyntax)ss.Else.Statement;
            CustomAssert.NotEqual(default, subIf.IfKeyword);
            CustomAssert.Equal(SyntaxKind.IfKeyword, subIf.IfKeyword.Kind());
            CustomAssert.NotNull(subIf.Condition);
            CustomAssert.Equal("b", subIf.Condition.ToString());
            CustomAssert.NotEqual(default, subIf.CloseParenToken);
            CustomAssert.NotNull(subIf.Statement);
        }

        [Fact]
        public void TestLock()
        {
            var text = "lock (a) { }";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.LockStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var ls = (LockStatementSyntax)statement;
            CustomAssert.NotEqual(default, ls.LockKeyword);
            CustomAssert.Equal(SyntaxKind.LockKeyword, ls.LockKeyword.Kind());
            CustomAssert.NotEqual(default, ls.OpenParenToken);
            CustomAssert.NotNull(ls.Expression);
            CustomAssert.Equal("a", ls.Expression.ToString());
            CustomAssert.NotEqual(default, ls.CloseParenToken);
            CustomAssert.NotNull(ls.Statement);
        }

        [Fact]
        public void TestSwitch()
        {
            var text = "switch (a) { }";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.SwitchStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);
            var diags = statement.ErrorsAndWarnings();
            CustomAssert.Equal(0, diags.Length);

            var ss = (SwitchStatementSyntax)statement;
            CustomAssert.NotEqual(default, ss.SwitchKeyword);
            CustomAssert.Equal(SyntaxKind.SwitchKeyword, ss.SwitchKeyword.Kind());
            CustomAssert.NotEqual(default, ss.OpenParenToken);
            CustomAssert.NotNull(ss.Expression);
            CustomAssert.Equal("a", ss.Expression.ToString());
            CustomAssert.NotEqual(default, ss.CloseParenToken);
            CustomAssert.NotEqual(default, ss.OpenBraceToken);
            CustomAssert.Equal(0, ss.Sections.Count);
            CustomAssert.NotEqual(default, ss.CloseBraceToken);
        }

        [Fact]
        public void TestSwitchWithCase()
        {
            var text = "switch (a) { case b:; }";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.SwitchStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var ss = (SwitchStatementSyntax)statement;
            CustomAssert.NotEqual(default, ss.SwitchKeyword);
            CustomAssert.Equal(SyntaxKind.SwitchKeyword, ss.SwitchKeyword.Kind());
            CustomAssert.NotEqual(default, ss.OpenParenToken);
            CustomAssert.NotNull(ss.Expression);
            CustomAssert.Equal("a", ss.Expression.ToString());
            CustomAssert.NotEqual(default, ss.CloseParenToken);
            CustomAssert.NotEqual(default, ss.OpenBraceToken);

            CustomAssert.Equal(1, ss.Sections.Count);
            CustomAssert.Equal(1, ss.Sections[0].Labels.Count);
            CustomAssert.NotEqual(default, ss.Sections[0].Labels[0].Keyword);
            CustomAssert.Equal(SyntaxKind.CaseKeyword, ss.Sections[0].Labels[0].Keyword.Kind());
            var caseLabelSyntax = ss.Sections[0].Labels[0] as CaseSwitchLabelSyntax;
            CustomAssert.NotNull(caseLabelSyntax);
            CustomAssert.NotNull(caseLabelSyntax.Value);
            CustomAssert.Equal("b", caseLabelSyntax.Value.ToString());
            CustomAssert.NotEqual(default, caseLabelSyntax.ColonToken);
            CustomAssert.Equal(1, ss.Sections[0].Statements.Count);
            CustomAssert.Equal(";", ss.Sections[0].Statements[0].ToString());

            CustomAssert.NotEqual(default, ss.CloseBraceToken);
        }

        [Fact]
        public void TestSwitchWithMultipleCases()
        {
            var text = "switch (a) { case b:; case c:; }";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.SwitchStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var ss = (SwitchStatementSyntax)statement;
            CustomAssert.NotEqual(default, ss.SwitchKeyword);
            CustomAssert.Equal(SyntaxKind.SwitchKeyword, ss.SwitchKeyword.Kind());
            CustomAssert.NotEqual(default, ss.OpenParenToken);
            CustomAssert.NotNull(ss.Expression);
            CustomAssert.Equal("a", ss.Expression.ToString());
            CustomAssert.NotEqual(default, ss.CloseParenToken);
            CustomAssert.NotEqual(default, ss.OpenBraceToken);

            CustomAssert.Equal(2, ss.Sections.Count);

            CustomAssert.Equal(1, ss.Sections[0].Labels.Count);
            CustomAssert.NotEqual(default, ss.Sections[0].Labels[0].Keyword);
            CustomAssert.Equal(SyntaxKind.CaseKeyword, ss.Sections[0].Labels[0].Keyword.Kind());
            var caseLabelSyntax = ss.Sections[0].Labels[0] as CaseSwitchLabelSyntax;
            CustomAssert.NotNull(caseLabelSyntax);
            CustomAssert.NotNull(caseLabelSyntax.Value);
            CustomAssert.Equal("b", caseLabelSyntax.Value.ToString());
            CustomAssert.NotEqual(default, caseLabelSyntax.ColonToken);
            CustomAssert.Equal(1, ss.Sections[0].Statements.Count);
            CustomAssert.Equal(";", ss.Sections[0].Statements[0].ToString());

            CustomAssert.Equal(1, ss.Sections[1].Labels.Count);
            CustomAssert.NotEqual(default, ss.Sections[1].Labels[0].Keyword);
            CustomAssert.Equal(SyntaxKind.CaseKeyword, ss.Sections[1].Labels[0].Keyword.Kind());
            var caseLabelSyntax2 = ss.Sections[1].Labels[0] as CaseSwitchLabelSyntax;
            CustomAssert.NotNull(caseLabelSyntax2);
            CustomAssert.NotNull(caseLabelSyntax2.Value);
            CustomAssert.Equal("c", caseLabelSyntax2.Value.ToString());
            CustomAssert.NotEqual(default, caseLabelSyntax2.ColonToken);
            CustomAssert.Equal(1, ss.Sections[1].Statements.Count);
            CustomAssert.Equal(";", ss.Sections[0].Statements[0].ToString());

            CustomAssert.NotEqual(default, ss.CloseBraceToken);
        }

        [Fact]
        public void TestSwitchWithDefaultCase()
        {
            var text = "switch (a) { default:; }";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.SwitchStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var ss = (SwitchStatementSyntax)statement;
            CustomAssert.NotEqual(default, ss.SwitchKeyword);
            CustomAssert.Equal(SyntaxKind.SwitchKeyword, ss.SwitchKeyword.Kind());
            CustomAssert.NotEqual(default, ss.OpenParenToken);
            CustomAssert.NotNull(ss.Expression);
            CustomAssert.Equal("a", ss.Expression.ToString());
            CustomAssert.NotEqual(default, ss.CloseParenToken);
            CustomAssert.NotEqual(default, ss.OpenBraceToken);

            CustomAssert.Equal(1, ss.Sections.Count);

            CustomAssert.Equal(1, ss.Sections[0].Labels.Count);
            CustomAssert.NotEqual(default, ss.Sections[0].Labels[0].Keyword);
            CustomAssert.Equal(SyntaxKind.DefaultKeyword, ss.Sections[0].Labels[0].Keyword.Kind());
            CustomAssert.Equal(SyntaxKind.DefaultSwitchLabel, ss.Sections[0].Labels[0].Kind());
            CustomAssert.NotEqual(default, ss.Sections[0].Labels[0].ColonToken);
            CustomAssert.Equal(1, ss.Sections[0].Statements.Count);
            CustomAssert.Equal(";", ss.Sections[0].Statements[0].ToString());

            CustomAssert.NotEqual(default, ss.CloseBraceToken);
        }

        [Fact]
        public void TestSwitchWithMultipleLabelsOnOneCase()
        {
            var text = "switch (a) { case b: case c:; }";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.SwitchStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var ss = (SwitchStatementSyntax)statement;
            CustomAssert.NotEqual(default, ss.SwitchKeyword);
            CustomAssert.Equal(SyntaxKind.SwitchKeyword, ss.SwitchKeyword.Kind());
            CustomAssert.NotEqual(default, ss.OpenParenToken);
            CustomAssert.NotNull(ss.Expression);
            CustomAssert.Equal("a", ss.Expression.ToString());
            CustomAssert.NotEqual(default, ss.CloseParenToken);
            CustomAssert.NotEqual(default, ss.OpenBraceToken);

            CustomAssert.Equal(1, ss.Sections.Count);

            CustomAssert.Equal(2, ss.Sections[0].Labels.Count);
            CustomAssert.NotEqual(default, ss.Sections[0].Labels[0].Keyword);
            CustomAssert.Equal(SyntaxKind.CaseKeyword, ss.Sections[0].Labels[0].Keyword.Kind());
            var caseLabelSyntax = ss.Sections[0].Labels[0] as CaseSwitchLabelSyntax;
            CustomAssert.NotNull(caseLabelSyntax);
            CustomAssert.NotNull(caseLabelSyntax.Value);
            CustomAssert.Equal("b", caseLabelSyntax.Value.ToString());
            CustomAssert.NotEqual(default, ss.Sections[0].Labels[1].Keyword);
            CustomAssert.Equal(SyntaxKind.CaseKeyword, ss.Sections[0].Labels[1].Keyword.Kind());
            var caseLabelSyntax2 = ss.Sections[0].Labels[1] as CaseSwitchLabelSyntax;
            CustomAssert.NotNull(caseLabelSyntax2);
            CustomAssert.NotNull(caseLabelSyntax2.Value);
            CustomAssert.Equal("c", caseLabelSyntax2.Value.ToString());
            CustomAssert.NotEqual(default, ss.Sections[0].Labels[0].ColonToken);
            CustomAssert.Equal(1, ss.Sections[0].Statements.Count);
            CustomAssert.Equal(";", ss.Sections[0].Statements[0].ToString());

            CustomAssert.NotEqual(default, ss.CloseBraceToken);
        }

        [Fact]
        public void TestSwitchWithMultipleStatementsOnOneCase()
        {
            var text = "switch (a) { case b: s1(); s2(); }";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.SwitchStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var ss = (SwitchStatementSyntax)statement;
            CustomAssert.NotEqual(default, ss.SwitchKeyword);
            CustomAssert.Equal(SyntaxKind.SwitchKeyword, ss.SwitchKeyword.Kind());
            CustomAssert.NotEqual(default, ss.OpenParenToken);
            CustomAssert.NotNull(ss.Expression);
            CustomAssert.Equal("a", ss.Expression.ToString());
            CustomAssert.NotEqual(default, ss.CloseParenToken);
            CustomAssert.NotEqual(default, ss.OpenBraceToken);

            CustomAssert.Equal(1, ss.Sections.Count);

            CustomAssert.Equal(1, ss.Sections[0].Labels.Count);
            CustomAssert.NotEqual(default, ss.Sections[0].Labels[0].Keyword);
            CustomAssert.Equal(SyntaxKind.CaseKeyword, ss.Sections[0].Labels[0].Keyword.Kind());
            var caseLabelSyntax = ss.Sections[0].Labels[0] as CaseSwitchLabelSyntax;
            CustomAssert.NotNull(caseLabelSyntax);
            CustomAssert.NotNull(caseLabelSyntax.Value);
            CustomAssert.Equal("b", caseLabelSyntax.Value.ToString());
            CustomAssert.Equal(2, ss.Sections[0].Statements.Count);
            CustomAssert.Equal("s1();", ss.Sections[0].Statements[0].ToString());
            CustomAssert.Equal("s2();", ss.Sections[0].Statements[1].ToString());

            CustomAssert.NotEqual(default, ss.CloseBraceToken);
        }

        [Fact]
        public void TestUsingWithExpression()
        {
            var text = "using (a) { }";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.UsingStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var us = (UsingStatementSyntax)statement;
            CustomAssert.NotEqual(default, us.UsingKeyword);
            CustomAssert.Equal(SyntaxKind.UsingKeyword, us.UsingKeyword.Kind());
            CustomAssert.NotEqual(default, us.OpenParenToken);
            CustomAssert.Null(us.Declaration);
            CustomAssert.NotNull(us.Expression);
            CustomAssert.Equal("a", us.Expression.ToString());
            CustomAssert.NotEqual(default, us.CloseParenToken);
            CustomAssert.NotNull(us.Statement);
        }

        [Fact]
        public void TestUsingWithDeclaration()
        {
            var text = "using (T a = b) { }";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.UsingStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var us = (UsingStatementSyntax)statement;
            CustomAssert.NotEqual(default, us.UsingKeyword);
            CustomAssert.Equal(SyntaxKind.UsingKeyword, us.UsingKeyword.Kind());
            CustomAssert.NotEqual(default, us.OpenParenToken);

            CustomAssert.NotNull(us.Declaration);
            CustomAssert.NotNull(us.Declaration.Type);
            CustomAssert.Equal("T", us.Declaration.Type.ToString());
            CustomAssert.Equal(1, us.Declaration.Variables.Count);
            CustomAssert.NotEqual(default, us.Declaration.Variables[0].Identifier);
            CustomAssert.Equal("a", us.Declaration.Variables[0].Identifier.ToString());
            CustomAssert.Null(us.Declaration.Variables[0].ArgumentList);
            CustomAssert.NotNull(us.Declaration.Variables[0].Initializer);
            CustomAssert.NotEqual(default, us.Declaration.Variables[0].Initializer.EqualsToken);
            CustomAssert.NotNull(us.Declaration.Variables[0].Initializer.Value);
            CustomAssert.Equal("b", us.Declaration.Variables[0].Initializer.Value.ToString());

            CustomAssert.Null(us.Expression);

            CustomAssert.NotEqual(default, us.CloseParenToken);
            CustomAssert.NotNull(us.Statement);
        }

        [Fact]
        public void TestUsingVarWithDeclaration()
        {
            var text = "using T a = b;";
            var statement = this.ParseStatement(text, options: TestOptions.Regular8);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.LocalDeclarationStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var us = (LocalDeclarationStatementSyntax)statement;
            CustomAssert.NotEqual(default, us.UsingKeyword);
            CustomAssert.Equal(SyntaxKind.UsingKeyword, us.UsingKeyword.Kind());

            CustomAssert.NotNull(us.Declaration);
            CustomAssert.NotNull(us.Declaration.Type);
            CustomAssert.Equal("T", us.Declaration.Type.ToString());
            CustomAssert.Equal(1, us.Declaration.Variables.Count);
            CustomAssert.NotEqual(default, us.Declaration.Variables[0].Identifier);
            CustomAssert.Equal("a", us.Declaration.Variables[0].Identifier.ToString());
            CustomAssert.Null(us.Declaration.Variables[0].ArgumentList);
            CustomAssert.NotNull(us.Declaration.Variables[0].Initializer);
            CustomAssert.NotEqual(default, us.Declaration.Variables[0].Initializer.EqualsToken);
            CustomAssert.NotNull(us.Declaration.Variables[0].Initializer.Value);
            CustomAssert.Equal("b", us.Declaration.Variables[0].Initializer.Value.ToString());
            CustomAssert.NotEqual(default, us.SemicolonToken);
        }

        [Fact]
        public void TestUsingVarWithDeclarationTree()
        {
            UsingStatement(@"using T a = b;", options: TestOptions.Regular8);
            N(SyntaxKind.LocalDeclarationStatement);
            {
                N(SyntaxKind.UsingKeyword);
                N(SyntaxKind.VariableDeclaration);
                {
                    N(SyntaxKind.IdentifierName, "T");
                    {
                        N(SyntaxKind.IdentifierToken);
                    }
                    N(SyntaxKind.VariableDeclarator);
                    {
                        N(SyntaxKind.IdentifierToken);
                        N(SyntaxKind.EqualsValueClause);
                        {
                            N(SyntaxKind.EqualsToken);
                            N(SyntaxKind.IdentifierName, "b");
                            {
                                N(SyntaxKind.IdentifierToken);
                            }
                        }
                    }
                }
                N(SyntaxKind.SemicolonToken);
            }
        }

        [Fact]
        public void TestUsingWithVarDeclaration()
        {
            var text = "using (var a = b) { }";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.UsingStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var us = (UsingStatementSyntax)statement;
            CustomAssert.NotEqual(default, us.UsingKeyword);
            CustomAssert.Equal(SyntaxKind.UsingKeyword, us.UsingKeyword.Kind());
            CustomAssert.NotEqual(default, us.OpenParenToken);

            CustomAssert.NotNull(us.Declaration);
            CustomAssert.NotNull(us.Declaration.Type);
            CustomAssert.Equal("var", us.Declaration.Type.ToString());
            CustomAssert.Equal(SyntaxKind.IdentifierName, us.Declaration.Type.Kind());
            CustomAssert.Equal(SyntaxKind.IdentifierToken, ((IdentifierNameSyntax)us.Declaration.Type).Identifier.Kind());
            CustomAssert.Equal(1, us.Declaration.Variables.Count);
            CustomAssert.NotEqual(default, us.Declaration.Variables[0].Identifier);
            CustomAssert.Equal("a", us.Declaration.Variables[0].Identifier.ToString());
            CustomAssert.Null(us.Declaration.Variables[0].ArgumentList);
            CustomAssert.NotNull(us.Declaration.Variables[0].Initializer);
            CustomAssert.NotEqual(default, us.Declaration.Variables[0].Initializer.EqualsToken);
            CustomAssert.NotNull(us.Declaration.Variables[0].Initializer.Value);
            CustomAssert.Equal("b", us.Declaration.Variables[0].Initializer.Value.ToString());

            CustomAssert.Null(us.Expression);

            CustomAssert.NotEqual(default, us.CloseParenToken);
            CustomAssert.NotNull(us.Statement);
        }

        [Fact]
        public void TestUsingVarWithVarDeclaration()
        {
            var text = "using var a = b;";
            var statement = this.ParseStatement(text, options: TestOptions.Regular8);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.LocalDeclarationStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var us = (LocalDeclarationStatementSyntax)statement;
            CustomAssert.NotEqual(default, us.UsingKeyword);
            CustomAssert.Equal(SyntaxKind.UsingKeyword, us.UsingKeyword.Kind());

            CustomAssert.NotNull(us.Declaration);
            CustomAssert.NotNull(us.Declaration.Type);
            CustomAssert.Equal("var", us.Declaration.Type.ToString());
            CustomAssert.Equal(SyntaxKind.IdentifierName, us.Declaration.Type.Kind());
            CustomAssert.Equal(SyntaxKind.IdentifierToken, ((IdentifierNameSyntax)us.Declaration.Type).Identifier.Kind());
            CustomAssert.Equal(1, us.Declaration.Variables.Count);
            CustomAssert.NotEqual(default, us.Declaration.Variables[0].Identifier);
            CustomAssert.Equal("a", us.Declaration.Variables[0].Identifier.ToString());
            CustomAssert.Null(us.Declaration.Variables[0].ArgumentList);
            CustomAssert.NotNull(us.Declaration.Variables[0].Initializer);
            CustomAssert.NotEqual(default, us.Declaration.Variables[0].Initializer.EqualsToken);
            CustomAssert.NotNull(us.Declaration.Variables[0].Initializer.Value);
            CustomAssert.Equal("b", us.Declaration.Variables[0].Initializer.Value.ToString());
        }

        [Fact]
        [WorkItem(36413, "https://github.com/dotnet/roslyn/issues/36413")]
        public void TestUsingVarWithInvalidDeclaration()
        {
            var text = "using public readonly var a = b;";
            var statement = this.ParseStatement(text, options: TestOptions.Regular8);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.LocalDeclarationStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(2, statement.Errors().Length);
            CustomAssert.Equal((int)ErrorCode.ERR_BadMemberFlag, statement.Errors()[0].Code);
            CustomAssert.Equal("public", statement.Errors()[0].Arguments[0]);
            CustomAssert.Equal((int)ErrorCode.ERR_BadMemberFlag, statement.Errors()[1].Code);
            CustomAssert.Equal("readonly", statement.Errors()[1].Arguments[0]);

            var us = (LocalDeclarationStatementSyntax)statement;
            CustomAssert.NotEqual(default, us.UsingKeyword);
            CustomAssert.Equal(SyntaxKind.UsingKeyword, us.UsingKeyword.Kind());

            CustomAssert.NotNull(us.Declaration);
            CustomAssert.NotNull(us.Declaration.Type);
            CustomAssert.Equal("var", us.Declaration.Type.ToString());
            CustomAssert.Equal(SyntaxKind.IdentifierName, us.Declaration.Type.Kind());
            CustomAssert.Equal(SyntaxKind.IdentifierToken, ((IdentifierNameSyntax)us.Declaration.Type).Identifier.Kind());
            CustomAssert.Equal(2, us.Modifiers.Count);
            CustomAssert.Equal("public", us.Modifiers[0].ToString());
            CustomAssert.Equal("readonly", us.Modifiers[1].ToString());
            CustomAssert.Equal(1, us.Declaration.Variables.Count);
            CustomAssert.NotEqual(default, us.Declaration.Variables[0].Identifier);
            CustomAssert.Equal("a", us.Declaration.Variables[0].Identifier.ToString());
            CustomAssert.Null(us.Declaration.Variables[0].ArgumentList);
            CustomAssert.NotNull(us.Declaration.Variables[0].Initializer);
            CustomAssert.NotEqual(default, us.Declaration.Variables[0].Initializer.EqualsToken);
            CustomAssert.NotNull(us.Declaration.Variables[0].Initializer.Value);
            CustomAssert.Equal("b", us.Declaration.Variables[0].Initializer.Value.ToString());
        }

        [Fact]
        public void TestUsingVarWithVarDeclarationTree()
        {
            UsingStatement(@"using var a = b;", options: TestOptions.Regular8);
            N(SyntaxKind.LocalDeclarationStatement);
            {
                N(SyntaxKind.UsingKeyword);
                N(SyntaxKind.VariableDeclaration);
                {
                    N(SyntaxKind.IdentifierName, "var");
                    {
                        N(SyntaxKind.IdentifierToken, "var");
                    }
                    N(SyntaxKind.VariableDeclarator);
                    {
                        N(SyntaxKind.IdentifierToken, "a");
                        N(SyntaxKind.EqualsValueClause);
                        {
                            N(SyntaxKind.EqualsToken);
                            N(SyntaxKind.IdentifierName, "b");
                            {
                                N(SyntaxKind.IdentifierToken);
                            }
                        }
                    }
                }
                N(SyntaxKind.SemicolonToken);
            }
        }

        [Fact]
        public void TestAwaitUsingVarWithDeclarationTree()
        {
            UsingStatement(@"await using T a = b;", TestOptions.Regular8);
            N(SyntaxKind.LocalDeclarationStatement);
            {
                N(SyntaxKind.AwaitKeyword);
                N(SyntaxKind.UsingKeyword);
                N(SyntaxKind.VariableDeclaration);
                {
                    N(SyntaxKind.IdentifierName, "T");
                    {
                        N(SyntaxKind.IdentifierToken);
                    }
                    N(SyntaxKind.VariableDeclarator);
                    {
                        N(SyntaxKind.IdentifierToken, "a");
                        N(SyntaxKind.EqualsValueClause);
                        {
                            N(SyntaxKind.EqualsToken);
                            N(SyntaxKind.IdentifierName, "b");
                            {
                                N(SyntaxKind.IdentifierToken);
                            }
                        }
                    }
                }
                N(SyntaxKind.SemicolonToken);
            }
        }

        [Fact]
        public void TestAwaitUsingWithVarDeclaration()
        {
            var text = "await using var a = b;";
            var statement = this.ParseStatement(text, 0, TestOptions.Regular8);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.LocalDeclarationStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var us = (LocalDeclarationStatementSyntax)statement;
            CustomAssert.NotEqual(default, us.AwaitKeyword);
            CustomAssert.Equal(SyntaxKind.AwaitKeyword, us.AwaitKeyword.ContextualKind());
            CustomAssert.NotEqual(default, us.UsingKeyword);
            CustomAssert.Equal(SyntaxKind.UsingKeyword, us.UsingKeyword.Kind());

            CustomAssert.NotNull(us.Declaration);
            CustomAssert.NotNull(us.Declaration.Type);
            CustomAssert.Equal("var", us.Declaration.Type.ToString());
            CustomAssert.Equal(SyntaxKind.IdentifierName, us.Declaration.Type.Kind());
            CustomAssert.Equal(SyntaxKind.IdentifierToken, ((IdentifierNameSyntax)us.Declaration.Type).Identifier.Kind());
            CustomAssert.Equal(1, us.Declaration.Variables.Count);
            CustomAssert.NotEqual(default, us.Declaration.Variables[0].Identifier);
            CustomAssert.Equal("a", us.Declaration.Variables[0].Identifier.ToString());
            CustomAssert.Null(us.Declaration.Variables[0].ArgumentList);
            CustomAssert.NotNull(us.Declaration.Variables[0].Initializer);
            CustomAssert.NotEqual(default, us.Declaration.Variables[0].Initializer.EqualsToken);
            CustomAssert.NotNull(us.Declaration.Variables[0].Initializer.Value);
            CustomAssert.Equal("b", us.Declaration.Variables[0].Initializer.Value.ToString());
        }

        [Fact]
        public void TestAwaitUsingVarWithVarDeclarationTree()
        {
            UsingStatement(@"await using var a = b;", TestOptions.Regular8);
            N(SyntaxKind.LocalDeclarationStatement);
            {
                N(SyntaxKind.AwaitKeyword);
                N(SyntaxKind.UsingKeyword);
                N(SyntaxKind.VariableDeclaration);
                {
                    N(SyntaxKind.IdentifierName, "var");
                    {
                        N(SyntaxKind.IdentifierToken, "var");
                    }
                    N(SyntaxKind.VariableDeclarator);
                    {
                        N(SyntaxKind.IdentifierToken, "a");
                        N(SyntaxKind.EqualsValueClause);
                        {
                            N(SyntaxKind.EqualsToken);
                            N(SyntaxKind.IdentifierName, "b");
                            {
                                N(SyntaxKind.IdentifierToken);
                            }
                        }
                    }
                }
                N(SyntaxKind.SemicolonToken);
            }
        }

        [Fact, WorkItem(30565, "https://github.com/dotnet/roslyn/issues/30565")]
        public void AwaitUsingVarWithVarDecl_Reversed()
        {
            UsingTree(@"
class C
{
    async void M()
    {
        using await var x = null;
    }
}
");
            N(SyntaxKind.CompilationUnit);
            {
                N(SyntaxKind.ClassDeclaration);
                {
                    N(SyntaxKind.ClassKeyword);
                    N(SyntaxKind.IdentifierToken, "C");
                    N(SyntaxKind.OpenBraceToken);
                    N(SyntaxKind.MethodDeclaration);
                    {
                        N(SyntaxKind.AsyncKeyword);
                        N(SyntaxKind.PredefinedType);
                        {
                            N(SyntaxKind.VoidKeyword);
                        }
                        N(SyntaxKind.IdentifierToken, "M");
                        N(SyntaxKind.ParameterList);
                        {
                            N(SyntaxKind.OpenParenToken);
                            N(SyntaxKind.CloseParenToken);
                        }
                        N(SyntaxKind.Block);
                        {
                            N(SyntaxKind.OpenBraceToken);
                            N(SyntaxKind.LocalDeclarationStatement);
                            {
                                N(SyntaxKind.UsingKeyword);
                                N(SyntaxKind.VariableDeclaration);
                                {
                                    N(SyntaxKind.IdentifierName);
                                    {
                                        N(SyntaxKind.IdentifierToken, "await");
                                    }
                                    N(SyntaxKind.VariableDeclarator);
                                    {
                                        N(SyntaxKind.IdentifierToken, "var");
                                    }
                                }
                                M(SyntaxKind.SemicolonToken);
                            }
                            N(SyntaxKind.ExpressionStatement);
                            {
                                N(SyntaxKind.SimpleAssignmentExpression);
                                {
                                    N(SyntaxKind.IdentifierName);
                                    {
                                        N(SyntaxKind.IdentifierToken, "x");
                                    }
                                    N(SyntaxKind.EqualsToken);
                                    N(SyntaxKind.NullLiteralExpression);
                                    {
                                        N(SyntaxKind.NullKeyword);
                                    }
                                }
                                N(SyntaxKind.SemicolonToken);
                            }
                            N(SyntaxKind.CloseBraceToken);
                        }
                    }
                    N(SyntaxKind.CloseBraceToken);
                }
                N(SyntaxKind.EndOfFileToken);
            }
            EOF();
        }

        [Fact]
        public void TestAwaitUsingVarWithVarAndNoUsingDeclarationTree()
        {
            UsingStatement(@"await var a = b;", TestOptions.Regular8,
                // (1,1): error CS1073: Unexpected token 'a'
                // await var a = b;
                Diagnostic(ErrorCode.ERR_UnexpectedToken, "await var ").WithArguments("a").WithLocation(1, 1),
                // (1,11): error CS1002: ; expected
                // await var a = b;
                Diagnostic(ErrorCode.ERR_SemicolonExpected, "a").WithLocation(1, 11));

            N(SyntaxKind.ExpressionStatement);
            {
                N(SyntaxKind.AwaitExpression);
                {
                    N(SyntaxKind.AwaitKeyword);
                    N(SyntaxKind.IdentifierName);
                    {
                        N(SyntaxKind.IdentifierToken, "var");
                    }
                }
                M(SyntaxKind.SemicolonToken);
            }
            EOF();
        }

        [Fact]
        public void TestUsingWithDeclarationWithMultipleVariables()
        {
            var text = "using (T a = b, c = d) { }";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.UsingStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var us = (UsingStatementSyntax)statement;
            CustomAssert.NotEqual(default, us.UsingKeyword);
            CustomAssert.Equal(SyntaxKind.UsingKeyword, us.UsingKeyword.Kind());
            CustomAssert.NotEqual(default, us.OpenParenToken);

            CustomAssert.NotNull(us.Declaration);
            CustomAssert.NotNull(us.Declaration.Type);
            CustomAssert.Equal("T", us.Declaration.Type.ToString());

            CustomAssert.Equal(2, us.Declaration.Variables.Count);

            CustomAssert.NotEqual(default, us.Declaration.Variables[0].Identifier);
            CustomAssert.Equal("a", us.Declaration.Variables[0].Identifier.ToString());
            CustomAssert.Null(us.Declaration.Variables[0].ArgumentList);
            CustomAssert.NotNull(us.Declaration.Variables[0].Initializer);
            CustomAssert.NotEqual(default, us.Declaration.Variables[0].Initializer.EqualsToken);
            CustomAssert.NotNull(us.Declaration.Variables[0].Initializer.Value);
            CustomAssert.Equal("b", us.Declaration.Variables[0].Initializer.Value.ToString());

            CustomAssert.NotEqual(default, us.Declaration.Variables[1].Identifier);
            CustomAssert.Equal("c", us.Declaration.Variables[1].Identifier.ToString());
            CustomAssert.Null(us.Declaration.Variables[1].ArgumentList);
            CustomAssert.NotNull(us.Declaration.Variables[1].Initializer);
            CustomAssert.NotEqual(default, us.Declaration.Variables[1].Initializer.EqualsToken);
            CustomAssert.NotNull(us.Declaration.Variables[1].Initializer.Value);
            CustomAssert.Equal("d", us.Declaration.Variables[1].Initializer.Value.ToString());

            CustomAssert.Null(us.Expression);

            CustomAssert.NotEqual(default, us.CloseParenToken);
            CustomAssert.NotNull(us.Statement);
        }

        [Fact]
        public void TestUsingVarWithDeclarationWithMultipleVariables()
        {
            var text = "using T a = b, c = d;";
            var statement = this.ParseStatement(text, options: TestOptions.Regular8);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.LocalDeclarationStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var us = (LocalDeclarationStatementSyntax)statement;
            CustomAssert.NotEqual(default, us.UsingKeyword);
            CustomAssert.Equal(SyntaxKind.UsingKeyword, us.UsingKeyword.Kind());

            CustomAssert.NotNull(us.Declaration);
            CustomAssert.NotNull(us.Declaration.Type);
            CustomAssert.Equal("T", us.Declaration.Type.ToString());

            CustomAssert.Equal(2, us.Declaration.Variables.Count);

            CustomAssert.NotEqual(default, us.Declaration.Variables[0].Identifier);
            CustomAssert.Equal("a", us.Declaration.Variables[0].Identifier.ToString());
            CustomAssert.Null(us.Declaration.Variables[0].ArgumentList);
            CustomAssert.NotNull(us.Declaration.Variables[0].Initializer);
            CustomAssert.NotEqual(default, us.Declaration.Variables[0].Initializer.EqualsToken);
            CustomAssert.NotNull(us.Declaration.Variables[0].Initializer.Value);
            CustomAssert.Equal("b", us.Declaration.Variables[0].Initializer.Value.ToString());

            CustomAssert.NotEqual(default, us.Declaration.Variables[1].Identifier);
            CustomAssert.Equal("c", us.Declaration.Variables[1].Identifier.ToString());
            CustomAssert.Null(us.Declaration.Variables[1].ArgumentList);
            CustomAssert.NotNull(us.Declaration.Variables[1].Initializer);
            CustomAssert.NotEqual(default, us.Declaration.Variables[1].Initializer.EqualsToken);
            CustomAssert.NotNull(us.Declaration.Variables[1].Initializer.Value);
            CustomAssert.Equal("d", us.Declaration.Variables[1].Initializer.Value.ToString());
        }

        [Fact]
        public void TestUsingVarWithDeclarationMultipleVariablesTree()
        {
            UsingStatement(@"using T a = b, c = d;", options: TestOptions.Regular8);
            N(SyntaxKind.LocalDeclarationStatement);
            {
                N(SyntaxKind.UsingKeyword);
                N(SyntaxKind.VariableDeclaration);
                {
                    N(SyntaxKind.IdentifierName, "T");
                    {
                        N(SyntaxKind.IdentifierToken, "T");
                    }
                    N(SyntaxKind.VariableDeclarator);
                    {
                        N(SyntaxKind.IdentifierToken, "a");
                        N(SyntaxKind.EqualsValueClause);
                        {
                            N(SyntaxKind.EqualsToken);
                            N(SyntaxKind.IdentifierName, "b");
                            {
                                N(SyntaxKind.IdentifierToken, "b");
                            }
                        }
                    }
                    N(SyntaxKind.CommaToken);
                    N(SyntaxKind.VariableDeclarator);
                    {
                        N(SyntaxKind.IdentifierToken, "c");
                        N(SyntaxKind.EqualsValueClause);
                        {
                            N(SyntaxKind.EqualsToken);
                            N(SyntaxKind.IdentifierName, "d");
                            {
                                N(SyntaxKind.IdentifierToken, "d");
                            }
                        }
                    }
                }
                N(SyntaxKind.SemicolonToken);
            }
        }

        [Fact]
        public void TestUsingSpecialCase1()
        {
            var text = "using (f ? x = a : x = b) { }";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.UsingStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var us = (UsingStatementSyntax)statement;
            CustomAssert.NotEqual(default, us.UsingKeyword);
            CustomAssert.Equal(SyntaxKind.UsingKeyword, us.UsingKeyword.Kind());
            CustomAssert.NotEqual(default, us.OpenParenToken);
            CustomAssert.Null(us.Declaration);
            CustomAssert.NotNull(us.Expression);
            CustomAssert.Equal("f ? x = a : x = b", us.Expression.ToString());
            CustomAssert.NotEqual(default, us.CloseParenToken);
            CustomAssert.NotNull(us.Statement);
        }

        [Fact]
        public void TestUsingVarSpecialCase1()
        {
            var text = "using var x = f ? a : b;";
            var statement = this.ParseStatement(text, options: TestOptions.Regular8);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.LocalDeclarationStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var us = (LocalDeclarationStatementSyntax)statement;
            CustomAssert.NotEqual(default, us.UsingKeyword);
            CustomAssert.Equal(SyntaxKind.UsingKeyword, us.UsingKeyword.Kind());
            CustomAssert.NotNull(us.Declaration);
            CustomAssert.Equal("var x = f ? a : b", us.Declaration.ToString());
        }

        [Fact]
        public void TestUsingVarSpecialCase1Tree()
        {
            UsingStatement(@"using var x = f ? a : b;", options: TestOptions.Regular8);
            N(SyntaxKind.LocalDeclarationStatement);
            {
                N(SyntaxKind.UsingKeyword);
                N(SyntaxKind.VariableDeclaration);
                {
                    N(SyntaxKind.IdentifierName, "var");
                    {
                        N(SyntaxKind.IdentifierToken, "var");
                    }
                    N(SyntaxKind.VariableDeclarator);
                    {
                        N(SyntaxKind.IdentifierToken, "x");
                        N(SyntaxKind.EqualsValueClause);
                        {
                            N(SyntaxKind.EqualsToken);
                            N(SyntaxKind.ConditionalExpression);
                            {
                                N(SyntaxKind.IdentifierName, "f");
                                {
                                    N(SyntaxKind.IdentifierToken, "f");
                                }
                                N(SyntaxKind.QuestionToken);
                                N(SyntaxKind.IdentifierName, "a");
                                {
                                    N(SyntaxKind.IdentifierToken, "a");
                                }
                                N(SyntaxKind.ColonToken);
                                N(SyntaxKind.IdentifierName, "b");
                                {
                                    N(SyntaxKind.IdentifierToken, "b");
                                }
                            }
                        }
                    }
                }
                N(SyntaxKind.SemicolonToken);
            }
        }

        [Fact]
        public void TestUsingSpecialCase2()
        {
            var text = "using (f ? x = a) { }";
            var statement = this.ParseStatement(text, options: TestOptions.Regular8);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.UsingStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var us = (UsingStatementSyntax)statement;
            CustomAssert.NotEqual(default, us.UsingKeyword);
            CustomAssert.Equal(SyntaxKind.UsingKeyword, us.UsingKeyword.Kind());
            CustomAssert.NotEqual(default, us.OpenParenToken);
            CustomAssert.NotNull(us.Declaration);
            CustomAssert.Equal("f ? x = a", us.Declaration.ToString());
            CustomAssert.Null(us.Expression);
            CustomAssert.NotEqual(default, us.CloseParenToken);
            CustomAssert.NotNull(us.Statement);
        }

        [Fact]
        public void TestUsingVarSpecialCase2()
        {
            var text = "using f ? x = a;";
            var statement = this.ParseStatement(text, options: TestOptions.Regular8);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.LocalDeclarationStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var us = (LocalDeclarationStatementSyntax)statement;
            CustomAssert.NotEqual(default, us.UsingKeyword);
            CustomAssert.Equal(SyntaxKind.UsingKeyword, us.UsingKeyword.Kind());
            CustomAssert.NotNull(us.Declaration);
            CustomAssert.Equal("f ? x = a", us.Declaration.ToString());
        }

        [Fact]
        public void TestUsingVarSpecialCase2Tree()
        {
            UsingStatement(@"using f ? x = a;", options: TestOptions.Regular8);
            N(SyntaxKind.LocalDeclarationStatement);
            {
                N(SyntaxKind.UsingKeyword);
                N(SyntaxKind.VariableDeclaration);
                {
                    N(SyntaxKind.NullableType);
                    {
                        N(SyntaxKind.IdentifierName, "f");
                        {
                            N(SyntaxKind.IdentifierToken, "f");
                        }
                        N(SyntaxKind.QuestionToken);
                    }
                    N(SyntaxKind.VariableDeclarator);
                    N(SyntaxKind.IdentifierToken, "x");
                    N(SyntaxKind.EqualsValueClause);
                    {
                        N(SyntaxKind.EqualsToken);
                        N(SyntaxKind.IdentifierName, "a");
                        {
                            N(SyntaxKind.IdentifierToken, "a");
                        }
                    }
                }
                N(SyntaxKind.SemicolonToken);
            }
        }

        [Fact]
        public void TestUsingSpecialCase3()
        {
            var text = "using (f ? x, y) { }";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.UsingStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var us = (UsingStatementSyntax)statement;
            CustomAssert.NotEqual(default, us.UsingKeyword);
            CustomAssert.Equal(SyntaxKind.UsingKeyword, us.UsingKeyword.Kind());
            CustomAssert.NotEqual(default, us.OpenParenToken);
            CustomAssert.NotNull(us.Declaration);
            CustomAssert.Equal("f ? x, y", us.Declaration.ToString());
            CustomAssert.Null(us.Expression);
            CustomAssert.NotEqual(default, us.CloseParenToken);
            CustomAssert.NotNull(us.Statement);
        }

        [Fact]
        public void TestUsingVarSpecialCase3()
        {
            var text = "using f ? x, y;";
            var statement = this.ParseStatement(text, options: TestOptions.Regular8);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.LocalDeclarationStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var us = (LocalDeclarationStatementSyntax)statement;
            CustomAssert.NotEqual(default, us.UsingKeyword);
            CustomAssert.Equal(SyntaxKind.UsingKeyword, us.UsingKeyword.Kind());
            CustomAssert.NotNull(us.Declaration);
            CustomAssert.Equal("f ? x, y", us.Declaration.ToString());
        }

        [Fact]
        public void TestUsingVarSpecialCase3Tree()
        {
            UsingStatement("using f? x, y;", options: TestOptions.Regular8);
            N(SyntaxKind.LocalDeclarationStatement);
            {
                N(SyntaxKind.UsingKeyword);
                N(SyntaxKind.VariableDeclaration);
                {
                    N(SyntaxKind.NullableType);
                    {
                        N(SyntaxKind.IdentifierName, "f");
                        {
                            N(SyntaxKind.IdentifierToken, "f");
                        }
                        N(SyntaxKind.QuestionToken);
                    }
                    N(SyntaxKind.VariableDeclarator);
                    {
                        N(SyntaxKind.IdentifierToken, "x");
                    }
                    N(SyntaxKind.CommaToken);
                    N(SyntaxKind.VariableDeclarator);
                    {
                        N(SyntaxKind.IdentifierToken, "y");
                    }
                }
            }
            N(SyntaxKind.SemicolonToken);
        }

        [Fact]
        public void TestUsingVarRefTree()
        {
            UsingStatement("using ref int x = ref y;", TestOptions.Regular8);
            N(SyntaxKind.LocalDeclarationStatement);
            {
                N(SyntaxKind.UsingKeyword);
                N(SyntaxKind.VariableDeclaration);
                {
                    N(SyntaxKind.RefType);
                    {
                        N(SyntaxKind.RefKeyword);
                        N(SyntaxKind.PredefinedType);
                        {
                            N(SyntaxKind.IntKeyword);
                        }
                    }
                    N(SyntaxKind.VariableDeclarator);
                    {
                        N(SyntaxKind.IdentifierToken, "x");
                        N(SyntaxKind.EqualsValueClause);
                        {
                            N(SyntaxKind.EqualsToken);
                            N(SyntaxKind.RefExpression);
                            {
                                N(SyntaxKind.RefKeyword);
                                N(SyntaxKind.IdentifierName, "y");
                                {
                                    N(SyntaxKind.IdentifierToken, "y");
                                }
                            }
                        }
                    }
                }
            }
            N(SyntaxKind.SemicolonToken);
        }

        [Fact]
        public void TestUsingVarRefReadonlyTree()
        {
            UsingStatement("using ref readonly int x = ref y;", TestOptions.Regular8);
            N(SyntaxKind.LocalDeclarationStatement);
            {
                N(SyntaxKind.UsingKeyword);
                N(SyntaxKind.VariableDeclaration);
                {
                    N(SyntaxKind.RefType);
                    {
                        N(SyntaxKind.RefKeyword);
                        N(SyntaxKind.ReadOnlyKeyword);
                        N(SyntaxKind.PredefinedType);
                        {
                            N(SyntaxKind.IntKeyword);
                        }
                    }
                    N(SyntaxKind.VariableDeclarator);
                    {
                        N(SyntaxKind.IdentifierToken, "x");
                        N(SyntaxKind.EqualsValueClause);
                        {
                            N(SyntaxKind.EqualsToken);
                            N(SyntaxKind.RefExpression);
                            {
                                N(SyntaxKind.RefKeyword);
                                N(SyntaxKind.IdentifierName, "y");
                                {
                                    N(SyntaxKind.IdentifierToken, "y");
                                }
                            }
                        }
                    }
                }
            }
            N(SyntaxKind.SemicolonToken);
        }

        [Fact]
        public void TestUsingVarRefVarTree()
        {
            UsingStatement("using ref var x = ref y;", TestOptions.Regular8);
            N(SyntaxKind.LocalDeclarationStatement);
            {
                N(SyntaxKind.UsingKeyword);
                N(SyntaxKind.VariableDeclaration);
                {
                    N(SyntaxKind.RefType);
                    {
                        N(SyntaxKind.RefKeyword);
                        N(SyntaxKind.IdentifierName, "var");
                        {
                            N(SyntaxKind.IdentifierToken, "var");
                        }
                    }
                    N(SyntaxKind.VariableDeclarator);
                    {
                        N(SyntaxKind.IdentifierToken, "x");
                        N(SyntaxKind.EqualsValueClause);
                        {
                            N(SyntaxKind.EqualsToken);
                            N(SyntaxKind.RefExpression);
                            {
                                N(SyntaxKind.RefKeyword);
                                N(SyntaxKind.IdentifierName, "y");
                                {
                                    N(SyntaxKind.IdentifierToken, "y");
                                }
                            }
                        }
                    }
                }
            }
            N(SyntaxKind.SemicolonToken);
        }

        [Fact]
        public void TestUsingVarRefVarIsYTree()
        {
            UsingStatement("using ref var x = y;", TestOptions.Regular8);
            N(SyntaxKind.LocalDeclarationStatement);
            {
                N(SyntaxKind.UsingKeyword);
                N(SyntaxKind.VariableDeclaration);
                {
                    N(SyntaxKind.RefType);
                    {
                        N(SyntaxKind.RefKeyword);
                        N(SyntaxKind.IdentifierName, "var");
                        {
                            N(SyntaxKind.IdentifierToken, "var");
                        }
                    }
                    N(SyntaxKind.VariableDeclarator);
                    {
                        N(SyntaxKind.IdentifierToken, "x");
                        N(SyntaxKind.EqualsValueClause);
                        {
                            N(SyntaxKind.EqualsToken);
                            N(SyntaxKind.IdentifierName, "y");
                            {
                                N(SyntaxKind.IdentifierToken, "y");
                            }
                        }
                    }
                }
            }
            N(SyntaxKind.SemicolonToken);
        }

        [Fact]
        public void TestUsingVarReadonlyMultipleDeclarations()
        {
            UsingStatement("using readonly var x, y = ref z;", TestOptions.Regular8,
                // (1,7): error CS0106: The modifier 'readonly' is not valid for this item
                // using readonly var x, y = ref z;
                Diagnostic(ErrorCode.ERR_BadMemberFlag, "readonly").WithArguments("readonly").WithLocation(1, 7));
            N(SyntaxKind.LocalDeclarationStatement);
            {
                N(SyntaxKind.UsingKeyword);
                N(SyntaxKind.ReadOnlyKeyword);
                N(SyntaxKind.VariableDeclaration);
                {
                    N(SyntaxKind.IdentifierName, "var");
                    {
                        N(SyntaxKind.IdentifierToken, "var");
                    }
                    N(SyntaxKind.VariableDeclarator);
                    {
                        N(SyntaxKind.IdentifierToken, "x");
                    }
                    N(SyntaxKind.CommaToken);
                    N(SyntaxKind.VariableDeclarator);
                    {
                        N(SyntaxKind.IdentifierToken, "y");
                    }
                    N(SyntaxKind.EqualsValueClause);
                    {
                        N(SyntaxKind.EqualsToken);
                        N(SyntaxKind.RefExpression);
                        {
                            N(SyntaxKind.RefKeyword);
                            N(SyntaxKind.IdentifierName, "z");
                            {
                                N(SyntaxKind.IdentifierToken, "z");
                            }
                        }
                    }
                }
            }
            N(SyntaxKind.SemicolonToken);
        }

        [Fact]
        public void TestContextualKeywordsAsLocalVariableTypes()
        {
            TestContextualKeywordAsLocalVariableType(SyntaxKind.PartialKeyword);
            TestContextualKeywordAsLocalVariableType(SyntaxKind.AsyncKeyword);
            TestContextualKeywordAsLocalVariableType(SyntaxKind.AwaitKeyword);
        }

        private void TestContextualKeywordAsLocalVariableType(SyntaxKind kind)
        {
            var keywordText = SyntaxFacts.GetText(kind);
            var text = keywordText + " o = null;";
            var statement = this.ParseStatement(text);
            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.LocalDeclarationStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());

            var decl = (LocalDeclarationStatementSyntax)statement;
            CustomAssert.Equal(keywordText, decl.Declaration.Type.ToString());
            CustomAssert.IsType<IdentifierNameSyntax>(decl.Declaration.Type);
            var name = (IdentifierNameSyntax)decl.Declaration.Type;
            CustomAssert.Equal(kind, name.Identifier.ContextualKind());
            CustomAssert.Equal(SyntaxKind.IdentifierToken, name.Identifier.Kind());
        }

        [Fact]
        public void Bug862649()
        {
            var text = @"static char[] delimiter;";
            var tree = SyntaxFactory.ParseStatement(text);
            var toText = tree.ToFullString();
            CustomAssert.Equal(text, toText);
        }

        [Fact]
        public void TestForEachAfterOffset()
        {
            const string prefix = "GARBAGE";
            var text = "foreach(T a in b) { }";
            var statement = this.ParseStatement(prefix + text, offset: prefix.Length);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.ForEachStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(0, statement.Errors().Length);

            var fs = (ForEachStatementSyntax)statement;
            CustomAssert.NotEqual(default, fs.ForEachKeyword);
            CustomAssert.Equal(SyntaxKind.ForEachKeyword, fs.ForEachKeyword.Kind());

            CustomAssert.NotEqual(default, fs.OpenParenToken);
            CustomAssert.NotNull(fs.Type);
            CustomAssert.Equal("T", fs.Type.ToString());
            CustomAssert.NotEqual(default, fs.Identifier);
            CustomAssert.Equal("a", fs.Identifier.ToString());
            CustomAssert.NotEqual(default, fs.InKeyword);
            CustomAssert.False(fs.InKeyword.IsMissing);
            CustomAssert.Equal(SyntaxKind.InKeyword, fs.InKeyword.Kind());
            CustomAssert.NotNull(fs.Expression);
            CustomAssert.Equal("b", fs.Expression.ToString());
            CustomAssert.NotEqual(default, fs.CloseParenToken);
            CustomAssert.NotNull(fs.Statement);
        }

        [WorkItem(684860, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/684860")]
        [Fact]
        public void Bug684860_SkippedTokens()
        {
            const int n = 100000;
            // 100000 instances of "0+" in:
            // #pragma warning disable 1 0+0+0+...
            var builder = new System.Text.StringBuilder();
            builder.Append("#pragma warning disable 1 ");
            for (int i = 0; i < n; i++)
            {
                builder.Append("0+");
            }
            builder.AppendLine();
            var text = builder.ToString();
            var tree = SyntaxFactory.ParseSyntaxTree(text);
            var root = tree.GetRoot();
            var walker = new TokenAndTriviaWalker();
            walker.Visit(root);
            CustomAssert.True(walker.Tokens > n);
            var tokens1 = root.DescendantTokens(descendIntoTrivia: false).ToArray();
            var tokens2 = root.DescendantTokens(descendIntoTrivia: true).ToArray();
            CustomAssert.True((tokens2.Length - tokens1.Length) > n);
        }

        [WorkItem(684860, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/684860")]
        [Fact]
        public void Bug684860_XmlText()
        {
            const int n = 100000;
            // 100000 instances of "&lt;" in:
            // /// <x a="&lt;&lt;&lt;..."/>
            // class { }
            var builder = new System.Text.StringBuilder();
            builder.Append("/// <x a=\"");
            for (int i = 0; i < n; i++)
            {
                builder.Append("&lt;");
            }
            builder.AppendLine("\"/>");
            builder.AppendLine("class C { }");
            var text = builder.ToString();
            var tree = SyntaxFactory.ParseSyntaxTree(text, options: new CSharpParseOptions(documentationMode: DocumentationMode.Parse));
            var root = tree.GetRoot();
            var walker = new TokenAndTriviaWalker();
            walker.Visit(root);
            CustomAssert.True(walker.Tokens > n);
            var tokens = root.DescendantTokens(descendIntoTrivia: true).ToArray();
            CustomAssert.True(tokens.Length > n);
        }

        [Fact]
        public void ExceptionFilter_IfKeyword()
        {
            const string source = @"
class C
{
    void M()
    {
        try { }
        catch (System.Exception e) if (true) { }
    }
}
";

            var tree = SyntaxFactory.ParseSyntaxTree(source);
            var root = tree.GetRoot();
            tree.GetDiagnostics(root).Verify(
                // (7,36): error CS1003: Syntax error, 'when' expected
                //         catch (System.Exception e) if (true) { }
                CSharpTestBase.Diagnostic(ErrorCode.ERR_SyntaxError, "if").WithArguments("when", "if").WithLocation(7, 36));

            var filterClause = root.DescendantNodes().OfType<CatchFilterClauseSyntax>().Single();
            CustomAssert.Equal(SyntaxKind.WhenKeyword, filterClause.WhenKeyword.Kind());
            CustomAssert.True(filterClause.WhenKeyword.HasStructuredTrivia);
        }

        [Fact]
        public void Tuple001()
        {
            var source = @"
class C1
{
    static void Test(int arg1, (byte, byte) arg2)
    {
        (int, int)? t1 = new(int, int)?();
        (int, int)? t1a = new(int, int)?((1,1));
        (int, int)? t1b = new(int, int)?[1];
        (int, int)? t1c = new(int, int)?[] {(1,1)};

        (int, int)? t2 = default((int a, int b));

        (int, int) t3 = (a: (int)arg1, b: (int)arg1);

        (int, int) t4 = ((int a, int b))(arg1, arg1);
        (int, int) t5 = ((int, int))arg2;

        List<(int, int)> l = new List<(int, int)>() { (a: arg1, b: arg1), (arg1, arg1) };

        Func<(int a, int b), (int a, int b)> f = ((int a, int b) t) => t;
        
        var x = from i in ""qq""
                from j in ""ee""
                select (i, j);

        foreach ((int, int) e in new (int, int)[10])
        {
        }
    }
}
";
            var tree = SyntaxFactory.ParseSyntaxTree(source, options: TestOptions.Regular);
            tree.GetDiagnostics().Verify();
        }

        [Fact]
        [WorkItem(684860, "https://devdiv.visualstudio.com/DevDiv/_workitems/edit/266237")]
        public void DevDiv266237()
        {
            var source = @"
class Program
{
    static void Go()
    {
        using (var p = new P
        {

        }

    protected override void M()
    {

    }
}
";

            var tree = SyntaxFactory.ParseSyntaxTree(source, options: TestOptions.Regular);
            tree.GetDiagnostics(tree.GetRoot()).Verify(
                // (9,10): error CS1026: ) expected
                //         }
                CSharpTestBase.Diagnostic(ErrorCode.ERR_CloseParenExpected, "").WithLocation(9, 10),
                // (9,10): error CS1002: ; expected
                //         }
                CSharpTestBase.Diagnostic(ErrorCode.ERR_SemicolonExpected, "").WithLocation(9, 10),
                // (9,10): error CS1513: } expected
                //         }
                CSharpTestBase.Diagnostic(ErrorCode.ERR_RbraceExpected, "").WithLocation(9, 10));
        }

        [WorkItem(6676, "https://github.com/dotnet/roslyn/issues/6676")]
        [Fact]
        public void TestRunEmbeddedStatementNotFollowedBySemicolon()
        {
            var text = @"if (true)
System.Console.WriteLine(true)";
            var statement = this.ParseStatement(text);

            CustomAssert.NotNull(statement);
            CustomAssert.Equal(SyntaxKind.IfStatement, statement.Kind());
            CustomAssert.Equal(text, statement.ToString());
            CustomAssert.Equal(1, statement.Errors().Length);
            CustomAssert.Equal((int)ErrorCode.ERR_SemicolonExpected, statement.Errors()[0].Code);
        }

        [WorkItem(266237, "https://devdiv.visualstudio.com/DefaultCollection/DevDiv/_workitems?_a=edit&id=266237")]
        [Fact]
        public void NullExceptionInLabeledStatement()
        {
            UsingStatement(@"{ label: public",
                // (1,1): error CS1073: Unexpected token 'public'
                // { label: public
                Diagnostic(ErrorCode.ERR_UnexpectedToken, "{ label: ").WithArguments("public").WithLocation(1, 1),
                // (1,10): error CS1002: ; expected
                // { label: public
                Diagnostic(ErrorCode.ERR_SemicolonExpected, "public").WithLocation(1, 10),
                // (1,10): error CS1513: } expected
                // { label: public
                Diagnostic(ErrorCode.ERR_RbraceExpected, "public").WithLocation(1, 10)
                );

            N(SyntaxKind.Block);
            {
                N(SyntaxKind.OpenBraceToken);
                N(SyntaxKind.LabeledStatement);
                {
                    N(SyntaxKind.IdentifierToken, "label");
                    N(SyntaxKind.ColonToken);
                    M(SyntaxKind.EmptyStatement);
                    {
                        M(SyntaxKind.SemicolonToken);
                    }
                }
                M(SyntaxKind.CloseBraceToken);
            }
            EOF();
        }

        [WorkItem(27866, "https://github.com/dotnet/roslyn/issues/27866")]
        [Fact]
        public void ParseElseWithoutPrecedingIfStatement()
        {
            UsingStatement("else {}",
                // (1,1): error CS8641: 'else' cannot start a statement.
                // else {}
                Diagnostic(ErrorCode.ERR_ElseCannotStartStatement, "else").WithLocation(1, 1),
                // (1,1): error CS1003: Syntax error, '(' expected
                // else {}
                Diagnostic(ErrorCode.ERR_SyntaxError, "else").WithArguments("(", "else").WithLocation(1, 1),
                // (1,1): error CS1525: Invalid expression term 'else'
                // else {}
                Diagnostic(ErrorCode.ERR_InvalidExprTerm, "else").WithArguments("else").WithLocation(1, 1),
                // (1,1): error CS1026: ) expected
                // else {}
                Diagnostic(ErrorCode.ERR_CloseParenExpected, "else").WithLocation(1, 1),
                // (1,1): error CS1525: Invalid expression term 'else'
                // else {}
                Diagnostic(ErrorCode.ERR_InvalidExprTerm, "else").WithArguments("else").WithLocation(1, 1),
                // (1,1): error CS1002: ; expected
                // else {}
                Diagnostic(ErrorCode.ERR_SemicolonExpected, "else").WithLocation(1, 1)
                );
            N(SyntaxKind.IfStatement);
            {
                M(SyntaxKind.IfKeyword);
                M(SyntaxKind.OpenParenToken);
                M(SyntaxKind.IdentifierName);
                {
                    M(SyntaxKind.IdentifierToken);
                }
                M(SyntaxKind.CloseParenToken);
                M(SyntaxKind.ExpressionStatement);
                {
                    M(SyntaxKind.IdentifierName);
                    {
                        M(SyntaxKind.IdentifierToken);
                    }
                    M(SyntaxKind.SemicolonToken);
                }
                N(SyntaxKind.ElseClause);
                {
                    N(SyntaxKind.ElseKeyword);
                    N(SyntaxKind.Block);
                    {
                        N(SyntaxKind.OpenBraceToken);
                        N(SyntaxKind.CloseBraceToken);
                    }
                }
            }
            EOF();
        }

        [WorkItem(27866, "https://github.com/dotnet/roslyn/issues/27866")]
        [Fact]
        public void ParseElseAndElseWithoutPrecedingIfStatement()
        {
            UsingStatement("{ else {} else {} }",
                // (1,3): error CS8641: 'else' cannot start a statement.
                // { else {} else {} }
                Diagnostic(ErrorCode.ERR_ElseCannotStartStatement, "else").WithLocation(1, 3),
                // (1,3): error CS1003: Syntax error, '(' expected
                // { else {} else {} }
                Diagnostic(ErrorCode.ERR_SyntaxError, "else").WithArguments("(", "else").WithLocation(1, 3),
                // (1,3): error CS1525: Invalid expression term 'else'
                // { else {} else {} }
                Diagnostic(ErrorCode.ERR_InvalidExprTerm, "else").WithArguments("else").WithLocation(1, 3),
                // (1,3): error CS1026: ) expected
                // { else {} else {} }
                Diagnostic(ErrorCode.ERR_CloseParenExpected, "else").WithLocation(1, 3),
                // (1,3): error CS1525: Invalid expression term 'else'
                // { else {} else {} }
                Diagnostic(ErrorCode.ERR_InvalidExprTerm, "else").WithArguments("else").WithLocation(1, 3),
                // (1,3): error CS1002: ; expected
                // { else {} else {} }
                Diagnostic(ErrorCode.ERR_SemicolonExpected, "else").WithLocation(1, 3),
                // (1,11): error CS8641: 'else' cannot start a statement.
                // { else {} else {} }
                Diagnostic(ErrorCode.ERR_ElseCannotStartStatement, "else").WithLocation(1, 11),
                // (1,11): error CS1003: Syntax error, '(' expected
                // { else {} else {} }
                Diagnostic(ErrorCode.ERR_SyntaxError, "else").WithArguments("(", "else").WithLocation(1, 11),
                // (1,11): error CS1525: Invalid expression term 'else'
                // { else {} else {} }
                Diagnostic(ErrorCode.ERR_InvalidExprTerm, "else").WithArguments("else").WithLocation(1, 11),
                // (1,11): error CS1026: ) expected
                // { else {} else {} }
                Diagnostic(ErrorCode.ERR_CloseParenExpected, "else").WithLocation(1, 11),
                // (1,11): error CS1525: Invalid expression term 'else'
                // { else {} else {} }
                Diagnostic(ErrorCode.ERR_InvalidExprTerm, "else").WithArguments("else").WithLocation(1, 11),
                // (1,11): error CS1002: ; expected
                // { else {} else {} }
                Diagnostic(ErrorCode.ERR_SemicolonExpected, "else").WithLocation(1, 11)
                );
            N(SyntaxKind.Block);
            {
                N(SyntaxKind.OpenBraceToken);
                N(SyntaxKind.IfStatement);
                {
                    M(SyntaxKind.IfKeyword);
                    M(SyntaxKind.OpenParenToken);
                    M(SyntaxKind.IdentifierName);
                    {
                        M(SyntaxKind.IdentifierToken);
                    }
                    M(SyntaxKind.CloseParenToken);
                    M(SyntaxKind.ExpressionStatement);
                    {
                        M(SyntaxKind.IdentifierName);
                        {
                            M(SyntaxKind.IdentifierToken);
                        }
                        M(SyntaxKind.SemicolonToken);
                    }
                    N(SyntaxKind.ElseClause);
                    {
                        N(SyntaxKind.ElseKeyword);
                        N(SyntaxKind.Block);
                        {
                            N(SyntaxKind.OpenBraceToken);
                            N(SyntaxKind.CloseBraceToken);
                        }
                    }
                }
                N(SyntaxKind.IfStatement);
                {
                    M(SyntaxKind.IfKeyword);
                    M(SyntaxKind.OpenParenToken);
                    M(SyntaxKind.IdentifierName);
                    {
                        M(SyntaxKind.IdentifierToken);
                    }
                    M(SyntaxKind.CloseParenToken);
                    M(SyntaxKind.ExpressionStatement);
                    {
                        M(SyntaxKind.IdentifierName);
                        {
                            M(SyntaxKind.IdentifierToken);
                        }
                        M(SyntaxKind.SemicolonToken);
                    }
                    N(SyntaxKind.ElseClause);
                    {
                        N(SyntaxKind.ElseKeyword);
                        N(SyntaxKind.Block);
                        {
                            N(SyntaxKind.OpenBraceToken);
                            N(SyntaxKind.CloseBraceToken);
                        }
                    }
                }
                N(SyntaxKind.CloseBraceToken);
            }
            EOF();
        }

        [WorkItem(27866, "https://github.com/dotnet/roslyn/issues/27866")]
        [Fact]
        public void ParseSubsequentElseWithoutPrecedingIfStatement()
        {
            UsingStatement("{ if (a) { } else { } else { } }",
                // (1,23): error CS8641: 'else' cannot start a statement.
                // { if (a) { } else { } else { } }
                Diagnostic(ErrorCode.ERR_ElseCannotStartStatement, "else").WithLocation(1, 23),
                // (1,23): error CS1003: Syntax error, '(' expected
                // { if (a) { } else { } else { } }
                Diagnostic(ErrorCode.ERR_SyntaxError, "else").WithArguments("(", "else").WithLocation(1, 23),
                // (1,23): error CS1525: Invalid expression term 'else'
                // { if (a) { } else { } else { } }
                Diagnostic(ErrorCode.ERR_InvalidExprTerm, "else").WithArguments("else").WithLocation(1, 23),
                // (1,23): error CS1026: ) expected
                // { if (a) { } else { } else { } }
                Diagnostic(ErrorCode.ERR_CloseParenExpected, "else").WithLocation(1, 23),
                // (1,23): error CS1525: Invalid expression term 'else'
                // { if (a) { } else { } else { } }
                Diagnostic(ErrorCode.ERR_InvalidExprTerm, "else").WithArguments("else").WithLocation(1, 23),
                // (1,23): error CS1002: ; expected
                // { if (a) { } else { } else { } }
                Diagnostic(ErrorCode.ERR_SemicolonExpected, "else").WithLocation(1, 23)
                );
            N(SyntaxKind.Block);
            {
                N(SyntaxKind.OpenBraceToken);
                N(SyntaxKind.IfStatement);
                {
                    N(SyntaxKind.IfKeyword);
                    N(SyntaxKind.OpenParenToken);
                    N(SyntaxKind.IdentifierName);
                    {
                        N(SyntaxKind.IdentifierToken, "a");
                    }
                    N(SyntaxKind.CloseParenToken);
                    N(SyntaxKind.Block);
                    {
                        N(SyntaxKind.OpenBraceToken);
                        N(SyntaxKind.CloseBraceToken);
                    }
                    N(SyntaxKind.ElseClause);
                    {
                        N(SyntaxKind.ElseKeyword);
                        N(SyntaxKind.Block);
                        {
                            N(SyntaxKind.OpenBraceToken);
                            N(SyntaxKind.CloseBraceToken);
                        }
                    }
                }
                N(SyntaxKind.IfStatement);
                {
                    M(SyntaxKind.IfKeyword);
                    M(SyntaxKind.OpenParenToken);
                    M(SyntaxKind.IdentifierName);
                    {
                        M(SyntaxKind.IdentifierToken);
                    }
                    M(SyntaxKind.CloseParenToken);
                    M(SyntaxKind.ExpressionStatement);
                    {
                        M(SyntaxKind.IdentifierName);
                        {
                            M(SyntaxKind.IdentifierToken);
                        }
                        M(SyntaxKind.SemicolonToken);
                    }
                    N(SyntaxKind.ElseClause);
                    {
                        N(SyntaxKind.ElseKeyword);
                        N(SyntaxKind.Block);
                        {
                            N(SyntaxKind.OpenBraceToken);
                            N(SyntaxKind.CloseBraceToken);
                        }
                    }
                }
                N(SyntaxKind.CloseBraceToken);
            }
            EOF();
        }

        [WorkItem(27866, "https://github.com/dotnet/roslyn/issues/27866")]
        [Fact]
        public void ParseElseKeywordPlacedAsIfEmbeddedStatement()
        {
            UsingStatement("if (a) else {}",
                // (1,8): error CS8641: 'else' cannot start a statement.
                // if (a) else {}
                Diagnostic(ErrorCode.ERR_ElseCannotStartStatement, "else").WithLocation(1, 8),
                // (1,8): error CS1003: Syntax error, '(' expected
                // if (a) else {}
                Diagnostic(ErrorCode.ERR_SyntaxError, "else").WithArguments("(", "else").WithLocation(1, 8),
                // (1,8): error CS1525: Invalid expression term 'else'
                // if (a) else {}
                Diagnostic(ErrorCode.ERR_InvalidExprTerm, "else").WithArguments("else").WithLocation(1, 8),
                // (1,8): error CS1026: ) expected
                // if (a) else {}
                Diagnostic(ErrorCode.ERR_CloseParenExpected, "else").WithLocation(1, 8),
                // (1,8): error CS1525: Invalid expression term 'else'
                // if (a) else {}
                Diagnostic(ErrorCode.ERR_InvalidExprTerm, "else").WithArguments("else").WithLocation(1, 8),
                // (1,8): error CS1002: ; expected
                // if (a) else {}
                Diagnostic(ErrorCode.ERR_SemicolonExpected, "else").WithLocation(1, 8)
                );
            N(SyntaxKind.IfStatement);
            {
                N(SyntaxKind.IfKeyword);
                N(SyntaxKind.OpenParenToken);
                N(SyntaxKind.IdentifierName);
                {
                    N(SyntaxKind.IdentifierToken, "a");
                }
                N(SyntaxKind.CloseParenToken);
                N(SyntaxKind.IfStatement);
                {
                    M(SyntaxKind.IfKeyword);
                    M(SyntaxKind.OpenParenToken);
                    M(SyntaxKind.IdentifierName);
                    {
                        M(SyntaxKind.IdentifierToken);
                    }
                    M(SyntaxKind.CloseParenToken);
                    M(SyntaxKind.ExpressionStatement);
                    {
                        M(SyntaxKind.IdentifierName);
                        {
                            M(SyntaxKind.IdentifierToken);
                        }
                        M(SyntaxKind.SemicolonToken);
                    }
                    N(SyntaxKind.ElseClause);
                    {
                        N(SyntaxKind.ElseKeyword);
                        N(SyntaxKind.Block);
                        {
                            N(SyntaxKind.OpenBraceToken);
                            N(SyntaxKind.CloseBraceToken);
                        }
                    }
                }
            }
            EOF();
        }

        [Fact]
        public void ParseSwitch01()
        {
            UsingStatement("switch 1+2 {}",
                // (1,8): error CS8415: Parentheses are required around the switch governing expression.
                // switch 1+2 {}
                Diagnostic(ErrorCode.ERR_SwitchGoverningExpressionRequiresParens, "1+2").WithLocation(1, 8)
                );
            N(SyntaxKind.SwitchStatement);
            {
                N(SyntaxKind.SwitchKeyword);
                M(SyntaxKind.OpenParenToken);
                N(SyntaxKind.AddExpression);
                {
                    N(SyntaxKind.NumericLiteralExpression);
                    {
                        N(SyntaxKind.NumericLiteralToken, "1");
                    }
                    N(SyntaxKind.PlusToken);
                    N(SyntaxKind.NumericLiteralExpression);
                    {
                        N(SyntaxKind.NumericLiteralToken, "2");
                    }
                }
                M(SyntaxKind.CloseParenToken);
                N(SyntaxKind.OpenBraceToken);
                N(SyntaxKind.CloseBraceToken);
            }
            EOF();
        }

        [Fact]
        public void ParseSwitch02()
        {
            UsingStatement("switch (a: 0) {}",
                // (1,13): error CS8124: Tuple must contain at least two elements.
                // switch (a: 0) {}
                Diagnostic(ErrorCode.ERR_TupleTooFewElements, ")").WithLocation(1, 13)
                );
            N(SyntaxKind.SwitchStatement);
            {
                N(SyntaxKind.SwitchKeyword);
                N(SyntaxKind.TupleExpression);
                {
                    N(SyntaxKind.OpenParenToken);
                    N(SyntaxKind.Argument);
                    {
                        N(SyntaxKind.NameColon);
                        {
                            N(SyntaxKind.IdentifierName);
                            {
                                N(SyntaxKind.IdentifierToken, "a");
                            }
                            N(SyntaxKind.ColonToken);
                        }
                        N(SyntaxKind.NumericLiteralExpression);
                        {
                            N(SyntaxKind.NumericLiteralToken, "0");
                        }
                    }
                    M(SyntaxKind.CommaToken);
                    M(SyntaxKind.Argument);
                    {
                        M(SyntaxKind.IdentifierName);
                        {
                            M(SyntaxKind.IdentifierToken);
                        }
                    }
                    N(SyntaxKind.CloseParenToken);
                }
                N(SyntaxKind.OpenBraceToken);
                N(SyntaxKind.CloseBraceToken);
            }
            EOF();
        }

        [Fact]
        public void ParseSwitch03()
        {
            UsingStatement("switch (a: 0, b: 4) {}");
            N(SyntaxKind.SwitchStatement);
            {
                N(SyntaxKind.SwitchKeyword);
                N(SyntaxKind.TupleExpression);
                {
                    N(SyntaxKind.OpenParenToken);
                    N(SyntaxKind.Argument);
                    {
                        N(SyntaxKind.NameColon);
                        {
                            N(SyntaxKind.IdentifierName);
                            {
                                N(SyntaxKind.IdentifierToken, "a");
                            }
                            N(SyntaxKind.ColonToken);
                        }
                        N(SyntaxKind.NumericLiteralExpression);
                        {
                            N(SyntaxKind.NumericLiteralToken, "0");
                        }
                    }
                    N(SyntaxKind.CommaToken);
                    N(SyntaxKind.Argument);
                    {
                        N(SyntaxKind.NameColon);
                        {
                            N(SyntaxKind.IdentifierName);
                            {
                                N(SyntaxKind.IdentifierToken, "b");
                            }
                            N(SyntaxKind.ColonToken);
                        }
                        N(SyntaxKind.NumericLiteralExpression);
                        {
                            N(SyntaxKind.NumericLiteralToken, "4");
                        }
                    }
                    N(SyntaxKind.CloseParenToken);
                }
                N(SyntaxKind.OpenBraceToken);
                N(SyntaxKind.CloseBraceToken);
            }
            EOF();
        }

        [Fact]
        public void ParseSwitch04()
        {
            UsingStatement("switch (1) + (2) {}",
                // (1,8): error CS8415: Parentheses are required around the switch governing expression.
                // switch (1) + (2) {}
                Diagnostic(ErrorCode.ERR_SwitchGoverningExpressionRequiresParens, "(1) + (2)").WithLocation(1, 8)
                );
            N(SyntaxKind.SwitchStatement);
            {
                N(SyntaxKind.SwitchKeyword);
                M(SyntaxKind.OpenParenToken);
                N(SyntaxKind.AddExpression);
                {
                    N(SyntaxKind.ParenthesizedExpression);
                    {
                        N(SyntaxKind.OpenParenToken);
                        N(SyntaxKind.NumericLiteralExpression);
                        {
                            N(SyntaxKind.NumericLiteralToken, "1");
                        }
                        N(SyntaxKind.CloseParenToken);
                    }
                    N(SyntaxKind.PlusToken);
                    N(SyntaxKind.ParenthesizedExpression);
                    {
                        N(SyntaxKind.OpenParenToken);
                        N(SyntaxKind.NumericLiteralExpression);
                        {
                            N(SyntaxKind.NumericLiteralToken, "2");
                        }
                        N(SyntaxKind.CloseParenToken);
                    }
                }
                M(SyntaxKind.CloseParenToken);
                N(SyntaxKind.OpenBraceToken);
                N(SyntaxKind.CloseBraceToken);
            }
            EOF();
        }

        [Fact]
        public void ParseCreateNullableTuple_01()
        {
            UsingStatement("_ = new (int, int)? {};");
            N(SyntaxKind.ExpressionStatement);
            {
                N(SyntaxKind.SimpleAssignmentExpression);
                {
                    N(SyntaxKind.IdentifierName);
                    {
                        N(SyntaxKind.IdentifierToken, "_");
                    }
                    N(SyntaxKind.EqualsToken);
                    N(SyntaxKind.ObjectCreationExpression);
                    {
                        N(SyntaxKind.NewKeyword);
                        N(SyntaxKind.NullableType);
                        {
                            N(SyntaxKind.TupleType);
                            {
                                N(SyntaxKind.OpenParenToken);
                                N(SyntaxKind.TupleElement);
                                {
                                    N(SyntaxKind.PredefinedType);
                                    {
                                        N(SyntaxKind.IntKeyword);
                                    }
                                }
                                N(SyntaxKind.CommaToken);
                                N(SyntaxKind.TupleElement);
                                {
                                    N(SyntaxKind.PredefinedType);
                                    {
                                        N(SyntaxKind.IntKeyword);
                                    }
                                }
                                N(SyntaxKind.CloseParenToken);
                            }
                            N(SyntaxKind.QuestionToken);
                        }
                        N(SyntaxKind.ObjectInitializerExpression);
                        {
                            N(SyntaxKind.OpenBraceToken);
                            N(SyntaxKind.CloseBraceToken);
                        }
                    }
                }
                N(SyntaxKind.SemicolonToken);
            }
            EOF();
        }

        [Fact]
        public void ParseCreateNullableTuple_02()
        {
            UsingStatement("_ = new (int, int) ? (x) : (y);",
                // (1,1): error CS1073: Unexpected token ':'
                // _ = new (int, int) ? (x) : (y);
                Diagnostic(ErrorCode.ERR_UnexpectedToken, "_ = new (int, int) ? (x) ").WithArguments(":").WithLocation(1, 1),
                // (1,26): error CS1002: ; expected
                // _ = new (int, int) ? (x) : (y);
                Diagnostic(ErrorCode.ERR_SemicolonExpected, ":").WithLocation(1, 26)
                );
            N(SyntaxKind.ExpressionStatement);
            {
                N(SyntaxKind.SimpleAssignmentExpression);
                {
                    N(SyntaxKind.IdentifierName);
                    {
                        N(SyntaxKind.IdentifierToken, "_");
                    }
                    N(SyntaxKind.EqualsToken);
                    N(SyntaxKind.ObjectCreationExpression);
                    {
                        N(SyntaxKind.NewKeyword);
                        N(SyntaxKind.NullableType);
                        {
                            N(SyntaxKind.TupleType);
                            {
                                N(SyntaxKind.OpenParenToken);
                                N(SyntaxKind.TupleElement);
                                {
                                    N(SyntaxKind.PredefinedType);
                                    {
                                        N(SyntaxKind.IntKeyword);
                                    }
                                }
                                N(SyntaxKind.CommaToken);
                                N(SyntaxKind.TupleElement);
                                {
                                    N(SyntaxKind.PredefinedType);
                                    {
                                        N(SyntaxKind.IntKeyword);
                                    }
                                }
                                N(SyntaxKind.CloseParenToken);
                            }
                            N(SyntaxKind.QuestionToken);
                        }
                        N(SyntaxKind.ArgumentList);
                        {
                            N(SyntaxKind.OpenParenToken);
                            N(SyntaxKind.Argument);
                            {
                                N(SyntaxKind.IdentifierName);
                                {
                                    N(SyntaxKind.IdentifierToken, "x");
                                }
                            }
                            N(SyntaxKind.CloseParenToken);
                        }
                    }
                }
                M(SyntaxKind.SemicolonToken);
            }
            EOF();
        }

        [Fact]
        public void ParsePointerToArray()
        {
            UsingStatement("int []* p;",
                // (1,7): error CS1001: Identifier expected
                // int []* p;
                Diagnostic(ErrorCode.ERR_IdentifierExpected, "*").WithLocation(1, 7),
                // (1,7): error CS1003: Syntax error, ',' expected
                // int []* p;
                Diagnostic(ErrorCode.ERR_SyntaxError, "*").WithArguments(",", "*").WithLocation(1, 7)
                );
            N(SyntaxKind.LocalDeclarationStatement);
            {
                N(SyntaxKind.VariableDeclaration);
                {
                    N(SyntaxKind.ArrayType);
                    {
                        N(SyntaxKind.PredefinedType);
                        {
                            N(SyntaxKind.IntKeyword);
                        }
                        N(SyntaxKind.ArrayRankSpecifier);
                        {
                            N(SyntaxKind.OpenBracketToken);
                            N(SyntaxKind.OmittedArraySizeExpression);
                            {
                                N(SyntaxKind.OmittedArraySizeExpressionToken);
                            }
                            N(SyntaxKind.CloseBracketToken);
                        }
                    }
                    M(SyntaxKind.VariableDeclarator);
                    {
                        M(SyntaxKind.IdentifierToken);
                    }
                }
                N(SyntaxKind.SemicolonToken);
            }
            EOF();
        }

        [Fact]
        public void ParseNewNullableWithInitializer()
        {
            UsingStatement("_ = new int? {};");
            N(SyntaxKind.ExpressionStatement);
            {
                N(SyntaxKind.SimpleAssignmentExpression);
                {
                    N(SyntaxKind.IdentifierName);
                    {
                        N(SyntaxKind.IdentifierToken, "_");
                    }
                    N(SyntaxKind.EqualsToken);
                    N(SyntaxKind.ObjectCreationExpression);
                    {
                        N(SyntaxKind.NewKeyword);
                        N(SyntaxKind.NullableType);
                        {
                            N(SyntaxKind.PredefinedType);
                            {
                                N(SyntaxKind.IntKeyword);
                            }
                            N(SyntaxKind.QuestionToken);
                        }
                        N(SyntaxKind.ObjectInitializerExpression);
                        {
                            N(SyntaxKind.OpenBraceToken);
                            N(SyntaxKind.CloseBraceToken);
                        }
                    }
                }
                N(SyntaxKind.SemicolonToken);
            }
            EOF();
        }

        private sealed class TokenAndTriviaWalker : CSharpSyntaxWalker
        {
            public int Tokens;
            public TokenAndTriviaWalker()
                : base(SyntaxWalkerDepth.StructuredTrivia)
            {
            }
            public override void VisitToken(SyntaxToken token)
            {
                Tokens++;
                base.VisitToken(token);
            }
        }
    }
}
