// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics;
using Microsoft.CodeAnalysis.Symbols;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class SynthesizedLambdaCacheFieldSymbol : SynthesizedFieldSymbolBase, ISynthesizedMethodBodyImplementationSymbol
    {
        private readonly TypeWithAnnotations _type;

        private readonly MethodSymbol _topLevelMethod;

        public SynthesizedLambdaCacheFieldSymbol(NamedTypeSymbol containingType, TypeSymbol type, string name, MethodSymbol topLevelMethod, bool isReadOnly, bool isStatic)
        : base(f_10685_818_832_C(containingType), name, isPublic: true, isReadOnly: isReadOnly, isStatic: isStatic)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10685, 634, 1131);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10685, 606, 621);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10685, 924, 959);

                f_10685_924_958((object)type != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10685, 973, 1018);

                f_10685_973_1017((object)topLevelMethod != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10685, 1032, 1073);

                _type = TypeWithAnnotations.Create(type);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10685, 1087, 1120);

                _topLevelMethod = topLevelMethod;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10685, 634, 1131);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10685, 634, 1131);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10685, 634, 1131);
            }
        }

        internal override bool SuppressDynamicAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10685, 1191, 1198);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10685, 1194, 1198);
                    return true; DynAbs.Tracing.TraceSender.TraceExitMethod(10685, 1191, 1198);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10685, 1191, 1198);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10685, 1191, 1198);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        IMethodSymbolInternal ISynthesizedMethodBodyImplementationSymbol.Method
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10685, 1283, 1301);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10685, 1286, 1301);
                    return _topLevelMethod; DynAbs.Tracing.TraceSender.TraceExitMethod(10685, 1283, 1301);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10685, 1283, 1301);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10685, 1283, 1301);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool ISynthesizedMethodBodyImplementationSymbol.HasMethodBodyDependency
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10685, 1547, 1555);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10685, 1550, 1555);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10685, 1547, 1555);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10685, 1547, 1555);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10685, 1547, 1555);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override TypeWithAnnotations GetFieldType(ConsList<FieldSymbol> fieldsBeingBound)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10685, 1568, 1707);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10685, 1683, 1696);

                return _type;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10685, 1568, 1707);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10685, 1568, 1707);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10685, 1568, 1707);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SynthesizedLambdaCacheFieldSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10685, 378, 1714);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10685, 378, 1714);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10685, 378, 1714);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10685, 378, 1714);

        int
        f_10685_924_958(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10685, 924, 958);
            return 0;
        }


        int
        f_10685_973_1017(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10685, 973, 1017);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10685_818_832_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10685, 634, 1131);
            return return_v;
        }

    }
}
