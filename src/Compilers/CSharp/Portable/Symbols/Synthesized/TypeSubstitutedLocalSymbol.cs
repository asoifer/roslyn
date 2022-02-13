// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class TypeSubstitutedLocalSymbol : LocalSymbol
    {
        private readonly LocalSymbol _originalVariable;

        private readonly TypeWithAnnotations _type;

        private readonly Symbol _containingSymbol;

        public TypeSubstitutedLocalSymbol(LocalSymbol originalVariable, TypeWithAnnotations type, Symbol containingSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10694, 619, 1033);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10694, 484, 501);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10694, 589, 606);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10694, 758, 797);

                f_10694_758_796(originalVariable != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10694, 811, 838);

                f_10694_811_837(type.HasType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10694, 852, 891);

                f_10694_852_890(containingSymbol != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10694, 907, 944);

                _originalVariable = originalVariable;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10694, 958, 971);

                _type = type;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10694, 985, 1022);

                _containingSymbol = containingSymbol;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10694, 619, 1033);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10694, 619, 1033);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10694, 619, 1033);
            }
        }

        internal override bool IsImportedFromMetadata
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10694, 1115, 1171);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10694, 1121, 1169);

                    return f_10694_1128_1168(_originalVariable);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10694, 1115, 1171);

                    bool
                    f_10694_1128_1168(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    this_param)
                    {
                        var return_v = this_param.IsImportedFromMetadata;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10694, 1128, 1168);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10694, 1045, 1182);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10694, 1045, 1182);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10694, 1273, 1322);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10694, 1279, 1320);

                    return f_10694_1286_1319(_originalVariable);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10694, 1273, 1322);

                    Microsoft.CodeAnalysis.CSharp.Symbols.LocalDeclarationKind
                    f_10694_1286_1319(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    this_param)
                    {
                        var return_v = this_param.DeclarationKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10694, 1286, 1319);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10694, 1194, 1333);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10694, 1194, 1333);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10694, 1424, 1473);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10694, 1430, 1471);

                    return f_10694_1437_1470(_originalVariable);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10694, 1424, 1473);

                    Microsoft.CodeAnalysis.SynthesizedLocalKind
                    f_10694_1437_1470(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    this_param)
                    {
                        var return_v = this_param.SynthesizedKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10694, 1437, 1470);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10694, 1345, 1484);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10694, 1345, 1484);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10694, 1568, 1620);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10694, 1574, 1618);

                    return f_10694_1581_1617(_originalVariable);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10694, 1568, 1620);

                    Microsoft.CodeAnalysis.SyntaxNode
                    f_10694_1581_1617(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    this_param)
                    {
                        var return_v = this_param.ScopeDesignatorOpt;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10694, 1581, 1617);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10694, 1496, 1631);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10694, 1496, 1631);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10694, 1695, 1733);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10694, 1701, 1731);

                    return f_10694_1708_1730(_originalVariable);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10694, 1695, 1733);

                    string
                    f_10694_1708_1730(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10694, 1708, 1730);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10694, 1643, 1744);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10694, 1643, 1744);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10694, 1820, 1853);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10694, 1826, 1851);

                    return _containingSymbol;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10694, 1820, 1853);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10694, 1756, 1864);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10694, 1756, 1864);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10694, 1974, 2033);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10694, 1980, 2031);

                    return f_10694_1987_2030(_originalVariable);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10694, 1974, 2033);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                    f_10694_1987_2030(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    this_param)
                    {
                        var return_v = this_param.DeclaringSyntaxReferences;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10694, 1987, 2030);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10694, 1876, 2044);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10694, 1876, 2044);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override SyntaxNode GetDeclaratorSyntax()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10694, 2056, 2189);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10694, 2131, 2178);

                return f_10694_2138_2177(_originalVariable);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10694, 2056, 2189);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10694_2138_2177(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.GetDeclaratorSyntax();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10694, 2138, 2177);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10694, 2056, 2189);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10694, 2056, 2189);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<Location> Locations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10694, 2276, 2319);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10694, 2282, 2317);

                    return f_10694_2289_2316(_originalVariable);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10694, 2276, 2319);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                    f_10694_2289_2316(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    this_param)
                    {
                        var return_v = this_param.Locations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10694, 2289, 2316);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10694, 2201, 2330);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10694, 2201, 2330);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10694, 2422, 2443);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10694, 2428, 2441);

                    return _type;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10694, 2422, 2443);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10694, 2342, 2454);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10694, 2342, 2454);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10694, 2536, 2585);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10694, 2542, 2583);

                    return f_10694_2549_2582(_originalVariable);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10694, 2536, 2585);

                    Microsoft.CodeAnalysis.SyntaxToken
                    f_10694_2549_2582(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    this_param)
                    {
                        var return_v = this_param.IdentifierToken;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10694, 2549, 2582);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10694, 2466, 2596);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10694, 2466, 2596);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10694, 2675, 2728);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10694, 2681, 2726);

                    return f_10694_2688_2725(_originalVariable);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10694, 2675, 2728);

                    bool
                    f_10694_2688_2725(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    this_param)
                    {
                        var return_v = this_param.IsCompilerGenerated;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10694, 2688, 2725);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10694, 2608, 2739);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10694, 2608, 2739);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10694, 2807, 2849);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10694, 2813, 2847);

                    return f_10694_2820_2846(_originalVariable);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10694, 2807, 2849);

                    bool
                    f_10694_2820_2846(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    this_param)
                    {
                        var return_v = this_param.IsPinned;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10694, 2820, 2846);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10694, 2751, 2860);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10694, 2751, 2860);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10694, 2928, 2969);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10694, 2934, 2967);

                    return f_10694_2941_2966(_originalVariable);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10694, 2928, 2969);

                    Microsoft.CodeAnalysis.RefKind
                    f_10694_2941_2966(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    this_param)
                    {
                        var return_v = this_param.RefKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10694, 2941, 2966);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10694, 2872, 2980);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10694, 2872, 2980);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10694, 3222, 3261);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10694, 3225, 3261);
                    throw f_10694_3231_3261(); DynAbs.Tracing.TraceSender.TraceExitMethod(10694, 3222, 3261);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10694, 3222, 3261);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10694, 3222, 3261);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10694, 3504, 3543);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10694, 3507, 3543);
                    throw f_10694_3513_3543(); DynAbs.Tracing.TraceSender.TraceExitMethod(10694, 3504, 3543);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10694, 3504, 3543);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10694, 3504, 3543);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ConstantValue GetConstantValue(SyntaxNode node, LocalSymbol inProgress, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10694, 3556, 3781);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10694, 3697, 3770);

                return f_10694_3704_3769(_originalVariable, node, inProgress, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10694, 3556, 3781);

                Microsoft.CodeAnalysis.ConstantValue
                f_10694_3704_3769(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                inProgress, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GetConstantValue(node, inProgress, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10694, 3704, 3769);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10694, 3556, 3781);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10694, 3556, 3781);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<Diagnostic> GetConstantValueDiagnostics(BoundExpression boundInitValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10694, 3793, 4002);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10694, 3922, 3991);

                return f_10694_3929_3990(_originalVariable, boundInitValue);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10694, 3793, 4002);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_10694_3929_3990(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                boundInitValue)
                {
                    var return_v = this_param.GetConstantValueDiagnostics(boundInitValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10694, 3929, 3990);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10694, 3793, 4002);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10694, 3793, 4002);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override LocalSymbol WithSynthesizedLocalKindAndSyntax(SynthesizedLocalKind kind, SyntaxNode syntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10694, 4014, 4442);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10694, 4148, 4206);

                var
                origSynthesized = (SynthesizedLocal)_originalVariable
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10694, 4220, 4431);

                return f_10694_4227_4430(f_10694_4280_4343(origSynthesized, kind, syntax), _type, _containingSymbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10694, 4014, 4442);

                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10694_4280_4343(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
                this_param, Microsoft.CodeAnalysis.SynthesizedLocalKind
                kind, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    var return_v = this_param.WithSynthesizedLocalKindAndSyntax(kind, syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10694, 4280, 4343);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSubstitutedLocalSymbol
                f_10694_4227_4430(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                originalVariable, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type, Microsoft.CodeAnalysis.CSharp.Symbol
                containingSymbol)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeSubstitutedLocalSymbol(originalVariable, type, containingSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10694, 4227, 4430);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10694, 4014, 4442);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10694, 4014, 4442);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static TypeSubstitutedLocalSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10694, 376, 4449);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10694, 376, 4449);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10694, 376, 4449);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10694, 376, 4449);

        int
        f_10694_758_796(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10694, 758, 796);
            return 0;
        }


        int
        f_10694_811_837(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10694, 811, 837);
            return 0;
        }


        int
        f_10694_852_890(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10694, 852, 890);
            return 0;
        }


        System.Exception
        f_10694_3231_3261()
        {
            var return_v = ExceptionUtilities.Unreachable;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10694, 3231, 3261);
            return return_v;
        }


        System.Exception
        f_10694_3513_3543()
        {
            var return_v = ExceptionUtilities.Unreachable;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10694, 3513, 3543);
            return return_v;
        }

    }
}
