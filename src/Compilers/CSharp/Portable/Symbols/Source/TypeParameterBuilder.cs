// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class TypeParameterBuilder
    {
        private readonly SyntaxReference _syntaxRef;

        private readonly SourceNamedTypeSymbol _owner;

        private readonly Location _location;

        internal TypeParameterBuilder(SyntaxReference syntaxRef, SourceNamedTypeSymbol owner, Location location)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10282, 884, 1194);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10282, 759, 769);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10282, 819, 825);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10282, 862, 871);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10282, 1013, 1036);

                _syntaxRef = syntaxRef;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10282, 1050, 1119);

                f_10282_1050_1118(f_10282_1063_1117(f_10282_1063_1084(syntaxRef), SyntaxKind.TypeParameter));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10282, 1133, 1148);

                _owner = owner;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10282, 1162, 1183);

                _location = location;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10282, 884, 1194);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10282, 884, 1194);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10282, 884, 1194);
            }
        }

        internal TypeParameterSymbol MakeSymbol(int ordinal, IList<TypeParameterBuilder> builders, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10282, 1206, 2058);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10282, 1348, 1409);

                var
                syntaxNode = (TypeParameterSyntax)f_10282_1386_1408(_syntaxRef)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10282, 1423, 1718);

                var
                result = f_10282_1436_1717(_owner, syntaxNode.Identifier.ValueText, ordinal, syntaxNode.VarianceKeyword.VarianceKindFromToken(), f_10282_1654_1675(builders), f_10282_1694_1716(builders))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10282, 1831, 2017) || true) && (f_10282_1835_1846(result) == f_10282_1850_1878(f_10282_1850_1873(result)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10282, 1831, 2017);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10282, 1912, 2002);

                    f_10282_1912_2001(diagnostics, ErrorCode.ERR_TypeVariableSameAsParent, f_10282_1968_1984(result)[0], f_10282_1989_2000(result));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10282, 1831, 2017);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10282, 2033, 2047);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10282, 1206, 2058);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10282_1386_1408(Microsoft.CodeAnalysis.SyntaxReference
                this_param)
                {
                    var return_v = this_param.GetSyntax();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10282, 1386, 1408);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10282_1654_1675(System.Collections.Generic.IList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterBuilder>
                builders)
                {
                    var return_v = ToLocations(builders);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10282, 1654, 1675);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                f_10282_1694_1716(System.Collections.Generic.IList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterBuilder>
                builders)
                {
                    var return_v = ToSyntaxRefs(builders);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10282, 1694, 1716);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbol
                f_10282_1436_1717(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                owner, string
                name, int
                ordinal, Microsoft.CodeAnalysis.VarianceKind
                varianceKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                locations, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                syntaxRefs)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbol(owner, name, ordinal, varianceKind, locations, syntaxRefs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10282, 1436, 1717);
                    return return_v;
                }


                string
                f_10282_1835_1846(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10282, 1835, 1846);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10282_1850_1873(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10282, 1850, 1873);
                    return return_v;
                }


                string
                f_10282_1850_1878(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10282, 1850, 1878);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10282_1968_1984(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10282, 1968, 1984);
                    return return_v;
                }


                string
                f_10282_1989_2000(Microsoft.CodeAnalysis.CSharp.Symbols.SourceTypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10282, 1989, 2000);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10282_1912_2001(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10282, 1912, 2001);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10282, 1206, 2058);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10282, 1206, 2058);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ImmutableArray<Location> ToLocations(IList<TypeParameterBuilder> builders)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10282, 2070, 2453);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10282, 2184, 2254);

                var
                arrayBuilder = f_10282_2203_2253(f_10282_2238_2252(builders))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10282, 2268, 2385);
                    foreach (var builder in f_10282_2292_2300_I(builders))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10282, 2268, 2385);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10282, 2334, 2370);

                        f_10282_2334_2369(arrayBuilder, builder._location);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10282, 2268, 2385);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10282, 1, 118);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10282, 1, 118);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10282, 2401, 2442);

                return f_10282_2408_2441(arrayBuilder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10282, 2070, 2453);

                int
                f_10282_2238_2252(System.Collections.Generic.IList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterBuilder>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10282, 2238, 2252);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Location>
                f_10282_2203_2253(int
                capacity)
                {
                    var return_v = ArrayBuilder<Location>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10282, 2203, 2253);
                    return return_v;
                }


                int
                f_10282_2334_2369(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Location>
                this_param, Microsoft.CodeAnalysis.Location
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10282, 2334, 2369);
                    return 0;
                }


                System.Collections.Generic.IList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterBuilder>
                f_10282_2292_2300_I(System.Collections.Generic.IList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterBuilder>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10282, 2292, 2300);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10282_2408_2441(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Location>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10282, 2408, 2441);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10282, 2070, 2453);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10282, 2070, 2453);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ImmutableArray<SyntaxReference> ToSyntaxRefs(IList<TypeParameterBuilder> builders)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10282, 2465, 2864);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10282, 2587, 2664);

                var
                arrayBuilder = f_10282_2606_2663(f_10282_2648_2662(builders))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10282, 2678, 2796);
                    foreach (var builder in f_10282_2702_2710_I(builders))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10282, 2678, 2796);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10282, 2744, 2781);

                        f_10282_2744_2780(arrayBuilder, builder._syntaxRef);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10282, 2678, 2796);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10282, 1, 119);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10282, 1, 119);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10282, 2812, 2853);

                return f_10282_2819_2852(arrayBuilder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10282, 2465, 2864);

                int
                f_10282_2648_2662(System.Collections.Generic.IList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterBuilder>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10282, 2648, 2662);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxReference>
                f_10282_2606_2663(int
                capacity)
                {
                    var return_v = ArrayBuilder<SyntaxReference>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10282, 2606, 2663);
                    return return_v;
                }


                int
                f_10282_2744_2780(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxReference>
                this_param, Microsoft.CodeAnalysis.SyntaxReference
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10282, 2744, 2780);
                    return 0;
                }


                System.Collections.Generic.IList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterBuilder>
                f_10282_2702_2710_I(System.Collections.Generic.IList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterBuilder>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10282, 2702, 2710);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                f_10282_2819_2852(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxReference>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10282, 2819, 2852);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10282, 2465, 2864);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10282, 2465, 2864);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static TypeParameterBuilder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10282, 667, 2871);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10282, 667, 2871);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10282, 667, 2871);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10282, 667, 2871);

        Microsoft.CodeAnalysis.SyntaxNode
        f_10282_1063_1084(Microsoft.CodeAnalysis.SyntaxReference
        this_param)
        {
            var return_v = this_param.GetSyntax();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10282, 1063, 1084);
            return return_v;
        }


        bool
        f_10282_1063_1117(Microsoft.CodeAnalysis.SyntaxNode
        node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
        kind)
        {
            var return_v = node.IsKind(kind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10282, 1063, 1117);
            return return_v;
        }


        int
        f_10282_1050_1118(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10282, 1050, 1118);
            return 0;
        }

    }
}
