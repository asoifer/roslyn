// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class SynthesizedAttributeData : SourceAttributeData
    {
        internal SynthesizedAttributeData(MethodSymbol wellKnownMember, ImmutableArray<TypedConstant> arguments, ImmutableArray<KeyValuePair<string, TypedConstant>> namedArguments)
        : base(
                    applicationNode: f_10280_748_769_C(null), attributeClass: f_10280_800_830(wellKnownMember), attributeConstructor: wellKnownMember, constructorArguments: arguments, constructorArgumentsSourceIndices: default, namedArguments: namedArguments, hasErrors: false, isConditionallyOmitted: false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10280, 541, 1319);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10280, 1131, 1177);

                f_10280_1131_1176((object)wellKnownMember != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10280, 1191, 1226);

                f_10280_1191_1225(f_10280_1204_1224_M(!arguments.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10280, 1240, 1280);

                f_10280_1240_1279(f_10280_1253_1278_M(!namedArguments.IsDefault));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10280, 541, 1319);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10280, 541, 1319);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10280, 541, 1319);
            }
        }

        internal SynthesizedAttributeData(SourceAttributeData original)
        : base(
                    applicationNode: f_10280_1429_1481_C(f_10280_1446_1481(original)), attributeClass: f_10280_1512_1535(original), attributeConstructor: f_10280_1572_1601(original), constructorArguments: f_10280_1638_1673(original), constructorArgumentsSourceIndices: f_10280_1723_1765(original), namedArguments: f_10280_1796_1825(original), hasErrors: f_10280_1851_1869(original), isConditionallyOmitted: f_10280_1908_1939(original))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10280, 1331, 1962);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10280, 1331, 1962);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10280, 1331, 1962);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10280, 1331, 1962);
            }
        }

        static SynthesizedAttributeData()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10280, 456, 1969);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10280, 456, 1969);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10280, 456, 1969);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10280, 456, 1969);

        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10280_800_830(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.ContainingType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10280, 800, 830);
            return return_v;
        }


        int
        f_10280_1131_1176(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10280, 1131, 1176);
            return 0;
        }


        bool
        f_10280_1204_1224_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10280, 1204, 1224);
            return return_v;
        }


        int
        f_10280_1191_1225(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10280, 1191, 1225);
            return 0;
        }


        bool
        f_10280_1253_1278_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10280, 1253, 1278);
            return return_v;
        }


        int
        f_10280_1240_1279(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10280, 1240, 1279);
            return 0;
        }


        static Microsoft.CodeAnalysis.SyntaxReference?
        f_10280_748_769_C(Microsoft.CodeAnalysis.SyntaxReference?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10280, 541, 1319);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxReference?
        f_10280_1446_1481(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData
        this_param)
        {
            var return_v = this_param.ApplicationSyntaxReference;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10280, 1446, 1481);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10280_1512_1535(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData
        this_param)
        {
            var return_v = this_param.AttributeClass;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10280, 1512, 1535);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
        f_10280_1572_1601(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData
        this_param)
        {
            var return_v = this_param.AttributeConstructor;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10280, 1572, 1601);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
        f_10280_1638_1673(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData
        this_param)
        {
            var return_v = this_param.CommonConstructorArguments;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10280, 1638, 1673);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<int>
        f_10280_1723_1765(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData
        this_param)
        {
            var return_v = this_param.ConstructorArgumentsSourceIndices;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10280, 1723, 1765);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
        f_10280_1796_1825(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData
        this_param)
        {
            var return_v = this_param.CommonNamedArguments;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10280, 1796, 1825);
            return return_v;
        }


        static bool
        f_10280_1851_1869(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData
        this_param)
        {
            var return_v = this_param.HasErrors;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10280, 1851, 1869);
            return return_v;
        }


        static bool
        f_10280_1908_1939(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData
        this_param)
        {
            var return_v = this_param.IsConditionallyOmitted;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10280, 1908, 1939);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxReference?
        f_10280_1429_1481_C(Microsoft.CodeAnalysis.SyntaxReference?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10280, 1331, 1962);
            return return_v;
        }

    }
}
