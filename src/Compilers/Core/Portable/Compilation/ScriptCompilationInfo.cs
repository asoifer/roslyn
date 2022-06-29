// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

namespace Microsoft.CodeAnalysis
{
    public abstract class ScriptCompilationInfo
    {
        internal Type? ReturnTypeOpt { get; }

        public Type ReturnType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(161, 396, 430);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(161, 399, 430);
                    return f_161_399_412() ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Type?>(161, 399, 430) ?? typeof(object)); DynAbs.Tracing.TraceSender.TraceExitMethod(161, 396, 430);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(161, 396, 430);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(161, 396, 430);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Type? GlobalsType { get; }

        internal ScriptCompilationInfo(Type? returnType, Type? globalsType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(161, 486, 656);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(161, 326, 363);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(161, 441, 474);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(161, 578, 605);

                ReturnTypeOpt = returnType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(161, 619, 645);

                GlobalsType = globalsType;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(161, 486, 656);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(161, 486, 656);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(161, 486, 656);
            }
        }

        public Compilation? PreviousScriptCompilation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(161, 714, 748);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(161, 717, 748);
                    return f_161_717_748(); DynAbs.Tracing.TraceSender.TraceExitMethod(161, 714, 748);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(161, 714, 748);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(161, 714, 748);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal abstract Compilation? CommonPreviousScriptCompilation { get; }

        public ScriptCompilationInfo WithPreviousScriptCompilation(Compilation? compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(161, 927, 978);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(161, 930, 978);
                return f_161_930_978(this, compilation); DynAbs.Tracing.TraceSender.TraceExitMethod(161, 927, 978);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(161, 927, 978);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(161, 927, 978);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.ScriptCompilationInfo
            f_161_930_978(Microsoft.CodeAnalysis.ScriptCompilationInfo
            this_param, Microsoft.CodeAnalysis.Compilation?
            compilation)
            {
                var return_v = this_param.CommonWithPreviousScriptCompilation(compilation);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(161, 930, 978);
                return return_v;
            }

        }

        internal abstract ScriptCompilationInfo CommonWithPreviousScriptCompilation(Compilation? compilation);

        static ScriptCompilationInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(161, 266, 1098);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(161, 266, 1098);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(161, 266, 1098);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(161, 266, 1098);

        System.Type?
        f_161_399_412()
        {
            var return_v = ReturnTypeOpt;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(161, 399, 412);
            return return_v;
        }


        Microsoft.CodeAnalysis.Compilation?
        f_161_717_748()
        {
            var return_v = CommonPreviousScriptCompilation;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(161, 717, 748);
            return return_v;
        }

    }
}
