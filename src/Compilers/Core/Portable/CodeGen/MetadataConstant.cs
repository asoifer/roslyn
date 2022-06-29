// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;
using System.Reflection;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CodeGen
{
    internal sealed class MetadataConstant : Cci.IMetadataExpression
    {
        public Cci.ITypeReference Type { get; }

        public object? Value { get; }

        public MetadataConstant(Cci.ITypeReference type, object? value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(72, 523, 752);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(72, 433, 472);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(72, 482, 511);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(72, 611, 644);

                f_72_611_643(type != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(72, 658, 685);

                f_72_658_684(value);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(72, 701, 713);

                Type = type;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(72, 727, 741);

                Value = value;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(72, 523, 752);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(72, 523, 752);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(72, 523, 752);
            }
        }

        void Cci.IMetadataExpression.Dispatch(Cci.MetadataVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(72, 764, 886);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(72, 855, 875);

                f_72_855_874(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(72, 764, 886);

                int
                f_72_855_874(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.CodeAnalysis.CodeGen.MetadataConstant
                constant)
                {
                    this_param.Visit(constant);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(72, 855, 874);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(72, 764, 886);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(72, 764, 886);
            }
        }

        [Conditional("DEBUG")]
        internal static void AssertValidConstant(object? value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(72, 898, 1241);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(72, 1010, 1230);

                f_72_1010_1229(value == null || (DynAbs.Tracing.TraceSender.Expression_False(72, 1023, 1055) || value is string) || (DynAbs.Tracing.TraceSender.Expression_False(72, 1023, 1076) || value is DateTime) || (DynAbs.Tracing.TraceSender.Expression_False(72, 1023, 1096) || value is decimal) || (DynAbs.Tracing.TraceSender.Expression_False(72, 1023, 1136) || f_72_1100_1136(f_72_1100_1129(f_72_1100_1115(value)))) || (DynAbs.Tracing.TraceSender.Expression_False(72, 1023, 1228) || (f_72_1141_1182(f_72_1141_1170(f_72_1141_1156(value))) && (DynAbs.Tracing.TraceSender.Expression_True(72, 1141, 1204) && !(value is IntPtr)) && (DynAbs.Tracing.TraceSender.Expression_True(72, 1141, 1227) && !(value is UIntPtr)))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(72, 898, 1241);

                System.Type
                f_72_1100_1115(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(72, 1100, 1115);
                    return return_v;
                }


                System.Reflection.TypeInfo
                f_72_1100_1129(System.Type
                type)
                {
                    var return_v = type.GetTypeInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(72, 1100, 1129);
                    return return_v;
                }


                bool
                f_72_1100_1136(System.Reflection.TypeInfo
                this_param)
                {
                    var return_v = this_param.IsEnum;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(72, 1100, 1136);
                    return return_v;
                }


                System.Type
                f_72_1141_1156(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(72, 1141, 1156);
                    return return_v;
                }


                System.Reflection.TypeInfo
                f_72_1141_1170(System.Type
                type)
                {
                    var return_v = type.GetTypeInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(72, 1141, 1170);
                    return return_v;
                }


                bool
                f_72_1141_1182(System.Reflection.TypeInfo
                this_param)
                {
                    var return_v = this_param.IsPrimitive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(72, 1141, 1182);
                    return return_v;
                }


                int
                f_72_1010_1229(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(72, 1010, 1229);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(72, 898, 1241);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(72, 898, 1241);
            }
        }

        static MetadataConstant()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(72, 352, 1248);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(72, 352, 1248);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(72, 352, 1248);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(72, 352, 1248);

        static int
        f_72_611_643(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(72, 611, 643);
            return 0;
        }


        static int
        f_72_658_684(object?
        value)
        {
            AssertValidConstant(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(72, 658, 684);
            return 0;
        }

    }
}
