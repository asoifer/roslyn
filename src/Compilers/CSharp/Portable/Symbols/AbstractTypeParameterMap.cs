// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    [DebuggerDisplay("{GetDebuggerDisplay(), nq}")]
    internal abstract class AbstractTypeParameterMap : AbstractTypeMap
    {
        protected readonly SmallDictionary<TypeParameterSymbol, TypeWithAnnotations> Mapping;

        protected AbstractTypeParameterMap(SmallDictionary<TypeParameterSymbol, TypeWithAnnotations> mapping)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10086, 708, 868);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10086, 688, 695);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10086, 834, 857);

                this.Mapping = mapping;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10086, 708, 868);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10086, 708, 868);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10086, 708, 868);
            }
        }

        protected sealed override TypeWithAnnotations SubstituteTypeParameter(TypeParameterSymbol typeParameter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10086, 880, 1297);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10086, 1067, 1094);

                TypeWithAnnotations
                result
                = default(TypeWithAnnotations);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10086, 1108, 1221) || true) && (f_10086_1112_1158(Mapping, typeParameter, out result))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10086, 1108, 1221);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10086, 1192, 1206);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10086, 1108, 1221);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10086, 1237, 1286);

                return TypeWithAnnotations.Create(typeParameter);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10086, 880, 1297);

                bool
                f_10086_1112_1158(Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                key, out Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10086, 1112, 1158);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10086, 880, 1297);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10086, 880, 1297);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string GetDebuggerDisplay()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10086, 1309, 1675);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10086, 1369, 1405);

                var
                result = f_10086_1382_1404("[")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10086, 1419, 1454);

                f_10086_1419_1453(result, f_10086_1433_1452(f_10086_1433_1447(this)));
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10086, 1468, 1611);
                    foreach (var kv in f_10086_1487_1494_I(Mapping))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10086, 1468, 1611);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10086, 1528, 1596);

                        f_10086_1528_1595(f_10086_1528_1573(f_10086_1528_1561(f_10086_1528_1546(result, " "), kv.Key), ":"), kv.Value.Type);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10086, 1468, 1611);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10086, 1, 144);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10086, 1, 144);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10086, 1627, 1664);

                return f_10086_1634_1663(f_10086_1634_1652(result, "]"));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10086, 1309, 1675);

                System.Text.StringBuilder
                f_10086_1382_1404(string
                value)
                {
                    var return_v = new System.Text.StringBuilder(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10086, 1382, 1404);
                    return return_v;
                }


                System.Type
                f_10086_1433_1447(Microsoft.CodeAnalysis.CSharp.Symbols.AbstractTypeParameterMap
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10086, 1433, 1447);
                    return return_v;
                }


                string
                f_10086_1433_1452(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10086, 1433, 1452);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10086_1419_1453(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10086, 1419, 1453);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10086_1528_1546(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10086, 1528, 1546);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10086_1528_1561(System.Text.StringBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                value)
                {
                    var return_v = this_param.Append((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10086, 1528, 1561);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10086_1528_1573(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10086, 1528, 1573);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10086_1528_1595(System.Text.StringBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                value)
                {
                    var return_v = this_param.Append((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10086, 1528, 1595);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10086_1487_1494_I(Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10086, 1487, 1494);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10086_1634_1652(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10086, 1634, 1652);
                    return return_v;
                }


                string
                f_10086_1634_1663(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10086, 1634, 1663);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10086, 1309, 1675);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10086, 1309, 1675);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static AbstractTypeParameterMap()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10086, 475, 1682);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10086, 475, 1682);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10086, 475, 1682);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10086, 475, 1682);
    }
}
