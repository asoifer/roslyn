// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class NullableWalker
    {
        private sealed class PlaceholderLocal : LocalSymbol
        {
            private readonly Symbol _containingSymbol;

            private readonly TypeWithAnnotations _type;

            private readonly object _identifier;

            public PlaceholderLocal(Symbol containingSymbol, object identifier, TypeWithAnnotations type)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10901, 1054, 1357);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10901, 913, 930);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10901, 1026, 1037);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10901, 1180, 1213);

                    f_10901_1180_1212(identifier != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10901, 1231, 1268);

                    _containingSymbol = containingSymbol;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10901, 1286, 1299);

                    _type = type;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10901, 1317, 1342);

                    _identifier = identifier;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10901, 1054, 1357);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10901, 1054, 1357);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10901, 1054, 1357);
                }
            }

            public override bool Equals(Symbol obj, TypeCompareKind compareKind)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10901, 1373, 1683);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10901, 1474, 1570) || true) && ((object)this == obj)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10901, 1474, 1570);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10901, 1539, 1551);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10901, 1474, 1570);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10901, 1590, 1668);

                    return obj is PlaceholderLocal other && (DynAbs.Tracing.TraceSender.Expression_True(10901, 1597, 1667) && f_10901_1630_1667(_identifier, other._identifier));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10901, 1373, 1683);

                    bool
                    f_10901_1630_1667(object
                    this_param, object
                    obj)
                    {
                        var return_v = this_param.Equals(obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10901, 1630, 1667);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10901, 1373, 1683);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10901, 1373, 1683);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override int GetHashCode()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10901, 1733, 1761);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10901, 1736, 1761);
                    return f_10901_1736_1761(_identifier); DynAbs.Tracing.TraceSender.TraceExitMethod(10901, 1733, 1761);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10901, 1733, 1761);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10901, 1733, 1761);
                }
                throw new System.Exception("Slicer error: unreachable code");

                int
                f_10901_1736_1761(object
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10901, 1736, 1761);
                    return return_v;
                }

            }

            internal override SyntaxNode ScopeDesignatorOpt
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10901, 1824, 1831);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10901, 1827, 1831);
                        return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10901, 1824, 1831);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10901, 1824, 1831);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10901, 1824, 1831);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override Symbol ContainingSymbol
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10901, 1886, 1906);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10901, 1889, 1906);
                        return _containingSymbol; DynAbs.Tracing.TraceSender.TraceExitMethod(10901, 1886, 1906);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10901, 1886, 1906);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10901, 1886, 1906);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override ImmutableArray<SyntaxReference> DeclaringSyntaxReferences
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10901, 1995, 2035);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10901, 1998, 2035);
                        return ImmutableArray<SyntaxReference>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10901, 1995, 2035);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10901, 1995, 2035);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10901, 1995, 2035);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override ImmutableArray<Location> Locations
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10901, 2101, 2134);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10901, 2104, 2134);
                        return ImmutableArray<Location>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10901, 2101, 2134);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10901, 2101, 2134);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10901, 2101, 2134);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override TypeWithAnnotations TypeWithAnnotations
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10901, 2205, 2213);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10901, 2208, 2213);
                        return _type; DynAbs.Tracing.TraceSender.TraceExitMethod(10901, 2205, 2213);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10901, 2205, 2213);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10901, 2205, 2213);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override LocalDeclarationKind DeclarationKind
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10901, 2283, 2311);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10901, 2286, 2311);
                        return LocalDeclarationKind.None; DynAbs.Tracing.TraceSender.TraceExitMethod(10901, 2283, 2311);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10901, 2283, 2311);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10901, 2283, 2311);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override SyntaxToken IdentifierToken
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10901, 2372, 2411);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10901, 2375, 2411);
                        throw f_10901_2381_2411(); DynAbs.Tracing.TraceSender.TraceExitMethod(10901, 2372, 2411);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10901, 2372, 2411);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10901, 2372, 2411);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override bool IsCompilerGenerated
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10901, 2469, 2476);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10901, 2472, 2476);
                        return true; DynAbs.Tracing.TraceSender.TraceExitMethod(10901, 2469, 2476);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10901, 2469, 2476);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10901, 2469, 2476);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override bool IsImportedFromMetadata
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10901, 2537, 2545);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10901, 2540, 2545);
                        return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10901, 2537, 2545);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10901, 2537, 2545);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10901, 2537, 2545);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override bool IsPinned
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10901, 2592, 2600);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10901, 2595, 2600);
                        return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10901, 2592, 2600);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10901, 2592, 2600);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10901, 2592, 2600);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override RefKind RefKind
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10901, 2647, 2662);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10901, 2650, 2662);
                        return RefKind.None; DynAbs.Tracing.TraceSender.TraceExitMethod(10901, 2647, 2662);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10901, 2647, 2662);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10901, 2647, 2662);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override SynthesizedLocalKind SynthesizedKind
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10901, 2732, 2771);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10901, 2735, 2771);
                        throw f_10901_2741_2771(); DynAbs.Tracing.TraceSender.TraceExitMethod(10901, 2732, 2771);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10901, 2732, 2771);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10901, 2732, 2771);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override ConstantValue GetConstantValue(SyntaxNode node, LocalSymbol inProgress, DiagnosticBag diagnostics = null)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10901, 2910, 2917);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10901, 2913, 2917);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10901, 2910, 2917);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10901, 2910, 2917);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10901, 2910, 2917);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override ImmutableArray<Diagnostic> GetConstantValueDiagnostics(BoundExpression boundInitValue)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10901, 3037, 3072);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10901, 3040, 3072);
                    return ImmutableArray<Diagnostic>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10901, 3037, 3072);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10901, 3037, 3072);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10901, 3037, 3072);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override SyntaxNode GetDeclaratorSyntax()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10901, 3138, 3177);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10901, 3141, 3177);
                    throw f_10901_3147_3177(); DynAbs.Tracing.TraceSender.TraceExitMethod(10901, 3138, 3177);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10901, 3138, 3177);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10901, 3138, 3177);
                }
                throw new System.Exception("Slicer error: unreachable code");

                System.Exception
                f_10901_3147_3177()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10901, 3147, 3177);
                    return return_v;
                }

            }

            internal override LocalSymbol WithSynthesizedLocalKindAndSyntax(SynthesizedLocalKind kind, SyntaxNode syntax)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10901, 3302, 3341);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10901, 3305, 3341);
                    throw f_10901_3311_3341(); DynAbs.Tracing.TraceSender.TraceExitMethod(10901, 3302, 3341);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10901, 3302, 3341);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10901, 3302, 3341);
                }
                throw new System.Exception("Slicer error: unreachable code");

                System.Exception
                f_10901_3311_3341()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10901, 3311, 3341);
                    return return_v;
                }

            }

            internal override uint ValEscapeScope
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10901, 3394, 3433);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10901, 3397, 3433);
                        throw f_10901_3403_3433(); DynAbs.Tracing.TraceSender.TraceExitMethod(10901, 3394, 3433);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10901, 3394, 3433);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10901, 3394, 3433);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override uint RefEscapeScope
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10901, 3486, 3525);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10901, 3489, 3525);
                        throw f_10901_3495_3525(); DynAbs.Tracing.TraceSender.TraceExitMethod(10901, 3486, 3525);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10901, 3486, 3525);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10901, 3486, 3525);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static PlaceholderLocal()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10901, 813, 3537);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10901, 813, 3537);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10901, 813, 3537);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10901, 813, 3537);

            int
            f_10901_1180_1212(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10901, 1180, 1212);
                return 0;
            }


            System.Exception
            f_10901_2381_2411()
            {
                var return_v = ExceptionUtilities.Unreachable;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10901, 2381, 2411);
                return return_v;
            }


            System.Exception
            f_10901_2741_2771()
            {
                var return_v = ExceptionUtilities.Unreachable;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10901, 2741, 2771);
                return return_v;
            }


            System.Exception
            f_10901_3403_3433()
            {
                var return_v = ExceptionUtilities.Unreachable;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10901, 3403, 3433);
                return return_v;
            }


            System.Exception
            f_10901_3495_3525()
            {
                var return_v = ExceptionUtilities.Unreachable;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10901, 3495, 3525);
                return return_v;
            }

        }
    }
}
