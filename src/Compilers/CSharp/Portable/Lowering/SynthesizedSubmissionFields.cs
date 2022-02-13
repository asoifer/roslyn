// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Emit;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Roslyn.Utilities;
using System;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal class SynthesizedSubmissionFields
    {
        private readonly NamedTypeSymbol _declaringSubmissionClass;

        private readonly CSharpCompilation _compilation;

        private FieldSymbol _hostObjectField;

        private Dictionary<ImplicitNamedTypeSymbol, FieldSymbol> _previousSubmissionFieldMap;

        public SynthesizedSubmissionFields(CSharpCompilation compilation, NamedTypeSymbol submissionClass)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10439, 1167, 1498);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10439, 927, 952);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10439, 998, 1010);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10439, 1043, 1059);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10439, 1127, 1154);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10439, 1290, 1324);

                f_10439_1290_1323(compilation != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10439, 1338, 1386);

                f_10439_1338_1385(f_10439_1351_1384(submissionClass));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10439, 1402, 1446);

                _declaringSubmissionClass = submissionClass;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10439, 1460, 1487);

                _compilation = compilation;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10439, 1167, 1498);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10439, 1167, 1498);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10439, 1167, 1498);
            }
        }

        internal int Count
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10439, 1553, 1687);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10439, 1589, 1672);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10439, 1596, 1631) || ((_previousSubmissionFieldMap == null && DynAbs.Tracing.TraceSender.Conditional_F2(10439, 1634, 1635)) || DynAbs.Tracing.TraceSender.Conditional_F3(10439, 1638, 1671))) ? 0 : f_10439_1638_1671(_previousSubmissionFieldMap);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10439, 1553, 1687);

                    int
                    f_10439_1638_1671(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.ImplicitNamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10439, 1638, 1671);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10439, 1510, 1698);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10439, 1510, 1698);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal IEnumerable<FieldSymbol> FieldSymbols
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10439, 1781, 1967);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10439, 1817, 1952);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10439, 1824, 1859) || ((_previousSubmissionFieldMap == null && DynAbs.Tracing.TraceSender.Conditional_F2(10439, 1862, 1888)) || DynAbs.Tracing.TraceSender.Conditional_F3(10439, 1891, 1951))) ? f_10439_1862_1888() : (IEnumerable<FieldSymbol>)f_10439_1917_1951(_previousSubmissionFieldMap);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10439, 1781, 1967);

                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol[]
                    f_10439_1862_1888()
                    {
                        var return_v = Array.Empty<FieldSymbol>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10439, 1862, 1888);
                        return return_v;
                    }


                    System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.ImplicitNamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>.ValueCollection
                    f_10439_1917_1951(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.ImplicitNamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                    this_param)
                    {
                        var return_v = this_param.Values;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10439, 1917, 1951);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10439, 1710, 1978);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10439, 1710, 1978);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal FieldSymbol GetHostObjectField()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10439, 1990, 2635);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10439, 2056, 2165) || true) && ((object)_hostObjectField != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10439, 2056, 2165);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10439, 2126, 2150);

                    return _hostObjectField;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10439, 2056, 2165);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10439, 2181, 2247);

                var
                hostObjectTypeSymbol = f_10439_2208_2246(_compilation)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10439, 2261, 2596) || true) && ((object)hostObjectTypeSymbol != null && (DynAbs.Tracing.TraceSender.Expression_True(10439, 2265, 2354) && f_10439_2305_2330(hostObjectTypeSymbol) != SymbolKind.ErrorType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10439, 2261, 2596);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10439, 2388, 2581);

                    return _hostObjectField = f_10439_2414_2580(_declaringSubmissionClass, hostObjectTypeSymbol, "<host-object>", isPublic: false, isReadOnly: true, isStatic: false);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10439, 2261, 2596);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10439, 2612, 2624);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10439, 1990, 2635);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10439_2208_2246(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GetHostObjectTypeSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10439, 2208, 2246);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10439_2305_2330(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10439, 2305, 2330);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedFieldSymbol
                f_10439_2414_2580(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                containingType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, string
                name, bool
                isPublic, bool
                isReadOnly, bool
                isStatic)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedFieldSymbol(containingType, type, name, isPublic: isPublic, isReadOnly: isReadOnly, isStatic: isStatic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10439, 2414, 2580);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10439, 1990, 2635);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10439, 1990, 2635);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal FieldSymbol GetOrMakeField(ImplicitNamedTypeSymbol previousSubmissionType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10439, 2647, 3591);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10439, 2755, 2928) || true) && (_previousSubmissionFieldMap == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10439, 2755, 2928);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10439, 2828, 2913);

                    _previousSubmissionFieldMap = f_10439_2858_2912();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10439, 2755, 2928);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10439, 2944, 2980);

                FieldSymbol
                previousSubmissionField
                = default(FieldSymbol);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10439, 2994, 3535) || true) && (!f_10439_2999_3091(_previousSubmissionFieldMap, previousSubmissionType, out previousSubmissionField))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10439, 2994, 3535);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10439, 3173, 3421);

                    previousSubmissionField = f_10439_3199_3420(_declaringSubmissionClass, previousSubmissionType, "<" + f_10439_3347_3374(previousSubmissionType) + ">", isReadOnly: true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10439, 3439, 3520);

                    f_10439_3439_3519(_previousSubmissionFieldMap, previousSubmissionType, previousSubmissionField);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10439, 2994, 3535);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10439, 3549, 3580);

                return previousSubmissionField;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10439, 2647, 3591);

                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.ImplicitNamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                f_10439_2858_2912()
                {
                    var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.ImplicitNamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10439, 2858, 2912);
                    return return_v;
                }


                bool
                f_10439_2999_3091(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.ImplicitNamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ImplicitNamedTypeSymbol
                key, out Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10439, 2999, 3091);
                    return return_v;
                }


                string
                f_10439_3347_3374(Microsoft.CodeAnalysis.CSharp.Symbols.ImplicitNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10439, 3347, 3374);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedFieldSymbol
                f_10439_3199_3420(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                containingType, Microsoft.CodeAnalysis.CSharp.Symbols.ImplicitNamedTypeSymbol
                type, string
                name, bool
                isReadOnly)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedFieldSymbol(containingType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, name, isReadOnly: isReadOnly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10439, 3199, 3420);
                    return return_v;
                }


                int
                f_10439_3439_3519(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.ImplicitNamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ImplicitNamedTypeSymbol
                key, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10439, 3439, 3519);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10439, 2647, 3591);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10439, 2647, 3591);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void AddToType(NamedTypeSymbol containingType, PEModuleBuilder moduleBeingBuilt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10439, 3603, 4148);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10439, 3717, 3881);
                    foreach (var field in f_10439_3739_3751_I(f_10439_3739_3751()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10439, 3717, 3881);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10439, 3785, 3866);

                        f_10439_3785_3865(moduleBeingBuilt, containingType, f_10439_3843_3864(field));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10439, 3717, 3881);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10439, 1, 165);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10439, 1, 165);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10439, 3897, 3948);

                FieldSymbol
                hostObjectField = f_10439_3927_3947(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10439, 3962, 4137) || true) && ((object)hostObjectField != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10439, 3962, 4137);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10439, 4031, 4122);

                    f_10439_4031_4121(moduleBeingBuilt, containingType, f_10439_4089_4120(hostObjectField));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10439, 3962, 4137);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10439, 3603, 4148);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                f_10439_3739_3751()
                {
                    var return_v = FieldSymbols;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10439, 3739, 3751);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                f_10439_3843_3864(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10439, 3843, 3864);
                    return return_v;
                }


                int
                f_10439_3785_3865(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                container, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                field)
                {
                    this_param.AddSynthesizedDefinition(container, (Microsoft.Cci.IFieldDefinition)field);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10439, 3785, 3865);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                f_10439_3739_3751_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10439, 3739, 3751);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10439_3927_3947(Microsoft.CodeAnalysis.CSharp.SynthesizedSubmissionFields
                this_param)
                {
                    var return_v = this_param.GetHostObjectField();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10439, 3927, 3947);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                f_10439_4089_4120(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10439, 4089, 4120);
                    return return_v;
                }


                int
                f_10439_4031_4121(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                container, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                field)
                {
                    this_param.AddSynthesizedDefinition(container, (Microsoft.Cci.IFieldDefinition)field);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10439, 4031, 4121);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10439, 3603, 4148);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10439, 3603, 4148);
            }
        }

        static SynthesizedSubmissionFields()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10439, 835, 4155);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10439, 835, 4155);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10439, 835, 4155);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10439, 835, 4155);

        int
        f_10439_1290_1323(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10439, 1290, 1323);
            return 0;
        }


        bool
        f_10439_1351_1384(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.IsSubmissionClass;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10439, 1351, 1384);
            return return_v;
        }


        int
        f_10439_1338_1385(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10439, 1338, 1385);
            return 0;
        }

    }
}
