// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class SynthesizedSubmissionConstructor : SynthesizedInstanceConstructor
    {
        private readonly ImmutableArray<ParameterSymbol> _parameters;

        internal SynthesizedSubmissionConstructor(NamedTypeSymbol containingType, DiagnosticBag diagnostics)
        : base(f_10692_649_663_C(containingType))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10692, 528, 1438);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10692, 689, 750);

                f_10692_689_749(f_10692_702_725(containingType) == TypeKind.Submission);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10692, 764, 798);

                f_10692_764_797(diagnostics != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10692, 814, 868);

                var
                compilation = f_10692_832_867(containingType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10692, 884, 999);

                var
                submissionArrayType = f_10692_910_998(compilation, f_10692_944_997(compilation, SpecialType.System_Object))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10692, 1013, 1075);

                var
                useSiteError = f_10692_1032_1074(submissionArrayType)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10692, 1089, 1214) || true) && (useSiteError != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10692, 1089, 1214);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10692, 1147, 1199);

                    f_10692_1147_1198(diagnostics, useSiteError, NoLocation.Singleton);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10692, 1089, 1214);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10692, 1230, 1427);

                _parameters = f_10692_1244_1426(f_10692_1301_1425(this, TypeWithAnnotations.Create(submissionArrayType), 0, RefKind.None, "submissionArray"));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10692, 528, 1438);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10692, 528, 1438);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10692, 528, 1438);
            }
        }

        public override ImmutableArray<ParameterSymbol> Parameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10692, 1533, 1560);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10692, 1539, 1558);

                    return _parameters;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10692, 1533, 1560);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10692, 1450, 1571);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10692, 1450, 1571);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static SynthesizedSubmissionConstructor()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10692, 351, 1578);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10692, 351, 1578);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10692, 351, 1578);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10692, 351, 1578);

        Microsoft.CodeAnalysis.TypeKind
        f_10692_702_725(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.TypeKind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10692, 702, 725);
            return return_v;
        }


        int
        f_10692_689_749(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10692, 689, 749);
            return 0;
        }


        int
        f_10692_764_797(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10692, 764, 797);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_10692_832_867(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.DeclaringCompilation;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10692, 832, 867);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10692_944_997(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param, Microsoft.CodeAnalysis.SpecialType
        specialType)
        {
            var return_v = this_param.GetSpecialType(specialType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10692, 944, 997);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
        f_10692_910_998(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        elementType)
        {
            var return_v = this_param.CreateArrayTypeSymbol((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)elementType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10692, 910, 998);
            return return_v;
        }


        Microsoft.CodeAnalysis.DiagnosticInfo?
        f_10692_1032_1074(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
        this_param)
        {
            var return_v = this_param.GetUseSiteDiagnostic();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10692, 1032, 1074);
            return return_v;
        }


        int
        f_10692_1147_1198(Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics, Microsoft.CodeAnalysis.DiagnosticInfo
        info, Microsoft.CodeAnalysis.Location
        location)
        {
            diagnostics.Add(info, location);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10692, 1147, 1198);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        f_10692_1301_1425(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedSubmissionConstructor
        container, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
        type, int
        ordinal, Microsoft.CodeAnalysis.RefKind
        refKind, string
        name)
        {
            var return_v = SynthesizedParameterSymbol.Create((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)container, type, ordinal, refKind, name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10692, 1301, 1425);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
        f_10692_1244_1426(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        item)
        {
            var return_v = ImmutableArray.Create<ParameterSymbol>(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10692, 1244, 1426);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10692_649_663_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10692, 528, 1438);
            return return_v;
        }

    }
}
