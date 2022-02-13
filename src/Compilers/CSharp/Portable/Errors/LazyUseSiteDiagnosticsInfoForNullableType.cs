// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CSharp.Symbols;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class LazyUseSiteDiagnosticsInfoForNullableType : LazyDiagnosticInfo
    {
        private readonly LanguageVersion _languageVersion;

        private readonly TypeWithAnnotations _possiblyNullableTypeSymbol;

        internal LazyUseSiteDiagnosticsInfoForNullableType(LanguageVersion languageVersion, TypeWithAnnotations possiblyNullableTypeSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10616, 542, 815);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10616, 438, 454);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10616, 698, 733);

                _languageVersion = languageVersion;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10616, 747, 804);

                _possiblyNullableTypeSymbol = possiblyNullableTypeSymbol;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10616, 542, 815);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10616, 542, 815);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10616, 542, 815);
            }
        }

        protected override DiagnosticInfo? ResolveInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10616, 827, 1224);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10616, 900, 1079) || true) && (_possiblyNullableTypeSymbol.IsNullableType())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10616, 900, 1079);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10616, 982, 1064);

                    return f_10616_989_1063(f_10616_989_1040(_possiblyNullableTypeSymbol.Type));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10616, 900, 1079);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10616, 1093, 1213);

                return f_10616_1100_1212(_languageVersion, _possiblyNullableTypeSymbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10616, 827, 1224);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10616_989_1040(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10616, 989, 1040);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10616_989_1063(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.GetUseSiteDiagnostic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10616, 989, 1063);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo?
                f_10616_1100_1212(Microsoft.CodeAnalysis.CSharp.LanguageVersion
                languageVersion, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type)
                {
                    var return_v = Binder.GetNullableUnconstrainedTypeParameterDiagnosticIfNecessary(languageVersion, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10616, 1100, 1212);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10616, 827, 1224);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10616, 827, 1224);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static LazyUseSiteDiagnosticsInfoForNullableType()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10616, 304, 1231);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10616, 304, 1231);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10616, 304, 1231);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10616, 304, 1231);
    }
}
