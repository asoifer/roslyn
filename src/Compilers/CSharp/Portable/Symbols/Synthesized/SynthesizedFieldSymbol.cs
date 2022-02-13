// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class SynthesizedFieldSymbol : SynthesizedFieldSymbolBase
    {
        private readonly TypeWithAnnotations _type;

        public SynthesizedFieldSymbol(
                    NamedTypeSymbol containingType,
                    TypeSymbol type,
                    string name,
                    bool isPublic = false,
                    bool isReadOnly = false,
                    bool isStatic = false)
        : base(f_10677_943_957_C(containingType), name, isPublic, isReadOnly, isStatic)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10677, 681, 1122);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10677, 1021, 1056);

                f_10677_1021_1055((object)type != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10677, 1070, 1111);

                _type = TypeWithAnnotations.Create(type);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10677, 681, 1122);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10677, 681, 1122);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10677, 681, 1122);
            }
        }

        internal override bool SuppressDynamicAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10677, 1206, 1226);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10677, 1212, 1224);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10677, 1206, 1226);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10677, 1134, 1237);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10677, 1134, 1237);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override TypeWithAnnotations GetFieldType(ConsList<FieldSymbol> fieldsBeingBound)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10677, 1249, 1388);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10677, 1364, 1377);

                return _type;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10677, 1249, 1388);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10677, 1249, 1388);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10677, 1249, 1388);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SynthesizedFieldSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10677, 536, 1395);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10677, 536, 1395);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10677, 536, 1395);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10677, 536, 1395);

        int
        f_10677_1021_1055(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10677, 1021, 1055);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10677_943_957_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10677, 681, 1122);
            return return_v;
        }

    }
}
