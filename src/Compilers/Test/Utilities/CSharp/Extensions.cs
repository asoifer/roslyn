// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Test.Utilities;
using Roslyn.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests
{
    internal static partial class Extensions
    {
        public static AssemblySymbol GetReferencedAssemblySymbol(this CSharpCompilation compilation, MetadataReference reference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 841, 1070);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 987, 1059);

                return (AssemblySymbol)f_21009_1010_1058(compilation, reference);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 841, 1070);

                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_21009_1010_1058(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.MetadataReference
                reference)
                {
                    var return_v = this_param.GetAssemblyOrModuleSymbol(reference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 1010, 1058);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 841, 1070);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 841, 1070);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ModuleSymbol GetReferencedModuleSymbol(this CSharpCompilation compilation, MetadataReference reference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 1082, 1305);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 1224, 1294);

                return (ModuleSymbol)f_21009_1245_1293(compilation, reference);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 1082, 1305);

                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_21009_1245_1293(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.MetadataReference
                reference)
                {
                    var return_v = this_param.GetAssemblyOrModuleSymbol(reference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 1245, 1293);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 1082, 1305);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 1082, 1305);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TypeDeclarationSyntax AsTypeDeclarationSyntax(this SyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 1317, 1471);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 1423, 1460);

                return node as TypeDeclarationSyntax;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 1317, 1471);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 1317, 1471);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 1317, 1471);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static MethodDeclarationSyntax AsMethodDeclarationSyntax(this SyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 1483, 1643);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 1593, 1632);

                return node as MethodDeclarationSyntax;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 1483, 1643);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 1483, 1643);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 1483, 1643);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxNodeOrToken FindNodeOrTokenByKind(this SyntaxTree syntaxTree, SyntaxKind kind, int occurrence = 1)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 1655, 2268);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 1798, 1962) || true) && (!(occurrence > 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 1798, 1962);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 1853, 1947);

                    throw f_21009_1859_1946("Specified value must be greater than zero.", nameof(occurrence));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 1798, 1962);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 1976, 2033);

                SyntaxNodeOrToken
                foundNode = default(SyntaxNodeOrToken)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 2047, 2209) || true) && (f_21009_2051_2143(syntaxTree.GetCompilationUnitRoot(), kind, ref occurrence, ref foundNode))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 2047, 2209);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 2177, 2194);

                    return foundNode;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 2047, 2209);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 2223, 2257);

                return default(SyntaxNodeOrToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 1655, 2268);

                System.ArgumentException
                f_21009_1859_1946(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 1859, 1946);
                    return return_v;
                }


                bool
                f_21009_2051_2143(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, ref int
                occurrence, ref Microsoft.CodeAnalysis.SyntaxNodeOrToken
                foundNode)
                {
                    var return_v = TryFindNodeOrToken((Microsoft.CodeAnalysis.SyntaxNodeOrToken)node, kind, ref occurrence, ref foundNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 2051, 2143);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 1655, 2268);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 1655, 2268);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool TryFindNodeOrToken(SyntaxNodeOrToken node, SyntaxKind kind, ref int occurrence, ref SyntaxNodeOrToken foundNode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 2280, 3047);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 2437, 2669) || true) && (node.IsKind(kind))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 2437, 2669);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 2492, 2505);

                    occurrence--;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 2523, 2654) || true) && (occurrence == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 2523, 2654);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 2584, 2601);

                        foundNode = node;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 2623, 2635);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 2523, 2654);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 2437, 2669);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 2771, 3007);
                    foreach (var child in f_21009_2793_2819_I(node.ChildNodesAndTokens()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 2771, 3007);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 2853, 2992) || true) && (f_21009_2857_2919(child, kind, ref occurrence, ref foundNode))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 2853, 2992);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 2961, 2973);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 2853, 2992);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 2771, 3007);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(21009, 1, 237);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(21009, 1, 237);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 3023, 3036);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 2280, 3047);

                bool
                f_21009_2857_2919(Microsoft.CodeAnalysis.SyntaxNodeOrToken
                node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, ref int
                occurrence, ref Microsoft.CodeAnalysis.SyntaxNodeOrToken
                foundNode)
                {
                    var return_v = TryFindNodeOrToken(node, kind, ref occurrence, ref foundNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 2857, 2919);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ChildSyntaxList
                f_21009_2793_2819_I(Microsoft.CodeAnalysis.ChildSyntaxList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 2793, 2819);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 2280, 3047);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 2280, 3047);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static AssemblySymbol[] BoundReferences(this AssemblySymbol @this)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 3059, 3311);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 3157, 3300);

                return f_21009_3164_3299((DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => from m in @this.Modules
                                                                                                  from @ref in m.GetReferencedAssemblySymbols()
                                                                                                  select @ref, 21009, 3165, 3288)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 3059, 3311);

                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol[]
                f_21009_3164_3299(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                source)
                {
                    var return_v = source.ToArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 3164, 3299);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 3059, 3311);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 3059, 3311);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SourceAssemblySymbol SourceAssembly(this CSharpCompilation @this)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 3323, 3482);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 3427, 3471);

                return (SourceAssemblySymbol)f_21009_3456_3470(@this);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 3323, 3482);

                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_21009_3456_3470(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 3456, 3470);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 3323, 3482);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 3323, 3482);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool HasUnresolvedReferencesByComparisonTo(this AssemblySymbol @this, AssemblySymbol that)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 3494, 4010);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 3623, 3662);

                var
                thisRefs = f_21009_3638_3661(@this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 3676, 3714);

                var
                thatRefs = f_21009_3691_3713(that)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 3739, 3744);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 3730, 3970) || true) && (i < f_21009_3750_3792(f_21009_3759_3774(thisRefs), f_21009_3776_3791(thatRefs)))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 3794, 3797)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 3730, 3970))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 3730, 3970);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 3831, 3955) || true) && (f_21009_3835_3856(thisRefs[i]) && (DynAbs.Tracing.TraceSender.Expression_True(21009, 3835, 3882) && f_21009_3860_3882_M(!thatRefs[i].IsMissing)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 3831, 3955);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 3924, 3936);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 3831, 3955);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(21009, 1, 241);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(21009, 1, 241);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 3986, 3999);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 3494, 4010);

                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol[]
                f_21009_3638_3661(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                @this)
                {
                    var return_v = @this.BoundReferences();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 3638, 3661);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol[]
                f_21009_3691_3713(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                @this)
                {
                    var return_v = @this.BoundReferences();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 3691, 3713);
                    return return_v;
                }


                int
                f_21009_3759_3774(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 3759, 3774);
                    return return_v;
                }


                int
                f_21009_3776_3791(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 3776, 3791);
                    return return_v;
                }


                int
                f_21009_3750_3792(int
                val1, int
                val2)
                {
                    var return_v = Math.Max(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 3750, 3792);
                    return return_v;
                }


                bool
                f_21009_3835_3856(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.IsMissing;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 3835, 3856);
                    return return_v;
                }


                bool
                f_21009_3860_3882_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 3860, 3882);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 3494, 4010);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 3494, 4010);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool RepresentsTheSameAssemblyButHasUnresolvedReferencesByComparisonTo(this AssemblySymbol @this, AssemblySymbol that)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 4022, 5631);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 4179, 4276);

                var
                thisPEAssembly = @this as Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEAssemblySymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 4292, 4656) || true) && (thisPEAssembly != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 4292, 4656);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 4352, 4448);

                    var
                    thatPEAssembly = that as Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEAssemblySymbol
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 4468, 4641);

                    return thatPEAssembly != null && (DynAbs.Tracing.TraceSender.Expression_True(21009, 4475, 4587) && f_21009_4522_4587(f_21009_4538_4561(thisPEAssembly), f_21009_4563_4586(thatPEAssembly))) && (DynAbs.Tracing.TraceSender.Expression_True(21009, 4475, 4640) && f_21009_4591_4640(@this, that));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 4292, 4656);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 4672, 4787);

                var
                thisRetargetingAssembly = @this as Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingAssemblySymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 4803, 5591) || true) && (thisRetargetingAssembly != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 4803, 5591);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 4872, 4986);

                    var
                    thatRetargetingAssembly = that as Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingAssemblySymbol
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 5006, 5291) || true) && (thatRetargetingAssembly != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 5006, 5291);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 5083, 5272);

                        return f_21009_5090_5193(f_21009_5106_5148(thisRetargetingAssembly), f_21009_5150_5192(thatRetargetingAssembly)) && (DynAbs.Tracing.TraceSender.Expression_True(21009, 5090, 5271) && f_21009_5222_5271(@this, that));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 5006, 5291);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 5311, 5365);

                    var
                    thatSourceAssembly = that as SourceAssemblySymbol
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 5385, 5576);

                    return thatSourceAssembly != null && (DynAbs.Tracing.TraceSender.Expression_True(21009, 5392, 5501) && f_21009_5422_5501(f_21009_5438_5480(thisRetargetingAssembly), thatSourceAssembly)) && (DynAbs.Tracing.TraceSender.Expression_True(21009, 5392, 5575) && f_21009_5526_5575(@this, that));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 4803, 5591);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 5607, 5620);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 4022, 5631);

                Microsoft.CodeAnalysis.PEAssembly
                f_21009_4538_4561(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEAssemblySymbol
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 4538, 4561);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEAssembly
                f_21009_4563_4586(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEAssemblySymbol
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 4563, 4586);
                    return return_v;
                }


                bool
                f_21009_4522_4587(Microsoft.CodeAnalysis.PEAssembly
                objA, Microsoft.CodeAnalysis.PEAssembly
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 4522, 4587);
                    return return_v;
                }


                bool
                f_21009_4591_4640(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                @this, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                that)
                {
                    var return_v = @this.HasUnresolvedReferencesByComparisonTo(that);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 4591, 4640);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_21009_5106_5148(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingAssemblySymbol
                this_param)
                {
                    var return_v = this_param.UnderlyingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 5106, 5148);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_21009_5150_5192(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingAssemblySymbol
                this_param)
                {
                    var return_v = this_param.UnderlyingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 5150, 5192);
                    return return_v;
                }


                bool
                f_21009_5090_5193(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 5090, 5193);
                    return return_v;
                }


                bool
                f_21009_5222_5271(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                @this, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                that)
                {
                    var return_v = @this.HasUnresolvedReferencesByComparisonTo(that);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 5222, 5271);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_21009_5438_5480(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingAssemblySymbol
                this_param)
                {
                    var return_v = this_param.UnderlyingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 5438, 5480);
                    return return_v;
                }


                bool
                f_21009_5422_5501(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 5422, 5501);
                    return return_v;
                }


                bool
                f_21009_5526_5575(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                @this, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                that)
                {
                    var return_v = @this.HasUnresolvedReferencesByComparisonTo(that);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 5526, 5575);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 4022, 5631);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 4022, 5631);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ImmutableArray<string> SplitMemberName(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 5643, 6218);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 5734, 5868) || true) && (f_21009_5738_5784(name, ".", StringComparison.Ordinal))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 5734, 5868);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 5818, 5853);

                    return f_21009_5825_5852(name);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 5734, 5868);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 5884, 5933);

                var
                builder = f_21009_5898_5932()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 5947, 5966);

                string
                part = name
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 5980, 6115) || true) && (f_21009_5987_5998(part) > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 5980, 6115);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 6036, 6100);

                        f_21009_6036_6099(builder, f_21009_6048_6098(part, out part));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 5980, 6115);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(21009, 5980, 6115);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(21009, 5980, 6115);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 6131, 6157);

                f_21009_6131_6156(
                            builder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 6171, 6207);

                return f_21009_6178_6206(builder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 5643, 6218);

                bool
                f_21009_5738_5784(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 5738, 5784);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_21009_5825_5852(string
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 5825, 5852);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                f_21009_5898_5932()
                {
                    var return_v = ArrayBuilder<string>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 5898, 5932);
                    return return_v;
                }


                int
                f_21009_5987_5998(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 5987, 5998);
                    return return_v;
                }


                string
                f_21009_6048_6098(string
                pstrName, out string
                qualifier)
                {
                    var return_v = MetadataHelpers.SplitQualifiedName(pstrName, out qualifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 6048, 6098);
                    return return_v;
                }


                int
                f_21009_6036_6099(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 6036, 6099);
                    return 0;
                }


                int
                f_21009_6131_6156(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param)
                {
                    this_param.ReverseContents();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 6131, 6156);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_21009_6178_6206(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 6178, 6206);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 5643, 6218);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 5643, 6218);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Symbol GetMember(this CSharpCompilation compilation, string qualifiedName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 6230, 6414);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 6343, 6403);

                return f_21009_6350_6402(f_21009_6350_6377(compilation), qualifiedName);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 6230, 6414);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_21009_6350_6377(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 6350, 6377);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_21009_6350_6402(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                container, string
                qualifiedName)
                {
                    var return_v = container.GetMember(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 6350, 6402);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 6230, 6414);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 6230, 6414);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ISymbol GetMember(this Compilation compilation, string qualifiedName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 6426, 6605);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 6534, 6594);

                return f_21009_6541_6593(f_21009_6541_6568(compilation), qualifiedName);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 6426, 6605);

                Microsoft.CodeAnalysis.INamespaceSymbol
                f_21009_6541_6568(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 6541, 6568);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol
                f_21009_6541_6593(Microsoft.CodeAnalysis.INamespaceSymbol
                container, string
                qualifiedName)
                {
                    var return_v = container.GetMember(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 6541, 6593);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 6426, 6605);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 6426, 6605);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static T GetMember<T>(this CSharpCompilation compilation, string qualifiedName) where T : Symbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 6617, 6819);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 6745, 6808);

                return (T)f_21009_6755_6807<T>(f_21009_6755_6782<T>(compilation), qualifiedName);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 6617, 6819);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_21009_6755_6782<T>(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param) where T : Symbol

                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 6755, 6782);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_21009_6755_6807<T>(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                container, string
                qualifiedName) where T : Symbol

                {
                    var return_v = container.GetMember(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 6755, 6807);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 6617, 6819);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 6617, 6819);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static T GetMember<T>(this Compilation compilation, string qualifiedName) where T : ISymbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 6831, 7028);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 6954, 7017);

                return (T)f_21009_6964_7016<T>(f_21009_6964_6991<T>(compilation), qualifiedName);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 6831, 7028);

                Microsoft.CodeAnalysis.INamespaceSymbol
                f_21009_6964_6991<T>(Microsoft.CodeAnalysis.Compilation
                this_param) where T : ISymbol

                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 6964, 6991);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol
                f_21009_6964_7016<T>(Microsoft.CodeAnalysis.INamespaceSymbol
                container, string
                qualifiedName) where T : ISymbol

                {
                    var return_v = container.GetMember(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 6964, 7016);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 6831, 7028);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 6831, 7028);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ImmutableArray<Symbol> GetMembers(this Compilation compilation, string qualifiedName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 7040, 7664);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 7164, 7200);

                NamespaceOrTypeSymbol
                lastContainer
                = default(NamespaceOrTypeSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 7214, 7323);

                var
                members = f_21009_7228_7322(f_21009_7239_7287(((CSharpCompilation)compilation)), qualifiedName, out lastContainer)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 7337, 7624) || true) && (members.IsEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 7337, 7624);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 7390, 7609);

                    f_21009_7390_7608(false, f_21009_7415_7607("Could not find member named '{0}'.  Available members:\r\n{1}", qualifiedName, f_21009_7530_7606("\r\n", f_21009_7550_7576(lastContainer).Select(m => "\t\t" + m.Name))));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 7337, 7624);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 7638, 7653);

                return members;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 7040, 7664);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_21009_7239_7287(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 7239, 7287);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_21009_7228_7322(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                container, string
                qualifiedName, out Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                lastContainer)
                {
                    var return_v = GetMembers((Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol)container, qualifiedName, out lastContainer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 7228, 7322);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_21009_7550_7576(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 7550, 7576);
                    return return_v;
                }


                string
                f_21009_7530_7606(string
                separator, System.Collections.Generic.IEnumerable<string>
                values)
                {
                    var return_v = string.Join(separator, values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 7530, 7606);
                    return return_v;
                }


                string
                f_21009_7415_7607(string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format(format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 7415, 7607);
                    return return_v;
                }


                bool
                f_21009_7390_7608(bool
                condition, string
                userMessage)
                {
                    var return_v = CustomAssert.True(condition, userMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 7390, 7608);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 7040, 7664);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 7040, 7664);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ImmutableArray<Symbol> GetMembers(NamespaceOrTypeSymbol container, string qualifiedName, out NamespaceOrTypeSymbol lastContainer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 7676, 8676);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 7845, 7888);

                var
                parts = f_21009_7857_7887(qualifiedName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 7904, 7930);

                lastContainer = container;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 7953, 7958);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 7944, 8592) || true) && (i < parts.Length - 1)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 7982, 7985)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 7944, 8592))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 7944, 8592);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 8019, 8098);

                        var
                        nestedContainer = (NamespaceOrTypeSymbol)f_21009_8064_8097(lastContainer, parts[i])
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 8116, 8577) || true) && (nestedContainer == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 8116, 8577);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 8379, 8444);

                            return f_21009_8386_8443(lastContainer, f_21009_8411_8442(".", f_21009_8428_8441(ref parts, i)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 8116, 8577);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 8116, 8577);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 8526, 8558);

                            lastContainer = nestedContainer;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 8116, 8577);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(21009, 1, 649);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(21009, 1, 649);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 8608, 8665);

                return f_21009_8615_8664(lastContainer, parts[parts.Length - 1]);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 7676, 8676);

                System.Collections.Immutable.ImmutableArray<string>
                f_21009_7857_7887(string
                name)
                {
                    var return_v = SplitMemberName(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 7857, 7887);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_21009_8064_8097(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                container, string
                qualifiedName)
                {
                    var return_v = container.GetMember(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 8064, 8097);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_21009_8428_8441(ref System.Collections.Immutable.ImmutableArray<string>
                source, int
                count)
                {
                    var return_v = source.Skip<string>(count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 8428, 8441);
                    return return_v;
                }


                string
                f_21009_8411_8442(string
                separator, System.Collections.Generic.IEnumerable<string>
                values)
                {
                    var return_v = string.Join(separator, values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 8411, 8442);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_21009_8386_8443(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 8386, 8443);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_21009_8615_8664(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 8615, 8664);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 7676, 8676);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 7676, 8676);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ImmutableArray<ISymbol> GetMembers(INamespaceOrTypeSymbol container, string qualifiedName, out INamespaceOrTypeSymbol lastContainer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 8688, 9692);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 8860, 8903);

                var
                parts = f_21009_8872_8902(qualifiedName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 8919, 8945);

                lastContainer = container;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 8968, 8973);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 8959, 9608) || true) && (i < parts.Length - 1)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 8997, 9000)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 8959, 9608))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 8959, 9608);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 9034, 9114);

                        var
                        nestedContainer = (INamespaceOrTypeSymbol)f_21009_9080_9113(lastContainer, parts[i])
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 9132, 9593) || true) && (nestedContainer == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 9132, 9593);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 9395, 9460);

                            return f_21009_9402_9459(lastContainer, f_21009_9427_9458(".", f_21009_9444_9457(ref parts, i)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 9132, 9593);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 9132, 9593);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 9542, 9574);

                            lastContainer = nestedContainer;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 9132, 9593);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(21009, 1, 650);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(21009, 1, 650);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 9624, 9681);

                return f_21009_9631_9680(lastContainer, parts[parts.Length - 1]);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 8688, 9692);

                System.Collections.Immutable.ImmutableArray<string>
                f_21009_8872_8902(string
                name)
                {
                    var return_v = SplitMemberName(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 8872, 8902);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol
                f_21009_9080_9113(Microsoft.CodeAnalysis.INamespaceOrTypeSymbol
                container, string
                qualifiedName)
                {
                    var return_v = container.GetMember(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 9080, 9113);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_21009_9444_9457(ref System.Collections.Immutable.ImmutableArray<string>
                source, int
                count)
                {
                    var return_v = source.Skip<string>(count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 9444, 9457);
                    return return_v;
                }


                string
                f_21009_9427_9458(string
                separator, System.Collections.Generic.IEnumerable<string>
                values)
                {
                    var return_v = string.Join(separator, values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 9427, 9458);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_21009_9402_9459(Microsoft.CodeAnalysis.INamespaceOrTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 9402, 9459);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_21009_9631_9680(Microsoft.CodeAnalysis.INamespaceOrTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 9631, 9680);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 8688, 9692);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 8688, 9692);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Symbol GetMember(this NamespaceOrTypeSymbol container, string qualifiedName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 9704, 10283);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 9819, 9855);

                NamespaceOrTypeSymbol
                lastContainer
                = default(NamespaceOrTypeSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 9869, 9939);

                var
                members = f_21009_9883_9938(container, qualifiedName, out lastContainer)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 9953, 10232) || true) && (members.Length == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 9953, 10232);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 10010, 10022);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 9953, 10232);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 9953, 10232);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 10056, 10232) || true) && (members.Length > 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 10056, 10232);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 10112, 10217);

                        f_21009_10112_10216(false, "Found multiple members of specified name:\r\n" + f_21009_10187_10215("\r\n", members));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 10056, 10232);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 9953, 10232);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 10248, 10272);

                return members.Single();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 9704, 10283);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_21009_9883_9938(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                container, string
                qualifiedName, out Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                lastContainer)
                {
                    var return_v = GetMembers(container, qualifiedName, out lastContainer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 9883, 9938);
                    return return_v;
                }


                string
                f_21009_10187_10215(string
                separator, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                values)
                {
                    var return_v = string.Join(separator, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbol>)values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 10187, 10215);
                    return return_v;
                }


                bool
                f_21009_10112_10216(bool
                condition, string
                userMessage)
                {
                    var return_v = CustomAssert.True(condition, userMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 10112, 10216);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 9704, 10283);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 9704, 10283);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ISymbol GetMember(this INamespaceOrTypeSymbol container, string qualifiedName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 10295, 10877);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 10412, 10449);

                INamespaceOrTypeSymbol
                lastContainer
                = default(INamespaceOrTypeSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 10463, 10533);

                var
                members = f_21009_10477_10532(container, qualifiedName, out lastContainer)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 10547, 10826) || true) && (members.Length == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 10547, 10826);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 10604, 10616);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 10547, 10826);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 10547, 10826);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 10650, 10826) || true) && (members.Length > 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 10650, 10826);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 10706, 10811);

                        f_21009_10706_10810(false, "Found multiple members of specified name:\r\n" + f_21009_10781_10809("\r\n", members));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 10650, 10826);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 10547, 10826);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 10842, 10866);

                return members.Single();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 10295, 10877);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_21009_10477_10532(Microsoft.CodeAnalysis.INamespaceOrTypeSymbol
                container, string
                qualifiedName, out Microsoft.CodeAnalysis.INamespaceOrTypeSymbol
                lastContainer)
                {
                    var return_v = GetMembers(container, qualifiedName, out lastContainer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 10477, 10532);
                    return return_v;
                }


                string
                f_21009_10781_10809(string
                separator, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                values)
                {
                    var return_v = string.Join(separator, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ISymbol>)values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 10781, 10809);
                    return return_v;
                }


                bool
                f_21009_10706_10810(bool
                condition, string
                userMessage)
                {
                    var return_v = CustomAssert.True(condition, userMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 10706, 10810);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 10295, 10877);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 10295, 10877);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static T GetMember<T>(this NamespaceOrTypeSymbol symbol, string qualifiedName) where T : Symbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 10889, 11069);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 11016, 11058);

                return (T)f_21009_11026_11057<T>(symbol, qualifiedName);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 10889, 11069);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_21009_11026_11057<T>(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                container, string
                qualifiedName) where T : Symbol

                {
                    var return_v = container.GetMember(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 11026, 11057);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 10889, 11069);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 10889, 11069);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static T GetMember<T>(this INamespaceOrTypeSymbol symbol, string qualifiedName) where T : ISymbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 11081, 11263);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 11210, 11252);

                return (T)f_21009_11220_11251<T>(symbol, qualifiedName);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 11081, 11263);

                Microsoft.CodeAnalysis.ISymbol
                f_21009_11220_11251<T>(Microsoft.CodeAnalysis.INamespaceOrTypeSymbol
                container, string
                qualifiedName) where T : ISymbol

                {
                    var return_v = container.GetMember(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 11220, 11251);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 11081, 11263);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 11081, 11263);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static PropertySymbol GetProperty(this NamedTypeSymbol symbol, string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 11275, 11449);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 11382, 11438);

                return (PropertySymbol)f_21009_11405_11428(symbol, name).Single();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 11275, 11449);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_21009_11405_11428(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 11405, 11428);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 11275, 11449);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 11275, 11449);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static EventSymbol GetEvent(this NamedTypeSymbol symbol, string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 11461, 11626);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 11562, 11615);

                return (EventSymbol)f_21009_11582_11605(symbol, name).Single();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 11461, 11626);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_21009_11582_11605(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 11582, 11605);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 11461, 11626);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 11461, 11626);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static MethodSymbol GetMethod(this NamedTypeSymbol symbol, string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 11638, 11806);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 11741, 11795);

                return (MethodSymbol)f_21009_11762_11785(symbol, name).Single();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 11638, 11806);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_21009_11762_11785(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 11762, 11785);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 11638, 11806);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 11638, 11806);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static FieldSymbol GetField(this NamedTypeSymbol symbol, string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 11818, 11983);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 11919, 11972);

                return (FieldSymbol)f_21009_11939_11962(symbol, name).Single();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 11818, 11983);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_21009_11939_11962(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 11939, 11962);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 11818, 11983);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 11818, 11983);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static NamedTypeSymbol GetTypeMember(this NamespaceOrTypeSymbol symbol, string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 11995, 12166);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 12111, 12155);

                return f_21009_12118_12145(symbol, name).Single();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 11995, 12166);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_21009_12118_12145(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetTypeMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 12118, 12145);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 11995, 12166);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 11995, 12166);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static INamedTypeSymbol GetTypeMember(this INamespaceOrTypeSymbol symbol, string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 12178, 12351);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 12296, 12340);

                return f_21009_12303_12330(symbol, name).Single();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 12178, 12351);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.INamedTypeSymbol>
                f_21009_12303_12330(Microsoft.CodeAnalysis.INamespaceOrTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetTypeMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 12303, 12330);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 12178, 12351);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 12178, 12351);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string[] GetFieldNames(this ModuleSymbol module, string qualifiedTypeName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 12363, 12658);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 12476, 12556);

                var
                type = (NamedTypeSymbol)f_21009_12504_12555(f_21009_12504_12526(module), qualifiedTypeName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 12570, 12647);

                return f_21009_12577_12646(f_21009_12577_12636(f_21009_12577_12594(type).OfType<FieldSymbol>(), f => f.Name));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 12363, 12658);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_21009_12504_12526(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 12504, 12526);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_21009_12504_12555(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                container, string
                qualifiedName)
                {
                    var return_v = container.GetMember(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 12504, 12555);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_21009_12577_12594(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 12577, 12594);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_21009_12577_12636(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                source, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol, string>
                selector)
                {
                    var return_v = source.Select<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol, string>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 12577, 12636);
                    return return_v;
                }


                string[]
                f_21009_12577_12646(System.Collections.Generic.IEnumerable<string>
                source)
                {
                    var return_v = source.ToArray<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 12577, 12646);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 12363, 12658);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 12363, 12658);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string[] GetFieldNamesAndTypes(this ModuleSymbol module, string qualifiedTypeName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 12670, 13004);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 12791, 12871);

                var
                type = (NamedTypeSymbol)f_21009_12819_12870(f_21009_12819_12841(module), qualifiedTypeName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 12885, 12993);

                return f_21009_12892_12992(f_21009_12892_12982(f_21009_12892_12909(type).OfType<FieldSymbol>(), f => f.Name + ": " + f.TypeWithAnnotations));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 12670, 13004);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_21009_12819_12841(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 12819, 12841);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_21009_12819_12870(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                container, string
                qualifiedName)
                {
                    var return_v = container.GetMember(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 12819, 12870);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_21009_12892_12909(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 12892, 12909);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_21009_12892_12982(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                source, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol, string>
                selector)
                {
                    var return_v = source.Select<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol, string>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 12892, 12982);
                    return return_v;
                }


                string[]
                f_21009_12892_12992(System.Collections.Generic.IEnumerable<string>
                source)
                {
                    var return_v = source.ToArray<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 12892, 12992);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 12670, 13004);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 12670, 13004);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IEnumerable<CSharpAttributeData> GetAttributes(this Symbol @this, NamedTypeSymbol c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 13016, 13267);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 13139, 13256);

                return f_21009_13146_13167(@this).Where(a => TypeSymbol.Equals(a.AttributeClass, c, TypeCompareKind.ConsiderEverything2));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 13016, 13267);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_21009_13146_13167(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 13146, 13167);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 13016, 13267);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 13016, 13267);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IEnumerable<CSharpAttributeData> GetAttributes(this Symbol @this, string namespaceName, string typeName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 13279, 13519);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 13422, 13508);

                return f_21009_13429_13450(@this).Where(a => a.IsTargetAttribute(namespaceName, typeName));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 13279, 13519);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_21009_13429_13450(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 13429, 13450);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 13279, 13519);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 13279, 13519);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IEnumerable<CSharpAttributeData> GetAttributes(this Symbol @this, AttributeDescription description)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 13531, 13761);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 13669, 13750);

                return f_21009_13676_13697(@this).Where(a => a.IsTargetAttribute(@this, description));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 13531, 13761);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_21009_13676_13697(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 13676, 13697);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 13531, 13761);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 13531, 13761);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static CSharpAttributeData GetAttribute(this Symbol @this, NamedTypeSymbol c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 13773, 14018);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 13882, 14007);

                return f_21009_13889_14006(f_21009_13889_13910(@this).Where(a => TypeSymbol.Equals(a.AttributeClass, c, TypeCompareKind.ConsiderEverything2)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 13773, 14018);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_21009_13889_13910(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 13889, 13910);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                f_21009_13889_14006(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                source)
                {
                    var return_v = source.First<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 13889, 14006);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 13773, 14018);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 13773, 14018);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static CSharpAttributeData GetAttribute(this Symbol @this, string namespaceName, string typeName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 14030, 14264);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 14159, 14253);

                return f_21009_14166_14252(f_21009_14166_14187(@this).Where(a => a.IsTargetAttribute(namespaceName, typeName)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 14030, 14264);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_21009_14166_14187(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 14166, 14187);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                f_21009_14166_14252(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                source)
                {
                    var return_v = source.First<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 14166, 14252);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 14030, 14264);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 14030, 14264);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static CSharpAttributeData GetAttribute(this Symbol @this, MethodSymbol m)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 14276, 14541);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 14382, 14530);

                return f_21009_14389_14529(f_21009_14389_14521((DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => from a in @this.GetAttributes()
                                                                                                                        where a.AttributeConstructor.Equals(m)
                                                                                                                        select a, 21009, 14390, 14511))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 14276, 14541);

                System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_21009_14389_14521(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                source)
                {
                    var return_v = source.ToList<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 14389, 14521);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                f_21009_14389_14529(System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                source)
                {
                    var return_v = source.First<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 14389, 14529);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 14276, 14541);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 14276, 14541);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool HasAttribute(this Symbol @this, MethodSymbol m)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 14553, 14820);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 14644, 14809);

                return f_21009_14651_14800(f_21009_14651_14783((DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => from a in @this.GetAttributes()
                                                                                                                        where a.AttributeConstructor.Equals(m)
                                                                                                                        select a, 21009, 14652, 14773)))) != null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 14553, 14820);

                System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_21009_14651_14783(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                source)
                {
                    var return_v = source.ToList<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 14651, 14783);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                f_21009_14651_14800(System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                source)
                {
                    var return_v = source.FirstOrDefault<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 14651, 14800);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 14553, 14820);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 14553, 14820);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static void VerifyValue<T>(this CSharpAttributeData attr, int i, TypedConstantKind kind, T v)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 14832, 15111);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 14957, 15002);

                var
                arg = f_21009_14967_14998<T>(attr)[i]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 15016, 15051);

                f_21009_15016_15050<T>(kind, arg.Kind);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 15065, 15100);

                f_21009_15065_15099<T>(f_21009_15083_15098<T>(arg, v));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 14832, 15111);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_21009_14967_14998<T>(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.CommonConstructorArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 14967, 14998);
                    return return_v;
                }


                bool
                f_21009_15016_15050<T>(Microsoft.CodeAnalysis.TypedConstantKind
                expected, Microsoft.CodeAnalysis.TypedConstantKind
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 15016, 15050);
                    return return_v;
                }


                bool
                f_21009_15083_15098<T>(Microsoft.CodeAnalysis.TypedConstant
                arg, T
                expected)
                {
                    var return_v = IsEqual(arg, (object)expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 15083, 15098);
                    return return_v;
                }


                bool
                f_21009_15065_15099<T>(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 15065, 15099);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 14832, 15111);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 14832, 15111);
            }
        }

        public static void VerifyNamedArgumentValue<T>(this CSharpAttributeData attr, int i, string name, TypedConstantKind kind, T v)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 15123, 15519);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 15274, 15318);

                var
                namedArg = f_21009_15289_15314<T>(attr)[i]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 15332, 15371);

                f_21009_15332_15370<T>(namedArg.Key, name);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 15385, 15410);

                var
                arg = namedArg.Value
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 15424, 15459);

                f_21009_15424_15458<T>(arg.Kind, kind);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 15473, 15508);

                f_21009_15473_15507<T>(f_21009_15491_15506<T>(arg, v));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 15123, 15519);

                System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                f_21009_15289_15314<T>(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.CommonNamedArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 15289, 15314);
                    return return_v;
                }


                bool
                f_21009_15332_15370<T>(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 15332, 15370);
                    return return_v;
                }


                bool
                f_21009_15424_15458<T>(Microsoft.CodeAnalysis.TypedConstantKind
                expected, Microsoft.CodeAnalysis.TypedConstantKind
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 15424, 15458);
                    return return_v;
                }


                bool
                f_21009_15491_15506<T>(Microsoft.CodeAnalysis.TypedConstant
                arg, T
                expected)
                {
                    var return_v = IsEqual(arg, (object)expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 15491, 15506);
                    return return_v;
                }


                bool
                f_21009_15473_15507<T>(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 15473, 15507);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 15123, 15519);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 15123, 15519);
            }
        }

        internal static bool IsEqual(TypedConstant arg, object expected)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 15531, 17402);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 15620, 17391);

                switch (arg.Kind)
                {

                    case TypedConstantKind.Array:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 15620, 17391);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 15721, 15759);

                        return f_21009_15728_15758(arg.Values, expected);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 15620, 17391);

                    case TypedConstantKind.Enum:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 15620, 17391);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 15827, 15861);

                        return f_21009_15834_15860(expected, arg.Value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 15620, 17391);

                    case TypedConstantKind.Type:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 15620, 17391);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 15929, 15975);

                        var
                        typeSym = arg.ValueInternal as TypeSymbol
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 15997, 16110) || true) && ((object)typeSym == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 15997, 16110);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 16074, 16087);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 15997, 16110);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 16134, 16174);

                        var
                        expTypeSym = expected as TypeSymbol
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 16196, 16311) || true) && (f_21009_16200_16226(typeSym, expTypeSym))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 16196, 16311);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 16276, 16288);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 16196, 16311);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 16417, 16856) || true) && (f_21009_16421_16433(typeSym) == SymbolKind.NamedType && (DynAbs.Tracing.TraceSender.Expression_True(21009, 16421, 16526) && f_21009_16486_16526(((NamedTypeSymbol)typeSym))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 16417, 16856);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 16576, 16641);

                            var
                            s1 = f_21009_16585_16640(typeSym, SymbolDisplayFormat.TestFormat)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 16667, 16696);

                            var
                            s2 = f_21009_16676_16695(expected)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 16722, 16833) || true) && ((s1 == s2))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 16722, 16833);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 16794, 16806);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 16722, 16833);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 16417, 16856);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 16880, 16911);

                        var
                        expType = expected as Type
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 16933, 17038) || true) && (expType == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 16933, 17038);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 17002, 17015);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 16933, 17038);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 17149, 17182);

                        return f_21009_17156_17181(typeSym, expType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 15620, 17391);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 15620, 17391);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 17303, 17376);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(21009, 17310, 17326) || ((expected == null && DynAbs.Tracing.TraceSender.Conditional_F2(21009, 17329, 17346)) || DynAbs.Tracing.TraceSender.Conditional_F3(21009, 17349, 17375))) ? arg.Value == null : f_21009_17349_17375(expected, arg.Value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 15620, 17391);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 15531, 17402);

                bool
                f_21009_15728_15758(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                tc, object
                o)
                {
                    var return_v = AreEqual(tc, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 15728, 15758);
                    return return_v;
                }


                bool
                f_21009_15834_15860(object
                this_param, object?
                obj)
                {
                    var return_v = this_param.Equals(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 15834, 15860);
                    return return_v;
                }


                bool
                f_21009_16200_16226(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                obj)
                {
                    var return_v = this_param.Equals((object?)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 16200, 16226);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_21009_16421_16433(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 16421, 16433);
                    return return_v;
                }


                bool
                f_21009_16486_16526(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsGenericType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 16486, 16526);
                    return return_v;
                }


                string
                f_21009_16585_16640(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.SymbolDisplayFormat
                format)
                {
                    var return_v = this_param.ToDisplayString(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 16585, 16640);
                    return return_v;
                }


                string?
                f_21009_16676_16695(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 16676, 16695);
                    return return_v;
                }


                bool
                f_21009_17156_17181(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeSym, System.Type
                expType)
                {
                    var return_v = IsEqual(typeSym, expType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 17156, 17181);
                    return return_v;
                }


                bool
                f_21009_17349_17375(object
                this_param, object?
                obj)
                {
                    var return_v = this_param.Equals(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 17349, 17375);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 15531, 17402);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 15531, 17402);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsEqual(TypeSymbol typeSym, Type expType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 17480, 19887);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 17594, 19847) || true) && ((f_21009_17599_17615(typeSym) == TypeKind.Interface || (DynAbs.Tracing.TraceSender.Expression_False(21009, 17599, 17675) || f_21009_17641_17657(typeSym) == TypeKind.Class) || (DynAbs.Tracing.TraceSender.Expression_False(21009, 17599, 17714) || f_21009_17679_17695(typeSym) == TypeKind.Struct) || (DynAbs.Tracing.TraceSender.Expression_False(21009, 17599, 17755) || f_21009_17718_17734(typeSym) == TypeKind.Delegate)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 17594, 19847);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 17790, 17843);

                    NamedTypeSymbol
                    namedType = (NamedTypeSymbol)typeSym
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 17945, 18068) || true) && ((f_21009_17950_17965(namedType) == 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 17945, 18068);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 18013, 18049);

                        return f_21009_18020_18032(typeSym) == f_21009_18036_18048(expType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 17945, 18068);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 18114, 18230) || true) && (f_21009_18118_18156_M(!(f_21009_18120_18155(f_21009_18120_18141(expType)))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 18114, 18230);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 18198, 18211);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 18114, 18230);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 18250, 18278);

                    var
                    nameOnly = f_21009_18265_18277(expType)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 18332, 18390);

                    var
                    idx = f_21009_18342_18389(f_21009_18342_18354(expType), new char[] { '`' })
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 18408, 18524) || true) && ((idx > 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 18408, 18524);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 18463, 18505);

                        nameOnly = f_21009_18474_18504(f_21009_18474_18486(expType), 0, idx);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 18408, 18524);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 18542, 18647) || true) && (!(f_21009_18548_18560(typeSym) == nameOnly))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 18542, 18647);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 18615, 18628);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 18542, 18647);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 18665, 18709);

                    var
                    expArgs = f_21009_18679_18708(expType)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 18727, 18767);

                    var
                    actArgs = f_21009_18741_18766(namedType)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 18785, 18899) || true) && (!(f_21009_18791_18806(expArgs) == actArgs.Length))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 18785, 18899);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 18867, 18880);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 18785, 18899);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 18928, 18933);

                        for (var
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 18919, 19147) || true) && (i <= f_21009_18940_18955(expArgs) - 1)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 18961, 18964)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 18919, 19147))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 18919, 19147);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 19006, 19128) || true) && (!f_21009_19011_19042(actArgs[i], expArgs[i]))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 19006, 19128);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 19092, 19105);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 19006, 19128);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(21009, 1, 229);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(21009, 1, 229);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 19165, 19177);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 17594, 19847);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 17594, 19847);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 19242, 19847) || true) && (f_21009_19246_19262(typeSym) == TypeKind.Array)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 19242, 19847);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 19314, 19408) || true) && (f_21009_19318_19334_M(!expType.IsArray))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 19314, 19408);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 19376, 19389);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 19314, 19408);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 19426, 19464);

                        var
                        arySym = (ArrayTypeSymbol)typeSym
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 19482, 19614) || true) && (!f_21009_19487_19540(f_21009_19495_19513(arySym), f_21009_19515_19539(expType)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 19482, 19614);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 19582, 19595);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 19482, 19614);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 19632, 19769) || true) && (!f_21009_19637_19695(f_21009_19645_19662(arySym), f_21009_19664_19694(f_21009_19664_19685(expType))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 19632, 19769);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 19737, 19750);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 19632, 19769);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 19787, 19832);

                        return f_21009_19794_19805(arySym) == f_21009_19809_19831(expType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 19242, 19847);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 17594, 19847);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 19863, 19876);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 17480, 19887);

                Microsoft.CodeAnalysis.TypeKind
                f_21009_17599_17615(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 17599, 17615);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_21009_17641_17657(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 17641, 17657);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_21009_17679_17695(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 17679, 17695);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_21009_17718_17734(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 17718, 17734);
                    return return_v;
                }


                int
                f_21009_17950_17965(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 17950, 17965);
                    return return_v;
                }


                string
                f_21009_18020_18032(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 18020, 18032);
                    return return_v;
                }


                string
                f_21009_18036_18048(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 18036, 18048);
                    return return_v;
                }


                System.Reflection.TypeInfo
                f_21009_18120_18141(System.Type
                type)
                {
                    var return_v = type.GetTypeInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 18120, 18141);
                    return return_v;
                }


                bool
                f_21009_18120_18155(System.Reflection.TypeInfo
                this_param)
                {
                    var return_v = this_param.IsGenericType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 18120, 18155);
                    return return_v;
                }


                bool
                f_21009_18118_18156_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 18118, 18156);
                    return return_v;
                }


                string
                f_21009_18265_18277(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 18265, 18277);
                    return return_v;
                }


                string
                f_21009_18342_18354(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 18342, 18354);
                    return return_v;
                }


                int
                f_21009_18342_18389(string
                this_param, char[]
                anyOf)
                {
                    var return_v = this_param.LastIndexOfAny(anyOf);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 18342, 18389);
                    return return_v;
                }


                string
                f_21009_18474_18486(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 18474, 18486);
                    return return_v;
                }


                string
                f_21009_18474_18504(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 18474, 18504);
                    return return_v;
                }


                string
                f_21009_18548_18560(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 18548, 18560);
                    return return_v;
                }


                System.Type[]
                f_21009_18679_18708(System.Type
                this_param)
                {
                    var return_v = this_param.GetGenericArguments();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 18679, 18708);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                f_21009_18741_18766(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.TypeArguments();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 18741, 18766);
                    return return_v;
                }


                int
                f_21009_18791_18806(System.Type[]
                source)
                {
                    var return_v = source.Count<System.Type>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 18791, 18806);
                    return return_v;
                }


                int
                f_21009_18940_18955(System.Type[]
                source)
                {
                    var return_v = source.Count<System.Type>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 18940, 18955);
                    return return_v;
                }


                bool
                f_21009_19011_19042(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeSym, System.Type
                expType)
                {
                    var return_v = IsEqual(typeSym, expType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 19011, 19042);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_21009_19246_19262(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 19246, 19262);
                    return return_v;
                }


                bool
                f_21009_19318_19334_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 19318, 19334);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_21009_19495_19513(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 19495, 19513);
                    return return_v;
                }


                System.Type?
                f_21009_19515_19539(System.Type
                this_param)
                {
                    var return_v = this_param.GetElementType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 19515, 19539);
                    return return_v;
                }


                bool
                f_21009_19487_19540(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeSym, System.Type?
                expType)
                {
                    var return_v = IsEqual(typeSym, expType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 19487, 19540);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_21009_19645_19662(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                symbol)
                {
                    var return_v = symbol.BaseType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 19645, 19662);
                    return return_v;
                }


                System.Reflection.TypeInfo
                f_21009_19664_19685(System.Type
                type)
                {
                    var return_v = type.GetTypeInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 19664, 19685);
                    return return_v;
                }


                System.Type?
                f_21009_19664_19694(System.Reflection.TypeInfo
                this_param)
                {
                    var return_v = this_param.BaseType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 19664, 19694);
                    return return_v;
                }


                bool
                f_21009_19637_19695(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                typeSym, System.Type?
                expType)
                {
                    var return_v = IsEqual((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)typeSym, expType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 19637, 19695);
                    return return_v;
                }


                int
                f_21009_19794_19805(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.Rank;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 19794, 19805);
                    return return_v;
                }


                int
                f_21009_19809_19831(System.Type
                this_param)
                {
                    var return_v = this_param.GetArrayRank();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 19809, 19831);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 17480, 19887);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 17480, 19887);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool AreEqual(ImmutableArray<TypedConstant> tc, object o)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 20028, 20704);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 20125, 20304) || true) && (o == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 20125, 20304);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 20172, 20192);

                    return tc.IsDefault;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 20125, 20304);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 20125, 20304);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 20226, 20304) || true) && (tc.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 20226, 20304);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 20276, 20289);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 20226, 20304);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 20125, 20304);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 20320, 20406) || true) && (f_21009_20324_20344_M(!f_21009_20325_20336(o).IsArray))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 20320, 20406);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 20378, 20391);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 20320, 20406);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 20422, 20439);

                var
                a = (Array)o
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 20453, 20469);

                bool
                ret = true
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 20492, 20497);
                    for (var
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 20483, 20668) || true) && (i <= f_21009_20504_20512(a) - 1)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 20518, 20521)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 20483, 20668))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 20483, 20668);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 20555, 20577);

                        var
                        v = f_21009_20563_20576(a, i)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 20595, 20609);

                        var
                        c = tc[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 20627, 20653);

                        ret = ret & f_21009_20639_20652(c, v);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(21009, 1, 186);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(21009, 1, 186);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 20682, 20693);

                return ret;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 20028, 20704);

                System.Type
                f_21009_20325_20336(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 20325, 20336);
                    return return_v;
                }


                bool
                f_21009_20324_20344_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 20324, 20344);
                    return return_v;
                }


                int
                f_21009_20504_20512(System.Array
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 20504, 20512);
                    return return_v;
                }


                object?
                f_21009_20563_20576(System.Array
                this_param, int
                index)
                {
                    var return_v = this_param.GetValue(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 20563, 20576);
                    return return_v;
                }


                bool
                f_21009_20639_20652(Microsoft.CodeAnalysis.TypedConstant
                arg, object?
                expected)
                {
                    var return_v = IsEqual(arg, expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 20639, 20652);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 20028, 20704);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 20028, 20704);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static void CheckAccessorShape(this MethodSymbol accessor, Symbol propertyOrEvent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 20716, 23530);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 20830, 20892);

                f_21009_20830_20891(propertyOrEvent, f_21009_20865_20890(accessor));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 20908, 20958);

                f_21009_20908_20957(accessor, propertyOrEvent);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 20974, 21064);

                f_21009_20974_21063(accessor, f_21009_21006_21062(f_21009_21006_21036(propertyOrEvent), f_21009_21048_21061(accessor)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 21080, 21149);

                var
                propertyOrEventType = f_21009_21106_21143(propertyOrEvent).Type
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 21163, 23519);

                switch (f_21009_21171_21190(accessor))
                {

                    case MethodKind.EventAdd:
                    case MethodKind.EventRemove:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 21163, 23519);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 21317, 21394);

                        f_21009_21317_21393(SpecialType.System_Void, f_21009_21361_21392(f_21009_21361_21380(accessor)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 21416, 21491);

                        f_21009_21416_21490(propertyOrEventType, f_21009_21456_21489(accessor.Parameters.Single()));
                        DynAbs.Tracing.TraceSender.TraceBreak(21009, 21513, 21519);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 21163, 23519);

                    case MethodKind.PropertyGet:
                    case MethodKind.PropertySet:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 21163, 23519);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 21633, 21680);

                        var
                        property = (PropertySymbol)propertyOrEvent
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 21702, 21763);

                        var
                        isSetter = f_21009_21717_21736(accessor) == MethodKind.PropertySet
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 21787, 22108) || true) && (isSetter)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 21787, 22108);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 21849, 21926);

                            f_21009_21849_21925(SpecialType.System_Void, f_21009_21893_21924(f_21009_21893_21912(accessor)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 21787, 22108);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 21787, 22108);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 22024, 22085);

                            f_21009_22024_22084(propertyOrEventType, f_21009_22064_22083(accessor));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 21787, 22108);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 22132, 22177);

                        var
                        propertyParameters = f_21009_22157_22176(property)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 22199, 22244);

                        var
                        accessorParameters = f_21009_22224_22243(accessor)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 22266, 22360);

                        f_21009_22266_22359(propertyParameters.Length, accessorParameters.Length - ((DynAbs.Tracing.TraceSender.Conditional_F1(21009, 22341, 22349) || ((isSetter && DynAbs.Tracing.TraceSender.Conditional_F2(21009, 22352, 22353)) || DynAbs.Tracing.TraceSender.Conditional_F3(21009, 22356, 22357))) ? 1 : 0));
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 22391, 22396);
                            for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 22382, 22876) || true) && (i < propertyParameters.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 22429, 22432)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 22382, 22876))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 22382, 22876);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 22482, 22524);

                                var
                                propertyParam = propertyParameters[i]
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 22550, 22592);

                                var
                                accessorParam = accessorParameters[i]
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 22618, 22677);

                                f_21009_22618_22676(f_21009_22637_22655(propertyParam), f_21009_22657_22675(accessorParam));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 22703, 22768);

                                f_21009_22703_22767(f_21009_22722_22743(propertyParam), f_21009_22745_22766(accessorParam));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 22794, 22853);

                                f_21009_22794_22852(f_21009_22813_22831(propertyParam), f_21009_22833_22851(accessorParam));
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(21009, 1, 495);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(21009, 1, 495);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 22900, 23324) || true) && (isSetter)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 22900, 23324);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 22962, 23029);

                            var
                            valueParameter = accessorParameters[propertyParameters.Length]
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 23055, 23116);

                            f_21009_23055_23115(propertyOrEventType, f_21009_23095_23114(valueParameter));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 23142, 23199);

                            f_21009_23142_23198(RefKind.None, f_21009_23175_23197(valueParameter));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 23225, 23301);

                            f_21009_23225_23300(ParameterSymbol.ValueParameterName, f_21009_23280_23299(valueParameter));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 22900, 23324);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(21009, 23346, 23352);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 21163, 23519);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 21163, 23519);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 23400, 23476);

                        f_21009_23400_23475(true, "Unexpected accessor kind " + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (f_21009_23455_23474(accessor)).ToString(), 21009, 23455, 23474));
                        DynAbs.Tracing.TraceSender.TraceBreak(21009, 23498, 23504);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 21163, 23519);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 20716, 23530);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_21009_20865_20890(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.AssociatedSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 20865, 20890);
                    return return_v;
                }


                bool
                f_21009_20830_20891(Microsoft.CodeAnalysis.CSharp.Symbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbol
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 20830, 20891);
                    return return_v;
                }


                int
                f_21009_20908_20957(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                accessor, Microsoft.CodeAnalysis.CSharp.Symbol
                propertyOrEvent)
                {
                    accessor.CheckAccessorModifiers(propertyOrEvent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 20908, 20957);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_21009_21006_21036(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 21006, 21036);
                    return return_v;
                }


                string
                f_21009_21048_21061(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 21048, 21061);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_21009_21006_21062(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 21006, 21062);
                    return return_v;
                }


                bool
                f_21009_20974_21063(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                expected, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                collection)
                {
                    var return_v = CustomAssert.Contains((Microsoft.CodeAnalysis.CSharp.Symbol)expected, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbol>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 20974, 21063);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_21009_21106_21143(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.GetTypeOrReturnType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 21106, 21143);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_21009_21171_21190(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 21171, 21190);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_21009_21361_21380(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 21361, 21380);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_21009_21361_21392(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 21361, 21392);
                    return return_v;
                }


                bool
                f_21009_21317_21393(Microsoft.CodeAnalysis.SpecialType
                expected, Microsoft.CodeAnalysis.SpecialType
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 21317, 21393);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_21009_21456_21489(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 21456, 21489);
                    return return_v;
                }


                bool
                f_21009_21416_21490(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 21416, 21490);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_21009_21717_21736(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 21717, 21736);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_21009_21893_21912(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 21893, 21912);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_21009_21893_21924(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 21893, 21924);
                    return return_v;
                }


                bool
                f_21009_21849_21925(Microsoft.CodeAnalysis.SpecialType
                expected, Microsoft.CodeAnalysis.SpecialType
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 21849, 21925);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_21009_22064_22083(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 22064, 22083);
                    return return_v;
                }


                bool
                f_21009_22024_22084(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 22024, 22084);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_21009_22157_22176(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 22157, 22176);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_21009_22224_22243(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 22224, 22243);
                    return return_v;
                }


                bool
                f_21009_22266_22359(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 22266, 22359);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_21009_22637_22655(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 22637, 22655);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_21009_22657_22675(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 22657, 22675);
                    return return_v;
                }


                bool
                f_21009_22618_22676(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 22618, 22676);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_21009_22722_22743(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 22722, 22743);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_21009_22745_22766(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 22745, 22766);
                    return return_v;
                }


                bool
                f_21009_22703_22767(Microsoft.CodeAnalysis.RefKind
                expected, Microsoft.CodeAnalysis.RefKind
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 22703, 22767);
                    return return_v;
                }


                string
                f_21009_22813_22831(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 22813, 22831);
                    return return_v;
                }


                string
                f_21009_22833_22851(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 22833, 22851);
                    return return_v;
                }


                bool
                f_21009_22794_22852(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 22794, 22852);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_21009_23095_23114(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 23095, 23114);
                    return return_v;
                }


                bool
                f_21009_23055_23115(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 23055, 23115);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_21009_23175_23197(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 23175, 23197);
                    return return_v;
                }


                bool
                f_21009_23142_23198(Microsoft.CodeAnalysis.RefKind
                expected, Microsoft.CodeAnalysis.RefKind
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 23142, 23198);
                    return return_v;
                }


                string
                f_21009_23280_23299(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 23280, 23299);
                    return return_v;
                }


                bool
                f_21009_23225_23300(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 23225, 23300);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_21009_23455_23474(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 23455, 23474);
                    return return_v;
                }


                bool
                f_21009_23400_23475(bool
                condition, string
                userMessage)
                {
                    var return_v = CustomAssert.False(condition, userMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 23400, 23475);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 20716, 23530);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 20716, 23530);
            }
        }

        internal static void CheckAccessorModifiers(this MethodSymbol accessor, Symbol propertyOrEvent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 23542, 24241);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 23662, 23752);

                f_21009_23662_23751(f_21009_23681_23718(propertyOrEvent), f_21009_23720_23750(accessor));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 23766, 23834);

                f_21009_23766_23833(f_21009_23785_23811(propertyOrEvent), f_21009_23813_23832(accessor));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 23848, 23916);

                f_21009_23848_23915(f_21009_23867_23893(propertyOrEvent), f_21009_23895_23914(accessor));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 23930, 23996);

                f_21009_23930_23995(f_21009_23949_23974(propertyOrEvent), f_21009_23976_23994(accessor));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 24010, 24074);

                f_21009_24010_24073(f_21009_24029_24053(propertyOrEvent), f_21009_24055_24072(accessor));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 24088, 24152);

                f_21009_24088_24151(f_21009_24107_24131(propertyOrEvent), f_21009_24133_24150(accessor));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 24166, 24230);

                f_21009_24166_24229(f_21009_24185_24209(propertyOrEvent), f_21009_24211_24228(accessor));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 23542, 24241);

                Microsoft.CodeAnalysis.Accessibility
                f_21009_23681_23718(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 23681, 23718);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_21009_23720_23750(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 23720, 23750);
                    return return_v;
                }


                bool
                f_21009_23662_23751(Microsoft.CodeAnalysis.Accessibility
                expected, Microsoft.CodeAnalysis.Accessibility
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 23662, 23751);
                    return return_v;
                }


                bool
                f_21009_23785_23811(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.IsAbstract;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 23785, 23811);
                    return return_v;
                }


                bool
                f_21009_23813_23832(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsAbstract;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 23813, 23832);
                    return return_v;
                }


                bool
                f_21009_23766_23833(bool
                expected, bool
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 23766, 23833);
                    return return_v;
                }


                bool
                f_21009_23867_23893(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.IsOverride;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 23867, 23893);
                    return return_v;
                }


                bool
                f_21009_23895_23914(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsOverride;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 23895, 23914);
                    return return_v;
                }


                bool
                f_21009_23848_23915(bool
                expected, bool
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 23848, 23915);
                    return return_v;
                }


                bool
                f_21009_23949_23974(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.IsVirtual;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 23949, 23974);
                    return return_v;
                }


                bool
                f_21009_23976_23994(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsVirtual;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 23976, 23994);
                    return return_v;
                }


                bool
                f_21009_23930_23995(bool
                expected, bool
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 23930, 23995);
                    return return_v;
                }


                bool
                f_21009_24029_24053(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.IsSealed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 24029, 24053);
                    return return_v;
                }


                bool
                f_21009_24055_24072(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsSealed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 24055, 24072);
                    return return_v;
                }


                bool
                f_21009_24010_24073(bool
                expected, bool
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 24010, 24073);
                    return return_v;
                }


                bool
                f_21009_24107_24131(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.IsExtern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 24107, 24131);
                    return return_v;
                }


                bool
                f_21009_24133_24150(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsExtern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 24133, 24150);
                    return return_v;
                }


                bool
                f_21009_24088_24151(bool
                expected, bool
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 24088, 24151);
                    return return_v;
                }


                bool
                f_21009_24185_24209(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 24185, 24209);
                    return return_v;
                }


                bool
                f_21009_24211_24228(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 24211, 24228);
                    return return_v;
                }


                bool
                f_21009_24166_24229(bool
                expected, bool
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 24166, 24229);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 23542, 24241);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 23542, 24241);
            }
        }

        static Extensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(21009, 784, 24248);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(21009, 784, 24248);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 784, 24248);
        }

    }
}
internal static class Extensions
{
    internal static Symbol GetDeclaredSymbolFromSyntaxNode(this CSharpSemanticModel model, Microsoft.CodeAnalysis.SyntaxNode declaration, CancellationToken cancellationToken = default(CancellationToken))
    {
        try
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 24769, 26320);

            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 25180, 26230) || true) && (!(
                        declaration is AnonymousObjectCreationExpressionSyntax || (DynAbs.Tracing.TraceSender.Expression_False(21009, 25200, 25323) || declaration is AnonymousObjectMemberDeclaratorSyntax) || (DynAbs.Tracing.TraceSender.Expression_False(21009, 25200, 25380) || declaration is BaseTypeDeclarationSyntax) || (DynAbs.Tracing.TraceSender.Expression_False(21009, 25200, 25434) || declaration is CatchDeclarationSyntax) || (DynAbs.Tracing.TraceSender.Expression_False(21009, 25200, 25492) || declaration is ExternAliasDirectiveSyntax) || (DynAbs.Tracing.TraceSender.Expression_False(21009, 25200, 25546) || declaration is ForEachStatementSyntax) || (DynAbs.Tracing.TraceSender.Expression_False(21009, 25200, 25598) || declaration is JoinIntoClauseSyntax) || (DynAbs.Tracing.TraceSender.Expression_False(21009, 25200, 25652) || declaration is LabeledStatementSyntax) || (DynAbs.Tracing.TraceSender.Expression_False(21009, 25200, 25707) || declaration is MemberDeclarationSyntax) || (DynAbs.Tracing.TraceSender.Expression_False(21009, 25200, 25765) || declaration is NamespaceDeclarationSyntax) || (DynAbs.Tracing.TraceSender.Expression_False(21009, 25200, 25812) || declaration is ParameterSyntax) || (DynAbs.Tracing.TraceSender.Expression_False(21009, 25200, 25861) || declaration is QueryClauseSyntax) || (DynAbs.Tracing.TraceSender.Expression_False(21009, 25200, 25916) || declaration is QueryContinuationSyntax) || (DynAbs.Tracing.TraceSender.Expression_False(21009, 25200, 25965) || declaration is SwitchLabelSyntax) || (DynAbs.Tracing.TraceSender.Expression_False(21009, 25200, 26016) || declaration is TypeParameterSyntax) || (DynAbs.Tracing.TraceSender.Expression_False(21009, 25200, 26068) || declaration is UsingDirectiveSyntax) || (DynAbs.Tracing.TraceSender.Expression_False(21009, 25200, 26124) || declaration is VariableDeclaratorSyntax)))
            )

            {
                DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 25180, 26230);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 26151, 26219);

                throw f_21009_26157_26218("This node type is not supported.");
                DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 25180, 26230);
            }
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 26242, 26313);

            return (Symbol)f_21009_26257_26312(model, declaration, cancellationToken);
            DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 24769, 26320);

            System.NotSupportedException
            f_21009_26157_26218(string
            message)
            {
                var return_v = new System.NotSupportedException(message);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 26157, 26218);
                return return_v;
            }


            Microsoft.CodeAnalysis.ISymbol?
            f_21009_26257_26312(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
            semanticModel, Microsoft.CodeAnalysis.SyntaxNode
            declaration, System.Threading.CancellationToken
            cancellationToken)
            {
                var return_v = semanticModel.GetDeclaredSymbol(declaration, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 26257, 26312);
                return return_v;
            }

        }
        catch
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 24769, 26320);
            throw;
        }
        finally
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 24769, 26320);
        }
        throw new System.Exception("Slicer error: unreachable code");
    }

    public static NamedTypeSymbol BaseType(this TypeSymbol symbol)
    {
        try
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 26328, 26457);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 26407, 26450);

            return f_21009_26414_26449(symbol);
            DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 26328, 26457);

            Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            f_21009_26414_26449(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
            this_param)
            {
                var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 26414, 26449);
                return return_v;
            }

        }
        catch
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 26328, 26457);
            throw;
        }
        finally
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 26328, 26457);
        }
        throw new System.Exception("Slicer error: unreachable code");
    }

    public static ImmutableArray<NamedTypeSymbol> Interfaces(this TypeSymbol symbol)
    {
        try
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 26465, 26616);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 26562, 26609);

            return f_21009_26569_26608(symbol);
            DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 26465, 26616);

            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
            f_21009_26569_26608(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
            this_param)
            {
                var return_v = this_param.InterfacesNoUseSiteDiagnostics();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 26569, 26608);
                return return_v;
            }

        }
        catch
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 26465, 26616);
            throw;
        }
        finally
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 26465, 26616);
        }
        throw new System.Exception("Slicer error: unreachable code");
    }

    public static ImmutableArray<NamedTypeSymbol> AllInterfaces(this TypeSymbol symbol)
    {
        try
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 26624, 26779);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 26724, 26772);

            return f_21009_26731_26771(symbol);
            DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 26624, 26779);

            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
            f_21009_26731_26771(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
            this_param)
            {
                var return_v = this_param.AllInterfacesNoUseSiteDiagnostics;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 26731, 26771);
                return return_v;
            }

        }
        catch
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 26624, 26779);
            throw;
        }
        finally
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 26624, 26779);
        }
        throw new System.Exception("Slicer error: unreachable code");
    }

    public static ImmutableArray<TypeSymbol> TypeArguments(this NamedTypeSymbol symbol)
    {
        try
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 26787, 26980);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 26887, 26973);

            return f_21009_26894_26972(f_21009_26916_26971(symbol));
            DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 26787, 26980);

            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
            f_21009_26916_26971(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            this_param)
            {
                var return_v = this_param.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 26916, 26971);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
            f_21009_26894_26972(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
            typesOpt)
            {
                var return_v = TypeMap.AsTypeSymbols(typesOpt);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 26894, 26972);
                return return_v;
            }

        }
        catch
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 26787, 26980);
            throw;
        }
        finally
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 26787, 26980);
        }
        throw new System.Exception("Slicer error: unreachable code");
    }

    public static ImmutableArray<TypeSymbol> ConstraintTypes(this TypeParameterSymbol symbol)
    {
        try
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 26988, 27174);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 27094, 27167);

            return f_21009_27101_27166(f_21009_27123_27165(symbol));
            DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 26988, 27174);

            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
            f_21009_27123_27165(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
            this_param)
            {
                var return_v = this_param.ConstraintTypesNoUseSiteDiagnostics;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 27123, 27165);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
            f_21009_27101_27166(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
            typesOpt)
            {
                var return_v = TypeMap.AsTypeSymbols(typesOpt);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 27101, 27166);
                return return_v;
            }

        }
        catch
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 26988, 27174);
            throw;
        }
        finally
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 26988, 27174);
        }
        throw new System.Exception("Slicer error: unreachable code");
    }

    public static ImmutableArray<INamedTypeSymbol> AllEffectiveInterfacesNoUseSiteDiagnostics(this ITypeParameterSymbol symbol)
    {
        try
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 27182, 27508);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 27322, 27501);

            return f_21009_27329_27438(((Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.TypeParameterSymbol)symbol)).AllEffectiveInterfacesNoUseSiteDiagnostics.GetPublicSymbols();
            DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 27182, 27508);

            Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
            f_21009_27329_27438(Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.TypeParameterSymbol
            this_param)
            {
                var return_v = this_param.UnderlyingTypeParameterSymbol;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 27329, 27438);
                return return_v;
            }

        }
        catch
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 27182, 27508);
            throw;
        }
        finally
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 27182, 27508);
        }
        throw new System.Exception("Slicer error: unreachable code");
    }

    public static ITypeSymbol GetParameterType(this IMethodSymbol method, int index)
    {
        try
        {
            DynAbs.Tracing.TraceSender.TraceEnterMethod(21009, 27597, 27629);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 27600, 27629);
            return f_21009_27600_27629(f_21009_27600_27617(method)[index]); DynAbs.Tracing.TraceSender.TraceExitMethod(21009, 27597, 27629);
        }
        catch
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 27597, 27629);
            throw;
        }
        finally
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 27597, 27629);
        }
        throw new System.Exception("Slicer error: unreachable code");

        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IParameterSymbol>
        f_21009_27600_27617(Microsoft.CodeAnalysis.IMethodSymbol
        this_param)
        {
            var return_v = this_param.Parameters;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 27600, 27617);
            return return_v;
        }


        Microsoft.CodeAnalysis.ITypeSymbol
        f_21009_27600_27629(Microsoft.CodeAnalysis.IParameterSymbol
        this_param)
        {
            var return_v = this_param.Type;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 27600, 27629);
            return return_v;
        }

    }

    public static bool IsNullableType(this ITypeSymbol typeOpt)
    {
        try
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 27638, 27771);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 27714, 27764);

            return f_21009_27721_27763(typeOpt);
            DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 27638, 27771);

            bool
            f_21009_27721_27763(Microsoft.CodeAnalysis.ITypeSymbol
            typeOpt)
            {
                var return_v = ITypeSymbolHelpers.IsNullableType(typeOpt);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 27721, 27763);
                return return_v;
            }

        }
        catch
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 27638, 27771);
            throw;
        }
        finally
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 27638, 27771);
        }
        throw new System.Exception("Slicer error: unreachable code");
    }

    public static ITypeSymbol GetNullableUnderlyingType(this ITypeSymbol type)
    {
        try
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 27779, 27935);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 27870, 27928);

            return f_21009_27877_27927(type);
            DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 27779, 27935);

            Microsoft.CodeAnalysis.ITypeSymbol
            f_21009_27877_27927(Microsoft.CodeAnalysis.ITypeSymbol
            type)
            {
                var return_v = ITypeSymbolHelpers.GetNullableUnderlyingType(type);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 27877, 27927);
                return return_v;
            }

        }
        catch
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 27779, 27935);
            throw;
        }
        finally
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 27779, 27935);
        }
        throw new System.Exception("Slicer error: unreachable code");
    }

    public static bool IsDynamic(this ITypeSymbol type)
    {
        try
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 27943, 28059);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 28011, 28052);

            return f_21009_28018_28031(type) == TypeKind.Dynamic;
            DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 27943, 28059);

            Microsoft.CodeAnalysis.TypeKind
            f_21009_28018_28031(Microsoft.CodeAnalysis.ITypeSymbol
            this_param)
            {
                var return_v = this_param.TypeKind;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 28018, 28031);
                return return_v;
            }

        }
        catch
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 27943, 28059);
            throw;
        }
        finally
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 27943, 28059);
        }
        throw new System.Exception("Slicer error: unreachable code");
    }

    public static bool IsDelegateType(this ITypeSymbol type)
    {
        try
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 28067, 28189);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 28140, 28182);

            return f_21009_28147_28160(type) == TypeKind.Delegate;
            DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 28067, 28189);

            Microsoft.CodeAnalysis.TypeKind
            f_21009_28147_28160(Microsoft.CodeAnalysis.ITypeSymbol
            this_param)
            {
                var return_v = this_param.TypeKind;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 28147, 28160);
                return return_v;
            }

        }
        catch
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 28067, 28189);
            throw;
        }
        finally
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 28067, 28189);
        }
        throw new System.Exception("Slicer error: unreachable code");
    }

    public static bool IsErrorType(this ITypeSymbol type)
    {
        try
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 28197, 28315);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 28267, 28308);

            return f_21009_28274_28283(type) == SymbolKind.ErrorType;
            DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 28197, 28315);

            Microsoft.CodeAnalysis.SymbolKind
            f_21009_28274_28283(Microsoft.CodeAnalysis.ITypeSymbol
            this_param)
            {
                var return_v = this_param.Kind;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 28274, 28283);
                return return_v;
            }

        }
        catch
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 28197, 28315);
            throw;
        }
        finally
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 28197, 28315);
        }
        throw new System.Exception("Slicer error: unreachable code");
    }

    public static ITypeSymbol StrippedType(this ITypeSymbol type)
    {
        try
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 28323, 28479);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 28401, 28472);

            return (DynAbs.Tracing.TraceSender.Conditional_F1(21009, 28408, 28429) || ((f_21009_28408_28429(type) && DynAbs.Tracing.TraceSender.Conditional_F2(21009, 28432, 28464)) || DynAbs.Tracing.TraceSender.Conditional_F3(21009, 28467, 28471))) ? f_21009_28432_28464(type) : type;
            DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 28323, 28479);

            bool
            f_21009_28408_28429(Microsoft.CodeAnalysis.ITypeSymbol
            typeOpt)
            {
                var return_v = typeOpt.IsNullableType();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 28408, 28429);
                return return_v;
            }


            Microsoft.CodeAnalysis.ITypeSymbol
            f_21009_28432_28464(Microsoft.CodeAnalysis.ITypeSymbol
            type)
            {
                var return_v = type.GetNullableUnderlyingType();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 28432, 28464);
                return return_v;
            }

        }
        catch
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 28323, 28479);
            throw;
        }
        finally
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 28323, 28479);
        }
        throw new System.Exception("Slicer error: unreachable code");
    }

    public static string ToTestDisplayString(this Symbol symbol)
    {
        try
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 28487, 28633);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 28564, 28626);

            return f_21009_28571_28625(symbol, SymbolDisplayFormat.TestFormat);
            DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 28487, 28633);

            string
            f_21009_28571_28625(Microsoft.CodeAnalysis.CSharp.Symbol
            this_param, Microsoft.CodeAnalysis.SymbolDisplayFormat
            format)
            {
                var return_v = this_param.ToDisplayString(format);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 28571, 28625);
                return return_v;
            }

        }
        catch
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 28487, 28633);
            throw;
        }
        finally
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 28487, 28633);
        }
        throw new System.Exception("Slicer error: unreachable code");
    }

    public static ISymbol GetSpecialTypeMember(this Compilation compilation, SpecialMember specialMember)
    {
        try
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 28641, 28860);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 28759, 28853);

            return f_21009_28766_28852(f_21009_28766_28834(((CSharpCompilation)compilation), specialMember));
            DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 28641, 28860);

            Microsoft.CodeAnalysis.CSharp.Symbol
            f_21009_28766_28834(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
            this_param, Microsoft.CodeAnalysis.SpecialMember
            specialMember)
            {
                var return_v = this_param.GetSpecialTypeMember(specialMember);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 28766, 28834);
                return return_v;
            }


            Microsoft.CodeAnalysis.ISymbol?
            f_21009_28766_28852(Microsoft.CodeAnalysis.CSharp.Symbol
            symbol)
            {
                var return_v = symbol.GetPublicSymbol();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 28766, 28852);
                return return_v;
            }

        }
        catch
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 28641, 28860);
            throw;
        }
        finally
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 28641, 28860);
        }
        throw new System.Exception("Slicer error: unreachable code");
    }

    public static INamedTypeSymbol GetWellKnownType(this Compilation compilation, WellKnownType type)
    {
        try
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 28868, 29070);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 28982, 29063);

            return f_21009_28989_29062(f_21009_28989_29044(((CSharpCompilation)compilation), type));
            DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 28868, 29070);

            Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            f_21009_28989_29044(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
            this_param, Microsoft.CodeAnalysis.WellKnownType
            type)
            {
                var return_v = this_param.GetWellKnownType(type);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 28989, 29044);
                return return_v;
            }


            Microsoft.CodeAnalysis.INamedTypeSymbol?
            f_21009_28989_29062(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            symbol)
            {
                var return_v = symbol.GetPublicSymbol();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 28989, 29062);
                return return_v;
            }

        }
        catch
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 28868, 29070);
            throw;
        }
        finally
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 28868, 29070);
        }
        throw new System.Exception("Slicer error: unreachable code");
    }

    public static NamedTypeSymbol Modifier(this CustomModifier m)
    {
        try
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 29078, 29211);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 29156, 29204);

            return f_21009_29163_29203(((CSharpCustomModifier)m));
            DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 29078, 29211);

            Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            f_21009_29163_29203(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpCustomModifier
            this_param)
            {
                var return_v = this_param.ModifierSymbol;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 29163, 29203);
                return return_v;
            }

        }
        catch
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 29078, 29211);
            throw;
        }
        finally
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 29078, 29211);
        }
        throw new System.Exception("Slicer error: unreachable code");
    }

    public static ImmutableArray<IParameterSymbol> GetParameters(this ISymbol member)
    {
        try
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 29219, 29758);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 29317, 29751);

            switch (f_21009_29325_29336(member))
            {

                case SymbolKind.Method:
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 29317, 29751);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 29403, 29445);

                    return f_21009_29410_29444(((IMethodSymbol)member));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 29317, 29751);

                case SymbolKind.Property:
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 29317, 29751);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 29502, 29546);

                    return f_21009_29509_29545(((IPropertySymbol)member));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 29317, 29751);

                case SymbolKind.Event:
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 29317, 29751);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 29600, 29646);

                    return ImmutableArray<IParameterSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 29317, 29751);

                default:
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 29317, 29751);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 29686, 29740);

                    throw f_21009_29692_29739(f_21009_29727_29738(member));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 29317, 29751);
            }
            DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 29219, 29758);

            Microsoft.CodeAnalysis.SymbolKind
            f_21009_29325_29336(Microsoft.CodeAnalysis.ISymbol
            this_param)
            {
                var return_v = this_param.Kind;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 29325, 29336);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IParameterSymbol>
            f_21009_29410_29444(Microsoft.CodeAnalysis.IMethodSymbol
            this_param)
            {
                var return_v = this_param.Parameters;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 29410, 29444);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IParameterSymbol>
            f_21009_29509_29545(Microsoft.CodeAnalysis.IPropertySymbol
            this_param)
            {
                var return_v = this_param.Parameters;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 29509, 29545);
                return return_v;
            }


            Microsoft.CodeAnalysis.SymbolKind
            f_21009_29727_29738(Microsoft.CodeAnalysis.ISymbol
            this_param)
            {
                var return_v = this_param.Kind;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 29727, 29738);
                return return_v;
            }


            System.Exception
            f_21009_29692_29739(Microsoft.CodeAnalysis.SymbolKind
            o)
            {
                var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 29692, 29739);
                return return_v;
            }

        }
        catch
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 29219, 29758);
            throw;
        }
        finally
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 29219, 29758);
        }
        throw new System.Exception("Slicer error: unreachable code");
    }

    public static bool IsUnboundGenericType(this ITypeSymbol type)
    {
        try
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 29766, 29928);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 29845, 29921);

            return type is INamedTypeSymbol namedType && (DynAbs.Tracing.TraceSender.Expression_True(21009, 29852, 29920) && f_21009_29890_29920(namedType));
            DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 29766, 29928);

            bool
            f_21009_29890_29920(Microsoft.CodeAnalysis.INamedTypeSymbol
            this_param)
            {
                var return_v = this_param.IsUnboundGenericType;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 29890, 29920);
                return return_v;
            }

        }
        catch
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 29766, 29928);
            throw;
        }
        finally
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 29766, 29928);
        }
        throw new System.Exception("Slicer error: unreachable code");
    }

    public static bool GivesAccessTo(this AssemblySymbol first, AssemblySymbol second)
    {
        try
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 29936, 30113);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 30035, 30106);

            return f_21009_30042_30105(f_21009_30042_30065(first), f_21009_30080_30104(second));
            DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 29936, 30113);

            Microsoft.CodeAnalysis.IAssemblySymbol?
            f_21009_30042_30065(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
            symbol)
            {
                var return_v = symbol.GetPublicSymbol();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 30042, 30065);
                return return_v;
            }


            Microsoft.CodeAnalysis.IAssemblySymbol?
            f_21009_30080_30104(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
            symbol)
            {
                var return_v = symbol.GetPublicSymbol();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 30080, 30104);
                return return_v;
            }


            bool
            f_21009_30042_30105(Microsoft.CodeAnalysis.IAssemblySymbol
            this_param, Microsoft.CodeAnalysis.IAssemblySymbol
            toAssembly)
            {
                var return_v = this_param.GivesAccessTo(toAssembly);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 30042, 30105);
                return return_v;
            }

        }
        catch
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 29936, 30113);
            throw;
        }
        finally
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 29936, 30113);
        }
        throw new System.Exception("Slicer error: unreachable code");
    }

    public static INamedTypeSymbol CreateTupleTypeSymbol(
            this CSharpCompilation comp,
            NamedTypeSymbol underlyingType,
            ImmutableArray<string> elementNames = default,
            ImmutableArray<Location> elementLocations = default)
    {
        try
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 30121, 30495);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 30388, 30488);

            return f_21009_30395_30487(comp, f_21009_30422_30454(underlyingType), elementNames, elementLocations);
            DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 30121, 30495);

            Microsoft.CodeAnalysis.INamedTypeSymbol?
            f_21009_30422_30454(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            symbol)
            {
                var return_v = symbol.GetPublicSymbol();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 30422, 30454);
                return return_v;
            }


            Microsoft.CodeAnalysis.INamedTypeSymbol
            f_21009_30395_30487(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
            this_param, Microsoft.CodeAnalysis.INamedTypeSymbol
            underlyingType, System.Collections.Immutable.ImmutableArray<string>
            elementNames, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
            elementLocations)
            {
                var return_v = this_param.CreateTupleTypeSymbol(underlyingType, elementNames, elementLocations);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 30395, 30487);
                return return_v;
            }

        }
        catch
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 30121, 30495);
            throw;
        }
        finally
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 30121, 30495);
        }
        throw new System.Exception("Slicer error: unreachable code");
    }

    public static INamedTypeSymbol CreateTupleTypeSymbol(
            this CSharpCompilation comp,
            ImmutableArray<TypeSymbol> elementTypes,
            ImmutableArray<string> elementNames = default,
            ImmutableArray<Location> elementLocations = default,
            ImmutableArray<Microsoft.CodeAnalysis.NullableAnnotation> elementNullableAnnotations = default)
    {
        try
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 30503, 31018);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 30884, 31011);

            return f_21009_30891_31010(comp, elementTypes.GetPublicSymbols(), elementNames, elementLocations, elementNullableAnnotations);
            DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 30503, 31018);

            Microsoft.CodeAnalysis.INamedTypeSymbol
            f_21009_30891_31010(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
            this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ITypeSymbol>
            elementTypes, System.Collections.Immutable.ImmutableArray<string>
            elementNames, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
            elementLocations, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.NullableAnnotation>
            elementNullableAnnotations)
            {
                var return_v = this_param.CreateTupleTypeSymbol(elementTypes, elementNames, elementLocations, elementNullableAnnotations);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 30891, 31010);
                return return_v;
            }

        }
        catch
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 30503, 31018);
            throw;
        }
        finally
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 30503, 31018);
        }
        throw new System.Exception("Slicer error: unreachable code");
    }

    public static INamedTypeSymbol Construct(this INamedTypeSymbol definition, params TypeSymbol[] typeArguments)
    {
        try
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 31026, 31245);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 31152, 31238);

            return f_21009_31159_31237(definition, f_21009_31180_31236(f_21009_31180_31226(typeArguments, s => s.GetPublicSymbol())));
            DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 31026, 31245);

            System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ITypeSymbol>
            f_21009_31180_31226(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
            source, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol, Microsoft.CodeAnalysis.ITypeSymbol>
            selector)
            {
                var return_v = source.Select<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol, Microsoft.CodeAnalysis.ITypeSymbol>(selector);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 31180, 31226);
                return return_v;
            }


            Microsoft.CodeAnalysis.ITypeSymbol[]
            f_21009_31180_31236(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ITypeSymbol>
            source)
            {
                var return_v = source.ToArray<Microsoft.CodeAnalysis.ITypeSymbol>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 31180, 31236);
                return return_v;
            }


            Microsoft.CodeAnalysis.INamedTypeSymbol
            f_21009_31159_31237(Microsoft.CodeAnalysis.INamedTypeSymbol
            this_param, params Microsoft.CodeAnalysis.ITypeSymbol[]
            typeArguments)
            {
                var return_v = this_param.Construct(typeArguments);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 31159, 31237);
                return return_v;
            }

        }
        catch
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 31026, 31245);
            throw;
        }
        finally
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 31026, 31245);
        }
        throw new System.Exception("Slicer error: unreachable code");
    }

    public static INamespaceSymbol CreateErrorNamespaceSymbol(this CSharpCompilation comp, NamespaceSymbol container, string name)
    {
        try
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 31253, 31477);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 31396, 31470);

            return f_21009_31403_31469(comp, f_21009_31435_31462(container), name);
            DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 31253, 31477);

            Microsoft.CodeAnalysis.INamespaceSymbol?
            f_21009_31435_31462(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
            symbol)
            {
                var return_v = symbol.GetPublicSymbol();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 31435, 31462);
                return return_v;
            }


            Microsoft.CodeAnalysis.INamespaceSymbol
            f_21009_31403_31469(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
            this_param, Microsoft.CodeAnalysis.INamespaceSymbol
            container, string
            name)
            {
                var return_v = this_param.CreateErrorNamespaceSymbol(container, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 31403, 31469);
                return return_v;
            }

        }
        catch
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 31253, 31477);
            throw;
        }
        finally
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 31253, 31477);
        }
        throw new System.Exception("Slicer error: unreachable code");
    }

    public static bool Equals(this ITypeSymbol first, ITypeSymbol second, TypeCompareKind typeCompareKind)
    {
        try
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 31485, 31707);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 31604, 31700);

            return f_21009_31611_31699(first, second, f_21009_31632_31698(typeCompareKind));
            DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 31485, 31707);

            Microsoft.CodeAnalysis.SymbolEqualityComparer
            f_21009_31632_31698(Microsoft.CodeAnalysis.TypeCompareKind
            compareKind)
            {
                var return_v = new Microsoft.CodeAnalysis.SymbolEqualityComparer(compareKind);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 31632, 31698);
                return return_v;
            }


            bool
            f_21009_31611_31699(Microsoft.CodeAnalysis.ITypeSymbol
            this_param, Microsoft.CodeAnalysis.ITypeSymbol
            other, Microsoft.CodeAnalysis.SymbolEqualityComparer
            equalityComparer)
            {
                var return_v = this_param.Equals((Microsoft.CodeAnalysis.ISymbol)other, equalityComparer);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 31611, 31699);
                return return_v;
            }

        }
        catch
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 31485, 31707);
            throw;
        }
        finally
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 31485, 31707);
        }
        throw new System.Exception("Slicer error: unreachable code");
    }

    public static ITypeSymbol GetTypeOrReturnType(this ISymbol symbol)
    {
        try
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 31715, 32582);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 31798, 32575);

            switch (f_21009_31806_31817(symbol))
            {

                case SymbolKind.Field:
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 31798, 32575);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 31883, 31918);

                    return f_21009_31890_31917(((IFieldSymbol)symbol));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 31798, 32575);

                case SymbolKind.Method:
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 31798, 32575);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 31973, 32015);

                    return f_21009_31980_32014(((IMethodSymbol)symbol));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 31798, 32575);

                case SymbolKind.Property:
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 31798, 32575);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 32072, 32110);

                    return f_21009_32079_32109(((IPropertySymbol)symbol));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 31798, 32575);

                case SymbolKind.Event:
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 31798, 32575);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 32164, 32199);

                    return f_21009_32171_32198(((IEventSymbol)symbol));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 31798, 32575);

                case SymbolKind.Local:
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 31798, 32575);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 32253, 32288);

                    return f_21009_32260_32287(((ILocalSymbol)symbol));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 31798, 32575);

                case SymbolKind.Parameter:
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 31798, 32575);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 32346, 32385);

                    return f_21009_32353_32384(((IParameterSymbol)symbol));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 31798, 32575);

                case SymbolKind.ErrorType:
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 31798, 32575);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 32443, 32470);

                    return (ITypeSymbol)symbol;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 31798, 32575);

                default:
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 31798, 32575);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 32510, 32564);

                    throw f_21009_32516_32563(f_21009_32551_32562(symbol));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 31798, 32575);
            }
            DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 31715, 32582);

            Microsoft.CodeAnalysis.SymbolKind
            f_21009_31806_31817(Microsoft.CodeAnalysis.ISymbol
            this_param)
            {
                var return_v = this_param.Kind;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 31806, 31817);
                return return_v;
            }


            Microsoft.CodeAnalysis.ITypeSymbol
            f_21009_31890_31917(Microsoft.CodeAnalysis.IFieldSymbol
            this_param)
            {
                var return_v = this_param.Type;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 31890, 31917);
                return return_v;
            }


            Microsoft.CodeAnalysis.ITypeSymbol
            f_21009_31980_32014(Microsoft.CodeAnalysis.IMethodSymbol
            this_param)
            {
                var return_v = this_param.ReturnType;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 31980, 32014);
                return return_v;
            }


            Microsoft.CodeAnalysis.ITypeSymbol
            f_21009_32079_32109(Microsoft.CodeAnalysis.IPropertySymbol
            this_param)
            {
                var return_v = this_param.Type;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 32079, 32109);
                return return_v;
            }


            Microsoft.CodeAnalysis.ITypeSymbol
            f_21009_32171_32198(Microsoft.CodeAnalysis.IEventSymbol
            this_param)
            {
                var return_v = this_param.Type;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 32171, 32198);
                return return_v;
            }


            Microsoft.CodeAnalysis.ITypeSymbol
            f_21009_32260_32287(Microsoft.CodeAnalysis.ILocalSymbol
            this_param)
            {
                var return_v = this_param.Type;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 32260, 32287);
                return return_v;
            }


            Microsoft.CodeAnalysis.ITypeSymbol
            f_21009_32353_32384(Microsoft.CodeAnalysis.IParameterSymbol
            this_param)
            {
                var return_v = this_param.Type;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 32353, 32384);
                return return_v;
            }


            Microsoft.CodeAnalysis.SymbolKind
            f_21009_32551_32562(Microsoft.CodeAnalysis.ISymbol
            this_param)
            {
                var return_v = this_param.Kind;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 32551, 32562);
                return return_v;
            }


            System.Exception
            f_21009_32516_32563(Microsoft.CodeAnalysis.SymbolKind
            o)
            {
                var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 32516, 32563);
                return return_v;
            }

        }
        catch
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 31715, 32582);
            throw;
        }
        finally
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 31715, 32582);
        }
        throw new System.Exception("Slicer error: unreachable code");
    }

    public static ITypeSymbol EnumUnderlyingTypeOrSelf(this ITypeSymbol type)
    {
        try
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 32590, 32778);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 32680, 32771);

            return (DynAbs.Tracing.TraceSender.Conditional_F1(21009, 32687, 32717) || ((f_21009_32687_32700(type) == TypeKind.Enum && DynAbs.Tracing.TraceSender.Conditional_F2(21009, 32720, 32763)) || DynAbs.Tracing.TraceSender.Conditional_F3(21009, 32766, 32770))) ? f_21009_32720_32763(((INamedTypeSymbol)type)) : type;
            DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 32590, 32778);

            Microsoft.CodeAnalysis.TypeKind
            f_21009_32687_32700(Microsoft.CodeAnalysis.ITypeSymbol
            this_param)
            {
                var return_v = this_param.TypeKind;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 32687, 32700);
                return return_v;
            }


            Microsoft.CodeAnalysis.INamedTypeSymbol?
            f_21009_32720_32763(Microsoft.CodeAnalysis.INamedTypeSymbol
            this_param)
            {
                var return_v = this_param.EnumUnderlyingType;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 32720, 32763);
                return return_v;
            }

        }
        catch
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 32590, 32778);
            throw;
        }
        finally
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 32590, 32778);
        }
        throw new System.Exception("Slicer error: unreachable code");
    }

    public static INamedTypeSymbol GetEnumUnderlyingType(this ITypeSymbol type)
    {
        try
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 32786, 33009);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 32878, 32919);

            var
            namedType = type as INamedTypeSymbol
            ;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 32929, 33002);

            return (DynAbs.Tracing.TraceSender.Conditional_F1(21009, 32936, 32963) || ((((object)namedType != null) && DynAbs.Tracing.TraceSender.Conditional_F2(21009, 32966, 32994)) || DynAbs.Tracing.TraceSender.Conditional_F3(21009, 32997, 33001))) ? f_21009_32966_32994(namedType) : null;
            DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 32786, 33009);

            Microsoft.CodeAnalysis.INamedTypeSymbol?
            f_21009_32966_32994(Microsoft.CodeAnalysis.INamedTypeSymbol
            this_param)
            {
                var return_v = this_param.EnumUnderlyingType;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 32966, 32994);
                return return_v;
            }

        }
        catch
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 32786, 33009);
            throw;
        }
        finally
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 32786, 33009);
        }
        throw new System.Exception("Slicer error: unreachable code");
    }

    public static ISymbol ConstructedFrom(this ISymbol symbol)
    {
        try
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 33017, 33449);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 33092, 33442);

            switch (f_21009_33100_33111(symbol))
            {

                case SymbolKind.NamedType:
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 33092, 33442);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 33181, 33231);

                    return f_21009_33188_33230(((INamedTypeSymbol)symbol));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 33092, 33442);

                case SymbolKind.Method:
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 33092, 33442);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 33288, 33335);

                    return f_21009_33295_33334(((IMethodSymbol)symbol));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 33092, 33442);

                default:
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 33092, 33442);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 33377, 33431);

                    throw f_21009_33383_33430(f_21009_33418_33429(symbol));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 33092, 33442);
            }
            DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 33017, 33449);

            Microsoft.CodeAnalysis.SymbolKind
            f_21009_33100_33111(Microsoft.CodeAnalysis.ISymbol
            this_param)
            {
                var return_v = this_param.Kind;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 33100, 33111);
                return return_v;
            }


            Microsoft.CodeAnalysis.INamedTypeSymbol
            f_21009_33188_33230(Microsoft.CodeAnalysis.INamedTypeSymbol
            this_param)
            {
                var return_v = this_param.ConstructedFrom;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 33188, 33230);
                return return_v;
            }


            Microsoft.CodeAnalysis.IMethodSymbol
            f_21009_33295_33334(Microsoft.CodeAnalysis.IMethodSymbol
            this_param)
            {
                var return_v = this_param.ConstructedFrom;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 33295, 33334);
                return return_v;
            }


            Microsoft.CodeAnalysis.SymbolKind
            f_21009_33418_33429(Microsoft.CodeAnalysis.ISymbol
            this_param)
            {
                var return_v = this_param.Kind;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 33418, 33429);
                return return_v;
            }


            System.Exception
            f_21009_33383_33430(Microsoft.CodeAnalysis.SymbolKind
            o)
            {
                var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 33383, 33430);
                return return_v;
            }

        }
        catch
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 33017, 33449);
            throw;
        }
        finally
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 33017, 33449);
        }
        throw new System.Exception("Slicer error: unreachable code");
    }

    public static INamespaceSymbol GetNestedNamespace(this INamespaceSymbol ns, string name)
    {
        try
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 33457, 33783);
            try
            {
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 33562, 33752);
                foreach (var sym in f_21009_33582_33601_I(f_21009_33582_33601(ns, name)))
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 33562, 33752);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 33627, 33741) || true) && (f_21009_33631_33639(sym) == SymbolKind.Namespace)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21009, 33627, 33741);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 33697, 33726);

                        return (INamespaceSymbol)sym;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 33627, 33741);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21009, 33562, 33752);
                }
            }
            catch (System.Exception)
            {
                DynAbs.Tracing.TraceSender.TraceExitLoopByException(21009, 1, 191);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceExitLoop(21009, 1, 191);
            }
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 33764, 33776);

            return null;
            DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 33457, 33783);

            System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol>
            f_21009_33582_33601(Microsoft.CodeAnalysis.INamespaceSymbol
            this_param, string
            name)
            {
                var return_v = this_param.GetMembers(name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 33582, 33601);
                return return_v;
            }


            Microsoft.CodeAnalysis.SymbolKind
            f_21009_33631_33639(Microsoft.CodeAnalysis.INamespaceOrTypeSymbol
            this_param)
            {
                var return_v = this_param.Kind;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21009, 33631, 33639);
                return return_v;
            }


            System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol>
            f_21009_33582_33601_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol>
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceEndInvocation(21009, 33582, 33601);
                return return_v;
            }

        }
        catch
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 33457, 33783);
            throw;
        }
        finally
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 33457, 33783);
        }
        throw new System.Exception("Slicer error: unreachable code");
    }

    public static IEnumerable<Microsoft.CodeAnalysis.NullableAnnotation> TypeArgumentNullableAnnotations(this INamedTypeSymbol type)
    {
        try
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 33791, 34003);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 33936, 33996);

            return type.TypeArguments.Select(t => t.NullableAnnotation);
            DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 33791, 34003);
        }
        catch
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 33791, 34003);
            throw;
        }
        finally
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 33791, 34003);
        }
        throw new System.Exception("Slicer error: unreachable code");
    }

    public static IEnumerable<Microsoft.CodeAnalysis.NullableAnnotation> TypeArgumentNullableAnnotations(this IMethodSymbol method)
    {
        try
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21009, 34011, 34224);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21009, 34155, 34217);

            return method.TypeArguments.Select(t => t.NullableAnnotation);
            DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21009, 34011, 34224);
        }
        catch
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21009, 34011, 34224);
            throw;
        }
        finally
        {
            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 34011, 34224);
        }
        throw new System.Exception("Slicer error: unreachable code");
    }

    static Extensions()
    {
        DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(21009, 24376, 34227);
        DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(21009, 24376, 34227);

        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21009, 24376, 34227);
    }

}
