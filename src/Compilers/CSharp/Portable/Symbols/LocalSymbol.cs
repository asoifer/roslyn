// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CodeGen;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Symbols;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal abstract class LocalSymbol : Symbol, ILocalSymbolInternal
    {
        protected LocalSymbol()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10115, 676, 721);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10115, 676, 721);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10115, 676, 721);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10115, 676, 721);
            }
        }

        internal abstract LocalDeclarationKind DeclarationKind
        {
            get;
        }

        internal abstract SynthesizedLocalKind SynthesizedKind
        {
            get;
        }

        internal abstract SyntaxNode ScopeDesignatorOpt { get; }

        internal abstract LocalSymbol WithSynthesizedLocalKindAndSyntax(SynthesizedLocalKind kind, SyntaxNode syntax);

        internal abstract bool IsImportedFromMetadata
        {
            get;
        }

        internal virtual bool CanScheduleToStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10115, 1400, 1424);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10115, 1403, 1424);
                    return f_10115_1403_1411_M(!IsConst) && (DynAbs.Tracing.TraceSender.Expression_True(10115, 1403, 1424) && f_10115_1415_1424_M(!IsPinned)); DynAbs.Tracing.TraceSender.TraceExitMethod(10115, 1400, 1424);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10115, 1400, 1424);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10115, 1400, 1424);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal abstract SyntaxToken IdentifierToken
        {
            get;
        }

        public abstract TypeWithAnnotations TypeWithAnnotations
        {
            get;
        }

        public TypeSymbol Type
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10115, 1869, 1896);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10115, 1872, 1896);
                    return f_10115_1872_1891().Type; DynAbs.Tracing.TraceSender.TraceExitMethod(10115, 1869, 1896);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10115, 1869, 1896);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10115, 1869, 1896);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal abstract bool IsPinned
        {
            get;
        }

        public sealed override bool IsExtern
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10115, 2827, 2891);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10115, 2863, 2876);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10115, 2827, 2891);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10115, 2766, 2902);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10115, 2766, 2902);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsSealed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10115, 3089, 3153);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10115, 3125, 3138);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10115, 3089, 3153);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10115, 3028, 3164);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10115, 3028, 3164);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsAbstract
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10115, 3355, 3419);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10115, 3391, 3404);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10115, 3355, 3419);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10115, 3292, 3430);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10115, 3292, 3430);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsOverride
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10115, 3623, 3687);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10115, 3659, 3672);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10115, 3623, 3687);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10115, 3560, 3698);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10115, 3560, 3698);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsVirtual
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10115, 3887, 3951);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10115, 3923, 3936);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10115, 3887, 3951);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10115, 3825, 3962);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10115, 3825, 3962);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsStatic
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10115, 4167, 4231);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10115, 4203, 4216);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10115, 4167, 4231);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10115, 4106, 4242);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10115, 4106, 4242);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override ObsoleteAttributeData ObsoleteAttributeData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10115, 4615, 4635);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10115, 4621, 4633);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10115, 4615, 4635);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10115, 4522, 4646);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10115, 4522, 4646);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override Accessibility DeclaredAccessibility
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10115, 4888, 4974);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10115, 4924, 4959);

                    return Accessibility.NotApplicable;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10115, 4888, 4974);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10115, 4805, 4985);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10115, 4805, 4985);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override SymbolKind Kind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10115, 5174, 5249);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10115, 5210, 5234);

                    return SymbolKind.Local;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10115, 5174, 5249);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10115, 5111, 5260);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10115, 5111, 5260);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override TResult Accept<TArgument, TResult>(CSharpSymbolVisitor<TArgument, TResult> visitor, TArgument argument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10115, 5272, 5478);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10115, 5425, 5467);

                return f_10115_5432_5466<TResult, TArgument>(visitor, this, argument);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10115, 5272, 5478);

                TResult
                f_10115_5432_5466<TResult, TArgument>(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TArgument, TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                symbol, TArgument
                argument)
                {
                    var return_v = this_param.VisitLocal(symbol, argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10115, 5432, 5466);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10115, 5272, 5478);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10115, 5272, 5478);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override void Accept(CSharpSymbolVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10115, 5490, 5614);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10115, 5578, 5603);

                f_10115_5578_5602(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10115, 5490, 5614);

                int
                f_10115_5578_5602(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                symbol)
                {
                    this_param.VisitLocal(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10115, 5578, 5602);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10115, 5490, 5614);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10115, 5490, 5614);
            }
        }

        public sealed override TResult Accept<TResult>(CSharpSymbolVisitor<TResult> visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10115, 5626, 5778);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10115, 5735, 5767);

                return f_10115_5742_5766<TResult>(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10115, 5626, 5778);

                TResult
                f_10115_5742_5766<TResult>(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                symbol)
                {
                    var return_v = this_param.VisitLocal(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10115, 5742, 5766);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10115, 5626, 5778);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10115, 5626, 5778);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool IsCatch
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10115, 5963, 6080);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10115, 5999, 6065);

                    return f_10115_6006_6026(this) == LocalDeclarationKind.CatchVariable;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10115, 5963, 6080);

                    Microsoft.CodeAnalysis.CSharp.Symbols.LocalDeclarationKind
                    f_10115_6006_6026(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    this_param)
                    {
                        var return_v = this_param.DeclarationKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10115, 6006, 6026);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10115, 5919, 6091);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10115, 5919, 6091);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsConst
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10115, 6301, 6413);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10115, 6337, 6398);

                    return f_10115_6344_6364(this) == LocalDeclarationKind.Constant;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10115, 6301, 6413);

                    Microsoft.CodeAnalysis.CSharp.Symbols.LocalDeclarationKind
                    f_10115_6344_6364(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    this_param)
                    {
                        var return_v = this_param.DeclarationKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10115, 6344, 6364);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10115, 6257, 6424);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10115, 6257, 6424);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsUsing
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10115, 6847, 6964);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10115, 6883, 6949);

                    return f_10115_6890_6910(this) == LocalDeclarationKind.UsingVariable;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10115, 6847, 6964);

                    Microsoft.CodeAnalysis.CSharp.Symbols.LocalDeclarationKind
                    f_10115_6890_6910(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    this_param)
                    {
                        var return_v = this_param.DeclarationKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10115, 6890, 6910);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10115, 6803, 6975);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10115, 6803, 6975);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsFixed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10115, 7187, 7304);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10115, 7223, 7289);

                    return f_10115_7230_7250(this) == LocalDeclarationKind.FixedVariable;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10115, 7187, 7304);

                    Microsoft.CodeAnalysis.CSharp.Symbols.LocalDeclarationKind
                    f_10115_7230_7250(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    this_param)
                    {
                        var return_v = this_param.DeclarationKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10115, 7230, 7250);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10115, 7143, 7315);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10115, 7143, 7315);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsForEach
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10115, 7503, 7631);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10115, 7539, 7616);

                    return f_10115_7546_7566(this) == LocalDeclarationKind.ForEachIterationVariable;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10115, 7503, 7631);

                    Microsoft.CodeAnalysis.CSharp.Symbols.LocalDeclarationKind
                    f_10115_7546_7566(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    this_param)
                    {
                        var return_v = this_param.DeclarationKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10115, 7546, 7566);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10115, 7457, 7642);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10115, 7457, 7642);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal abstract SyntaxNode GetDeclaratorSyntax();

        internal virtual bool IsWritableVariable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10115, 8723, 9202);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10115, 8759, 9187);

                    switch (f_10115_8767_8787(this))
                    {

                        case LocalDeclarationKind.Constant:
                        case LocalDeclarationKind.FixedVariable:
                        case LocalDeclarationKind.ForEachIterationVariable:
                        case LocalDeclarationKind.UsingVariable:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10115, 8759, 9187);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10115, 9087, 9100);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10115, 8759, 9187);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10115, 8759, 9187);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10115, 9156, 9168);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10115, 8759, 9187);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10115, 8723, 9202);

                    Microsoft.CodeAnalysis.CSharp.Symbols.LocalDeclarationKind
                    f_10115_8767_8787(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    this_param)
                    {
                        var return_v = this_param.DeclarationKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10115, 8767, 8787);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10115, 8658, 9213);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10115, 8658, 9213);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool HasConstantValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10115, 9466, 9802);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10115, 9502, 9593) || true) && (f_10115_9506_9519_M(!this.IsConst))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10115, 9502, 9593);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10115, 9561, 9574);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10115, 9502, 9593);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10115, 9613, 9683);

                    ConstantValue
                    constantValue = f_10115_9643_9682(this, null, null, null)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10115, 9701, 9754);

                    return constantValue != null && (DynAbs.Tracing.TraceSender.Expression_True(10115, 9708, 9753) && f_10115_9733_9753_M(!constantValue.IsBad));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10115, 9466, 9802);

                    bool
                    f_10115_9506_9519_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10115, 9506, 9519);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConstantValue
                    f_10115_9643_9682(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    this_param, Microsoft.CodeAnalysis.SyntaxNode
                    node, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    inProgress, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        var return_v = this_param.GetConstantValue(node, inProgress, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10115, 9643, 9682);
                        return return_v;
                    }


                    bool
                    f_10115_9733_9753_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10115, 9733, 9753);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10115, 9413, 9813);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10115, 9413, 9813);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public object ConstantValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10115, 10081, 10391);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10115, 10117, 10207) || true) && (f_10115_10121_10134_M(!this.IsConst))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10115, 10117, 10207);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10115, 10176, 10188);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10115, 10117, 10207);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10115, 10227, 10297);

                    ConstantValue
                    constantValue = f_10115_10257_10296(this, null, null, null)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10115, 10315, 10343);

                    return f_10115_10322_10342_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(constantValue, 10115, 10322, 10342)?.Value);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10115, 10081, 10391);

                    bool
                    f_10115_10121_10134_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10115, 10121, 10134);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConstantValue
                    f_10115_10257_10296(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    this_param, Microsoft.CodeAnalysis.SyntaxNode
                    node, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    inProgress, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        var return_v = this_param.GetConstantValue(node, inProgress, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10115, 10257, 10296);
                        return return_v;
                    }


                    object?
                    f_10115_10322_10342_M(object?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10115, 10322, 10342);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10115, 10029, 10402);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10115, 10029, 10402);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal abstract bool IsCompilerGenerated
        {
            get;
        }

        internal abstract ConstantValue GetConstantValue(SyntaxNode node, LocalSymbol inProgress, DiagnosticBag diagnostics = null);

        internal abstract ImmutableArray<Diagnostic> GetConstantValueDiagnostics(BoundExpression boundInitValue);

        public bool IsRef
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10115, 10896, 10922);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10115, 10899, 10922);
                    return f_10115_10899_10906() != RefKind.None; DynAbs.Tracing.TraceSender.TraceExitMethod(10115, 10896, 10922);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10115, 10896, 10922);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10115, 10896, 10922);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public abstract RefKind RefKind
        {
            get;
        }

        internal abstract uint RefEscapeScope { get; }

        internal abstract uint ValEscapeScope { get; }

        internal virtual SyntaxNode ForbiddenZone
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10115, 11934, 11941);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10115, 11937, 11941);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10115, 11934, 11941);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10115, 11934, 11941);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10115, 11934, 11941);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual ErrorCode ForbiddenDiagnostic
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10115, 12166, 12212);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10115, 12169, 12212);
                    return ErrorCode.ERR_VariableUsedBeforeDeclaration; DynAbs.Tracing.TraceSender.TraceExitMethod(10115, 12166, 12212);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10115, 12166, 12212);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10115, 12166, 12212);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected sealed override ISymbol CreateISymbol()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10115, 12225, 12351);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10115, 12299, 12340);

                return f_10115_12306_12339(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10115, 12225, 12351);

                Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.LocalSymbol
                f_10115_12306_12339(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                underlying)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.LocalSymbol(underlying);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10115, 12306, 12339);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10115, 12225, 12351);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10115, 12225, 12351);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        SynthesizedLocalKind ILocalSymbolInternal.SynthesizedKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10115, 12493, 12572);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10115, 12529, 12557);

                    return f_10115_12536_12556(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10115, 12493, 12572);

                    Microsoft.CodeAnalysis.SynthesizedLocalKind
                    f_10115_12536_12556(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    this_param)
                    {
                        var return_v = this_param.SynthesizedKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10115, 12536, 12556);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10115, 12411, 12583);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10115, 12411, 12583);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool ILocalSymbolInternal.IsImportedFromMetadata
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10115, 12668, 12754);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10115, 12704, 12739);

                    return f_10115_12711_12738(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10115, 12668, 12754);

                    bool
                    f_10115_12711_12738(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    this_param)
                    {
                        var return_v = this_param.IsImportedFromMetadata;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10115, 12711, 12738);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10115, 12595, 12765);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10115, 12595, 12765);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        SyntaxNode ILocalSymbolInternal.GetDeclaratorSyntax()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10115, 12777, 12900);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10115, 12855, 12889);

                return f_10115_12862_12888(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10115, 12777, 12900);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10115_12862_12888(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.GetDeclaratorSyntax();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10115, 12862, 12888);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10115, 12777, 12900);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10115, 12777, 12900);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static LocalSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10115, 593, 12929);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10115, 593, 12929);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10115, 593, 12929);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10115, 593, 12929);

        bool
        f_10115_1403_1411_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10115, 1403, 1411);
            return return_v;
        }


        bool
        f_10115_1415_1424_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10115, 1415, 1424);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
        f_10115_1872_1891()
        {
            var return_v = TypeWithAnnotations;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10115, 1872, 1891);
            return return_v;
        }


        Microsoft.CodeAnalysis.RefKind
        f_10115_10899_10906()
        {
            var return_v = RefKind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10115, 10899, 10906);
            return return_v;
        }

    }
}
