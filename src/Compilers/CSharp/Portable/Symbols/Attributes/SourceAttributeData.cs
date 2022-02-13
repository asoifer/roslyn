// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Reflection.Metadata;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal class SourceAttributeData : CSharpAttributeData
    {
        private readonly NamedTypeSymbol _attributeClass;

        private readonly MethodSymbol? _attributeConstructor;

        private readonly ImmutableArray<TypedConstant> _constructorArguments;

        private readonly ImmutableArray<int> _constructorArgumentsSourceIndices;

        private readonly ImmutableArray<KeyValuePair<string, TypedConstant>> _namedArguments;

        private readonly bool _isConditionallyOmitted;

        private readonly bool _hasErrors;

        private readonly SyntaxReference? _applicationNode;

        internal SourceAttributeData(
                    SyntaxReference? applicationNode,
                    NamedTypeSymbol attributeClass,
                    MethodSymbol? attributeConstructor,
                    ImmutableArray<TypedConstant> constructorArguments,
                    ImmutableArray<int> constructorArgumentsSourceIndices,
                    ImmutableArray<KeyValuePair<string, TypedConstant>> namedArguments,
                    bool hasErrors,
                    bool isConditionallyOmitted)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10405, 1217, 2647);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 710, 725);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 767, 788);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 1077, 1100);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 1133, 1143);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 1188, 1204);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 1697, 1795);

                f_10405_1697_1794(!isConditionallyOmitted || (DynAbs.Tracing.TraceSender.Expression_False(10405, 1710, 1793) || attributeClass is object && (DynAbs.Tracing.TraceSender.Expression_True(10405, 1737, 1793) && f_10405_1765_1793(attributeClass))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 1809, 1855);

                f_10405_1809_1854(f_10405_1822_1853_M(!constructorArguments.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 1869, 1909);

                f_10405_1869_1908(f_10405_1882_1907_M(!namedArguments.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 1923, 2116);

                f_10405_1923_2115(constructorArgumentsSourceIndices.IsDefault || (DynAbs.Tracing.TraceSender.Expression_False(10405, 1936, 2114) || constructorArgumentsSourceIndices.Any() && (DynAbs.Tracing.TraceSender.Expression_True(10405, 2000, 2114) && constructorArgumentsSourceIndices.Length == constructorArguments.Length)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 2130, 2188);

                f_10405_2130_2187(attributeConstructor is object || (DynAbs.Tracing.TraceSender.Expression_False(10405, 2143, 2186) || hasErrors));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 2204, 2237);

                _attributeClass = attributeClass;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 2251, 2296);

                _attributeConstructor = attributeConstructor;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 2310, 2355);

                _constructorArguments = constructorArguments;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 2369, 2440);

                _constructorArgumentsSourceIndices = constructorArgumentsSourceIndices;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 2454, 2487);

                _namedArguments = namedArguments;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 2501, 2550);

                _isConditionallyOmitted = isConditionallyOmitted;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 2564, 2587);

                _hasErrors = hasErrors;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 2601, 2636);

                _applicationNode = applicationNode;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10405, 1217, 2647);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10405, 1217, 2647);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10405, 1217, 2647);
            }
        }

        internal SourceAttributeData(SyntaxReference applicationNode, NamedTypeSymbol attributeClass, MethodSymbol? attributeConstructor, bool hasErrors)
        : this(
        f_10405_2839_2854_C(applicationNode), attributeClass, attributeConstructor, constructorArguments: ImmutableArray<TypedConstant>.Empty, constructorArgumentsSourceIndices: default, namedArguments: ImmutableArray<KeyValuePair<string, TypedConstant>>.Empty, hasErrors: hasErrors, isConditionallyOmitted: false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10405, 2659, 3237);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10405, 2659, 3237);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10405, 2659, 3237);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10405, 2659, 3237);
            }
        }

        public override NamedTypeSymbol AttributeClass
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10405, 3320, 3394);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 3356, 3379);

                    return _attributeClass;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10405, 3320, 3394);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10405, 3249, 3405);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10405, 3249, 3405);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override MethodSymbol? AttributeConstructor
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10405, 3492, 3572);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 3528, 3557);

                    return _attributeConstructor;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10405, 3492, 3572);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10405, 3417, 3583);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10405, 3417, 3583);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override SyntaxReference? ApplicationSyntaxReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10405, 3679, 3754);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 3715, 3739);

                    return _applicationNode;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10405, 3679, 3754);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10405, 3595, 3765);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10405, 3595, 3765);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal ImmutableArray<int> ConstructorArgumentsSourceIndices
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10405, 4226, 4319);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 4262, 4304);

                    return _constructorArgumentsSourceIndices;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10405, 4226, 4319);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10405, 4139, 4330);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10405, 4139, 4330);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal CSharpSyntaxNode GetAttributeArgumentSyntax(int parameterIndex, AttributeSyntax attributeSyntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10405, 4342, 6062);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 4568, 4598);

                f_10405_4568_4597(f_10405_4581_4596_M(!this.HasErrors));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 4612, 4662);

                f_10405_4612_4661(f_10405_4625_4650(this) is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 4676, 4710);

                f_10405_4676_4709(parameterIndex >= 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 4724, 4796);

                f_10405_4724_4795(parameterIndex < f_10405_4754_4794(f_10405_4754_4779(this)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 4810, 4848);

                f_10405_4810_4847(attributeSyntax != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 4864, 6051) || true) && (_constructorArgumentsSourceIndices.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10405, 4864, 6051);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 5024, 5075);

                    f_10405_5024_5074(f_10405_5037_5065(attributeSyntax) != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 5093, 5196);

                    f_10405_5093_5195(f_10405_5106_5146(f_10405_5106_5131(this)) <= f_10405_5150_5178(attributeSyntax).Arguments.Count);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 5216, 5278);

                    return f_10405_5223_5261(f_10405_5223_5251(attributeSyntax))[parameterIndex];
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10405, 4864, 6051);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10405, 4864, 6051);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 5344, 5416);

                    int
                    sourceArgIndex = _constructorArgumentsSourceIndices[parameterIndex]
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 5436, 6036) || true) && (sourceArgIndex == -1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10405, 5436, 6036);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 5590, 5668);

                        f_10405_5590_5667(f_10405_5603_5666(f_10405_5603_5639(f_10405_5603_5628(this))[parameterIndex]));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 5690, 5718);

                        return f_10405_5697_5717(attributeSyntax);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10405, 5436, 6036);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10405, 5436, 6036);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 5800, 5834);

                        f_10405_5800_5833(sourceArgIndex >= 0);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 5856, 5933);

                        f_10405_5856_5932(sourceArgIndex < attributeSyntax.ArgumentList!.Arguments.Count);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 5955, 6017);

                        return f_10405_5962_6000(f_10405_5962_5990(attributeSyntax))[sourceArgIndex];
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10405, 5436, 6036);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10405, 4864, 6051);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10405, 4342, 6062);

                bool
                f_10405_4581_4596_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10405, 4581, 4596);
                    return return_v;
                }


                int
                f_10405_4568_4597(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10405, 4568, 4597);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10405_4625_4650(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData
                this_param)
                {
                    var return_v = this_param.AttributeConstructor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10405, 4625, 4650);
                    return return_v;
                }


                int
                f_10405_4612_4661(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10405, 4612, 4661);
                    return 0;
                }


                int
                f_10405_4676_4709(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10405, 4676, 4709);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10405_4754_4779(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData
                this_param)
                {
                    var return_v = this_param.AttributeConstructor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10405, 4754, 4779);
                    return return_v;
                }


                int
                f_10405_4754_4794(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10405, 4754, 4794);
                    return return_v;
                }


                int
                f_10405_4724_4795(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10405, 4724, 4795);
                    return 0;
                }


                int
                f_10405_4810_4847(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10405, 4810, 4847);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentListSyntax?
                f_10405_5037_5065(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.ArgumentList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10405, 5037, 5065);
                    return return_v;
                }


                int
                f_10405_5024_5074(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10405, 5024, 5074);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10405_5106_5131(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData
                this_param)
                {
                    var return_v = this_param.AttributeConstructor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10405, 5106, 5131);
                    return return_v;
                }


                int
                f_10405_5106_5146(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10405, 5106, 5146);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentListSyntax
                f_10405_5150_5178(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.ArgumentList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10405, 5150, 5178);
                    return return_v;
                }


                int
                f_10405_5093_5195(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10405, 5093, 5195);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentListSyntax
                f_10405_5223_5251(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.ArgumentList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10405, 5223, 5251);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax>
                f_10405_5223_5261(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentListSyntax
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10405, 5223, 5261);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10405_5603_5628(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData
                this_param)
                {
                    var return_v = this_param.AttributeConstructor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10405, 5603, 5628);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10405_5603_5639(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10405, 5603, 5639);
                    return return_v;
                }


                bool
                f_10405_5603_5666(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.IsOptional;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10405, 5603, 5666);
                    return return_v;
                }


                int
                f_10405_5590_5667(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10405, 5590, 5667);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10405_5697_5717(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10405, 5697, 5717);
                    return return_v;
                }


                int
                f_10405_5800_5833(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10405, 5800, 5833);
                    return 0;
                }


                int
                f_10405_5856_5932(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10405, 5856, 5932);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentListSyntax
                f_10405_5962_5990(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.ArgumentList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10405, 5962, 5990);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax>
                f_10405_5962_6000(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentListSyntax
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10405, 5962, 6000);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10405, 4342, 6062);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10405, 4342, 6062);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool IsConditionallyOmitted
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10405, 6144, 6226);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 6180, 6211);

                    return _isConditionallyOmitted;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10405, 6144, 6226);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10405, 6074, 6237);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10405, 6074, 6237);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal SourceAttributeData WithOmittedCondition(bool isConditionallyOmitted)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10405, 6249, 6820);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 6352, 6809) || true) && (f_10405_6356_6383(this) == isConditionallyOmitted)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10405, 6352, 6809);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 6443, 6455);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10405, 6352, 6809);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10405, 6352, 6809);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 6521, 6794);

                    return f_10405_6528_6793(f_10405_6552_6583(this), f_10405_6585_6604(this), f_10405_6606_6631(this), f_10405_6633_6664(this), f_10405_6687_6725(this), f_10405_6727_6752(this), f_10405_6754_6768(this), isConditionallyOmitted);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10405, 6352, 6809);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10405, 6249, 6820);

                bool
                f_10405_6356_6383(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData
                this_param)
                {
                    var return_v = this_param.IsConditionallyOmitted;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10405, 6356, 6383);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxReference?
                f_10405_6552_6583(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData
                this_param)
                {
                    var return_v = this_param.ApplicationSyntaxReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10405, 6552, 6583);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10405_6585_6604(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData
                this_param)
                {
                    var return_v = this_param.AttributeClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10405, 6585, 6604);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10405_6606_6631(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData
                this_param)
                {
                    var return_v = this_param.AttributeConstructor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10405, 6606, 6631);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10405_6633_6664(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData
                this_param)
                {
                    var return_v = this_param.CommonConstructorArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10405, 6633, 6664);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<int>
                f_10405_6687_6725(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData
                this_param)
                {
                    var return_v = this_param.ConstructorArgumentsSourceIndices;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10405, 6687, 6725);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                f_10405_6727_6752(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData
                this_param)
                {
                    var return_v = this_param.CommonNamedArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10405, 6727, 6752);
                    return return_v;
                }


                bool
                f_10405_6754_6768(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10405, 6754, 6768);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData
                f_10405_6528_6793(Microsoft.CodeAnalysis.SyntaxReference?
                applicationNode, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                attributeClass, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                attributeConstructor, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                constructorArguments, System.Collections.Immutable.ImmutableArray<int>
                constructorArgumentsSourceIndices, System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                namedArguments, bool
                hasErrors, bool
                isConditionallyOmitted)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData(applicationNode, attributeClass, attributeConstructor, constructorArguments, constructorArgumentsSourceIndices, namedArguments, hasErrors, isConditionallyOmitted);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10405, 6528, 6793);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10405, 6249, 6820);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10405, 6249, 6820);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [MemberNotNullWhen(true, nameof(AttributeClass), nameof(AttributeConstructor))]
        internal override bool HasErrors
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10405, 6978, 7047);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 7014, 7032);

                    return _hasErrors;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10405, 6978, 7047);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10405, 6832, 7058);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10405, 6832, 7058);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected internal sealed override ImmutableArray<TypedConstant> CommonConstructorArguments
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10405, 7186, 7223);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 7192, 7221);

                    return _constructorArguments;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10405, 7186, 7223);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10405, 7070, 7234);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10405, 7070, 7234);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected internal sealed override ImmutableArray<KeyValuePair<string, TypedConstant>> CommonNamedArguments
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10405, 7378, 7409);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 7384, 7407);

                    return _namedArguments;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10405, 7378, 7409);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10405, 7246, 7420);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10405, 7246, 7420);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override int GetTargetAttributeSignatureIndex(Symbol targetSymbol, AttributeDescription description)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10405, 8072, 17837);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 8206, 8328) || true) && (!f_10405_8211_8269(this, description.Namespace, description.Name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10405, 8206, 8328);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 8303, 8313);

                    return -1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10405, 8206, 8328);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 8344, 8381);

                var
                ctor = f_10405_8355_8380(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 8501, 8576) || true) && (ctor is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10405, 8501, 8576);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 8551, 8561);

                    return -1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10405, 8501, 8576);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 8646, 8680);

                TypeSymbol?
                lazySystemType = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 8696, 8757);

                ImmutableArray<ParameterSymbol>
                parameters = f_10405_8741_8756(ctor)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 8782, 8800);

                    for (int
        signatureIndex = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 8773, 9142) || true) && (signatureIndex < f_10405_8819_8848(description.Signatures))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 8850, 8866)
        , signatureIndex++, DynAbs.Tracing.TraceSender.TraceExitCondition(10405, 8773, 9142))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10405, 8773, 9142);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 8900, 8964);

                        byte[]
                        targetSignature = description.Signatures[signatureIndex]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 8984, 9127) || true) && (f_10405_8988_9044(targetSignature, parameters, ref lazySystemType))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10405, 8984, 9127);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 9086, 9108);

                            return signatureIndex;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10405, 8984, 9127);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10405, 1, 370);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10405, 1, 370);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 9158, 9168);

                return -1;

                bool matches(byte[] targetSignature, ImmutableArray<ParameterSymbol> parameters, ref TypeSymbol? lazySystemType)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10405, 9184, 17826);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 9329, 9463) || true) && (targetSignature[0] != (byte)SignatureAttributes.Instance)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10405, 9329, 9463);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 9431, 9444);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10405, 9329, 9463);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 9483, 9524);

                        byte
                        parameterCount = targetSignature[1]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 9542, 9655) || true) && (parameterCount != parameters.Length)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10405, 9542, 9655);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 9623, 9636);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10405, 9542, 9655);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 9675, 9816) || true) && ((SignatureTypeCode)targetSignature[2] != SignatureTypeCode.Void)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10405, 9675, 9816);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 9784, 9797);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10405, 9675, 9816);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 9836, 9859);

                        int
                        parameterIndex = 0
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 9886, 9908);
                            for (int
            signatureByteIndex = 3
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 9877, 17779) || true) && (signatureByteIndex < f_10405_9931_9953(targetSignature))
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 9955, 9975)
            , signatureByteIndex++, DynAbs.Tracing.TraceSender.TraceExitCondition(10405, 9877, 17779))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10405, 9877, 17779);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 10017, 10142) || true) && (parameterIndex >= parameters.Length)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10405, 10017, 10142);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 10106, 10119);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10405, 10017, 10142);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 10166, 10225);

                                TypeSymbol
                                parameterType = f_10405_10193_10224(parameters[parameterIndex])
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 10247, 10296);

                                SpecialType
                                specType = f_10405_10270_10295(parameterType)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 10318, 10372);

                                byte
                                targetType = targetSignature[signatureByteIndex]
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 10396, 12179) || true) && (targetType == (byte)SignatureTypeCode.TypeHandle)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10405, 10396, 12179);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 10498, 10519);

                                    signatureByteIndex++;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 10547, 10737) || true) && (f_10405_10551_10569(parameterType) != SymbolKind.NamedType && (DynAbs.Tracing.TraceSender.Expression_True(10405, 10551, 10639) && f_10405_10597_10615(parameterType) != SymbolKind.ErrorType))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10405, 10547, 10737);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 10697, 10710);

                                        return false;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10405, 10547, 10737);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 10765, 10812);

                                    var
                                    namedType = (NamedTypeSymbol)parameterType
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 10838, 10969);

                                    AttributeDescription.TypeHandleTargetInfo
                                    targetInfo = AttributeDescription.TypeHandleTargets[targetSignature[signatureByteIndex]]
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 11162, 11434) || true) && (!f_10405_11167_11254(f_10405_11181_11203(namedType), targetInfo.Name, System.StringComparison.Ordinal) || (DynAbs.Tracing.TraceSender.Expression_False(10405, 11166, 11336) || !f_10405_11288_11336(namedType, targetInfo.Namespace)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10405, 11162, 11434);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 11394, 11407);

                                        return false;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10405, 11162, 11434);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 11462, 11503);

                                    targetType = (byte)targetInfo.Underlying;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 11531, 11708) || true) && (f_10405_11535_11561(parameterType))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10405, 11531, 11708);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 11619, 11681);

                                        specType = f_10405_11630_11680(f_10405_11630_11667(parameterType)!);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10405, 11531, 11708);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10405, 10396, 12179);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10405, 10396, 12179);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 11758, 12179) || true) && (targetType != (byte)SignatureTypeCode.SZArray && (DynAbs.Tracing.TraceSender.Expression_True(10405, 11762, 11834) && f_10405_11811_11834(parameterType)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10405, 11758, 12179);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 11884, 12060) || true) && (targetSignature[signatureByteIndex - 1] != (byte)SignatureTypeCode.SZArray)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10405, 11884, 12060);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 12020, 12033);

                                            return false;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10405, 11884, 12060);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 12088, 12156);

                                        specType = f_10405_12099_12155(f_10405_12099_12143(((ArrayTypeSymbol)parameterType)));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10405, 11758, 12179);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10405, 10396, 12179);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 12203, 17760);

                                switch (targetType)
                                {

                                    case (byte)SignatureTypeCode.Boolean:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10405, 12203, 17760);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 12338, 12490) || true) && (specType != SpecialType.System_Boolean)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10405, 12338, 12490);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 12446, 12459);

                                            return false;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10405, 12338, 12490);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 12520, 12540);

                                        parameterIndex += 1;
                                        DynAbs.Tracing.TraceSender.TraceBreak(10405, 12570, 12576);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10405, 12203, 17760);

                                    case (byte)SignatureTypeCode.Char:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10405, 12203, 17760);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 12668, 12817) || true) && (specType != SpecialType.System_Char)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10405, 12668, 12817);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 12773, 12786);

                                            return false;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10405, 12668, 12817);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 12847, 12867);

                                        parameterIndex += 1;
                                        DynAbs.Tracing.TraceSender.TraceBreak(10405, 12897, 12903);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10405, 12203, 17760);

                                    case (byte)SignatureTypeCode.SByte:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10405, 12203, 17760);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 12996, 13146) || true) && (specType != SpecialType.System_SByte)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10405, 12996, 13146);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 13102, 13115);

                                            return false;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10405, 12996, 13146);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 13176, 13196);

                                        parameterIndex += 1;
                                        DynAbs.Tracing.TraceSender.TraceBreak(10405, 13226, 13232);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10405, 12203, 17760);

                                    case (byte)SignatureTypeCode.Byte:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10405, 12203, 17760);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 13324, 13473) || true) && (specType != SpecialType.System_Byte)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10405, 13324, 13473);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 13429, 13442);

                                            return false;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10405, 13324, 13473);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 13503, 13523);

                                        parameterIndex += 1;
                                        DynAbs.Tracing.TraceSender.TraceBreak(10405, 13553, 13559);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10405, 12203, 17760);

                                    case (byte)SignatureTypeCode.Int16:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10405, 12203, 17760);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 13652, 13802) || true) && (specType != SpecialType.System_Int16)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10405, 13652, 13802);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 13758, 13771);

                                            return false;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10405, 13652, 13802);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 13832, 13852);

                                        parameterIndex += 1;
                                        DynAbs.Tracing.TraceSender.TraceBreak(10405, 13882, 13888);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10405, 12203, 17760);

                                    case (byte)SignatureTypeCode.UInt16:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10405, 12203, 17760);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 13982, 14133) || true) && (specType != SpecialType.System_UInt16)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10405, 13982, 14133);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 14089, 14102);

                                            return false;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10405, 13982, 14133);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 14163, 14183);

                                        parameterIndex += 1;
                                        DynAbs.Tracing.TraceSender.TraceBreak(10405, 14213, 14219);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10405, 12203, 17760);

                                    case (byte)SignatureTypeCode.Int32:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10405, 12203, 17760);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 14312, 14462) || true) && (specType != SpecialType.System_Int32)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10405, 14312, 14462);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 14418, 14431);

                                            return false;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10405, 14312, 14462);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 14492, 14512);

                                        parameterIndex += 1;
                                        DynAbs.Tracing.TraceSender.TraceBreak(10405, 14542, 14548);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10405, 12203, 17760);

                                    case (byte)SignatureTypeCode.UInt32:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10405, 12203, 17760);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 14642, 14793) || true) && (specType != SpecialType.System_UInt32)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10405, 14642, 14793);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 14749, 14762);

                                            return false;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10405, 14642, 14793);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 14823, 14843);

                                        parameterIndex += 1;
                                        DynAbs.Tracing.TraceSender.TraceBreak(10405, 14873, 14879);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10405, 12203, 17760);

                                    case (byte)SignatureTypeCode.Int64:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10405, 12203, 17760);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 14972, 15122) || true) && (specType != SpecialType.System_Int64)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10405, 14972, 15122);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 15078, 15091);

                                            return false;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10405, 14972, 15122);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 15152, 15172);

                                        parameterIndex += 1;
                                        DynAbs.Tracing.TraceSender.TraceBreak(10405, 15202, 15208);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10405, 12203, 17760);

                                    case (byte)SignatureTypeCode.UInt64:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10405, 12203, 17760);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 15302, 15453) || true) && (specType != SpecialType.System_UInt64)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10405, 15302, 15453);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 15409, 15422);

                                            return false;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10405, 15302, 15453);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 15483, 15503);

                                        parameterIndex += 1;
                                        DynAbs.Tracing.TraceSender.TraceBreak(10405, 15533, 15539);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10405, 12203, 17760);

                                    case (byte)SignatureTypeCode.Single:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10405, 12203, 17760);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 15633, 15784) || true) && (specType != SpecialType.System_Single)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10405, 15633, 15784);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 15740, 15753);

                                            return false;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10405, 15633, 15784);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 15814, 15834);

                                        parameterIndex += 1;
                                        DynAbs.Tracing.TraceSender.TraceBreak(10405, 15864, 15870);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10405, 12203, 17760);

                                    case (byte)SignatureTypeCode.Double:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10405, 12203, 17760);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 15964, 16115) || true) && (specType != SpecialType.System_Double)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10405, 15964, 16115);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 16071, 16084);

                                            return false;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10405, 15964, 16115);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 16145, 16165);

                                        parameterIndex += 1;
                                        DynAbs.Tracing.TraceSender.TraceBreak(10405, 16195, 16201);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10405, 12203, 17760);

                                    case (byte)SignatureTypeCode.String:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10405, 12203, 17760);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 16295, 16446) || true) && (specType != SpecialType.System_String)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10405, 16295, 16446);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 16402, 16415);

                                            return false;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10405, 16295, 16446);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 16476, 16496);

                                        parameterIndex += 1;
                                        DynAbs.Tracing.TraceSender.TraceBreak(10405, 16526, 16532);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10405, 12203, 17760);

                                    case (byte)SignatureTypeCode.Object:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10405, 12203, 17760);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 16626, 16777) || true) && (specType != SpecialType.System_Object)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10405, 16626, 16777);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 16733, 16746);

                                            return false;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10405, 16626, 16777);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 16807, 16827);

                                        parameterIndex += 1;
                                        DynAbs.Tracing.TraceSender.TraceBreak(10405, 16857, 16863);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10405, 12203, 17760);

                                    case (byte)SerializationTypeCode.Type:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10405, 12203, 17760);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 16959, 17006);

                                        if (lazySystemType is null)
                                            DynAbs.Tracing.TraceSender.TraceEnterExpression(10405, 16959, 17006);

                                        lazySystemType ??= f_10405_16978_17005(this, targetSymbol);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 17038, 17237) || true) && (!f_10405_17043_17127(parameterType, lazySystemType, TypeCompareKind.ConsiderEverything))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10405, 17038, 17237);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 17193, 17206);

                                            return false;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10405, 17038, 17237);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 17267, 17287);

                                        parameterIndex += 1;
                                        DynAbs.Tracing.TraceSender.TraceBreak(10405, 17317, 17323);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10405, 12203, 17760);

                                    case (byte)SignatureTypeCode.SZArray:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10405, 12203, 17760);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 17484, 17622) || true) && (!f_10405_17489_17512(parameterType))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10405, 17484, 17622);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 17578, 17591);

                                            return false;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10405, 17484, 17622);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceBreak(10405, 17652, 17658);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10405, 12203, 17760);

                                    default:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10405, 12203, 17760);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 17724, 17737);

                                        return false;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10405, 12203, 17760);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10405, 1, 7903);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10405, 1, 7903);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 17799, 17811);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10405, 9184, 17826);

                        int
                        f_10405_9931_9953(byte[]
                        this_param)
                        {
                            var return_v = this_param.Length;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10405, 9931, 9953);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        f_10405_10193_10224(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10405, 10193, 10224);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SpecialType
                        f_10405_10270_10295(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        this_param)
                        {
                            var return_v = this_param.SpecialType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10405, 10270, 10295);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SymbolKind
                        f_10405_10551_10569(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10405, 10551, 10569);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SymbolKind
                        f_10405_10597_10615(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10405, 10597, 10615);
                            return return_v;
                        }


                        string
                        f_10405_11181_11203(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        this_param)
                        {
                            var return_v = this_param.MetadataName;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10405, 11181, 11203);
                            return return_v;
                        }


                        bool
                        f_10405_11167_11254(string
                        a, string
                        b, System.StringComparison
                        comparisonType)
                        {
                            var return_v = string.Equals(a, b, comparisonType);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10405, 11167, 11254);
                            return return_v;
                        }


                        bool
                        f_10405_11288_11336(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        type, string
                        qualifiedName)
                        {
                            var return_v = type.HasNameQualifier(qualifiedName);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10405, 11288, 11336);
                            return return_v;
                        }


                        bool
                        f_10405_11535_11561(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        type)
                        {
                            var return_v = type.IsEnumType();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10405, 11535, 11561);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                        f_10405_11630_11667(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        type)
                        {
                            var return_v = type.GetEnumUnderlyingType();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10405, 11630, 11667);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SpecialType
                        f_10405_11630_11680(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        this_param)
                        {
                            var return_v = this_param.SpecialType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10405, 11630, 11680);
                            return return_v;
                        }


                        bool
                        f_10405_11811_11834(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        type)
                        {
                            var return_v = type.IsArray();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10405, 11811, 11834);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        f_10405_12099_12143(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                        this_param)
                        {
                            var return_v = this_param.ElementType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10405, 12099, 12143);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SpecialType
                        f_10405_12099_12155(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        this_param)
                        {
                            var return_v = this_param.SpecialType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10405, 12099, 12155);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        f_10405_16978_17005(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                        targetSymbol)
                        {
                            var return_v = this_param.GetSystemType(targetSymbol);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10405, 16978, 17005);
                            return return_v;
                        }


                        bool
                        f_10405_17043_17127(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        right, Microsoft.CodeAnalysis.TypeCompareKind
                        comparison)
                        {
                            var return_v = TypeSymbol.Equals(left, right, comparison);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10405, 17043, 17127);
                            return return_v;
                        }


                        bool
                        f_10405_17489_17512(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        type)
                        {
                            var return_v = type.IsArray();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10405, 17489, 17512);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10405, 9184, 17826);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10405, 9184, 17826);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10405, 8072, 17837);

                bool
                f_10405_8211_8269(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData
                this_param, string
                namespaceName, string
                typeName)
                {
                    var return_v = this_param.IsTargetAttribute(namespaceName, typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10405, 8211, 8269);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10405_8355_8380(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData
                this_param)
                {
                    var return_v = this_param.AttributeConstructor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10405, 8355, 8380);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10405_8741_8756(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10405, 8741, 8756);
                    return return_v;
                }


                int
                f_10405_8819_8848(byte[][]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10405, 8819, 8848);
                    return return_v;
                }


                bool
                f_10405_8988_9044(byte[]
                targetSignature, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, ref Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                lazySystemType)
                {
                    var return_v = matches(targetSignature, parameters, ref lazySystemType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10405, 8988, 9044);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10405, 8072, 17837);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10405, 8072, 17837);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual TypeSymbol GetSystemType(Symbol targetSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10405, 18138, 18321);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10405, 18225, 18310);

                return f_10405_18232_18309(f_10405_18232_18265(targetSymbol), WellKnownType.System_Type);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10405, 18138, 18321);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10405_18232_18265(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10405, 18232, 18265);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10405_18232_18309(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10405, 18232, 18309);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10405, 18138, 18321);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10405, 18138, 18321);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SourceAttributeData()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10405, 604, 18328);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10405, 604, 18328);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10405, 604, 18328);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10405, 604, 18328);

        bool
        f_10405_1765_1793(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.IsConditional;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10405, 1765, 1793);
            return return_v;
        }


        int
        f_10405_1697_1794(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10405, 1697, 1794);
            return 0;
        }


        bool
        f_10405_1822_1853_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10405, 1822, 1853);
            return return_v;
        }


        int
        f_10405_1809_1854(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10405, 1809, 1854);
            return 0;
        }


        bool
        f_10405_1882_1907_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10405, 1882, 1907);
            return return_v;
        }


        int
        f_10405_1869_1908(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10405, 1869, 1908);
            return 0;
        }


        int
        f_10405_1923_2115(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10405, 1923, 2115);
            return 0;
        }


        int
        f_10405_2130_2187(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10405, 2130, 2187);
            return 0;
        }


        static Microsoft.CodeAnalysis.SyntaxReference
        f_10405_2839_2854_C(Microsoft.CodeAnalysis.SyntaxReference
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10405, 2659, 3237);
            return return_v;
        }

    }
}
