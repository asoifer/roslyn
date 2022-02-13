// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    [DebuggerDisplay("{GetDebuggerDisplay(),nq}")]
    internal sealed class SynthesizedLocal : LocalSymbol
    {
        private readonly MethodSymbol _containingMethodOpt;

        private readonly TypeWithAnnotations _type;

        private readonly SynthesizedLocalKind _kind;

        private readonly SyntaxNode _syntaxOpt;

        private readonly bool _isPinned;

        private readonly RefKind _refKind;

        private readonly int _createdAtLineNumber;

        private readonly string _createdAtFilePath;

        internal SynthesizedLocal(
                    MethodSymbol containingMethodOpt,
                    TypeWithAnnotations type,
                    SynthesizedLocalKind kind,
                    SyntaxNode syntaxOpt = null,
                    bool isPinned = false,
                    RefKind refKind = RefKind.None
                    ,
                    [CallerLineNumber] int createdAtLineNumber = 0,
                    [CallerFilePath] string createdAtFilePath = null
                    )
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10686, 1081, 2065);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10686, 680, 700);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10686, 802, 807);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10686, 846, 856);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10686, 889, 898);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10686, 934, 942);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10686, 987, 1007);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10686, 1042, 1060);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10686, 5653, 5722);
                this._sequence = f_10686_5665_5722(ref _nextSequence); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10686, 1552, 1585);

                f_10686_1552_1584(!type.IsVoidType());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10686, 1599, 1654);

                f_10686_1599_1653(!f_10686_1613_1631(kind) || (DynAbs.Tracing.TraceSender.Expression_False(10686, 1612, 1652) || syntaxOpt != null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10686, 1668, 1705);

                f_10686_1668_1704(refKind != RefKind.Out);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10686, 1721, 1764);

                _containingMethodOpt = containingMethodOpt;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10686, 1778, 1791);

                _type = type;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10686, 1805, 1818);

                _kind = kind;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10686, 1832, 1855);

                _syntaxOpt = syntaxOpt;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10686, 1869, 1890);

                _isPinned = isPinned;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10686, 1904, 1923);

                _refKind = refKind;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10686, 1950, 1993);

                _createdAtLineNumber = createdAtLineNumber;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10686, 2007, 2046);

                _createdAtFilePath = createdAtFilePath;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10686, 1081, 2065);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10686, 1081, 2065);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10686, 1081, 2065);
            }
        }

        public SyntaxNode SyntaxOpt
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10686, 2129, 2155);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10686, 2135, 2153);

                    return _syntaxOpt;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10686, 2129, 2155);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10686, 2077, 2166);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10686, 2077, 2166);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override LocalSymbol WithSynthesizedLocalKindAndSyntax(SynthesizedLocalKind kind, SyntaxNode syntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10686, 2178, 2518);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10686, 2312, 2507);

                return f_10686_2319_2506(_containingMethodOpt, _type, kind, syntax, _isPinned, _refKind);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10686, 2178, 2518);

                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
                f_10686_2319_2506(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                containingMethodOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type, Microsoft.CodeAnalysis.SynthesizedLocalKind
                kind, Microsoft.CodeAnalysis.SyntaxNode
                syntaxOpt, bool
                isPinned, Microsoft.CodeAnalysis.RefKind
                refKind)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal(containingMethodOpt, type, kind, syntaxOpt, isPinned, refKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10686, 2319, 2506);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10686, 2178, 2518);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10686, 2178, 2518);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override RefKind RefKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10686, 2586, 2610);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10686, 2592, 2608);

                    return _refKind;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10686, 2586, 2610);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10686, 2530, 2621);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10686, 2530, 2621);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10686, 2703, 2724);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10686, 2709, 2722);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10686, 2703, 2724);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10686, 2633, 2735);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10686, 2633, 2735);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10686, 2826, 2867);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10686, 2832, 2865);

                    return LocalDeclarationKind.None;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10686, 2826, 2867);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10686, 2747, 2878);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10686, 2747, 2878);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10686, 2969, 2990);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10686, 2975, 2988);

                    return _kind;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10686, 2969, 2990);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10686, 2890, 3001);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10686, 2890, 3001);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override SyntaxNode ScopeDesignatorOpt
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10686, 3085, 3105);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10686, 3091, 3103);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10686, 3085, 3105);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10686, 3013, 3116);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10686, 3013, 3116);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10686, 3198, 3234);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10686, 3204, 3232);

                    return default(SyntaxToken);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10686, 3198, 3234);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10686, 3128, 3245);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10686, 3128, 3245);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10686, 3321, 3357);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10686, 3327, 3355);

                    return _containingMethodOpt;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10686, 3321, 3357);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10686, 3257, 3368);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10686, 3257, 3368);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10686, 3432, 3452);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10686, 3438, 3450);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10686, 3432, 3452);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10686, 3380, 3463);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10686, 3380, 3463);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10686, 3555, 3576);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10686, 3561, 3574);

                    return _type;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10686, 3555, 3576);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10686, 3475, 3587);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10686, 3475, 3587);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10686, 3674, 3793);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10686, 3680, 3791);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10686, 3687, 3707) || (((_syntaxOpt == null) && DynAbs.Tracing.TraceSender.Conditional_F2(10686, 3710, 3740)) || DynAbs.Tracing.TraceSender.Conditional_F3(10686, 3743, 3790))) ? ImmutableArray<Location>.Empty : f_10686_3743_3790(f_10686_3765_3789(_syntaxOpt));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10686, 3674, 3793);

                    Microsoft.CodeAnalysis.Location
                    f_10686_3765_3789(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.GetLocation();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10686, 3765, 3789);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                    f_10686_3743_3790(Microsoft.CodeAnalysis.Location
                    item)
                    {
                        var return_v = ImmutableArray.Create(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10686, 3743, 3790);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10686, 3599, 3804);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10686, 3599, 3804);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10686, 3914, 4041);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10686, 3920, 4039);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10686, 3927, 3947) || (((_syntaxOpt == null) && DynAbs.Tracing.TraceSender.Conditional_F2(10686, 3950, 3987)) || DynAbs.Tracing.TraceSender.Conditional_F3(10686, 3990, 4038))) ? ImmutableArray<SyntaxReference>.Empty : f_10686_3990_4038(f_10686_4012_4037(_syntaxOpt));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10686, 3914, 4041);

                    Microsoft.CodeAnalysis.SyntaxReference
                    f_10686_4012_4037(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.GetReference();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10686, 4012, 4037);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                    f_10686_3990_4038(Microsoft.CodeAnalysis.SyntaxReference
                    item)
                    {
                        var return_v = ImmutableArray.Create(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10686, 3990, 4038);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10686, 3816, 4052);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10686, 3816, 4052);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override SyntaxNode GetDeclaratorSyntax()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10686, 4064, 4215);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10686, 4139, 4172);

                f_10686_4139_4171(_syntaxOpt != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10686, 4186, 4204);

                return _syntaxOpt;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10686, 4064, 4215);

                int
                f_10686_4139_4171(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10686, 4139, 4171);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10686, 4064, 4215);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10686, 4064, 4215);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool IsImplicitlyDeclared
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10686, 4293, 4313);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10686, 4299, 4311);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10686, 4293, 4313);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10686, 4227, 4324);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10686, 4227, 4324);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10686, 4392, 4417);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10686, 4398, 4415);

                    return _isPinned;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10686, 4392, 4417);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10686, 4336, 4428);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10686, 4336, 4428);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10686, 4507, 4527);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10686, 4513, 4525);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10686, 4507, 4527);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10686, 4440, 4538);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10686, 4440, 4538);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override uint ValEscapeScope
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10686, 4780, 4819);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10686, 4783, 4819);
                    throw f_10686_4789_4819(); DynAbs.Tracing.TraceSender.TraceExitMethod(10686, 4780, 4819);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10686, 4780, 4819);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10686, 4780, 4819);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10686, 5062, 5101);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10686, 5065, 5101);
                    throw f_10686_5071_5101(); DynAbs.Tracing.TraceSender.TraceExitMethod(10686, 5062, 5101);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10686, 5062, 5101);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10686, 5062, 5101);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ConstantValue GetConstantValue(SyntaxNode node, LocalSymbol inProgress, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10686, 5114, 5278);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10686, 5255, 5267);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10686, 5114, 5278);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10686, 5114, 5278);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10686, 5114, 5278);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<Diagnostic> GetConstantValueDiagnostics(BoundExpression boundInitValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10686, 5290, 5470);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10686, 5419, 5459);

                return ImmutableArray<Diagnostic>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10686, 5290, 5470);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10686, 5290, 5470);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10686, 5290, 5470);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static int _nextSequence;

        private readonly int _sequence;

        internal string DumperString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10686, 5735, 6114);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10686, 5790, 5824);

                var
                builder = f_10686_5804_5823()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10686, 5838, 5908);

                f_10686_5838_5907(builder, _type.ToDisplayString(SymbolDisplayFormat.TestFormat));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10686, 5922, 5942);

                f_10686_5922_5941(builder, ' ');
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10686, 5956, 5989);

                f_10686_5956_5988(builder, f_10686_5971_5987(_kind));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10686, 6003, 6023);

                f_10686_6003_6022(builder, '.');
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10686, 6037, 6063);

                f_10686_6037_6062(builder, _sequence);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10686, 6077, 6103);

                return f_10686_6084_6102(builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10686, 5735, 6114);

                System.Text.StringBuilder
                f_10686_5804_5823()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10686, 5804, 5823);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10686_5838_5907(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10686, 5838, 5907);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10686_5922_5941(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10686, 5922, 5941);
                    return return_v;
                }


                string
                f_10686_5971_5987(Microsoft.CodeAnalysis.SynthesizedLocalKind
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10686, 5971, 5987);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10686_5956_5988(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10686, 5956, 5988);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10686_6003_6022(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10686, 6003, 6022);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10686_6037_6062(System.Text.StringBuilder
                this_param, int
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10686, 6037, 6062);
                    return return_v;
                }


                string
                f_10686_6084_6102(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10686, 6084, 6102);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10686, 5735, 6114);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10686, 5735, 6114);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override string GetDebuggerDisplay()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10686, 6134, 6841);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10686, 6204, 6238);

                var
                builder = f_10686_6218_6237()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10686, 6252, 6272);

                f_10686_6252_6271(builder, '<');
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10686, 6286, 6319);

                f_10686_6286_6318(builder, f_10686_6301_6317(_kind));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10686, 6333, 6353);

                f_10686_6333_6352(builder, '>');
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10686, 6378, 6398);

                f_10686_6378_6397(builder, '.');
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10686, 6412, 6438);

                f_10686_6412_6437(builder, _sequence);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10686, 6460, 6480);

                f_10686_6460_6479(builder, ' ');
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10686, 6494, 6564);

                f_10686_6494_6563(builder, _type.ToDisplayString(SymbolDisplayFormat.TestFormat));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10686, 6591, 6612);

                f_10686_6591_6611(
                            builder, " @");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10686, 6626, 6661);

                f_10686_6626_6660(builder, _createdAtFilePath);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10686, 6675, 6695);

                f_10686_6675_6694(builder, '(');
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10686, 6709, 6746);

                f_10686_6709_6745(builder, _createdAtLineNumber);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10686, 6760, 6780);

                f_10686_6760_6779(builder, ')');
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10686, 6804, 6830);

                return f_10686_6811_6829(builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10686, 6134, 6841);

                System.Text.StringBuilder
                f_10686_6218_6237()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10686, 6218, 6237);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10686_6252_6271(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10686, 6252, 6271);
                    return return_v;
                }


                string
                f_10686_6301_6317(Microsoft.CodeAnalysis.SynthesizedLocalKind
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10686, 6301, 6317);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10686_6286_6318(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10686, 6286, 6318);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10686_6333_6352(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10686, 6333, 6352);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10686_6378_6397(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10686, 6378, 6397);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10686_6412_6437(System.Text.StringBuilder
                this_param, int
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10686, 6412, 6437);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10686_6460_6479(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10686, 6460, 6479);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10686_6494_6563(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10686, 6494, 6563);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10686_6591_6611(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10686, 6591, 6611);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10686_6626_6660(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10686, 6626, 6660);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10686_6675_6694(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10686, 6675, 6694);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10686_6709_6745(System.Text.StringBuilder
                this_param, int
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10686, 6709, 6745);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10686_6760_6779(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10686, 6760, 6779);
                    return return_v;
                }


                string
                f_10686_6811_6829(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10686, 6811, 6829);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10686, 6134, 6841);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10686, 6134, 6841);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SynthesizedLocal()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10686, 529, 6848);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10686, 5512, 5529);
            _nextSequence = 0; DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10686, 529, 6848);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10686, 529, 6848);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10686, 529, 6848);

        int
        f_10686_1552_1584(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10686, 1552, 1584);
            return 0;
        }


        bool
        f_10686_1613_1631(Microsoft.CodeAnalysis.SynthesizedLocalKind
        kind)
        {
            var return_v = kind.IsLongLived();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10686, 1613, 1631);
            return return_v;
        }


        int
        f_10686_1599_1653(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10686, 1599, 1653);
            return 0;
        }


        int
        f_10686_1668_1704(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10686, 1668, 1704);
            return 0;
        }


        System.Exception
        f_10686_4789_4819()
        {
            var return_v = ExceptionUtilities.Unreachable;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10686, 4789, 4819);
            return return_v;
        }


        System.Exception
        f_10686_5071_5101()
        {
            var return_v = ExceptionUtilities.Unreachable;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10686, 5071, 5101);
            return return_v;
        }


        int
        f_10686_5665_5722(ref int
        location)
        {
            var return_v = System.Threading.Interlocked.Increment(ref location);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10686, 5665, 5722);
            return return_v;
        }

    }
}
