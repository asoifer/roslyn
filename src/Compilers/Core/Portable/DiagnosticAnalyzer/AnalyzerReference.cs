// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;

namespace Microsoft.CodeAnalysis.Diagnostics
{
    public abstract class AnalyzerReference
    {
        protected AnalyzerReference()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(239, 759, 810);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(239, 759, 810);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(239, 759, 810);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(239, 759, 810);
            }
        }

        public abstract string? FullPath { get; }

        public virtual string Display
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(239, 1295, 1323);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(239, 1301, 1321);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(239, 1295, 1323);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(239, 1241, 1334);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(239, 1241, 1334);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public abstract object Id { get; }

        public abstract ImmutableArray<DiagnosticAnalyzer> GetAnalyzersForAllLanguages();

        public abstract ImmutableArray<DiagnosticAnalyzer> GetAnalyzers(string language);

        public virtual ImmutableArray<ISourceGenerator> GetGeneratorsForAllLanguages()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(239, 3056, 3097);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(239, 3059, 3097);
                return ImmutableArray<ISourceGenerator>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(239, 3056, 3097);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(239, 3056, 3097);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(239, 3056, 3097);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [Obsolete("Use GetGenerators(string language) or GetGeneratorsForAllLanguages()")]
        public virtual ImmutableArray<ISourceGenerator> GetGenerators()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(239, 3266, 3307);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(239, 3269, 3307);
                return ImmutableArray<ISourceGenerator>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(239, 3266, 3307);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(239, 3266, 3307);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(239, 3266, 3307);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual ImmutableArray<ISourceGenerator> GetGenerators(string language)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(239, 3631, 3672);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(239, 3634, 3672);
                return ImmutableArray<ISourceGenerator>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(239, 3631, 3672);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(239, 3631, 3672);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(239, 3631, 3672);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static AnalyzerReference()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(239, 703, 3680);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(239, 703, 3680);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(239, 703, 3680);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(239, 703, 3680);
    }
}
