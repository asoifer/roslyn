// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Symbols;

namespace Microsoft.CodeAnalysis.CSharp
{

    internal struct UnaryOperatorSignature
    {

        public static UnaryOperatorSignature Error;

        public readonly MethodSymbol Method;

        public readonly TypeSymbol OperandType;

        public readonly TypeSymbol ReturnType;

        public readonly UnaryOperatorKind Kind;

        public UnaryOperatorSignature(UnaryOperatorKind kind, TypeSymbol operandType, TypeSymbol returnType, MethodSymbol method = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10864, 710, 1014);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10864, 863, 880);

                this.Kind = kind;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10864, 894, 925);

                this.OperandType = operandType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10864, 939, 968);

                this.ReturnType = returnType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10864, 982, 1003);

                this.Method = method;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10864, 710, 1014);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10864, 710, 1014);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10864, 710, 1014);
            }
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10864, 1026, 1212);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10864, 1084, 1201);

                return $"kind: {this.Kind} operandType: {this.OperandType} operandRefKind: {this.RefKind} return: {this.ReturnType}";
                DynAbs.Tracing.TraceSender.TraceExitMethod(10864, 1026, 1212);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10864, 1026, 1212);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10864, 1026, 1212);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public RefKind RefKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10864, 1271, 1753);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10864, 1307, 1698) || true) && ((object)Method != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10864, 1307, 1698);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10864, 1375, 1416);

                        f_10864_1375_1415(f_10864_1388_1409(Method) == 1);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10864, 1440, 1679) || true) && (f_10864_1444_1486_M(!Method.ParameterRefKinds.IsDefaultOrEmpty))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10864, 1440, 1679);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10864, 1536, 1587);

                            f_10864_1536_1586(Method.ParameterRefKinds.Length == 1);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10864, 1615, 1656);

                            return Method.ParameterRefKinds.Single();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10864, 1440, 1679);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10864, 1307, 1698);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10864, 1718, 1738);

                    return RefKind.None;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10864, 1271, 1753);

                    int
                    f_10864_1388_1409(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ParameterCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10864, 1388, 1409);
                        return return_v;
                    }


                    int
                    f_10864_1375_1415(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10864, 1375, 1415);
                        return 0;
                    }


                    bool
                    f_10864_1444_1486_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10864, 1444, 1486);
                        return return_v;
                    }


                    int
                    f_10864_1536_1586(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10864, 1536, 1586);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10864, 1224, 1764);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10864, 1224, 1764);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }
        static UnaryOperatorSignature()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10864, 372, 1771);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10864, 464, 503);
            Error = default(UnaryOperatorSignature); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10864, 372, 1771);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10864, 372, 1771);
        }
    }
}
