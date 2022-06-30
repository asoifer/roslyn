// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using Microsoft.CodeAnalysis.Emit;

namespace Microsoft.CodeAnalysis
{
    public abstract class CustomModifier : Cci.ICustomModifier
    {
        public abstract bool IsOptional { get; }

        public abstract INamedTypeSymbol Modifier { get; }

        bool Cci.ICustomModifier.IsOptional
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(589, 926, 1000);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(589, 962, 985);

                    return f_589_969_984(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(589, 926, 1000);

                    bool
                    f_589_969_984(Microsoft.CodeAnalysis.CustomModifier
                    this_param)
                    {
                        var return_v = this_param.IsOptional;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(589, 969, 984);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(589, 866, 1011);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(589, 866, 1011);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.ITypeReference Cci.ICustomModifier.GetModifier(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(589, 1023, 1166);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(589, 1119, 1155);

                throw f_589_1125_1154();
                DynAbs.Tracing.TraceSender.TraceExitMethod(589, 1023, 1166);

                System.NotImplementedException
                f_589_1125_1154()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(589, 1125, 1154);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(589, 1023, 1166);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(589, 1023, 1166);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CustomModifier()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(589, 302, 1193);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(589, 302, 1193);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(589, 302, 1193);
        }


        static CustomModifier()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(589, 302, 1193);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(589, 302, 1193);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(589, 302, 1193);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(589, 302, 1193);
    }
}
