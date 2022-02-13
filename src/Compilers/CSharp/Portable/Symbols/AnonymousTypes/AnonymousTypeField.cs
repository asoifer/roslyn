// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{

    internal struct AnonymousTypeField
    {

        public readonly string Name;

        public readonly Location Location;

        public readonly TypeWithAnnotations TypeWithAnnotations;

        public TypeSymbol Type
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10417, 949, 976);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10417, 952, 976);
                    return TypeWithAnnotations.Type; DynAbs.Tracing.TraceSender.TraceExitMethod(10417, 949, 976);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10417, 949, 976);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10417, 949, 976);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public AnonymousTypeField(string name, Location location, TypeWithAnnotations typeWithAnnotations)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10417, 989, 1240);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10417, 1112, 1129);

                this.Name = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10417, 1143, 1168);

                this.Location = location;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10417, 1182, 1229);

                this.TypeWithAnnotations = typeWithAnnotations;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10417, 989, 1240);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10417, 989, 1240);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10417, 989, 1240);
            }
        }

        [Conditional("DEBUG")]
        internal void AssertIsGood()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10417, 1252, 1441);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10417, 1337, 1430);

                f_10417_1337_1429(this.Name != null && (DynAbs.Tracing.TraceSender.Expression_True(10417, 1350, 1392) && this.Location != null) && (DynAbs.Tracing.TraceSender.Expression_True(10417, 1350, 1428) && this.TypeWithAnnotations.HasType));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10417, 1252, 1441);

                int
                f_10417_1337_1429(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10417, 1337, 1429);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10417, 1252, 1441);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10417, 1252, 1441);
            }
        }
        static AnonymousTypeField()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10417, 441, 1448);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10417, 441, 1448);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10417, 441, 1448);
        }
    }
}
