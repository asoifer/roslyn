// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    /// <summary>
    /// Classifies the different ways in which a found symbol might be incorrect.
    /// Higher values are considered "better" than lower values. These values are used
    /// in a few different places:
    ///    1) Inside a LookupResult to indicate the quality of a symbol from lookup.
    ///    2) Inside a bound node (for example, BoundBadExpression), to indicate
    ///       the "binding quality" of the symbols referenced by that bound node.
    ///    3) Inside an error type symbol, to indicate the reason that the candidate symbols
    ///       in the error type symbols were not good.
    ///       
    /// While most of the values can occur in all places, some of the problems are not
    /// detected at lookup time (e.g., NotAVariable), so only occur in bound nodes.
    /// </summary>
    /// <remarks>
    /// This enumeration is parallel to and almost the same as the CandidateReason enumeration.
    /// Changes to one should usually result in changes to the other.
    /// 
    /// There are two enumerations because:
    ///   1) CandidateReason in language-independent, while this enum is language specific.
    ///   2) The name "CandidateReason" didn't make much sense in the way LookupResultKind is used internally.
    ///   3) Viable isn't used in CandidateReason, but we need it in LookupResultKind, and there isn't a 
    ///      a way to have internal enumeration values.
    /// </remarks>
    internal enum LookupResultKind : byte
    {
        // Note: order is important! High values take precedences over lower values. 

        Empty,
        NotATypeOrNamespace,
        NotAnAttributeType,
        WrongArity,
        NotCreatable,      // E.g., new of an interface or static class
        Inaccessible,
        NotReferencable,   // E.g., get_Goo binding to an accessor.
        NotAValue,
        NotAVariable,      // used for several slightly different places, e.g. LHS of =, out/ref parameters, etc.
        NotInvocable,
        NotLabel,          // used when a label is required
        StaticInstanceMismatch,
        OverloadResolutionFailure,

        // Note: within LookupResult, LookupResultKind.Ambiguous is currently not used (in C#). Instead
        // ambiguous results are determined later by examining multiple viable results to determine if
        // they are ambiguous or overloaded. Thus, LookupResultKind.Ambiguous does not occur in a LookupResult,
        // but can occur within a BoundBadExpression.
        Ambiguous,

        // Indicates a set of symbols, and they are totally fine.
        MemberGroup,

        // Indicates a single symbol is totally fine.
        Viable,
    }
    internal static class LookupResultKindExtensions
    {
        public static CandidateReason ToCandidateReason(this LookupResultKind resultKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10355, 3406, 5172);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10355, 3512, 5161);

                switch (resultKind)
                {

                    case LookupResultKind.Empty:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10355, 3512, 5161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10355, 3593, 3621);

                        return CandidateReason.None;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10355, 3512, 5161);

                    case LookupResultKind.NotATypeOrNamespace:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10355, 3512, 5161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10355, 3682, 3725);

                        return CandidateReason.NotATypeOrNamespace;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10355, 3512, 5161);

                    case LookupResultKind.NotAnAttributeType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10355, 3512, 5161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10355, 3785, 3827);

                        return CandidateReason.NotAnAttributeType;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10355, 3512, 5161);

                    case LookupResultKind.WrongArity:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10355, 3512, 5161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10355, 3879, 3913);

                        return CandidateReason.WrongArity;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10355, 3512, 5161);

                    case LookupResultKind.Inaccessible:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10355, 3512, 5161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10355, 3967, 4003);

                        return CandidateReason.Inaccessible;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10355, 3512, 5161);

                    case LookupResultKind.NotCreatable:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10355, 3512, 5161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10355, 4057, 4093);

                        return CandidateReason.NotCreatable;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10355, 3512, 5161);

                    case LookupResultKind.NotReferencable:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10355, 3512, 5161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10355, 4150, 4189);

                        return CandidateReason.NotReferencable;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10355, 3512, 5161);

                    case LookupResultKind.NotAValue:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10355, 3512, 5161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10355, 4240, 4273);

                        return CandidateReason.NotAValue;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10355, 3512, 5161);

                    case LookupResultKind.NotAVariable:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10355, 3512, 5161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10355, 4327, 4363);

                        return CandidateReason.NotAVariable;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10355, 3512, 5161);

                    case LookupResultKind.NotInvocable:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10355, 3512, 5161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10355, 4417, 4453);

                        return CandidateReason.NotInvocable;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10355, 3512, 5161);

                    case LookupResultKind.StaticInstanceMismatch:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10355, 3512, 5161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10355, 4517, 4563);

                        return CandidateReason.StaticInstanceMismatch;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10355, 3512, 5161);

                    case LookupResultKind.OverloadResolutionFailure:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10355, 3512, 5161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10355, 4630, 4679);

                        return CandidateReason.OverloadResolutionFailure;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10355, 3512, 5161);

                    case LookupResultKind.Ambiguous:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10355, 3512, 5161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10355, 4730, 4763);

                        return CandidateReason.Ambiguous;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10355, 3512, 5161);

                    case LookupResultKind.MemberGroup:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10355, 3512, 5161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10355, 4816, 4851);

                        return CandidateReason.MemberGroup;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10355, 3512, 5161);

                    case LookupResultKind.Viable:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10355, 3512, 5161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10355, 4922, 4993);

                        f_10355_4922_4992(false, "Should not call this on LookupResultKind.Viable");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10355, 5015, 5043);

                        return CandidateReason.None;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10355, 3512, 5161);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10355, 3512, 5161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10355, 5093, 5146);

                        throw f_10355_5099_5145(resultKind);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10355, 3512, 5161);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10355, 3406, 5172);

                int
                f_10355_4922_4992(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10355, 4922, 4992);
                    return 0;
                }


                System.Exception
                f_10355_5099_5145(Microsoft.CodeAnalysis.CSharp.LookupResultKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10355, 5099, 5145);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10355, 3406, 5172);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10355, 3406, 5172);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static LookupResultKind WorseResultKind(this LookupResultKind resultKind1, LookupResultKind resultKind2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10355, 5236, 5691);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10355, 5372, 5451) || true) && (resultKind1 == LookupResultKind.Empty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10355, 5372, 5451);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10355, 5432, 5451);

                    return resultKind2;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10355, 5372, 5451);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10355, 5465, 5544) || true) && (resultKind2 == LookupResultKind.Empty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10355, 5465, 5544);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10355, 5525, 5544);

                    return resultKind1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10355, 5465, 5544);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10355, 5558, 5680) || true) && (resultKind1 < resultKind2)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10355, 5558, 5680);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10355, 5606, 5625);

                    return resultKind1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10355, 5558, 5680);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10355, 5558, 5680);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10355, 5661, 5680);

                    return resultKind2;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10355, 5558, 5680);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10355, 5236, 5691);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10355, 5236, 5691);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10355, 5236, 5691);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static LookupResultKindExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10355, 3186, 5698);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10355, 3186, 5698);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10355, 3186, 5698);
        }

    }
}
