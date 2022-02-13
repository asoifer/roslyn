// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class MergedNamespaceDeclaration : MergedNamespaceOrTypeDeclaration
    {
        private readonly ImmutableArray<SingleNamespaceDeclaration> _declarations;

        private ImmutableArray<MergedNamespaceOrTypeDeclaration> _lazyChildren;

        private MergedNamespaceDeclaration(ImmutableArray<SingleNamespaceDeclaration> declarations)
        : base(f_10393_923_981_C((DynAbs.Tracing.TraceSender.Conditional_F1(10393, 923, 943) || ((declarations.IsEmpty && DynAbs.Tracing.TraceSender.Conditional_F2(10393, 946, 958)) || DynAbs.Tracing.TraceSender.Conditional_F3(10393, 961, 981))) ? string.Empty : f_10393_961_981(declarations[0])))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10393, 811, 1047);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10393, 1007, 1036);

                _declarations = declarations;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10393, 811, 1047);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10393, 811, 1047);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10393, 811, 1047);
            }
        }

        public static MergedNamespaceDeclaration Create(ImmutableArray<SingleNamespaceDeclaration> declarations)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10393, 1059, 1251);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10393, 1188, 1240);

                return f_10393_1195_1239(declarations);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10393, 1059, 1251);

                Microsoft.CodeAnalysis.CSharp.MergedNamespaceDeclaration
                f_10393_1195_1239(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration>
                declarations)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MergedNamespaceDeclaration(declarations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10393, 1195, 1239);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10393, 1059, 1251);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10393, 1059, 1251);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static MergedNamespaceDeclaration Create(SingleNamespaceDeclaration declaration)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10393, 1263, 1460);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10393, 1375, 1449);

                return f_10393_1382_1448(f_10393_1413_1447(declaration));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10393, 1263, 1460);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration>
                f_10393_1413_1447(Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10393, 1413, 1447);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MergedNamespaceDeclaration
                f_10393_1382_1448(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration>
                declarations)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MergedNamespaceDeclaration(declarations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10393, 1382, 1448);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10393, 1263, 1460);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10393, 1263, 1460);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override DeclarationKind Kind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10393, 1533, 1617);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10393, 1569, 1602);

                    return DeclarationKind.Namespace;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10393, 1533, 1617);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10393, 1472, 1628);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10393, 1472, 1628);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public LexicalSortKey GetLexicalSortKey(CSharpCompilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10393, 1640, 2077);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10393, 1735, 1823);

                LexicalSortKey
                sortKey = f_10393_1760_1822(f_10393_1779_1808(_declarations[0]), compilation)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10393, 1846, 1851);
                    for (var
        i = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10393, 1837, 2035) || true) && (i < _declarations.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10393, 1879, 1882)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10393, 1837, 2035))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10393, 1837, 2035);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10393, 1916, 2020);

                        sortKey = LexicalSortKey.First(sortKey, f_10393_1956_2018(f_10393_1975_2004(_declarations[i]), compilation));
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10393, 1, 199);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10393, 1, 199);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10393, 2051, 2066);

                return sortKey;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10393, 1640, 2077);

                Microsoft.CodeAnalysis.SourceLocation
                f_10393_1779_1808(Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration
                this_param)
                {
                    var return_v = this_param.NameLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10393, 1779, 1808);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LexicalSortKey
                f_10393_1760_1822(Microsoft.CodeAnalysis.SourceLocation
                location, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.LexicalSortKey((Microsoft.CodeAnalysis.Location)location, compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10393, 1760, 1822);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceLocation
                f_10393_1975_2004(Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration
                this_param)
                {
                    var return_v = this_param.NameLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10393, 1975, 2004);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LexicalSortKey
                f_10393_1956_2018(Microsoft.CodeAnalysis.SourceLocation
                location, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.LexicalSortKey((Microsoft.CodeAnalysis.Location)location, compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10393, 1956, 2018);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10393, 1640, 2077);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10393, 1640, 2077);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ImmutableArray<Location> NameLocations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10393, 2159, 2818);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10393, 2195, 2803) || true) && (_declarations.Length == 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10393, 2195, 2803);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10393, 2266, 2336);

                        return f_10393_2273_2335(f_10393_2305_2334(_declarations[0]));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10393, 2195, 2803);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10393, 2195, 2803);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10393, 2418, 2469);

                        var
                        builder = f_10393_2432_2468()
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10393, 2491, 2726);
                            foreach (var decl in f_10393_2512_2525_I(_declarations))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10393, 2491, 2726);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10393, 2575, 2614);

                                SourceLocation
                                loc = f_10393_2596_2613(decl)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10393, 2640, 2703) || true) && (loc != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10393, 2640, 2703);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10393, 2686, 2703);

                                    f_10393_2686_2702(builder, loc);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10393, 2640, 2703);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10393, 2491, 2726);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10393, 1, 236);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10393, 1, 236);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10393, 2748, 2784);

                        return f_10393_2755_2783(builder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10393, 2195, 2803);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10393, 2159, 2818);

                    Microsoft.CodeAnalysis.SourceLocation
                    f_10393_2305_2334(Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration
                    this_param)
                    {
                        var return_v = this_param.NameLocation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10393, 2305, 2334);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                    f_10393_2273_2335(Microsoft.CodeAnalysis.SourceLocation
                    item)
                    {
                        var return_v = ImmutableArray.Create<Location>((Microsoft.CodeAnalysis.Location)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10393, 2273, 2335);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Location>
                    f_10393_2432_2468()
                    {
                        var return_v = ArrayBuilder<Location>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10393, 2432, 2468);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SourceLocation
                    f_10393_2596_2613(Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration
                    this_param)
                    {
                        var return_v = this_param.NameLocation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10393, 2596, 2613);
                        return return_v;
                    }


                    int
                    f_10393_2686_2702(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Location>
                    this_param, Microsoft.CodeAnalysis.SourceLocation
                    item)
                    {
                        this_param.Add((Microsoft.CodeAnalysis.Location)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10393, 2686, 2702);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration>
                    f_10393_2512_2525_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10393, 2512, 2525);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                    f_10393_2755_2783(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Location>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10393, 2755, 2783);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10393, 2089, 2829);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10393, 2089, 2829);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ImmutableArray<SingleNamespaceDeclaration> Declarations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10393, 2928, 2957);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10393, 2934, 2955);

                    return _declarations;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10393, 2928, 2957);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10393, 2841, 2968);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10393, 2841, 2968);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override ImmutableArray<Declaration> GetDeclarationChildren()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10393, 2980, 3138);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10393, 3076, 3127);

                return f_10393_3083_3126(f_10393_3112_3125(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10393, 2980, 3138);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.MergedNamespaceOrTypeDeclaration>
                f_10393_3112_3125(Microsoft.CodeAnalysis.CSharp.MergedNamespaceDeclaration
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10393, 3112, 3125);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Declaration>
                f_10393_3083_3126(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.MergedNamespaceOrTypeDeclaration>
                from)
                {
                    var return_v = StaticCast<Declaration>.From(from);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10393, 3083, 3126);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10393, 2980, 3138);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10393, 2980, 3138);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<MergedNamespaceOrTypeDeclaration> MakeChildren()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10393, 3150, 6767);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10393, 3246, 3305);

                ArrayBuilder<SingleNamespaceDeclaration>
                namespaces = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10393, 3319, 3368);

                ArrayBuilder<SingleTypeDeclaration>
                types = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10393, 3382, 3420);

                bool
                allNamespacesHaveSameName = true
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10393, 3434, 3471);

                bool
                allTypesHaveSameIdentity = true
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10393, 3487, 5326);
                    foreach (var decl in f_10393_3508_3521_I(_declarations))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10393, 3487, 5326);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10393, 3555, 5311);
                            foreach (var child in f_10393_3577_3590_I(f_10393_3577_3590(decl)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10393, 3555, 5311);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10393, 3690, 3734);

                                var
                                asType = child as SingleTypeDeclaration
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10393, 3756, 4352) || true) && (asType != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10393, 3756, 4352);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10393, 3865, 4248) || true) && (types == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10393, 3865, 4248);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10393, 3940, 3998);

                                        types = f_10393_3948_3997();
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10393, 3865, 4248);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10393, 3865, 4248);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10393, 4056, 4248) || true) && (allTypesHaveSameIdentity && (DynAbs.Tracing.TraceSender.Expression_True(10393, 4060, 4130) && !asType.Identity.Equals(f_10393_4112_4129(f_10393_4112_4120(types, 0)))))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10393, 4056, 4248);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10393, 4188, 4221);

                                            allTypesHaveSameIdentity = false;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10393, 4056, 4248);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10393, 3865, 4248);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10393, 4276, 4294);

                                    f_10393_4276_4293(
                                                            types, asType);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10393, 4320, 4329);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10393, 3756, 4352);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10393, 4421, 4475);

                                var
                                asNamespace = child as SingleNamespaceDeclaration
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10393, 4497, 5131) || true) && (asNamespace != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10393, 4497, 5131);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10393, 4615, 5017) || true) && (namespaces == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10393, 4615, 5017);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10393, 4695, 4763);

                                        namespaces = f_10393_4708_4762();
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10393, 4615, 5017);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10393, 4615, 5017);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10393, 4821, 5017) || true) && (allNamespacesHaveSameName && (DynAbs.Tracing.TraceSender.Expression_True(10393, 4825, 4898) && !f_10393_4855_4898(f_10393_4855_4871(asNamespace), f_10393_4879_4897(f_10393_4879_4892(namespaces, 0)))))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10393, 4821, 5017);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10393, 4956, 4990);

                                            allNamespacesHaveSameName = false;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10393, 4821, 5017);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10393, 4615, 5017);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10393, 5045, 5073);

                                    f_10393_5045_5072(
                                                            namespaces, asNamespace);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10393, 5099, 5108);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10393, 4497, 5131);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10393, 3555, 5311);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10393, 1, 1757);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10393, 1, 1757);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10393, 3487, 5326);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10393, 1, 1840);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10393, 1, 1840);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10393, 5342, 5418);

                var
                children = f_10393_5357_5417()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10393, 5434, 6103) || true) && (namespaces != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10393, 5434, 6103);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10393, 5490, 6088) || true) && (allNamespacesHaveSameName)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10393, 5490, 6088);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10393, 5561, 5642);

                        f_10393_5561_5641(children, f_10393_5574_5640(f_10393_5608_5639(namespaces)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10393, 5490, 6088);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10393, 5490, 6088);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10393, 5724, 5815);

                        var
                        namespaceGroups = f_10393_5746_5814(namespaces, n => n.Name, StringOrdinalComparer.Instance)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10393, 5837, 5855);

                        f_10393_5837_5854(namespaces);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10393, 5879, 6069);
                            foreach (var namespaceGroup in f_10393_5910_5932_I(f_10393_5910_5932(namespaceGroups)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10393, 5879, 6069);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10393, 5982, 6046);

                                f_10393_5982_6045(children, f_10393_5995_6044(namespaceGroup));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10393, 5879, 6069);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10393, 1, 191);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10393, 1, 191);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10393, 5490, 6088);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10393, 5434, 6103);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10393, 6119, 6703) || true) && (types != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10393, 6119, 6703);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10393, 6170, 6688) || true) && (allTypesHaveSameIdentity)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10393, 6170, 6688);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10393, 6240, 6308);

                        f_10393_6240_6307(children, f_10393_6253_6306(f_10393_6279_6305(types)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10393, 6170, 6688);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10393, 6170, 6688);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10393, 6390, 6443);

                        var
                        typeGroups = f_10393_6407_6442(types, t => t.Identity)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10393, 6465, 6478);

                        f_10393_6465_6477(types);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10393, 6502, 6669);
                            foreach (var typeGroup in f_10393_6528_6545_I(f_10393_6528_6545(typeGroups)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10393, 6502, 6669);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10393, 6595, 6646);

                                f_10393_6595_6645(children, f_10393_6608_6644(typeGroup));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10393, 6502, 6669);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10393, 1, 168);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10393, 1, 168);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10393, 6170, 6688);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10393, 6119, 6703);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10393, 6719, 6756);

                return f_10393_6726_6755(children);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10393, 3150, 6767);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleNamespaceOrTypeDeclaration>
                f_10393_3577_3590(Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10393, 3577, 3590);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                f_10393_3948_3997()
                {
                    var return_v = ArrayBuilder<SingleTypeDeclaration>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10393, 3948, 3997);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration
                f_10393_4112_4120(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10393, 4112, 4120);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration.TypeDeclarationIdentity
                f_10393_4112_4129(Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration
                this_param)
                {
                    var return_v = this_param.Identity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10393, 4112, 4129);
                    return return_v;
                }


                int
                f_10393_4276_4293(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                this_param, Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10393, 4276, 4293);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration>
                f_10393_4708_4762()
                {
                    var return_v = ArrayBuilder<SingleNamespaceDeclaration>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10393, 4708, 4762);
                    return return_v;
                }


                string
                f_10393_4855_4871(Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10393, 4855, 4871);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration
                f_10393_4879_4892(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10393, 4879, 4892);
                    return return_v;
                }


                string
                f_10393_4879_4897(Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10393, 4879, 4897);
                    return return_v;
                }


                bool
                f_10393_4855_4898(string
                this_param, string
                value)
                {
                    var return_v = this_param.Equals(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10393, 4855, 4898);
                    return return_v;
                }


                int
                f_10393_5045_5072(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration>
                this_param, Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10393, 5045, 5072);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleNamespaceOrTypeDeclaration>
                f_10393_3577_3590_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleNamespaceOrTypeDeclaration>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10393, 3577, 3590);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration>
                f_10393_3508_3521_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10393, 3508, 3521);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MergedNamespaceOrTypeDeclaration>
                f_10393_5357_5417()
                {
                    var return_v = ArrayBuilder<MergedNamespaceOrTypeDeclaration>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10393, 5357, 5417);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration>
                f_10393_5608_5639(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10393, 5608, 5639);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MergedNamespaceDeclaration
                f_10393_5574_5640(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration>
                declarations)
                {
                    var return_v = MergedNamespaceDeclaration.Create(declarations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10393, 5574, 5640);
                    return return_v;
                }


                int
                f_10393_5561_5641(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MergedNamespaceOrTypeDeclaration>
                this_param, Microsoft.CodeAnalysis.CSharp.MergedNamespaceDeclaration
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.MergedNamespaceOrTypeDeclaration)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10393, 5561, 5641);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration>>
                f_10393_5746_5814(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration>
                this_param, System.Func<Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration, string>
                keySelector, Roslyn.Utilities.StringOrdinalComparer
                comparer)
                {
                    var return_v = this_param.ToDictionary<string>(keySelector, (System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10393, 5746, 5814);
                    return return_v;
                }


                int
                f_10393_5837_5854(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10393, 5837, 5854);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration>>.ValueCollection
                f_10393_5910_5932(System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration>>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10393, 5910, 5932);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MergedNamespaceDeclaration
                f_10393_5995_6044(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration>
                declarations)
                {
                    var return_v = MergedNamespaceDeclaration.Create(declarations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10393, 5995, 6044);
                    return return_v;
                }


                int
                f_10393_5982_6045(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MergedNamespaceOrTypeDeclaration>
                this_param, Microsoft.CodeAnalysis.CSharp.MergedNamespaceDeclaration
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.MergedNamespaceOrTypeDeclaration)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10393, 5982, 6045);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration>>.ValueCollection
                f_10393_5910_5932_I(System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration>>.ValueCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10393, 5910, 5932);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                f_10393_6279_6305(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10393, 6279, 6305);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MergedTypeDeclaration
                f_10393_6253_6306(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                declarations)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MergedTypeDeclaration(declarations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10393, 6253, 6306);
                    return return_v;
                }


                int
                f_10393_6240_6307(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MergedNamespaceOrTypeDeclaration>
                this_param, Microsoft.CodeAnalysis.CSharp.MergedTypeDeclaration
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.MergedNamespaceOrTypeDeclaration)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10393, 6240, 6307);
                    return 0;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration.TypeDeclarationIdentity, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>>
                f_10393_6407_6442(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                this_param, System.Func<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration, Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration.TypeDeclarationIdentity>
                keySelector)
                {
                    var return_v = this_param.ToDictionary<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration.TypeDeclarationIdentity>(keySelector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10393, 6407, 6442);
                    return return_v;
                }


                int
                f_10393_6465_6477(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10393, 6465, 6477);
                    return 0;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration.TypeDeclarationIdentity, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>>.ValueCollection
                f_10393_6528_6545(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration.TypeDeclarationIdentity, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10393, 6528, 6545);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MergedTypeDeclaration
                f_10393_6608_6644(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                declarations)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MergedTypeDeclaration(declarations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10393, 6608, 6644);
                    return return_v;
                }


                int
                f_10393_6595_6645(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MergedNamespaceOrTypeDeclaration>
                this_param, Microsoft.CodeAnalysis.CSharp.MergedTypeDeclaration
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.MergedNamespaceOrTypeDeclaration)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10393, 6595, 6645);
                    return 0;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration.TypeDeclarationIdentity, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>>.ValueCollection
                f_10393_6528_6545_I(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration.TypeDeclarationIdentity, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>>.ValueCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10393, 6528, 6545);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.MergedNamespaceOrTypeDeclaration>
                f_10393_6726_6755(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.MergedNamespaceOrTypeDeclaration>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10393, 6726, 6755);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10393, 3150, 6767);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10393, 3150, 6767);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public new ImmutableArray<MergedNamespaceOrTypeDeclaration> Children
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10393, 6872, 7130);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10393, 6908, 7074) || true) && (_lazyChildren.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10393, 6908, 7074);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10393, 6977, 7055);

                        f_10393_6977_7054(ref _lazyChildren, f_10393_7039_7053(this));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10393, 6908, 7074);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10393, 7094, 7115);

                    return _lazyChildren;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10393, 6872, 7130);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.MergedNamespaceOrTypeDeclaration>
                    f_10393_7039_7053(Microsoft.CodeAnalysis.CSharp.MergedNamespaceDeclaration
                    this_param)
                    {
                        var return_v = this_param.MakeChildren();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10393, 7039, 7053);
                        return return_v;
                    }


                    bool
                    f_10393_6977_7054(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.MergedNamespaceOrTypeDeclaration>
                    location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.MergedNamespaceOrTypeDeclaration>
                    value)
                    {
                        var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10393, 6977, 7054);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10393, 6779, 7141);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10393, 6779, 7141);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static MergedNamespaceDeclaration()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10393, 544, 7148);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10393, 544, 7148);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10393, 544, 7148);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10393, 544, 7148);

        static string
        f_10393_961_981(Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10393, 961, 981);
            return return_v;
        }


        static string
        f_10393_923_981_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10393, 811, 1047);
            return return_v;
        }

    }
}
