// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal abstract class LabelSymbol : Symbol
    {
        public override bool IsExtern
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10112, 759, 823);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10112, 795, 808);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10112, 759, 823);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10112, 705, 834);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10112, 705, 834);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsSealed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10112, 1005, 1069);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10112, 1041, 1054);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10112, 1005, 1069);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10112, 951, 1080);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10112, 951, 1080);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsAbstract
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10112, 1255, 1319);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10112, 1291, 1304);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10112, 1255, 1319);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10112, 1199, 1330);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10112, 1199, 1330);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsOverride
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10112, 1507, 1571);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10112, 1543, 1556);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10112, 1507, 1571);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10112, 1451, 1582);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10112, 1451, 1582);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsVirtual
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10112, 1755, 1819);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10112, 1791, 1804);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10112, 1755, 1819);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10112, 1700, 1830);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10112, 1700, 1830);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsStatic
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10112, 2001, 2065);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10112, 2037, 2050);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10112, 2001, 2065);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10112, 1947, 2076);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10112, 1947, 2076);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override ObsoleteAttributeData? ObsoleteAttributeData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10112, 2450, 2470);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10112, 2456, 2468);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10112, 2450, 2470);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10112, 2356, 2481);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10112, 2356, 2481);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Accessibility DeclaredAccessibility
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10112, 2706, 2792);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10112, 2742, 2777);

                    return Accessibility.NotApplicable;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10112, 2706, 2792);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10112, 2630, 2803);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10112, 2630, 2803);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10112, 3152, 3237);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10112, 3188, 3222);

                    throw f_10112_3194_3221();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10112, 3152, 3237);

                    System.NotSupportedException
                    f_10112_3194_3221()
                    {
                        var return_v = new System.NotSupportedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10112, 3194, 3221);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10112, 3077, 3248);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10112, 3077, 3248);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual SyntaxNodeOrToken IdentifierNodeOrToken
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10112, 3341, 3383);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10112, 3347, 3381);

                    return default(SyntaxNodeOrToken);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10112, 3341, 3383);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10112, 3260, 3394);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10112, 3260, 3394);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override TResult Accept<TArgument, TResult>(CSharpSymbolVisitor<TArgument, TResult> visitor, TArgument argument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10112, 3406, 3605);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10112, 3552, 3594);

                return f_10112_3559_3593<TResult, TArgument>(visitor, this, argument);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10112, 3406, 3605);

                TResult
                f_10112_3559_3593<TResult, TArgument>(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TArgument, TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                symbol, TArgument
                argument)
                {
                    var return_v = this_param.VisitLabel(symbol, argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10112, 3559, 3593);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10112, 3406, 3605);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10112, 3406, 3605);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void Accept(CSharpSymbolVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10112, 3617, 3734);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10112, 3698, 3723);

                f_10112_3698_3722(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10112, 3617, 3734);

                int
                f_10112_3698_3722(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                symbol)
                {
                    this_param.VisitLabel(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10112, 3698, 3722);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10112, 3617, 3734);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10112, 3617, 3734);
            }
        }

        public override TResult Accept<TResult>(CSharpSymbolVisitor<TResult> visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10112, 3746, 3891);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10112, 3848, 3880);

                return f_10112_3855_3879<TResult>(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10112, 3746, 3891);

                TResult
                f_10112_3855_3879<TResult>(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                symbol)
                {
                    var return_v = this_param.VisitLabel(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10112, 3855, 3879);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10112, 3746, 3891);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10112, 3746, 3891);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual MethodSymbol ContainingMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10112, 4196, 4281);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10112, 4232, 4266);

                    throw f_10112_4238_4265();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10112, 4196, 4281);

                    System.NotSupportedException
                    f_10112_4238_4265()
                    {
                        var return_v = new System.NotSupportedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10112, 4238, 4265);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10112, 4127, 4292);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10112, 4127, 4292);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10112, 4592, 4677);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10112, 4628, 4662);

                    throw f_10112_4634_4661();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10112, 4592, 4677);

                    System.NotSupportedException
                    f_10112_4634_4661()
                    {
                        var return_v = new System.NotSupportedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10112, 4634, 4661);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10112, 4528, 4688);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10112, 4528, 4688);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override SymbolKind Kind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10112, 4870, 4945);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10112, 4906, 4930);

                    return SymbolKind.Label;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10112, 4870, 4945);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10112, 4814, 4956);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10112, 4814, 4956);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected sealed override ISymbol CreateISymbol()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10112, 4968, 5094);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10112, 5042, 5083);

                return f_10112_5049_5082(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10112, 4968, 5094);

                Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.LabelSymbol
                f_10112_5049_5082(Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                underlying)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.LabelSymbol(underlying);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10112, 5049, 5082);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10112, 4968, 5094);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10112, 4968, 5094);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public LabelSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(10112, 527, 5101);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(10112, 527, 5101);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10112, 527, 5101);
        }


        static LabelSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10112, 527, 5101);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10112, 527, 5101);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10112, 527, 5101);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10112, 527, 5101);
    }
}
