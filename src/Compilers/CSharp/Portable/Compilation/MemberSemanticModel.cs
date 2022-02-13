// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Operations;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal abstract partial class MemberSemanticModel : CSharpSemanticModel
    {
        private readonly Symbol _memberSymbol;

        private readonly CSharpSyntaxNode _root;

        private readonly DiagnosticBag _ignoredDiagnostics;

        private readonly ReaderWriterLockSlim _nodeMapLock;

        private readonly Dictionary<SyntaxNode, ImmutableArray<BoundNode>> _guardedBoundNodeMap;

        private readonly Dictionary<SyntaxNode, IOperation> _guardedIOperationNodeMap;

        private Dictionary<SyntaxNode, BoundStatement> _lazyGuardedSynthesizedStatementsMap;

        private NullableWalker.SnapshotManager _lazySnapshotManager;

        private ImmutableDictionary<Symbol, Symbol> _lazyRemappedSymbols;

        private readonly ImmutableDictionary<Symbol, Symbol> _parentRemappedSymbolsOpt;

        private readonly NullableWalker.SnapshotManager _parentSnapshotManagerOpt;

        internal readonly Binder RootBinder;

        private readonly SyntaxTreeSemanticModel _containingSemanticModelOpt;

        private readonly SyntaxTreeSemanticModel _parentSemanticModelOpt;

        private readonly int _speculatedPosition;

        private readonly Lazy<CSharpOperationFactory> _operationFactory;

        protected MemberSemanticModel(
                    CSharpSyntaxNode root,
                    Symbol memberSymbol,
                    Binder rootBinder,
                    SyntaxTreeSemanticModel containingSemanticModelOpt,
                    SyntaxTreeSemanticModel parentSemanticModelOpt,
                    NullableWalker.SnapshotManager snapshotManagerOpt,
                    ImmutableDictionary<Symbol, Symbol> parentRemappedSymbolsOpt,
                    int speculatedPosition)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10923, 2623, 4246);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 877, 890);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 935, 940);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 982, 1023);
                this._ignoredDiagnostics = f_10923_1004_1023(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 1072, 1144);
                this._nodeMapLock = f_10923_1087_1144(LockRecursionPolicy.NoRecursion); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 1317, 1395);
                this._guardedBoundNodeMap = f_10923_1340_1395(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 1458, 1526);
                this._guardedIOperationNodeMap = f_10923_1486_1526(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 1584, 1620);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 1670, 1690);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 1745, 1765);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 1829, 1854);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 2026, 2051);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 2089, 2099);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 2313, 2340);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 2460, 2483);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 2515, 2534);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 2593, 2610);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 3082, 3109);

                f_10923_3082_3108(root != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 3123, 3166);

                f_10923_3123_3165((object)memberSymbol != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 3180, 3262);

                f_10923_3180_3261(parentSemanticModelOpt == null ^ containingSemanticModelOpt == null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 3276, 3383);

                f_10923_3276_3382(containingSemanticModelOpt == null || (DynAbs.Tracing.TraceSender.Expression_False(10923, 3289, 3381) || f_10923_3327_3381_M(!containingSemanticModelOpt.IsSpeculativeSemanticModel)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 3397, 3552);

                f_10923_3397_3551(parentSemanticModelOpt == null || (DynAbs.Tracing.TraceSender.Expression_False(10923, 3410, 3494) || f_10923_3444_3494_M(!parentSemanticModelOpt.IsSpeculativeSemanticModel)), f_10923_3496_3550());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 3566, 3641);

                f_10923_3566_3640(snapshotManagerOpt == null || (DynAbs.Tracing.TraceSender.Expression_False(10923, 3579, 3639) || parentSemanticModelOpt != null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 3657, 3670);

                _root = root;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 3684, 3713);

                _memberSymbol = memberSymbol;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 3729, 3809);

                this.RootBinder = f_10923_3747_3808(rootBinder, f_10923_3778_3807(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 3823, 3880);

                _containingSemanticModelOpt = containingSemanticModelOpt;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 3894, 3943);

                _parentSemanticModelOpt = parentSemanticModelOpt;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 3957, 4004);

                _parentSnapshotManagerOpt = snapshotManagerOpt;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 4018, 4071);

                _parentRemappedSymbolsOpt = parentRemappedSymbolsOpt;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 4085, 4126);

                _speculatedPosition = speculatedPosition;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 4142, 4235);

                _operationFactory = f_10923_4162_4234(() => new CSharpOperationFactory(this));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10923, 2623, 4246);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 2623, 4246);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 2623, 4246);
            }
        }

        public override CSharpCompilation Compilation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 4328, 4455);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 4364, 4440);

                    return f_10923_4371_4439((_containingSemanticModelOpt ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel>(10923, 4372, 4426) ?? _parentSemanticModelOpt)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 4328, 4455);

                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10923_4371_4439(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                    this_param)
                    {
                        var return_v = this_param.Compilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 4371, 4439);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 4258, 4466);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 4258, 4466);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override CSharpSyntaxNode Root
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 4542, 4606);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 4578, 4591);

                    return _root;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 4542, 4606);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 4478, 4617);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 4478, 4617);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal Symbol MemberSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 4761, 4833);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 4797, 4818);

                    return _memberSymbol;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 4761, 4833);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 4708, 4844);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 4708, 4844);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsSpeculativeSemanticModel
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 4935, 5025);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 4971, 5010);

                    return _parentSemanticModelOpt != null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 4935, 5025);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 4856, 5036);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 4856, 5036);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override int OriginalPositionForSpeculation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 5130, 5208);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 5166, 5193);

                    return _speculatedPosition;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 5130, 5208);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 5048, 5219);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 5048, 5219);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override CSharpSemanticModel ParentModel
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 5310, 5392);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 5346, 5377);

                    return _parentSemanticModelOpt;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 5310, 5392);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 5231, 5403);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 5231, 5403);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override SemanticModel ContainingModelOrSelf
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 5500, 5609);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 5536, 5594);

                    return _containingSemanticModelOpt ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel>(10923, 5543, 5593) ?? (SemanticModel)this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 5500, 5609);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 5415, 5620);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 5415, 5620);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override MemberSemanticModel GetMemberModel(SyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 5632, 5926);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 5845, 5865);

                f_10923_5845_5864(false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 5879, 5915);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10923, 5886, 5900) || ((f_10923_5886_5900(this, node) && DynAbs.Tracing.TraceSender.Conditional_F2(10923, 5903, 5907)) || DynAbs.Tracing.TraceSender.Conditional_F3(10923, 5910, 5914))) ? this : null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 5632, 5926);

                int
                f_10923_5845_5864(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 5845, 5864);
                    return 0;
                }


                bool
                f_10923_5886_5900(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.IsInTree(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 5886, 5900);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 5632, 5926);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 5632, 5926);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual NullableWalker.SnapshotManager GetSnapshotManager()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 6093, 6413);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 6187, 6235);

                f_10923_6187_6234(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 6249, 6360);

                f_10923_6249_6359(_lazySnapshotManager is object || (DynAbs.Tracing.TraceSender.Expression_False(10923, 6262, 6326) || this is AttributeSemanticModel) || (DynAbs.Tracing.TraceSender.Expression_False(10923, 6262, 6358) || !f_10923_6331_6358(this)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 6374, 6402);

                return _lazySnapshotManager;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 6093, 6413);

                int
                f_10923_6187_6234(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param)
                {
                    this_param.EnsureNullabilityAnalysisPerformedIfNecessary();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 6187, 6234);
                    return 0;
                }


                bool
                f_10923_6331_6358(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param)
                {
                    var return_v = this_param.IsNullableAnalysisEnabled();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 6331, 6358);
                    return return_v;
                }


                int
                f_10923_6249_6359(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 6249, 6359);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 6093, 6413);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 6093, 6413);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ImmutableDictionary<Symbol, Symbol> GetRemappedSymbols()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 6425, 6741);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 6515, 6563);

                f_10923_6515_6562(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 6577, 6688);

                f_10923_6577_6687(_lazyRemappedSymbols is object || (DynAbs.Tracing.TraceSender.Expression_False(10923, 6590, 6654) || this is AttributeSemanticModel) || (DynAbs.Tracing.TraceSender.Expression_False(10923, 6590, 6686) || !f_10923_6659_6686(this)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 6702, 6730);

                return _lazyRemappedSymbols;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 6425, 6741);

                int
                f_10923_6515_6562(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param)
                {
                    this_param.EnsureNullabilityAnalysisPerformedIfNecessary();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 6515, 6562);
                    return 0;
                }


                bool
                f_10923_6659_6686(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param)
                {
                    var return_v = this_param.IsNullableAnalysisEnabled();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 6659, 6686);
                    return return_v;
                }


                int
                f_10923_6577_6687(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 6577, 6687);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 6425, 6741);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 6425, 6741);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override bool TryGetSpeculativeSemanticModelCore(SyntaxTreeSemanticModel parentModel, int position, TypeSyntax type, SpeculativeBindingOption bindingOption, out SemanticModel speculativeModel)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 6753, 7478);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 6986, 7047);

                var
                expression = f_10923_7003_7046(type)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 7063, 7139);

                var
                binder = f_10923_7076_7138(this, position, expression, bindingOption)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 7153, 7400) || true) && (binder != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 7153, 7400);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 7205, 7355);

                    speculativeModel = f_10923_7224_7354(parentModel, _memberSymbol, type, binder, f_10923_7301_7321(this), f_10923_7323_7343(this), position);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 7373, 7385);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 7153, 7400);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 7416, 7440);

                speculativeModel = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 7454, 7467);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 6753, 7478);

                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10923_7003_7046(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                expression)
                {
                    var return_v = SyntaxFactory.GetStandaloneExpression((Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 7003, 7046);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10923_7076_7138(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                expression, Microsoft.CodeAnalysis.SpeculativeBindingOption
                bindingOption)
                {
                    var return_v = this_param.GetSpeculativeBinder(position, expression, bindingOption);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 7076, 7138);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.NullableWalker.SnapshotManager
                f_10923_7301_7321(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param)
                {
                    var return_v = this_param.GetSnapshotManager();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 7301, 7321);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10923_7323_7343(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param)
                {
                    var return_v = this_param.GetRemappedSymbols();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 7323, 7343);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel.SpeculativeMemberSemanticModel
                f_10923_7224_7354(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                parentSemanticModel, Microsoft.CodeAnalysis.CSharp.Symbol
                owner, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                root, Microsoft.CodeAnalysis.CSharp.Binder
                rootBinder, Microsoft.CodeAnalysis.CSharp.NullableWalker.SnapshotManager
                snapshotManagerOpt, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>
                parentRemappedSymbolsOpt, int
                position)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MemberSemanticModel.SpeculativeMemberSemanticModel(parentSemanticModel, owner, root, rootBinder, snapshotManagerOpt, parentRemappedSymbolsOpt, position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 7224, 7354);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 6753, 7478);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 6753, 7478);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override bool TryGetSpeculativeSemanticModelCore(SyntaxTreeSemanticModel parentModel, int position, CrefSyntax crefSyntax, out SemanticModel speculativeModel)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 7490, 7814);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 7752, 7776);

                speculativeModel = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 7790, 7803);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 7490, 7814);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 7490, 7814);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 7490, 7814);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override BoundExpression GetSpeculativelyBoundExpression(int position, ExpressionSyntax expression, SpeculativeBindingOption bindingOption, out Binder binder, out ImmutableArray<Symbol> crefSymbols)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 7826, 9146);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 8058, 8181) || true) && (expression == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 8058, 8181);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 8114, 8166);

                    throw f_10923_8120_8165(nameof(expression));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 8058, 8181);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 8197, 9135) || true) && (bindingOption == SpeculativeBindingOption.BindAsExpression && (DynAbs.Tracing.TraceSender.Expression_True(10923, 8201, 8306) && f_10923_8263_8283(this) is { } snapshotManager))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 8197, 9135);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 8340, 8362);

                    crefSymbols = default;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 8380, 8424);

                    position = f_10923_8391_8423(this, position);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 8442, 8505);

                    expression = f_10923_8455_8504(expression);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 8523, 8590);

                    binder = f_10923_8532_8589(this, position, expression, bindingOption);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 8608, 8679);

                    var
                    boundRoot = f_10923_8624_8678(binder, expression, _ignoredDiagnostics)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 8697, 8748);

                    ImmutableDictionary<Symbol, Symbol>
                    ignored = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 8766, 8931);

                    return (BoundExpression)f_10923_8790_8930(position, boundRoot, binder, snapshotManager, newSnapshots: out _, remappedSymbols: ref ignored);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 8197, 9135);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 8197, 9135);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 8997, 9120);

                    return f_10923_9004_9119(this, position, expression, bindingOption, out binder, out crefSymbols);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 8197, 9135);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 7826, 9146);

                System.ArgumentNullException
                f_10923_8120_8165(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 8120, 8165);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.NullableWalker.SnapshotManager
                f_10923_8263_8283(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param)
                {
                    var return_v = this_param.GetSnapshotManager();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 8263, 8283);
                    return return_v;
                }


                int
                f_10923_8391_8423(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, int
                position)
                {
                    var return_v = this_param.CheckAndAdjustPosition(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 8391, 8423);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10923_8455_8504(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                expression)
                {
                    var return_v = SyntaxFactory.GetStandaloneExpression(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 8455, 8504);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10923_8532_8589(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                expression, Microsoft.CodeAnalysis.SpeculativeBindingOption
                bindingOption)
                {
                    var return_v = this_param.GetSpeculativeBinder(position, expression, bindingOption);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 8532, 8589);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10923_8624_8678(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindExpression(node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 8624, 8678);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10923_8790_8930(int
                position, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.CSharp.NullableWalker.SnapshotManager
                originalSnapshots, out Microsoft.CodeAnalysis.CSharp.NullableWalker.SnapshotManager
                newSnapshots, ref System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>?
                remappedSymbols)
                {
                    var return_v = NullableWalker.AnalyzeAndRewriteSpeculation(position, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, binder, originalSnapshots, out newSnapshots, remappedSymbols: ref remappedSymbols);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 8790, 8930);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10923_9004_9119(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                expression, Microsoft.CodeAnalysis.SpeculativeBindingOption
                bindingOption, out Microsoft.CodeAnalysis.CSharp.Binder
                binder, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                crefSymbols)
                {
                    var return_v = this_param.GetSpeculativelyBoundExpressionWithoutNullability(position, expression, bindingOption, out binder, out crefSymbols);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 9004, 9119);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 7826, 9146);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 7826, 9146);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Binder GetEnclosingBinderInternalWithinRoot(SyntaxNode node, int position)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 9158, 9453);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 9265, 9298);

                f_10923_9265_9297(this, position);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 9312, 9442);

                return f_10923_9319_9441(f_10923_9319_9390(node, position, RootBinder, _root), f_10923_9411_9440(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 9158, 9453);

                int
                f_10923_9265_9297(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, int
                position)
                {
                    this_param.AssertPositionAdjusted(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 9265, 9297);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10923_9319_9390(Microsoft.CodeAnalysis.SyntaxNode
                node, int
                position, Microsoft.CodeAnalysis.CSharp.Binder
                rootBinder, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                root)
                {
                    var return_v = GetEnclosingBinderInternalWithinRoot(node, position, rootBinder, (Microsoft.CodeAnalysis.SyntaxNode)root);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 9319, 9390);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinderFlags
                f_10923_9411_9440(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param)
                {
                    var return_v = this_param.GetSemanticModelBinderFlags();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 9411, 9440);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10923_9319_9441(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BinderFlags
                flags)
                {
                    var return_v = this_param.WithAdditionalFlags(flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 9319, 9441);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 9158, 9453);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 9158, 9453);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Binder GetEnclosingBinderInternalWithinRoot(SyntaxNode node, int position, Binder rootBinder, SyntaxNode root)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10923, 9465, 16172);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 9615, 9728) || true) && (node == root)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 9615, 9728);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 9665, 9713);

                    return f_10923_9672_9698(rootBinder, node) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Binder?>(10923, 9672, 9712) ?? rootBinder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 9615, 9728);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 9744, 9778);

                f_10923_9744_9777(f_10923_9757_9776(root, node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 9794, 9833);

                ExpressionSyntax
                typeOfArgument = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 9847, 9912);

                LocalFunctionStatementSyntax
                ownerOfTypeParametersInScope = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 9928, 9949);

                Binder
                binder = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 9974, 9988);

                    for (var
        current = node
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 9965, 15520) || true) && (binder == null)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 10006, 10054)
        , current = f_10923_10016_10054(current), DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 9965, 15520))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 9965, 15520);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 10088, 10118);

                        f_10923_10088_10117(current != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 10210, 10260);

                        StatementSyntax
                        stmt = current as StatementSyntax
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 10278, 10318);

                        TypeOfExpressionSyntax
                        typeOfExpression
                        = default(TypeOfExpressionSyntax);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 10336, 10369);

                        SyntaxKind
                        kind = f_10923_10354_10368(current)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 10389, 15399) || true) && (stmt != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 10389, 15399);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 10447, 11517) || true) && (f_10923_10451_10500(position, stmt))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 10447, 11517);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 10550, 10589);

                                binder = f_10923_10559_10588(rootBinder, current);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 10617, 11494) || true) && (binder != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 10617, 11494);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 10693, 10765);

                                    binder = f_10923_10702_10764(position, binder, stmt);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 10617, 11494);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 10617, 11494);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 10823, 11494) || true) && (kind == SyntaxKind.LocalFunctionStatement)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 10823, 11494);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 10926, 10977);

                                        f_10923_10926_10976(ownerOfTypeParametersInScope == null);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 11007, 11062);

                                        var
                                        localFunction = (LocalFunctionStatementSyntax)stmt
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 11092, 11467) || true) && (f_10923_11096_11127(localFunction) != null && (DynAbs.Tracing.TraceSender.Expression_True(10923, 11096, 11286) && !f_10923_11173_11286(position, f_10923_11214_11238(localFunction), f_10923_11240_11285(f_10923_11240_11271(localFunction)))))
                                        ) // Scope does not include method name.

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 11092, 11467);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 11391, 11436);

                                            ownerOfTypeParametersInScope = localFunction;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 11092, 11467);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 10823, 11494);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 10617, 11494);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 10447, 11517);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 10389, 15399);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 10389, 15399);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 11559, 15399) || true) && (kind == SyntaxKind.CatchClause)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 11559, 15399);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 11635, 11823) || true) && (f_10923_11639_11711(position, current))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 11635, 11823);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 11761, 11800);

                                    binder = f_10923_11770_11799(rootBinder, current);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 11635, 11823);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 11559, 15399);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 11559, 15399);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 11865, 15399) || true) && (kind == SyntaxKind.CatchFilterClause)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 11865, 15399);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 11947, 12142) || true) && (f_10923_11951_12030(position, current))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 11947, 12142);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 12080, 12119);

                                        binder = f_10923_12089_12118(rootBinder, current);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 11947, 12142);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 11865, 15399);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 11865, 15399);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 12184, 15399) || true) && (f_10923_12188_12217(current))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 12184, 15399);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 12259, 12516) || true) && (f_10923_12263_12325(position, current))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 12259, 12516);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 12375, 12438);

                                            binder = f_10923_12384_12437(rootBinder, f_10923_12405_12436(current));
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 12464, 12493);

                                            f_10923_12464_12492(binder != null);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 12259, 12516);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 12184, 15399);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 12184, 15399);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 12558, 15399) || true) && (kind == SyntaxKind.TypeOfExpression && (DynAbs.Tracing.TraceSender.Expression_True(10923, 12562, 12644) && typeOfArgument == null) && (DynAbs.Tracing.TraceSender.Expression_True(10923, 12562, 12888) && f_10923_12669_12888(position, f_10923_12761_12828((typeOfExpression = (TypeOfExpressionSyntax)current)), f_10923_12855_12887(typeOfExpression))))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 12558, 15399);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 12930, 12969);

                                            typeOfArgument = f_10923_12947_12968(typeOfExpression);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 12558, 15399);
                                        }

                                        else
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 12558, 15399);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 13011, 15399) || true) && (kind == SyntaxKind.SwitchSection)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 13011, 15399);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 13089, 13282) || true) && (f_10923_13093_13170(position, current))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 13089, 13282);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 13220, 13259);

                                                    binder = f_10923_13229_13258(rootBinder, current);
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 13089, 13282);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 13011, 15399);
                                            }

                                            else
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 13011, 15399);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 13324, 15399) || true) && (kind == SyntaxKind.ArgumentList)
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 13324, 15399);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 13401, 13443);

                                                    var
                                                    argList = (ArgumentListSyntax)current
                                                    ;

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 13467, 13672) || true) && (f_10923_13471_13560(position, f_10923_13512_13534(argList), f_10923_13536_13559(argList)))
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 13467, 13672);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 13610, 13649);

                                                        binder = f_10923_13619_13648(rootBinder, current);
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 13467, 13672);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 13324, 15399);
                                                }

                                                else
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 13324, 15399);

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 13714, 15399) || true) && (kind == SyntaxKind.EqualsValueClause)
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 13714, 15399);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 13796, 13835);

                                                        binder = f_10923_13805_13834(rootBinder, current);
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 13714, 15399);
                                                    }

                                                    else
                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 13714, 15399);

                                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 13877, 15399) || true) && (kind == SyntaxKind.Attribute)
                                                        )

                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 13877, 15399);
                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 13951, 13990);

                                                            binder = f_10923_13960_13989(rootBinder, current);
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 13877, 15399);
                                                        }

                                                        else
                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 13877, 15399);

                                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 14032, 15399) || true) && (kind == SyntaxKind.ArrowExpressionClause)
                                                            )

                                                            {
                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 14032, 15399);
                                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 14118, 14157);

                                                                binder = f_10923_14127_14156(rootBinder, current);
                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 14032, 15399);
                                                            }

                                                            else
                                                            {
                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 14032, 15399);

                                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 14199, 15399) || true) && (kind == SyntaxKind.ThisConstructorInitializer || (DynAbs.Tracing.TraceSender.Expression_False(10923, 14203, 14297) || kind == SyntaxKind.BaseConstructorInitializer) || (DynAbs.Tracing.TraceSender.Expression_False(10923, 14203, 14346) || kind == SyntaxKind.PrimaryConstructorBaseType))
                                                                )

                                                                {
                                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 14199, 15399);
                                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 14388, 14427);

                                                                    binder = f_10923_14397_14426(rootBinder, current);
                                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 14199, 15399);
                                                                }

                                                                else
                                                                {
                                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 14199, 15399);

                                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 14469, 15399) || true) && (kind == SyntaxKind.ConstructorDeclaration)
                                                                    )

                                                                    {
                                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 14469, 15399);
                                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 14556, 14595);

                                                                        binder = f_10923_14565_14594(rootBinder, current);
                                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 14469, 15399);
                                                                    }

                                                                    else
                                                                    {
                                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 14469, 15399);

                                                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 14637, 15399) || true) && (kind == SyntaxKind.SwitchExpression)
                                                                        )

                                                                        {
                                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 14637, 15399);
                                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 14718, 14757);

                                                                            binder = f_10923_14727_14756(rootBinder, current);
                                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 14637, 15399);
                                                                        }

                                                                        else
                                                                        {
                                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 14637, 15399);

                                                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 14799, 15399) || true) && (kind == SyntaxKind.SwitchExpressionArm)
                                                                            )

                                                                            {
                                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 14799, 15399);
                                                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 14883, 14922);

                                                                                binder = f_10923_14892_14921(rootBinder, current);
                                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 14799, 15399);
                                                                            }

                                                                            else
                                                                            {
                                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 14799, 15399);

                                                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 14964, 15399) || true) && (f_10923_14968_15022((current as ExpressionSyntax)))
                                                                                )

                                                                                {
                                                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 14964, 15399);
                                                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 15064, 15103);

                                                                                    binder = f_10923_15073_15102(rootBinder, current);
                                                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 14964, 15399);
                                                                                }

                                                                                else

                                                                                {
                                                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 14964, 15399);
                                                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 15326, 15380);

                                                                                    f_10923_15326_15379(!f_10923_15340_15378(current));
                                                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 14964, 15399);
                                                                                }
                                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 14799, 15399);
                                                                            }
                                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 14637, 15399);
                                                                        }
                                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 14469, 15399);
                                                                    }
                                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 14199, 15399);
                                                                }
                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 14032, 15399);
                                                            }
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 13877, 15399);
                                                        }
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 13714, 15399);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 13324, 15399);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 13011, 15399);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 12558, 15399);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 12184, 15399);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 11865, 15399);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 11559, 15399);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 10389, 15399);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 15419, 15505) || true) && (current == root)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 15419, 15505);
                            DynAbs.Tracing.TraceSender.TraceBreak(10923, 15480, 15486);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 15419, 15505);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10923, 1, 5556);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10923, 1, 5556);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 15536, 15596);

                binder = binder ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Binder?>(10923, 15545, 15595) ?? f_10923_15555_15581(rootBinder, root) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Binder?>(10923, 15555, 15595) ?? rootBinder));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 15610, 15639);

                f_10923_15610_15638(binder != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 15655, 15990) || true) && (ownerOfTypeParametersInScope != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 15655, 15990);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 15729, 15834);

                    LocalFunctionSymbol
                    function = f_10923_15760_15833(binder, f_10923_15793_15832(ownerOfTypeParametersInScope))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 15852, 15975) || true) && ((object)function != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 15852, 15975);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 15922, 15956);

                        binder = f_10923_15931_15955(function);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 15852, 15975);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 15655, 15990);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 16006, 16131) || true) && (typeOfArgument != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 16006, 16131);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 16066, 16116);

                    binder = f_10923_16075_16115(typeOfArgument, binder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 16006, 16131);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 16147, 16161);

                return binder;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10923, 9465, 16172);

                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10923_9672_9698(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.GetBinder(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 9672, 9698);
                    return return_v;
                }


                bool
                f_10923_9757_9776(Microsoft.CodeAnalysis.SyntaxNode
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.Contains(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 9757, 9776);
                    return return_v;
                }


                int
                f_10923_9744_9777(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 9744, 9777);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_10923_10016_10054(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.ParentOrStructuredTriviaParent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 10016, 10054);
                    return return_v;
                }


                int
                f_10923_10088_10117(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 10088, 10117);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10923_10354_10368(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 10354, 10368);
                    return return_v;
                }


                bool
                f_10923_10451_10500(int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                statement)
                {
                    var return_v = LookupPosition.IsInStatementScope(position, statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 10451, 10500);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10923_10559_10588(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.GetBinder(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 10559, 10588);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10923_10702_10764(int
                position, Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                stmt)
                {
                    var return_v = AdjustBinderForPositionWithinStatement(position, binder, stmt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 10702, 10764);
                    return return_v;
                }


                int
                f_10923_10926_10976(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 10926, 10976);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax?
                f_10923_11096_11127(Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
                this_param)
                {
                    var return_v = this_param.TypeParameterList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 11096, 11127);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10923_11214_11238(Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 11214, 11238);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax
                f_10923_11240_11271(Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
                this_param)
                {
                    var return_v = this_param.TypeParameterList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 11240, 11271);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10923_11240_11285(Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax
                this_param)
                {
                    var return_v = this_param.LessThanToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 11240, 11285);
                    return return_v;
                }


                bool
                f_10923_11173_11286(int
                position, Microsoft.CodeAnalysis.SyntaxToken
                firstIncluded, Microsoft.CodeAnalysis.SyntaxToken
                firstExcluded)
                {
                    var return_v = LookupPosition.IsBetweenTokens(position, firstIncluded, firstExcluded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 11173, 11286);
                    return return_v;
                }


                bool
                f_10923_11639_11711(int
                position, Microsoft.CodeAnalysis.SyntaxNode
                catchClause)
                {
                    var return_v = LookupPosition.IsInCatchBlockScope(position, (Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax)catchClause);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 11639, 11711);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10923_11770_11799(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.GetBinder(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 11770, 11799);
                    return return_v;
                }


                bool
                f_10923_11951_12030(int
                position, Microsoft.CodeAnalysis.SyntaxNode
                filterClause)
                {
                    var return_v = LookupPosition.IsInCatchFilterScope(position, (Microsoft.CodeAnalysis.CSharp.Syntax.CatchFilterClauseSyntax)filterClause);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 11951, 12030);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10923_12089_12118(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.GetBinder(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 12089, 12118);
                    return return_v;
                }


                bool
                f_10923_12188_12217(Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    var return_v = syntax.IsAnonymousFunction();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 12188, 12217);
                    return return_v;
                }


                bool
                f_10923_12263_12325(int
                position, Microsoft.CodeAnalysis.SyntaxNode
                lambdaExpressionOrQueryNode)
                {
                    var return_v = LookupPosition.IsInAnonymousFunctionOrQuery(position, lambdaExpressionOrQueryNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 12263, 12325);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10923_12405_12436(Microsoft.CodeAnalysis.SyntaxNode
                lambda)
                {
                    var return_v = lambda.AnonymousFunctionBody();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 12405, 12436);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10923_12384_12437(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 12384, 12437);
                    return return_v;
                }


                int
                f_10923_12464_12492(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 12464, 12492);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10923_12761_12828(Microsoft.CodeAnalysis.CSharp.Syntax.TypeOfExpressionSyntax
                this_param)
                {
                    var return_v = this_param.OpenParenToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 12761, 12828);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10923_12855_12887(Microsoft.CodeAnalysis.CSharp.Syntax.TypeOfExpressionSyntax
                this_param)
                {
                    var return_v = this_param.CloseParenToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 12855, 12887);
                    return return_v;
                }


                bool
                f_10923_12669_12888(int
                position, Microsoft.CodeAnalysis.SyntaxToken
                firstIncluded, Microsoft.CodeAnalysis.SyntaxToken
                firstExcluded)
                {
                    var return_v = LookupPosition.IsBetweenTokens(position, firstIncluded, firstExcluded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 12669, 12888);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10923_12947_12968(Microsoft.CodeAnalysis.CSharp.Syntax.TypeOfExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 12947, 12968);
                    return return_v;
                }


                bool
                f_10923_13093_13170(int
                position, Microsoft.CodeAnalysis.SyntaxNode
                section)
                {
                    var return_v = LookupPosition.IsInSwitchSectionScope(position, (Microsoft.CodeAnalysis.CSharp.Syntax.SwitchSectionSyntax)section);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 13093, 13170);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10923_13229_13258(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.GetBinder(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 13229, 13258);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10923_13512_13534(Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax
                this_param)
                {
                    var return_v = this_param.OpenParenToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 13512, 13534);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10923_13536_13559(Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax
                this_param)
                {
                    var return_v = this_param.CloseParenToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 13536, 13559);
                    return return_v;
                }


                bool
                f_10923_13471_13560(int
                position, Microsoft.CodeAnalysis.SyntaxToken
                firstIncluded, Microsoft.CodeAnalysis.SyntaxToken
                firstExcluded)
                {
                    var return_v = LookupPosition.IsBetweenTokens(position, firstIncluded, firstExcluded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 13471, 13560);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10923_13619_13648(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.GetBinder(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 13619, 13648);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10923_13805_13834(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.GetBinder(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 13805, 13834);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10923_13960_13989(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.GetBinder(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 13960, 13989);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10923_14127_14156(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.GetBinder(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 14127, 14156);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10923_14397_14426(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.GetBinder(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 14397, 14426);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10923_14565_14594(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.GetBinder(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 14565, 14594);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10923_14727_14756(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.GetBinder(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 14727, 14756);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10923_14892_14921(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.GetBinder(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 14892, 14921);
                    return return_v;
                }


                bool
                f_10923_14968_15022(Microsoft.CodeAnalysis.SyntaxNode
                expression)
                {
                    var return_v = ((ExpressionSyntax)expression).IsValidScopeDesignator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 14968, 15022);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10923_15073_15102(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.GetBinder(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 15073, 15102);
                    return return_v;
                }


                bool
                f_10923_15340_15378(Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    var return_v = syntax.CanHaveAssociatedLocalBinder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 15340, 15378);
                    return return_v;
                }


                int
                f_10923_15326_15379(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 15326, 15379);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10923_15555_15581(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.GetBinder(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 15555, 15581);
                    return return_v;
                }


                int
                f_10923_15610_15638(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 15610, 15638);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10923_15793_15832(Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 15793, 15832);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                f_10923_15760_15833(Microsoft.CodeAnalysis.CSharp.Binder
                enclosingBinder, Microsoft.CodeAnalysis.SyntaxToken
                declaredIdentifier)
                {
                    var return_v = GetDeclaredLocalFunction(enclosingBinder, declaredIdentifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 15760, 15833);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10923_15931_15955(Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                this_param)
                {
                    var return_v = this_param.SignatureBinder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 15931, 15955);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.TypeofBinder
                f_10923_16075_16115(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                typeExpression, Microsoft.CodeAnalysis.CSharp.Binder
                next)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.TypeofBinder(typeExpression, next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 16075, 16115);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 9465, 16172);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 9465, 16172);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Binder AdjustBinderForPositionWithinStatement(int position, Binder binder, StatementSyntax stmt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10923, 16184, 18371);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 16320, 18330);

                switch (f_10923_16328_16339(stmt))
                {

                    case SyntaxKind.SwitchStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 16320, 18330);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 16427, 16472);

                        var
                        switchStmt = (SwitchStatementSyntax)stmt
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 16494, 16768) || true) && (f_10923_16498_16591(position, f_10923_16539_16563(switchStmt), f_10923_16565_16590(switchStmt)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 16494, 16768);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 16641, 16690);

                            binder = f_10923_16650_16689(binder, f_10923_16667_16688(switchStmt));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 16716, 16745);

                            f_10923_16716_16744(binder != null);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 16494, 16768);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10923, 16790, 16796);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 16320, 18330);

                    case SyntaxKind.ForStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 16320, 18330);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 16867, 16906);

                        var
                        forStmt = (ForStatementSyntax)stmt
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 16928, 17644) || true) && (f_10923_16932_17027(position, f_10923_16973_17001(forStmt), f_10923_17003_17026(forStmt)) && (DynAbs.Tracing.TraceSender.Expression_True(10923, 16932, 17086) && forStmt.Incrementors.Count > 0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 16928, 17644);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 17136, 17192);

                            binder = f_10923_17145_17191(binder, forStmt.Incrementors.First());
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 17218, 17247);

                            f_10923_17218_17246(binder != null);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 16928, 17644);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 16928, 17644);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 17297, 17644) || true) && (f_10923_17301_17417(position, f_10923_17342_17369(forStmt), f_10923_17371_17416(forStmt)) && (DynAbs.Tracing.TraceSender.Expression_True(10923, 17301, 17471) && f_10923_17446_17463(forStmt) != null))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 17297, 17644);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 17521, 17566);

                                binder = f_10923_17530_17565(binder, f_10923_17547_17564(forStmt));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 17592, 17621);

                                f_10923_17592_17620(binder != null);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 17297, 17644);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 16928, 17644);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10923, 17666, 17672);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 16320, 18330);

                    case SyntaxKind.ForEachStatement:
                    case SyntaxKind.ForEachVariableStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 16320, 18330);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 17806, 17859);

                        var
                        foreachStmt = (CommonForEachStatementSyntax)stmt
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 17881, 17997);

                        var
                        start = (DynAbs.Tracing.TraceSender.Conditional_F1(10923, 17893, 17943) || ((f_10923_17893_17904(stmt) == SyntaxKind.ForEachVariableStatement && DynAbs.Tracing.TraceSender.Conditional_F2(10923, 17946, 17967)) || DynAbs.Tracing.TraceSender.Conditional_F3(10923, 17970, 17996))) ? f_10923_17946_17967(foreachStmt) : f_10923_17970_17996(foreachStmt)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 18019, 18287) || true) && (f_10923_18023_18109(position, start, f_10923_18071_18108(f_10923_18071_18092(foreachStmt))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 18019, 18287);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 18159, 18209);

                            binder = f_10923_18168_18208(binder, f_10923_18185_18207(foreachStmt));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 18235, 18264);

                            f_10923_18235_18263(binder != null);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 18019, 18287);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10923, 18309, 18315);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 16320, 18330);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 18346, 18360);

                return binder;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10923, 16184, 18371);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10923_16328_16339(Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 16328, 16339);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10923_16539_16563(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax
                this_param)
                {
                    var return_v = this_param.SwitchKeyword;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 16539, 16563);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10923_16565_16590(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax
                this_param)
                {
                    var return_v = this_param.OpenBraceToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 16565, 16590);
                    return return_v;
                }


                bool
                f_10923_16498_16591(int
                position, Microsoft.CodeAnalysis.SyntaxToken
                firstIncluded, Microsoft.CodeAnalysis.SyntaxToken
                firstExcluded)
                {
                    var return_v = LookupPosition.IsBetweenTokens(position, firstIncluded, firstExcluded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 16498, 16591);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10923_16667_16688(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 16667, 16688);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10923_16650_16689(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node)
                {
                    var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 16650, 16689);
                    return return_v;
                }


                int
                f_10923_16716_16744(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 16716, 16744);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10923_16973_17001(Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax
                this_param)
                {
                    var return_v = this_param.SecondSemicolonToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 16973, 17001);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10923_17003_17026(Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax
                this_param)
                {
                    var return_v = this_param.CloseParenToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 17003, 17026);
                    return return_v;
                }


                bool
                f_10923_16932_17027(int
                position, Microsoft.CodeAnalysis.SyntaxToken
                firstIncluded, Microsoft.CodeAnalysis.SyntaxToken
                firstExcluded)
                {
                    var return_v = LookupPosition.IsBetweenTokens(position, firstIncluded, firstExcluded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 16932, 17027);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10923_17145_17191(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node)
                {
                    var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 17145, 17191);
                    return return_v;
                }


                int
                f_10923_17218_17246(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 17218, 17246);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10923_17342_17369(Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax
                this_param)
                {
                    var return_v = this_param.FirstSemicolonToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 17342, 17369);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10923_17371_17416(Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax
                statement)
                {
                    var return_v = LookupPosition.GetFirstExcludedToken((Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax)statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 17371, 17416);
                    return return_v;
                }


                bool
                f_10923_17301_17417(int
                position, Microsoft.CodeAnalysis.SyntaxToken
                firstIncluded, Microsoft.CodeAnalysis.SyntaxToken
                firstExcluded)
                {
                    var return_v = LookupPosition.IsBetweenTokens(position, firstIncluded, firstExcluded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 17301, 17417);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax?
                f_10923_17446_17463(Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax
                this_param)
                {
                    var return_v = this_param.Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 17446, 17463);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10923_17547_17564(Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax
                this_param)
                {
                    var return_v = this_param.Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 17547, 17564);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10923_17530_17565(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node)
                {
                    var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 17530, 17565);
                    return return_v;
                }


                int
                f_10923_17592_17620(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 17592, 17620);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10923_17893_17904(Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 17893, 17904);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10923_17946_17967(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.InKeyword;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 17946, 17967);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10923_17970_17996(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.OpenParenToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 17970, 17996);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                f_10923_18071_18092(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.Statement;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 18071, 18092);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10923_18071_18108(Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                this_param)
                {
                    var return_v = this_param.GetFirstToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 18071, 18108);
                    return return_v;
                }


                bool
                f_10923_18023_18109(int
                position, Microsoft.CodeAnalysis.SyntaxToken
                firstIncluded, Microsoft.CodeAnalysis.SyntaxToken
                firstExcluded)
                {
                    var return_v = LookupPosition.IsBetweenTokens(position, firstIncluded, firstExcluded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 18023, 18109);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10923_18185_18207(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 18185, 18207);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10923_18168_18208(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node)
                {
                    var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 18168, 18208);
                    return return_v;
                }


                int
                f_10923_18235_18263(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 18235, 18263);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 16184, 18371);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 16184, 18371);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Conversion ClassifyConversion(
                    ExpressionSyntax expression,
                    ITypeSymbol destination,
                    bool isExplicitInSource = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 18383, 21218);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 18580, 18713) || true) && ((object)destination == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 18580, 18713);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 18645, 18698);

                    throw f_10923_18651_18697(nameof(destination));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 18580, 18713);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 18729, 18814);

                TypeSymbol
                csdestination = f_10923_18756_18813(destination, nameof(destination))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 18830, 19033) || true) && (f_10923_18834_18851(expression) == SyntaxKind.DeclarationExpression)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 18830, 19033);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 18987, 19018);

                    return Conversion.NoConversion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 18830, 19033);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 19904, 20133) || true) && (f_10923_19908_19940(expression))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 19904, 20133);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 19974, 20002);

                    f_10923_19974_20001(this, expression);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 20020, 20118);

                    return f_10923_20027_20117(this, f_10923_20051_20071(expression), expression, destination, isExplicitInSource);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 19904, 20133);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 20149, 20280) || true) && (isExplicitInSource)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 20149, 20280);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 20205, 20265);

                    return f_10923_20212_20264(this, expression, csdestination);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 20149, 20280);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 20558, 20586);

                f_10923_20558_20585(this, expression);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 20602, 20696);

                var
                binder = f_10923_20615_20695(this, expression, f_10923_20659_20694(this, expression))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 20710, 20781);

                CSharpSyntaxNode
                bindableNode = f_10923_20742_20780(this, expression)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 20795, 20873);

                var
                boundExpression = f_10923_20817_20853(this, bindableNode) as BoundExpression
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 20887, 21012) || true) && (binder == null || (DynAbs.Tracing.TraceSender.Expression_False(10923, 20891, 20932) || boundExpression == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 20887, 21012);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 20966, 20997);

                    return Conversion.NoConversion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 20887, 21012);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 21028, 21078);

                HashSet<DiagnosticInfo>
                useSiteDiagnostics = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 21092, 21207);

                return f_10923_21099_21206(f_10923_21099_21117(binder), boundExpression, csdestination, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 18383, 21218);

                System.ArgumentNullException
                f_10923_18651_18697(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 18651, 18697);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10923_18756_18813(Microsoft.CodeAnalysis.ITypeSymbol
                symbol, string
                paramName)
                {
                    var return_v = symbol.EnsureCSharpSymbolOrNull(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 18756, 18813);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10923_18834_18851(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 18834, 18851);
                    return return_v;
                }


                bool
                f_10923_19908_19940(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax)
                {
                    var return_v = syntax.IsAnonymousFunction();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 19908, 19940);
                    return return_v;
                }


                int
                f_10923_19974_20001(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax)
                {
                    this_param.CheckSyntaxNode((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 19974, 20001);
                    return 0;
                }


                int
                f_10923_20051_20071(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.SpanStart;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 20051, 20071);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10923_20027_20117(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                expression, Microsoft.CodeAnalysis.ITypeSymbol
                destination, bool
                isExplicitInSource)
                {
                    var return_v = this_param.ClassifyConversion(position, expression, destination, isExplicitInSource);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 20027, 20117);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10923_20212_20264(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                expression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination)
                {
                    var return_v = this_param.ClassifyConversionForCast(expression, destination);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 20212, 20264);
                    return return_v;
                }


                int
                f_10923_20558_20585(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax)
                {
                    this_param.CheckSyntaxNode((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 20558, 20585);
                    return 0;
                }


                int
                f_10923_20659_20694(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node)
                {
                    var return_v = this_param.GetAdjustedNodePosition((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 20659, 20694);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10923_20615_20695(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, int
                position)
                {
                    var return_v = this_param.GetEnclosingBinderInternal((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 20615, 20695);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10923_20742_20780(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node)
                {
                    var return_v = this_param.GetBindableSyntaxNode((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 20742, 20780);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10923_20817_20853(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetLowerBoundNode(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 20817, 20853);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10923_21099_21117(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 21099, 21117);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10923_21099_21206(Microsoft.CodeAnalysis.CSharp.Conversions
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                sourceExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyConversionFromExpression(sourceExpression, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 21099, 21206);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 18383, 21218);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 18383, 21218);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override Conversion ClassifyConversionForCast(
                    ExpressionSyntax expression,
                    TypeSymbol destination)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 21230, 22211);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 21389, 21417);

                f_10923_21389_21416(this, expression);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 21433, 21566) || true) && ((object)destination == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 21433, 21566);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 21498, 21551);

                    throw f_10923_21504_21550(nameof(destination));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 21433, 21566);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 21582, 21676);

                var
                binder = f_10923_21595_21675(this, expression, f_10923_21639_21674(this, expression))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 21690, 21761);

                CSharpSyntaxNode
                bindableNode = f_10923_21722_21760(this, expression)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 21775, 21853);

                var
                boundExpression = f_10923_21797_21833(this, bindableNode) as BoundExpression
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 21867, 21992) || true) && (binder == null || (DynAbs.Tracing.TraceSender.Expression_False(10923, 21871, 21912) || boundExpression == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 21867, 21992);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 21946, 21977);

                    return Conversion.NoConversion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 21867, 21992);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 22008, 22058);

                HashSet<DiagnosticInfo>
                useSiteDiagnostics = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 22072, 22200);

                return f_10923_22079_22199(f_10923_22079_22097(binder), boundExpression, destination, ref useSiteDiagnostics, forCast: true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 21230, 22211);

                int
                f_10923_21389_21416(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax)
                {
                    this_param.CheckSyntaxNode((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 21389, 21416);
                    return 0;
                }


                System.ArgumentNullException
                f_10923_21504_21550(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 21504, 21550);
                    return return_v;
                }


                int
                f_10923_21639_21674(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node)
                {
                    var return_v = this_param.GetAdjustedNodePosition((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 21639, 21674);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10923_21595_21675(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, int
                position)
                {
                    var return_v = this_param.GetEnclosingBinderInternal((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 21595, 21675);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10923_21722_21760(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node)
                {
                    var return_v = this_param.GetBindableSyntaxNode((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 21722, 21760);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10923_21797_21833(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetLowerBoundNode(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 21797, 21833);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10923_22079_22097(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 22079, 22097);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10923_22079_22199(Microsoft.CodeAnalysis.CSharp.Conversions
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                sourceExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics, bool
                forCast)
                {
                    var return_v = this_param.ClassifyConversionFromExpression(sourceExpression, destination, ref useSiteDiagnostics, forCast: forCast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 22079, 22199);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 21230, 22211);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 21230, 22211);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual BoundNode GetBoundRoot()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 22330, 22466);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 22396, 22455);

                return f_10923_22403_22454(this, f_10923_22421_22453(this, f_10923_22443_22452(this)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 22330, 22466);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10923_22443_22452(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param)
                {
                    var return_v = this_param.Root;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 22443, 22452);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10923_22421_22453(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetBindableSyntaxNode(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 22421, 22453);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10923_22403_22454(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetUpperBoundNode(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 22403, 22454);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 22330, 22466);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 22330, 22466);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal BoundNode GetUpperBoundNode(CSharpSyntaxNode node, bool promoteToBindable = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 22619, 23328);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 22735, 22956) || true) && (promoteToBindable)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 22735, 22956);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 22790, 22825);

                    node = f_10923_22797_22824(this, node);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 22735, 22956);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 22735, 22956);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 22891, 22941);

                    f_10923_22891_22940(node == f_10923_22912_22939(this, node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 22735, 22956);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 23090, 23127);

                var
                boundNodes = f_10923_23107_23126(this, node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 23143, 23317) || true) && (boundNodes.Length == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 23143, 23317);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 23203, 23215);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 23143, 23317);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 23143, 23317);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 23281, 23302);

                    return boundNodes[0];
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 23143, 23317);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 22619, 23328);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10923_22797_22824(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetBindableSyntaxNode(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 22797, 22824);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10923_22912_22939(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetBindableSyntaxNode(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 22912, 22939);
                    return return_v;
                }


                int
                f_10923_22891_22940(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 22891, 22940);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>
                f_10923_23107_23126(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetBoundNodes(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 23107, 23126);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 22619, 23328);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 22619, 23328);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal BoundNode GetLowerBoundNode(CSharpSyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 23563, 24083);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 23647, 23697);

                f_10923_23647_23696(node == f_10923_23668_23695(this, node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 23829, 23866);

                var
                boundNodes = f_10923_23846_23865(this, node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 23882, 24072) || true) && (boundNodes.Length == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 23882, 24072);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 23942, 23954);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 23882, 24072);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 23882, 24072);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 24020, 24057);

                    return f_10923_24027_24056(boundNodes);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 23882, 24072);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 23563, 24083);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10923_23668_23695(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetBindableSyntaxNode(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 23668, 23695);
                    return return_v;
                }


                int
                f_10923_23647_23696(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 23647, 23696);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>
                f_10923_23846_23865(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetBoundNodes(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 23846, 23865);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10923_24027_24056(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>
                boundNodes)
                {
                    var return_v = GetLowerBoundNode(boundNodes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 24027, 24056);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 23563, 24083);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 23563, 24083);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static BoundNode GetLowerBoundNode(ImmutableArray<BoundNode> boundNodes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10923, 24095, 24252);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 24200, 24241);

                return boundNodes[boundNodes.Length - 1];
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10923, 24095, 24252);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 24095, 24252);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 24095, 24252);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<Diagnostic> GetSyntaxDiagnostics(TextSpan? span = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 24264, 24486);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 24441, 24475);

                throw f_10923_24447_24474();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 24264, 24486);

                System.NotSupportedException
                f_10923_24447_24474()
                {
                    var return_v = new System.NotSupportedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 24447, 24474);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 24264, 24486);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 24264, 24486);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<Diagnostic> GetDeclarationDiagnostics(TextSpan? span = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 24498, 24725);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 24680, 24714);

                throw f_10923_24686_24713();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 24498, 24725);

                System.NotSupportedException
                f_10923_24686_24713()
                {
                    var return_v = new System.NotSupportedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 24686, 24713);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 24498, 24725);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 24498, 24725);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<Diagnostic> GetMethodBodyDiagnostics(TextSpan? span = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 24737, 24963);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 24918, 24952);

                throw f_10923_24924_24951();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 24737, 24963);

                System.NotSupportedException
                f_10923_24924_24951()
                {
                    var return_v = new System.NotSupportedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 24924, 24951);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 24737, 24963);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 24737, 24963);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<Diagnostic> GetDiagnostics(TextSpan? span = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 24975, 25191);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 25146, 25180);

                throw f_10923_25152_25179();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 24975, 25191);

                System.NotSupportedException
                f_10923_25152_25179()
                {
                    var return_v = new System.NotSupportedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 25152, 25179);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 24975, 25191);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 24975, 25191);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override INamespaceSymbol GetDeclaredSymbol(NamespaceDeclarationSyntax declarationSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 25203, 25470);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 25447, 25459);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 25203, 25470);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 25203, 25470);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 25203, 25470);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override INamedTypeSymbol GetDeclaredSymbol(BaseTypeDeclarationSyntax declarationSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 25482, 25742);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 25719, 25731);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 25482, 25742);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 25482, 25742);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 25482, 25742);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override INamedTypeSymbol GetDeclaredSymbol(DelegateDeclarationSyntax declarationSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 25754, 26014);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 25991, 26003);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 25754, 26014);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 25754, 26014);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 25754, 26014);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override IFieldSymbol GetDeclaredSymbol(EnumMemberDeclarationSyntax declarationSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 26026, 26284);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 26261, 26273);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 26026, 26284);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 26026, 26284);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 26026, 26284);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ISymbol GetDeclaredSymbol(LocalFunctionStatementSyntax declarationSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 26296, 26605);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 26476, 26511);

                f_10923_26476_26510(this, declarationSyntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 26525, 26594);

                return f_10923_26532_26593(f_10923_26532_26575(this, declarationSyntax));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 26296, 26605);

                int
                f_10923_26476_26510(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
                syntax)
                {
                    this_param.CheckSyntaxNode((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 26476, 26510);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                f_10923_26532_26575(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
                declarationSyntax)
                {
                    var return_v = this_param.GetDeclaredLocalFunction(declarationSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 26532, 26575);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IMethodSymbol?
                f_10923_26532_26593(Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 26532, 26593);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 26296, 26605);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 26296, 26605);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ISymbol GetDeclaredSymbol(MemberDeclarationSyntax declarationSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 26617, 26866);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 26843, 26855);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 26617, 26866);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 26617, 26866);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 26617, 26866);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override IMethodSymbol GetDeclaredSymbol(CompilationUnitSyntax declarationSyntax, CancellationToken cancellationToken = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 26878, 27061);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 27038, 27050);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 26878, 27061);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 26878, 27061);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 26878, 27061);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override IMethodSymbol GetDeclaredSymbol(BaseMethodDeclarationSyntax declarationSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 27073, 27332);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 27309, 27321);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 27073, 27332);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 27073, 27332);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 27073, 27332);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ISymbol GetDeclaredSymbol(BasePropertyDeclarationSyntax declarationSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 27344, 27601);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 27578, 27590);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 27344, 27601);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 27344, 27601);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 27344, 27601);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override IPropertySymbol GetDeclaredSymbol(PropertyDeclarationSyntax declarationSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 27613, 27874);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 27851, 27863);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 27613, 27874);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 27613, 27874);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 27613, 27874);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override IPropertySymbol GetDeclaredSymbol(IndexerDeclarationSyntax declarationSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 27886, 28145);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 28122, 28134);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 27886, 28145);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 27886, 28145);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 27886, 28145);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override IEventSymbol GetDeclaredSymbol(EventDeclarationSyntax declarationSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 28157, 28409);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 28386, 28398);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 28157, 28409);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 28157, 28409);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 28157, 28409);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override IMethodSymbol GetDeclaredSymbol(AccessorDeclarationSyntax declarationSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 28421, 28680);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 28657, 28669);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 28421, 28680);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 28421, 28680);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 28421, 28680);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override IMethodSymbol GetDeclaredSymbol(ArrowExpressionClauseSyntax declarationSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 28692, 28959);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 28936, 28948);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 28692, 28959);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 28692, 28959);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 28692, 28959);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ISymbol GetDeclaredSymbol(VariableDeclaratorSyntax declarationSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 28971, 29298);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 29147, 29182);

                f_10923_29147_29181(this, declarationSyntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 29196, 29287);

                return f_10923_29203_29286(f_10923_29203_29268(this, declarationSyntax, f_10923_29239_29267(declarationSyntax)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 28971, 29298);

                int
                f_10923_29147_29181(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                syntax)
                {
                    this_param.CheckSyntaxNode((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 29147, 29181);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10923_29239_29267(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 29239, 29267);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10923_29203_29268(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                declarationSyntax, Microsoft.CodeAnalysis.SyntaxToken
                declaredIdentifier)
                {
                    var return_v = this_param.GetDeclaredLocal((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)declarationSyntax, declaredIdentifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 29203, 29268);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ILocalSymbol?
                f_10923_29203_29286(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 29203, 29286);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 28971, 29298);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 28971, 29298);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ISymbol GetDeclaredSymbol(SingleVariableDesignationSyntax declarationSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 29310, 29644);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 29493, 29528);

                f_10923_29493_29527(this, declarationSyntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 29542, 29633);

                return f_10923_29549_29632(f_10923_29549_29614(this, declarationSyntax, f_10923_29585_29613(declarationSyntax)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 29310, 29644);

                int
                f_10923_29493_29527(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SingleVariableDesignationSyntax
                syntax)
                {
                    this_param.CheckSyntaxNode((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 29493, 29527);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10923_29585_29613(Microsoft.CodeAnalysis.CSharp.Syntax.SingleVariableDesignationSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 29585, 29613);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10923_29549_29614(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SingleVariableDesignationSyntax
                declarationSyntax, Microsoft.CodeAnalysis.SyntaxToken
                declaredIdentifier)
                {
                    var return_v = this_param.GetDeclaredLocal((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)declarationSyntax, declaredIdentifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 29549, 29614);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ILocalSymbol?
                f_10923_29549_29632(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 29549, 29632);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 29310, 29644);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 29310, 29644);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private LocalSymbol GetDeclaredLocal(CSharpSyntaxNode declarationSyntax, SyntaxToken declaredIdentifier)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 29656, 30268);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 29794, 29870);
                    for (var
        binder = f_10923_29803_29870(this, f_10923_29827_29869(this, declarationSyntax))
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 29785, 30229) || true) && (binder != null)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 29888, 29908)
        , binder = f_10923_29897_29908(binder), DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 29785, 30229))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 29785, 30229);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 29942, 30214);
                            foreach (var local in f_10923_29964_29977_I(f_10923_29964_29977(binder)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 29942, 30214);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 30019, 30195) || true) && (f_10923_30023_30044(local) == declaredIdentifier)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 30019, 30195);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 30116, 30172);

                                    return f_10923_30123_30171(this, local);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 30019, 30195);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 29942, 30214);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10923, 1, 273);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10923, 1, 273);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10923, 1, 445);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10923, 1, 445);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 30245, 30257);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 29656, 30268);

                int
                f_10923_29827_29869(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetAdjustedNodePosition((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 29827, 29869);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10923_29803_29870(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, int
                position)
                {
                    var return_v = this_param.GetEnclosingBinder(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 29803, 29870);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10923_29897_29908(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Next;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 29897, 29908);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10923_29964_29977(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 29964, 29977);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10923_30023_30044(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.IdentifierToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 30023, 30044);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10923_30123_30171(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.GetAdjustedLocalSymbol((Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol)local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 30123, 30171);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10923_29964_29977_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 29964, 29977);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 29656, 30268);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 29656, 30268);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override LocalSymbol GetAdjustedLocalSymbol(SourceLocalSymbol local)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 30298, 30456);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 30400, 30445);

                return f_10923_30407_30444(this, local);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 30298, 30456);

                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10923_30407_30444(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                originalSymbol)
                {
                    var return_v = this_param.GetRemappedSymbol<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>((Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol)originalSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 30407, 30444);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 30298, 30456);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 30298, 30456);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private LocalFunctionSymbol GetDeclaredLocalFunction(LocalFunctionStatementSyntax declarationSyntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 30468, 30804);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 30593, 30738);

                var
                originalSymbol = f_10923_30614_30737(f_10923_30639_30706(this, f_10923_30663_30705(this, declarationSyntax)), f_10923_30708_30736(declarationSyntax))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 30752, 30793);

                return f_10923_30759_30792(this, originalSymbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 30468, 30804);

                int
                f_10923_30663_30705(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
                node)
                {
                    var return_v = this_param.GetAdjustedNodePosition((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 30663, 30705);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10923_30639_30706(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, int
                position)
                {
                    var return_v = this_param.GetEnclosingBinder(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 30639, 30706);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10923_30708_30736(Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 30708, 30736);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                f_10923_30614_30737(Microsoft.CodeAnalysis.CSharp.Binder
                enclosingBinder, Microsoft.CodeAnalysis.SyntaxToken
                declaredIdentifier)
                {
                    var return_v = GetDeclaredLocalFunction(enclosingBinder, declaredIdentifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 30614, 30737);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                f_10923_30759_30792(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                originalSymbol)
                {
                    var return_v = this_param.GetRemappedSymbol<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>(originalSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 30759, 30792);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 30468, 30804);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 30468, 30804);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private T GetRemappedSymbol<T>(T originalSymbol) where T : Symbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 30816, 31306);
                Microsoft.CodeAnalysis.CSharp.Symbol remappedSymbol = default(Microsoft.CodeAnalysis.CSharp.Symbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 30906, 30954);

                f_10923_30906_30953<T>(this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 30968, 31024) || true) && (_lazyRemappedSymbols is null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 30968, 31024);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 31002, 31024);

                    return originalSymbol;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 30968, 31024);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 31040, 31257) || true) && (f_10923_31044_31120<T>(_lazyRemappedSymbols, originalSymbol, out remappedSymbol))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 31040, 31257);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 31154, 31199);

                    f_10923_31154_31198<T>(remappedSymbol is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 31217, 31242);

                    return (T)remappedSymbol;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 31040, 31257);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 31273, 31295);

                return originalSymbol;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 30816, 31306);

                int
                f_10923_30906_30953<T>(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param) where T : Symbol

                {
                    this_param.EnsureNullabilityAnalysisPerformedIfNecessary();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 30906, 30953);
                    return 0;
                }


                bool
                f_10923_31044_31120<T>(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, T
                key, out Microsoft.CodeAnalysis.CSharp.Symbol?
                value) where T : Symbol

                {
                    var return_v = this_param.TryGetValue((Microsoft.CodeAnalysis.CSharp.Symbol)key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 31044, 31120);
                    return return_v;
                }


                int
                f_10923_31154_31198<T>(bool
                b) where T : Symbol

                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 31154, 31198);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 30816, 31306);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 30816, 31306);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static LocalFunctionSymbol GetDeclaredLocalFunction(Binder enclosingBinder, SyntaxToken declaredIdentifier)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10923, 31337, 31891);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 31486, 31510);
                    for (var
        binder = enclosingBinder
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 31477, 31852) || true) && (binder != null)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 31528, 31548)
        , binder = f_10923_31537_31548(binder), DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 31477, 31852))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 31477, 31852);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 31582, 31837);
                            foreach (var localFunction in f_10923_31612_31633_I(f_10923_31612_31633(binder)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 31582, 31837);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 31675, 31818) || true) && (f_10923_31679_31702(localFunction) == declaredIdentifier)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 31675, 31818);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 31774, 31795);

                                    return localFunction;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 31675, 31818);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 31582, 31837);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10923, 1, 256);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10923, 1, 256);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10923, 1, 376);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10923, 1, 376);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 31868, 31880);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10923, 31337, 31891);

                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10923_31537_31548(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Next;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 31537, 31548);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                f_10923_31612_31633(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.LocalFunctions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 31612, 31633);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10923_31679_31702(Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                this_param)
                {
                    var return_v = this_param.NameToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 31679, 31702);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                f_10923_31612_31633_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 31612, 31633);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 31337, 31891);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 31337, 31891);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ILabelSymbol GetDeclaredSymbol(LabeledStatementSyntax declarationSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 31903, 32811);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 32082, 32117);

                f_10923_32082_32116(this, declarationSyntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 32133, 32214);

                var
                binder = f_10923_32146_32213(this, f_10923_32170_32212(this, declarationSyntax))
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 32230, 32352) || true) && (binder != null && (DynAbs.Tracing.TraceSender.Expression_True(10923, 32237, 32282) && f_10923_32255_32282_M(!binder.IsLabelsScopeBinder)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 32230, 32352);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 32316, 32337);

                        binder = f_10923_32325_32336(binder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 32230, 32352);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10923, 32230, 32352);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10923, 32230, 32352);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 32368, 32772) || true) && (binder != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 32368, 32772);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 32420, 32757);
                        foreach (var label in f_10923_32442_32455_I(f_10923_32442_32455(binder)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 32420, 32757);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 32497, 32738) || true) && (label.IdentifierNodeOrToken.IsToken && (DynAbs.Tracing.TraceSender.Expression_True(10923, 32501, 32634) && label.IdentifierNodeOrToken.AsToken() == f_10923_32606_32634(declarationSyntax)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 32497, 32738);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 32684, 32715);

                                return f_10923_32691_32714(label);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 32497, 32738);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 32420, 32757);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10923, 1, 338);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10923, 1, 338);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 32368, 32772);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 32788, 32800);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 31903, 32811);

                int
                f_10923_32082_32116(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.LabeledStatementSyntax
                syntax)
                {
                    this_param.CheckSyntaxNode((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 32082, 32116);
                    return 0;
                }


                int
                f_10923_32170_32212(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.LabeledStatementSyntax
                node)
                {
                    var return_v = this_param.GetAdjustedNodePosition((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 32170, 32212);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10923_32146_32213(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, int
                position)
                {
                    var return_v = this_param.GetEnclosingBinder(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 32146, 32213);
                    return return_v;
                }


                bool
                f_10923_32255_32282_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 32255, 32282);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10923_32325_32336(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Next;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 32325, 32336);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                f_10923_32442_32455(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Labels;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 32442, 32455);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10923_32606_32634(Microsoft.CodeAnalysis.CSharp.Syntax.LabeledStatementSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 32606, 32634);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ILabelSymbol?
                f_10923_32691_32714(Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 32691, 32714);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                f_10923_32442_32455_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 32442, 32455);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 31903, 32811);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 31903, 32811);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ILabelSymbol GetDeclaredSymbol(SwitchLabelSyntax declarationSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 32823, 33709);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 32997, 33032);

                f_10923_32997_33031(this, declarationSyntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 33048, 33129);

                var
                binder = f_10923_33061_33128(this, f_10923_33085_33127(this, declarationSyntax))
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 33143, 33263) || true) && (binder != null && (DynAbs.Tracing.TraceSender.Expression_True(10923, 33150, 33193) && !(binder is SwitchBinder)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 33143, 33263);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 33227, 33248);

                        binder = f_10923_33236_33247(binder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 33143, 33263);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10923, 33143, 33263);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10923, 33143, 33263);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 33279, 33670) || true) && (binder != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 33279, 33670);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 33331, 33655);
                        foreach (var label in f_10923_33353_33366_I(f_10923_33353_33366(binder)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 33331, 33655);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 33408, 33636) || true) && (label.IdentifierNodeOrToken.IsNode && (DynAbs.Tracing.TraceSender.Expression_True(10923, 33412, 33532) && label.IdentifierNodeOrToken.AsNode() == declarationSyntax))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 33408, 33636);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 33582, 33613);

                                return f_10923_33589_33612(label);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 33408, 33636);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 33331, 33655);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10923, 1, 325);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10923, 1, 325);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 33279, 33670);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 33686, 33698);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 32823, 33709);

                int
                f_10923_32997_33031(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SwitchLabelSyntax
                syntax)
                {
                    this_param.CheckSyntaxNode((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 32997, 33031);
                    return 0;
                }


                int
                f_10923_33085_33127(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SwitchLabelSyntax
                node)
                {
                    var return_v = this_param.GetAdjustedNodePosition((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 33085, 33127);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10923_33061_33128(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, int
                position)
                {
                    var return_v = this_param.GetEnclosingBinder(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 33061, 33128);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10923_33236_33247(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Next;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 33236, 33247);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                f_10923_33353_33366(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Labels;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 33353, 33366);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ILabelSymbol?
                f_10923_33589_33612(Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 33589, 33612);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                f_10923_33353_33366_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 33353, 33366);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 32823, 33709);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 32823, 33709);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override IAliasSymbol GetDeclaredSymbol(UsingDirectiveSyntax declarationSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 33721, 33971);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 33948, 33960);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 33721, 33971);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 33721, 33971);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 33721, 33971);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override IAliasSymbol GetDeclaredSymbol(ExternAliasDirectiveSyntax declarationSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 33983, 34251);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 34228, 34240);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 33983, 34251);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 33983, 34251);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 33983, 34251);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override IParameterSymbol GetDeclaredSymbol(ParameterSyntax declarationSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 34263, 34672);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 34507, 34542);

                f_10923_34507_34541(this, declarationSyntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 34558, 34661);

                return f_10923_34565_34660(f_10923_34565_34642(this, declarationSyntax, cancellationToken));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 34263, 34672);

                int
                f_10923_34507_34541(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                syntax)
                {
                    this_param.CheckSyntaxNode((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 34507, 34541);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10923_34565_34642(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                parameter, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetLambdaOrLocalFunctionParameterSymbol(parameter, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 34565, 34642);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IParameterSymbol?
                f_10923_34565_34660(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 34565, 34660);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 34263, 34672);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 34263, 34672);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<ISymbol> GetDeclaredSymbols(BaseFieldDeclarationSyntax declarationSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 34684, 34982);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 34931, 34971);

                return f_10923_34938_34970();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 34684, 34982);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_10923_34938_34970()
                {
                    var return_v = ImmutableArray.Create<ISymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 34938, 34970);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 34684, 34982);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 34684, 34982);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ParameterSymbol GetLambdaOrLocalFunctionParameterSymbol(
                    ParameterSyntax parameter,
                    CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 34994, 36349);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 35173, 35205);

                f_10923_35173_35204(parameter != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 35221, 35289);

                var
                simpleLambda = f_10923_35240_35256(parameter) as SimpleLambdaExpressionSyntax
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 35303, 35452) || true) && (simpleLambda != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 35303, 35452);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 35361, 35437);

                    return f_10923_35368_35436(this, parameter, simpleLambda, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 35303, 35452);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 35468, 35524);

                var
                paramList = f_10923_35484_35500(parameter) as ParameterListSyntax
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 35538, 35648) || true) && (paramList == null || (DynAbs.Tracing.TraceSender.Expression_False(10923, 35542, 35587) || f_10923_35563_35579(paramList) == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 35538, 35648);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 35621, 35633);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 35538, 35648);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 35664, 36310) || true) && (f_10923_35668_35706(f_10923_35668_35684(paramList)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 35664, 36310);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 35740, 35838);

                    return f_10923_35747_35837(this, parameter, f_10923_35801_35817(paramList), cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 35664, 36310);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 35664, 36310);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 35872, 36310) || true) && (f_10923_35876_35899(f_10923_35876_35892(paramList)) == SyntaxKind.LocalFunctionStatement)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 35872, 36310);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 35970, 36101);

                        var
                        localFunction = f_10923_35990_36100(f_10923_35990_36074(this, f_10923_36038_36054(paramList), cancellationToken))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 36119, 36295) || true) && ((object)localFunction != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 36119, 36295);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 36194, 36276);

                            return f_10923_36201_36275(this, f_10923_36220_36244(localFunction), parameter, cancellationToken);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 36119, 36295);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 35872, 36310);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 35664, 36310);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 36326, 36338);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 34994, 36349);

                int
                f_10923_35173_35204(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 35173, 35204);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10923_35240_35256(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 35240, 35256);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10923_35368_35436(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                parameter, Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax
                lambda, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetLambdaParameterSymbol(parameter, (Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)lambda, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 35368, 35436);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10923_35484_35500(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 35484, 35500);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10923_35563_35579(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 35563, 35579);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10923_35668_35684(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 35668, 35684);
                    return return_v;
                }


                bool
                f_10923_35668_35706(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax)
                {
                    var return_v = syntax.IsAnonymousFunction();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 35668, 35706);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10923_35801_35817(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 35801, 35817);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10923_35747_35837(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                parameter, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                lambda, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetLambdaParameterSymbol(parameter, (Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)lambda, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 35747, 35837);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10923_35876_35892(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 35876, 35892);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10923_35876_35899(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 35876, 35899);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10923_36038_36054(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 36038, 36054);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol
                f_10923_35990_36074(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                declarationSyntax, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetDeclaredSymbol((Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax)declarationSyntax, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 35990, 36074);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10923_35990_36100(Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    var return_v = symbol.GetSymbol<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 35990, 36100);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10923_36220_36244(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 36220, 36244);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10923_36201_36275(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                parameter, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetParameterSymbol(parameters, parameter, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 36201, 36275);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 34994, 36349);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 34994, 36349);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ParameterSymbol GetLambdaParameterSymbol(
                    ParameterSyntax parameter,
                    ExpressionSyntax lambda,
                    CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 36361, 37548);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 36563, 36595);

                f_10923_36563_36594(parameter != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 36609, 36670);

                f_10923_36609_36669(lambda != null && (DynAbs.Tracing.TraceSender.Expression_True(10923, 36622, 36668) && f_10923_36640_36668(lambda)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 36776, 36846);

                SymbolInfo
                symbolInfo = f_10923_36800_36845(this, lambda, cancellationToken)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 36862, 36888);

                LambdaSymbol
                lambdaSymbol
                = default(LambdaSymbol);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 36902, 37442) || true) && ((object)symbolInfo.Symbol != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 36902, 37442);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 36973, 37032);

                    lambdaSymbol = f_10923_36988_37031(symbolInfo.Symbol);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 36902, 37442);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 36902, 37442);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 37066, 37442) || true) && (symbolInfo.CandidateSymbols.Length == 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 37066, 37442);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 37143, 37221);

                        lambdaSymbol = f_10923_37158_37220(symbolInfo.CandidateSymbols.Single());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 37066, 37442);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 37066, 37442);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 37287, 37397);

                        f_10923_37287_37396(f_10923_37300_37327(this, lambda) == null, "Did not find a unique LambdaSymbol for lambda in member.");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 37415, 37427);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 37066, 37442);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 36902, 37442);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 37456, 37537);

                return f_10923_37463_37536(this, f_10923_37482_37505(lambdaSymbol), parameter, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 36361, 37548);

                int
                f_10923_36563_36594(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 36563, 36594);
                    return 0;
                }


                bool
                f_10923_36640_36668(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax)
                {
                    var return_v = syntax.IsAnonymousFunction();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 36640, 36668);
                    return return_v;
                }


                int
                f_10923_36609_36669(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 36609, 36669);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolInfo
                f_10923_36800_36845(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                expression, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetSymbolInfo(expression, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 36800, 36845);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol?
                f_10923_36988_37031(Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    var return_v = symbol.GetSymbol<Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 36988, 37031);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol?
                f_10923_37158_37220(Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    var return_v = symbol.GetSymbol<Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 37158, 37220);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10923_37300_37327(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node)
                {
                    var return_v = this_param.GetMemberModel((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 37300, 37327);
                    return return_v;
                }


                int
                f_10923_37287_37396(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 37287, 37396);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10923_37482_37505(Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 37482, 37505);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10923_37463_37536(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                parameter, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetParameterSymbol(parameters, parameter, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 37463, 37536);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 36361, 37548);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 36361, 37548);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ITypeParameterSymbol GetDeclaredSymbol(TypeParameterSyntax typeParameter, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 37560, 37813);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 37790, 37802);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 37560, 37813);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 37560, 37813);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 37560, 37813);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override IRangeVariableSymbol GetDeclaredSymbol(JoinIntoClauseSyntax node, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 37825, 38128);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 37997, 38035);

                var
                bound = f_10923_38009_38034(this, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 38049, 38117);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10923, 38056, 38069) || ((bound == null && DynAbs.Tracing.TraceSender.Conditional_F2(10923, 38072, 38076)) || DynAbs.Tracing.TraceSender.Conditional_F3(10923, 38079, 38116))) ? null : f_10923_38079_38116(f_10923_38079_38098(bound));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 37825, 38128);

                Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                f_10923_38009_38034(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.JoinIntoClauseSyntax
                node)
                {
                    var return_v = this_param.GetBoundQueryClause((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 38009, 38034);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol?
                f_10923_38079_38098(Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                this_param)
                {
                    var return_v = this_param.DefinedSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 38079, 38098);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IRangeVariableSymbol?
                f_10923_38079_38116(Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol?
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 38079, 38116);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 37825, 38128);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 37825, 38128);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override IRangeVariableSymbol GetDeclaredSymbol(QueryClauseSyntax queryClause, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 38140, 38454);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 38316, 38361);

                var
                bound = f_10923_38328_38360(this, queryClause)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 38375, 38443);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10923, 38382, 38395) || ((bound == null && DynAbs.Tracing.TraceSender.Conditional_F2(10923, 38398, 38402)) || DynAbs.Tracing.TraceSender.Conditional_F3(10923, 38405, 38442))) ? null : f_10923_38405_38442(f_10923_38405_38424(bound));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 38140, 38454);

                Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                f_10923_38328_38360(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.QueryClauseSyntax
                node)
                {
                    var return_v = this_param.GetBoundQueryClause((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 38328, 38360);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol?
                f_10923_38405_38424(Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                this_param)
                {
                    var return_v = this_param.DefinedSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 38405, 38424);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IRangeVariableSymbol?
                f_10923_38405_38442(Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol?
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 38405, 38442);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 38140, 38454);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 38140, 38454);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override IRangeVariableSymbol GetDeclaredSymbol(QueryContinuationSyntax node, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 38466, 38772);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 38641, 38679);

                var
                bound = f_10923_38653_38678(this, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 38693, 38761);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10923, 38700, 38713) || ((bound == null && DynAbs.Tracing.TraceSender.Conditional_F2(10923, 38716, 38720)) || DynAbs.Tracing.TraceSender.Conditional_F3(10923, 38723, 38760))) ? null : f_10923_38723_38760(f_10923_38723_38742(bound));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 38466, 38772);

                Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                f_10923_38653_38678(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.QueryContinuationSyntax
                node)
                {
                    var return_v = this_param.GetBoundQueryClause((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 38653, 38678);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol?
                f_10923_38723_38742(Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                this_param)
                {
                    var return_v = this_param.DefinedSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 38723, 38742);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IRangeVariableSymbol?
                f_10923_38723_38760(Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol?
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 38723, 38760);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 38466, 38772);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 38466, 38772);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override AwaitExpressionInfo GetAwaitExpressionInfo(AwaitExpressionSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 38784, 39950);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 38895, 39046) || true) && (f_10923_38899_38910(node) != SyntaxKind.AwaitExpression)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 38895, 39046);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 38974, 39031);

                    throw f_10923_38980_39030("node.Kind==" + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (f_10923_39018_39029(node)).ToString(), 10923, 39018, 39029));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 38895, 39046);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 39062, 39098);

                var
                bound = f_10923_39074_39097(this, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 39135, 39180);

                var
                temp = bound as BoundExpressionStatement
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 39194, 39221);

                var
                exp = f_10923_39204_39220_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(temp, 10923, 39204, 39220)?.Expression)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 39235, 39262);

                var
                temp2 = (exp ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.BoundExpression?>(10923, 39248, 39260) ?? bound))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 39276, 39381);

                var
                awaitableInfo = (DynAbs.Tracing.TraceSender.Conditional_F1(10923, 39296, 39327) || (((temp2 is BoundAwaitExpression) && DynAbs.Tracing.TraceSender.Conditional_F2(10923, 39330, 39373)) || DynAbs.Tracing.TraceSender.Conditional_F3(10923, 39376, 39380))) ? f_10923_39330_39373(((BoundAwaitExpression)temp2)) : null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 39395, 39505) || true) && (awaitableInfo == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 39395, 39505);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 39454, 39490);

                    return default(AwaitExpressionInfo);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 39395, 39505);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 39544, 39581);

                var
                temp3 = f_10923_39556_39580(awaitableInfo)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 39595, 39939);

                return f_10923_39602_39938(getAwaiter: (DynAbs.Tracing.TraceSender.Conditional_F1(10923, 39656, 39673) || ((temp3 is not null && DynAbs.Tracing.TraceSender.Conditional_F2(10923, 39676, 39731)) || DynAbs.Tracing.TraceSender.Conditional_F3(10923, 39734, 39738))) ? (IMethodSymbol)f_10923_39691_39731(f_10923_39691_39713(temp3)) : null, isCompleted: f_10923_39770_39813(f_10923_39770_39795(awaitableInfo)), getResult: f_10923_39843_39884(f_10923_39843_39866(awaitableInfo)), isDynamic: f_10923_39914_39937(awaitableInfo));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 38784, 39950);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10923_38899_38910(Microsoft.CodeAnalysis.CSharp.Syntax.AwaitExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 38899, 38910);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10923_39018_39029(Microsoft.CodeAnalysis.CSharp.Syntax.AwaitExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 39018, 39029);
                    return return_v;
                }


                System.ArgumentException
                f_10923_38980_39030(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 38980, 39030);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10923_39074_39097(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AwaitExpressionSyntax
                node)
                {
                    var return_v = this_param.GetUpperBoundNode((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 39074, 39097);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10923_39204_39220_M(Microsoft.CodeAnalysis.CSharp.BoundExpression?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 39204, 39220);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo
                f_10923_39330_39373(Microsoft.CodeAnalysis.CSharp.BoundAwaitExpression
                this_param)
                {
                    var return_v = this_param.AwaitableInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 39330, 39373);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10923_39556_39580(Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo
                this_param)
                {
                    var return_v = this_param.GetAwaiter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 39556, 39580);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10923_39691_39713(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ExpressionSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 39691, 39713);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol?
                f_10923_39691_39731(Microsoft.CodeAnalysis.CSharp.Symbol?
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 39691, 39731);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol?
                f_10923_39770_39795(Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo
                this_param)
                {
                    var return_v = this_param.IsCompleted;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 39770, 39795);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IPropertySymbol?
                f_10923_39770_39813(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol?
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 39770, 39813);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10923_39843_39866(Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo
                this_param)
                {
                    var return_v = this_param.GetResult;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 39843, 39866);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IMethodSymbol?
                f_10923_39843_39884(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 39843, 39884);
                    return return_v;
                }


                bool
                f_10923_39914_39937(Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo
                this_param)
                {
                    var return_v = this_param.IsDynamic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 39914, 39937);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.AwaitExpressionInfo
                f_10923_39602_39938(Microsoft.CodeAnalysis.IMethodSymbol?
                getAwaiter, Microsoft.CodeAnalysis.IPropertySymbol?
                isCompleted, Microsoft.CodeAnalysis.IMethodSymbol?
                getResult, bool
                isDynamic)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.AwaitExpressionInfo(getAwaiter: getAwaiter, isCompleted: isCompleted, getResult: getResult, isDynamic: isDynamic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 39602, 39938);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 38784, 39950);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 38784, 39950);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ForEachStatementInfo GetForEachStatementInfo(ForEachStatementSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 39962, 40154);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 40076, 40143);

                return f_10923_40083_40142(this, node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 39962, 40154);

                Microsoft.CodeAnalysis.CSharp.ForEachStatementInfo
                f_10923_40083_40142(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax
                node)
                {
                    var return_v = this_param.GetForEachStatementInfo((Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 40083, 40142);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 39962, 40154);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 39962, 40154);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ForEachStatementInfo GetForEachStatementInfo(CommonForEachStatementSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 40166, 42909);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 40286, 40370);

                BoundForEachStatement
                boundForEach = (BoundForEachStatement)f_10923_40346_40369(this, node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 40386, 40496) || true) && (boundForEach == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 40386, 40496);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 40444, 40481);

                    return default(ForEachStatementInfo);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 40386, 40496);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 40512, 40585);

                ForEachEnumeratorInfo
                enumeratorInfoOpt = f_10923_40554_40584(boundForEach)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 40601, 40670);

                f_10923_40601_40669(enumeratorInfoOpt != null || (DynAbs.Tracing.TraceSender.Expression_False(10923, 40614, 40668) || f_10923_40643_40668(boundForEach)));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 40686, 40801) || true) && (enumeratorInfoOpt == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 40686, 40801);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 40749, 40786);

                    return default(ForEachStatementInfo);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 40686, 40801);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 41111, 41323) || true) && (f_10923_41115_41160(f_10923_41115_41144(enumeratorInfoOpt)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 41111, 41323);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 41194, 41253);

                    f_10923_41194_41252(f_10923_41207_41251_M(!enumeratorInfoOpt.CurrentConversion.IsValid));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 41271, 41308);

                    return default(ForEachStatementInfo);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 41111, 41323);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 41546, 41580);

                MethodSymbol
                disposeMethod = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 41594, 42192) || true) && (enumeratorInfoOpt.NeedsDisposal)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 41594, 42192);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 41663, 42177) || true) && (enumeratorInfoOpt.PatternDisposeInfo is { Method: var method })
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 41663, 42177);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 41771, 41794);

                        disposeMethod = method;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 41663, 42177);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 41663, 42177);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 41876, 42158);

                        disposeMethod = (DynAbs.Tracing.TraceSender.Conditional_F1(10923, 41892, 41917) || ((enumeratorInfoOpt.IsAsync
                        && DynAbs.Tracing.TraceSender.Conditional_F2(10923, 41941, 42044)) || DynAbs.Tracing.TraceSender.Conditional_F3(10923, 42068, 42157))) ? (MethodSymbol)f_10923_41955_42044(f_10923_41955_41966(), WellKnownMember.System_IAsyncDisposable__DisposeAsync) : (MethodSymbol)f_10923_42082_42157(f_10923_42082_42093(), SpecialMember.System_IDisposable__Dispose);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 41663, 42177);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 41594, 42192);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 42231, 42282);

                var
                temp = enumeratorInfoOpt.CurrentPropertyGetter
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 42296, 42374);

                var
                temp2 = (DynAbs.Tracing.TraceSender.Conditional_F1(10923, 42308, 42324) || ((temp is not null && DynAbs.Tracing.TraceSender.Conditional_F2(10923, 42327, 42366)) || DynAbs.Tracing.TraceSender.Conditional_F3(10923, 42369, 42373))) ? ((PropertySymbol)f_10923_42344_42365(temp)) : null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 42390, 42898);

                return f_10923_42397_42897(enumeratorInfoOpt.IsAsync, f_10923_42484_42544(f_10923_42484_42526(enumeratorInfoOpt.GetEnumeratorInfo)), f_10923_42563_42618(f_10923_42563_42600(enumeratorInfoOpt.MoveNextInfo)), currentProperty: f_10923_42654_42677(temp2), f_10923_42696_42727(disposeMethod), f_10923_42746_42793(f_10923_42746_42775(enumeratorInfoOpt)), f_10923_42812_42842(boundForEach), enumeratorInfoOpt.CurrentConversion);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 40166, 42909);

                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10923_40346_40369(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                node)
                {
                    var return_v = this_param.GetUpperBoundNode((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 40346, 40369);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ForEachEnumeratorInfo?
                f_10923_40554_40584(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
                this_param)
                {
                    var return_v = this_param.EnumeratorInfoOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 40554, 40584);
                    return return_v;
                }


                bool
                f_10923_40643_40668(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
                this_param)
                {
                    var return_v = this_param.HasAnyErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 40643, 40668);
                    return return_v;
                }


                int
                f_10923_40601_40669(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 40601, 40669);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10923_41115_41144(Microsoft.CodeAnalysis.CSharp.ForEachEnumeratorInfo
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 41115, 41144);
                    return return_v;
                }


                bool
                f_10923_41115_41160(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsPointerType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 41115, 41160);
                    return return_v;
                }


                bool
                f_10923_41207_41251_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 41207, 41251);
                    return return_v;
                }


                int
                f_10923_41194_41252(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 41194, 41252);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10923_41955_41966()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 41955, 41966);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10923_41955_42044(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                member)
                {
                    var return_v = this_param.GetWellKnownTypeMember(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 41955, 42044);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10923_42082_42093()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 42082, 42093);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10923_42082_42157(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialMember
                specialMember)
                {
                    var return_v = this_param.GetSpecialTypeMember(specialMember);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 42082, 42157);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10923_42344_42365(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.AssociatedSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 42344, 42365);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10923_42484_42526(Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 42484, 42526);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IMethodSymbol?
                f_10923_42484_42544(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 42484, 42544);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10923_42563_42600(Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 42563, 42600);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IMethodSymbol?
                f_10923_42563_42618(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 42563, 42618);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IPropertySymbol?
                f_10923_42654_42677(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol?
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 42654, 42677);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IMethodSymbol?
                f_10923_42696_42727(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 42696, 42727);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10923_42746_42775(Microsoft.CodeAnalysis.CSharp.ForEachEnumeratorInfo
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 42746, 42775);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol?
                f_10923_42746_42793(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 42746, 42793);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10923_42812_42842(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
                this_param)
                {
                    var return_v = this_param.ElementConversion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 42812, 42842);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ForEachStatementInfo
                f_10923_42397_42897(bool
                isAsync, Microsoft.CodeAnalysis.IMethodSymbol
                getEnumeratorMethod, Microsoft.CodeAnalysis.IMethodSymbol
                moveNextMethod, Microsoft.CodeAnalysis.IPropertySymbol?
                currentProperty, Microsoft.CodeAnalysis.IMethodSymbol?
                disposeMethod, Microsoft.CodeAnalysis.ITypeSymbol
                elementType, Microsoft.CodeAnalysis.CSharp.Conversion
                elementConversion, Microsoft.CodeAnalysis.CSharp.Conversion
                currentConversion)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ForEachStatementInfo(isAsync, getEnumeratorMethod, moveNextMethod, currentProperty: currentProperty, disposeMethod, elementType, elementConversion, currentConversion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 42397, 42897);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 40166, 42909);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 40166, 42909);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override DeconstructionInfo GetDeconstructionInfo(AssignmentExpressionSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 42921, 43541);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 43035, 43126);

                var
                boundDeconstruction = f_10923_43061_43084(this, node) as BoundDeconstructionAssignmentOperator
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 43140, 43235) || true) && (boundDeconstruction is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 43140, 43235);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 43205, 43220);

                    return default;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 43140, 43235);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 43251, 43299);

                var
                boundConversion = f_10923_43273_43298(boundDeconstruction)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 43313, 43351);

                f_10923_43313_43350(boundConversion != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 43365, 43456) || true) && (boundConversion is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 43365, 43456);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 43426, 43441);

                    return default;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 43365, 43456);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 43472, 43530);

                return f_10923_43479_43529(f_10923_43502_43528(boundConversion));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 42921, 43541);

                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10923_43061_43084(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax
                node)
                {
                    var return_v = this_param.GetUpperBoundNode((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 43061, 43084);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundConversion
                f_10923_43273_43298(Microsoft.CodeAnalysis.CSharp.BoundDeconstructionAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 43273, 43298);
                    return return_v;
                }


                int
                f_10923_43313_43350(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 43313, 43350);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10923_43502_43528(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Conversion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 43502, 43528);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DeconstructionInfo
                f_10923_43479_43529(Microsoft.CodeAnalysis.CSharp.Conversion
                conversion)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DeconstructionInfo(conversion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 43479, 43529);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 42921, 43541);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 42921, 43541);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override DeconstructionInfo GetDeconstructionInfo(ForEachVariableStatementSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 43553, 44226);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 43671, 43737);

                var
                boundForEach = (BoundForEachStatement)f_10923_43713_43736(this, node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 43751, 43839) || true) && (boundForEach is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 43751, 43839);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 43809, 43824);

                    return default;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 43751, 43839);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 43855, 43912);

                var
                boundDeconstruction = f_10923_43881_43911(boundForEach)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 43926, 43997);

                f_10923_43926_43996(boundDeconstruction != null || (DynAbs.Tracing.TraceSender.Expression_False(10923, 43939, 43995) || f_10923_43970_43995(boundForEach)));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 44011, 44106) || true) && (boundDeconstruction is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 44011, 44106);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 44076, 44091);

                    return default;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 44011, 44106);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 44122, 44215);

                return f_10923_44129_44214(f_10923_44152_44213(f_10923_44152_44202(f_10923_44152_44196(boundDeconstruction))));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 43553, 44226);

                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10923_43713_43736(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ForEachVariableStatementSyntax
                node)
                {
                    var return_v = this_param.GetUpperBoundNode((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 43713, 43736);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundForEachDeconstructStep?
                f_10923_43881_43911(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
                this_param)
                {
                    var return_v = this_param.DeconstructionOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 43881, 43911);
                    return return_v;
                }


                bool
                f_10923_43970_43995(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
                this_param)
                {
                    var return_v = this_param.HasAnyErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 43970, 43995);
                    return return_v;
                }


                int
                f_10923_43926_43996(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 43926, 43996);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDeconstructionAssignmentOperator
                f_10923_44152_44196(Microsoft.CodeAnalysis.CSharp.BoundForEachDeconstructStep
                this_param)
                {
                    var return_v = this_param.DeconstructionAssignment;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 44152, 44196);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundConversion
                f_10923_44152_44202(Microsoft.CodeAnalysis.CSharp.BoundDeconstructionAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 44152, 44202);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10923_44152_44213(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Conversion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 44152, 44213);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DeconstructionInfo
                f_10923_44129_44214(Microsoft.CodeAnalysis.CSharp.Conversion
                conversion)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DeconstructionInfo(conversion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 44129, 44214);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 43553, 44226);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 43553, 44226);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundQueryClause GetBoundQueryClause(CSharpSyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 44238, 44433);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 44330, 44352);

                f_10923_44330_44351(this, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 44366, 44422);

                return f_10923_44373_44401(this, node) as BoundQueryClause;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 44238, 44433);

                int
                f_10923_44330_44351(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax)
                {
                    this_param.CheckSyntaxNode(syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 44330, 44351);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10923_44373_44401(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetLowerBoundNode(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 44373, 44401);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 44238, 44433);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 44238, 44433);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private QueryClauseInfo GetQueryClauseInfo(BoundQueryClause bound)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 44445, 44953);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 44536, 44587) || true) && (bound == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 44536, 44587);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 44555, 44587);

                    return default(QueryClauseInfo);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 44536, 44587);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 44601, 44788);

                var
                castInfo = (DynAbs.Tracing.TraceSender.Conditional_F1(10923, 44616, 44636) || (((f_10923_44617_44627(bound) == null) && DynAbs.Tracing.TraceSender.Conditional_F2(10923, 44639, 44654)) || DynAbs.Tracing.TraceSender.Conditional_F3(10923, 44657, 44787))) ? SymbolInfo.None : f_10923_44657_44787(this, SymbolInfoOptions.DefaultOptions, f_10923_44712_44722(bound), f_10923_44724_44734(bound), boundNodeForSyntacticParent: null, binderOpt: null)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 44802, 44851);

                var
                operationInfo = f_10923_44822_44850(this, bound)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 44865, 44942);

                return f_10923_44872_44941(castInfo: castInfo, operationInfo: operationInfo);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 44445, 44953);

                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10923_44617_44627(Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                this_param)
                {
                    var return_v = this_param.Cast;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 44617, 44627);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10923_44712_44722(Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                this_param)
                {
                    var return_v = this_param.Cast;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 44712, 44722);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10923_44724_44734(Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                this_param)
                {
                    var return_v = this_param.Cast;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 44724, 44734);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolInfo
                f_10923_44657_44787(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel.SymbolInfoOptions
                options, Microsoft.CodeAnalysis.CSharp.BoundExpression
                lowestBoundNode, Microsoft.CodeAnalysis.CSharp.BoundExpression
                highestBoundNode, Microsoft.CodeAnalysis.CSharp.BoundNode
                boundNodeForSyntacticParent, Microsoft.CodeAnalysis.CSharp.Binder
                binderOpt)
                {
                    var return_v = this_param.GetSymbolInfoForNode(options, (Microsoft.CodeAnalysis.CSharp.BoundNode)lowestBoundNode, (Microsoft.CodeAnalysis.CSharp.BoundNode)highestBoundNode, boundNodeForSyntacticParent: boundNodeForSyntacticParent, binderOpt: binderOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 44657, 44787);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolInfo
                f_10923_44822_44850(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                bound)
                {
                    var return_v = this_param.GetSymbolInfoForQuery(bound);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 44822, 44850);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.QueryClauseInfo
                f_10923_44872_44941(Microsoft.CodeAnalysis.SymbolInfo
                castInfo, Microsoft.CodeAnalysis.SymbolInfo
                operationInfo)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.QueryClauseInfo(castInfo: castInfo, operationInfo: operationInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 44872, 44941);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 44445, 44953);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 44445, 44953);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private SymbolInfo GetSymbolInfoForQuery(BoundQueryClause bound)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 44965, 45485);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 45077, 45144);

                var
                call = (DynAbs.Tracing.TraceSender.Conditional_F1(10923, 45088, 45105) || ((bound is not null && DynAbs.Tracing.TraceSender.Conditional_F2(10923, 45108, 45136)) || DynAbs.Tracing.TraceSender.Conditional_F3(10923, 45139, 45143))) ? f_10923_45108_45123(bound) as BoundCall : null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 45158, 45246) || true) && (call == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 45158, 45246);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 45208, 45231);

                    return SymbolInfo.None;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 45158, 45246);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 45262, 45324);

                var
                operation = (DynAbs.Tracing.TraceSender.Conditional_F1(10923, 45278, 45297) || ((f_10923_45278_45297(call) && DynAbs.Tracing.TraceSender.Conditional_F2(10923, 45300, 45316)) || DynAbs.Tracing.TraceSender.Conditional_F3(10923, 45319, 45323))) ? f_10923_45300_45316(call) : call
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 45338, 45474);

                return f_10923_45345_45473(this, SymbolInfoOptions.DefaultOptions, operation, operation, boundNodeForSyntacticParent: null, binderOpt: null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 44965, 45485);

                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10923_45108_45123(Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                this_param)
                {
                    var return_v = this_param.Operation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 45108, 45123);
                    return return_v;
                }


                bool
                f_10923_45278_45297(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.IsDelegateCall;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 45278, 45297);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10923_45300_45316(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 45300, 45316);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolInfo
                f_10923_45345_45473(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel.SymbolInfoOptions
                options, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                lowestBoundNode, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                highestBoundNode, Microsoft.CodeAnalysis.CSharp.BoundNode
                boundNodeForSyntacticParent, Microsoft.CodeAnalysis.CSharp.Binder
                binderOpt)
                {
                    var return_v = this_param.GetSymbolInfoForNode(options, (Microsoft.CodeAnalysis.CSharp.BoundNode?)lowestBoundNode, (Microsoft.CodeAnalysis.CSharp.BoundNode?)highestBoundNode, boundNodeForSyntacticParent: boundNodeForSyntacticParent, binderOpt: binderOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 45345, 45473);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 44965, 45485);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 44965, 45485);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private CSharpTypeInfo GetTypeInfoForQuery(BoundQueryClause bound)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 45497, 45718);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 45588, 45707);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10923, 45595, 45608) || ((bound == null && DynAbs.Tracing.TraceSender.Conditional_F2(10923, 45628, 45647)) || DynAbs.Tracing.TraceSender.Conditional_F3(10923, 45667, 45706))) ? CSharpTypeInfo.None : f_10923_45667_45706(this, bound, bound, bound);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 45497, 45718);

                Microsoft.CodeAnalysis.CSharp.CSharpTypeInfo
                f_10923_45667_45706(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                lowestBoundNode, Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                highestBoundNode, Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                boundNodeForSyntacticParent)
                {
                    var return_v = this_param.GetTypeInfoForNode((Microsoft.CodeAnalysis.CSharp.BoundNode)lowestBoundNode, (Microsoft.CodeAnalysis.CSharp.BoundNode)highestBoundNode, (Microsoft.CodeAnalysis.CSharp.BoundNode)boundNodeForSyntacticParent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 45667, 45706);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 45497, 45718);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 45497, 45718);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override QueryClauseInfo GetQueryClauseInfo(QueryClauseSyntax node, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 45730, 45991);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 45895, 45933);

                var
                bound = f_10923_45907_45932(this, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 45947, 45980);

                return f_10923_45954_45979(this, bound);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 45730, 45991);

                Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                f_10923_45907_45932(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.QueryClauseSyntax
                node)
                {
                    var return_v = this_param.GetBoundQueryClause((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 45907, 45932);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.QueryClauseInfo
                f_10923_45954_45979(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                bound)
                {
                    var return_v = this_param.GetQueryClauseInfo(bound);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 45954, 45979);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 45730, 45991);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 45730, 45991);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override IPropertySymbol GetDeclaredSymbol(AnonymousObjectMemberDeclaratorSyntax declaratorSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 46003, 47163);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 46199, 46233);

                f_10923_46199_46232(this, declaratorSyntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 46247, 46342);

                var
                anonymousObjectCreation = (AnonymousObjectCreationExpressionSyntax)f_10923_46318_46341(declaratorSyntax)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 46356, 46452) || true) && (anonymousObjectCreation == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 46356, 46452);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 46425, 46437);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 46356, 46452);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 46468, 46570);

                var
                bound = f_10923_46480_46527(this, anonymousObjectCreation) as BoundAnonymousObjectCreationExpression
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 46584, 46662) || true) && (bound == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 46584, 46662);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 46635, 46647);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 46584, 46662);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 46678, 46728);

                var
                anonymousType = f_10923_46698_46708(bound) as NamedTypeSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 46742, 46836) || true) && ((object)anonymousType == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 46742, 46836);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 46809, 46821);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 46742, 46836);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 46852, 46927);

                int
                index = anonymousObjectCreation.Initializers.IndexOf(declaratorSyntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 46941, 46966);

                f_10923_46941_46965(index >= 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 46980, 47045);

                f_10923_46980_47044(index < anonymousObjectCreation.Initializers.Count);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 47059, 47152);

                return f_10923_47066_47151(f_10923_47066_47133(anonymousType, index));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 46003, 47163);

                int
                f_10923_46199_46232(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectMemberDeclaratorSyntax
                syntax)
                {
                    this_param.CheckSyntaxNode((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 46199, 46232);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10923_46318_46341(Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectMemberDeclaratorSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 46318, 46341);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10923_46480_46527(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectCreationExpressionSyntax
                node)
                {
                    var return_v = this_param.GetLowerBoundNode((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 46480, 46527);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10923_46698_46708(Microsoft.CodeAnalysis.CSharp.BoundAnonymousObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 46698, 46708);
                    return return_v;
                }


                int
                f_10923_46941_46965(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 46941, 46965);
                    return 0;
                }


                int
                f_10923_46980_47044(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 46980, 47044);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10923_47066_47133(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, int
                index)
                {
                    var return_v = AnonymousTypeManager.GetAnonymousTypeProperty(type, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 47066, 47133);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IPropertySymbol?
                f_10923_47066_47151(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 47066, 47151);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 46003, 47163);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 46003, 47163);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override INamedTypeSymbol GetDeclaredSymbol(AnonymousObjectCreationExpressionSyntax declaratorSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 47175, 47624);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 47374, 47408);

                f_10923_47374_47407(this, declaratorSyntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 47422, 47517);

                var
                bound = f_10923_47434_47474(this, declaratorSyntax) as BoundAnonymousObjectCreationExpression
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 47531, 47613);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10923, 47538, 47553) || (((bound == null) && DynAbs.Tracing.TraceSender.Conditional_F2(10923, 47556, 47560)) || DynAbs.Tracing.TraceSender.Conditional_F3(10923, 47563, 47612))) ? null : f_10923_47563_47612((f_10923_47564_47574(bound) as NamedTypeSymbol));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 47175, 47624);

                int
                f_10923_47374_47407(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectCreationExpressionSyntax
                syntax)
                {
                    this_param.CheckSyntaxNode((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 47374, 47407);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10923_47434_47474(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectCreationExpressionSyntax
                node)
                {
                    var return_v = this_param.GetLowerBoundNode((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 47434, 47474);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10923_47564_47574(Microsoft.CodeAnalysis.CSharp.BoundAnonymousObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 47564, 47574);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamedTypeSymbol?
                f_10923_47563_47612(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 47563, 47612);
                    return (INamedTypeSymbol?)return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 47175, 47624);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 47175, 47624);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override INamedTypeSymbol GetDeclaredSymbol(TupleExpressionSyntax declaratorSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 47636, 47941);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 47817, 47851);

                f_10923_47817_47850(this, declaratorSyntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 47865, 47930);

                return f_10923_47872_47929(f_10923_47872_47911(this, declaratorSyntax));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 47636, 47941);

                int
                f_10923_47817_47850(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TupleExpressionSyntax
                syntax)
                {
                    this_param.CheckSyntaxNode((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 47817, 47850);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10923_47872_47911(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TupleExpressionSyntax
                declaratorSyntax)
                {
                    var return_v = this_param.GetTypeOfTupleLiteral(declaratorSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 47872, 47911);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamedTypeSymbol?
                f_10923_47872_47929(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 47872, 47929);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 47636, 47941);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 47636, 47941);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ISymbol GetDeclaredSymbol(ArgumentSyntax declaratorSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 47953, 48961);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 48118, 48152);

                f_10923_48118_48151(this, declaratorSyntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 48191, 48297);

                var
                tupleLiteral = (DynAbs.Tracing.TraceSender.Conditional_F1(10923, 48210, 48238) || ((declaratorSyntax is not null && DynAbs.Tracing.TraceSender.Conditional_F2(10923, 48241, 48289)) || DynAbs.Tracing.TraceSender.Conditional_F3(10923, 48292, 48296))) ? f_10923_48241_48264(declaratorSyntax) as TupleExpressionSyntax : null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 48391, 48476) || true) && (tupleLiteral == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 48391, 48476);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 48449, 48461);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 48391, 48476);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 48492, 48551);

                var
                tupleLiteralType = f_10923_48515_48550(this, tupleLiteral)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 48567, 48922) || true) && ((object)tupleLiteralType != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 48567, 48922);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 48637, 48683);

                    var
                    elements = f_10923_48652_48682(tupleLiteralType)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 48703, 48907) || true) && (f_10923_48707_48726_M(!elements.IsDefault))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 48703, 48907);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 48768, 48827);

                        var
                        idx = tupleLiteral.Arguments.IndexOf(declaratorSyntax)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 48849, 48888);

                        return f_10923_48856_48887(elements[idx]);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 48703, 48907);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 48567, 48922);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 48938, 48950);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 47953, 48961);

                int
                f_10923_48118_48151(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax
                syntax)
                {
                    this_param.CheckSyntaxNode((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 48118, 48151);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10923_48241_48264(Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 48241, 48264);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10923_48515_48550(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TupleExpressionSyntax
                declaratorSyntax)
                {
                    var return_v = this_param.GetTypeOfTupleLiteral(declaratorSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 48515, 48550);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                f_10923_48652_48682(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TupleElements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 48652, 48682);
                    return return_v;
                }


                bool
                f_10923_48707_48726_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 48707, 48726);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IFieldSymbol?
                f_10923_48856_48887(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 48856, 48887);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 47953, 48961);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 47953, 48961);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private NamedTypeSymbol GetTypeOfTupleLiteral(TupleExpressionSyntax declaratorSyntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 48973, 49288);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 49083, 49136);

                var
                bound = f_10923_49095_49135(this, declaratorSyntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 49175, 49277);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10923, 49182, 49213) || (((bound is BoundTupleExpression) && DynAbs.Tracing.TraceSender.Conditional_F2(10923, 49216, 49269)) || DynAbs.Tracing.TraceSender.Conditional_F3(10923, 49272, 49276))) ? f_10923_49216_49250(((BoundTupleExpression)bound)) as NamedTypeSymbol : null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 48973, 49288);

                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10923_49095_49135(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TupleExpressionSyntax
                node)
                {
                    var return_v = this_param.GetLowerBoundNode((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 49095, 49135);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10923_49216_49250(Microsoft.CodeAnalysis.CSharp.BoundTupleExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 49216, 49250);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 48973, 49288);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 48973, 49288);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override SyntaxTree SyntaxTree
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 49362, 49437);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 49398, 49422);

                    return f_10923_49405_49421(_root);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 49362, 49437);

                    Microsoft.CodeAnalysis.SyntaxTree
                    f_10923_49405_49421(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    this_param)
                    {
                        var return_v = this_param.SyntaxTree;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 49405, 49421);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 49300, 49448);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 49300, 49448);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override IOperation? GetOperationWorker(CSharpSyntaxNode node, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 49478, 50461);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 49611, 49827);
                using (f_10923_49618_49647(_nodeMapLock))
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 49681, 49812) || true) && (f_10923_49685_49716(_guardedIOperationNodeMap) != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 49681, 49812);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 49763, 49793);

                        return f_10923_49770_49792();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 49681, 49812);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(10923, 49611, 49827);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 49843, 49889);

                IOperation
                rootOperation = f_10923_49870_49888(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 49905, 49950);

                using var
                _ = f_10923_49919_49949(_nodeMapLock)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 49966, 50085) || true) && (f_10923_49970_50001(_guardedIOperationNodeMap) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 49966, 50085);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 50040, 50070);

                    return f_10923_50047_50069();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 49966, 50085);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 50101, 50172);

                f_10923_50101_50171(rootOperation, _guardedIOperationNodeMap);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 50186, 50216);

                return f_10923_50193_50215();

                IOperation? guardedGetIOperation()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 50232, 50450);
                        Microsoft.CodeAnalysis.IOperation operation = default(Microsoft.CodeAnalysis.IOperation);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 50299, 50328);

                        f_10923_50299_50327(_nodeMapLock);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 50346, 50435);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(10923, 50353, 50415) || ((f_10923_50353_50415(_guardedIOperationNodeMap, node, out operation) && DynAbs.Tracing.TraceSender.Conditional_F2(10923, 50418, 50427)) || DynAbs.Tracing.TraceSender.Conditional_F3(10923, 50430, 50434))) ? operation : null;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 50232, 50450);

                        int
                        f_10923_50299_50327(System.Threading.ReaderWriterLockSlim
                        @lock)
                        {
                            @lock.AssertCanRead();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 50299, 50327);
                            return 0;
                        }


                        bool
                        f_10923_50353_50415(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.IOperation>
                        this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                        key, out Microsoft.CodeAnalysis.IOperation
                        value)
                        {
                            var return_v = this_param.TryGetValue((Microsoft.CodeAnalysis.SyntaxNode)key, out value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 50353, 50415);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 50232, 50450);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 50232, 50450);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 49478, 50461);

                Roslyn.Utilities.ReaderWriterLockSlimExtensions.ReadLockExiter
                f_10923_49618_49647(System.Threading.ReaderWriterLockSlim
                @lock)
                {
                    var return_v = @lock.DisposableRead();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 49618, 49647);
                    return return_v;
                }


                int
                f_10923_49685_49716(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.IOperation>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 49685, 49716);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_10923_49770_49792()
                {
                    var return_v = guardedGetIOperation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 49770, 49792);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_10923_49870_49888(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param)
                {
                    var return_v = this_param.GetRootOperation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 49870, 49888);
                    return return_v;
                }


                Roslyn.Utilities.ReaderWriterLockSlimExtensions.WriteLockExiter
                f_10923_49919_49949(System.Threading.ReaderWriterLockSlim
                @lock)
                {
                    var return_v = @lock.DisposableWrite();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 49919, 49949);
                    return return_v;
                }


                int
                f_10923_49970_50001(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.IOperation>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 49970, 50001);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_10923_50047_50069()
                {
                    var return_v = guardedGetIOperation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 50047, 50069);
                    return return_v;
                }


                int
                f_10923_50101_50171(Microsoft.CodeAnalysis.IOperation
                root, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.IOperation>
                dictionary)
                {
                    OperationMapBuilder.AddToMap(root, dictionary);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 50101, 50171);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_10923_50193_50215()
                {
                    var return_v = guardedGetIOperation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 50193, 50215);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 49478, 50461);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 49478, 50461);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private CSharpSyntaxNode GetBindingRootOrInitializer(CSharpSyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 50492, 53368);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 50592, 50644);

                CSharpSyntaxNode
                bindingRoot = f_10923_50623_50643(this, node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 50840, 51136) || true) && (bindingRoot is ParameterSyntax && (DynAbs.Tracing.TraceSender.Expression_True(10923, 50844, 50945) && f_10923_50895_50933(((ParameterSyntax)bindingRoot)) is not null) && (DynAbs.Tracing.TraceSender.Expression_True(10923, 50844, 51041) && f_10923_50966_51004(((ParameterSyntax)bindingRoot)).FullSpan.Contains(f_10923_51023_51032(node)) == true))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 50840, 51136);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 51075, 51121);

                    return f_10923_51082_51120(((ParameterSyntax)bindingRoot));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 50840, 51136);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 51370, 52175) || true) && (bindingRoot is VariableDeclaratorSyntax && (DynAbs.Tracing.TraceSender.Expression_True(10923, 51374, 51498) && f_10923_51435_51486(((VariableDeclaratorSyntax)bindingRoot)) is not null) && (DynAbs.Tracing.TraceSender.Expression_True(10923, 51374, 51607) && f_10923_51519_51570(((VariableDeclaratorSyntax)bindingRoot)).FullSpan.Contains(f_10923_51589_51598(node)) == true))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 51370, 52175);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 51641, 52160) || true) && ((f_10923_51646_51692(((VariableDeclaratorSyntax)bindingRoot)) is not null && (DynAbs.Tracing.TraceSender.Expression_True(10923, 51646, 51827) && f_10923_51730_51819(f_10923_51730_51783(f_10923_51730_51776(((VariableDeclaratorSyntax)bindingRoot))), SyntaxKind.FieldDeclaration) == true)) || (DynAbs.Tracing.TraceSender.Expression_False(10923, 51645, 52040) || (f_10923_51854_51900(((VariableDeclaratorSyntax)bindingRoot)) is not null && (DynAbs.Tracing.TraceSender.Expression_True(10923, 51854, 52039) && f_10923_51937_52031(f_10923_51937_51990(f_10923_51937_51983(((VariableDeclaratorSyntax)bindingRoot))), SyntaxKind.EventFieldDeclaration) == true))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 51641, 52160);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 52082, 52141);

                        return f_10923_52089_52140(((VariableDeclaratorSyntax)bindingRoot));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 51641, 52160);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 51370, 52175);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 52392, 52748) || true) && (bindingRoot is EnumMemberDeclarationSyntax && (DynAbs.Tracing.TraceSender.Expression_True(10923, 52396, 52525) && f_10923_52459_52513(((EnumMemberDeclarationSyntax)bindingRoot)) is not null) && (DynAbs.Tracing.TraceSender.Expression_True(10923, 52396, 52637) && f_10923_52546_52600(((EnumMemberDeclarationSyntax)bindingRoot)).FullSpan.Contains(f_10923_52619_52628(node)) == true))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 52392, 52748);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 52671, 52733);

                    return f_10923_52678_52732(((EnumMemberDeclarationSyntax)bindingRoot));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 52392, 52748);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 52973, 53322) || true) && (bindingRoot is PropertyDeclarationSyntax && (DynAbs.Tracing.TraceSender.Expression_True(10923, 52977, 53103) && f_10923_53039_53091(((PropertyDeclarationSyntax)bindingRoot)) is not null) && (DynAbs.Tracing.TraceSender.Expression_True(10923, 52977, 53213) && f_10923_53124_53176(((PropertyDeclarationSyntax)bindingRoot)).FullSpan.Contains(f_10923_53195_53204(node)) == true))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 52973, 53322);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 53247, 53307);

                    return f_10923_53254_53306(((PropertyDeclarationSyntax)bindingRoot));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 52973, 53322);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 53338, 53357);

                return bindingRoot;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 50492, 53368);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10923_50623_50643(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetBindingRoot(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 50623, 50643);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax?
                f_10923_50895_50933(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                this_param)
                {
                    var return_v = this_param.Default;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 50895, 50933);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax?
                f_10923_50966_51004(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                this_param)
                {
                    var return_v = this_param.Default;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 50966, 51004);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10923_51023_51032(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Span;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 51023, 51032);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax?
                f_10923_51082_51120(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                this_param)
                {
                    var return_v = this_param.Default;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 51082, 51120);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax?
                f_10923_51435_51486(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 51435, 51486);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax?
                f_10923_51519_51570(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 51519, 51570);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10923_51589_51598(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Span;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 51589, 51598);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10923_51646_51692(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 51646, 51692);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10923_51730_51776(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 51730, 51776);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10923_51730_51783(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 51730, 51783);
                    return return_v;
                }


                bool
                f_10923_51730_51819(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = node.IsKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 51730, 51819);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10923_51854_51900(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 51854, 51900);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10923_51937_51983(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 51937, 51983);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10923_51937_51990(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 51937, 51990);
                    return return_v;
                }


                bool
                f_10923_51937_52031(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = node.IsKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 51937, 52031);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax?
                f_10923_52089_52140(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 52089, 52140);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax?
                f_10923_52459_52513(Microsoft.CodeAnalysis.CSharp.Syntax.EnumMemberDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.EqualsValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 52459, 52513);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax?
                f_10923_52546_52600(Microsoft.CodeAnalysis.CSharp.Syntax.EnumMemberDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.EqualsValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 52546, 52600);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10923_52619_52628(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Span;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 52619, 52628);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax?
                f_10923_52678_52732(Microsoft.CodeAnalysis.CSharp.Syntax.EnumMemberDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.EqualsValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 52678, 52732);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax?
                f_10923_53039_53091(Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 53039, 53091);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax?
                f_10923_53124_53176(Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 53124, 53176);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10923_53195_53204(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Span;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 53195, 53204);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax?
                f_10923_53254_53306(Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 53254, 53306);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 50492, 53368);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 50492, 53368);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private IOperation GetRootOperation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 53398, 54582);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 53460, 53504);

                BoundNode
                highestBoundNode = f_10923_53489_53503(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 53518, 53557);

                f_10923_53518_53556(highestBoundNode != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 53573, 53939) || true) && (highestBoundNode is BoundGlobalStatementInitializer { Statement: var innerStatement })
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 53573, 53939);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 53890, 53924);

                    highestBoundNode = innerStatement;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 53573, 53939);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 54331, 54394);

                f_10923_54331_54393(f_10923_54344_54365(highestBoundNode) != BoundKind.UnboundLambda);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 54408, 54480);

                IOperation
                operation = f_10923_54431_54479(f_10923_54431_54454(_operationFactory), highestBoundNode)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 54494, 54540);

                f_10923_54494_54539(operation, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 54554, 54571);

                return operation;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 53398, 54582);

                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10923_53489_53503(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param)
                {
                    var return_v = this_param.GetBoundRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 53489, 53503);
                    return return_v;
                }


                int
                f_10923_53518_53556(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 53518, 53556);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10923_54344_54365(Microsoft.CodeAnalysis.CSharp.BoundNode
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 54344, 54365);
                    return return_v;
                }


                int
                f_10923_54331_54393(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 54331, 54393);
                    return 0;
                }


                Microsoft.CodeAnalysis.Operations.CSharpOperationFactory
                f_10923_54431_54454(System.Lazy<Microsoft.CodeAnalysis.Operations.CSharpOperationFactory>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 54431, 54454);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_10923_54431_54479(Microsoft.CodeAnalysis.Operations.CSharpOperationFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                boundNode)
                {
                    var return_v = this_param.Create(boundNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 54431, 54479);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_10923_54494_54539(Microsoft.CodeAnalysis.IOperation
                operation, Microsoft.CodeAnalysis.IOperation?
                parent)
                {
                    var return_v = Operation.SetParentOperation(operation, parent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 54494, 54539);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 53398, 54582);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 53398, 54582);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override SymbolInfo GetSymbolInfoWorker(CSharpSyntaxNode node, SymbolInfoOptions options, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 54613, 55364);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 54802, 54837);

                f_10923_54802_54836(options);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 54853, 54883);

                CSharpSyntaxNode
                bindableNode
                = default(CSharpSyntaxNode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 54897, 54923);

                BoundNode
                lowestBoundNode
                = default(BoundNode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 54937, 54964);

                BoundNode
                highestBoundNode
                = default(BoundNode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 54978, 55000);

                BoundNode
                boundParent
                = default(BoundNode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 55014, 55112);

                f_10923_55014_55111(this, node, out bindableNode, out lowestBoundNode, out highestBoundNode, out boundParent);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 55128, 55232);

                f_10923_55128_55231(f_10923_55141_55155(this, node), "Since the node is in the tree, we can always recompute the binder later");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 55246, 55353);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetSymbolInfoForNode(options, lowestBoundNode, highestBoundNode, boundParent, binderOpt: null), 10923, 55253, 55352);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 54613, 55364);

                int
                f_10923_54802_54836(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel.SymbolInfoOptions
                options)
                {
                    ValidateSymbolInfoOptions(options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 54802, 54836);
                    return 0;
                }


                int
                f_10923_55014_55111(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, out Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                bindableNode, out Microsoft.CodeAnalysis.CSharp.BoundNode
                lowestBoundNode, out Microsoft.CodeAnalysis.CSharp.BoundNode
                highestBoundNode, out Microsoft.CodeAnalysis.CSharp.BoundNode
                boundParent)
                {
                    this_param.GetBoundNodes(node, out bindableNode, out lowestBoundNode, out highestBoundNode, out boundParent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 55014, 55111);
                    return 0;
                }


                bool
                f_10923_55141_55155(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.IsInTree((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 55141, 55155);
                    return return_v;
                }


                int
                f_10923_55128_55231(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 55128, 55231);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 54613, 55364);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 54613, 55364);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override CSharpTypeInfo GetTypeInfoWorker(CSharpSyntaxNode node, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 55376, 55900);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 55540, 55570);

                CSharpSyntaxNode
                bindableNode
                = default(CSharpSyntaxNode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 55584, 55610);

                BoundNode
                lowestBoundNode
                = default(BoundNode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 55624, 55651);

                BoundNode
                highestBoundNode
                = default(BoundNode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 55665, 55687);

                BoundNode
                boundParent
                = default(BoundNode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 55701, 55799);

                f_10923_55701_55798(this, node, out bindableNode, out lowestBoundNode, out highestBoundNode, out boundParent);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 55815, 55889);

                return f_10923_55822_55888(this, lowestBoundNode, highestBoundNode, boundParent);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 55376, 55900);

                int
                f_10923_55701_55798(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, out Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                bindableNode, out Microsoft.CodeAnalysis.CSharp.BoundNode
                lowestBoundNode, out Microsoft.CodeAnalysis.CSharp.BoundNode
                highestBoundNode, out Microsoft.CodeAnalysis.CSharp.BoundNode
                boundParent)
                {
                    this_param.GetBoundNodes(node, out bindableNode, out lowestBoundNode, out highestBoundNode, out boundParent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 55701, 55798);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpTypeInfo
                f_10923_55822_55888(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                lowestBoundNode, Microsoft.CodeAnalysis.CSharp.BoundNode
                highestBoundNode, Microsoft.CodeAnalysis.CSharp.BoundNode
                boundNodeForSyntacticParent)
                {
                    var return_v = this_param.GetTypeInfoForNode(lowestBoundNode, highestBoundNode, boundNodeForSyntacticParent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 55822, 55888);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 55376, 55900);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 55376, 55900);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<Symbol> GetMemberGroupWorker(CSharpSyntaxNode node, SymbolInfoOptions options, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 55912, 56608);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 56114, 56144);

                CSharpSyntaxNode
                bindableNode
                = default(CSharpSyntaxNode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 56158, 56184);

                BoundNode
                lowestBoundNode
                = default(BoundNode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 56198, 56225);

                BoundNode
                highestBoundNode
                = default(BoundNode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 56239, 56261);

                BoundNode
                boundParent
                = default(BoundNode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 56275, 56373);

                f_10923_56275_56372(this, node, out bindableNode, out lowestBoundNode, out highestBoundNode, out boundParent);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 56389, 56493);

                f_10923_56389_56492(f_10923_56402_56416(this, node), "Since the node is in the tree, we can always recompute the binder later");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 56507, 56597);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetMemberGroupForNode(options, lowestBoundNode, boundParent, binderOpt: null), 10923, 56514, 56596);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 55912, 56608);

                int
                f_10923_56275_56372(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, out Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                bindableNode, out Microsoft.CodeAnalysis.CSharp.BoundNode
                lowestBoundNode, out Microsoft.CodeAnalysis.CSharp.BoundNode
                highestBoundNode, out Microsoft.CodeAnalysis.CSharp.BoundNode
                boundParent)
                {
                    this_param.GetBoundNodes(node, out bindableNode, out lowestBoundNode, out highestBoundNode, out boundParent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 56275, 56372);
                    return 0;
                }


                bool
                f_10923_56402_56416(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.IsInTree((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 56402, 56416);
                    return return_v;
                }


                int
                f_10923_56389_56492(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 56389, 56492);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 55912, 56608);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 55912, 56608);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<IPropertySymbol> GetIndexerGroupWorker(CSharpSyntaxNode node, SymbolInfoOptions options, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 56620, 57305);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 56832, 56862);

                CSharpSyntaxNode
                bindableNode
                = default(CSharpSyntaxNode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 56876, 56902);

                BoundNode
                lowestBoundNode
                = default(BoundNode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 56916, 56943);

                BoundNode
                highestBoundNode
                = default(BoundNode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 56957, 56979);

                BoundNode
                boundParent
                = default(BoundNode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 56993, 57091);

                f_10923_56993_57090(this, node, out bindableNode, out lowestBoundNode, out highestBoundNode, out boundParent);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 57107, 57211);

                f_10923_57107_57210(f_10923_57120_57134(this, node), "Since the node is in the tree, we can always recompute the binder later");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 57225, 57294);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetIndexerGroupForNode(lowestBoundNode, binderOpt: null), 10923, 57232, 57293);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 56620, 57305);

                int
                f_10923_56993_57090(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, out Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                bindableNode, out Microsoft.CodeAnalysis.CSharp.BoundNode
                lowestBoundNode, out Microsoft.CodeAnalysis.CSharp.BoundNode
                highestBoundNode, out Microsoft.CodeAnalysis.CSharp.BoundNode
                boundParent)
                {
                    this_param.GetBoundNodes(node, out bindableNode, out lowestBoundNode, out highestBoundNode, out boundParent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 56993, 57090);
                    return 0;
                }


                bool
                f_10923_57120_57134(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.IsInTree((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 57120, 57134);
                    return return_v;
                }


                int
                f_10923_57107_57210(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 57107, 57210);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 56620, 57305);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 56620, 57305);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override Optional<object> GetConstantValueWorker(CSharpSyntaxNode node, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 57317, 57947);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 57459, 57524);

                CSharpSyntaxNode
                bindableNode = f_10923_57491_57523(this, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 57538, 57622);

                BoundExpression
                boundExpr = f_10923_57566_57602(this, bindableNode) as BoundExpression
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 57638, 57694) || true) && (boundExpr == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 57638, 57694);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 57661, 57694);

                    return default(Optional<object>);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 57638, 57694);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 57710, 57764);

                ConstantValue
                constantValue = f_10923_57740_57763(boundExpr)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 57778, 57936);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10923, 57785, 57829) || ((constantValue == null || (DynAbs.Tracing.TraceSender.Expression_False(10923, 57785, 57829) || f_10923_57810_57829(constantValue)) && DynAbs.Tracing.TraceSender.Conditional_F2(10923, 57849, 57874)) || DynAbs.Tracing.TraceSender.Conditional_F3(10923, 57894, 57935))) ? default(Optional<object>)
                : f_10923_57894_57935(f_10923_57915_57934(constantValue));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 57317, 57947);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10923_57491_57523(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetBindableSyntaxNode(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 57491, 57523);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10923_57566_57602(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetLowerBoundNode(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 57566, 57602);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10923_57740_57763(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 57740, 57763);
                    return return_v;
                }


                bool
                f_10923_57810_57829(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.IsBad
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 57810, 57829);
                    return return_v;
                }


                object?
                f_10923_57915_57934(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 57915, 57934);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Optional<object>
                f_10923_57894_57935(object?
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.Optional<object>(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 57894, 57935);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 57317, 57947);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 57317, 57947);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override SymbolInfo GetCollectionInitializerSymbolInfoWorker(InitializerExpressionSyntax collectionInitializer, ExpressionSyntax node, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 57959, 58689);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 58193, 58307);

                var
                boundCollectionInitializer = f_10923_58226_58266(this, collectionInitializer) as BoundCollectionInitializerExpression
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 58323, 58639) || true) && (boundCollectionInitializer != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 58323, 58639);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 58395, 58499);

                    var
                    boundAdd = f_10923_58410_58449(boundCollectionInitializer)[collectionInitializer.Expressions.IndexOf(node)]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 58519, 58624);

                    return f_10923_58526_58623(this, SymbolInfoOptions.DefaultOptions, boundAdd, boundAdd, null, binderOpt: null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 58323, 58639);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 58655, 58678);

                return SymbolInfo.None;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 57959, 58689);

                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10923_58226_58266(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InitializerExpressionSyntax
                node)
                {
                    var return_v = this_param.GetLowerBoundNode((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 58226, 58266);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10923_58410_58449(Microsoft.CodeAnalysis.CSharp.BoundCollectionInitializerExpression
                this_param)
                {
                    var return_v = this_param.Initializers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 58410, 58449);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolInfo
                f_10923_58526_58623(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel.SymbolInfoOptions
                options, Microsoft.CodeAnalysis.CSharp.BoundExpression
                lowestBoundNode, Microsoft.CodeAnalysis.CSharp.BoundExpression
                highestBoundNode, Microsoft.CodeAnalysis.CSharp.BoundNode
                boundNodeForSyntacticParent, Microsoft.CodeAnalysis.CSharp.Binder
                binderOpt)
                {
                    var return_v = this_param.GetSymbolInfoForNode(options, (Microsoft.CodeAnalysis.CSharp.BoundNode)lowestBoundNode, (Microsoft.CodeAnalysis.CSharp.BoundNode)highestBoundNode, boundNodeForSyntacticParent, binderOpt: binderOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 58526, 58623);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 57959, 58689);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 57959, 58689);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override SymbolInfo GetSymbolInfo(OrderingSyntax node, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 58701, 58952);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 58853, 58891);

                var
                bound = f_10923_58865_58890(this, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 58905, 58941);

                return f_10923_58912_58940(this, bound);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 58701, 58952);

                Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                f_10923_58865_58890(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.OrderingSyntax
                node)
                {
                    var return_v = this_param.GetBoundQueryClause((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 58865, 58890);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolInfo
                f_10923_58912_58940(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                bound)
                {
                    var return_v = this_param.GetSymbolInfoForQuery(bound);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 58912, 58940);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 58701, 58952);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 58701, 58952);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override SymbolInfo GetSymbolInfo(SelectOrGroupClauseSyntax node, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 58964, 59226);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 59127, 59165);

                var
                bound = f_10923_59139_59164(this, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 59179, 59215);

                return f_10923_59186_59214(this, bound);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 58964, 59226);

                Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                f_10923_59139_59164(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SelectOrGroupClauseSyntax
                node)
                {
                    var return_v = this_param.GetBoundQueryClause((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 59139, 59164);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolInfo
                f_10923_59186_59214(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                bound)
                {
                    var return_v = this_param.GetSymbolInfoForQuery(bound);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 59186, 59214);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 58964, 59226);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 58964, 59226);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override TypeInfo GetTypeInfo(SelectOrGroupClauseSyntax node, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 59238, 59494);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 59397, 59435);

                var
                bound = f_10923_59409_59434(this, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 59449, 59483);

                return f_10923_59456_59482(this, bound);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 59238, 59494);

                Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                f_10923_59409_59434(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SelectOrGroupClauseSyntax
                node)
                {
                    var return_v = this_param.GetBoundQueryClause((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 59409, 59434);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpTypeInfo
                f_10923_59456_59482(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                bound)
                {
                    var return_v = this_param.GetTypeInfoForQuery(bound);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 59456, 59482);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 59238, 59494);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 59238, 59494);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void GetBoundNodes(CSharpSyntaxNode node, out CSharpSyntaxNode bindableNode, out BoundNode lowestBoundNode, out BoundNode highestBoundNode, out BoundNode boundParent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 59506, 61882);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 59705, 59753);

                bindableNode = f_10923_59720_59752(this, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 59769, 59844);

                CSharpSyntaxNode
                bindableParent = f_10923_59803_59843(this, bindableNode)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 61349, 61629) || true) && (bindableParent != null && (DynAbs.Tracing.TraceSender.Expression_True(10923, 61353, 61443) && f_10923_61379_61400(bindableParent) == SyntaxKind.SimpleMemberAccessExpression) && (DynAbs.Tracing.TraceSender.Expression_True(10923, 61353, 61520) && f_10923_61447_61504(((MemberAccessExpressionSyntax)bindableParent)) == bindableNode))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 61349, 61629);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 61554, 61614);

                    bindableParent = f_10923_61571_61613(this, bindableParent);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 61349, 61629);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 61645, 61730);

                boundParent = (DynAbs.Tracing.TraceSender.Conditional_F1(10923, 61659, 61681) || ((bindableParent == null && DynAbs.Tracing.TraceSender.Conditional_F2(10923, 61684, 61688)) || DynAbs.Tracing.TraceSender.Conditional_F3(10923, 61691, 61729))) ? null : f_10923_61691_61729(this, bindableParent);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 61746, 61801);

                lowestBoundNode = f_10923_61764_61800(this, bindableNode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 61815, 61871);

                highestBoundNode = f_10923_61834_61870(this, bindableNode);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 59506, 61882);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10923_59720_59752(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetBindableSyntaxNode(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 59720, 59752);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10923_59803_59843(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetBindableParentNode(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 59803, 59843);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10923_61379_61400(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 61379, 61400);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10923_61447_61504(Microsoft.CodeAnalysis.CSharp.Syntax.MemberAccessExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 61447, 61504);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10923_61571_61613(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetBindableParentNode(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 61571, 61613);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10923_61691_61729(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetLowerBoundNode(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 61691, 61729);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10923_61764_61800(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetLowerBoundNode(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 61764, 61800);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10923_61834_61870(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetUpperBoundNode(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 61834, 61870);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 59506, 61882);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 59506, 61882);
            }
        }

        private CSharpSyntaxNode GetInnermostLambdaOrQuery(CSharpSyntaxNode node, int position, bool allowStarting = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 63005, 64977);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 63145, 63172);

                f_10923_63145_63171(node != null);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 63197, 63211);

                    for (var
        current = node
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 63188, 64597) || true) && (current != f_10923_63224_63233(this))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 63235, 63283)
        , current = f_10923_63245_63283(current), DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 63188, 64597))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 63188, 64597);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 63652, 63757);

                        f_10923_63652_63756(current != null, "Why are we being asked to find an enclosing lambda outside of our root?");

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 63777, 63904) || true) && (!(f_10923_63783_63812(current) || (DynAbs.Tracing.TraceSender.Expression_False(10923, 63783, 63833) || f_10923_63816_63833(current))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 63777, 63904);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 63876, 63885);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 63777, 63904);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 64047, 64184) || true) && (!f_10923_64052_64114(position, current))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 64047, 64184);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 64156, 64165);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 64047, 64184);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 64440, 64547) || true) && (!allowStarting && (DynAbs.Tracing.TraceSender.Expression_True(10923, 64444, 64477) && current == node))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 64440, 64547);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 64519, 64528);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 64440, 64547);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 64567, 64582);

                        return current;
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10923, 1, 1410);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10923, 1, 1410);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 64954, 64966);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 63005, 64977);

                int
                f_10923_63145_63171(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 63145, 63171);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10923_63224_63233(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param)
                {
                    var return_v = this_param.Root;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 63224, 63233);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10923_63245_63283(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.ParentOrStructuredTriviaParent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 63245, 63283);
                    return return_v;
                }


                int
                f_10923_63652_63756(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 63652, 63756);
                    return 0;
                }


                bool
                f_10923_63783_63812(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax)
                {
                    var return_v = syntax.IsAnonymousFunction();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 63783, 63812);
                    return return_v;
                }


                bool
                f_10923_63816_63833(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax)
                {
                    var return_v = syntax.IsQuery();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 63816, 63833);
                    return return_v;
                }


                bool
                f_10923_64052_64114(int
                position, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                lambdaExpressionOrQueryNode)
                {
                    var return_v = LookupPosition.IsInAnonymousFunctionOrQuery(position, (Microsoft.CodeAnalysis.SyntaxNode)lambdaExpressionOrQueryNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 64052, 64114);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 63005, 64977);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 63005, 64977);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void GuardedAddSynthesizedStatementToMap(StatementSyntax node, BoundStatement statement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 64989, 65376);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 65110, 65291) || true) && (_lazyGuardedSynthesizedStatementsMap == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 65110, 65291);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 65192, 65276);

                    _lazyGuardedSynthesizedStatementsMap = f_10923_65231_65275();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 65110, 65291);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 65307, 65365);

                f_10923_65307_65364(
                            _lazyGuardedSynthesizedStatementsMap, node, statement);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 64989, 65376);

                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10923_65231_65275()
                {
                    var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.CSharp.BoundStatement>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 65231, 65275);
                    return return_v;
                }


                int
                f_10923_65307_65364(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                key, Microsoft.CodeAnalysis.CSharp.BoundStatement
                value)
                {
                    this_param.Add((Microsoft.CodeAnalysis.SyntaxNode)key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 65307, 65364);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 64989, 65376);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 64989, 65376);
            }
        }

        private BoundStatement GuardedGetSynthesizedStatementFromMap(StatementSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 65388, 65747);
                Microsoft.CodeAnalysis.CSharp.BoundStatement result = default(Microsoft.CodeAnalysis.CSharp.BoundStatement);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 65495, 65708) || true) && (_lazyGuardedSynthesizedStatementsMap != null && (DynAbs.Tracing.TraceSender.Expression_True(10923, 65499, 65645) && f_10923_65564_65645(_lazyGuardedSynthesizedStatementsMap, node, out result)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 65495, 65708);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 65679, 65693);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 65495, 65708);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 65724, 65736);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 65388, 65747);

                bool
                f_10923_65564_65645(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                key, out Microsoft.CodeAnalysis.CSharp.BoundStatement
                value)
                {
                    var return_v = this_param.TryGetValue((Microsoft.CodeAnalysis.SyntaxNode)key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 65564, 65645);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 65388, 65747);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 65388, 65747);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<BoundNode> GuardedGetBoundNodesFromMap(CSharpSyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 65759, 66118);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 65868, 65942);

                f_10923_65868_65941(f_10923_65881_65909(_nodeMapLock) || (DynAbs.Tracing.TraceSender.Expression_False(10923, 65881, 65940) || f_10923_65913_65940(_nodeMapLock)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 65956, 65989);

                ImmutableArray<BoundNode>
                result
                = default(ImmutableArray<BoundNode>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 66003, 66107);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10923, 66010, 66060) || ((f_10923_66010_66060(_guardedBoundNodeMap, node, out result) && DynAbs.Tracing.TraceSender.Conditional_F2(10923, 66063, 66069)) || DynAbs.Tracing.TraceSender.Conditional_F3(10923, 66072, 66106))) ? result : default(ImmutableArray<BoundNode>);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 65759, 66118);

                bool
                f_10923_65881_65909(System.Threading.ReaderWriterLockSlim
                this_param)
                {
                    var return_v = this_param.IsWriteLockHeld;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 65881, 65909);
                    return return_v;
                }


                bool
                f_10923_65913_65940(System.Threading.ReaderWriterLockSlim
                this_param)
                {
                    var return_v = this_param.IsReadLockHeld;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 65913, 65940);
                    return return_v;
                }


                int
                f_10923_65868_65941(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 65868, 65941);
                    return 0;
                }


                bool
                f_10923_66010_66060(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxNode, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>>
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                key, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>
                value)
                {
                    var return_v = this_param.TryGetValue((Microsoft.CodeAnalysis.SyntaxNode)key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 66010, 66060);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 65759, 66118);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 65759, 66118);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ImmutableArray<BoundNode> TestOnlyTryGetBoundNodesFromMap(CSharpSyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 66222, 66498);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 66336, 66369);

                ImmutableArray<BoundNode>
                result
                = default(ImmutableArray<BoundNode>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 66383, 66487);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10923, 66390, 66440) || ((f_10923_66390_66440(_guardedBoundNodeMap, node, out result) && DynAbs.Tracing.TraceSender.Conditional_F2(10923, 66443, 66449)) || DynAbs.Tracing.TraceSender.Conditional_F3(10923, 66452, 66486))) ? result : default(ImmutableArray<BoundNode>);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 66222, 66498);

                bool
                f_10923_66390_66440(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxNode, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>>
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                key, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>
                value)
                {
                    var return_v = this_param.TryGetValue((Microsoft.CodeAnalysis.SyntaxNode)key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 66390, 66440);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 66222, 66498);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 66222, 66498);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<BoundNode> GuardedAddBoundTreeAndGetBoundNodeFromMap(CSharpSyntaxNode syntax, BoundNode bound)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 66680, 67643);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 66822, 66865);

                f_10923_66822_66864(f_10923_66835_66863(_nodeMapLock));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 66881, 66908);

                bool
                alreadyInTree = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 66924, 67053) || true) && (bound != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 66924, 67053);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 66975, 67038);

                    alreadyInTree = f_10923_66991_67037(_guardedBoundNodeMap, bound.Syntax);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 66924, 67053);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 67233, 67463) || true) && (!alreadyInTree)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 67233, 67463);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 67285, 67350);

                    f_10923_67285_67349(bound, _guardedBoundNodeMap, f_10923_67338_67348());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 67368, 67448);

                    f_10923_67368_67447(syntax != _root || (DynAbs.Tracing.TraceSender.Expression_False(10923, 67381, 67446) || f_10923_67400_67446(_guardedBoundNodeMap, bound.Syntax)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 67233, 67463);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 67479, 67512);

                ImmutableArray<BoundNode>
                result
                = default(ImmutableArray<BoundNode>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 67526, 67632);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10923, 67533, 67585) || ((f_10923_67533_67585(_guardedBoundNodeMap, syntax, out result) && DynAbs.Tracing.TraceSender.Conditional_F2(10923, 67588, 67594)) || DynAbs.Tracing.TraceSender.Conditional_F3(10923, 67597, 67631))) ? result : default(ImmutableArray<BoundNode>);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 66680, 67643);

                bool
                f_10923_66835_66863(System.Threading.ReaderWriterLockSlim
                this_param)
                {
                    var return_v = this_param.IsWriteLockHeld;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 66835, 66863);
                    return return_v;
                }


                int
                f_10923_66822_66864(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 66822, 66864);
                    return 0;
                }


                bool
                f_10923_66991_67037(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxNode, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>>
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 66991, 67037);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10923_67338_67348()
                {
                    var return_v = SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 67338, 67348);
                    return return_v;
                }


                int
                f_10923_67285_67349(Microsoft.CodeAnalysis.CSharp.BoundNode?
                root, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxNode, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>>
                map, Microsoft.CodeAnalysis.SyntaxTree
                tree)
                {
                    NodeMapBuilder.AddToMap(root, map, tree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 67285, 67349);
                    return 0;
                }


                bool
                f_10923_67400_67446(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxNode, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>>
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 67400, 67446);
                    return return_v;
                }


                int
                f_10923_67368_67447(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 67368, 67447);
                    return 0;
                }


                bool
                f_10923_67533_67585(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxNode, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>>
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                key, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>
                value)
                {
                    var return_v = this_param.TryGetValue((Microsoft.CodeAnalysis.SyntaxNode)key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 67533, 67585);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 66680, 67643);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 66680, 67643);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected void UnguardedAddBoundTreeForStandaloneSyntax(SyntaxNode syntax, BoundNode bound, NullableWalker.SnapshotManager manager = null, ImmutableDictionary<Symbol, Symbol> remappedSymbols = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 67655, 68055);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 67878, 68044);
                using (f_10923_67885_67915(_nodeMapLock))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 67949, 68029);

                    f_10923_67949_68028(this, syntax, bound, manager, remappedSymbols);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(10923, 67878, 68044);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 67655, 68055);

                Roslyn.Utilities.ReaderWriterLockSlimExtensions.WriteLockExiter
                f_10923_67885_67915(System.Threading.ReaderWriterLockSlim
                @lock)
                {
                    var return_v = @lock.DisposableWrite();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 67885, 67915);
                    return return_v;
                }


                int
                f_10923_67949_68028(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundNode
                bound, Microsoft.CodeAnalysis.CSharp.NullableWalker.SnapshotManager?
                manager, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>?
                remappedSymbols)
                {
                    this_param.GuardedAddBoundTreeForStandaloneSyntax(syntax, bound, manager, remappedSymbols);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 67949, 68028);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 67655, 68055);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 67655, 68055);
            }
        }

        protected void GuardedAddBoundTreeForStandaloneSyntax(SyntaxNode syntax, BoundNode bound, NullableWalker.SnapshotManager manager = null, ImmutableDictionary<Symbol, Symbol> remappedSymbols = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 68067, 70344);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 68288, 68331);

                f_10923_68288_68330(f_10923_68301_68329(_nodeMapLock));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 68345, 68372);

                bool
                alreadyInTree = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 68552, 68681) || true) && (bound != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 68552, 68681);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 68603, 68666);

                    alreadyInTree = f_10923_68619_68665(_guardedBoundNodeMap, bound.Syntax);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 68552, 68681);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 68697, 70333) || true) && (!alreadyInTree)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 68697, 70333);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 68749, 69560) || true) && (syntax == _root || (DynAbs.Tracing.TraceSender.Expression_False(10923, 68753, 68797) || syntax is StatementSyntax))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 68749, 69560);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 69156, 69221);

                        f_10923_69156_69220(bound, _guardedBoundNodeMap, f_10923_69209_69219());
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 69243, 69323);

                        f_10923_69243_69322(syntax != _root || (DynAbs.Tracing.TraceSender.Expression_False(10923, 69256, 69321) || f_10923_69275_69321(_guardedBoundNodeMap, bound.Syntax)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 68749, 69560);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 68749, 69560);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 69468, 69541);

                        f_10923_69468_69540(bound, _guardedBoundNodeMap, f_10923_69521_69531(), syntax);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 68749, 69560);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 69580, 70126);

                    f_10923_69580_70125((manager is null && (DynAbs.Tracing.TraceSender.Expression_True(10923, 69594, 69960) && (!f_10923_69615_69642(this) || (DynAbs.Tracing.TraceSender.Expression_False(10923, 69614, 69660) || syntax != f_10923_69656_69660()) || (DynAbs.Tracing.TraceSender.Expression_False(10923, 69614, 69684) || syntax is TypeSyntax) || (DynAbs.Tracing.TraceSender.Expression_False(10923, 69614, 69959) ||                                                  // Supporting attributes is tracked by
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            // https://github.com/dotnet/roslyn/issues/36066
                                                                      this is AttributeSemanticModel)))) || (DynAbs.Tracing.TraceSender.Expression_False(10923, 69593, 70124) || (manager is object && (DynAbs.Tracing.TraceSender.Expression_True(10923, 69996, 70042) && remappedSymbols is object) && (DynAbs.Tracing.TraceSender.Expression_True(10923, 69996, 70060) && syntax == f_10923_70056_70060()) && (DynAbs.Tracing.TraceSender.Expression_True(10923, 69996, 70091) && f_10923_70064_70091(this)) && (DynAbs.Tracing.TraceSender.Expression_True(10923, 69996, 70123) && _lazySnapshotManager is null))));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 70144, 70318) || true) && (manager is object)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 70144, 70318);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 70207, 70238);

                        _lazySnapshotManager = manager;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 70260, 70299);

                        _lazyRemappedSymbols = remappedSymbols;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 70144, 70318);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 68697, 70333);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 68067, 70344);

                bool
                f_10923_68301_68329(System.Threading.ReaderWriterLockSlim
                this_param)
                {
                    var return_v = this_param.IsWriteLockHeld;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 68301, 68329);
                    return return_v;
                }


                int
                f_10923_68288_68330(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 68288, 68330);
                    return 0;
                }


                bool
                f_10923_68619_68665(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxNode, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>>
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 68619, 68665);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10923_69209_69219()
                {
                    var return_v = SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 69209, 69219);
                    return return_v;
                }


                int
                f_10923_69156_69220(Microsoft.CodeAnalysis.CSharp.BoundNode?
                root, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxNode, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>>
                map, Microsoft.CodeAnalysis.SyntaxTree
                tree)
                {
                    NodeMapBuilder.AddToMap(root, map, tree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 69156, 69220);
                    return 0;
                }


                bool
                f_10923_69275_69321(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxNode, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>>
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 69275, 69321);
                    return return_v;
                }


                int
                f_10923_69243_69322(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 69243, 69322);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10923_69521_69531()
                {
                    var return_v = SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 69521, 69531);
                    return return_v;
                }


                int
                f_10923_69468_69540(Microsoft.CodeAnalysis.CSharp.BoundNode?
                root, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxNode, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>>
                map, Microsoft.CodeAnalysis.SyntaxTree
                tree, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    NodeMapBuilder.AddToMap(root, map, tree, node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 69468, 69540);
                    return 0;
                }


                bool
                f_10923_69615_69642(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param)
                {
                    var return_v = this_param.IsNullableAnalysisEnabled();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 69615, 69642);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10923_69656_69660()
                {
                    var return_v = Root;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 69656, 69660);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10923_70056_70060()
                {
                    var return_v = Root;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 70056, 70060);
                    return return_v;
                }


                bool
                f_10923_70064_70091(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param)
                {
                    var return_v = this_param.IsNullableAnalysisEnabled();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 70064, 70091);
                    return return_v;
                }


                int
                f_10923_69580_70125(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 69580, 70125);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 68067, 70344);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 68067, 70344);
            }
        }

        private CSharpSyntaxNode GetBindingRoot(CSharpSyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 70601, 72258);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 70688, 70715);

                f_10923_70688_70714(node != null);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 70764, 70778);

                    for (CSharpSyntaxNode
        current = node
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 70742, 71019) || true) && (current != f_10923_70791_70800(this))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 70802, 70850)
        , current = f_10923_70812_70850(current), DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 70742, 71019))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 70742, 71019);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 70938, 71004);

                        f_10923_70938_71003(current != null, "How did we get outside the root?");
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10923, 1, 278);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10923, 1, 278);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 71065, 71079);

                    for (CSharpSyntaxNode
        current = node
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 71043, 72214) || true) && (current != f_10923_71092_71101(this))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 71103, 71151)
        , current = f_10923_71113_71151(current), DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 71043, 72214))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 71043, 72214);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 71185, 71291) || true) && (current is StatementSyntax)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 71185, 71291);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 71257, 71272);

                            return current;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 71185, 71291);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 71311, 72199);

                        switch (f_10923_71319_71333(current))
                        {

                            case SyntaxKind.ThisConstructorInitializer:
                            case SyntaxKind.BaseConstructorInitializer:
                            case SyntaxKind.PrimaryConstructorBaseType:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 71311, 72199);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 71574, 71589);

                                return current;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 71311, 72199);

                            case SyntaxKind.ArrowExpressionClause:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 71311, 72199);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 71960, 72148) || true) && (f_10923_71964_71978(current) == null || (DynAbs.Tracing.TraceSender.Expression_False(10923, 71964, 72048) || f_10923_71990_72011(f_10923_71990_72004(current)) != SyntaxKind.LocalFunctionStatement))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 71960, 72148);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 72106, 72121);

                                    return current;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 71960, 72148);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(10923, 72174, 72180);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 71311, 72199);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10923, 1, 1172);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10923, 1, 1172);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 72230, 72247);

                return f_10923_72237_72246(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 70601, 72258);

                int
                f_10923_70688_70714(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 70688, 70714);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10923_70791_70800(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param)
                {
                    var return_v = this_param.Root;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 70791, 70800);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10923_70812_70850(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.ParentOrStructuredTriviaParent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 70812, 70850);
                    return return_v;
                }


                int
                f_10923_70938_71003(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 70938, 71003);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10923_71092_71101(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param)
                {
                    var return_v = this_param.Root;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 71092, 71101);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10923_71113_71151(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.ParentOrStructuredTriviaParent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 71113, 71151);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10923_71319_71333(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 71319, 71333);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10923_71964_71978(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 71964, 71978);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10923_71990_72004(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 71990, 72004);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10923_71990_72011(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 71990, 72011);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10923_72237_72246(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param)
                {
                    var return_v = this_param.Root;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 72237, 72246);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 70601, 72258);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 70601, 72258);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override Binder GetEnclosingBinderInternal(int position)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 72855, 73473);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 72945, 72978);

                f_10923_72945_72977(this, position);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 73177, 73261) || true) && (!f_10923_73182_73191(this).FullSpan.Contains(position))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 73177, 73261);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 73238, 73261);

                    return this.RootBinder;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 73177, 73261);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 73277, 73327);

                SyntaxToken
                token = f_10923_73297_73326(f_10923_73297_73306(this), position)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 73341, 73396);

                CSharpSyntaxNode
                node = (CSharpSyntaxNode)token.Parent
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 73412, 73462);

                return f_10923_73419_73461(this, node, position);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 72855, 73473);

                int
                f_10923_72945_72977(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, int
                position)
                {
                    this_param.AssertPositionAdjusted(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 72945, 72977);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10923_73182_73191(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param)
                {
                    var return_v = this_param.Root;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 73182, 73191);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10923_73297_73306(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param)
                {
                    var return_v = this_param.Root;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 73297, 73306);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10923_73297_73326(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param, int
                position)
                {
                    var return_v = this_param.FindToken(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 73297, 73326);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10923_73419_73461(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                node, int
                position)
                {
                    var return_v = this_param.GetEnclosingBinderInternal(node, position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 73419, 73461);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 72855, 73473);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 72855, 73473);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Binder GetEnclosingBinderInternal(CSharpSyntaxNode node, int position)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 73667, 75388);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 73770, 73803);

                f_10923_73770_73802(this, position);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 73819, 73920);

                CSharpSyntaxNode
                innerLambdaOrQuery = f_10923_73857_73919(this, node, position, allowStarting: true)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 74963, 75102) || true) && (innerLambdaOrQuery == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 74963, 75102);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 75027, 75087);

                    return f_10923_75034_75086(this, node, position);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 74963, 75102);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 75179, 75257);

                BoundNode
                boundInnerLambdaOrQuery = f_10923_75215_75256(this, innerLambdaOrQuery)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 75271, 75377);

                return f_10923_75278_75376(this, position, node, innerLambdaOrQuery, ref boundInnerLambdaOrQuery);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 73667, 75388);

                int
                f_10923_73770_73802(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, int
                position)
                {
                    this_param.AssertPositionAdjusted(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 73770, 73802);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10923_73857_73919(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, int
                position, bool
                allowStarting)
                {
                    var return_v = this_param.GetInnermostLambdaOrQuery(node, position, allowStarting: allowStarting);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 73857, 73919);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10923_75034_75086(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, int
                position)
                {
                    var return_v = this_param.GetEnclosingBinderInternalWithinRoot((Microsoft.CodeAnalysis.SyntaxNode)node, position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 75034, 75086);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10923_75215_75256(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                lambdaOrQuery)
                {
                    var return_v = this_param.GetBoundLambdaOrQuery(lambdaOrQuery);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 75215, 75256);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10923_75278_75376(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, int
                position, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                innerLambdaOrQuery, ref Microsoft.CodeAnalysis.CSharp.BoundNode
                boundInnerLambdaOrQuery)
                {
                    var return_v = this_param.GetEnclosingBinderInLambdaOrQuery(position, node, innerLambdaOrQuery, ref boundInnerLambdaOrQuery);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 75278, 75376);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 73667, 75388);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 73667, 75388);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundNode GetBoundLambdaOrQuery(CSharpSyntaxNode lambdaOrQuery)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 75400, 80392);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 75658, 75690);

                ImmutableArray<BoundNode>
                nodes
                = default(ImmutableArray<BoundNode>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 75706, 75754);

                f_10923_75706_75753(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 75770, 75906);
                using (f_10923_75777_75806(_nodeMapLock))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 75840, 75891);

                    nodes = f_10923_75848_75890(this, lambdaOrQuery);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(10923, 75770, 75906);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 75922, 76030) || true) && (f_10923_75926_75949_M(!nodes.IsDefaultOrEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 75922, 76030);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 75983, 76015);

                    return f_10923_75990_76014(nodes);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 75922, 76030);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 76147, 76175);

                Binder
                lambdaRecoveryBinder
                = default(Binder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 76189, 76250);

                CSharpSyntaxNode
                bindingRoot = f_10923_76220_76249(this, lambdaOrQuery)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 76264, 76394);

                CSharpSyntaxNode
                enclosingLambdaOrQuery = f_10923_76306_76393(this, lambdaOrQuery, f_10923_76347_76370(lambdaOrQuery), allowStarting: false)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 76408, 76453);

                BoundNode
                boundEnclosingLambdaOrQuery = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 76467, 76495);

                CSharpSyntaxNode
                nodeToBind
                = default(CSharpSyntaxNode);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 76511, 77967) || true) && (enclosingLambdaOrQuery == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 76511, 77967);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 76579, 76604);

                    nodeToBind = bindingRoot;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 76622, 76731);

                    lambdaRecoveryBinder = f_10923_76645_76730(this, nodeToBind, f_10923_76694_76729(this, nodeToBind));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 76511, 77967);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 76511, 77967);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 76797, 77163) || true) && (enclosingLambdaOrQuery == bindingRoot || (DynAbs.Tracing.TraceSender.Expression_False(10923, 76801, 76887) || !f_10923_76843_76887(enclosingLambdaOrQuery, bindingRoot)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 76797, 77163);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 76929, 76988);

                        f_10923_76929_76987(f_10923_76942_76986(bindingRoot, enclosingLambdaOrQuery));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 77010, 77037);

                        nodeToBind = lambdaOrQuery;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 76797, 77163);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 76797, 77163);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 77119, 77144);

                        nodeToBind = bindingRoot;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 76797, 77163);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 77183, 77259);

                    boundEnclosingLambdaOrQuery = f_10923_77213_77258(this, enclosingLambdaOrQuery);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 77279, 77427);
                    using (f_10923_77286_77315(_nodeMapLock))
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 77357, 77408);

                        nodes = f_10923_77365_77407(this, lambdaOrQuery);
                        DynAbs.Tracing.TraceSender.TraceExitUsing(10923, 77279, 77427);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 77447, 77769) || true) && (f_10923_77451_77474_M(!nodes.IsDefaultOrEmpty))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 77447, 77769);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 77718, 77750);

                        return f_10923_77725_77749(nodes);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 77447, 77769);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 77789, 77952);

                    lambdaRecoveryBinder = f_10923_77812_77951(this, f_10923_77846_77881(this, nodeToBind), nodeToBind, enclosingLambdaOrQuery, ref boundEnclosingLambdaOrQuery);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 76511, 77967);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 77983, 78060);

                Binder
                incrementalBinder = f_10923_78010_78059(this, lambdaRecoveryBinder)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 78076, 78533);
                using (f_10923_78083_78113(_nodeMapLock))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 78147, 78242);

                    BoundNode
                    boundOuterExpression = f_10923_78180_78241(this, incrementalBinder, nodeToBind, _ignoredDiagnostics)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 78431, 78518);

                    nodes = f_10923_78439_78517(this, lambdaOrQuery, boundOuterExpression);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(10923, 78076, 78533);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 78549, 78657) || true) && (f_10923_78553_78576_M(!nodes.IsDefaultOrEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 78549, 78657);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 78610, 78642);

                    return f_10923_78617_78641(nodes);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 78549, 78657);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 78673, 78715);

                f_10923_78673_78714(lambdaOrQuery != nodeToBind);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 79086, 79519) || true) && (enclosingLambdaOrQuery == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 79086, 79519);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 79154, 79269);

                    lambdaRecoveryBinder = f_10923_79177_79268(this, lambdaOrQuery, f_10923_79229_79267(this, lambdaOrQuery));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 79086, 79519);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 79086, 79519);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 79335, 79504);

                    lambdaRecoveryBinder = f_10923_79358_79503(this, f_10923_79392_79430(this, lambdaOrQuery), lambdaOrQuery, enclosingLambdaOrQuery, ref boundEnclosingLambdaOrQuery);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 79086, 79519);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 79535, 79605);

                incrementalBinder = f_10923_79555_79604(this, lambdaRecoveryBinder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 79621, 80333);
                using (f_10923_79628_79658(_nodeMapLock))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 79692, 79790);

                    BoundNode
                    boundOuterExpression = f_10923_79725_79789(this, incrementalBinder, lambdaOrQuery, _ignoredDiagnostics)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 79944, 80211) || true) && (!f_10923_79949_79976(this) && (DynAbs.Tracing.TraceSender.Expression_True(10923, 79948, 80023) && f_10923_79980_80023(f_10923_79980_79991())))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 79944, 80211);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 80065, 80192);

                        f_10923_80065_80191(this, boundOuterExpression, incrementalBinder, diagnostics: f_10923_80147_80166(), createSnapshots: false);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 79944, 80211);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 80231, 80318);

                    nodes = f_10923_80239_80317(this, lambdaOrQuery, boundOuterExpression);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(10923, 79621, 80333);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 80349, 80381);

                return f_10923_80356_80380(nodes);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 75400, 80392);

                int
                f_10923_75706_75753(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param)
                {
                    this_param.EnsureNullabilityAnalysisPerformedIfNecessary();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 75706, 75753);
                    return 0;
                }


                Roslyn.Utilities.ReaderWriterLockSlimExtensions.ReadLockExiter
                f_10923_75777_75806(System.Threading.ReaderWriterLockSlim
                @lock)
                {
                    var return_v = @lock.DisposableRead();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 75777, 75806);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>
                f_10923_75848_75890(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GuardedGetBoundNodesFromMap(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 75848, 75890);
                    return return_v;
                }


                bool
                f_10923_75926_75949_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 75926, 75949);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10923_75990_76014(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>
                boundNodes)
                {
                    var return_v = GetLowerBoundNode(boundNodes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 75990, 76014);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10923_76220_76249(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetBindingRoot(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 76220, 76249);
                    return return_v;
                }


                int
                f_10923_76347_76370(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.SpanStart;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 76347, 76370);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10923_76306_76393(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, int
                position, bool
                allowStarting)
                {
                    var return_v = this_param.GetInnermostLambdaOrQuery(node, position, allowStarting: allowStarting);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 76306, 76393);
                    return return_v;
                }


                int
                f_10923_76694_76729(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetAdjustedNodePosition((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 76694, 76729);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10923_76645_76730(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, int
                position)
                {
                    var return_v = this_param.GetEnclosingBinderInternalWithinRoot((Microsoft.CodeAnalysis.SyntaxNode)node, position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 76645, 76730);
                    return return_v;
                }


                bool
                f_10923_76843_76887(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.Contains((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 76843, 76887);
                    return return_v;
                }


                bool
                f_10923_76942_76986(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.Contains((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 76942, 76986);
                    return return_v;
                }


                int
                f_10923_76929_76987(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 76929, 76987);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10923_77213_77258(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                lambdaOrQuery)
                {
                    var return_v = this_param.GetBoundLambdaOrQuery(lambdaOrQuery);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 77213, 77258);
                    return return_v;
                }


                Roslyn.Utilities.ReaderWriterLockSlimExtensions.ReadLockExiter
                f_10923_77286_77315(System.Threading.ReaderWriterLockSlim
                @lock)
                {
                    var return_v = @lock.DisposableRead();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 77286, 77315);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>
                f_10923_77365_77407(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GuardedGetBoundNodesFromMap(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 77365, 77407);
                    return return_v;
                }


                bool
                f_10923_77451_77474_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 77451, 77474);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10923_77725_77749(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>
                boundNodes)
                {
                    var return_v = GetLowerBoundNode(boundNodes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 77725, 77749);
                    return return_v;
                }


                int
                f_10923_77846_77881(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetAdjustedNodePosition((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 77846, 77881);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10923_77812_77951(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, int
                position, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                innerLambdaOrQuery, ref Microsoft.CodeAnalysis.CSharp.BoundNode
                boundInnerLambdaOrQuery)
                {
                    var return_v = this_param.GetEnclosingBinderInLambdaOrQuery(position, node, innerLambdaOrQuery, ref boundInnerLambdaOrQuery);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 77812, 77951);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel.IncrementalBinder
                f_10923_78010_78059(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                semanticModel, Microsoft.CodeAnalysis.CSharp.Binder
                next)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MemberSemanticModel.IncrementalBinder(semanticModel, next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 78010, 78059);
                    return return_v;
                }


                Roslyn.Utilities.ReaderWriterLockSlimExtensions.WriteLockExiter
                f_10923_78083_78113(System.Threading.ReaderWriterLockSlim
                @lock)
                {
                    var return_v = @lock.DisposableWrite();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 78083, 78113);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10923_78180_78241(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Bind(binder, node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 78180, 78241);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>
                f_10923_78439_78517(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundNode
                bound)
                {
                    var return_v = this_param.GuardedAddBoundTreeAndGetBoundNodeFromMap(syntax, bound);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 78439, 78517);
                    return return_v;
                }


                bool
                f_10923_78553_78576_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 78553, 78576);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10923_78617_78641(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>
                boundNodes)
                {
                    var return_v = GetLowerBoundNode(boundNodes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 78617, 78641);
                    return return_v;
                }


                int
                f_10923_78673_78714(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 78673, 78714);
                    return 0;
                }


                int
                f_10923_79229_79267(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetAdjustedNodePosition((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 79229, 79267);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10923_79177_79268(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, int
                position)
                {
                    var return_v = this_param.GetEnclosingBinderInternalWithinRoot((Microsoft.CodeAnalysis.SyntaxNode)node, position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 79177, 79268);
                    return return_v;
                }


                int
                f_10923_79392_79430(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetAdjustedNodePosition((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 79392, 79430);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10923_79358_79503(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, int
                position, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                innerLambdaOrQuery, ref Microsoft.CodeAnalysis.CSharp.BoundNode?
                boundInnerLambdaOrQuery)
                {
                    var return_v = this_param.GetEnclosingBinderInLambdaOrQuery(position, node, innerLambdaOrQuery, ref boundInnerLambdaOrQuery);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 79358, 79503);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel.IncrementalBinder
                f_10923_79555_79604(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                semanticModel, Microsoft.CodeAnalysis.CSharp.Binder
                next)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MemberSemanticModel.IncrementalBinder(semanticModel, next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 79555, 79604);
                    return return_v;
                }


                Roslyn.Utilities.ReaderWriterLockSlimExtensions.WriteLockExiter
                f_10923_79628_79658(System.Threading.ReaderWriterLockSlim
                @lock)
                {
                    var return_v = @lock.DisposableWrite();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 79628, 79658);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10923_79725_79789(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Bind(binder, node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 79725, 79789);
                    return return_v;
                }


                bool
                f_10923_79949_79976(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param)
                {
                    var return_v = this_param.IsNullableAnalysisEnabled();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 79949, 79976);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10923_79980_79991()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 79980, 79991);
                    return return_v;
                }


                bool
                f_10923_79980_80023(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.IsNullableAnalysisEnabledAlways;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 79980, 80023);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10923_80147_80166()
                {
                    var return_v = new Microsoft.CodeAnalysis.DiagnosticBag();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 80147, 80166);
                    return return_v;
                }


                int
                f_10923_80065_80191(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                boundRoot, Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                createSnapshots)
                {
                    this_param.AnalyzeBoundNodeNullability(boundRoot, binder, diagnostics: diagnostics, createSnapshots: createSnapshots);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 80065, 80191);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>
                f_10923_80239_80317(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundNode
                bound)
                {
                    var return_v = this_param.GuardedAddBoundTreeAndGetBoundNodeFromMap(syntax, bound);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 80239, 80317);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10923_80356_80380(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>
                boundNodes)
                {
                    var return_v = GetLowerBoundNode(boundNodes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 80356, 80380);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 75400, 80392);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 75400, 80392);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Binder GetEnclosingBinderInLambdaOrQuery(int position, CSharpSyntaxNode node, CSharpSyntaxNode innerLambdaOrQuery, ref BoundNode boundInnerLambdaOrQuery)
        {
            Debug.Assert(boundInnerLambdaOrQuery != null);
            Binder result;
            switch (boundInnerLambdaOrQuery.Kind)
            {
                case BoundKind.UnboundLambda:
                    boundInnerLambdaOrQuery = ((UnboundLambda)boundInnerLambdaOrQuery).BindForErrorRecovery();
                    goto case BoundKind.Lambda;
                case BoundKind.Lambda:
                    AssertPositionAdjusted(position);
                    result = GetLambdaEnclosingBinder(position, node, innerLambdaOrQuery, ((BoundLambda)boundInnerLambdaOrQuery).Binder);
                    break;
                case BoundKind.QueryClause:
                    result = GetQueryEnclosingBinder(position, node, ((BoundQueryClause)boundInnerLambdaOrQuery));
                    break;
                default:
                    return GetEnclosingBinderInternalWithinRoot(node, position); // Known to return non-null with BinderFlags.SemanticModel.
            }

            Debug.Assert(result != null);
            return result.WithAdditionalFlags(GetSemanticModelBinderFlags());
        }

        /// <remarks>
        /// Returned binder doesn't need to have <see cref="BinderFlags.SemanticModel"/> set - the caller will add it.
        /// </remarks>
        private static Binder GetQueryEnclosingBinder(int position, CSharpSyntaxNode startingNode, BoundQueryClause queryClause)
        {
            BoundExpression node = queryClause;

            do
            {
                switch (node.Kind)
                {
                    case BoundKind.QueryClause:
                        queryClause = (BoundQueryClause)node;
                        node = GetQueryClauseValue(queryClause);
                        continue;
                    case BoundKind.Call:
                        var call = (BoundCall)node;
                        node = GetContainingArgument(call.Arguments, position);
                        if (node != null)
                        {
                            continue;
                        }

                        BoundExpression receiver = call.ReceiverOpt;

                        // In some error scenarios, we end-up with a method group as the receiver,
                        // let's get to real receiver.
                        // LAFHIS
                        while (receiver is not null && receiver.Kind == BoundKind.MethodGroup)
                        {
                            receiver = ((BoundMethodGroup)receiver).ReceiverOpt;
                        }

                        if (receiver != null)
                        {
                            node = GetContainingExprOrQueryClause(receiver, position);
                            if (node != null)
                            {
                                continue;
                            }
                        }

                        // TODO: should we look for the "nearest" argument as a fallback?
                        node = call.Arguments.LastOrDefault();
                        continue;
                    case BoundKind.Conversion:
                        node = ((BoundConversion)node).Operand;
                        continue;
                    case BoundKind.UnboundLambda:
                        var unbound = (UnboundLambda)node;
                        return GetEnclosingBinderInternalWithinRoot(AdjustStartingNodeAccordingToNewRoot(startingNode, unbound.Syntax),
                                                  position, unbound.BindForErrorRecovery().Binder, unbound.Syntax);
                    case BoundKind.Lambda:
                        var lambda = (BoundLambda)node;
                        return GetEnclosingBinderInternalWithinRoot(AdjustStartingNodeAccordingToNewRoot(startingNode, lambda.Body.Syntax),
                                                  position, lambda.Binder, lambda.Body.Syntax);
                    default:
                        goto done;
                }
            }
            while (node != null);

done:
            return GetEnclosingBinderInternalWithinRoot(AdjustStartingNodeAccordingToNewRoot(startingNode, queryClause.Syntax),
                                      position, queryClause.Binder, queryClause.Syntax);
        }

        private static BoundExpression GetContainingArgument(ImmutableArray<BoundExpression> arguments, int position)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10923, 85158, 85891);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 85292, 85322);

                BoundExpression
                result = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 85336, 85376);

                TextSpan
                resultSpan = default(TextSpan)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 85390, 85852);
                    foreach (var arg in f_10923_85410_85419_I(arguments))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 85390, 85852);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 85453, 85510);

                        var
                        expr = f_10923_85464_85509(arg, position)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 85528, 85837) || true) && (expr != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 85528, 85837);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 85586, 85618);

                            var
                            span = f_10923_85597_85617(expr.Syntax)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 85640, 85818) || true) && (result == null || (DynAbs.Tracing.TraceSender.Expression_False(10923, 85644, 85687) || resultSpan.Contains(span)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 85640, 85818);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 85737, 85751);

                                result = expr;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 85777, 85795);

                                resultSpan = span;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 85640, 85818);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 85528, 85837);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 85390, 85852);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10923, 1, 463);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10923, 1, 463);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 85866, 85880);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10923, 85158, 85891);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10923_85464_85509(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, int
                position)
                {
                    var return_v = GetContainingExprOrQueryClause(expr, position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 85464, 85509);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10923_85597_85617(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.FullSpan;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 85597, 85617);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10923_85410_85419_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 85410, 85419);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 85158, 85891);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 85158, 85891);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static BoundExpression GetContainingExprOrQueryClause(BoundExpression expr, int position)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10923, 86124, 86680);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 86246, 86525) || true) && (f_10923_86250_86259(expr) == BoundKind.QueryClause)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 86246, 86525);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 86318, 86374);

                    var
                    value = f_10923_86330_86373(expr)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 86392, 86510) || true) && (value.Syntax.FullSpan.Contains(position))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 86392, 86510);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 86478, 86491);

                        return value;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 86392, 86510);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 86246, 86525);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 86539, 86643) || true) && (expr.Syntax.FullSpan.Contains(position))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 86539, 86643);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 86616, 86628);

                    return expr;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 86539, 86643);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 86657, 86669);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10923, 86124, 86680);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10923_86250_86259(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 86250, 86259);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10923_86330_86373(Microsoft.CodeAnalysis.CSharp.BoundExpression
                queryClause)
                {
                    var return_v = GetQueryClauseValue((Microsoft.CodeAnalysis.CSharp.BoundQueryClause)queryClause);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 86330, 86373);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 86124, 86680);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 86124, 86680);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static BoundExpression GetQueryClauseValue(BoundQueryClause queryClause)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10923, 86692, 86864);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 86797, 86853);

                return f_10923_86804_86831(queryClause) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.BoundExpression?>(10923, 86804, 86852) ?? f_10923_86835_86852(queryClause));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10923, 86692, 86864);

                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10923_86804_86831(Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                this_param)
                {
                    var return_v = this_param.UnoptimizedForm;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 86804, 86831);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10923_86835_86852(Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 86835, 86852);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 86692, 86864);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 86692, 86864);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static SyntaxNode AdjustStartingNodeAccordingToNewRoot(SyntaxNode startingNode, SyntaxNode root)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10923, 86876, 87237);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 87005, 87075);

                SyntaxNode
                result = (DynAbs.Tracing.TraceSender.Conditional_F1(10923, 87025, 87052) || ((f_10923_87025_87052(startingNode, root) && DynAbs.Tracing.TraceSender.Conditional_F2(10923, 87055, 87059)) || DynAbs.Tracing.TraceSender.Conditional_F3(10923, 87062, 87074))) ? root : startingNode
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 87089, 87196) || true) && (result != root && (DynAbs.Tracing.TraceSender.Expression_True(10923, 87093, 87133) && !f_10923_87112_87133(root, result)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 87089, 87196);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 87167, 87181);

                    result = root;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 87089, 87196);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 87212, 87226);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10923, 86876, 87237);

                bool
                f_10923_87025_87052(Microsoft.CodeAnalysis.SyntaxNode
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.Contains(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 87025, 87052);
                    return return_v;
                }


                bool
                f_10923_87112_87133(Microsoft.CodeAnalysis.SyntaxNode
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.Contains(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 87112, 87133);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 86876, 87237);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 86876, 87237);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Binder GetLambdaEnclosingBinder(int position, CSharpSyntaxNode startingNode, CSharpSyntaxNode containingLambda, Binder lambdaBinder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10923, 87788, 88240);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 87960, 88013);

                f_10923_87960_88012(f_10923_87973_88011(containingLambda));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 88027, 88113);

                f_10923_88027_88112(f_10923_88040_88111(position, containingLambda));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 88129, 88229);

                return f_10923_88136_88228(startingNode, position, lambdaBinder, containingLambda);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10923, 87788, 88240);

                bool
                f_10923_87973_88011(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax)
                {
                    var return_v = syntax.IsAnonymousFunction();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 87973, 88011);
                    return return_v;
                }


                int
                f_10923_87960_88012(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 87960, 88012);
                    return 0;
                }


                bool
                f_10923_88040_88111(int
                position, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                lambdaExpressionOrQueryNode)
                {
                    var return_v = LookupPosition.IsInAnonymousFunctionOrQuery(position, (Microsoft.CodeAnalysis.SyntaxNode)lambdaExpressionOrQueryNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 88040, 88111);
                    return return_v;
                }


                int
                f_10923_88027_88112(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 88027, 88112);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10923_88136_88228(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, int
                position, Microsoft.CodeAnalysis.CSharp.Binder
                rootBinder, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                root)
                {
                    var return_v = GetEnclosingBinderInternalWithinRoot((Microsoft.CodeAnalysis.SyntaxNode)node, position, rootBinder, (Microsoft.CodeAnalysis.SyntaxNode)root);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 88136, 88228);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 87788, 88240);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 87788, 88240);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected void EnsureNullabilityAnalysisPerformedIfNecessary()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 88604, 94343);
                Microsoft.CodeAnalysis.CSharp.NullableWalker.SnapshotManager newSnapshots = default(Microsoft.CodeAnalysis.CSharp.NullableWalker.SnapshotManager);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 88691, 88752);

                bool
                isNullableAnalysisEnabled = f_10923_88724_88751(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 88766, 88900) || true) && (!isNullableAnalysisEnabled && (DynAbs.Tracing.TraceSender.Expression_True(10923, 88770, 88844) && f_10923_88800_88844_M(!f_10923_88801_88812().IsNullableAnalysisEnabledAlways)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 88766, 88900);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 88878, 88885);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 88766, 88900);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 89095, 89185) || true) && (_lazySnapshotManager is object)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 89095, 89185);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 89163, 89170);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 89095, 89185);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 89201, 89248);

                var
                bindableRoot = f_10923_89220_89247(this, f_10923_89242_89246())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 89262, 89331);

                using var
                upgradeableLock = f_10923_89290_89330(_nodeMapLock)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 89922, 90271) || true) && (f_10923_89926_89952(_guardedBoundNodeMap) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 89922, 90271);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 89990, 90231);

                    f_10923_89990_90230(!isNullableAnalysisEnabled || (DynAbs.Tracing.TraceSender.Expression_False(10923, 90003, 90109) || f_10923_90063_90109(_guardedBoundNodeMap, bindableRoot)) || (DynAbs.Tracing.TraceSender.Expression_False(10923, 90003, 90229) || f_10923_90143_90229(_guardedBoundNodeMap, f_10923_90176_90221(bindableRoot, f_10923_90195_90213(), out _).Syntax)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 90249, 90256);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 89922, 90271);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 90287, 90316);

                upgradeableLock.EnterWrite();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 90332, 90379);

                NullableWalker.SnapshotManager
                snapshotManager
                = default(NullableWalker.SnapshotManager);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 90393, 90441);

                var
                remappedSymbols = _parentRemappedSymbolsOpt
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 90455, 90469);

                Binder
                binder
                = default(Binder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 90483, 90532);

                DiagnosticBag
                diagnosticBag = f_10923_90513_90531()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 90548, 90616);

                BoundNode
                boundRoot = f_10923_90570_90615(bindableRoot, diagnosticBag, out binder)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 90632, 91562) || true) && (f_10923_90636_90662())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 90632, 91562);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 90963, 91151) || true) && (_parentSnapshotManagerOpt is null || (DynAbs.Tracing.TraceSender.Expression_False(10923, 90967, 91030) || !isNullableAnalysisEnabled))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 90963, 91151);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 91072, 91103);

                        f_10923_91072_91102(diagnosticBag);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 91125, 91132);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 90963, 91151);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 91171, 91337);

                    boundRoot = f_10923_91183_91336(_speculatedPosition, boundRoot, binder, _parentSnapshotManagerOpt, out newSnapshots, ref remappedSymbols);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 91355, 91450);

                    f_10923_91355_91449(this, bindableRoot, boundRoot, newSnapshots, remappedSymbols);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 90632, 91562);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 90632, 91562);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 91516, 91547);

                    f_10923_91516_91546(diagnosticBag);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 90632, 91562);
                }

                BoundNode bind(CSharpSyntaxNode root, DiagnosticBag diagnosticBag, out Binder binder)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 91578, 93229);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 91696, 93155) || true) && (root is CompilationUnitSyntax)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 91696, 93155);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 92893, 92929);

                            binder = f_10923_92902_92928(RootBinder, root);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 92951, 92995);

                            f_10923_92951_92994(binder is SimpleProgramBinder);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 91696, 93155);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 91696, 93155);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 93077, 93136);

                            binder = f_10923_93086_93135(this, f_10923_93105_93134(this, root));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 91696, 93155);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 93173, 93214);

                        return f_10923_93180_93213(this, binder, root, diagnosticBag);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 91578, 93229);

                        Microsoft.CodeAnalysis.CSharp.Binder?
                        f_10923_92902_92928(Microsoft.CodeAnalysis.CSharp.Binder
                        this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                        node)
                        {
                            var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode)node);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 92902, 92928);
                            return return_v;
                        }


                        int
                        f_10923_92951_92994(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 92951, 92994);
                            return 0;
                        }


                        int
                        f_10923_93105_93134(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                        this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                        node)
                        {
                            var return_v = this_param.GetAdjustedNodePosition((Microsoft.CodeAnalysis.SyntaxNode)node);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 93105, 93134);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Binder
                        f_10923_93086_93135(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                        this_param, int
                        position)
                        {
                            var return_v = this_param.GetEnclosingBinder(position);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 93086, 93135);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundNode
                        f_10923_93180_93213(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                        this_param, Microsoft.CodeAnalysis.CSharp.Binder
                        binder, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                        node, Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics)
                        {
                            var return_v = this_param.Bind(binder, node, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 93180, 93213);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 91578, 93229);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 91578, 93229);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                void rewriteAndCache(DiagnosticBag diagnosticBag)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 93245, 93913);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 93327, 93612) || true) && (!isNullableAnalysisEnabled)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 93327, 93612);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 93399, 93457);

                            f_10923_93399_93456(f_10923_93412_93455(f_10923_93412_93423()));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 93479, 93564);

                            f_10923_93479_93563(this, boundRoot, binder, diagnosticBag, createSnapshots: true);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 93586, 93593);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 93327, 93612);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 93632, 93782);

                        boundRoot = f_10923_93644_93781(this, boundRoot, binder, diagnosticBag, createSnapshots: true, out snapshotManager, ref remappedSymbols);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 93800, 93898);

                        f_10923_93800_93897(this, bindableRoot, boundRoot, snapshotManager, remappedSymbols);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 93245, 93913);

                        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        f_10923_93412_93423()
                        {
                            var return_v = Compilation;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 93412, 93423);
                            return return_v;
                        }


                        bool
                        f_10923_93412_93455(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        this_param)
                        {
                            var return_v = this_param.IsNullableAnalysisEnabledAlways;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 93412, 93455);
                            return return_v;
                        }


                        int
                        f_10923_93399_93456(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 93399, 93456);
                            return 0;
                        }


                        int
                        f_10923_93479_93563(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                        this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                        boundRoot, Microsoft.CodeAnalysis.CSharp.Binder
                        binder, Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics, bool
                        createSnapshots)
                        {
                            this_param.AnalyzeBoundNodeNullability(boundRoot, binder, diagnostics, createSnapshots: createSnapshots);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 93479, 93563);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundNode
                        f_10923_93644_93781(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                        this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                        boundRoot, Microsoft.CodeAnalysis.CSharp.Binder
                        binder, Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics, bool
                        createSnapshots, out Microsoft.CodeAnalysis.CSharp.NullableWalker.SnapshotManager
                        snapshotManager, ref System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>
                        remappedSymbols)
                        {
                            var return_v = this_param.RewriteNullableBoundNodesWithSnapshots(boundRoot, binder, diagnostics, createSnapshots: createSnapshots, out snapshotManager, ref remappedSymbols);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 93644, 93781);
                            return return_v;
                        }


                        int
                        f_10923_93800_93897(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                        this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                        syntax, Microsoft.CodeAnalysis.CSharp.BoundNode
                        bound, Microsoft.CodeAnalysis.CSharp.NullableWalker.SnapshotManager?
                        manager, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>?
                        remappedSymbols)
                        {
                            this_param.GuardedAddBoundTreeForStandaloneSyntax((Microsoft.CodeAnalysis.SyntaxNode)syntax, bound, manager, remappedSymbols);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 93800, 93897);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 93245, 93913);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 93245, 93913);
                    }
                }

                DiagnosticBag getDiagnosticBag()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 93929, 94332);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 94154, 94272) || true) && (!isNullableAnalysisEnabled)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 94154, 94272);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 94226, 94253);

                            return f_10923_94233_94252();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 94154, 94272);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 94290, 94317);

                        return _ignoredDiagnostics;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 93929, 94332);

                        Microsoft.CodeAnalysis.DiagnosticBag
                        f_10923_94233_94252()
                        {
                            var return_v = new Microsoft.CodeAnalysis.DiagnosticBag();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 94233, 94252);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 93929, 94332);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 93929, 94332);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 88604, 94343);

                bool
                f_10923_88724_88751(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param)
                {
                    var return_v = this_param.IsNullableAnalysisEnabled();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 88724, 88751);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10923_88801_88812()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 88801, 88812);
                    return return_v;
                }


                bool
                f_10923_88800_88844_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 88800, 88844);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10923_89242_89246()
                {
                    var return_v = Root;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 89242, 89246);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10923_89220_89247(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetBindableSyntaxNode(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 89220, 89247);
                    return return_v;
                }


                Roslyn.Utilities.ReaderWriterLockSlimExtensions.UpgradeableReadLockExiter
                f_10923_89290_89330(System.Threading.ReaderWriterLockSlim
                @lock)
                {
                    var return_v = @lock.DisposableUpgradeableRead();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 89290, 89330);
                    return return_v;
                }


                int
                f_10923_89926_89952(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxNode, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 89926, 89952);
                    return return_v;
                }


                bool
                f_10923_90063_90109(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxNode, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>>
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                key)
                {
                    var return_v = this_param.ContainsKey((Microsoft.CodeAnalysis.SyntaxNode)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 90063, 90109);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10923_90195_90213()
                {
                    var return_v = getDiagnosticBag();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 90195, 90213);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10923_90176_90221(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                root, Microsoft.CodeAnalysis.DiagnosticBag
                diagnosticBag, out Microsoft.CodeAnalysis.CSharp.Binder
                binder)
                {
                    var return_v = bind(root, diagnosticBag, out binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 90176, 90221);
                    return return_v;
                }


                bool
                f_10923_90143_90229(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxNode, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>>
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 90143, 90229);
                    return return_v;
                }


                int
                f_10923_89990_90230(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 89990, 90230);
                    return 0;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10923_90513_90531()
                {
                    var return_v = getDiagnosticBag();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 90513, 90531);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10923_90570_90615(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                root, Microsoft.CodeAnalysis.DiagnosticBag
                diagnosticBag, out Microsoft.CodeAnalysis.CSharp.Binder
                binder)
                {
                    var return_v = bind(root, diagnosticBag, out binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 90570, 90615);
                    return return_v;
                }


                bool
                f_10923_90636_90662()
                {
                    var return_v = IsSpeculativeSemanticModel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 90636, 90662);
                    return return_v;
                }


                int
                f_10923_91072_91102(Microsoft.CodeAnalysis.DiagnosticBag
                diagnosticBag)
                {
                    rewriteAndCache(diagnosticBag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 91072, 91102);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10923_91183_91336(int
                position, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.CSharp.NullableWalker.SnapshotManager
                originalSnapshots, out Microsoft.CodeAnalysis.CSharp.NullableWalker.SnapshotManager
                newSnapshots, ref System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>
                remappedSymbols)
                {
                    var return_v = NullableWalker.AnalyzeAndRewriteSpeculation(position, node, binder, originalSnapshots, out newSnapshots, ref remappedSymbols);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 91183, 91336);
                    return return_v;
                }


                int
                f_10923_91355_91449(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundNode
                bound, Microsoft.CodeAnalysis.CSharp.NullableWalker.SnapshotManager
                manager, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>?
                remappedSymbols)
                {
                    this_param.GuardedAddBoundTreeForStandaloneSyntax((Microsoft.CodeAnalysis.SyntaxNode)syntax, bound, manager, remappedSymbols);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 91355, 91449);
                    return 0;
                }


                int
                f_10923_91516_91546(Microsoft.CodeAnalysis.DiagnosticBag
                diagnosticBag)
                {
                    rewriteAndCache(diagnosticBag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 91516, 91546);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 88604, 94343);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 88604, 94343);
            }
        }

        protected abstract BoundNode RewriteNullableBoundNodesWithSnapshots(
                    BoundNode boundRoot,
                    Binder binder,
                    DiagnosticBag diagnostics,
                    bool createSnapshots,
                    out NullableWalker.SnapshotManager? snapshotManager,
                    ref ImmutableDictionary<Symbol, Symbol>? remappedSymbols);

        protected abstract void AnalyzeBoundNodeNullability(BoundNode boundRoot, Binder binder, DiagnosticBag diagnostics, bool createSnapshots);

        protected abstract bool IsNullableAnalysisEnabled();

        internal ImmutableArray<BoundNode> GetBoundNodes(CSharpSyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 95874, 99905);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 96135, 96235) || true) && (node == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 96135, 96235);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 96185, 96220);

                    node = f_10923_96192_96219(this, f_10923_96214_96218());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 96135, 96235);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 96249, 96299);

                f_10923_96249_96298(node == f_10923_96270_96297(this, node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 96315, 96363);

                f_10923_96315_96362(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 97013, 97047);

                ImmutableArray<BoundNode>
                results
                = default(ImmutableArray<BoundNode>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 97063, 97192);
                using (f_10923_97070_97099(_nodeMapLock))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 97133, 97177);

                    results = f_10923_97143_97176(this, node);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(10923, 97063, 97192);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 97208, 97301) || true) && (f_10923_97212_97237_M(!results.IsDefaultOrEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 97208, 97301);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 97271, 97286);

                    return results;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 97208, 97301);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 97644, 97695);

                CSharpSyntaxNode
                nodeToBind = f_10923_97674_97694(this, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 97709, 97787);

                var
                statementBinder = f_10923_97731_97786(this, f_10923_97750_97785(this, nodeToBind))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 97801, 97873);

                Binder
                incrementalBinder = f_10923_97828_97872(this, statementBinder)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 97889, 98156);
                using (f_10923_97896_97926(_nodeMapLock))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 97960, 98049);

                    BoundNode
                    boundStatement = f_10923_97987_98048(this, incrementalBinder, nodeToBind, _ignoredDiagnostics)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 98067, 98141);

                    results = f_10923_98077_98140(this, node, boundStatement);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(10923, 97889, 98156);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 98172, 98265) || true) && (f_10923_98176_98201_M(!results.IsDefaultOrEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 98172, 98265);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 98235, 98250);

                    return results;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 98172, 98265);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 98829, 98892);

                var
                binder = f_10923_98842_98891(this, f_10923_98861_98890(this, node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 98906, 98962);

                incrementalBinder = f_10923_98926_98961(this, binder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 98978, 99107);
                using (f_10923_98985_99014(_nodeMapLock))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 99048, 99092);

                    results = f_10923_99058_99091(this, node);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(10923, 98978, 99107);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 99123, 99839) || true) && (results.IsDefaultOrEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 99123, 99839);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 99304, 99618);
                    using (f_10923_99311_99341(_nodeMapLock))
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 99383, 99455);

                        var
                        boundNode = f_10923_99399_99454(this, incrementalBinder, node, _ignoredDiagnostics)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 99477, 99533);

                        f_10923_99477_99532(this, node, boundNode);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 99555, 99599);

                        results = f_10923_99565_99598(this, node);
                        DynAbs.Tracing.TraceSender.TraceExitUsing(10923, 99304, 99618);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 99638, 99743) || true) && (f_10923_99642_99667_M(!results.IsDefaultOrEmpty))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 99638, 99743);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 99709, 99724);

                        return results;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 99638, 99743);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 99123, 99839);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 99123, 99839);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 99809, 99824);

                    return results;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 99123, 99839);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 99855, 99894);

                return ImmutableArray<BoundNode>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 95874, 99905);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10923_96214_96218()
                {
                    var return_v = Root;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 96214, 96218);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10923_96192_96219(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetBindableSyntaxNode(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 96192, 96219);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10923_96270_96297(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetBindableSyntaxNode(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 96270, 96297);
                    return return_v;
                }


                int
                f_10923_96249_96298(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 96249, 96298);
                    return 0;
                }


                int
                f_10923_96315_96362(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param)
                {
                    this_param.EnsureNullabilityAnalysisPerformedIfNecessary();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 96315, 96362);
                    return 0;
                }


                Roslyn.Utilities.ReaderWriterLockSlimExtensions.ReadLockExiter
                f_10923_97070_97099(System.Threading.ReaderWriterLockSlim
                @lock)
                {
                    var return_v = @lock.DisposableRead();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 97070, 97099);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>
                f_10923_97143_97176(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GuardedGetBoundNodesFromMap(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 97143, 97176);
                    return return_v;
                }


                bool
                f_10923_97212_97237_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 97212, 97237);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10923_97674_97694(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetBindingRoot(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 97674, 97694);
                    return return_v;
                }


                int
                f_10923_97750_97785(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetAdjustedNodePosition((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 97750, 97785);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10923_97731_97786(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, int
                position)
                {
                    var return_v = this_param.GetEnclosingBinder(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 97731, 97786);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel.IncrementalBinder
                f_10923_97828_97872(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                semanticModel, Microsoft.CodeAnalysis.CSharp.Binder
                next)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MemberSemanticModel.IncrementalBinder(semanticModel, next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 97828, 97872);
                    return return_v;
                }


                Roslyn.Utilities.ReaderWriterLockSlimExtensions.WriteLockExiter
                f_10923_97896_97926(System.Threading.ReaderWriterLockSlim
                @lock)
                {
                    var return_v = @lock.DisposableWrite();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 97896, 97926);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10923_97987_98048(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Bind(binder, node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 97987, 98048);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>
                f_10923_98077_98140(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundNode
                bound)
                {
                    var return_v = this_param.GuardedAddBoundTreeAndGetBoundNodeFromMap(syntax, bound);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 98077, 98140);
                    return return_v;
                }


                bool
                f_10923_98176_98201_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 98176, 98201);
                    return return_v;
                }


                int
                f_10923_98861_98890(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetAdjustedNodePosition((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 98861, 98890);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10923_98842_98891(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, int
                position)
                {
                    var return_v = this_param.GetEnclosingBinder(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 98842, 98891);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel.IncrementalBinder
                f_10923_98926_98961(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                semanticModel, Microsoft.CodeAnalysis.CSharp.Binder
                next)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MemberSemanticModel.IncrementalBinder(semanticModel, next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 98926, 98961);
                    return return_v;
                }


                Roslyn.Utilities.ReaderWriterLockSlimExtensions.ReadLockExiter
                f_10923_98985_99014(System.Threading.ReaderWriterLockSlim
                @lock)
                {
                    var return_v = @lock.DisposableRead();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 98985, 99014);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>
                f_10923_99058_99091(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GuardedGetBoundNodesFromMap(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 99058, 99091);
                    return return_v;
                }


                Roslyn.Utilities.ReaderWriterLockSlimExtensions.WriteLockExiter
                f_10923_99311_99341(System.Threading.ReaderWriterLockSlim
                @lock)
                {
                    var return_v = @lock.DisposableWrite();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 99311, 99341);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10923_99399_99454(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Bind(binder, node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 99399, 99454);
                    return return_v;
                }


                int
                f_10923_99477_99532(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundNode
                bound)
                {
                    this_param.GuardedAddBoundTreeForStandaloneSyntax((Microsoft.CodeAnalysis.SyntaxNode)syntax, bound);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 99477, 99532);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>
                f_10923_99565_99598(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GuardedGetBoundNodesFromMap(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 99565, 99598);
                    return return_v;
                }


                bool
                f_10923_99642_99667_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 99642, 99667);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 95874, 99905);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 95874, 99905);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected internal virtual CSharpSyntaxNode GetBindableSyntaxNode(CSharpSyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 100039, 104787);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 100152, 101002);

                switch (f_10923_100160_100171(node))
                {

                    case SyntaxKind.GetAccessorDeclaration:
                    case SyntaxKind.SetAccessorDeclaration:
                    case SyntaxKind.InitAccessorDeclaration:
                    case SyntaxKind.AddAccessorDeclaration:
                    case SyntaxKind.RemoveAccessorDeclaration:
                    case SyntaxKind.MethodDeclaration:
                    case SyntaxKind.ConstructorDeclaration:
                    case SyntaxKind.DestructorDeclaration:
                    case SyntaxKind.OperatorDeclaration:
                    case SyntaxKind.ConversionOperatorDeclaration:
                    case SyntaxKind.GlobalStatement:
                    case SyntaxKind.Subpattern:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 100152, 101002);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 100876, 100888);

                        return node;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 100152, 101002);

                    case SyntaxKind.PositionalPatternClause:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 100152, 101002);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 100968, 100987);

                        return f_10923_100975_100986(node);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 100152, 101002);
                }
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 101018, 102036) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 101018, 102036);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 101063, 101995);

                        switch (node)
                        {

                            case ParenthesizedExpressionSyntax n:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 101063, 101995);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 101180, 101200);

                                node = f_10923_101187_101199(n);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 101226, 101235);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 101063, 101995);

                            case CheckedExpressionSyntax n:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 101063, 101995);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 101316, 101336);

                                node = f_10923_101323_101335(n);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 101362, 101371);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 101063, 101995);

                            case PostfixUnaryExpressionSyntax { RawKind: (int)SyntaxKind.SuppressNullableWarningExpression } n:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 101063, 101995);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 101665, 101682);

                                node = f_10923_101672_101681(n);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 101708, 101717);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 101063, 101995);

                            case UnsafeStatementSyntax n:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 101063, 101995);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 101796, 101811);

                                node = f_10923_101803_101810(n);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 101837, 101846);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 101063, 101995);

                            case CheckedStatementSyntax n:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 101063, 101995);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 101926, 101941);

                                node = f_10923_101933_101940(n);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 101967, 101976);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 101063, 101995);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10923, 102015, 102021);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 101018, 102036);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10923, 101018, 102036);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10923, 101018, 102036);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 102052, 102077);

                var
                parent = f_10923_102065_102076(node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 102091, 104748) || true) && (parent != null && (DynAbs.Tracing.TraceSender.Expression_True(10923, 102095, 102130) && node != f_10923_102121_102130(this)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 102091, 104748);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 102164, 104733);

                    switch (f_10923_102172_102183(node))
                    {

                        case SyntaxKind.IdentifierName:
                        case SyntaxKind.GenericName:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 102164, 104733);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 102332, 102380);

                            var
                            tmp = f_10923_102342_102379(node)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 102406, 102540) || true) && (tmp != node)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 102406, 102540);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 102479, 102513);

                                return f_10923_102486_102512(this, tmp);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 102406, 102540);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10923, 102568, 102574);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 102164, 104733);

                        case SyntaxKind.AnonymousObjectMemberDeclarator:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 102164, 104733);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 102672, 102709);

                            return f_10923_102679_102708(this, parent);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 102164, 104733);

                        case SyntaxKind.VariableDeclarator: // declarators are mapped in SyntaxBinder
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 102164, 104733);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 103242, 103304);

                            f_10923_103242_103303(f_10923_103255_103268(parent) == SyntaxKind.VariableDeclaration);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 103330, 103362);

                            var
                            grandparent = f_10923_103348_103361(parent)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 103388, 103684) || true) && (grandparent != null && (DynAbs.Tracing.TraceSender.Expression_True(10923, 103392, 103473) && f_10923_103415_103433(grandparent) == SyntaxKind.LocalDeclarationStatement) && (DynAbs.Tracing.TraceSender.Expression_True(10923, 103392, 103562) && ((VariableDeclarationSyntax)parent).Variables.Count == 1))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 103388, 103684);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 103620, 103657);

                                return f_10923_103627_103656(this, parent);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 103388, 103684);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10923, 103710, 103716);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 102164, 104733);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 102164, 104733);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 103774, 104680) || true) && (node is QueryExpressionSyntax && (DynAbs.Tracing.TraceSender.Expression_True(10923, 103778, 103844) && parent is QueryContinuationSyntax) || (DynAbs.Tracing.TraceSender.Expression_False(10923, 103778, 104558) || !(node is ExpressionSyntax) && (DynAbs.Tracing.TraceSender.Expression_True(10923, 103877, 103963) && !(node is StatementSyntax)) && (DynAbs.Tracing.TraceSender.Expression_True(10923, 103877, 104032) && !(node is SelectOrGroupClauseSyntax)) && (DynAbs.Tracing.TraceSender.Expression_True(10923, 103877, 104093) && !(node is QueryClauseSyntax)) && (DynAbs.Tracing.TraceSender.Expression_True(10923, 103877, 104151) && !(node is OrderingSyntax)) && (DynAbs.Tracing.TraceSender.Expression_True(10923, 103877, 104215) && !(node is JoinIntoClauseSyntax)) && (DynAbs.Tracing.TraceSender.Expression_True(10923, 103877, 104282) && !(node is QueryContinuationSyntax)) && (DynAbs.Tracing.TraceSender.Expression_True(10923, 103877, 104354) && !(node is ConstructorInitializerSyntax)) && (DynAbs.Tracing.TraceSender.Expression_True(10923, 103877, 104430) && !(node is PrimaryConstructorBaseTypeSyntax)) && (DynAbs.Tracing.TraceSender.Expression_True(10923, 103877, 104501) && !(node is ArrowExpressionClauseSyntax)) && (DynAbs.Tracing.TraceSender.Expression_True(10923, 103877, 104558) && !(node is PatternSyntax))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 103774, 104680);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 104616, 104653);

                                return f_10923_104623_104652(this, parent);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 103774, 104680);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10923, 104708, 104714);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 102164, 104733);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 102091, 104748);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 104764, 104776);

                return node;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 100039, 104787);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10923_100160_100171(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 100160, 100171);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10923_100975_100986(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 100975, 100986);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10923_101187_101199(Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 101187, 101199);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10923_101323_101335(Microsoft.CodeAnalysis.CSharp.Syntax.CheckedExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 101323, 101335);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10923_101672_101681(Microsoft.CodeAnalysis.CSharp.Syntax.PostfixUnaryExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 101672, 101681);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                f_10923_101803_101810(Microsoft.CodeAnalysis.CSharp.Syntax.UnsafeStatementSyntax
                this_param)
                {
                    var return_v = this_param.Block;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 101803, 101810);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                f_10923_101933_101940(Microsoft.CodeAnalysis.CSharp.Syntax.CheckedStatementSyntax
                this_param)
                {
                    var return_v = this_param.Block;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 101933, 101940);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10923_102065_102076(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 102065, 102076);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10923_102121_102130(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param)
                {
                    var return_v = this_param.Root;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 102121, 102130);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10923_102172_102183(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 102172, 102183);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10923_102342_102379(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = SyntaxFactory.GetStandaloneNode(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 102342, 102379);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10923_102486_102512(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                node)
                {
                    var return_v = this_param.GetBindableSyntaxNode(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 102486, 102512);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10923_102679_102708(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetBindableSyntaxNode(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 102679, 102708);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10923_103255_103268(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 103255, 103268);
                    return return_v;
                }


                int
                f_10923_103242_103303(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 103242, 103303);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10923_103348_103361(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 103348, 103361);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10923_103415_103433(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 103415, 103433);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10923_103627_103656(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetBindableSyntaxNode(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 103627, 103656);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10923_104623_104652(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetBindableSyntaxNode(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 104623, 104652);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 100039, 104787);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 100039, 104787);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        /// <summary>
        /// If the node is an expression, return the nearest parent node
        /// with semantic meaning. Otherwise return null.
        /// </summary>
        protected CSharpSyntaxNode GetBindableParentNode(CSharpSyntaxNode node)
        {
            if (!(node is ExpressionSyntax))
            {
                return null;
            }

            // The node is an expression, but its parent is null
            CSharpSyntaxNode parent = node.Parent;
            if (parent == null)
            {
                // For speculative model, expression might be the root of the syntax tree, in which case it can have a null parent.
                if (this.IsSpeculativeSemanticModel && this.Root == node)
                {
                    return null;
                }

                throw new ArgumentException($"The parent of {nameof(node)} must not be null unless this is a speculative semantic model.", nameof(node));
            }

            // skip up past parens and ref expressions, as we have no bound nodes for them.
            while (true)
            {
                switch (parent.Kind())
                {
                    case SyntaxKind.ParenthesizedExpression:
                    case SyntaxKind.RefExpression:
                    case SyntaxKind.RefType:
                        var pp = parent.Parent;
                        if (pp == null) break;
                        parent = pp;
                        break;
                    default:
                        goto foundParent;
                }
            }
foundParent:;

            var bindableParent = this.GetBindableSyntaxNode(parent);
            Debug.Assert(bindableParent != null);

            // If the parent is a member used for a method invocation, then
            // the node is the instance associated with the method invocation.
            // In that case, return the invocation expression so that any conversion
            // of the receiver can be included in the resulting SemanticInfo.
            if ((bindableParent.Kind() == SyntaxKind.SimpleMemberAccessExpression) && (bindableParent.Parent.Kind() == SyntaxKind.InvocationExpression))
            {
                bindableParent = bindableParent.Parent;
            }
            else if (bindableParent.Kind() == SyntaxKind.ArrayType)
            {
                bindableParent = SyntaxFactory.GetStandaloneExpression((ArrayTypeSyntax)bindableParent);
            }

            return bindableParent;
        }

        internal override Symbol RemapSymbolIfNecessaryCore(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 107385, 108008);
                Microsoft.CodeAnalysis.CSharp.Symbol remappedSymbol = default(Microsoft.CodeAnalysis.CSharp.Symbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 107476, 107587);

                f_10923_107476_107586(symbol is LocalSymbol or ParameterSymbol or MethodSymbol { MethodKind: MethodKind.LambdaMethod });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 107603, 107651);

                f_10923_107603_107650(this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 107667, 107762) || true) && (_lazyRemappedSymbols is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 107667, 107762);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 107733, 107747);

                    return symbol;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 107667, 107762);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 107778, 107997) || true) && (f_10923_107782_107846(_lazyRemappedSymbols, symbol, out remappedSymbol))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 107778, 107997);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 107880, 107902);

                    return remappedSymbol;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 107778, 107997);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 107778, 107997);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 107968, 107982);

                    return symbol;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 107778, 107997);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 107385, 108008);

                int
                f_10923_107476_107586(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 107476, 107586);
                    return 0;
                }


                int
                f_10923_107603_107650(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param)
                {
                    this_param.EnsureNullabilityAnalysisPerformedIfNecessary();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 107603, 107650);
                    return 0;
                }


                bool
                f_10923_107782_107846(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                key, out Microsoft.CodeAnalysis.CSharp.Symbol
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 107782, 107846);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 107385, 108008);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 107385, 108008);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override Func<SyntaxNode, bool> GetSyntaxNodesToAnalyzeFilter(SyntaxNode declaredNode, ISymbol declaredSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 108020, 108219);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 108171, 108208);

                throw f_10923_108177_108207();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 108020, 108219);

                System.Exception
                f_10923_108177_108207()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 108177, 108207);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 108020, 108219);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 108020, 108219);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        internal class IncrementalBinder : Binder
        {
            private readonly MemberSemanticModel _semanticModel;

            internal IncrementalBinder(MemberSemanticModel semanticModel, Binder next)
            : base(f_10923_109440_109444_C(next))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10923, 109341, 109524);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 109310, 109324);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 109478, 109509);

                    _semanticModel = semanticModel;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10923, 109341, 109524);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 109341, 109524);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 109341, 109524);
                }
            }

            internal override Binder GetBinder(SyntaxNode node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 109724, 110163);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 109808, 109850);

                    Binder
                    binder = f_10923_109824_109849(f_10923_109824_109833(this), node)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 109870, 110116) || true) && (binder != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 109870, 110116);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 109930, 109975);

                        f_10923_109930_109974(!(binder is IncrementalBinder));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 109997, 110097);

                        return f_10923_110004_110096(_semanticModel, f_10923_110042_110095(binder, BinderFlags.SemanticModel));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 109870, 110116);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 110136, 110148);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 109724, 110163);

                    Microsoft.CodeAnalysis.CSharp.Binder?
                    f_10923_109824_109833(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel.IncrementalBinder
                    this_param)
                    {
                        var return_v = this_param.Next;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 109824, 109833);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder?
                    f_10923_109824_109849(Microsoft.CodeAnalysis.CSharp.Binder?
                    this_param, Microsoft.CodeAnalysis.SyntaxNode
                    node)
                    {
                        var return_v = this_param.GetBinder(node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 109824, 109849);
                        return return_v;
                    }


                    int
                    f_10923_109930_109974(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 109930, 109974);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10923_110042_110095(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param, Microsoft.CodeAnalysis.CSharp.BinderFlags
                    flags)
                    {
                        var return_v = this_param.WithAdditionalFlags(flags);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 110042, 110095);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.MemberSemanticModel.IncrementalBinder
                    f_10923_110004_110096(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                    semanticModel, Microsoft.CodeAnalysis.CSharp.Binder
                    next)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.MemberSemanticModel.IncrementalBinder(semanticModel, next);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 110004, 110096);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 109724, 110163);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 109724, 110163);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundStatement BindStatement(StatementSyntax node, DiagnosticBag diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 110179, 111525);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 110395, 110984) || true) && (f_10923_110399_110414(node) == f_10923_110418_110443(_semanticModel))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 110395, 110984);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 110485, 110582);

                        BoundStatement
                        synthesizedStatement = f_10923_110523_110581(_semanticModel, node)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 110606, 110739) || true) && (synthesizedStatement != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 110606, 110739);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 110688, 110716);

                            return synthesizedStatement;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 110606, 110739);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 110763, 110814);

                        BoundNode
                        boundNode = f_10923_110785_110813(this, node)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 110838, 110965) || true) && (boundNode != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 110838, 110965);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 110909, 110942);

                            return (BoundStatement)boundNode;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 110838, 110965);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 110395, 110984);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 111004, 111069);

                    BoundStatement
                    statement = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.BindStatement(node, diagnostics), 10923, 111031, 111068)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 111262, 111473) || true) && (f_10923_111266_111296(statement) && (DynAbs.Tracing.TraceSender.Expression_True(10923, 111266, 111344) && f_10923_111300_111315(node) == f_10923_111319_111344(_semanticModel)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 111262, 111473);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 111386, 111454);

                        f_10923_111386_111453(_semanticModel, node, statement);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 111262, 111473);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 111493, 111510);

                    return statement;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 110179, 111525);

                    Microsoft.CodeAnalysis.SyntaxTree
                    f_10923_110399_110414(Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                    this_param)
                    {
                        var return_v = this_param.SyntaxTree;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 110399, 110414);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTree
                    f_10923_110418_110443(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                    this_param)
                    {
                        var return_v = this_param.SyntaxTree;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 110418, 110443);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundStatement
                    f_10923_110523_110581(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                    node)
                    {
                        var return_v = this_param.GuardedGetSynthesizedStatementFromMap(node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 110523, 110581);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundNode
                    f_10923_110785_110813(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel.IncrementalBinder
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                    node)
                    {
                        var return_v = this_param.TryGetBoundNodeFromMap((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 110785, 110813);
                        return return_v;
                    }


                    bool
                    f_10923_111266_111296(Microsoft.CodeAnalysis.CSharp.BoundStatement
                    this_param)
                    {
                        var return_v = this_param.WasCompilerGenerated;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 111266, 111296);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTree
                    f_10923_111300_111315(Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                    this_param)
                    {
                        var return_v = this_param.SyntaxTree;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 111300, 111315);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTree
                    f_10923_111319_111344(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                    this_param)
                    {
                        var return_v = this_param.SyntaxTree;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 111319, 111344);
                        return return_v;
                    }


                    int
                    f_10923_111386_111453(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                    node, Microsoft.CodeAnalysis.CSharp.BoundStatement
                    statement)
                    {
                        this_param.GuardedAddSynthesizedStatementToMap(node, statement);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 111386, 111453);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 110179, 111525);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 110179, 111525);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override BoundBlock BindEmbeddedBlock(BlockSyntax node, DiagnosticBag diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 111541, 112016);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 111665, 111725);

                    BoundBlock
                    block = (BoundBlock)f_10923_111696_111724(this, node)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 111745, 111838) || true) && (block is object)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 111745, 111838);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 111806, 111819);

                        return block;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 111745, 111838);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 111858, 111908);

                    block = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.BindEmbeddedBlock(node, diagnostics), 10923, 111866, 111907);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 111928, 111970);

                    f_10923_111928_111969(f_10923_111941_111968_M(!block.WasCompilerGenerated));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 111988, 112001);

                    return block;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 111541, 112016);

                    Microsoft.CodeAnalysis.CSharp.BoundNode
                    f_10923_111696_111724(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel.IncrementalBinder
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                    node)
                    {
                        var return_v = this_param.TryGetBoundNodeFromMap((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 111696, 111724);
                        return return_v;
                    }


                    bool
                    f_10923_111941_111968_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 111941, 111968);
                        return return_v;
                    }


                    int
                    f_10923_111928_111969(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 111928, 111969);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 111541, 112016);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 111541, 112016);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private BoundNode TryGetBoundNodeFromMap(CSharpSyntaxNode node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 112032, 112628);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 112128, 112581) || true) && (f_10923_112132_112147(node) == f_10923_112151_112176(_semanticModel))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 112128, 112581);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 112218, 112306);

                        ImmutableArray<BoundNode>
                        boundNodes = f_10923_112257_112305(_semanticModel, node)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 112330, 112562) || true) && (f_10923_112334_112362_M(!boundNodes.IsDefaultOrEmpty))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 112330, 112562);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 112518, 112539);

                            return boundNodes[0];
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 112330, 112562);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 112128, 112581);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 112601, 112613);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 112032, 112628);

                    Microsoft.CodeAnalysis.SyntaxTree
                    f_10923_112132_112147(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    this_param)
                    {
                        var return_v = this_param.SyntaxTree;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 112132, 112147);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTree
                    f_10923_112151_112176(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                    this_param)
                    {
                        var return_v = this_param.SyntaxTree;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 112151, 112176);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>
                    f_10923_112257_112305(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                    this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    node)
                    {
                        var return_v = this_param.GuardedGetBoundNodesFromMap(node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 112257, 112305);
                        return return_v;
                    }


                    bool
                    f_10923_112334_112362_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 112334, 112362);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 112032, 112628);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 112032, 112628);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode BindMethodBody(CSharpSyntaxNode node, DiagnosticBag diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 112644, 113062);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 112767, 112818);

                    BoundNode
                    boundNode = f_10923_112789_112817(this, node)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 112838, 112939) || true) && (boundNode is object)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 112838, 112939);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 112903, 112920);

                        return boundNode;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 112838, 112939);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 112959, 113010);

                    boundNode = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.BindMethodBody(node, diagnostics), 10923, 112971, 113009);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 113030, 113047);

                    return boundNode;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 112644, 113062);

                    Microsoft.CodeAnalysis.CSharp.BoundNode
                    f_10923_112789_112817(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel.IncrementalBinder
                    this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    node)
                    {
                        var return_v = this_param.TryGetBoundNodeFromMap(node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 112789, 112817);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 112644, 113062);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 112644, 113062);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override BoundExpressionStatement BindConstructorInitializer(ConstructorInitializerSyntax node, DiagnosticBag diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 113078, 113373);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 113242, 113358);

                    return (BoundExpressionStatement)f_10923_113275_113303(this, node) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement>(10923, 113249, 113357) ?? DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.BindConstructorInitializer(node, diagnostics), 10923, 113307, 113357));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 113078, 113373);

                    Microsoft.CodeAnalysis.CSharp.BoundNode
                    f_10923_113275_113303(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel.IncrementalBinder
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax
                    node)
                    {
                        var return_v = this_param.TryGetBoundNodeFromMap((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 113275, 113303);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 113078, 113373);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 113078, 113373);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override BoundExpressionStatement BindConstructorInitializer(PrimaryConstructorBaseTypeSyntax node, DiagnosticBag diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 113389, 113688);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 113557, 113673);

                    return (BoundExpressionStatement)f_10923_113590_113618(this, node) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement>(10923, 113564, 113672) ?? DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.BindConstructorInitializer(node, diagnostics), 10923, 113622, 113672));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 113389, 113688);

                    Microsoft.CodeAnalysis.CSharp.BoundNode
                    f_10923_113590_113618(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel.IncrementalBinder
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.PrimaryConstructorBaseTypeSyntax
                    node)
                    {
                        var return_v = this_param.TryGetBoundNodeFromMap((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 113590, 113618);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 113389, 113688);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 113389, 113688);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override BoundBlock BindExpressionBodyAsBlock(ArrowExpressionClauseSyntax node, DiagnosticBag diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10923, 113704, 114151);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 113852, 113912);

                    BoundBlock
                    block = (BoundBlock)f_10923_113883_113911(this, node)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 113932, 114025) || true) && (block is object)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10923, 113932, 114025);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 113993, 114006);

                        return block;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10923, 113932, 114025);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 114045, 114103);

                    block = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.BindExpressionBodyAsBlock(node, diagnostics), 10923, 114053, 114102);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10923, 114123, 114136);

                    return block;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10923, 113704, 114151);

                    Microsoft.CodeAnalysis.CSharp.BoundNode
                    f_10923_113883_113911(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel.IncrementalBinder
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax
                    node)
                    {
                        var return_v = this_param.TryGetBoundNodeFromMap((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 113883, 113911);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10923, 113704, 114151);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 113704, 114151);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static IncrementalBinder()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10923, 109207, 114162);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10923, 109207, 114162);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 109207, 114162);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10923, 109207, 114162);

            static Microsoft.CodeAnalysis.CSharp.Binder
            f_10923_109440_109444_C(Microsoft.CodeAnalysis.CSharp.Binder
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10923, 109341, 109524);
                return return_v;
            }

        }

        static MemberSemanticModel()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10923, 763, 114171);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10923, 763, 114171);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10923, 763, 114171);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10923, 763, 114171);

        Microsoft.CodeAnalysis.DiagnosticBag
        f_10923_1004_1023()
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticBag();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 1004, 1023);
            return return_v;
        }


        System.Threading.ReaderWriterLockSlim
        f_10923_1087_1144(System.Threading.LockRecursionPolicy
        recursionPolicy)
        {
            var return_v = new System.Threading.ReaderWriterLockSlim(recursionPolicy);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 1087, 1144);
            return return_v;
        }


        System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxNode, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>>
        f_10923_1340_1395()
        {
            var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxNode, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 1340, 1395);
            return return_v;
        }


        System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.IOperation>
        f_10923_1486_1526()
        {
            var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.IOperation>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 1486, 1526);
            return return_v;
        }


        int
        f_10923_3082_3108(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 3082, 3108);
            return 0;
        }


        int
        f_10923_3123_3165(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 3123, 3165);
            return 0;
        }


        int
        f_10923_3180_3261(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 3180, 3261);
            return 0;
        }


        bool
        f_10923_3327_3381_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 3327, 3381);
            return return_v;
        }


        int
        f_10923_3276_3382(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 3276, 3382);
            return 0;
        }


        bool
        f_10923_3444_3494_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 3444, 3494);
            return return_v;
        }


        string
        f_10923_3496_3550()
        {
            var return_v = CSharpResources.ChainingSpeculativeModelIsNotSupported;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10923, 3496, 3550);
            return return_v;
        }


        int
        f_10923_3397_3551(bool
        condition, string
        message)
        {
            Debug.Assert(condition, message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 3397, 3551);
            return 0;
        }


        int
        f_10923_3566_3640(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 3566, 3640);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.BinderFlags
        f_10923_3778_3807(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
        this_param)
        {
            var return_v = this_param.GetSemanticModelBinderFlags();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 3778, 3807);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Binder
        f_10923_3747_3808(Microsoft.CodeAnalysis.CSharp.Binder
        this_param, Microsoft.CodeAnalysis.CSharp.BinderFlags
        flags)
        {
            var return_v = this_param.WithAdditionalFlags(flags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 3747, 3808);
            return return_v;
        }


        System.Lazy<Microsoft.CodeAnalysis.Operations.CSharpOperationFactory>
        f_10923_4162_4234(System.Func<Microsoft.CodeAnalysis.Operations.CSharpOperationFactory>
        valueFactory)
        {
            var return_v = new System.Lazy<Microsoft.CodeAnalysis.Operations.CSharpOperationFactory>(valueFactory);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10923, 4162, 4234);
            return return_v;
        }

    }
}
