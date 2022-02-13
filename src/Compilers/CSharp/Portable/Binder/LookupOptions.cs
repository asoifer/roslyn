// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp
{
    /// <summary>
    /// Options that can be used to modify the symbol lookup mechanism. 
    /// </summary>
    /// <remarks>
    /// Multiple options can be combined together.  LookupOptions.AreValid checks for valid combinations.
    /// </remarks>
    [Flags]
    internal enum LookupOptions
    {
        /// <summary>
        /// Consider all symbols, using normal accessibility rules.
        /// </summary>
        Default = 0,

        /// <summary>
        /// Consider only namespace aliases and extern aliases.
        /// </summary>
        NamespaceAliasesOnly = 1 << 1,

        /// <summary>
        /// Consider only namespaces and types.
        /// </summary>
        NamespacesOrTypesOnly = 1 << 2,

        /// <summary>
        /// Consider non-members, plus invocable members.
        /// </summary>
        MustBeInvocableIfMember = 1 << 3,

        /// <summary>
        /// Consider only symbols that are instance members. Valid with IncludeExtensionMethods
        /// since extension methods are invoked on an instance.
        /// </summary>
        MustBeInstance = 1 << 4,

        /// <summary>
        /// Do not consider symbols that are instance members.
        /// </summary>
        MustNotBeInstance = 1 << 5,

        /// <summary>
        /// Do not consider symbols that are namespaces.
        /// </summary>
        MustNotBeNamespace = 1 << 6,

        /// <summary>
        /// Consider methods of any arity when arity zero is specified. Because type parameters can be inferred, it is
        /// often desired to consider generic methods when no type arguments were present.
        /// </summary>
        AllMethodsOnArityZero = 1 << 7,

        /// <summary>
        /// Look only for label symbols.  This must be exclusive of all other options.
        /// </summary>
        LabelsOnly = 1 << 8,

        /// <summary>
        /// Usually, when determining if a member is accessible, both the type of the receiver
        /// and the type containing the access are used.  If this flag is specified, then only
        /// the containing type will be used (i.e. as if you've written base.XX).
        /// </summary>
        UseBaseReferenceAccessibility = 1 << 9,

        /// <summary>
        /// Include extension methods.
        /// </summary>
        IncludeExtensionMethods = 1 << 10,

        /// <summary>
        /// Consider only attribute types.
        /// </summary>
        AttributeTypeOnly = (1 << 11) | NamespacesOrTypesOnly,

        /// <summary>
        /// Consider lookup name to be a verbatim identifier.
        /// If this flag is specified, then only one lookup is performed for attribute name: lookup with the given name,
        /// and attribute name lookup with "Attribute" suffix is skipped.
        /// </summary>
        VerbatimNameAttributeTypeOnly = (1 << 12) | AttributeTypeOnly,

        /// <summary>
        /// Consider named types of any arity when arity zero is specified. It is specifically desired for nameof in such situations: nameof(System.Collections.Generic.List)
        /// </summary>
        AllNamedTypesOnArityZero = 1 << 13,

        /// <summary>
        /// Do not consider symbols that are method type parameters.
        /// </summary>
        MustNotBeMethodTypeParameter = 1 << 14,
    }
    internal static class LookupOptionExtensions
    {
        internal static bool AreValid(this LookupOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10353, 4668, 6040);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10353, 4750, 4847) || true) && (options == LookupOptions.Default)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10353, 4750, 4847);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10353, 4820, 4832);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10353, 4750, 4847);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10353, 4863, 5000) || true) && ((options & LookupOptions.LabelsOnly) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10353, 4863, 5000);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10353, 4942, 4985);

                    return options == LookupOptions.LabelsOnly;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10353, 4863, 5000);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10353, 5079, 5183);

                LookupOptions
                mustBeAndNotBeInstance = (LookupOptions.MustBeInstance | LookupOptions.MustNotBeInstance)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10353, 5197, 5323) || true) && ((options & mustBeAndNotBeInstance) == mustBeAndNotBeInstance)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10353, 5197, 5323);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10353, 5295, 5308);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10353, 5197, 5323);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10353, 5485, 5759) || true) && ((options & (LookupOptions.MustNotBeNamespace | LookupOptions.MustNotBeMethodTypeParameter)) != 0 && (DynAbs.Tracing.TraceSender.Expression_True(10353, 5489, 5697) && (options & (LookupOptions.NamespaceAliasesOnly | LookupOptions.NamespacesOrTypesOnly)) != 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10353, 5485, 5759);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10353, 5731, 5744);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10353, 5485, 5759);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10353, 5775, 5979);

                LookupOptions
                onlyOptions = options &
                                (LookupOptions.NamespaceAliasesOnly
                                 | LookupOptions.NamespacesOrTypesOnly
                                 | LookupOptions.AllMethodsOnArityZero)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10353, 5995, 6029);

                return f_10353_6002_6028(onlyOptions);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10353, 4668, 6040);

                bool
                f_10353_6002_6028(Microsoft.CodeAnalysis.CSharp.LookupOptions
                o)
                {
                    var return_v = OnlyOneBitSet(o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10353, 6002, 6028);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10353, 4668, 6040);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10353, 4668, 6040);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void ThrowIfInvalid(this LookupOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10353, 6052, 6297);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10353, 6140, 6286) || true) && (!f_10353_6145_6163(options))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10353, 6140, 6286);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10353, 6197, 6271);

                    throw f_10353_6203_6270(f_10353_6225_6269());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10353, 6140, 6286);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10353, 6052, 6297);

                bool
                f_10353_6145_6163(Microsoft.CodeAnalysis.CSharp.LookupOptions
                options)
                {
                    var return_v = options.AreValid();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10353, 6145, 6163);
                    return return_v;
                }


                string
                f_10353_6225_6269()
                {
                    var return_v = CSharpResources.LookupOptionsHasInvalidCombo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10353, 6225, 6269);
                    return return_v;
                }


                System.ArgumentException
                f_10353_6203_6270(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10353, 6203, 6270);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10353, 6052, 6297);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10353, 6052, 6297);
            }
        }

        private static bool OnlyOneBitSet(LookupOptions o)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10353, 6309, 6421);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10353, 6384, 6410);

                return (o & (o - 1)) == 0;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10353, 6309, 6421);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10353, 6309, 6421);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10353, 6309, 6421);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool CanConsiderMembers(this LookupOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10353, 6433, 6662);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10353, 6525, 6651);

                return (options & (LookupOptions.NamespaceAliasesOnly | LookupOptions.NamespacesOrTypesOnly | LookupOptions.LabelsOnly)) == 0;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10353, 6433, 6662);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10353, 6433, 6662);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10353, 6433, 6662);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool CanConsiderLocals(this LookupOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10353, 6674, 6902);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10353, 6765, 6891);

                return (options & (LookupOptions.NamespaceAliasesOnly | LookupOptions.NamespacesOrTypesOnly | LookupOptions.LabelsOnly)) == 0;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10353, 6674, 6902);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10353, 6674, 6902);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10353, 6674, 6902);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool CanConsiderTypes(this LookupOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10353, 6914, 7174);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10353, 7004, 7163);

                return (options & (LookupOptions.NamespaceAliasesOnly | LookupOptions.MustBeInvocableIfMember | LookupOptions.MustBeInstance | LookupOptions.LabelsOnly)) == 0;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10353, 6914, 7174);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10353, 6914, 7174);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10353, 6914, 7174);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool CanConsiderNamespaces(this LookupOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10353, 7186, 7449);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10353, 7281, 7438);

                return (options & (LookupOptions.MustNotBeNamespace | LookupOptions.MustBeInvocableIfMember | LookupOptions.MustBeInstance | LookupOptions.LabelsOnly)) == 0;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10353, 7186, 7449);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10353, 7186, 7449);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10353, 7186, 7449);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsAttributeTypeLookup(this LookupOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10353, 7461, 7653);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10353, 7556, 7642);

                return (options & LookupOptions.AttributeTypeOnly) == LookupOptions.AttributeTypeOnly;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10353, 7461, 7653);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10353, 7461, 7653);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10353, 7461, 7653);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsVerbatimNameAttributeTypeLookup(this LookupOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10353, 7665, 7893);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10353, 7772, 7882);

                return (options & LookupOptions.VerbatimNameAttributeTypeOnly) == LookupOptions.VerbatimNameAttributeTypeOnly;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10353, 7665, 7893);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10353, 7665, 7893);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10353, 7665, 7893);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static LookupOptionExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10353, 3814, 7900);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10353, 3814, 7900);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10353, 3814, 7900);
        }

    }
}
