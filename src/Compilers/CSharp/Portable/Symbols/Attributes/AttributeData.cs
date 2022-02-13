// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Reflection;
using Microsoft.CodeAnalysis.CodeGen;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;
using Microsoft.CodeAnalysis;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal abstract partial class CSharpAttributeData : AttributeData
    {
        private ThreeState _lazyIsSecurityAttribute;

        public new abstract NamedTypeSymbol? AttributeClass { get; }

        public new abstract MethodSymbol? AttributeConstructor { get; }

        public new abstract SyntaxReference? ApplicationSyntaxReference { get; }

        [MemberNotNullWhen(true, nameof(AttributeClass), nameof(AttributeConstructor))]
        internal override bool HasErrors
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10402, 1836, 2158);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 1872, 1903);

                    var
                    hasErrors = DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.HasErrors, 10402, 1888, 1902)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 1921, 2106) || true) && (!hasErrors)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 1921, 2106);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 1977, 2018);

                        f_10402_1977_2017(f_10402_1990_2004() is not null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 2040, 2087);

                        f_10402_2040_2086(f_10402_2053_2073() is not null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 1921, 2106);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 2126, 2143);

                    return hasErrors;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10402, 1836, 2158);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                    f_10402_1990_2004()
                    {
                        var return_v = AttributeClass;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 1990, 2004);
                        return return_v;
                    }


                    int
                    f_10402_1977_2017(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 1977, 2017);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                    f_10402_2053_2073()
                    {
                        var return_v = AttributeConstructor;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 2053, 2073);
                        return return_v;
                    }


                    int
                    f_10402_2040_2086(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 2040, 2086);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10402, 1690, 2169);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10402, 1690, 2169);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public new IEnumerable<TypedConstant> ConstructorArguments
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10402, 2537, 2584);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 2543, 2582);

                    return f_10402_2550_2581(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10402, 2537, 2584);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                    f_10402_2550_2581(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                    this_param)
                    {
                        var return_v = this_param.CommonConstructorArguments;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 2550, 2581);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10402, 2454, 2595);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10402, 2454, 2595);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public new IEnumerable<KeyValuePair<string, TypedConstant>> NamedArguments
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10402, 2871, 2912);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 2877, 2910);

                    return f_10402_2884_2909(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10402, 2871, 2912);

                    System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                    f_10402_2884_2909(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                    this_param)
                    {
                        var return_v = this_param.CommonNamedArguments;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 2884, 2909);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10402, 2772, 2923);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10402, 2772, 2923);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual bool IsTargetAttribute(string namespaceName, string typeName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10402, 3126, 3716);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 3229, 3273);

                f_10402_3229_3272(f_10402_3242_3261(this) is object);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 3289, 3397) || true) && (!f_10402_3294_3335(f_10402_3294_3318(f_10402_3294_3313(this)), typeName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 3289, 3397);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 3369, 3382);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 3289, 3397);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 3413, 3630) || true) && (f_10402_3417_3450(f_10402_3417_3436(this)) && (DynAbs.Tracing.TraceSender.Expression_True(10402, 3417, 3505) && !(f_10402_3456_3475(this) is MissingMetadataTypeSymbol)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 3413, 3630);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 3602, 3615);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 3413, 3630);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 3646, 3705);

                return f_10402_3653_3704(f_10402_3653_3672(this), namespaceName);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10402, 3126, 3716);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10402_3242_3261(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.AttributeClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 3242, 3261);
                    return return_v;
                }


                int
                f_10402_3229_3272(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 3229, 3272);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10402_3294_3313(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.AttributeClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 3294, 3313);
                    return return_v;
                }


                string
                f_10402_3294_3318(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 3294, 3318);
                    return return_v;
                }


                bool
                f_10402_3294_3335(string
                this_param, string
                value)
                {
                    var return_v = this_param.Equals(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 3294, 3335);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10402_3417_3436(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.AttributeClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 3417, 3436);
                    return return_v;
                }


                bool
                f_10402_3417_3450(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 3417, 3450);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10402_3456_3475(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.AttributeClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 3456, 3475);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10402_3653_3672(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.AttributeClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 3653, 3672);
                    return return_v;
                }


                bool
                f_10402_3653_3704(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, string
                qualifiedName)
                {
                    var return_v = type.HasNameQualifier(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 3653, 3704);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10402, 3126, 3716);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10402, 3126, 3716);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsTargetAttribute(Symbol targetSymbol, AttributeDescription description)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10402, 3728, 3923);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 3839, 3912);

                return f_10402_3846_3905(this, targetSymbol, description) != -1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10402, 3728, 3923);

                int
                f_10402_3846_3905(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.GetTargetAttributeSignatureIndex(targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 3846, 3905);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10402, 3728, 3923);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10402, 3728, 3923);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal abstract int GetTargetAttributeSignatureIndex(Symbol targetSymbol, AttributeDescription description);

        internal static bool IsTargetEarlyAttribute(NamedTypeSymbol attributeType, AttributeSyntax attributeSyntax, AttributeDescription description)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10402, 4488, 5027);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 4654, 4697);

                f_10402_4654_4696(!f_10402_4668_4695(attributeType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 4713, 4915);

                int
                argumentCount = (DynAbs.Tracing.TraceSender.Conditional_F1(10402, 4733, 4771) || (((f_10402_4734_4762(attributeSyntax) != null) && DynAbs.Tracing.TraceSender.Conditional_F2(10402, 4791, 4893)) || DynAbs.Tracing.TraceSender.Conditional_F3(10402, 4913, 4914))) ? f_10402_4791_4893(f_10402_4791_4819(attributeSyntax).Arguments, (arg) => arg.NameEquals == null) : 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 4929, 5016);

                return f_10402_4936_5015(attributeType, argumentCount, description);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10402, 4488, 5027);

                bool
                f_10402_4668_4695(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 4668, 4695);
                    return return_v;
                }


                int
                f_10402_4654_4696(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 4654, 4696);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentListSyntax?
                f_10402_4734_4762(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.ArgumentList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 4734, 4762);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentListSyntax
                f_10402_4791_4819(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.ArgumentList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 4791, 4819);
                    return return_v;
                }


                int
                f_10402_4791_4893(Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax>
                source, System.Func<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax, bool>
                predicate)
                {
                    var return_v = source.Count<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 4791, 4893);
                    return return_v;
                }


                bool
                f_10402_4936_5015(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                attributeType, int
                attributeArgCount, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = AttributeData.IsTargetEarlyAttribute((Microsoft.CodeAnalysis.Symbols.INamedTypeSymbolInternal)attributeType, attributeArgCount, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 4936, 5015);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10402, 4488, 5027);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10402, 4488, 5027);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsSecurityAttribute(CSharpCompilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10402, 5179, 6893);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 5268, 6826) || true) && (_lazyIsSecurityAttribute == ThreeState.Unknown)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 5268, 6826);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 5352, 5382);

                    f_10402_5352_5381(f_10402_5365_5380_M(!this.HasErrors));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 6391, 6501);

                    var
                    wellKnownType = f_10402_6411_6500(compilation, WellKnownType.System_Security_Permissions_SecurityAttribute)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 6519, 6558);

                    f_10402_6519_6557(f_10402_6532_6546() is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 6576, 6627);

                    HashSet<DiagnosticInfo>?
                    useSiteDiagnostics = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 6645, 6811);

                    _lazyIsSecurityAttribute = f_10402_6672_6810(f_10402_6672_6795(f_10402_6672_6686(), wellKnownType, TypeCompareKind.ConsiderEverything, useSiteDiagnostics: ref useSiteDiagnostics));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 5268, 6826);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 6842, 6882);

                return f_10402_6849_6881(_lazyIsSecurityAttribute);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10402, 5179, 6893);

                bool
                f_10402_5365_5380_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 5365, 5380);
                    return return_v;
                }


                int
                f_10402_5352_5381(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 5352, 5381);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10402_6411_6500(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 6411, 6500);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10402_6532_6546()
                {
                    var return_v = AttributeClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 6532, 6546);
                    return return_v;
                }


                int
                f_10402_6519_6557(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 6519, 6557);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10402_6672_6686()
                {
                    var return_v = AttributeClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 6672, 6686);
                    return return_v;
                }


                bool
                f_10402_6672_6795(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.TypeCompareKind
                comparison, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.IsDerivedFrom((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, comparison, useSiteDiagnostics: ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 6672, 6795);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ThreeState
                f_10402_6672_6810(bool
                value)
                {
                    var return_v = value.ToThreeState();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 6672, 6810);
                    return return_v;
                }


                bool
                f_10402_6849_6881(Microsoft.CodeAnalysis.ThreeState
                value)
                {
                    var return_v = value.Value();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 6849, 6881);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10402, 5179, 6893);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10402, 5179, 6893);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string? ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10402, 7198, 8910);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 7257, 8860) || true) && (f_10402_7261_7280(this) is object)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 7257, 8860);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 7324, 7424);

                    string
                    className = f_10402_7343_7423(f_10402_7343_7362(this), SymbolDisplayFormat.QualifiedNameOnlyFormat)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 7444, 7599) || true) && (!this.CommonConstructorArguments.Any() & !this.CommonNamedArguments.Any())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 7444, 7599);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 7563, 7580);

                        return className;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 7444, 7599);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 7619, 7676);

                    var
                    pooledStrbuilder = f_10402_7642_7675()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 7694, 7749);

                    StringBuilder
                    stringBuilder = pooledStrbuilder.Builder
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 7769, 7801);

                    f_10402_7769_7800(
                                    stringBuilder, className);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 7819, 7845);

                    f_10402_7819_7844(stringBuilder, "(");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 7865, 7883);

                    bool
                    first = true
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 7903, 8260);
                        foreach (var constructorArgument in f_10402_7939_7970_I(f_10402_7939_7970(this)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 7903, 8260);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 8012, 8122) || true) && (!first)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 8012, 8122);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 8072, 8099);

                                f_10402_8072_8098(stringBuilder, ", ");
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 8012, 8122);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 8146, 8205);

                            f_10402_8146_8204(
                                                stringBuilder, constructorArgument.ToCSharpString());
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 8227, 8241);

                            first = false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 7903, 8260);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10402, 1, 358);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10402, 1, 358);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 8280, 8737);
                        foreach (var namedArgument in f_10402_8310_8335_I(f_10402_8310_8335(this)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 8280, 8737);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 8377, 8487) || true) && (!first)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 8377, 8487);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 8437, 8464);

                                f_10402_8437_8463(stringBuilder, ", ");
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 8377, 8487);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 8511, 8551);

                            f_10402_8511_8550(
                                                stringBuilder, namedArgument.Key);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 8573, 8601);

                            f_10402_8573_8600(stringBuilder, " = ");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 8623, 8682);

                            f_10402_8623_8681(stringBuilder, namedArgument.Value.ToCSharpString());
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 8704, 8718);

                            first = false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 8280, 8737);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10402, 1, 458);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10402, 1, 458);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 8757, 8783);

                    f_10402_8757_8782(
                                    stringBuilder, ")");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 8803, 8845);

                    return f_10402_8810_8844(pooledStrbuilder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 7257, 8860);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 8876, 8899);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.ToString(), 10402, 8883, 8898);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10402, 7198, 8910);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10402_7261_7280(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.AttributeClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 7261, 7280);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10402_7343_7362(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.AttributeClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 7343, 7362);
                    return return_v;
                }


                string
                f_10402_7343_7423(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.SymbolDisplayFormat
                format)
                {
                    var return_v = this_param.ToDisplayString(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 7343, 7423);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                f_10402_7642_7675()
                {
                    var return_v = PooledStringBuilder.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 7642, 7675);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10402_7769_7800(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 7769, 7800);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10402_7819_7844(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 7819, 7844);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10402_7939_7970(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.CommonConstructorArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 7939, 7970);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10402_8072_8098(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 8072, 8098);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10402_8146_8204(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 8146, 8204);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10402_7939_7970_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 7939, 7970);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                f_10402_8310_8335(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.CommonNamedArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 8310, 8335);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10402_8437_8463(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 8437, 8463);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10402_8511_8550(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 8511, 8550);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10402_8573_8600(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 8573, 8600);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10402_8623_8681(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 8623, 8681);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                f_10402_8310_8335_I(System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 8310, 8335);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10402_8757_8782(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 8757, 8782);
                    return return_v;
                }


                string
                f_10402_8810_8844(Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                this_param)
                {
                    var return_v = this_param.ToStringAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 8810, 8844);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10402, 7198, 8910);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10402, 7198, 8910);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override INamedTypeSymbol? CommonAttributeClass
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10402, 9188, 9241);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 9194, 9239);

                    return f_10402_9201_9238(f_10402_9201_9220(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10402, 9188, 9241);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                    f_10402_9201_9220(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                    this_param)
                    {
                        var return_v = this_param.AttributeClass;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 9201, 9220);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.INamedTypeSymbol?
                    f_10402_9201_9238(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                    symbol)
                    {
                        var return_v = symbol.GetPublicSymbol();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 9201, 9238);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10402, 9106, 9252);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10402, 9106, 9252);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override IMethodSymbol? CommonAttributeConstructor
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10402, 9507, 9566);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 9513, 9564);

                    return f_10402_9520_9563(f_10402_9520_9545(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10402, 9507, 9566);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                    f_10402_9520_9545(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                    this_param)
                    {
                        var return_v = this_param.AttributeConstructor;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 9520, 9545);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.IMethodSymbol?
                    f_10402_9520_9563(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                    symbol)
                    {
                        var return_v = symbol.GetPublicSymbol();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 9520, 9563);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10402, 9422, 9577);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10402, 9422, 9577);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override SyntaxReference? CommonApplicationSyntaxReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10402, 9877, 9924);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 9883, 9922);

                    return f_10402_9890_9921(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10402, 9877, 9924);

                    Microsoft.CodeAnalysis.SyntaxReference?
                    f_10402_9890_9921(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                    this_param)
                    {
                        var return_v = this_param.ApplicationSyntaxReference;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 9890, 9921);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10402, 9784, 9935);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10402, 9784, 9935);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal void DecodeSecurityAttribute<T>(Symbol targetSymbol, CSharpCompilation compilation, ref DecodeWellKnownAttributeArguments<AttributeSyntax, CSharpAttributeData, AttributeLocation> arguments)
                    where T : WellKnownAttributeData, ISecurityAttributeTarget, new()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10402, 10005, 11399);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 10307, 10337);

                f_10402_10307_10336<T>(f_10402_10320_10335_M(!this.HasErrors));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 10353, 10368);

                bool
                hasErrors
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 10382, 10542);

                DeclarativeSecurityAction
                action = f_10402_10417_10541<T>(this, targetSymbol, compilation, arguments.AttributeSyntaxOpt, out hasErrors, arguments.Diagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 10558, 11388) || true) && (!hasErrors)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 10558, 11388);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 10606, 10646);

                    T
                    data = arguments.GetOrCreateData<T>()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 10664, 10733);

                    SecurityWellKnownAttributeData
                    securityData = f_10402_10710_10732<T>(data)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 10751, 10837);

                    f_10402_10751_10836<T>(securityData, arguments.Index, action, arguments.AttributesCount);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 10857, 11373) || true) && (f_10402_10861_10942<T>(this, targetSymbol, AttributeDescription.PermissionSetAttribute))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 10857, 11373);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 10984, 11110);

                        string?
                        resolvedPathForFixup = f_10402_11015_11109<T>(this, compilation, arguments.AttributeSyntaxOpt, arguments.Diagnostics)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 11132, 11354) || true) && (resolvedPathForFixup != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 11132, 11354);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 11214, 11331);

                            f_10402_11214_11330<T>(securityData, arguments.Index, resolvedPathForFixup, arguments.AttributesCount);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 11132, 11354);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 10857, 11373);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 10558, 11388);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10402, 10005, 11399);

                bool
                f_10402_10320_10335_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 10320, 10335);
                    return return_v;
                }


                int
                f_10402_10307_10336<T>(bool
                condition) where T : WellKnownAttributeData, ISecurityAttributeTarget, new()

                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 10307, 10336);
                    return 0;
                }


                System.Reflection.DeclarativeSecurityAction
                f_10402_10417_10541<T>(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                targetSymbol, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax?
                nodeOpt, out bool
                hasErrors, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics) where T : WellKnownAttributeData, ISecurityAttributeTarget, new()

                {
                    var return_v = this_param.DecodeSecurityAttributeAction(targetSymbol, compilation, nodeOpt, out hasErrors, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 10417, 10541);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SecurityWellKnownAttributeData
                f_10402_10710_10732<T>(T
                this_param) where T : WellKnownAttributeData, ISecurityAttributeTarget, new()

                {
                    var return_v = this_param.GetOrCreateData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 10710, 10732);
                    return return_v;
                }


                int
                f_10402_10751_10836<T>(Microsoft.CodeAnalysis.SecurityWellKnownAttributeData
                this_param, int
                attributeIndex, System.Reflection.DeclarativeSecurityAction
                action, int
                totalSourceAttributes) where T : WellKnownAttributeData, ISecurityAttributeTarget, new()

                {
                    this_param.SetSecurityAttribute(attributeIndex, action, totalSourceAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 10751, 10836);
                    return 0;
                }


                bool
                f_10402_10861_10942<T>(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description) where T : WellKnownAttributeData, ISecurityAttributeTarget, new()

                {
                    var return_v = this_param.IsTargetAttribute(targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 10861, 10942);
                    return return_v;
                }


                string?
                f_10402_11015_11109<T>(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax?
                nodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics) where T : WellKnownAttributeData, ISecurityAttributeTarget, new()

                {
                    var return_v = this_param.DecodePermissionSetAttribute(compilation, nodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 11015, 11109);
                    return return_v;
                }


                int
                f_10402_11214_11330<T>(Microsoft.CodeAnalysis.SecurityWellKnownAttributeData
                this_param, int
                attributeIndex, string
                resolvedFilePath, int
                totalSourceAttributes) where T : WellKnownAttributeData, ISecurityAttributeTarget, new()

                {
                    this_param.SetPathForPermissionSetAttributeFixup(attributeIndex, resolvedFilePath, totalSourceAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 11214, 11330);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10402, 10005, 11399);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10402, 10005, 11399);
            }
        }

        internal static void DecodeSkipLocalsInitAttribute<T>(CSharpCompilation compilation, ref DecodeWellKnownAttributeArguments<AttributeSyntax, CSharpAttributeData, AttributeLocation> arguments)
                    where T : WellKnownAttributeData, ISkipLocalsInitAttributeTarget, new()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10402, 11411, 12051);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 11711, 11776);

                arguments.GetOrCreateData<T>().HasSkipLocalsInitAttribute = true;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 11790, 12040) || true) && (f_10402_11794_11826_M(!f_10402_11795_11814<T>(compilation).AllowUnsafe))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 11790, 12040);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 11860, 11913);

                    f_10402_11860_11912<T>(arguments.AttributeSyntaxOpt is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 11931, 12025);

                    f_10402_11931_12024<T>(arguments.Diagnostics, ErrorCode.ERR_IllegalUnsafe, f_10402_11986_12023<T>(arguments.AttributeSyntaxOpt));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 11790, 12040);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10402, 11411, 12051);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10402_11795_11814<T>(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param) where T : WellKnownAttributeData, ISkipLocalsInitAttributeTarget, new()

                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 11795, 11814);
                    return return_v;
                }


                bool
                f_10402_11794_11826_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 11794, 11826);
                    return return_v;
                }


                int
                f_10402_11860_11912<T>(bool
                condition) where T : WellKnownAttributeData, ISkipLocalsInitAttributeTarget, new()

                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 11860, 11912);
                    return 0;
                }


                Microsoft.CodeAnalysis.Location
                f_10402_11986_12023<T>(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param) where T : WellKnownAttributeData, ISkipLocalsInitAttributeTarget, new()

                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 11986, 12023);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10402_11931_12024<T>(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location) where T : WellKnownAttributeData, ISkipLocalsInitAttributeTarget, new()

                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 11931, 12024);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10402, 11411, 12051);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10402, 11411, 12051);
            }
        }

        internal static void DecodeMemberNotNullAttribute<T>(TypeSymbol type, ref DecodeWellKnownAttributeArguments<AttributeSyntax, CSharpAttributeData, AttributeLocation> arguments)
                    where T : WellKnownAttributeData, IMemberNotNullAttributeTarget, new()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10402, 12063, 13570);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 12347, 12409);

                var
                value = f_10402_12359_12405<T>(arguments.Attribute)[0]
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 12423, 12495) || true) && (value.IsNull)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 12423, 12495);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 12473, 12480);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 12423, 12495);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 12511, 13559) || true) && (value.Kind != TypedConstantKind.Array)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 12511, 13559);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 12586, 12660);

                    string?
                    memberName = value.DecodeValue<string>(SpecialType.System_String)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 12678, 12905) || true) && (memberName is object)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 12678, 12905);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 12744, 12804);

                        f_10402_12744_12803<T>(arguments.GetOrCreateData<T>(), memberName);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 12826, 12886);

                        f_10402_12826_12885<T>(type, arguments, memberName);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 12678, 12905);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 12511, 13559);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 12511, 13559);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 12971, 13020);

                    var
                    builder = f_10402_12985_13019<T>()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 13038, 13434);
                        foreach (var member in f_10402_13061_13073_I(value.Values))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 13038, 13434);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 13115, 13186);

                            var
                            memberName = member.DecodeValue<string>(SpecialType.System_String)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 13208, 13415) || true) && (memberName is object)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 13208, 13415);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 13282, 13306);

                                f_10402_13282_13305<T>(builder, memberName);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 13332, 13392);

                                f_10402_13332_13391<T>(type, arguments, memberName);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 13208, 13415);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 13038, 13434);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10402, 1, 397);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10402, 1, 397);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 13454, 13511);

                    f_10402_13454_13510<T>(
                                    arguments.GetOrCreateData<T>(), builder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 13529, 13544);

                    f_10402_13529_13543<T>(builder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 12511, 13559);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10402, 12063, 13570);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10402_12359_12405<T>(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param) where T : WellKnownAttributeData, IMemberNotNullAttributeTarget, new()

                {
                    var return_v = this_param.CommonConstructorArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 12359, 12405);
                    return return_v;
                }


                int
                f_10402_12744_12803<T>(T
                this_param, string
                memberName) where T : WellKnownAttributeData, IMemberNotNullAttributeTarget, new()

                {
                    this_param.AddNotNullMember(memberName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 12744, 12803);
                    return 0;
                }


                int
                f_10402_12826_12885<T>(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.DecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>
                arguments, string
                memberName) where T : WellKnownAttributeData, IMemberNotNullAttributeTarget, new()

                {
                    ReportBadNotNullMemberIfNeeded(type, arguments, memberName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 12826, 12885);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                f_10402_12985_13019<T>() where T : WellKnownAttributeData, IMemberNotNullAttributeTarget, new()

                {
                    var return_v = ArrayBuilder<string>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 12985, 13019);
                    return return_v;
                }


                int
                f_10402_13282_13305<T>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param, string
                item) where T : WellKnownAttributeData, IMemberNotNullAttributeTarget, new()

                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 13282, 13305);
                    return 0;
                }


                int
                f_10402_13332_13391<T>(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.DecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>
                arguments, string
                memberName) where T : WellKnownAttributeData, IMemberNotNullAttributeTarget, new()

                {
                    ReportBadNotNullMemberIfNeeded(type, arguments, memberName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 13332, 13391);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10402_13061_13073_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 13061, 13073);
                    return return_v;
                }


                int
                f_10402_13454_13510<T>(T
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                memberNames) where T : WellKnownAttributeData, IMemberNotNullAttributeTarget, new()

                {
                    this_param.AddNotNullMember(memberNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 13454, 13510);
                    return 0;
                }


                int
                f_10402_13529_13543<T>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param) where T : WellKnownAttributeData, IMemberNotNullAttributeTarget, new()

                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 13529, 13543);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10402, 12063, 13570);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10402, 12063, 13570);
            }
        }

        private static void ReportBadNotNullMemberIfNeeded(TypeSymbol type, DecodeWellKnownAttributeArguments<AttributeSyntax, CSharpAttributeData, AttributeLocation> arguments, string memberName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10402, 13582, 14262);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 13795, 14053);
                    foreach (Symbol foundMember in f_10402_13826_13853_I(f_10402_13826_13853(type, memberName)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 13795, 14053);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 13887, 14038) || true) && (f_10402_13891_13907(foundMember) == SymbolKind.Field || (DynAbs.Tracing.TraceSender.Expression_False(10402, 13891, 13970) || f_10402_13931_13947(foundMember) == SymbolKind.Property))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 13887, 14038);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 14012, 14019);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 13887, 14038);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 13795, 14053);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10402, 1, 259);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10402, 1, 259);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 14069, 14122);

                f_10402_14069_14121(arguments.AttributeSyntaxOpt is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 14136, 14251);

                f_10402_14136_14250(arguments.Diagnostics, ErrorCode.WRN_MemberNotNullBadMember, f_10402_14200_14237(arguments.AttributeSyntaxOpt), memberName);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10402, 13582, 14262);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10402_13826_13853(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 13826, 13853);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10402_13891_13907(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 13891, 13907);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10402_13931_13947(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 13931, 13947);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10402_13826_13853_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 13826, 13853);
                    return return_v;
                }


                int
                f_10402_14069_14121(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 14069, 14121);
                    return 0;
                }


                Microsoft.CodeAnalysis.Location
                f_10402_14200_14237(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 14200, 14237);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10402_14136_14250(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 14136, 14250);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10402, 13582, 14262);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10402, 13582, 14262);
            }
        }

        internal static void DecodeMemberNotNullWhenAttribute<T>(TypeSymbol type, ref DecodeWellKnownAttributeArguments<AttributeSyntax, CSharpAttributeData, AttributeLocation> arguments)
                    where T : WellKnownAttributeData, IMemberNotNullAttributeTarget, new()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10402, 14274, 15925);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 14562, 14624);

                var
                value = f_10402_14574_14620<T>(arguments.Attribute)[1]
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 14638, 14710) || true) && (value.IsNull)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 14638, 14710);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 14688, 14695);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 14638, 14710);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 14726, 14834);

                var
                sense = f_10402_14738_14784<T>(arguments.Attribute)[0].DecodeValue<bool>(SpecialType.System_Boolean)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 14848, 15914) || true) && (value.Kind != TypedConstantKind.Array)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 14848, 15914);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 14923, 14993);

                    var
                    memberName = value.DecodeValue<string>(SpecialType.System_String)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 15011, 15249) || true) && (memberName is object)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 15011, 15249);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 15077, 15148);

                        f_10402_15077_15147<T>(arguments.GetOrCreateData<T>(), sense, memberName);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 15170, 15230);

                        f_10402_15170_15229<T>(type, arguments, memberName);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 15011, 15249);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 14848, 15914);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 14848, 15914);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 15315, 15364);

                    var
                    builder = f_10402_15329_15363<T>()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 15382, 15778);
                        foreach (var member in f_10402_15405_15417_I(value.Values))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 15382, 15778);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 15459, 15530);

                            var
                            memberName = member.DecodeValue<string>(SpecialType.System_String)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 15552, 15759) || true) && (memberName is object)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 15552, 15759);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 15626, 15650);

                                f_10402_15626_15649<T>(builder, memberName);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 15676, 15736);

                                f_10402_15676_15735<T>(type, arguments, memberName);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 15552, 15759);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 15382, 15778);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10402, 1, 397);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10402, 1, 397);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 15798, 15866);

                    f_10402_15798_15865<T>(
                                    arguments.GetOrCreateData<T>(), sense, builder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 15884, 15899);

                    f_10402_15884_15898<T>(builder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 14848, 15914);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10402, 14274, 15925);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10402_14574_14620<T>(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param) where T : WellKnownAttributeData, IMemberNotNullAttributeTarget, new()

                {
                    var return_v = this_param.CommonConstructorArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 14574, 14620);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10402_14738_14784<T>(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param) where T : WellKnownAttributeData, IMemberNotNullAttributeTarget, new()

                {
                    var return_v = this_param.CommonConstructorArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 14738, 14784);
                    return return_v;
                }


                int
                f_10402_15077_15147<T>(T
                this_param, bool
                sense, string
                memberName) where T : WellKnownAttributeData, IMemberNotNullAttributeTarget, new()

                {
                    this_param.AddNotNullWhenMember(sense, memberName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 15077, 15147);
                    return 0;
                }


                int
                f_10402_15170_15229<T>(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.DecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>
                arguments, string
                memberName) where T : WellKnownAttributeData, IMemberNotNullAttributeTarget, new()

                {
                    ReportBadNotNullMemberIfNeeded(type, arguments, memberName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 15170, 15229);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                f_10402_15329_15363<T>() where T : WellKnownAttributeData, IMemberNotNullAttributeTarget, new()

                {
                    var return_v = ArrayBuilder<string>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 15329, 15363);
                    return return_v;
                }


                int
                f_10402_15626_15649<T>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param, string
                item) where T : WellKnownAttributeData, IMemberNotNullAttributeTarget, new()

                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 15626, 15649);
                    return 0;
                }


                int
                f_10402_15676_15735<T>(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.DecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>
                arguments, string
                memberName) where T : WellKnownAttributeData, IMemberNotNullAttributeTarget, new()

                {
                    ReportBadNotNullMemberIfNeeded(type, arguments, memberName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 15676, 15735);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10402_15405_15417_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 15405, 15417);
                    return return_v;
                }


                int
                f_10402_15798_15865<T>(T
                this_param, bool
                sense, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                memberNames) where T : WellKnownAttributeData, IMemberNotNullAttributeTarget, new()

                {
                    this_param.AddNotNullWhenMember(sense, memberNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 15798, 15865);
                    return 0;
                }


                int
                f_10402_15884_15898<T>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param) where T : WellKnownAttributeData, IMemberNotNullAttributeTarget, new()

                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 15884, 15898);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10402, 14274, 15925);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10402, 14274, 15925);
            }
        }

        private DeclarativeSecurityAction DecodeSecurityAttributeAction(Symbol targetSymbol, CSharpCompilation compilation, AttributeSyntax? nodeOpt, out bool hasErrors, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10402, 15937, 19000);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 16150, 16193);

                f_10402_16150_16192((object)targetSymbol != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 16207, 16349);

                f_10402_16207_16348(f_10402_16220_16237(targetSymbol) == SymbolKind.Assembly || (DynAbs.Tracing.TraceSender.Expression_False(10402, 16220, 16305) || f_10402_16264_16281(targetSymbol) == SymbolKind.NamedType) || (DynAbs.Tracing.TraceSender.Expression_False(10402, 16220, 16347) || f_10402_16309_16326(targetSymbol) == SymbolKind.Method));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 16363, 16415);

                f_10402_16363_16414(f_10402_16376_16413(this, compilation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 16431, 16478);

                var
                ctorArgs = f_10402_16446_16477(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 16492, 18670) || true) && (!ctorArgs.Any())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 16492, 18670);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 17939, 18170) || true) && (f_10402_17943_18025(this, targetSymbol, AttributeDescription.HostProtectionAttribute))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 17939, 18170);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 18067, 18085);

                        hasErrors = false;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 18107, 18151);

                        return DeclarativeSecurityAction.LinkDemand;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 17939, 18170);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 16492, 18670);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 16492, 18670);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 18236, 18278);

                    TypedConstant
                    firstArg = ctorArgs.First()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 18296, 18350);

                    var
                    firstArgType = (TypeSymbol?)firstArg.TypeInternal
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 18368, 18655) || true) && (firstArgType is object && (DynAbs.Tracing.TraceSender.Expression_True(10402, 18372, 18505) && f_10402_18398_18505(firstArgType, f_10402_18418_18504(compilation, WellKnownType.System_Security_Permissions_SecurityAction))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 18368, 18655);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 18547, 18636);

                        return f_10402_18554_18635(this, firstArg, targetSymbol, nodeOpt, diagnostics, out hasErrors);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 18368, 18655);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 16492, 18670);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 18780, 18906);

                f_10402_18780_18905(
                            // CS7048: First argument to a security attribute must be a valid SecurityAction
                            diagnostics, ErrorCode.ERR_SecurityAttributeMissingAction, (DynAbs.Tracing.TraceSender.Conditional_F1(10402, 18842, 18857) || ((nodeOpt != null && DynAbs.Tracing.TraceSender.Conditional_F2(10402, 18860, 18881)) || DynAbs.Tracing.TraceSender.Conditional_F3(10402, 18884, 18904))) ? f_10402_18860_18881(f_10402_18860_18872(nodeOpt)) : NoLocation.Singleton);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 18920, 18937);

                hasErrors = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 18951, 18989);

                return DeclarativeSecurityAction.None;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10402, 15937, 19000);

                int
                f_10402_16150_16192(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 16150, 16192);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10402_16220_16237(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 16220, 16237);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10402_16264_16281(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 16264, 16281);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10402_16309_16326(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 16309, 16326);
                    return return_v;
                }


                int
                f_10402_16207_16348(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 16207, 16348);
                    return 0;
                }


                bool
                f_10402_16376_16413(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = this_param.IsSecurityAttribute(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 16376, 16413);
                    return return_v;
                }


                int
                f_10402_16363_16414(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 16363, 16414);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10402_16446_16477(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.CommonConstructorArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 16446, 16477);
                    return return_v;
                }


                bool
                f_10402_17943_18025(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute(targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 17943, 18025);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10402_18418_18504(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 18418, 18504);
                    return return_v;
                }


                bool
                f_10402_18398_18505(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                obj)
                {
                    var return_v = this_param.Equals((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 18398, 18505);
                    return return_v;
                }


                System.Reflection.DeclarativeSecurityAction
                f_10402_18554_18635(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.TypedConstant
                typedValue, Microsoft.CodeAnalysis.CSharp.Symbol
                targetSymbol, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax?
                nodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out bool
                hasErrors)
                {
                    var return_v = this_param.DecodeSecurityAction(typedValue, targetSymbol, nodeOpt, diagnostics, out hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 18554, 18635);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10402_18860_18872(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 18860, 18872);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10402_18860_18881(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 18860, 18881);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10402_18780_18905(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 18780, 18905);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10402, 15937, 19000);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10402, 15937, 19000);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private DeclarativeSecurityAction DecodeSecurityAction(TypedConstant typedValue, Symbol targetSymbol, AttributeSyntax? nodeOpt, DiagnosticBag diagnostics, out bool hasErrors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10402, 19012, 23813);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 19211, 19254);

                f_10402_19211_19253((object)targetSymbol != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 19268, 19410);

                f_10402_19268_19409(f_10402_19281_19298(targetSymbol) == SymbolKind.Assembly || (DynAbs.Tracing.TraceSender.Expression_False(10402, 19281, 19366) || f_10402_19325_19342(targetSymbol) == SymbolKind.NamedType) || (DynAbs.Tracing.TraceSender.Expression_False(10402, 19281, 19408) || f_10402_19370_19387(targetSymbol) == SymbolKind.Method));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 19424, 19473);

                f_10402_19424_19472(typedValue.ValueInternal is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 19489, 19540);

                int
                securityAction = (int)typedValue.ValueInternal
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 19554, 19585);

                bool
                isPermissionRequestAction
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 19601, 22098);

                switch (securityAction)
                {

                    case (int)DeclarativeSecurityAction.InheritanceDemand:
                    case (int)DeclarativeSecurityAction.LinkDemand:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 19601, 22098);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 19798, 20452) || true) && (f_10402_19802_19889(this, targetSymbol, AttributeDescription.PrincipalPermissionAttribute))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 19798, 20452);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 20047, 20068);

                            object
                            displayString
                            = default(object);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 20094, 20201);

                            Location
                            syntaxLocation = f_10402_20120_20200(nodeOpt, typedValue, out displayString)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 20227, 20322);

                            f_10402_20227_20321(diagnostics, ErrorCode.ERR_PrincipalPermissionInvalidAction, syntaxLocation, displayString);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 20348, 20365);

                            hasErrors = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 20391, 20429);

                            return DeclarativeSecurityAction.None;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 19798, 20452);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 20476, 20510);

                        isPermissionRequestAction = false;
                        DynAbs.Tracing.TraceSender.TraceBreak(10402, 20532, 20538);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 19601, 22098);

                    case 1:
                    // Native compiler allows security action value 1 for security attributes on types/methods, even though there is no corresponding field in System.Security.Permissions.SecurityAction enum.
                    // We will maintain compatibility.

                    case (int)DeclarativeSecurityAction.Assert:
                    case (int)DeclarativeSecurityAction.Demand:
                    case (int)DeclarativeSecurityAction.PermitOnly:
                    case (int)DeclarativeSecurityAction.Deny:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 19601, 22098);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 21092, 21126);

                        isPermissionRequestAction = false;
                        DynAbs.Tracing.TraceSender.TraceBreak(10402, 21148, 21154);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 19601, 22098);

                    case (int)DeclarativeSecurityAction.RequestMinimum:
                    case (int)DeclarativeSecurityAction.RequestOptional:
                    case (int)DeclarativeSecurityAction.RequestRefuse:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 19601, 22098);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 21385, 21418);

                        isPermissionRequestAction = true;
                        DynAbs.Tracing.TraceSender.TraceBreak(10402, 21440, 21446);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 19601, 22098);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 19601, 22098);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 21626, 21647);

                            object
                            displayString
                            = default(object);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 21673, 21780);

                            Location
                            syntaxLocation = f_10402_21699_21779(nodeOpt, typedValue, out displayString)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 21806, 21953);

                            f_10402_21806_21952(diagnostics, ErrorCode.ERR_SecurityAttributeInvalidAction, syntaxLocation, (DynAbs.Tracing.TraceSender.Conditional_F1(10402, 21884, 21899) || ((nodeOpt != null && DynAbs.Tracing.TraceSender.Conditional_F2(10402, 21902, 21931)) || DynAbs.Tracing.TraceSender.Conditional_F3(10402, 21934, 21936))) ? f_10402_21902_21931(nodeOpt) : "", displayString);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 21979, 21996);

                            hasErrors = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 22022, 22060);

                            return DeclarativeSecurityAction.None;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 19601, 22098);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 22171, 23705) || true) && (isPermissionRequestAction)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 22171, 23705);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 22234, 22959) || true) && (f_10402_22238_22255(targetSymbol) == SymbolKind.NamedType || (DynAbs.Tracing.TraceSender.Expression_False(10402, 22238, 22321) || f_10402_22283_22300(targetSymbol) == SymbolKind.Method))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 22234, 22959);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 22564, 22585);

                        object
                        displayString
                        = default(object);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 22607, 22714);

                        Location
                        syntaxLocation = f_10402_22633_22713(nodeOpt, typedValue, out displayString)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 22736, 22841);

                        f_10402_22736_22840(diagnostics, ErrorCode.ERR_SecurityAttributeInvalidActionTypeOrMethod, syntaxLocation, displayString);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 22863, 22880);

                        hasErrors = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 22902, 22940);

                        return DeclarativeSecurityAction.None;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 22234, 22959);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 22171, 23705);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 22171, 23705);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 23025, 23690) || true) && (f_10402_23029_23046(targetSymbol) == SymbolKind.Assembly)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 23025, 23690);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 23299, 23320);

                        object
                        displayString
                        = default(object);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 23342, 23449);

                        Location
                        syntaxLocation = f_10402_23368_23448(nodeOpt, typedValue, out displayString)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 23471, 23572);

                        f_10402_23471_23571(diagnostics, ErrorCode.ERR_SecurityAttributeInvalidActionAssembly, syntaxLocation, displayString);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 23594, 23611);

                        hasErrors = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 23633, 23671);

                        return DeclarativeSecurityAction.None;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 23025, 23690);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 22171, 23705);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 23721, 23739);

                hasErrors = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 23753, 23802);

                return (DeclarativeSecurityAction)securityAction;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10402, 19012, 23813);

                int
                f_10402_19211_19253(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 19211, 19253);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10402_19281_19298(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 19281, 19298);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10402_19325_19342(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 19325, 19342);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10402_19370_19387(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 19370, 19387);
                    return return_v;
                }


                int
                f_10402_19268_19409(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 19268, 19409);
                    return 0;
                }


                int
                f_10402_19424_19472(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 19424, 19472);
                    return 0;
                }


                bool
                f_10402_19802_19889(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute(targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 19802, 19889);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10402_20120_20200(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax?
                nodeOpt, Microsoft.CodeAnalysis.TypedConstant
                typedValue, out object
                displayString)
                {
                    var return_v = GetSecurityAttributeActionSyntaxLocation(nodeOpt, typedValue, out displayString);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 20120, 20200);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10402_20227_20321(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 20227, 20321);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10402_21699_21779(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax?
                nodeOpt, Microsoft.CodeAnalysis.TypedConstant
                typedValue, out object
                displayString)
                {
                    var return_v = GetSecurityAttributeActionSyntaxLocation(nodeOpt, typedValue, out displayString);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 21699, 21779);
                    return return_v;
                }


                string
                f_10402_21902_21931(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.GetErrorDisplayName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 21902, 21931);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10402_21806_21952(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 21806, 21952);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10402_22238_22255(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 22238, 22255);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10402_22283_22300(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 22283, 22300);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10402_22633_22713(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax?
                nodeOpt, Microsoft.CodeAnalysis.TypedConstant
                typedValue, out object
                displayString)
                {
                    var return_v = GetSecurityAttributeActionSyntaxLocation(nodeOpt, typedValue, out displayString);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 22633, 22713);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10402_22736_22840(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 22736, 22840);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10402_23029_23046(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 23029, 23046);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10402_23368_23448(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax?
                nodeOpt, Microsoft.CodeAnalysis.TypedConstant
                typedValue, out object
                displayString)
                {
                    var return_v = GetSecurityAttributeActionSyntaxLocation(nodeOpt, typedValue, out displayString);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 23368, 23448);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10402_23471_23571(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 23471, 23571);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10402, 19012, 23813);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10402, 19012, 23813);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Location GetSecurityAttributeActionSyntaxLocation(AttributeSyntax? nodeOpt, TypedConstant typedValue, out object displayString)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10402, 23825, 24645);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 23992, 24125) || true) && (nodeOpt == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 23992, 24125);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 24045, 24064);

                    displayString = "";
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 24082, 24110);

                    return NoLocation.Singleton;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 23992, 24125);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 24141, 24176);

                var
                argList = f_10402_24155_24175(nodeOpt)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 24190, 24470) || true) && (argList == null || (DynAbs.Tracing.TraceSender.Expression_False(10402, 24194, 24240) || f_10402_24213_24240(argList.Arguments)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 24190, 24470);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 24348, 24413);

                    displayString = (FormattableString)$"{typedValue.ValueInternal}";
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 24431, 24455);

                    return f_10402_24438_24454(nodeOpt);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 24190, 24470);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 24486, 24543);

                AttributeArgumentSyntax
                argSyntax = f_10402_24522_24539(argList)[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 24557, 24594);

                displayString = f_10402_24573_24593(argSyntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 24608, 24634);

                return f_10402_24615_24633(argSyntax);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10402, 23825, 24645);

                Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentListSyntax?
                f_10402_24155_24175(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.ArgumentList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 24155, 24175);
                    return return_v;
                }


                bool
                f_10402_24213_24240(Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax>
                source)
                {
                    var return_v = source.IsEmpty<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 24213, 24240);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10402_24438_24454(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 24438, 24454);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax>
                f_10402_24522_24539(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentListSyntax
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 24522, 24539);
                    return return_v;
                }


                string
                f_10402_24573_24593(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 24573, 24593);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10402_24615_24633(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 24615, 24633);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10402, 23825, 24645);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10402, 23825, 24645);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string? DecodePermissionSetAttribute(CSharpCompilation compilation, AttributeSyntax? nodeOpt, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10402, 26074, 28747);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 26227, 26257);

                f_10402_26227_26256(f_10402_26240_26255_M(!this.HasErrors));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 26273, 26305);

                string?
                resolvedFilePath = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 26319, 26361);

                var
                namedArgs = f_10402_26335_26360(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 26377, 28696) || true) && (namedArgs.Length == 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 26377, 28696);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 26436, 26464);

                    var
                    namedArg = namedArgs[0]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 26482, 26521);

                    f_10402_26482_26520(f_10402_26495_26509() is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 26539, 26586);

                    NamedTypeSymbol
                    attrType = f_10402_26566_26585(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 26604, 26683);

                    string
                    filePropName = PermissionSetAttributeWithFileReference.FilePropertyName
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 26701, 26778);

                    string
                    hexPropName = PermissionSetAttributeWithFileReference.HexPropertyName
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 26798, 28681) || true) && (namedArg.Key == filePropName && (DynAbs.Tracing.TraceSender.Expression_True(10402, 26802, 26924) && f_10402_26855_26924(attrType, filePropName)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 26798, 28681);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 27013, 27066);

                        var
                        fileName = (string?)namedArg.Value.ValueInternal
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 27088, 27144);

                        var
                        resolver = f_10402_27103_27143(f_10402_27103_27122(compilation))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 27168, 27291);

                        resolvedFilePath = (DynAbs.Tracing.TraceSender.Conditional_F1(10402, 27187, 27225) || (((resolver != null && (DynAbs.Tracing.TraceSender.Expression_True(10402, 27188, 27224) && fileName != null)) && DynAbs.Tracing.TraceSender.Conditional_F2(10402, 27228, 27283)) || DynAbs.Tracing.TraceSender.Conditional_F3(10402, 27286, 27290))) ? f_10402_27228_27283(resolver, fileName, baseFilePath: null) : null;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 27315, 28662) || true) && (resolvedFilePath == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 27315, 28662);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 27565, 27667);

                            AttributeArgumentSyntax?
                            temp = (DynAbs.Tracing.TraceSender.Conditional_F1(10402, 27597, 27612) || ((nodeOpt != null && DynAbs.Tracing.TraceSender.Conditional_F2(10402, 27615, 27659)) || DynAbs.Tracing.TraceSender.Conditional_F3(10402, 27662, 27666))) ? f_10402_27615_27659(nodeOpt, filePropName) : null
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 27693, 27746);

                            Location
                            temp2 = (DynAbs.Tracing.TraceSender.Conditional_F1(10402, 27710, 27722) || ((temp != null && DynAbs.Tracing.TraceSender.Conditional_F2(10402, 27725, 27738)) || DynAbs.Tracing.TraceSender.Conditional_F3(10402, 27741, 27745))) ? f_10402_27725_27738(temp) : null
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 27772, 27831);

                            Location
                            argSyntaxLocation = temp2 ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.Location?>(10402, 27801, 27830) ?? NoLocation.Singleton)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 27857, 27977);

                            f_10402_27857_27976(diagnostics, ErrorCode.ERR_PermissionSetAttributeInvalidFile, argSyntaxLocation, fileName ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(10402, 27941, 27961) ?? "<null>"), filePropName);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 27315, 28662);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 27315, 28662);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 28027, 28662) || true) && (!f_10402_28032_28100(attrType, hexPropName))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 28027, 28662);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 28627, 28639);

                                return null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 28027, 28662);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 27315, 28662);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 26798, 28681);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 26377, 28696);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 28712, 28736);

                return resolvedFilePath;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10402, 26074, 28747);

                bool
                f_10402_26240_26255_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 26240, 26255);
                    return return_v;
                }


                int
                f_10402_26227_26256(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 26227, 26256);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                f_10402_26335_26360(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.CommonNamedArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 26335, 26360);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10402_26495_26509()
                {
                    var return_v = AttributeClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 26495, 26509);
                    return return_v;
                }


                int
                f_10402_26482_26520(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 26482, 26520);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10402_26566_26585(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.AttributeClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 26566, 26585);
                    return return_v;
                }


                bool
                f_10402_26855_26924(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                permissionSetType, string
                propName)
                {
                    var return_v = PermissionSetAttributeTypeHasRequiredProperty(permissionSetType, propName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 26855, 26924);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10402_27103_27122(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 27103, 27122);
                    return return_v;
                }


                Microsoft.CodeAnalysis.XmlReferenceResolver?
                f_10402_27103_27143(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.XmlReferenceResolver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 27103, 27143);
                    return return_v;
                }


                string?
                f_10402_27228_27283(Microsoft.CodeAnalysis.XmlReferenceResolver
                this_param, string
                path, string?
                baseFilePath)
                {
                    var return_v = this_param.ResolveReference(path, baseFilePath: baseFilePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 27228, 27283);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax?
                f_10402_27615_27659(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param, string
                namedArgName)
                {
                    var return_v = this_param.GetNamedArgumentSyntax(namedArgName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 27615, 27659);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10402_27725_27738(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 27725, 27738);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10402_27857_27976(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 27857, 27976);
                    return return_v;
                }


                bool
                f_10402_28032_28100(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                permissionSetType, string
                propName)
                {
                    var return_v = PermissionSetAttributeTypeHasRequiredProperty(permissionSetType, propName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 28032, 28100);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10402, 26074, 28747);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10402, 26074, 28747);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool PermissionSetAttributeTypeHasRequiredProperty(NamedTypeSymbol permissionSetType, string propName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10402, 28936, 29770);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 29078, 29131);

                var
                members = f_10402_29092_29130(permissionSetType, propName)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 29145, 29730) || true) && (members.Length == 1 && (DynAbs.Tracing.TraceSender.Expression_True(10402, 29149, 29210) && f_10402_29172_29187(members[0]) == SymbolKind.Property))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 29145, 29730);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 29244, 29286);

                    var
                    property = (PropertySymbol)members[0]
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 29304, 29715) || true) && (property.TypeWithAnnotations.HasType && (DynAbs.Tracing.TraceSender.Expression_True(10402, 29308, 29402) && f_10402_29348_29373(f_10402_29348_29361(property)) == SpecialType.System_String) && (DynAbs.Tracing.TraceSender.Expression_True(10402, 29308, 29481) && f_10402_29427_29457(property) == Accessibility.Public) && (DynAbs.Tracing.TraceSender.Expression_True(10402, 29308, 29515) && f_10402_29485_29510(property) == 0) && (DynAbs.Tracing.TraceSender.Expression_True(10402, 29308, 29574) && (object)f_10402_29548_29566(property) != null) && (DynAbs.Tracing.TraceSender.Expression_True(10402, 29308, 29642) && f_10402_29578_29618(f_10402_29578_29596(property)) == Accessibility.Public))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 29304, 29715);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 29684, 29696);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 29304, 29715);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 29145, 29730);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 29746, 29759);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10402, 28936, 29770);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10402_29092_29130(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 29092, 29130);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10402_29172_29187(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 29172, 29187);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10402_29348_29361(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 29348, 29361);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10402_29348_29373(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 29348, 29373);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10402_29427_29457(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 29427, 29457);
                    return return_v;
                }


                int
                f_10402_29485_29510(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                symbol)
                {
                    var return_v = symbol.GetMemberArity();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 29485, 29510);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10402_29548_29566(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.SetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 29548, 29566);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10402_29578_29596(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.SetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 29578, 29596);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10402_29578_29618(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 29578, 29618);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10402, 28936, 29770);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10402, 28936, 29770);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void DecodeClassInterfaceAttribute(AttributeSyntax? nodeOpt, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10402, 29782, 31122);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 29903, 29933);

                f_10402_29903_29932(f_10402_29916_29931_M(!this.HasErrors));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 29949, 30013);

                TypedConstant
                ctorArgument = f_10402_29978_30009(this)[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 30027, 30137);

                f_10402_30027_30136(ctorArgument.Kind == TypedConstantKind.Enum || (DynAbs.Tracing.TraceSender.Expression_False(10402, 30040, 30135) || ctorArgument.Kind == TypedConstantKind.Primitive));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 30153, 30418);

                ClassInterfaceType
                interfaceType = (DynAbs.Tracing.TraceSender.Conditional_F1(10402, 30188, 30231) || ((ctorArgument.Kind == TypedConstantKind.Enum && DynAbs.Tracing.TraceSender.Conditional_F2(10402, 30251, 30320)) || DynAbs.Tracing.TraceSender.Conditional_F3(10402, 30340, 30417))) ? ctorArgument.DecodeValue<ClassInterfaceType>(SpecialType.System_Enum) : (ClassInterfaceType)ctorArgument.DecodeValue<short>(SpecialType.System_Int16)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 30434, 31111);

                switch (interfaceType)
                {

                    case ClassInterfaceType.None:
                    case Cci.Constants.ClassInterfaceType_AutoDispatch:
                    case Cci.Constants.ClassInterfaceType_AutoDual:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 30434, 31111);
                        DynAbs.Tracing.TraceSender.TraceBreak(10402, 30674, 30680);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 30434, 31111);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 30434, 31111);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 30808, 30903);

                        Location
                        attributeArgumentSyntaxLocation = f_10402_30851_30902(this, 0, nodeOpt)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 30925, 31068);

                        f_10402_30925_31067(diagnostics, ErrorCode.ERR_InvalidAttributeArgument, attributeArgumentSyntaxLocation, (DynAbs.Tracing.TraceSender.Conditional_F1(10402, 31014, 31029) || ((nodeOpt != null && DynAbs.Tracing.TraceSender.Conditional_F2(10402, 31032, 31061)) || DynAbs.Tracing.TraceSender.Conditional_F3(10402, 31064, 31066))) ? f_10402_31032_31061(nodeOpt) : "");
                        DynAbs.Tracing.TraceSender.TraceBreak(10402, 31090, 31096);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 30434, 31111);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10402, 29782, 31122);

                bool
                f_10402_29916_29931_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 29916, 29931);
                    return return_v;
                }


                int
                f_10402_29903_29932(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 29903, 29932);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10402_29978_30009(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.CommonConstructorArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 29978, 30009);
                    return return_v;
                }


                int
                f_10402_30027_30136(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 30027, 30136);
                    return 0;
                }


                Microsoft.CodeAnalysis.Location
                f_10402_30851_30902(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                attribute, int
                parameterIndex, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax?
                attributeSyntaxOpt)
                {
                    var return_v = attribute.GetAttributeArgumentSyntaxLocation(parameterIndex, attributeSyntaxOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 30851, 30902);
                    return return_v;
                }


                string
                f_10402_31032_31061(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.GetErrorDisplayName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 31032, 31061);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10402_30925_31067(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 30925, 31067);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10402, 29782, 31122);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10402, 29782, 31122);
            }
        }

        internal void DecodeInterfaceTypeAttribute(AttributeSyntax node, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10402, 31134, 32515);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 31250, 31280);

                f_10402_31250_31279(f_10402_31263_31278_M(!this.HasErrors));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 31296, 31360);

                TypedConstant
                ctorArgument = f_10402_31325_31356(this)[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 31374, 31484);

                f_10402_31374_31483(ctorArgument.Kind == TypedConstantKind.Enum || (DynAbs.Tracing.TraceSender.Expression_False(10402, 31387, 31482) || ctorArgument.Kind == TypedConstantKind.Primitive));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 31500, 31759);

                ComInterfaceType
                interfaceType = (DynAbs.Tracing.TraceSender.Conditional_F1(10402, 31533, 31576) || ((ctorArgument.Kind == TypedConstantKind.Enum && DynAbs.Tracing.TraceSender.Conditional_F2(10402, 31596, 31663)) || DynAbs.Tracing.TraceSender.Conditional_F3(10402, 31683, 31758))) ? ctorArgument.DecodeValue<ComInterfaceType>(SpecialType.System_Enum) : (ComInterfaceType)ctorArgument.DecodeValue<short>(SpecialType.System_Int16)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 31775, 32504);

                switch (interfaceType)
                {

                    case Cci.Constants.ComInterfaceType_InterfaceIsDual:
                    case Cci.Constants.ComInterfaceType_InterfaceIsIDispatch:
                    case ComInterfaceType.InterfaceIsIInspectable:
                    case ComInterfaceType.InterfaceIsIUnknown:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 31775, 32504);
                        DynAbs.Tracing.TraceSender.TraceBreak(10402, 32103, 32109);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 31775, 32504);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 31775, 32504);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 32237, 32321);

                        CSharpSyntaxNode
                        attributeArgumentSyntax = f_10402_32280_32320(this, 0, node)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 32343, 32461);

                        f_10402_32343_32460(diagnostics, ErrorCode.ERR_InvalidAttributeArgument, f_10402_32399_32431(attributeArgumentSyntax), f_10402_32433_32459(node));
                        DynAbs.Tracing.TraceSender.TraceBreak(10402, 32483, 32489);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 31775, 32504);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10402, 31134, 32515);

                bool
                f_10402_31263_31278_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 31263, 31278);
                    return return_v;
                }


                int
                f_10402_31250_31279(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 31250, 31279);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10402_31325_31356(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.CommonConstructorArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 31325, 31356);
                    return return_v;
                }


                int
                f_10402_31374_31483(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 31374, 31483);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10402_32280_32320(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                attribute, int
                parameterIndex, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                attributeSyntax)
                {
                    var return_v = attribute.GetAttributeArgumentSyntax(parameterIndex, attributeSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 32280, 32320);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10402_32399_32431(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 32399, 32431);
                    return return_v;
                }


                string
                f_10402_32433_32459(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.GetErrorDisplayName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 32433, 32459);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10402_32343_32460(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 32343, 32460);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10402, 31134, 32515);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10402, 31134, 32515);
            }
        }

        internal string DecodeGuidAttribute(AttributeSyntax? nodeOpt, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10402, 32527, 33432);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 32640, 32670);

                f_10402_32640_32669(f_10402_32653_32668_M(!this.HasErrors));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 32686, 32761);

                var
                guidString = (string?)f_10402_32712_32743(this)[0].ValueInternal
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 32889, 32899);

                Guid
                guid
                = default(Guid);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 32913, 33386) || true) && (!Guid.TryParseExact(guidString, "D", out guid))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 32913, 33386);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 33071, 33166);

                    Location
                    attributeArgumentSyntaxLocation = f_10402_33114_33165(this, 0, nodeOpt)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 33184, 33327);

                    f_10402_33184_33326(diagnostics, ErrorCode.ERR_InvalidAttributeArgument, attributeArgumentSyntaxLocation, (DynAbs.Tracing.TraceSender.Conditional_F1(10402, 33273, 33288) || ((nodeOpt != null && DynAbs.Tracing.TraceSender.Conditional_F2(10402, 33291, 33320)) || DynAbs.Tracing.TraceSender.Conditional_F3(10402, 33323, 33325))) ? f_10402_33291_33320(nodeOpt) : "");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 33345, 33371);

                    guidString = String.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 32913, 33386);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 33402, 33421);

                return guidString!;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10402, 32527, 33432);

                bool
                f_10402_32653_32668_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 32653, 32668);
                    return return_v;
                }


                int
                f_10402_32640_32669(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 32640, 32669);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10402_32712_32743(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.CommonConstructorArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 32712, 32743);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10402_33114_33165(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                attribute, int
                parameterIndex, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax?
                attributeSyntaxOpt)
                {
                    var return_v = attribute.GetAttributeArgumentSyntaxLocation(parameterIndex, attributeSyntaxOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 33114, 33165);
                    return return_v;
                }


                string
                f_10402_33291_33320(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.GetErrorDisplayName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 33291, 33320);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10402_33184_33326(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 33184, 33326);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10402, 32527, 33432);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10402, 32527, 33432);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private protected sealed override bool IsStringProperty(string memberName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10402, 33444, 33947);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 33543, 33907) || true) && (f_10402_33547_33561() is object)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 33543, 33907);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 33605, 33892);
                        foreach (var member in f_10402_33628_33665_I(f_10402_33628_33665(f_10402_33628_33642(), memberName)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 33605, 33892);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 33707, 33873) || true) && (member is PropertySymbol { Type: { SpecialType: SpecialType.System_String } })
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 33707, 33873);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 33838, 33850);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 33707, 33873);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 33605, 33892);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10402, 1, 288);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10402, 1, 288);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 33543, 33907);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 33923, 33936);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10402, 33444, 33947);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10402_33547_33561()
                {
                    var return_v = AttributeClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 33547, 33561);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10402_33628_33642()
                {
                    var return_v = AttributeClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 33628, 33642);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10402_33628_33665(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 33628, 33665);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10402_33628_33665_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 33628, 33665);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10402, 33444, 33947);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10402, 33444, 33947);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool ShouldEmitAttribute(Symbol target, bool isReturnType, bool emittingAssemblyAttributesInNetModule)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10402, 34225, 40127);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 34361, 34459);

                f_10402_34361_34458(target is SourceAssemblySymbol || (DynAbs.Tracing.TraceSender.Expression_False(10402, 34374, 34457) || f_10402_34408_34433(target) is SourceAssemblySymbol));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 34475, 34574) || true) && (f_10402_34479_34488())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 34475, 34574);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 34522, 34559);

                    throw f_10402_34528_34558();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 34475, 34574);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 34882, 34975) || true) && (f_10402_34886_34913(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 34882, 34975);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 34947, 34960);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 34882, 34975);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 34991, 40088);

                switch (f_10402_34999_35010(target))
                {

                    case SymbolKind.Assembly:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 34991, 40088);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 35091, 35826) || true) && ((!emittingAssemblyAttributesInNetModule && (DynAbs.Tracing.TraceSender.Expression_True(10402, 35096, 35561) && (f_10402_35168_35240(this, target, AttributeDescription.AssemblyCultureAttribute) || (DynAbs.Tracing.TraceSender.Expression_False(10402, 35168, 35346) || f_10402_35274_35346(this, target, AttributeDescription.AssemblyVersionAttribute)) || (DynAbs.Tracing.TraceSender.Expression_False(10402, 35168, 35450) || f_10402_35380_35450(this, target, AttributeDescription.AssemblyFlagsAttribute)) || (DynAbs.Tracing.TraceSender.Expression_False(10402, 35168, 35560) || f_10402_35484_35560(this, target, AttributeDescription.AssemblyAlgorithmIdAttribute))))) || (DynAbs.Tracing.TraceSender.Expression_False(10402, 35095, 35663) || f_10402_35591_35663(this, target, AttributeDescription.TypeForwardedToAttribute)) || (DynAbs.Tracing.TraceSender.Expression_False(10402, 35095, 35740) || f_10402_35692_35740(this, f_10402_35712_35739(target))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 35091, 35826);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 35790, 35803);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 35091, 35826);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10402, 35850, 35856);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 34991, 40088);

                    case SymbolKind.Event:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 34991, 40088);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 35920, 36078) || true) && (f_10402_35924_35992(this, target, AttributeDescription.SpecialNameAttribute))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 35920, 36078);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 36042, 36055);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 35920, 36078);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10402, 36102, 36108);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 34991, 40088);

                    case SymbolKind.Field:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 34991, 40088);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 36172, 36621) || true) && (f_10402_36176_36244(this, target, AttributeDescription.SpecialNameAttribute) || (DynAbs.Tracing.TraceSender.Expression_False(10402, 36176, 36343) || f_10402_36273_36343(this, target, AttributeDescription.NonSerializedAttribute)) || (DynAbs.Tracing.TraceSender.Expression_False(10402, 36176, 36440) || f_10402_36372_36440(this, target, AttributeDescription.FieldOffsetAttribute)) || (DynAbs.Tracing.TraceSender.Expression_False(10402, 36176, 36535) || f_10402_36469_36535(this, target, AttributeDescription.MarshalAsAttribute)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 36172, 36621);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 36585, 36598);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 36172, 36621);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10402, 36645, 36651);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 34991, 40088);

                    case SymbolKind.Method:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 34991, 40088);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 36716, 37733) || true) && (isReturnType)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 36716, 37733);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 36782, 36950) || true) && (f_10402_36786_36852(this, target, AttributeDescription.MarshalAsAttribute))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 36782, 36950);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 36910, 36923);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 36782, 36950);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 36716, 37733);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 36716, 37733);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 37048, 37710) || true) && (f_10402_37052_37120(this, target, AttributeDescription.SpecialNameAttribute) || (DynAbs.Tracing.TraceSender.Expression_False(10402, 37052, 37220) || f_10402_37153_37220(this, target, AttributeDescription.MethodImplAttribute)) || (DynAbs.Tracing.TraceSender.Expression_False(10402, 37052, 37319) || f_10402_37253_37319(this, target, AttributeDescription.DllImportAttribute)) || (DynAbs.Tracing.TraceSender.Expression_False(10402, 37052, 37420) || f_10402_37352_37420(this, target, AttributeDescription.PreserveSigAttribute)) || (DynAbs.Tracing.TraceSender.Expression_False(10402, 37052, 37531) || f_10402_37453_37531(this, target, AttributeDescription.DynamicSecurityMethodAttribute)) || (DynAbs.Tracing.TraceSender.Expression_False(10402, 37052, 37612) || f_10402_37564_37612(this, f_10402_37584_37611(target))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 37048, 37710);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 37670, 37683);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 37048, 37710);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 36716, 37733);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10402, 37757, 37763);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 34991, 40088);

                    case SymbolKind.NetModule:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 34991, 40088);
                        DynAbs.Tracing.TraceSender.TraceBreak(10402, 37972, 37978);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 34991, 40088);

                    case SymbolKind.NamedType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 34991, 40088);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 38046, 38678) || true) && (f_10402_38050_38118(this, target, AttributeDescription.SpecialNameAttribute) || (DynAbs.Tracing.TraceSender.Expression_False(10402, 38050, 38213) || f_10402_38147_38213(this, target, AttributeDescription.ComImportAttribute)) || (DynAbs.Tracing.TraceSender.Expression_False(10402, 38050, 38311) || f_10402_38242_38311(this, target, AttributeDescription.SerializableAttribute)) || (DynAbs.Tracing.TraceSender.Expression_False(10402, 38050, 38409) || f_10402_38340_38409(this, target, AttributeDescription.StructLayoutAttribute)) || (DynAbs.Tracing.TraceSender.Expression_False(10402, 38050, 38515) || f_10402_38438_38515(this, target, AttributeDescription.WindowsRuntimeImportAttribute)) || (DynAbs.Tracing.TraceSender.Expression_False(10402, 38050, 38592) || f_10402_38544_38592(this, f_10402_38564_38591(target))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 38046, 38678);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 38642, 38655);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 38046, 38678);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10402, 38702, 38708);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 34991, 40088);

                    case SymbolKind.Parameter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 34991, 40088);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 38776, 39310) || true) && (f_10402_38780_38845(this, target, AttributeDescription.OptionalAttribute) || (DynAbs.Tracing.TraceSender.Expression_False(10402, 38780, 38952) || f_10402_38874_38952(this, target, AttributeDescription.DefaultParameterValueAttribute)) || (DynAbs.Tracing.TraceSender.Expression_False(10402, 38780, 39040) || f_10402_38981_39040(this, target, AttributeDescription.InAttribute)) || (DynAbs.Tracing.TraceSender.Expression_False(10402, 38780, 39129) || f_10402_39069_39129(this, target, AttributeDescription.OutAttribute)) || (DynAbs.Tracing.TraceSender.Expression_False(10402, 38780, 39224) || f_10402_39158_39224(this, target, AttributeDescription.MarshalAsAttribute)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 38776, 39310);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 39274, 39287);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 38776, 39310);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10402, 39334, 39340);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 34991, 40088);

                    case SymbolKind.Property:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 34991, 40088);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 39407, 40043) || true) && (f_10402_39411_39479(this, target, AttributeDescription.IndexerNameAttribute) || (DynAbs.Tracing.TraceSender.Expression_False(10402, 39411, 39576) || f_10402_39508_39576(this, target, AttributeDescription.SpecialNameAttribute)) || (DynAbs.Tracing.TraceSender.Expression_False(10402, 39411, 39674) || f_10402_39605_39674(this, target, AttributeDescription.DisallowNullAttribute)) || (DynAbs.Tracing.TraceSender.Expression_False(10402, 39411, 39769) || f_10402_39703_39769(this, target, AttributeDescription.AllowNullAttribute)) || (DynAbs.Tracing.TraceSender.Expression_False(10402, 39411, 39864) || f_10402_39798_39864(this, target, AttributeDescription.MaybeNullAttribute)) || (DynAbs.Tracing.TraceSender.Expression_False(10402, 39411, 39957) || f_10402_39893_39957(this, target, AttributeDescription.NotNullAttribute)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 39407, 40043);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 40007, 40020);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 39407, 40043);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10402, 40067, 40073);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 34991, 40088);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 40104, 40116);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10402, 34225, 40127);

                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10402_34408_34433(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 34408, 34433);
                    return return_v;
                }


                int
                f_10402_34361_34458(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 34361, 34458);
                    return 0;
                }


                bool
                f_10402_34479_34488()
                {
                    var return_v = HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 34479, 34488);
                    return return_v;
                }


                System.Exception
                f_10402_34528_34558()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 34528, 34558);
                    return return_v;
                }


                bool
                f_10402_34886_34913(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.IsConditionallyOmitted;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 34886, 34913);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10402_34999_35010(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 34999, 35010);
                    return return_v;
                }


                bool
                f_10402_35168_35240(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute(targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 35168, 35240);
                    return return_v;
                }


                bool
                f_10402_35274_35346(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute(targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 35274, 35346);
                    return return_v;
                }


                bool
                f_10402_35380_35450(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute(targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 35380, 35450);
                    return return_v;
                }


                bool
                f_10402_35484_35560(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute(targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 35484, 35560);
                    return return_v;
                }


                bool
                f_10402_35591_35663(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute(targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 35591, 35663);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10402_35712_35739(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 35712, 35739);
                    return return_v;
                }


                bool
                f_10402_35692_35740(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = this_param.IsSecurityAttribute(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 35692, 35740);
                    return return_v;
                }


                bool
                f_10402_35924_35992(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute(targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 35924, 35992);
                    return return_v;
                }


                bool
                f_10402_36176_36244(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute(targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 36176, 36244);
                    return return_v;
                }


                bool
                f_10402_36273_36343(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute(targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 36273, 36343);
                    return return_v;
                }


                bool
                f_10402_36372_36440(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute(targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 36372, 36440);
                    return return_v;
                }


                bool
                f_10402_36469_36535(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute(targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 36469, 36535);
                    return return_v;
                }


                bool
                f_10402_36786_36852(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute(targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 36786, 36852);
                    return return_v;
                }


                bool
                f_10402_37052_37120(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute(targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 37052, 37120);
                    return return_v;
                }


                bool
                f_10402_37153_37220(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute(targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 37153, 37220);
                    return return_v;
                }


                bool
                f_10402_37253_37319(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute(targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 37253, 37319);
                    return return_v;
                }


                bool
                f_10402_37352_37420(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute(targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 37352, 37420);
                    return return_v;
                }


                bool
                f_10402_37453_37531(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute(targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 37453, 37531);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10402_37584_37611(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 37584, 37611);
                    return return_v;
                }


                bool
                f_10402_37564_37612(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = this_param.IsSecurityAttribute(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 37564, 37612);
                    return return_v;
                }


                bool
                f_10402_38050_38118(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute(targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 38050, 38118);
                    return return_v;
                }


                bool
                f_10402_38147_38213(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute(targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 38147, 38213);
                    return return_v;
                }


                bool
                f_10402_38242_38311(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute(targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 38242, 38311);
                    return return_v;
                }


                bool
                f_10402_38340_38409(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute(targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 38340, 38409);
                    return return_v;
                }


                bool
                f_10402_38438_38515(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute(targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 38438, 38515);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10402_38564_38591(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 38564, 38591);
                    return return_v;
                }


                bool
                f_10402_38544_38592(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = this_param.IsSecurityAttribute(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 38544, 38592);
                    return return_v;
                }


                bool
                f_10402_38780_38845(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute(targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 38780, 38845);
                    return return_v;
                }


                bool
                f_10402_38874_38952(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute(targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 38874, 38952);
                    return return_v;
                }


                bool
                f_10402_38981_39040(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute(targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 38981, 39040);
                    return return_v;
                }


                bool
                f_10402_39069_39129(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute(targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 39069, 39129);
                    return return_v;
                }


                bool
                f_10402_39158_39224(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute(targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 39158, 39224);
                    return return_v;
                }


                bool
                f_10402_39411_39479(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute(targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 39411, 39479);
                    return return_v;
                }


                bool
                f_10402_39508_39576(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute(targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 39508, 39576);
                    return return_v;
                }


                bool
                f_10402_39605_39674(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute(targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 39605, 39674);
                    return return_v;
                }


                bool
                f_10402_39703_39769(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute(targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 39703, 39769);
                    return return_v;
                }


                bool
                f_10402_39798_39864(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute(targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 39798, 39864);
                    return return_v;
                }


                bool
                f_10402_39893_39957(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute(targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 39893, 39957);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10402, 34225, 40127);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10402, 34225, 40127);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
    internal static class AttributeDataExtensions
    {
        internal static int IndexOfAttribute(this ImmutableArray<CSharpAttributeData> attributes, Symbol targetSymbol, AttributeDescription description)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10402, 40206, 40635);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 40384, 40389);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 40375, 40598) || true) && (i < attributes.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 40414, 40417)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 40375, 40598))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 40375, 40598);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 40451, 40583) || true) && (f_10402_40455_40513(attributes[i], targetSymbol, description))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 40451, 40583);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 40555, 40564);

                            return i;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 40451, 40583);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10402, 1, 224);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10402, 1, 224);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 40614, 40624);

                return -1;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10402, 40206, 40635);

                bool
                f_10402_40455_40513(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute(targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 40455, 40513);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10402, 40206, 40635);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10402, 40206, 40635);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static CSharpSyntaxNode GetAttributeArgumentSyntax(this AttributeData attribute, int parameterIndex, AttributeSyntax attributeSyntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10402, 40647, 40986);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 40814, 40861);

                f_10402_40814_40860(attribute is SourceAttributeData);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 40875, 40975);

                return f_10402_40882_40974(((SourceAttributeData)attribute), parameterIndex, attributeSyntax);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10402, 40647, 40986);

                int
                f_10402_40814_40860(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 40814, 40860);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10402_40882_40974(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData
                this_param, int
                parameterIndex, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                attributeSyntax)
                {
                    var return_v = this_param.GetAttributeArgumentSyntax(parameterIndex, attributeSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 40882, 40974);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10402, 40647, 40986);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10402, 40647, 40986);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string? DecodeNotNullIfNotNullAttribute(this CSharpAttributeData attribute)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10402, 40998, 41313);
                string? value = default(string?);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 41114, 41167);

                var
                arguments = f_10402_41130_41166(attribute)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 41181, 41302);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10402, 41188, 41286) || ((arguments.Length == 1 && (DynAbs.Tracing.TraceSender.Expression_True(10402, 41188, 41286) && arguments[0].TryDecodeValue(SpecialType.System_String, out value
                )) && DynAbs.Tracing.TraceSender.Conditional_F2(10402, 41289, 41294)) || DynAbs.Tracing.TraceSender.Conditional_F3(10402, 41297, 41301))) ? value : null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10402, 40998, 41313);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10402_41130_41166(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.CommonConstructorArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 41130, 41166);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10402, 40998, 41313);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10402, 40998, 41313);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Location GetAttributeArgumentSyntaxLocation(this AttributeData attribute, int parameterIndex, AttributeSyntax? attributeSyntaxOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10402, 41325, 41803);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 41496, 41603) || true) && (attributeSyntaxOpt == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10402, 41496, 41603);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 41560, 41588);

                    return NoLocation.Singleton;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10402, 41496, 41603);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 41619, 41666);

                f_10402_41619_41665(attribute is SourceAttributeData);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10402, 41680, 41792);

                return f_10402_41687_41791(f_10402_41687_41782(((SourceAttributeData)attribute), parameterIndex, attributeSyntaxOpt));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10402, 41325, 41803);

                int
                f_10402_41619_41665(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 41619, 41665);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10402_41687_41782(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData
                this_param, int
                parameterIndex, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                attributeSyntax)
                {
                    var return_v = this_param.GetAttributeArgumentSyntax(parameterIndex, attributeSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10402, 41687, 41782);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10402_41687_41791(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10402, 41687, 41791);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10402, 41325, 41803);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10402, 41325, 41803);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static AttributeDataExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10402, 40144, 41810);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10402, 40144, 41810);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10402, 40144, 41810);
        }

    }
}
