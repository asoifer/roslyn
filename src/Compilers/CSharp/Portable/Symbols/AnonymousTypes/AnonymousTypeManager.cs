// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.Symbols;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed partial class AnonymousTypeManager : CommonAnonymousTypeManager
    {
        internal AnonymousTypeManager(CSharpCompilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10418, 674, 849);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10418, 942, 987);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 1165, 1192);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 1728, 1753);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10420, 4138, 4203);
                // LAFHIS
                this._sourceLocationsSeen = new System.Collections.Concurrent.ConcurrentDictionary<Location, bool>(); // f_10420_4161_4203(); 
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10420, 4161, 4203);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10418, 759, 793);

                f_10418_759_792(compilation != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10418, 807, 838);

                this.Compilation = compilation;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10418, 674, 849);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10418, 674, 849);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10418, 674, 849);
            }
        }

        public CSharpCompilation Compilation { get; }

        public NamedTypeSymbol ConstructAnonymousTypeSymbol(AnonymousTypeDescriptor typeDescr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10418, 1137, 1313);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10418, 1248, 1302);

                return f_10418_1255_1301(this, typeDescr);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10418, 1137, 1313);

                Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypePublicSymbol
                f_10418_1255_1301(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                manager, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeDescriptor
                typeDescr)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypePublicSymbol(manager, typeDescr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10418, 1255, 1301);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10418, 1137, 1313);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10418, 1137, 1313);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static PropertySymbol GetAnonymousTypeProperty(NamedTypeSymbol type, int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10418, 1455, 1776);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10418, 1568, 1603);

                f_10418_1568_1602((object)type != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10418, 1617, 1652);

                f_10418_1617_1651(f_10418_1630_1650(type));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10418, 1668, 1716);

                var
                anonymous = (AnonymousTypePublicSymbol)type
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10418, 1730, 1765);

                return anonymous.Properties[index];
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10418, 1455, 1776);

                int
                f_10418_1568_1602(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10418, 1568, 1602);
                    return 0;
                }


                bool
                f_10418_1630_1650(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsAnonymousType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10418, 1630, 1650);
                    return return_v;
                }


                int
                f_10418_1617_1651(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10418, 1617, 1651);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10418, 1455, 1776);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10418, 1455, 1776);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ImmutableArray<TypeWithAnnotations> GetAnonymousTypePropertyTypesWithAnnotations(NamedTypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10418, 1890, 2270);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10418, 2033, 2068);

                f_10418_2033_2067(f_10418_2046_2066(type));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10418, 2082, 2130);

                var
                anonymous = (AnonymousTypePublicSymbol)type
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10418, 2144, 2189);

                var
                fields = anonymous.TypeDescriptor.Fields
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10418, 2203, 2259);

                return fields.SelectAsArray(f => f.TypeWithAnnotations);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10418, 1890, 2270);

                bool
                f_10418_2046_2066(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsAnonymousType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10418, 2046, 2066);
                    return return_v;
                }


                int
                f_10418_2033_2067(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10418, 2033, 2067);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10418, 1890, 2270);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10418, 1890, 2270);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static NamedTypeSymbol ConstructAnonymousTypeSymbol(NamedTypeSymbol type, ImmutableArray<TypeWithAnnotations> newFieldTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10418, 2535, 2982);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10418, 2691, 2730);

                f_10418_2691_2729(f_10418_2704_2728_M(!newFieldTypes.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10418, 2744, 2779);

                f_10418_2744_2778(f_10418_2757_2777(type));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10418, 2795, 2843);

                var
                anonymous = (AnonymousTypePublicSymbol)type
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10418, 2857, 2971);

                return f_10418_2864_2970(anonymous.Manager, anonymous.TypeDescriptor.WithNewFieldsTypes(newFieldTypes));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10418, 2535, 2982);

                bool
                f_10418_2704_2728_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10418, 2704, 2728);
                    return return_v;
                }


                int
                f_10418_2691_2729(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10418, 2691, 2729);
                    return 0;
                }


                bool
                f_10418_2757_2777(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsAnonymousType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10418, 2757, 2777);
                    return return_v;
                }


                int
                f_10418_2744_2778(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10418, 2744, 2778);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10418_2864_2970(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeDescriptor
                typeDescr)
                {
                    var return_v = this_param.ConstructAnonymousTypeSymbol(typeDescr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10418, 2864, 2970);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10418, 2535, 2982);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10418, 2535, 2982);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static AnonymousTypeManager()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10418, 578, 2989);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10418, 578, 2989);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10418, 578, 2989);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10418, 578, 2989);

        int
        f_10418_759_792(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10418, 759, 792);
            return 0;
        }

    }
}
