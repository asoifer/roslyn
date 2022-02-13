// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CSharp.Symbols;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    partial class BoundDagTemp
    {
        public bool IsOriginalInput
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10549, 543, 565);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10549, 546, 565);
                    return f_10549_546_557(this) is null; DynAbs.Tracing.TraceSender.TraceExitMethod(10549, 543, 565);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10549, 543, 565);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10549, 543, 565);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static BoundDagTemp ForOriginalInput(SyntaxNode syntax, TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10549, 658, 700);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10549, 661, 700);
                return f_10549_661_700(syntax, type, null, 0); DynAbs.Tracing.TraceSender.TraceExitMethod(10549, 658, 700);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10549, 658, 700);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10549, 658, 700);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.BoundDagTemp
            f_10549_661_700(Microsoft.CodeAnalysis.SyntaxNode
            syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
            type, Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation?
            source, int
            index)
            {
                var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDagTemp(syntax, type, source, index);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10549, 661, 700);
                return return_v;
            }

        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10549, 754, 804);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10549, 757, 804);
                return obj is BoundDagTemp other && (DynAbs.Tracing.TraceSender.Expression_True(10549, 757, 804) && f_10549_786_804(this, other)); DynAbs.Tracing.TraceSender.TraceExitMethod(10549, 754, 804);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10549, 754, 804);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10549, 754, 804);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_10549_786_804(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
            this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
            other)
            {
                var return_v = this_param.Equals(other);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10549, 786, 804);
                return return_v;
            }

        }

        public bool Equals(BoundDagTemp other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10549, 817, 1084);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10549, 880, 1073);

                return other is { } && (DynAbs.Tracing.TraceSender.Expression_True(10549, 887, 982) && f_10549_920_982(f_10549_920_929(this), f_10549_937_947(other), TypeCompareKind.AllIgnoreOptions)) && (DynAbs.Tracing.TraceSender.Expression_True(10549, 887, 1043) && f_10549_1003_1043(f_10549_1017_1028(this), f_10549_1030_1042(other))) && (DynAbs.Tracing.TraceSender.Expression_True(10549, 887, 1072) && f_10549_1047_1057(this) == f_10549_1061_1072(other));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10549, 817, 1084);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10549_920_929(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10549, 920, 929);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10549_937_947(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10549, 937, 947);
                    return return_v;
                }


                bool
                f_10549_920_982(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10549, 920, 982);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation?
                f_10549_1017_1028(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                this_param)
                {
                    var return_v = this_param.Source;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10549, 1017, 1028);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation?
                f_10549_1030_1042(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                this_param)
                {
                    var return_v = this_param.Source;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10549, 1030, 1042);
                    return return_v;
                }


                bool
                f_10549_1003_1043(Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation?
                objA, Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation?
                objB)
                {
                    var return_v = object.Equals((object?)objA, (object?)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10549, 1003, 1043);
                    return return_v;
                }


                int
                f_10549_1047_1057(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                this_param)
                {
                    var return_v = this_param.Index;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10549, 1047, 1057);
                    return return_v;
                }


                int
                f_10549_1061_1072(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                this_param)
                {
                    var return_v = this_param.Index;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10549, 1061, 1072);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10549, 817, 1084);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10549, 817, 1084);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10549, 1096, 1269);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10549, 1154, 1258);

                return f_10549_1161_1257(f_10549_1174_1197(f_10549_1174_1183(this)), f_10549_1199_1256(f_10549_1212_1238_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10549_1212_1223(this), 10549, 1212, 1238)?.GetHashCode()) ?? (DynAbs.Tracing.TraceSender.Expression_Null<int?>(10549, 1212, 1243) ?? 0), f_10549_1245_1255(this)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10549, 1096, 1269);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10549_1174_1183(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10549, 1174, 1183);
                    return return_v;
                }


                int
                f_10549_1174_1197(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10549, 1174, 1197);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation?
                f_10549_1212_1223(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                this_param)
                {
                    var return_v = this_param.Source;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10549, 1212, 1223);
                    return return_v;
                }


                int?
                f_10549_1212_1238_I(int?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10549, 1212, 1238);
                    return return_v;
                }


                int
                f_10549_1245_1255(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                this_param)
                {
                    var return_v = this_param.Index;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10549, 1245, 1255);
                    return return_v;
                }


                int
                f_10549_1199_1256(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10549, 1199, 1256);
                    return return_v;
                }


                int
                f_10549_1161_1257(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10549, 1161, 1257);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10549, 1096, 1269);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10549, 1096, 1269);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static BoundDagTemp()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10549, 329, 1276);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10549, 329, 1276);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10549, 329, 1276);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10549, 329, 1276);

        Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation?
        f_10549_546_557(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
        this_param)
        {
            var return_v = this_param.Source;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10549, 546, 557);
            return return_v;
        }

    }
}
