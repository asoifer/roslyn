// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class WithCrefTypeParametersBinder : WithTypeParametersBinder
    {
        private readonly CrefSyntax _crefSyntax;

        private MultiDictionary<string, TypeParameterSymbol> _lazyTypeParameterMap;

        internal WithCrefTypeParametersBinder(CrefSyntax crefSyntax, Binder next)
        : base(f_10377_987_991_C(next))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10377, 893, 1053);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10377, 784, 795);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10377, 859, 880);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10377, 1017, 1042);

                _crefSyntax = crefSyntax;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10377, 893, 1053);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10377, 893, 1053);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10377, 893, 1053);
            }
        }

        protected override MultiDictionary<string, TypeParameterSymbol> TypeParameterMap
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10377, 1170, 1528);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10377, 1206, 1464) || true) && (_lazyTypeParameterMap == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10377, 1206, 1464);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10377, 1281, 1357);

                        MultiDictionary<string, TypeParameterSymbol>
                        map = f_10377_1332_1356(this)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10377, 1379, 1445);

                        f_10377_1379_1444(ref _lazyTypeParameterMap, map, null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10377, 1206, 1464);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10377, 1484, 1513);

                    return _lazyTypeParameterMap;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10377, 1170, 1528);

                    Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    f_10377_1332_1356(Microsoft.CodeAnalysis.CSharp.WithCrefTypeParametersBinder
                    this_param)
                    {
                        var return_v = this_param.CreateTypeParameterMap();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10377, 1332, 1356);
                        return return_v;
                    }


                    Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>?
                    f_10377_1379_1444(ref Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>?
                    location1, Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    value, Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10377, 1379, 1444);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10377, 1065, 1539);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10377, 1065, 1539);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private MultiDictionary<string, TypeParameterSymbol> CreateTypeParameterMap()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10377, 1551, 2949);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10377, 1653, 1714);

                var
                map = f_10377_1663_1713()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10377, 1730, 2913);

                switch (f_10377_1738_1756(_crefSyntax))
                {

                    case SyntaxKind.TypeCref:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10377, 1730, 2913);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10377, 1864, 1923);

                            f_10377_1864_1922(this, f_10377_1882_1916(((TypeCrefSyntax)_crefSyntax)), map);
                            DynAbs.Tracing.TraceSender.TraceBreak(10377, 1949, 1955);

                            break;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10377, 1730, 2913);

                    case SyntaxKind.QualifiedCref:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10377, 1730, 2913);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10377, 2075, 2152);

                            QualifiedCrefSyntax
                            qualifiedCrefSyntax = ((QualifiedCrefSyntax)_crefSyntax)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10377, 2178, 2229);

                            f_10377_2178_2228(this, f_10377_2196_2222(qualifiedCrefSyntax), map);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10377, 2255, 2309);

                            f_10377_2255_2308(this, f_10377_2273_2302(qualifiedCrefSyntax), map);
                            DynAbs.Tracing.TraceSender.TraceBreak(10377, 2335, 2341);

                            break;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10377, 1730, 2913);

                    case SyntaxKind.NameMemberCref:
                    case SyntaxKind.IndexerMemberCref:
                    case SyntaxKind.OperatorMemberCref:
                    case SyntaxKind.ConversionOperatorMemberCref:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10377, 1730, 2913);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10377, 2630, 2684);

                            f_10377_2630_2683(this, _crefSyntax, map);
                            DynAbs.Tracing.TraceSender.TraceBreak(10377, 2710, 2716);

                            break;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10377, 1730, 2913);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10377, 1730, 2913);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10377, 2814, 2875);

                            throw f_10377_2820_2874(f_10377_2855_2873(_crefSyntax));
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10377, 1730, 2913);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10377, 2927, 2938);

                return map;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10377, 1551, 2949);

                Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10377_1663_1713()
                {
                    var return_v = new Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10377, 1663, 1713);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10377_1738_1756(Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10377, 1738, 1756);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10377_1882_1916(Microsoft.CodeAnalysis.CSharp.Syntax.TypeCrefSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10377, 1882, 1916);
                    return return_v;
                }


                int
                f_10377_1864_1922(Microsoft.CodeAnalysis.CSharp.WithCrefTypeParametersBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                typeSyntax, Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                map)
                {
                    this_param.AddTypeParameters(typeSyntax, map);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10377, 1864, 1922);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.MemberCrefSyntax
                f_10377_2196_2222(Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedCrefSyntax
                this_param)
                {
                    var return_v = this_param.Member;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10377, 2196, 2222);
                    return return_v;
                }


                int
                f_10377_2178_2228(Microsoft.CodeAnalysis.CSharp.WithCrefTypeParametersBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.MemberCrefSyntax
                memberSyntax, Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                map)
                {
                    this_param.AddTypeParameters(memberSyntax, map);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10377, 2178, 2228);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10377_2273_2302(Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedCrefSyntax
                this_param)
                {
                    var return_v = this_param.Container;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10377, 2273, 2302);
                    return return_v;
                }


                int
                f_10377_2255_2308(Microsoft.CodeAnalysis.CSharp.WithCrefTypeParametersBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                typeSyntax, Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                map)
                {
                    this_param.AddTypeParameters(typeSyntax, map);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10377, 2255, 2308);
                    return 0;
                }


                int
                f_10377_2630_2683(Microsoft.CodeAnalysis.CSharp.WithCrefTypeParametersBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
                memberSyntax, Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                map)
                {
                    this_param.AddTypeParameters((Microsoft.CodeAnalysis.CSharp.Syntax.MemberCrefSyntax)memberSyntax, map);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10377, 2630, 2683);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10377_2855_2873(Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10377, 2855, 2873);
                    return return_v;
                }


                System.Exception
                f_10377_2820_2874(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10377, 2820, 2874);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10377, 1551, 2949);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10377, 1551, 2949);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void AddTypeParameters(TypeSyntax typeSyntax, MultiDictionary<string, TypeParameterSymbol> map)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10377, 2961, 4239);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10377, 3089, 4228);

                switch (f_10377_3097_3114(typeSyntax))
                {

                    case SyntaxKind.AliasQualifiedName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10377, 3089, 4228);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10377, 3205, 3273);

                        f_10377_3205_3272(this, f_10377_3223_3266(((AliasQualifiedNameSyntax)typeSyntax)), map);
                        DynAbs.Tracing.TraceSender.TraceBreak(10377, 3295, 3301);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10377, 3089, 4228);

                    case SyntaxKind.QualifiedName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10377, 3089, 4228);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10377, 3584, 3658);

                        QualifiedNameSyntax
                        qualifiedNameSyntax = (QualifiedNameSyntax)typeSyntax
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10377, 3680, 3730);

                        f_10377_3680_3729(this, f_10377_3698_3723(qualifiedNameSyntax), map);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10377, 3752, 3801);

                        f_10377_3752_3800(this, f_10377_3770_3794(qualifiedNameSyntax), map);
                        DynAbs.Tracing.TraceSender.TraceBreak(10377, 3823, 3829);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10377, 3089, 4228);

                    case SyntaxKind.GenericName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10377, 3089, 4228);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10377, 3897, 3951);

                        f_10377_3897_3950(typeSyntax, map);
                        DynAbs.Tracing.TraceSender.TraceBreak(10377, 3973, 3979);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10377, 3089, 4228);

                    case SyntaxKind.IdentifierName:
                    case SyntaxKind.PredefinedType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10377, 3089, 4228);
                        DynAbs.Tracing.TraceSender.TraceBreak(10377, 4099, 4105);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10377, 3089, 4228);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10377, 3089, 4228);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10377, 4153, 4213);

                        throw f_10377_4159_4212(f_10377_4194_4211(typeSyntax));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10377, 3089, 4228);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10377, 2961, 4239);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10377_3097_3114(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10377, 3097, 3114);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                f_10377_3223_3266(Microsoft.CodeAnalysis.CSharp.Syntax.AliasQualifiedNameSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10377, 3223, 3266);
                    return return_v;
                }


                int
                f_10377_3205_3272(Microsoft.CodeAnalysis.CSharp.WithCrefTypeParametersBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                typeSyntax, Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                map)
                {
                    this_param.AddTypeParameters((Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax)typeSyntax, map);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10377, 3205, 3272);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                f_10377_3698_3723(Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedNameSyntax
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10377, 3698, 3723);
                    return return_v;
                }


                int
                f_10377_3680_3729(Microsoft.CodeAnalysis.CSharp.WithCrefTypeParametersBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                typeSyntax, Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                map)
                {
                    this_param.AddTypeParameters((Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax)typeSyntax, map);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10377, 3680, 3729);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10377_3770_3794(Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedNameSyntax
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10377, 3770, 3794);
                    return return_v;
                }


                int
                f_10377_3752_3800(Microsoft.CodeAnalysis.CSharp.WithCrefTypeParametersBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                typeSyntax, Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                map)
                {
                    this_param.AddTypeParameters((Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax)typeSyntax, map);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10377, 3752, 3800);
                    return 0;
                }


                int
                f_10377_3897_3950(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                genericNameSyntax, Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                map)
                {
                    AddTypeParameters((Microsoft.CodeAnalysis.CSharp.Syntax.GenericNameSyntax)genericNameSyntax, map);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10377, 3897, 3950);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10377_4194_4211(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10377, 4194, 4211);
                    return return_v;
                }


                System.Exception
                f_10377_4159_4212(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10377, 4159, 4212);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10377, 2961, 4239);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10377, 2961, 4239);
            }
        }

        private void AddTypeParameters(MemberCrefSyntax memberSyntax, MultiDictionary<string, TypeParameterSymbol> map)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10377, 4251, 4609);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10377, 4431, 4598) || true) && (f_10377_4435_4454(memberSyntax) == SyntaxKind.NameMemberCref)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10377, 4431, 4598);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10377, 4517, 4583);

                    f_10377_4517_4582(this, f_10377_4535_4576(((NameMemberCrefSyntax)memberSyntax)), map);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10377, 4431, 4598);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10377, 4251, 4609);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10377_4435_4454(Microsoft.CodeAnalysis.CSharp.Syntax.MemberCrefSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10377, 4435, 4454);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10377_4535_4576(Microsoft.CodeAnalysis.CSharp.Syntax.NameMemberCrefSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10377, 4535, 4576);
                    return return_v;
                }


                int
                f_10377_4517_4582(Microsoft.CodeAnalysis.CSharp.WithCrefTypeParametersBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                typeSyntax, Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                map)
                {
                    this_param.AddTypeParameters(typeSyntax, map);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10377, 4517, 4582);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10377, 4251, 4609);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10377, 4251, 4609);
            }
        }

        private static void AddTypeParameters(GenericNameSyntax genericNameSyntax, MultiDictionary<string, TypeParameterSymbol> map)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10377, 4621, 6274);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10377, 5206, 5299);

                SeparatedSyntaxList<TypeSyntax>
                typeArguments = f_10377_5254_5298(f_10377_5254_5288(genericNameSyntax))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10377, 5322, 5349);
                    for (int
        i = typeArguments.Count - 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10377, 5313, 6263) || true) && (i >= 0)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10377, 5359, 5362)
        , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(10377, 5313, 6263))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10377, 5313, 6263);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10377, 5551, 6248) || true) && (f_10377_5555_5578(typeArguments[i]) == SyntaxKind.IdentifierName)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10377, 5551, 6248);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10377, 5649, 5731);

                            IdentifierNameSyntax
                            typeParameterSyntax = (IdentifierNameSyntax)typeArguments[i]
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10377, 5753, 5829);

                            f_10377_5753_5828(typeParameterSyntax != null, "Syntactic requirement of crefs");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10377, 5853, 5908);

                            string
                            name = typeParameterSyntax.Identifier.ValueText
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10377, 5930, 6229) || true) && (f_10377_5934_5969(name) && (DynAbs.Tracing.TraceSender.Expression_True(10377, 5934, 5995) && !f_10377_5974_5995(map, name)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10377, 5930, 6229);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10377, 6045, 6145);

                                TypeParameterSymbol
                                typeParameterSymbol = f_10377_6087_6144(name, i, typeParameterSyntax)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10377, 6171, 6206);

                                f_10377_6171_6205(map, name, typeParameterSymbol);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10377, 5930, 6229);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10377, 5551, 6248);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10377, 1, 951);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10377, 1, 951);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10377, 4621, 6274);

                Microsoft.CodeAnalysis.CSharp.Syntax.TypeArgumentListSyntax
                f_10377_5254_5288(Microsoft.CodeAnalysis.CSharp.Syntax.GenericNameSyntax
                this_param)
                {
                    var return_v = this_param.TypeArgumentList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10377, 5254, 5288);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax>
                f_10377_5254_5298(Microsoft.CodeAnalysis.CSharp.Syntax.TypeArgumentListSyntax
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10377, 5254, 5298);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10377_5555_5578(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10377, 5555, 5578);
                    return return_v;
                }


                int
                f_10377_5753_5828(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10377, 5753, 5828);
                    return 0;
                }


                bool
                f_10377_5934_5969(string
                name)
                {
                    var return_v = SyntaxFacts.IsValidIdentifier(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10377, 5934, 5969);
                    return return_v;
                }


                bool
                f_10377_5974_5995(Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                this_param, string
                k)
                {
                    var return_v = this_param.ContainsKey(k);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10377, 5974, 5995);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.CrefTypeParameterSymbol
                f_10377_6087_6144(string
                name, int
                ordinal, Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                declaringSyntax)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.CrefTypeParameterSymbol(name, ordinal, declaringSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10377, 6087, 6144);
                    return return_v;
                }


                bool
                f_10377_6171_6205(Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                this_param, string
                k, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                v)
                {
                    var return_v = this_param.Add(k, v);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10377, 6171, 6205);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10377, 4621, 6274);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10377, 4621, 6274);
            }
        }

        protected override void AddLookupSymbolsInfoInSingleBinder(LookupSymbolsInfo result, LookupOptions options, Binder originalBinder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10377, 6286, 7087);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10377, 6441, 7076) || true) && (f_10377_6445_6479(this, options))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10377, 6441, 7076);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10377, 6513, 7061);
                        foreach (var kvp in f_10377_6533_6549_I(f_10377_6533_6549()))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10377, 6513, 7061);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10377, 6591, 7042);
                                foreach (TypeParameterSymbol typeParameter in f_10377_6637_6646_I(kvp.Value))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10377, 6591, 7042);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10377, 6815, 6947);

                                    f_10377_6815_6946(!f_10377_6829_6866(result, f_10377_6847_6865(typeParameter)) || (DynAbs.Tracing.TraceSender.Expression_False(10377, 6828, 6945) || f_10377_6870_6945(originalBinder, typeParameter, options, result, null)));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10377, 6975, 7019);

                                    f_10377_6975_7018(
                                                            result, typeParameter, kvp.Key, 0);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10377, 6591, 7042);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10377, 1, 452);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10377, 1, 452);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10377, 6513, 7061);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10377, 1, 549);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10377, 1, 549);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10377, 6441, 7076);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10377, 6286, 7087);

                bool
                f_10377_6445_6479(Microsoft.CodeAnalysis.CSharp.WithCrefTypeParametersBinder
                this_param, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options)
                {
                    var return_v = this_param.CanConsiderTypeParameters(options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10377, 6445, 6479);
                    return return_v;
                }


                Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10377_6533_6549()
                {
                    var return_v = TypeParameterMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10377, 6533, 6549);
                    return return_v;
                }


                string
                f_10377_6847_6865(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10377, 6847, 6865);
                    return return_v;
                }


                bool
                f_10377_6829_6866(Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo
                this_param, string
                name)
                {
                    var return_v = this_param.CanBeAdded(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10377, 6829, 6866);
                    return return_v;
                }


                bool
                f_10377_6870_6945(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo
                info, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                accessThroughType)
                {
                    var return_v = this_param.CanAddLookupSymbolInfo((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, options, info, accessThroughType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10377, 6870, 6945);
                    return return_v;
                }


                int
                f_10377_6815_6946(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10377, 6815, 6946);
                    return 0;
                }


                int
                f_10377_6975_7018(Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                symbol, string
                name, int
                arity)
                {
                    this_param.AddSymbol((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, name, arity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10377, 6975, 7018);
                    return 0;
                }


                Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>.ValueSet
                f_10377_6637_6646_I(Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>.ValueSet
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10377, 6637, 6646);
                    return return_v;
                }


                Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10377_6533_6549_I(Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10377, 6533, 6549);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10377, 6286, 7087);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10377, 6286, 7087);
            }
        }

        static WithCrefTypeParametersBinder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10377, 662, 7094);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10377, 662, 7094);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10377, 662, 7094);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10377, 662, 7094);

        static Microsoft.CodeAnalysis.CSharp.Binder
        f_10377_987_991_C(Microsoft.CodeAnalysis.CSharp.Binder
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10377, 893, 1053);
            return return_v;
        }

    }
}
