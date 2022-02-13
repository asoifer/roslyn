// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class Binder
    {
        internal CSharpCompilation Compilation { get; }

        internal readonly BinderFlags Flags;

        internal Binder(CSharpCompilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10286, 923, 1219);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 726, 773);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 815, 820);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 2975, 3015);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 17802, 17818);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 18200, 18223);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 994, 1034);

                f_10286_994_1033(compilation != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 1048, 1096);

                f_10286_1048_1095(this is BuckStopsHereBinder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 1110, 1163);

                this.Flags = f_10286_1123_1162(f_10286_1123_1142(compilation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 1177, 1208);

                this.Compilation = compilation;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10286, 923, 1219);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 923, 1219);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 923, 1219);
            }
        }

        internal Binder(Binder next, Conversions? conversions = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10286, 1231, 1520);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 726, 773);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 815, 820);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 2975, 3015);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 17802, 17818);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 18200, 18223);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 1317, 1350);

                f_10286_1317_1349(next != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 1364, 1376);

                Next = next;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 1390, 1414);

                this.Flags = next.Flags;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 1428, 1464);

                this.Compilation = f_10286_1447_1463(next);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 1478, 1509);

                _lazyConversions = conversions;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10286, 1231, 1520);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 1231, 1520);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 1231, 1520);
            }
        }

        protected Binder(Binder next, BinderFlags flags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10286, 1532, 2083);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 726, 773);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 815, 820);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 2975, 3015);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 17802, 17818);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 18200, 18223);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 1605, 1638);

                f_10286_1605_1637(next != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 1688, 1781);

                f_10286_1688_1780(!f_10286_1708_1779(flags, BinderFlags.UncheckedRegion | BinderFlags.CheckedRegion));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 1820, 1963);

                f_10286_1820_1962(!f_10286_1840_1888(flags, BinderFlags.InNestedFinallyBlock) || (DynAbs.Tracing.TraceSender.Expression_False(10286, 1839, 1961) || f_10286_1892_1961(flags, BinderFlags.InFinallyBlock | BinderFlags.InCatchBlock)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 1977, 1989);

                Next = next;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 2003, 2022);

                this.Flags = flags;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 2036, 2072);

                this.Compilation = f_10286_2055_2071(next);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10286, 1532, 2083);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 1532, 2083);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 1532, 2083);
            }
        }

        internal bool IsSemanticModelBinder
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10286, 2155, 2260);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 2191, 2245);

                    return f_10286_2198_2244(this.Flags, BinderFlags.SemanticModel);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10286, 2155, 2260);

                    bool
                    f_10286_2198_2244(Microsoft.CodeAnalysis.CSharp.BinderFlags
                    self, Microsoft.CodeAnalysis.CSharp.BinderFlags
                    other)
                    {
                        var return_v = self.Includes(other);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 2198, 2244);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 2095, 2271);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 2095, 2271);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool IsEarlyAttributeBinder
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10286, 2438, 2551);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 2474, 2536);

                    return f_10286_2481_2535(this.Flags, BinderFlags.EarlyAttributeBinding);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10286, 2438, 2551);

                    bool
                    f_10286_2481_2535(Microsoft.CodeAnalysis.CSharp.BinderFlags
                    self, Microsoft.CodeAnalysis.CSharp.BinderFlags
                    other)
                    {
                        var return_v = self.Includes(other);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 2481, 2535);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 2377, 2562);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 2377, 2562);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected virtual SyntaxNode? EnclosingNameofArgument
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10286, 2738, 2745);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 2741, 2745);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10286, 2738, 2745);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 2738, 2745);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 2738, 2745);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private bool IsInsideNameof
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10286, 2786, 2825);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 2789, 2825);
                    return f_10286_2789_2817(this) != null; DynAbs.Tracing.TraceSender.TraceExitMethod(10286, 2786, 2825);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 2786, 2825);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 2786, 2825);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected internal Binder? Next { get; }

        protected OverflowChecks CheckOverflow
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10286, 3466, 4355);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 3948, 4046);

                    f_10286_3948_4045(!f_10286_3968_4044(this.Flags, BinderFlags.UncheckedRegion | BinderFlags.CheckedRegion));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 4066, 4340);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10286, 4073, 4119) || ((f_10286_4073_4119(this.Flags, BinderFlags.CheckedRegion) && DynAbs.Tracing.TraceSender.Conditional_F2(10286, 4143, 4165)) || DynAbs.Tracing.TraceSender.Conditional_F3(10286, 4189, 4339))) ? OverflowChecks.Enabled
                    : (DynAbs.Tracing.TraceSender.Conditional_F1(10286, 4189, 4237) || ((f_10286_4189_4237(this.Flags, BinderFlags.UncheckedRegion) && DynAbs.Tracing.TraceSender.Conditional_F2(10286, 4265, 4288)) || DynAbs.Tracing.TraceSender.Conditional_F3(10286, 4316, 4339))) ? OverflowChecks.Disabled
                    : OverflowChecks.Implicit;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10286, 3466, 4355);

                    bool
                    f_10286_3968_4044(Microsoft.CodeAnalysis.CSharp.BinderFlags
                    self, Microsoft.CodeAnalysis.CSharp.BinderFlags
                    other)
                    {
                        var return_v = self.Includes(other);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 3968, 4044);
                        return return_v;
                    }


                    int
                    f_10286_3948_4045(bool
                    b)
                    {
                        RoslynDebug.Assert(b);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 3948, 4045);
                        return 0;
                    }


                    bool
                    f_10286_4073_4119(Microsoft.CodeAnalysis.CSharp.BinderFlags
                    self, Microsoft.CodeAnalysis.CSharp.BinderFlags
                    other)
                    {
                        var return_v = self.Includes(other);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 4073, 4119);
                        return return_v;
                    }


                    bool
                    f_10286_4189_4237(Microsoft.CodeAnalysis.CSharp.BinderFlags
                    self, Microsoft.CodeAnalysis.CSharp.BinderFlags
                    other)
                    {
                        var return_v = self.Includes(other);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 4189, 4237);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 3403, 4366);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 3403, 4366);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected bool CheckOverflowAtRuntime
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10286, 5010, 5220);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 5046, 5073);

                    var
                    result = f_10286_5059_5072()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 5091, 5205);

                    return result == OverflowChecks.Enabled || (DynAbs.Tracing.TraceSender.Expression_False(10286, 5098, 5204) || result == OverflowChecks.Implicit && (DynAbs.Tracing.TraceSender.Expression_True(10286, 5134, 5204) && f_10286_5171_5204(f_10286_5171_5190(f_10286_5171_5182()))));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10286, 5010, 5220);

                    Microsoft.CodeAnalysis.CSharp.Binder.OverflowChecks
                    f_10286_5059_5072()
                    {
                        var return_v = CheckOverflow;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 5059, 5072);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10286_5171_5182()
                    {
                        var return_v = Compilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 5171, 5182);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                    f_10286_5171_5190(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param)
                    {
                        var return_v = this_param.Options;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 5171, 5190);
                        return return_v;
                    }


                    bool
                    f_10286_5171_5204(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                    this_param)
                    {
                        var return_v = this_param.CheckOverflow;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 5171, 5204);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 4948, 5231);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 4948, 5231);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool CheckOverflowAtCompileTime
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10286, 5906, 6005);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 5942, 5990);

                    return f_10286_5949_5962() != OverflowChecks.Disabled;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10286, 5906, 6005);

                    Microsoft.CodeAnalysis.CSharp.Binder.OverflowChecks
                    f_10286_5949_5962()
                    {
                        var return_v = CheckOverflow;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 5949, 5962);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 5841, 6016);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 5841, 6016);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual Binder? GetBinder(SyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10286, 6153, 6322);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 6229, 6264);

                f_10286_6229_6263(f_10286_6248_6252() is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 6278, 6311);

                return f_10286_6285_6310(f_10286_6285_6294(this), node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10286, 6153, 6322);

                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10286_6248_6252()
                {
                    var return_v = Next;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 6248, 6252);
                    return return_v;
                }


                int
                f_10286_6229_6263(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 6229, 6263);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10286_6285_6294(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Next;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 6285, 6294);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10286_6285_6310(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.GetBinder(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 6285, 6310);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 6153, 6322);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 6153, 6322);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Binder GetRequiredBinder(SyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10286, 6481, 6675);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 6556, 6585);

                var
                binder = f_10286_6569_6584(this, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 6599, 6636);

                f_10286_6599_6635(binder is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 6650, 6664);

                return binder;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10286, 6481, 6675);

                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10286_6569_6584(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.GetBinder(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 6569, 6584);
                    return return_v;
                }


                int
                f_10286_6599_6635(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 6599, 6635);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 6481, 6675);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 6481, 6675);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual ImmutableArray<LocalSymbol> GetDeclaredLocalsForScope(SyntaxNode scopeDesignator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10286, 6812, 7055);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 6935, 6970);

                f_10286_6935_6969(f_10286_6954_6958() is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 6984, 7044);

                return f_10286_6991_7043(f_10286_6991_7000(this), scopeDesignator);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10286, 6812, 7055);

                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10286_6954_6958()
                {
                    var return_v = Next;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 6954, 6958);
                    return return_v;
                }


                int
                f_10286_6935_6969(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 6935, 6969);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10286_6991_7000(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Next;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 6991, 7000);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10286_6991_7043(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                scopeDesignator)
                {
                    var return_v = this_param.GetDeclaredLocalsForScope(scopeDesignator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 6991, 7043);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 6812, 7055);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 6812, 7055);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual ImmutableArray<LocalFunctionSymbol> GetDeclaredLocalFunctionsForScope(CSharpSyntaxNode scopeDesignator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10286, 7201, 7474);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 7346, 7381);

                f_10286_7346_7380(f_10286_7365_7369() is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 7395, 7463);

                return f_10286_7402_7462(f_10286_7402_7411(this), scopeDesignator);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10286, 7201, 7474);

                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10286_7365_7369()
                {
                    var return_v = Next;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 7365, 7369);
                    return return_v;
                }


                int
                f_10286_7346_7380(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 7346, 7380);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10286_7402_7411(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Next;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 7402, 7411);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                f_10286_7402_7462(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                scopeDesignator)
                {
                    var return_v = this_param.GetDeclaredLocalFunctionsForScope(scopeDesignator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 7402, 7462);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 7201, 7474);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 7201, 7474);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual SyntaxNode? ScopeDesignator
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10286, 7742, 7805);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 7778, 7790);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10286, 7742, 7805);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 7673, 7816);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 7673, 7816);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual bool IsLocalFunctionsScopeBinder
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10286, 7902, 7966);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 7938, 7951);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10286, 7902, 7966);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 7828, 7977);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 7828, 7977);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual bool IsLabelsScopeBinder
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10286, 8055, 8119);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 8091, 8104);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10286, 8055, 8119);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 7989, 8130);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 7989, 8130);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual bool IsNestedFunctionBinder
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10286, 8381, 8389);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 8384, 8389);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10286, 8381, 8389);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 8381, 8389);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 8381, 8389);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual Symbol? ContainingMemberOrLambda
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10286, 8725, 8866);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 8761, 8796);

                    f_10286_8761_8795(f_10286_8780_8784() is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 8814, 8851);

                    return f_10286_8821_8850(f_10286_8821_8825());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10286, 8725, 8866);

                    Microsoft.CodeAnalysis.CSharp.Binder?
                    f_10286_8780_8784()
                    {
                        var return_v = Next;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 8780, 8784);
                        return return_v;
                    }


                    int
                    f_10286_8761_8795(bool
                    b)
                    {
                        RoslynDebug.Assert(b);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 8761, 8795);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10286_8821_8825()
                    {
                        var return_v = Next;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 8821, 8825);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol?
                    f_10286_8821_8850(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param)
                    {
                        var return_v = this_param.ContainingMemberOrLambda;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 8821, 8850);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 8651, 8877);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 8651, 8877);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool AreNullableAnnotationsEnabled(SyntaxTree syntaxTree, int position)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10286, 9029, 9954);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 9134, 9189);

                CSharpSyntaxTree
                csTree = (CSharpSyntaxTree)syntaxTree
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 9203, 9282);

                Syntax.NullableContextState
                context = f_10286_9241_9281(csTree, position)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 9298, 9943);

                return context.AnnotationsState switch
                {
                    Syntax.NullableContextState.State.Enabled when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 9369, 9418) && DynAbs.Tracing.TraceSender.Expression_True(10286, 9369, 9418))
    => true,
                    Syntax.NullableContextState.State.Disabled when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 9437, 9488) && DynAbs.Tracing.TraceSender.Expression_True(10286, 9437, 9488))
    => false,
                    Syntax.NullableContextState.State.ExplicitlyRestored when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 9507, 9589) && DynAbs.Tracing.TraceSender.Expression_True(10286, 9507, 9589))
    => f_10286_9563_9589(this),
                    Syntax.NullableContextState.State.Unknown when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 9608, 9837) && DynAbs.Tracing.TraceSender.Expression_True(10286, 9608, 9837))
    =>
                        !f_10286_9675_9773(csTree, f_10286_9698_9748(f_10286_9698_9722(f_10286_9698_9714(this))), CancellationToken.None) && (DynAbs.Tracing.TraceSender.Expression_True(10286, 9674, 9837) && f_10286_9798_9837(this)),
                    _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 9856, 9927) && DynAbs.Tracing.TraceSender.Expression_True(10286, 9856, 9927))
    => throw f_10286_9867_9927(context.AnnotationsState)
                };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10286, 9029, 9954);

                Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextState
                f_10286_9241_9281(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                this_param, int
                position)
                {
                    var return_v = this_param.GetNullableContextState(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 9241, 9281);
                    return return_v;
                }


                bool
                f_10286_9563_9589(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.GetGlobalAnnotationState();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 9563, 9589);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10286_9698_9714(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 9698, 9714);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10286_9698_9722(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 9698, 9722);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTreeOptionsProvider?
                f_10286_9698_9748(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.SyntaxTreeOptionsProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 9698, 9748);
                    return return_v;
                }


                bool
                f_10286_9675_9773(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                this_param, Microsoft.CodeAnalysis.SyntaxTreeOptionsProvider?
                provider, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.IsGeneratedCode(provider, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 9675, 9773);
                    return return_v;
                }


                bool
                f_10286_9798_9837(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.AreNullableAnnotationsGloballyEnabled();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 9798, 9837);
                    return return_v;
                }


                System.Exception
                f_10286_9867_9927(Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextState.State
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 9867, 9927);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 9029, 9954);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 9029, 9954);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool AreNullableAnnotationsEnabled(SyntaxToken token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10286, 9966, 10197);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 10053, 10100);

                f_10286_10053_10099(token.SyntaxTree is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 10114, 10186);

                return f_10286_10121_10185(this, token.SyntaxTree, token.SpanStart);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10286, 9966, 10197);

                int
                f_10286_10053_10099(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 10053, 10099);
                    return 0;
                }


                bool
                f_10286_10121_10185(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree, int
                position)
                {
                    var return_v = this_param.AreNullableAnnotationsEnabled(syntaxTree, position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 10121, 10185);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 9966, 10197);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 9966, 10197);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsGeneratedCode(SyntaxToken token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10286, 10209, 10453);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 10282, 10329);

                var
                tree = (CSharpSyntaxTree)token.SyntaxTree!
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 10343, 10442);

                return f_10286_10350_10441(tree, f_10286_10371_10416(f_10286_10371_10390(f_10286_10371_10382())), CancellationToken.None);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10286, 10209, 10453);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10286_10371_10382()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 10371, 10382);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10286_10371_10390(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 10371, 10390);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTreeOptionsProvider?
                f_10286_10371_10416(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.SyntaxTreeOptionsProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 10371, 10416);
                    return return_v;
                }


                bool
                f_10286_10350_10441(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                this_param, Microsoft.CodeAnalysis.SyntaxTreeOptionsProvider?
                provider, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.IsGeneratedCode(provider, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 10350, 10441);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 10209, 10453);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 10209, 10453);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual bool AreNullableAnnotationsGloballyEnabled()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10286, 10465, 10663);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 10551, 10586);

                f_10286_10551_10585(f_10286_10570_10574() is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 10600, 10652);

                return f_10286_10607_10651(f_10286_10607_10611());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10286, 10465, 10663);

                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10286_10570_10574()
                {
                    var return_v = Next;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 10570, 10574);
                    return return_v;
                }


                int
                f_10286_10551_10585(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 10551, 10585);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10286_10607_10611()
                {
                    var return_v = Next;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 10607, 10611);
                    return return_v;
                }


                bool
                f_10286_10607_10651(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.AreNullableAnnotationsGloballyEnabled();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 10607, 10651);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 10465, 10663);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 10465, 10663);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected bool GetGlobalAnnotationState()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10286, 10675, 11259);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 10741, 11248);

                switch (f_10286_10749_10791(f_10286_10749_10768(f_10286_10749_10760())))
                {

                    case NullableContextOptions.Enable:
                    case NullableContextOptions.Annotations:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10286, 10741, 11248);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 10940, 10952);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10286, 10741, 11248);

                    case NullableContextOptions.Disable:
                    case NullableContextOptions.Warnings:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10286, 10741, 11248);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 11085, 11098);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10286, 10741, 11248);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10286, 10741, 11248);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 11148, 11233);

                        throw f_10286_11154_11232(f_10286_11189_11231(f_10286_11189_11208(f_10286_11189_11200())));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10286, 10741, 11248);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10286, 10675, 11259);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10286_10749_10760()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 10749, 10760);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10286_10749_10768(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 10749, 10768);
                    return return_v;
                }


                Microsoft.CodeAnalysis.NullableContextOptions
                f_10286_10749_10791(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.NullableContextOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 10749, 10791);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10286_11189_11200()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 11189, 11200);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10286_11189_11208(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 11189, 11208);
                    return return_v;
                }


                Microsoft.CodeAnalysis.NullableContextOptions
                f_10286_11189_11231(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.NullableContextOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 11189, 11231);
                    return return_v;
                }


                System.Exception
                f_10286_11154_11232(Microsoft.CodeAnalysis.NullableContextOptions
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 11154, 11232);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 10675, 11259);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 10675, 11259);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual bool IsInMethodBody
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10286, 11618, 11749);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 11654, 11689);

                    f_10286_11654_11688(f_10286_11673_11677() is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 11707, 11734);

                    return f_10286_11714_11733(f_10286_11714_11718());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10286, 11618, 11749);

                    Microsoft.CodeAnalysis.CSharp.Binder?
                    f_10286_11673_11677()
                    {
                        var return_v = Next;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 11673, 11677);
                        return return_v;
                    }


                    int
                    f_10286_11654_11688(bool
                    b)
                    {
                        RoslynDebug.Assert(b);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 11654, 11688);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10286_11714_11718()
                    {
                        var return_v = Next;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 11714, 11718);
                        return return_v;
                    }


                    bool
                    f_10286_11714_11733(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param)
                    {
                        var return_v = this_param.IsInMethodBody;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 11714, 11733);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 11557, 11760);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 11557, 11760);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual bool IsDirectlyInIterator
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10286, 12049, 12186);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 12085, 12120);

                    f_10286_12085_12119(f_10286_12104_12108() is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 12138, 12171);

                    return f_10286_12145_12170(f_10286_12145_12149());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10286, 12049, 12186);

                    Microsoft.CodeAnalysis.CSharp.Binder?
                    f_10286_12104_12108()
                    {
                        var return_v = Next;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 12104, 12108);
                        return return_v;
                    }


                    int
                    f_10286_12085_12119(bool
                    b)
                    {
                        RoslynDebug.Assert(b);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 12085, 12119);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10286_12145_12149()
                    {
                        var return_v = Next;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 12145, 12149);
                        return return_v;
                    }


                    bool
                    f_10286_12145_12170(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param)
                    {
                        var return_v = this_param.IsDirectlyInIterator;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 12145, 12170);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 11982, 12197);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 11982, 12197);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual bool IsIndirectlyInIterator
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10286, 12523, 12662);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 12559, 12594);

                    f_10286_12559_12593(f_10286_12578_12582() is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 12612, 12647);

                    return f_10286_12619_12646(f_10286_12619_12623());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10286, 12523, 12662);

                    Microsoft.CodeAnalysis.CSharp.Binder?
                    f_10286_12578_12582()
                    {
                        var return_v = Next;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 12578, 12582);
                        return return_v;
                    }


                    int
                    f_10286_12559_12593(bool
                    b)
                    {
                        RoslynDebug.Assert(b);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 12559, 12593);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10286_12619_12623()
                    {
                        var return_v = Next;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 12619, 12623);
                        return return_v;
                    }


                    bool
                    f_10286_12619_12646(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param)
                    {
                        var return_v = this_param.IsIndirectlyInIterator;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 12619, 12646);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 12454, 12673);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 12454, 12673);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual GeneratedLabelSymbol? BreakLabel
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10286, 13017, 13144);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 13053, 13088);

                    f_10286_13053_13087(f_10286_13072_13076() is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 13106, 13129);

                    return f_10286_13113_13128(f_10286_13113_13117());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10286, 13017, 13144);

                    Microsoft.CodeAnalysis.CSharp.Binder?
                    f_10286_13072_13076()
                    {
                        var return_v = Next;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 13072, 13076);
                        return return_v;
                    }


                    int
                    f_10286_13053_13087(bool
                    b)
                    {
                        RoslynDebug.Assert(b);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 13053, 13087);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10286_13113_13117()
                    {
                        var return_v = Next;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 13113, 13117);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol?
                    f_10286_13113_13128(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param)
                    {
                        var return_v = this_param.BreakLabel;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 13113, 13128);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 12943, 13155);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 12943, 13155);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual GeneratedLabelSymbol? ContinueLabel
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10286, 13508, 13638);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 13544, 13579);

                    f_10286_13544_13578(f_10286_13563_13567() is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 13597, 13623);

                    return f_10286_13604_13622(f_10286_13604_13608());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10286, 13508, 13638);

                    Microsoft.CodeAnalysis.CSharp.Binder?
                    f_10286_13563_13567()
                    {
                        var return_v = Next;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 13563, 13567);
                        return return_v;
                    }


                    int
                    f_10286_13544_13578(bool
                    b)
                    {
                        RoslynDebug.Assert(b);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 13544, 13578);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10286_13604_13608()
                    {
                        var return_v = Next;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 13604, 13608);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol?
                    f_10286_13604_13622(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param)
                    {
                        var return_v = this_param.ContinueLabel;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 13604, 13622);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 13431, 13649);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 13431, 13649);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual TypeWithAnnotations GetIteratorElementType()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10286, 13848, 14031);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 13934, 13969);

                f_10286_13934_13968(f_10286_13953_13957() is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 13983, 14020);

                return f_10286_13990_14019(f_10286_13990_13994());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10286, 13848, 14031);

                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10286_13953_13957()
                {
                    var return_v = Next;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 13953, 13957);
                    return return_v;
                }


                int
                f_10286_13934_13968(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 13934, 13968);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10286_13990_13994()
                {
                    var return_v = Next;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 13990, 13994);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10286_13990_14019(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.GetIteratorElementType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 13990, 14019);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 13848, 14031);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 13848, 14031);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual ImportChain? ImportChain
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10286, 14307, 14435);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 14343, 14378);

                    f_10286_14343_14377(f_10286_14362_14366() is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 14396, 14420);

                    return f_10286_14403_14419(f_10286_14403_14407());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10286, 14307, 14435);

                    Microsoft.CodeAnalysis.CSharp.Binder?
                    f_10286_14362_14366()
                    {
                        var return_v = Next;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 14362, 14366);
                        return return_v;
                    }


                    int
                    f_10286_14343_14377(bool
                    b)
                    {
                        RoslynDebug.Assert(b);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 14343, 14377);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10286_14403_14407()
                    {
                        var return_v = Next;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 14403, 14407);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.ImportChain?
                    f_10286_14403_14419(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param)
                    {
                        var return_v = this_param.ImportChain;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 14403, 14419);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 14241, 14446);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 14241, 14446);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual QuickAttributeChecker QuickAttributeChecker
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10286, 14752, 14890);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 14788, 14823);

                    f_10286_14788_14822(f_10286_14807_14811() is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 14841, 14875);

                    return f_10286_14848_14874(f_10286_14848_14852());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10286, 14752, 14890);

                    Microsoft.CodeAnalysis.CSharp.Binder?
                    f_10286_14807_14811()
                    {
                        var return_v = Next;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 14807, 14811);
                        return return_v;
                    }


                    int
                    f_10286_14788_14822(bool
                    b)
                    {
                        RoslynDebug.Assert(b);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 14788, 14822);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10286_14848_14852()
                    {
                        var return_v = Next;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 14848, 14852);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.QuickAttributeChecker
                    f_10286_14848_14874(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param)
                    {
                        var return_v = this_param.QuickAttributeChecker;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 14848, 14874);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 14667, 14901);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 14667, 14901);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual Imports GetImports(ConsList<TypeSymbol>? basesBeingResolved)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10286, 14913, 15118);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 15015, 15050);

                f_10286_15015_15049(f_10286_15034_15038() is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 15064, 15107);

                return f_10286_15071_15106(f_10286_15071_15075(), basesBeingResolved);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10286, 14913, 15118);

                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10286_15034_15038()
                {
                    var return_v = Next;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 15034, 15038);
                    return return_v;
                }


                int
                f_10286_15015_15049(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 15015, 15049);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10286_15071_15075()
                {
                    var return_v = Next;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 15071, 15075);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Imports
                f_10286_15071_15106(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
                basesBeingResolved)
                {
                    var return_v = this_param.GetImports(basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 15071, 15106);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 14913, 15118);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 14913, 15118);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual bool InExecutableBinder
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10286, 15196, 15331);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 15232, 15267);

                    f_10286_15232_15266(f_10286_15251_15255() is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 15285, 15316);

                    return f_10286_15292_15315(f_10286_15292_15296());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10286, 15196, 15331);

                    Microsoft.CodeAnalysis.CSharp.Binder?
                    f_10286_15251_15255()
                    {
                        var return_v = Next;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 15251, 15255);
                        return return_v;
                    }


                    int
                    f_10286_15232_15266(bool
                    b)
                    {
                        RoslynDebug.Assert(b);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 15232, 15266);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10286_15292_15296()
                    {
                        var return_v = Next;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 15292, 15296);
                        return return_v;
                    }


                    bool
                    f_10286_15292_15315(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param)
                    {
                        var return_v = this_param.InExecutableBinder;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 15292, 15315);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 15130, 15342);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 15130, 15342);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal NamedTypeSymbol? ContainingType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10286, 15519, 15926);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 15555, 15598);

                    var
                    member = f_10286_15568_15597(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 15616, 15690);

                    f_10286_15616_15689(member is null || (DynAbs.Tracing.TraceSender.Expression_False(10286, 15635, 15688) || f_10286_15653_15664(member) != SymbolKind.ErrorType));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 15708, 15911);

                    return member switch
                    {
                        null when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 15769, 15781) && DynAbs.Tracing.TraceSender.Expression_True(10286, 15769, 15781))
    => null,
                        NamedTypeSymbol namedType when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 15804, 15842) && DynAbs.Tracing.TraceSender.Expression_True(10286, 15804, 15842))
    => namedType,
                        _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 15865, 15891) && DynAbs.Tracing.TraceSender.Expression_True(10286, 15865, 15891))
    => f_10286_15870_15891(member)
                    };
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10286, 15519, 15926);

                    Microsoft.CodeAnalysis.CSharp.Symbol?
                    f_10286_15568_15597(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param)
                    {
                        var return_v = this_param.ContainingMemberOrLambda;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 15568, 15597);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SymbolKind
                    f_10286_15653_15664(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 15653, 15664);
                        return return_v;
                    }


                    int
                    f_10286_15616_15689(bool
                    b)
                    {
                        RoslynDebug.Assert(b);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 15616, 15689);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10286_15870_15891(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType
                        ;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 15870, 15891);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 15454, 15937);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 15454, 15937);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool BindingTopLevelScriptCode
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10286, 16136, 16765);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 16172, 16225);

                    var
                    containingMember = f_10286_16195_16224(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 16243, 16750);

                    switch (f_10286_16251_16273_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(containingMember, 10286, 16251, 16273)?.Kind))
                    {

                        case SymbolKind.Method:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10286, 16243, 16750);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 16410, 16470);

                            return f_10286_16417_16469(((MethodSymbol)containingMember));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10286, 16243, 16750);

                        case SymbolKind.NamedType:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10286, 16243, 16750);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 16603, 16660);

                            return f_10286_16610_16659(((NamedTypeSymbol)containingMember));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10286, 16243, 16750);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10286, 16243, 16750);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 16718, 16731);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10286, 16243, 16750);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10286, 16136, 16765);

                    Microsoft.CodeAnalysis.CSharp.Symbol?
                    f_10286_16195_16224(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param)
                    {
                        var return_v = this_param.ContainingMemberOrLambda;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 16195, 16224);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SymbolKind?
                    f_10286_16251_16273_M(Microsoft.CodeAnalysis.SymbolKind?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 16251, 16273);
                        return return_v;
                    }


                    bool
                    f_10286_16417_16469(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsScriptInitializer;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 16417, 16469);
                        return return_v;
                    }


                    bool
                    f_10286_16610_16659(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsScriptClass;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 16610, 16659);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 16072, 16776);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 16072, 16776);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual ConstantFieldsInProgress ConstantFieldsInProgress
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10286, 16879, 17025);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 16915, 16950);

                    f_10286_16915_16949(f_10286_16934_16938() is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 16968, 17010);

                    return f_10286_16975_17009(f_10286_16975_16984(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10286, 16879, 17025);

                    Microsoft.CodeAnalysis.CSharp.Binder?
                    f_10286_16934_16938()
                    {
                        var return_v = Next;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 16934, 16938);
                        return return_v;
                    }


                    int
                    f_10286_16915_16949(bool
                    b)
                    {
                        RoslynDebug.Assert(b);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 16915, 16949);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10286_16975_16984(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param)
                    {
                        var return_v = this_param.Next;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 16975, 16984);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.ConstantFieldsInProgress
                    f_10286_16975_17009(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param)
                    {
                        var return_v = this_param.ConstantFieldsInProgress;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 16975, 17009);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 16788, 17036);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 16788, 17036);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual ConsList<FieldSymbol> FieldsBeingBound
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10286, 17128, 17266);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 17164, 17199);

                    f_10286_17164_17198(f_10286_17183_17187() is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 17217, 17251);

                    return f_10286_17224_17250(f_10286_17224_17233(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10286, 17128, 17266);

                    Microsoft.CodeAnalysis.CSharp.Binder?
                    f_10286_17183_17187()
                    {
                        var return_v = Next;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 17183, 17187);
                        return return_v;
                    }


                    int
                    f_10286_17164_17198(bool
                    b)
                    {
                        RoslynDebug.Assert(b);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 17164, 17198);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10286_17224_17233(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param)
                    {
                        var return_v = this_param.Next;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 17224, 17233);
                        return return_v;
                    }


                    Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                    f_10286_17224_17250(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param)
                    {
                        var return_v = this_param.FieldsBeingBound;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 17224, 17250);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 17048, 17277);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 17048, 17277);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual LocalSymbol? LocalInProgress
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10286, 17359, 17496);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 17395, 17430);

                    f_10286_17395_17429(f_10286_17414_17418() is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 17448, 17481);

                    return f_10286_17455_17480(f_10286_17455_17464(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10286, 17359, 17496);

                    Microsoft.CodeAnalysis.CSharp.Binder?
                    f_10286_17414_17418()
                    {
                        var return_v = Next;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 17414, 17418);
                        return return_v;
                    }


                    int
                    f_10286_17395_17429(bool
                    b)
                    {
                        RoslynDebug.Assert(b);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 17395, 17429);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10286_17455_17464(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param)
                    {
                        var return_v = this_param.Next;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 17455, 17464);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol?
                    f_10286_17455_17480(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param)
                    {
                        var return_v = this_param.LocalInProgress;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 17455, 17480);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 17289, 17507);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 17289, 17507);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual BoundExpression? ConditionalReceiverExpression
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10286, 17607, 17758);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 17643, 17678);

                    f_10286_17643_17677(f_10286_17662_17666() is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 17696, 17743);

                    return f_10286_17703_17742(f_10286_17703_17712(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10286, 17607, 17758);

                    Microsoft.CodeAnalysis.CSharp.Binder?
                    f_10286_17662_17666()
                    {
                        var return_v = Next;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 17662, 17666);
                        return return_v;
                    }


                    int
                    f_10286_17643_17677(bool
                    b)
                    {
                        RoslynDebug.Assert(b);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 17643, 17677);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10286_17703_17712(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param)
                    {
                        var return_v = this_param.Next;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 17703, 17712);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression?
                    f_10286_17703_17742(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param)
                    {
                        var return_v = this_param.ConditionalReceiverExpression;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 17703, 17742);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 17519, 17769);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 17519, 17769);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private Conversions? _lazyConversions;

        internal Conversions Conversions
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10286, 17886, 18149);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 17922, 18090) || true) && (_lazyConversions == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10286, 17922, 18090);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 17992, 18071);

                        f_10286_17992_18070(ref _lazyConversions, f_10286_18042_18063(this), null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10286, 17922, 18090);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 18110, 18134);

                    return _lazyConversions;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10286, 17886, 18149);

                    Microsoft.CodeAnalysis.CSharp.Conversions
                    f_10286_18042_18063(Microsoft.CodeAnalysis.CSharp.Binder
                    binder)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Conversions(binder);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 18042, 18063);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Conversions?
                    f_10286_17992_18070(ref Microsoft.CodeAnalysis.CSharp.Conversions?
                    location1, Microsoft.CodeAnalysis.CSharp.Conversions
                    value, Microsoft.CodeAnalysis.CSharp.Conversions?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 17992, 18070);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 17829, 18160);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 17829, 18160);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private OverloadResolution? _lazyOverloadResolution;

        internal OverloadResolution OverloadResolution
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10286, 18305, 18596);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 18341, 18530) || true) && (_lazyOverloadResolution == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10286, 18341, 18530);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 18418, 18511);

                        f_10286_18418_18510(ref _lazyOverloadResolution, f_10286_18475_18503(this), null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10286, 18341, 18530);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 18550, 18581);

                    return _lazyOverloadResolution;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10286, 18305, 18596);

                    Microsoft.CodeAnalysis.CSharp.OverloadResolution
                    f_10286_18475_18503(Microsoft.CodeAnalysis.CSharp.Binder
                    binder)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.OverloadResolution(binder);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 18475, 18503);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.OverloadResolution?
                    f_10286_18418_18510(ref Microsoft.CodeAnalysis.CSharp.OverloadResolution?
                    location1, Microsoft.CodeAnalysis.CSharp.OverloadResolution
                    value, Microsoft.CodeAnalysis.CSharp.OverloadResolution?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 18418, 18510);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 18234, 18607);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 18234, 18607);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static void Error(DiagnosticBag diagnostics, DiagnosticInfo info, SyntaxNode syntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10286, 18619, 18805);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 18737, 18794);

                f_10286_18737_18793(diagnostics, f_10286_18753_18792(info, f_10286_18776_18791(syntax)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10286, 18619, 18805);

                Microsoft.CodeAnalysis.Location
                f_10286_18776_18791(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 18776, 18791);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                f_10286_18753_18792(Microsoft.CodeAnalysis.DiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnostic(info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 18753, 18792);
                    return return_v;
                }


                int
                f_10286_18737_18793(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                diag)
                {
                    this_param.Add((Microsoft.CodeAnalysis.Diagnostic)diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 18737, 18793);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 18619, 18805);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 18619, 18805);
            }
        }

        internal static void Error(DiagnosticBag diagnostics, DiagnosticInfo info, Location location)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10286, 18817, 18996);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 18935, 18985);

                f_10286_18935_18984(diagnostics, f_10286_18951_18983(info, location));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10286, 18817, 18996);

                Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                f_10286_18951_18983(Microsoft.CodeAnalysis.DiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnostic(info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 18951, 18983);
                    return return_v;
                }


                int
                f_10286_18935_18984(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                diag)
                {
                    this_param.Add((Microsoft.CodeAnalysis.Diagnostic)diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 18935, 18984);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 18817, 18996);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 18817, 18996);
            }
        }

        internal static void Error(DiagnosticBag diagnostics, ErrorCode code, CSharpSyntaxNode syntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10286, 19008, 19217);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 19127, 19206);

                f_10286_19127_19205(diagnostics, f_10286_19143_19204(f_10286_19160_19186(code), f_10286_19188_19203(syntax)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10286, 19008, 19217);

                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10286_19160_19186(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 19160, 19186);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10286_19188_19203(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 19188, 19203);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                f_10286_19143_19204(Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnostic((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 19143, 19204);
                    return return_v;
                }


                int
                f_10286_19127_19205(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                diag)
                {
                    this_param.Add((Microsoft.CodeAnalysis.Diagnostic)diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 19127, 19205);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 19008, 19217);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 19008, 19217);
            }
        }

        internal static void Error(DiagnosticBag diagnostics, ErrorCode code, CSharpSyntaxNode syntax, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10286, 19229, 19466);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 19370, 19455);

                f_10286_19370_19454(diagnostics, f_10286_19386_19453(f_10286_19403_19435(code, args), f_10286_19437_19452(syntax)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10286, 19229, 19466);

                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10286_19403_19435(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 19403, 19435);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10286_19437_19452(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 19437, 19452);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                f_10286_19386_19453(Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnostic((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 19386, 19453);
                    return return_v;
                }


                int
                f_10286_19370_19454(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                diag)
                {
                    this_param.Add((Microsoft.CodeAnalysis.Diagnostic)diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 19370, 19454);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 19229, 19466);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 19229, 19466);
            }
        }

        internal static void Error(DiagnosticBag diagnostics, ErrorCode code, SyntaxToken token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10286, 19478, 19685);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 19591, 19674);

                f_10286_19591_19673(diagnostics, f_10286_19607_19672(f_10286_19624_19650(code), token.GetLocation()));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10286, 19478, 19685);

                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10286_19624_19650(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 19624, 19650);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                f_10286_19607_19672(Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnostic((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 19607, 19672);
                    return return_v;
                }


                int
                f_10286_19591_19673(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                diag)
                {
                    this_param.Add((Microsoft.CodeAnalysis.Diagnostic)diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 19591, 19673);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 19478, 19685);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 19478, 19685);
            }
        }

        internal static void Error(DiagnosticBag diagnostics, ErrorCode code, SyntaxToken token, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10286, 19697, 19932);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 19832, 19921);

                f_10286_19832_19920(diagnostics, f_10286_19848_19919(f_10286_19865_19897(code, args), token.GetLocation()));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10286, 19697, 19932);

                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10286_19865_19897(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 19865, 19897);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                f_10286_19848_19919(Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnostic((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 19848, 19919);
                    return return_v;
                }


                int
                f_10286_19832_19920(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                diag)
                {
                    this_param.Add((Microsoft.CodeAnalysis.Diagnostic)diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 19832, 19920);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 19697, 19932);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 19697, 19932);
            }
        }

        internal static void Error(DiagnosticBag diagnostics, ErrorCode code, SyntaxNodeOrToken syntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10286, 19944, 20213);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 20064, 20100);

                var
                location = syntax.GetLocation()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 20114, 20153);

                f_10286_20114_20152(location is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 20167, 20202);

                f_10286_20167_20201(diagnostics, code, location);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10286, 19944, 20213);

                int
                f_10286_20114_20152(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 20114, 20152);
                    return 0;
                }


                int
                f_10286_20167_20201(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    Error(diagnostics, code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 20167, 20201);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 19944, 20213);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 19944, 20213);
            }
        }

        internal static void Error(DiagnosticBag diagnostics, ErrorCode code, SyntaxNodeOrToken syntax, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10286, 20225, 20522);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 20367, 20403);

                var
                location = syntax.GetLocation()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 20417, 20456);

                f_10286_20417_20455(location is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 20470, 20511);

                f_10286_20470_20510(diagnostics, code, location, args);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10286, 20225, 20522);

                int
                f_10286_20417_20455(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 20417, 20455);
                    return 0;
                }


                int
                f_10286_20470_20510(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    Error(diagnostics, code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 20470, 20510);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 20225, 20522);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 20225, 20522);
            }
        }

        internal static void Error(DiagnosticBag diagnostics, ErrorCode code, Location location)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10286, 20534, 20730);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 20647, 20719);

                f_10286_20647_20718(diagnostics, f_10286_20663_20717(f_10286_20680_20706(code), location));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10286, 20534, 20730);

                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10286_20680_20706(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 20680, 20706);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                f_10286_20663_20717(Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnostic((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 20663, 20717);
                    return return_v;
                }


                int
                f_10286_20647_20718(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                diag)
                {
                    this_param.Add((Microsoft.CodeAnalysis.Diagnostic)diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 20647, 20718);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 20534, 20730);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 20534, 20730);
            }
        }

        internal static void Error(DiagnosticBag diagnostics, ErrorCode code, Location location, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10286, 20742, 20966);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 20877, 20955);

                f_10286_20877_20954(diagnostics, f_10286_20893_20953(f_10286_20910_20942(code, args), location));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10286, 20742, 20966);

                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10286_20910_20942(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 20910, 20942);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                f_10286_20893_20953(Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnostic((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 20893, 20953);
                    return return_v;
                }


                int
                f_10286_20877_20954(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                diag)
                {
                    this_param.Add((Microsoft.CodeAnalysis.Diagnostic)diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 20877, 20954);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 20742, 20966);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 20742, 20966);
            }
        }

        internal void ReportDiagnosticsIfObsolete(DiagnosticBag diagnostics, Symbol symbol, SyntaxNode node, bool hasBaseReceiver)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10286, 21462, 21711);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 21609, 21700);

                f_10286_21609_21699(this, diagnostics, symbol, node, hasBaseReceiver);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10286, 21462, 21711);

                int
                f_10286_21609_21699(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                node, bool
                hasBaseReceiver)
                {
                    this_param.ReportDiagnosticsIfObsolete(diagnostics, symbol, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)node, hasBaseReceiver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 21609, 21699);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 21462, 21711);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 21462, 21711);
            }
        }

        internal void ReportDiagnosticsIfObsolete(DiagnosticBag diagnostics, Symbol symbol, SyntaxNodeOrToken node, bool hasBaseReceiver)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10286, 22002, 22611);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 22156, 22600);

                switch (f_10286_22164_22175(symbol))
                {

                    case SymbolKind.NamedType:
                    case SymbolKind.Field:
                    case SymbolKind.Method:
                    case SymbolKind.Event:
                    case SymbolKind.Property:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10286, 22156, 22600);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 22421, 22557);

                        f_10286_22421_22556(diagnostics, symbol, node, hasBaseReceiver, f_10286_22493_22522(this), f_10286_22524_22543(this), this.Flags);
                        DynAbs.Tracing.TraceSender.TraceBreak(10286, 22579, 22585);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10286, 22156, 22600);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10286, 22002, 22611);

                Microsoft.CodeAnalysis.SymbolKind
                f_10286_22164_22175(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 22164, 22175);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10286_22493_22522(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.ContainingMemberOrLambda;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 22493, 22522);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10286_22524_22543(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 22524, 22543);
                    return return_v;
                }


                int
                f_10286_22421_22556(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.SyntaxNodeOrToken
                node, bool
                hasBaseReceiver, Microsoft.CodeAnalysis.CSharp.Symbol?
                containingMember, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                containingType, Microsoft.CodeAnalysis.CSharp.BinderFlags
                location)
                {
                    ReportDiagnosticsIfObsolete(diagnostics, symbol, node, hasBaseReceiver, containingMember, containingType, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 22421, 22556);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 22002, 22611);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 22002, 22611);
            }
        }

        internal void ReportDiagnosticsIfObsolete(DiagnosticBag diagnostics, Conversion conversion, SyntaxNodeOrToken node, bool hasBaseReceiver)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10286, 22623, 22981);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 22785, 22970) || true) && (conversion.IsValid && (DynAbs.Tracing.TraceSender.Expression_True(10286, 22789, 22838) && conversion.Method is object))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10286, 22785, 22970);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 22872, 22955);

                    f_10286_22872_22954(this, diagnostics, conversion.Method, node, hasBaseReceiver);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10286, 22785, 22970);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10286, 22623, 22981);

                int
                f_10286_22872_22954(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNodeOrToken
                node, bool
                hasBaseReceiver)
                {
                    this_param.ReportDiagnosticsIfObsolete(diagnostics, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol, node, hasBaseReceiver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 22872, 22954);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 22623, 22981);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 22623, 22981);
            }
        }

        internal static void ReportDiagnosticsIfObsolete(
                    DiagnosticBag diagnostics,
                    Symbol symbol,
                    SyntaxNodeOrToken node,
                    bool hasBaseReceiver,
                    Symbol? containingMember,
                    NamedTypeSymbol? containingType,
                    BinderFlags location)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10286, 22993, 26823);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 23327, 23364);

                f_10286_23327_23363(symbol is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 23380, 23684);

                f_10286_23380_23683(f_10286_23399_23410(symbol) == SymbolKind.NamedType || (DynAbs.Tracing.TraceSender.Expression_False(10286, 23399, 23495) || f_10286_23464_23475(symbol) == SymbolKind.Field) || (DynAbs.Tracing.TraceSender.Expression_False(10286, 23399, 23557) || f_10286_23525_23536(symbol) == SymbolKind.Method) || (DynAbs.Tracing.TraceSender.Expression_False(10286, 23399, 23618) || f_10286_23587_23598(symbol) == SymbolKind.Event) || (DynAbs.Tracing.TraceSender.Expression_False(10286, 23399, 23682) || f_10286_23648_23659(symbol) == SymbolKind.Property));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 23893, 24026) || true) && (f_10286_23897_23908(symbol) == SymbolKind.Method)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10286, 23893, 24026);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 23963, 24011);

                    symbol = f_10286_23972_24010(((MethodSymbol)symbol));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10286, 23893, 24026);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 24450, 24529);

                Symbol
                leastOverriddenSymbol = f_10286_24481_24528(symbol, containingType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 24545, 24641);

                bool
                checkOverridingSymbol = hasBaseReceiver && (DynAbs.Tracing.TraceSender.Expression_True(10286, 24574, 24640) && !f_10286_24594_24640(symbol, leastOverriddenSymbol))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 24655, 25349) || true) && (checkOverridingSymbol)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10286, 24655, 25349);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 25296, 25334);

                    f_10286_25296_25333(                // If we have a base receiver, we must be done with declaration binding, so it should
                                                        // be safe to decode diagnostics.  We want to do this since reporting for the overriding
                                                        // member is conditional on reporting for the overridden member (i.e. we need a definite
                                                        // answer so we don't double-report).  You might think that double reporting just results
                                                        // in cascading diagnostics, but it's possible that the second diagnostic is an error
                                                        // while the first is merely a warning.
                                    leastOverriddenSymbol);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10286, 24655, 25349);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 25365, 25492);

                var
                diagnosticKind = f_10286_25386_25491(diagnostics, leastOverriddenSymbol, node, containingMember, location)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 26281, 26812);

                switch (diagnosticKind)
                {

                    case ObsoleteDiagnosticKind.NotObsolete:
                    case ObsoleteDiagnosticKind.Lazy:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10286, 26281, 26812);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 26450, 26769) || true) && (checkOverridingSymbol)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10286, 26450, 26769);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 26525, 26629);

                            f_10286_26525_26628(diagnosticKind != ObsoleteDiagnosticKind.Lazy, "We forced attribute binding above.");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 26655, 26746);

                            f_10286_26655_26745(diagnostics, symbol, node, containingMember, location);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10286, 26450, 26769);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10286, 26791, 26797);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10286, 26281, 26812);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10286, 22993, 26823);

                int
                f_10286_23327_23363(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 23327, 23363);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10286_23399_23410(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 23399, 23410);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10286_23464_23475(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 23464, 23475);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10286_23525_23536(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 23525, 23536);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10286_23587_23598(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 23587, 23598);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10286_23648_23659(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 23648, 23659);
                    return return_v;
                }


                int
                f_10286_23380_23683(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 23380, 23683);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10286_23897_23908(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 23897, 23908);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10286_23972_24010(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ConstructedFrom;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 23972, 24010);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10286_24481_24528(Microsoft.CodeAnalysis.CSharp.Symbol
                member, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                accessingTypeOpt)
                {
                    var return_v = member.GetLeastOverriddenMember(accessingTypeOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 24481, 24528);
                    return return_v;
                }


                bool
                f_10286_24594_24640(Microsoft.CodeAnalysis.CSharp.Symbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 24594, 24640);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10286_25296_25333(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 25296, 25333);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ObsoleteDiagnosticKind
                f_10286_25386_25491(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.SyntaxNodeOrToken
                node, Microsoft.CodeAnalysis.CSharp.Symbol?
                containingMember, Microsoft.CodeAnalysis.CSharp.BinderFlags
                location)
                {
                    var return_v = ReportDiagnosticsIfObsoleteInternal(diagnostics, symbol, node, containingMember, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 25386, 25491);
                    return return_v;
                }


                int
                f_10286_26525_26628(bool
                b, string
                message)
                {
                    RoslynDebug.Assert(b, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 26525, 26628);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ObsoleteDiagnosticKind
                f_10286_26655_26745(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.SyntaxNodeOrToken
                node, Microsoft.CodeAnalysis.CSharp.Symbol?
                containingMember, Microsoft.CodeAnalysis.CSharp.BinderFlags
                location)
                {
                    var return_v = ReportDiagnosticsIfObsoleteInternal(diagnostics, symbol, node, containingMember, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 26655, 26745);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 22993, 26823);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 22993, 26823);
            }
        }

        internal static ObsoleteDiagnosticKind ReportDiagnosticsIfObsoleteInternal(DiagnosticBag diagnostics, Symbol symbol, SyntaxNodeOrToken node, Symbol? containingMember, BinderFlags location)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10286, 26835, 27884);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 27048, 27088);

                f_10286_27048_27087(diagnostics != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 27104, 27192);

                var
                kind = f_10286_27115_27191(symbol, containingMember)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 27208, 27236);

                DiagnosticInfo?
                info = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 27250, 27722);

                switch (kind)
                {

                    case ObsoleteDiagnosticKind.Diagnostic:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10286, 27250, 27722);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 27357, 27432);

                        info = f_10286_27364_27431(symbol, location);
                        DynAbs.Tracing.TraceSender.TraceBreak(10286, 27454, 27460);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10286, 27250, 27722);

                    case ObsoleteDiagnosticKind.Lazy:
                    case ObsoleteDiagnosticKind.LazyPotentiallySuppressed:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10286, 27250, 27722);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 27605, 27679);

                        info = f_10286_27612_27678(symbol, containingMember, location);
                        DynAbs.Tracing.TraceSender.TraceBreak(10286, 27701, 27707);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10286, 27250, 27722);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 27738, 27845) || true) && (info != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10286, 27738, 27845);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 27788, 27830);

                    f_10286_27788_27829(diagnostics, info, node.GetLocation());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10286, 27738, 27845);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 27861, 27873);

                return kind;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10286, 26835, 27884);

                int
                f_10286_27048_27087(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 27048, 27087);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ObsoleteDiagnosticKind
                f_10286_27115_27191(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.CSharp.Symbol?
                containingMember)
                {
                    var return_v = ObsoleteAttributeHelpers.GetObsoleteDiagnosticKind(symbol, containingMember);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 27115, 27191);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10286_27364_27431(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.CSharp.BinderFlags
                location)
                {
                    var return_v = ObsoleteAttributeHelpers.CreateObsoleteDiagnostic(symbol, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 27364, 27431);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LazyObsoleteDiagnosticInfo
                f_10286_27612_27678(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.CSharp.Symbol?
                containingSymbol, Microsoft.CodeAnalysis.CSharp.BinderFlags
                binderFlags)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.LazyObsoleteDiagnosticInfo((object)symbol, containingSymbol, binderFlags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 27612, 27678);
                    return return_v;
                }


                int
                f_10286_27788_27829(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.DiagnosticInfo
                info, Microsoft.CodeAnalysis.Location?
                location)
                {
                    diagnostics.Add(info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 27788, 27829);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 26835, 27884);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 26835, 27884);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void ReportDiagnosticsIfUnmanagedCallersOnly(DiagnosticBag diagnostics, MethodSymbol symbol, Location location, bool isDelegateConversion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10286, 27896, 29280);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 28075, 28181);

                var
                unmanagedCallersOnlyAttributeData = f_10286_28115_28180(symbol, forceComplete: false)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 28195, 29269) || true) && (unmanagedCallersOnlyAttributeData != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10286, 28195, 29269);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 28554, 29254);

                    f_10286_28554_29253(                // Either we haven't yet bound the attributes of this method, or there is an UnmanagedCallersOnly present.
                                                        // In the former case, we use a lazy diagnostic that may end up being ignored later, to avoid causing a
                                                        // binding cycle.
                                    diagnostics, (DynAbs.Tracing.TraceSender.Conditional_F1(10286, 28570, 28654) || ((unmanagedCallersOnlyAttributeData == UnmanagedCallersOnlyAttributeData.Uninitialized
                    && DynAbs.Tracing.TraceSender.Conditional_F2(10286, 28694, 28794)) || DynAbs.Tracing.TraceSender.Conditional_F3(10286, 28834, 29209))) ? (DiagnosticInfo)f_10286_28710_28794(symbol, isDelegateConversion) : f_10286_28834_29209((DynAbs.Tracing.TraceSender.Conditional_F1(10286, 28855, 28875) || ((isDelegateConversion
                    && DynAbs.Tracing.TraceSender.Conditional_F2(10286, 28942, 29010)) || DynAbs.Tracing.TraceSender.Conditional_F3(10286, 29077, 29140))) ? ErrorCode.ERR_UnmanagedCallersOnlyMethodsCannotBeConvertedToDelegate
                    : ErrorCode.ERR_UnmanagedCallersOnlyMethodsCannotBeCalledDirectly, symbol), location);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10286, 28195, 29269);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10286, 27896, 29280);

                Microsoft.CodeAnalysis.UnmanagedCallersOnlyAttributeData?
                f_10286_28115_28180(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, bool
                forceComplete)
                {
                    var return_v = this_param.GetUnmanagedCallersOnlyAttributeData(forceComplete: forceComplete);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 28115, 28180);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LazyUnmanagedCallersOnlyMethodCalledDiagnosticInfo
                f_10286_28710_28794(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, bool
                isDelegateConversion)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.LazyUnmanagedCallersOnlyMethodCalledDiagnosticInfo(method, isDelegateConversion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 28710, 28794);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10286_28834_29209(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 28834, 29209);
                    return return_v;
                }


                int
                f_10286_28554_29253(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.DiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    diagnostics.Add(info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 28554, 29253);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 27896, 29280);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 27896, 29280);
            }
        }

        internal static bool IsSymbolAccessibleConditional(
                    Symbol symbol,
                    AssemblySymbol within,
                    ref HashSet<DiagnosticInfo>? useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10286, 29292, 29583);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 29494, 29572);

                return f_10286_29501_29571(symbol, within, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10286, 29292, 29583);

                bool
                f_10286_29501_29571(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                within, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = AccessCheck.IsSymbolAccessible(symbol, within, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 29501, 29571);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 29292, 29583);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 29292, 29583);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsSymbolAccessibleConditional(
                    Symbol symbol,
                    NamedTypeSymbol within,
                    ref HashSet<DiagnosticInfo>? useSiteDiagnostics,
                    TypeSymbol? throughTypeOpt = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10286, 29595, 30000);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 29839, 29989);

                return f_10286_29846_29898(this.Flags, BinderFlags.IgnoreAccessibility) || (DynAbs.Tracing.TraceSender.Expression_False(10286, 29846, 29988) || f_10286_29902_29988(symbol, within, ref useSiteDiagnostics, throughTypeOpt));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10286, 29595, 30000);

                bool
                f_10286_29846_29898(Microsoft.CodeAnalysis.CSharp.BinderFlags
                self, Microsoft.CodeAnalysis.CSharp.BinderFlags
                other)
                {
                    var return_v = self.Includes(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 29846, 29898);
                    return return_v;
                }


                bool
                f_10286_29902_29988(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                within, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                throughTypeOpt)
                {
                    var return_v = AccessCheck.IsSymbolAccessible(symbol, within, ref useSiteDiagnostics, throughTypeOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 29902, 29988);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 29595, 30000);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 29595, 30000);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsSymbolAccessibleConditional(
                    Symbol symbol,
                    NamedTypeSymbol within,
                    TypeSymbol throughTypeOpt,
                    out bool failedThroughTypeCheck,
                    ref HashSet<DiagnosticInfo>? useSiteDiagnostics,
                    ConsList<TypeSymbol>? basesBeingResolved = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10286, 30012, 30691);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 30356, 30522) || true) && (f_10286_30360_30412(this.Flags, BinderFlags.IgnoreAccessibility))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10286, 30356, 30522);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 30446, 30477);

                    failedThroughTypeCheck = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 30495, 30507);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10286, 30356, 30522);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 30538, 30680);

                return f_10286_30545_30679(symbol, within, throughTypeOpt, out failedThroughTypeCheck, ref useSiteDiagnostics, basesBeingResolved);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10286, 30012, 30691);

                bool
                f_10286_30360_30412(Microsoft.CodeAnalysis.CSharp.BinderFlags
                self, Microsoft.CodeAnalysis.CSharp.BinderFlags
                other)
                {
                    var return_v = self.Includes(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 30360, 30412);
                    return return_v;
                }


                bool
                f_10286_30545_30679(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                within, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                throughTypeOpt, out bool
                failedThroughTypeCheck, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
                basesBeingResolved)
                {
                    var return_v = AccessCheck.IsSymbolAccessible(symbol, within, throughTypeOpt, out failedThroughTypeCheck, ref useSiteDiagnostics, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 30545, 30679);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 30012, 30691);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 30012, 30691);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void ReportUseSiteDiagnosticForSynthesizedAttribute(
                    CSharpCompilation compilation,
                    WellKnownMember attributeMember,
                    DiagnosticBag diagnostics,
                    Location? location = null,
                    CSharpSyntaxNode? syntax = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10286, 30843, 31721);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 31152, 31210);

                f_10286_31152_31209((location != null) ^ (syntax != null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 31515, 31598);

                bool
                isOptional = f_10286_31533_31597(attributeMember)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 31614, 31710);

                f_10286_31614_31709(compilation, attributeMember, diagnostics, location, syntax, isOptional);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10286, 30843, 31721);

                int
                f_10286_31152_31209(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 31152, 31209);
                    return 0;
                }


                bool
                f_10286_31533_31597(Microsoft.CodeAnalysis.WellKnownMember
                attributeMember)
                {
                    var return_v = WellKnownMembers.IsSynthesizedAttributeOptional(attributeMember);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 31533, 31597);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10286_31614_31709(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.WellKnownMember
                member, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location?
                location, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                syntax, bool
                isOptional)
                {
                    var return_v = GetWellKnownTypeMember(compilation, member, diagnostics, location, (Microsoft.CodeAnalysis.SyntaxNode?)syntax, isOptional);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 31614, 31709);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 30843, 31721);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 30843, 31721);
            }
        }

        internal Binder[] GetAllBinders()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10286, 31821, 32132);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 31879, 31928);

                var
                binders = f_10286_31893_31927()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 31955, 31968);
                    for (Binder?
        binder = this
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 31942, 32075) || true) && (binder != null)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 31986, 32006)
        , binder = f_10286_31995_32006(binder), DynAbs.Tracing.TraceSender.TraceExitCondition(10286, 31942, 32075))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10286, 31942, 32075);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 32040, 32060);

                        f_10286_32040_32059(binders, binder);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10286, 1, 134);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10286, 1, 134);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 32089, 32121);

                return f_10286_32096_32120(binders);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10286, 31821, 32132);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder>
                f_10286_31893_31927()
                {
                    var return_v = ArrayBuilder<Binder>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 31893, 31927);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10286_31995_32006(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Next;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 31995, 32006);
                    return return_v;
                }


                int
                f_10286_32040_32059(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder>
                this_param, Microsoft.CodeAnalysis.CSharp.Binder
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 32040, 32059);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Binder[]
                f_10286_32096_32120(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder>
                this_param)
                {
                    var return_v = this_param.ToArrayAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 32096, 32120);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 31821, 32132);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 31821, 32132);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal BoundExpression WrapWithVariablesIfAny(CSharpSyntaxNode scopeDesignator, BoundExpression expression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10286, 32152, 32753);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 32286, 32347);

                var
                locals = f_10286_32299_32346(this, scopeDesignator)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 32361, 32571);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10286, 32368, 32384) || (((locals.IsEmpty)
                && DynAbs.Tracing.TraceSender.Conditional_F2(10286, 32404, 32414)) || DynAbs.Tracing.TraceSender.Conditional_F3(10286, 32434, 32570))) ? expression
                : new BoundSequence(scopeDesignator, locals, ImmutableArray<BoundExpression>.Empty, expression, f_10286_32528_32537()) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10286, 32434, 32570) };

                TypeSymbol getType()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10286, 32587, 32742);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 32640, 32686);

                        f_10286_32640_32685(f_10286_32659_32674(expression) is object);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 32704, 32727);

                        return f_10286_32711_32726(expression);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10286, 32587, 32742);

                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                        f_10286_32659_32674(Microsoft.CodeAnalysis.CSharp.BoundExpression
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 32659, 32674);
                            return return_v;
                        }


                        int
                        f_10286_32640_32685(bool
                        b)
                        {
                            RoslynDebug.Assert(b);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 32640, 32685);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        f_10286_32711_32726(Microsoft.CodeAnalysis.CSharp.BoundExpression
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 32711, 32726);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 32587, 32742);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 32587, 32742);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10286, 32152, 32753);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10286_32299_32346(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                scopeDesignator)
                {
                    var return_v = this_param.GetDeclaredLocalsForScope((Microsoft.CodeAnalysis.SyntaxNode)scopeDesignator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 32299, 32346);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10286_32528_32537()
                {
                    var return_v = getType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 32528, 32537);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 32152, 32753);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 32152, 32753);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal BoundStatement WrapWithVariablesIfAny(CSharpSyntaxNode scopeDesignator, BoundStatement statement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10286, 32765, 33285);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 32896, 32958);

                f_10286_32896_32957(f_10286_32915_32929(statement) != BoundKind.StatementList);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 32972, 33033);

                var
                locals = f_10286_32985_33032(this, scopeDesignator)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 33047, 33131) || true) && (locals.IsEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10286, 33047, 33131);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 33099, 33116);

                    return statement;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10286, 33047, 33131);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 33147, 33274);

                return new BoundBlock(statement.Syntax, locals, f_10286_33195_33227(statement))
                { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10286, 33154, 33273) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10286, 32765, 33285);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10286_32915_32929(Microsoft.CodeAnalysis.CSharp.BoundStatement
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 32915, 32929);
                    return return_v;
                }


                int
                f_10286_32896_32957(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 32896, 32957);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10286_32985_33032(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                scopeDesignator)
                {
                    var return_v = this_param.GetDeclaredLocalsForScope((Microsoft.CodeAnalysis.SyntaxNode)scopeDesignator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 32985, 33032);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10286_33195_33227(Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 33195, 33227);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 32765, 33285);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 32765, 33285);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal BoundStatement WrapWithVariablesAndLocalFunctionsIfAny(CSharpSyntaxNode scopeDesignator, BoundStatement statement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10286, 33425, 34054);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 33573, 33634);

                var
                locals = f_10286_33586_33633(this, scopeDesignator)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 33648, 33725);

                var
                localFunctions = f_10286_33669_33724(this, scopeDesignator)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 33739, 33849) || true) && (locals.IsEmpty && (DynAbs.Tracing.TraceSender.Expression_True(10286, 33743, 33783) && localFunctions.IsEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10286, 33739, 33849);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 33817, 33834);

                    return statement;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10286, 33739, 33849);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 33865, 34043);

                return new BoundBlock(statement.Syntax, locals, localFunctions,
                f_10286_33964_33996(statement))
                { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10286, 33872, 34042) };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10286, 33425, 34054);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10286_33586_33633(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                scopeDesignator)
                {
                    var return_v = this_param.GetDeclaredLocalsForScope((Microsoft.CodeAnalysis.SyntaxNode)scopeDesignator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 33586, 33633);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                f_10286_33669_33724(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                scopeDesignator)
                {
                    var return_v = this_param.GetDeclaredLocalFunctionsForScope(scopeDesignator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 33669, 33724);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10286_33964_33996(Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 33964, 33996);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 33425, 34054);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 33425, 34054);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string Dump()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10286, 34066, 36901);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 34113, 34160);

                return f_10286_34120_34159(f_10286_34143_34158());

                TreeDumperNode dumpAncestors()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10286, 34176, 35686);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 34239, 34270);

                        TreeDumperNode?
                        current = null
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 34303, 34315);

                            for (Binder?
            scope = this
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 34290, 35580) || true) && (scope != null)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 34332, 34350)
            , scope = f_10286_34340_34350(scope), DynAbs.Tracing.TraceSender.TraceExitCondition(10286, 34290, 35580))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10286, 34290, 35580);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 34392, 34442);

                                var (description, snippet, locals) = f_10286_34429_34441(scope);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 34464, 34501);

                                var
                                sub = f_10286_34474_34500()
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 34523, 34669) || true) && (!f_10286_34528_34544(locals))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10286, 34523, 34669);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 34594, 34646);

                                    f_10286_34594_34645(sub, f_10286_34602_34644("locals", locals, null));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10286, 34523, 34669);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 34691, 34745);

                                var
                                currentContainer = f_10286_34714_34744(scope)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 34767, 35019) || true) && (currentContainer != null && (DynAbs.Tracing.TraceSender.Expression_True(10286, 34771, 34855) && currentContainer != f_10286_34819_34855_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10286_34819_34829(scope), 10286, 34819, 34855)?.ContainingMemberOrLambda)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10286, 34767, 35019);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 34905, 34996);

                                    f_10286_34905_34995(sub, f_10286_34913_34994("containing symbol", f_10286_34953_34987(currentContainer), null));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10286, 34767, 35019);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 35041, 35355) || true) && (snippet != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10286, 35041, 35355);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 35145, 35239);

                                    var
                                    temp = (DynAbs.Tracing.TraceSender.Conditional_F1(10286, 35156, 35185) || ((f_10286_35156_35177(scope) != null && DynAbs.Tracing.TraceSender.Conditional_F2(10286, 35188, 35216)) || DynAbs.Tracing.TraceSender.Conditional_F3(10286, 35219, 35238))) ? f_10286_35188_35216(f_10286_35188_35209(scope)) : default(SyntaxKind)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 35265, 35332);

                                    f_10286_35265_35331(sub, f_10286_35273_35330($"scope", $"{snippet} ({temp})", null));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10286, 35041, 35355);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 35377, 35486) || true) && (current != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10286, 35377, 35486);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 35446, 35463);

                                    f_10286_35446_35462(sub, current);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10286, 35377, 35486);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 35508, 35561);

                                current = f_10286_35518_35560(description, null, sub);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10286, 1, 1291);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10286, 1, 1291);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 35600, 35638);

                        f_10286_35600_35637(current is object);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 35656, 35671);

                        return current;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10286, 34176, 35686);

                        Microsoft.CodeAnalysis.CSharp.Binder?
                        f_10286_34340_34350(Microsoft.CodeAnalysis.CSharp.Binder
                        this_param)
                        {
                            var return_v = this_param.Next;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 34340, 34350);
                            return return_v;
                        }


                        (string description, string? snippet, string locals)
                        f_10286_34429_34441(Microsoft.CodeAnalysis.CSharp.Binder
                        scope)
                        {
                            var return_v = print(scope);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 34429, 34441);
                            return return_v;
                        }


                        System.Collections.Generic.List<Microsoft.CodeAnalysis.TreeDumperNode>
                        f_10286_34474_34500()
                        {
                            var return_v = new System.Collections.Generic.List<Microsoft.CodeAnalysis.TreeDumperNode>();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 34474, 34500);
                            return return_v;
                        }


                        bool
                        f_10286_34528_34544(string
                        source)
                        {
                            var return_v = source.IsEmpty();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 34528, 34544);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.TreeDumperNode
                        f_10286_34602_34644(string
                        text, string
                        value, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.TreeDumperNode>?
                        children)
                        {
                            var return_v = new Microsoft.CodeAnalysis.TreeDumperNode(text, (object)value, children);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 34602, 34644);
                            return return_v;
                        }


                        int
                        f_10286_34594_34645(System.Collections.Generic.List<Microsoft.CodeAnalysis.TreeDumperNode>
                        this_param, Microsoft.CodeAnalysis.TreeDumperNode
                        item)
                        {
                            this_param.Add(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 34594, 34645);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbol?
                        f_10286_34714_34744(Microsoft.CodeAnalysis.CSharp.Binder
                        this_param)
                        {
                            var return_v = this_param.ContainingMemberOrLambda;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 34714, 34744);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Binder?
                        f_10286_34819_34829(Microsoft.CodeAnalysis.CSharp.Binder
                        this_param)
                        {
                            var return_v = this_param.Next;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 34819, 34829);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbol?
                        f_10286_34819_34855_M(Microsoft.CodeAnalysis.CSharp.Symbol?
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 34819, 34855);
                            return return_v;
                        }


                        string
                        f_10286_34953_34987(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.ToDisplayString();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 34953, 34987);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.TreeDumperNode
                        f_10286_34913_34994(string
                        text, string
                        value, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.TreeDumperNode>?
                        children)
                        {
                            var return_v = new Microsoft.CodeAnalysis.TreeDumperNode(text, (object)value, children);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 34913, 34994);
                            return return_v;
                        }


                        int
                        f_10286_34905_34995(System.Collections.Generic.List<Microsoft.CodeAnalysis.TreeDumperNode>
                        this_param, Microsoft.CodeAnalysis.TreeDumperNode
                        item)
                        {
                            this_param.Add(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 34905, 34995);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.SyntaxNode?
                        f_10286_35156_35177(Microsoft.CodeAnalysis.CSharp.Binder
                        this_param)
                        {
                            var return_v = this_param.ScopeDesignator;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 35156, 35177);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SyntaxNode
                        f_10286_35188_35209(Microsoft.CodeAnalysis.CSharp.Binder
                        this_param)
                        {
                            var return_v = this_param.ScopeDesignator;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 35188, 35209);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.SyntaxKind
                        f_10286_35188_35216(Microsoft.CodeAnalysis.SyntaxNode
                        node)
                        {
                            var return_v = node.Kind();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 35188, 35216);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.TreeDumperNode
                        f_10286_35273_35330(string
                        text, string
                        value, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.TreeDumperNode>?
                        children)
                        {
                            var return_v = new Microsoft.CodeAnalysis.TreeDumperNode(text, (object)value, children);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 35273, 35330);
                            return return_v;
                        }


                        int
                        f_10286_35265_35331(System.Collections.Generic.List<Microsoft.CodeAnalysis.TreeDumperNode>
                        this_param, Microsoft.CodeAnalysis.TreeDumperNode
                        item)
                        {
                            this_param.Add(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 35265, 35331);
                            return 0;
                        }


                        int
                        f_10286_35446_35462(System.Collections.Generic.List<Microsoft.CodeAnalysis.TreeDumperNode>
                        this_param, Microsoft.CodeAnalysis.TreeDumperNode
                        item)
                        {
                            this_param.Add(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 35446, 35462);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.TreeDumperNode
                        f_10286_35518_35560(string
                        text, object?
                        value, System.Collections.Generic.List<Microsoft.CodeAnalysis.TreeDumperNode>
                        children)
                        {
                            var return_v = new Microsoft.CodeAnalysis.TreeDumperNode(text, value, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.TreeDumperNode>)children);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 35518, 35560);
                            return return_v;
                        }


                        int
                        f_10286_35600_35637(bool
                        b)
                        {
                            RoslynDebug.Assert(b);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 35600, 35637);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 34176, 35686);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 34176, 35686);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                static (string description, string? snippet, string locals) print(Binder scope)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10286, 35702, 36890);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 35814, 35886);

                        var
                        locals = f_10286_35827_35885(", ", scope.Locals.SelectAsArray(s => s.Name))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 35904, 35927);

                        string?
                        snippet = null
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 35945, 36760) || true) && (f_10286_35949_35970(scope) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10286, 35945, 36760);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 36020, 36141);

                            var
                            lines = f_10286_36032_36140(f_10286_36032_36064(f_10286_36032_36053(scope)), new[] { f_10286_36079_36098() }, StringSplitOptions.RemoveEmptyEntries)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 36163, 36674) || true) && (f_10286_36167_36179(lines) == 1)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10286, 36163, 36674);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 36234, 36253);

                                snippet = lines[0];
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10286, 36163, 36674);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10286, 36163, 36674);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 36351, 36372);

                                var
                                first = lines[0]
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 36398, 36440);

                                var
                                last = f_10286_36409_36439(lines[f_10286_36415_36427(lines) - 1])
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 36466, 36507);

                                var
                                lastSize = f_10286_36481_36506(f_10286_36490_36501(last), 12)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 36533, 36651);

                                snippet = f_10286_36543_36589(first, 0, f_10286_36562_36588(f_10286_36571_36583(first), 12)) + " ... " + f_10286_36602_36650(last, f_10286_36617_36628(last) - lastSize, lastSize);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10286, 36163, 36674);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 36696, 36741);

                            snippet = (DynAbs.Tracing.TraceSender.Conditional_F1(10286, 36706, 36723) || ((f_10286_36706_36723(snippet) && DynAbs.Tracing.TraceSender.Conditional_F2(10286, 36726, 36730)) || DynAbs.Tracing.TraceSender.Conditional_F3(10286, 36733, 36740))) ? null : snippet;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10286, 35945, 36760);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 36780, 36819);

                        var
                        description = f_10286_36798_36818(f_10286_36798_36813(scope))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10286, 36837, 36875);

                        return (description, snippet, locals);
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10286, 35702, 36890);

                        string
                        f_10286_35827_35885(string
                        separator, System.Collections.Immutable.ImmutableArray<string>
                        values)
                        {
                            var return_v = string.Join(separator, (System.Collections.Generic.IEnumerable<string?>)values);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 35827, 35885);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SyntaxNode?
                        f_10286_35949_35970(Microsoft.CodeAnalysis.CSharp.Binder
                        this_param)
                        {
                            var return_v = this_param.ScopeDesignator;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 35949, 35970);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SyntaxNode
                        f_10286_36032_36053(Microsoft.CodeAnalysis.CSharp.Binder
                        this_param)
                        {
                            var return_v = this_param.ScopeDesignator;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 36032, 36053);
                            return return_v;
                        }


                        string
                        f_10286_36032_36064(Microsoft.CodeAnalysis.SyntaxNode
                        this_param)
                        {
                            var return_v = this_param.ToString();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 36032, 36064);
                            return return_v;
                        }


                        string
                        f_10286_36079_36098()
                        {
                            var return_v = Environment.NewLine;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 36079, 36098);
                            return return_v;
                        }


                        string[]
                        f_10286_36032_36140(string
                        this_param, string[]
                        separator, System.StringSplitOptions
                        options)
                        {
                            var return_v = this_param.Split(separator, options);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 36032, 36140);
                            return return_v;
                        }


                        int
                        f_10286_36167_36179(string[]
                        this_param)
                        {
                            var return_v = this_param.Length;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 36167, 36179);
                            return return_v;
                        }


                        int
                        f_10286_36415_36427(string[]
                        this_param)
                        {
                            var return_v = this_param.Length;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 36415, 36427);
                            return return_v;
                        }


                        string
                        f_10286_36409_36439(string
                        this_param)
                        {
                            var return_v = this_param.Trim();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 36409, 36439);
                            return return_v;
                        }


                        int
                        f_10286_36490_36501(string
                        this_param)
                        {
                            var return_v = this_param.Length;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 36490, 36501);
                            return return_v;
                        }


                        int
                        f_10286_36481_36506(int
                        val1, int
                        val2)
                        {
                            var return_v = Math.Min(val1, val2);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 36481, 36506);
                            return return_v;
                        }


                        int
                        f_10286_36571_36583(string
                        this_param)
                        {
                            var return_v = this_param.Length;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 36571, 36583);
                            return return_v;
                        }


                        int
                        f_10286_36562_36588(int
                        val1, int
                        val2)
                        {
                            var return_v = Math.Min(val1, val2);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 36562, 36588);
                            return return_v;
                        }


                        string
                        f_10286_36543_36589(string
                        this_param, int
                        startIndex, int
                        length)
                        {
                            var return_v = this_param.Substring(startIndex, length);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 36543, 36589);
                            return return_v;
                        }


                        int
                        f_10286_36617_36628(string
                        this_param)
                        {
                            var return_v = this_param.Length;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 36617, 36628);
                            return return_v;
                        }


                        string
                        f_10286_36602_36650(string
                        this_param, int
                        startIndex, int
                        length)
                        {
                            var return_v = this_param.Substring(startIndex, length);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 36602, 36650);
                            return return_v;
                        }


                        bool
                        f_10286_36706_36723(string
                        source)
                        {
                            var return_v = source.IsEmpty();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 36706, 36723);
                            return return_v;
                        }


                        System.Type
                        f_10286_36798_36813(Microsoft.CodeAnalysis.CSharp.Binder
                        this_param)
                        {
                            var return_v = this_param.GetType();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 36798, 36813);
                            return return_v;
                        }


                        string
                        f_10286_36798_36818(System.Type
                        this_param)
                        {
                            var return_v = this_param.Name;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 36798, 36818);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 35702, 36890);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 35702, 36890);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10286, 34066, 36901);

                Microsoft.CodeAnalysis.TreeDumperNode
                f_10286_34143_34158()
                {
                    var return_v = dumpAncestors();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 34143, 34158);
                    return return_v;
                }


                string
                f_10286_34120_34159(Microsoft.CodeAnalysis.TreeDumperNode
                root)
                {
                    var return_v = TreeDumper.DumpCompact(root);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 34120, 34159);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10286, 34066, 36901);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 34066, 36901);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static Binder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10286, 680, 36908);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 1704, 1721);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 1752, 1769);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 1963, 1993);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10292, 2032, 2129);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10306, 388923, 389344);
            s_isIndexedPropertyWithNonOptionalArguments = property =>
            {
                if (property.IsIndexer || !property.IsIndexedProperty)
                {
                    return false;
                }

                Debug.Assert(property.ParameterCount > 0);
                var parameter = property.Parameters[0];
                return !parameter.IsOptional && !parameter.IsParams;
            }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10306, 389401, 389840);
            // LAFHIS
            s_propertyGroupFormat = new SymbolDisplayFormat(globalNamespaceStyle: SymbolDisplayGlobalNamespaceStyle.Omitted, memberOptions:
                                SymbolDisplayMemberOptions.IncludeContainingType, miscellaneousOptions:
                                SymbolDisplayMiscellaneousOptions.EscapeKeywordIdentifiers |
                                SymbolDisplayMiscellaneousOptions.UseSpecialTypes);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10306, 389048, 389450);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10310, 84458, 84496);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 772, 830);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 69620, 69663);
            s_toMethodSymbolFunc = s => (MethodSymbol)s; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10319, 69727, 69774);
            s_toPropertySymbolFunc = s => (PropertySymbol)s; DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10286, 680, 36908);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10286, 680, 36908);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10286, 680, 36908);

        int
        f_10286_994_1033(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 994, 1033);
            return 0;
        }


        int
        f_10286_1048_1095(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 1048, 1095);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        f_10286_1123_1142(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param)
        {
            var return_v = this_param.Options;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 1123, 1142);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.BinderFlags
        f_10286_1123_1162(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param)
        {
            var return_v = this_param.TopLevelBinderFlags;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 1123, 1162);
            return return_v;
        }


        int
        f_10286_1317_1349(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 1317, 1349);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_10286_1447_1463(Microsoft.CodeAnalysis.CSharp.Binder
        this_param)
        {
            var return_v = this_param.Compilation;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 1447, 1463);
            return return_v;
        }


        int
        f_10286_1605_1637(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 1605, 1637);
            return 0;
        }


        bool
        f_10286_1708_1779(Microsoft.CodeAnalysis.CSharp.BinderFlags
        self, Microsoft.CodeAnalysis.CSharp.BinderFlags
        other)
        {
            var return_v = self.Includes(other);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 1708, 1779);
            return return_v;
        }


        int
        f_10286_1688_1780(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 1688, 1780);
            return 0;
        }


        bool
        f_10286_1840_1888(Microsoft.CodeAnalysis.CSharp.BinderFlags
        self, Microsoft.CodeAnalysis.CSharp.BinderFlags
        other)
        {
            var return_v = self.Includes(other);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 1840, 1888);
            return return_v;
        }


        bool
        f_10286_1892_1961(Microsoft.CodeAnalysis.CSharp.BinderFlags
        self, Microsoft.CodeAnalysis.CSharp.BinderFlags
        other)
        {
            var return_v = self.Includes(other);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 1892, 1961);
            return return_v;
        }


        int
        f_10286_1820_1962(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10286, 1820, 1962);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_10286_2055_2071(Microsoft.CodeAnalysis.CSharp.Binder
        this_param)
        {
            var return_v = this_param.Compilation;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 2055, 2071);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode?
        f_10286_2789_2817(Microsoft.CodeAnalysis.CSharp.Binder
        this_param)
        {
            var return_v = this_param.EnclosingNameofArgument;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10286, 2789, 2817);
            return return_v;
        }

    }
}
