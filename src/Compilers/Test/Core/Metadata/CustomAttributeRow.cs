// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Reflection.Metadata;
using Roslyn.Utilities;

namespace Roslyn.Test.Utilities
{

    internal struct CustomAttributeRow : IEquatable<CustomAttributeRow>
    {

        public readonly EntityHandle ParentToken;

        public readonly EntityHandle ConstructorToken;

        public CustomAttributeRow(EntityHandle parentToken, EntityHandle constructorToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25102, 539, 743);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25102, 646, 677);

                this.ParentToken = parentToken;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25102, 691, 732);

                this.ConstructorToken = constructorToken;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25102, 539, 743);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25102, 539, 743);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25102, 539, 743);
            }
        }

        public bool Equals(CustomAttributeRow other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25102, 755, 948);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25102, 824, 937);

                return this.ParentToken == other.ParentToken
                && (DynAbs.Tracing.TraceSender.Expression_True(25102, 831, 936) && this.ConstructorToken == other.ConstructorToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25102, 755, 948);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25102, 755, 948);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25102, 755, 948);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25102, 960, 1079);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25102, 1024, 1068);

                // LAFHIS
                //return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Equals(obj), 25102, 1031, 1067);
                var temp = base.Equals(obj);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25102, 1031, 1067);
                return temp;

                DynAbs.Tracing.TraceSender.TraceExitMethod(25102, 960, 1079);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25102, 960, 1079);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25102, 960, 1079);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25102, 1091, 1239);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25102, 1149, 1228);

                return f_25102_1156_1227(ParentToken.GetHashCode(), ConstructorToken.GetHashCode());
                DynAbs.Tracing.TraceSender.TraceExitMethod(25102, 1091, 1239);

                int
                f_25102_1156_1227(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25102, 1156, 1227);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25102, 1091, 1239);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25102, 1091, 1239);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static CustomAttributeRow()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25102, 346, 1246);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25102, 346, 1246);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25102, 346, 1246);
        }
    }
}
