// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal abstract partial class PropertySymbol : Symbol
    {
        private ParameterSignature _lazyParameterSignature;

        internal PropertySymbol()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10147, 1166, 1213);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10206, 9084, 9096);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 777, 800);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10147, 1166, 1213);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10147, 1166, 1213);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10147, 1166, 1213);
            }
        }

        public new virtual PropertySymbol OriginalDefinition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10147, 1589, 1652);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 1625, 1637);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10147, 1589, 1652);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10147, 1512, 1663);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10147, 1512, 1663);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected sealed override Symbol OriginalSymbolDefinition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10147, 1757, 1839);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 1793, 1824);

                    return f_10147_1800_1823(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10147, 1757, 1839);

                    Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    f_10147_1800_1823(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10147, 1800, 1823);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10147, 1675, 1850);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10147, 1675, 1850);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual ImmutableArray<string> NotNullMembers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10147, 2153, 2184);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 2156, 2184);
                    return ImmutableArray<string>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10147, 2153, 2184);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10147, 2153, 2184);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10147, 2153, 2184);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual ImmutableArray<string> NotNullWhenTrueMembers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10147, 2260, 2291);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 2263, 2291);
                    return ImmutableArray<string>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10147, 2260, 2291);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10147, 2260, 2291);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10147, 2260, 2291);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual ImmutableArray<string> NotNullWhenFalseMembers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10147, 2368, 2399);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 2371, 2399);
                    return ImmutableArray<string>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10147, 2368, 2399);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10147, 2368, 2399);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10147, 2368, 2399);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool ReturnsByRef
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10147, 2558, 2601);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 2564, 2599);

                    return f_10147_2571_2583(this) == RefKind.Ref;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10147, 2558, 2601);

                    Microsoft.CodeAnalysis.RefKind
                    f_10147_2571_2583(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.RefKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10147, 2571, 2583);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10147, 2531, 2603);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10147, 2531, 2603);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool ReturnsByRefReadonly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10147, 2777, 2828);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 2783, 2826);

                    return f_10147_2790_2802(this) == RefKind.RefReadOnly;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10147, 2777, 2828);

                    Microsoft.CodeAnalysis.RefKind
                    f_10147_2790_2802(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.RefKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10147, 2790, 2802);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10147, 2742, 2830);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10147, 2742, 2830);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public abstract RefKind RefKind { get; }

        public abstract TypeWithAnnotations TypeWithAnnotations { get; }

        public TypeSymbol Type
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10147, 3287, 3314);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 3290, 3314);
                    return f_10147_3290_3309().Type; DynAbs.Tracing.TraceSender.TraceExitMethod(10147, 3287, 3314);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10147, 3287, 3314);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10147, 3287, 3314);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public abstract ImmutableArray<CustomModifier> RefCustomModifiers { get; }

        public abstract ImmutableArray<ParameterSymbol> Parameters { get; }

        internal int ParameterCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10147, 4162, 4243);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 4198, 4228);

                    return this.Parameters.Length;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10147, 4162, 4243);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10147, 4110, 4254);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10147, 4110, 4254);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal ImmutableArray<TypeWithAnnotations> ParameterTypesWithAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10147, 4365, 4587);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 4401, 4493);

                    f_10147_4401_4492(f_10147_4447_4462(this), ref _lazyParameterSignature);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 4511, 4572);

                    return _lazyParameterSignature.parameterTypesWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10147, 4365, 4587);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10147_4447_4462(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10147, 4447, 4462);
                        return return_v;
                    }


                    int
                    f_10147_4401_4492(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    parameters, ref Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSignature
                    lazySignature)
                    {
                        ParameterSignature.PopulateParameterSignature(parameters, ref lazySignature);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10147, 4401, 4492);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10147, 4266, 4598);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10147, 4266, 4598);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal ImmutableArray<RefKind> ParameterRefKinds
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10147, 4685, 4895);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 4721, 4813);

                    f_10147_4721_4812(f_10147_4767_4782(this), ref _lazyParameterSignature);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 4831, 4880);

                    return _lazyParameterSignature.parameterRefKinds;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10147, 4685, 4895);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10147_4767_4782(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10147, 4767, 4782);
                        return return_v;
                    }


                    int
                    f_10147_4721_4812(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    parameters, ref Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSignature
                    lazySignature)
                    {
                        ParameterSignature.PopulateParameterSignature(parameters, ref lazySignature);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10147, 4721, 4812);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10147, 4610, 4906);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10147, 4610, 4906);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual bool RequiresInstanceReceiver
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10147, 5147, 5159);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 5150, 5159);
                    return f_10147_5150_5159_M(!IsStatic); DynAbs.Tracing.TraceSender.TraceExitMethod(10147, 5147, 5159);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10147, 5147, 5159);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10147, 5147, 5159);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public abstract bool IsIndexer { get; }

        public virtual bool IsIndexedProperty
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10147, 6108, 6129);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 6114, 6127);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10147, 6108, 6129);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10147, 6046, 6140);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10147, 6046, 6140);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsReadOnly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10147, 6339, 6532);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 6375, 6457);

                    var
                    property = (PropertySymbol)f_10147_6406_6456(this, f_10147_6436_6455(this))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 6475, 6517);

                    return (object)f_10147_6490_6508(property) == null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10147, 6339, 6532);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10147_6436_6455(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10147, 6436, 6455);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10147_6406_6456(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    member, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    accessingTypeOpt)
                    {
                        var return_v = member.GetLeastOverriddenMember(accessingTypeOpt);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10147, 6406, 6456);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10147_6490_6508(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.SetMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10147, 6490, 6508);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10147, 6292, 6543);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10147, 6292, 6543);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsWriteOnly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10147, 6744, 6937);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 6780, 6862);

                    var
                    property = (PropertySymbol)f_10147_6811_6861(this, f_10147_6841_6860(this))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 6880, 6922);

                    return (object)f_10147_6895_6913(property) == null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10147, 6744, 6937);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10147_6841_6860(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10147, 6841, 6860);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10147_6811_6861(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    member, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    accessingTypeOpt)
                    {
                        var return_v = member.GetLeastOverriddenMember(accessingTypeOpt);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10147, 6811, 6861);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10147_6895_6913(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.GetMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10147, 6895, 6913);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10147, 6696, 6948);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10147, 6696, 6948);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual bool IsDirectlyExcludedFromCodeCoverage
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10147, 7280, 7288);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 7283, 7288);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10147, 7280, 7288);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10147, 7217, 7291);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10147, 7217, 7291);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal abstract bool HasSpecialName { get; }

        public abstract MethodSymbol GetMethod
        {
            get;
        }

        public abstract MethodSymbol SetMethod
        {
            get;
        }

        internal abstract Cci.CallingConvention CallingConvention { get; }

        internal abstract bool MustCallMethodsDirectly { get; }

        public PropertySymbol OverriddenProperty
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10147, 8257, 8722);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 8293, 8677) || true) && (f_10147_8297_8312(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10147, 8293, 8677);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 8354, 8514) || true) && (f_10147_8358_8370())
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10147, 8354, 8514);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 8420, 8491);

                            return (PropertySymbol)f_10147_8443_8490(f_10147_8443_8468());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10147, 8354, 8514);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 8538, 8658);

                        return (PropertySymbol)f_10147_8561_8657(this, f_10147_8619_8656(f_10147_8619_8637()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10147, 8293, 8677);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 8695, 8707);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10147, 8257, 8722);

                    bool
                    f_10147_8297_8312(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.IsOverride;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10147, 8297, 8312);
                        return return_v;
                    }


                    bool
                    f_10147_8358_8370()
                    {
                        var return_v = IsDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10147, 8358, 8370);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                    f_10147_8443_8468()
                    {
                        var return_v = OverriddenOrHiddenMembers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10147, 8443, 8468);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10147_8443_8490(Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                    this_param)
                    {
                        var return_v = this_param.GetOverriddenMember();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10147, 8443, 8490);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    f_10147_8619_8637()
                    {
                        var return_v = OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10147, 8619, 8637);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    f_10147_8619_8656(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.OverriddenProperty;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10147, 8619, 8656);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10147_8561_8657(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    substitutedOverridingMember, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    overriddenByDefinitionMember)
                    {
                        var return_v = OverriddenOrHiddenMembersResult.GetOverriddenMember((Microsoft.CodeAnalysis.CSharp.Symbol)substitutedOverridingMember, (Microsoft.CodeAnalysis.CSharp.Symbol)overriddenByDefinitionMember);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10147, 8561, 8657);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10147, 8192, 8733);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10147, 8192, 8733);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual OverriddenOrHiddenMembersResult OverriddenOrHiddenMembers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10147, 8844, 8939);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 8880, 8924);

                    return f_10147_8887_8923(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10147, 8844, 8939);

                    Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                    f_10147_8887_8923(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    member)
                    {
                        var return_v = member.MakeOverriddenOrHiddenMembers();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10147, 8887, 8923);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10147, 8745, 8950);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10147, 8745, 8950);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool HidesBasePropertiesByName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10147, 9026, 9369);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 9120, 9167);

                    MethodSymbol
                    accessor = f_10147_9144_9153() ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>(10147, 9144, 9166) ?? f_10147_9157_9166())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 9287, 9354);

                    return (object)accessor != null && (DynAbs.Tracing.TraceSender.Expression_True(10147, 9294, 9353) && f_10147_9322_9353(accessor));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10147, 9026, 9369);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10147_9144_9153()
                    {
                        var return_v = GetMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10147, 9144, 9153);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10147_9157_9166()
                    {
                        var return_v = SetMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10147, 9157, 9166);
                        return return_v;
                    }


                    bool
                    f_10147_9322_9353(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.HidesBaseMethodsByName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10147, 9322, 9353);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10147, 8962, 9380);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10147, 8962, 9380);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal PropertySymbol GetLeastOverriddenProperty(NamedTypeSymbol accessingTypeOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10147, 9392, 11054);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 9501, 9557);

                accessingTypeOpt = f_10147_9520_9556_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(accessingTypeOpt, 10147, 9520, 9556)?.OriginalDefinition);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 9571, 9595);

                PropertySymbol
                p = this
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 9609, 11018) || true) && (f_10147_9616_9628(p) && (DynAbs.Tracing.TraceSender.Expression_True(10147, 9616, 9660) && f_10147_9632_9660_M(!p.HidesBasePropertiesByName)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10147, 9609, 11018);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 10597, 10646);

                        PropertySymbol
                        overridden = f_10147_10625_10645(p)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 10664, 10714);

                        HashSet<DiagnosticInfo>
                        useSiteDiagnostics = null
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 10732, 10968) || true) && ((object)overridden == null || (DynAbs.Tracing.TraceSender.Expression_False(10147, 10736, 10901) || (accessingTypeOpt is { } && (DynAbs.Tracing.TraceSender.Expression_True(10147, 10788, 10900) && !f_10147_10816_10900(overridden, accessingTypeOpt, ref useSiteDiagnostics)))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10147, 10732, 10968);
                            DynAbs.Tracing.TraceSender.TraceBreak(10147, 10943, 10949);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10147, 10732, 10968);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 10988, 11003);

                        p = overridden;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10147, 9609, 11018);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10147, 9609, 11018);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10147, 9609, 11018);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 11034, 11043);

                return p;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10147, 9392, 11054);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10147_9520_9556_M(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10147, 9520, 9556);
                    return return_v;
                }


                bool
                f_10147_9616_9628(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.IsOverride;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10147, 9616, 9628);
                    return return_v;
                }


                bool
                f_10147_9632_9660_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10147, 9632, 9660);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10147_10625_10645(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.OverriddenProperty;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10147, 10625, 10645);
                    return return_v;
                }


                bool
                f_10147_10816_10900(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                symbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                within, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = AccessCheck.IsSymbolAccessible((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, within, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10147, 10816, 10900);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10147, 9392, 11054);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10147, 9392, 11054);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual bool IsExplicitInterfaceImplementation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10147, 11520, 11574);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 11526, 11572);

                    return f_10147_11533_11565().Any();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10147, 11520, 11574);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                    f_10147_11533_11565()
                    {
                        var return_v = ExplicitInterfaceImplementations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10147, 11533, 11565);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10147, 11440, 11585);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10147, 11440, 11585);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public abstract ImmutableArray<PropertySymbol> ExplicitInterfaceImplementations { get; }

        public sealed override SymbolKind Kind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10147, 12123, 12201);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 12159, 12186);

                    return SymbolKind.Property;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10147, 12123, 12201);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10147, 12060, 12212);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10147, 12060, 12212);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override TResult Accept<TArgument, TResult>(CSharpSymbolVisitor<TArgument, TResult> visitor, TArgument argument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10147, 12312, 12514);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 12458, 12503);

                return f_10147_12465_12502<TResult, TArgument>(visitor, this, argument);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10147, 12312, 12514);

                TResult
                f_10147_12465_12502<TResult, TArgument>(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TArgument, TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                symbol, TArgument
                argument)
                {
                    var return_v = this_param.VisitProperty(symbol, argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10147, 12465, 12502);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10147, 12312, 12514);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10147, 12312, 12514);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void Accept(CSharpSymbolVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10147, 12526, 12646);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 12607, 12635);

                f_10147_12607_12634(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10147, 12526, 12646);

                int
                f_10147_12607_12634(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                symbol)
                {
                    this_param.VisitProperty(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10147, 12607, 12634);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10147, 12526, 12646);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10147, 12526, 12646);
            }
        }

        public override TResult Accept<TResult>(CSharpSymbolVisitor<TResult> visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10147, 12658, 12806);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 12760, 12795);

                return f_10147_12767_12794<TResult>(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10147, 12658, 12806);

                TResult
                f_10147_12767_12794<TResult>(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                symbol)
                {
                    var return_v = this_param.VisitProperty(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10147, 12767, 12794);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10147, 12658, 12806);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10147, 12658, 12806);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal PropertySymbol AsMember(NamedTypeSymbol newOwner)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10147, 12818, 13187);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 12901, 12933);

                f_10147_12901_12932(f_10147_12914_12931(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 12947, 13048);

                f_10147_12947_13047(f_10147_12960_13046(f_10147_12976_13003(newOwner), f_10147_13005_13045(f_10147_13005_13026(this))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 13062, 13176);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10147, 13069, 13090) || ((f_10147_13069_13090(newOwner) && DynAbs.Tracing.TraceSender.Conditional_F2(10147, 13093, 13097)) || DynAbs.Tracing.TraceSender.Conditional_F3(10147, 13100, 13175))) ? this : f_10147_13100_13175(newOwner as SubstitutedNamedTypeSymbol, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10147, 12818, 13187);

                bool
                f_10147_12914_12931(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10147, 12914, 12931);
                    return return_v;
                }


                int
                f_10147_12901_12932(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10147, 12901, 12932);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10147_12976_13003(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10147, 12976, 13003);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10147_13005_13026(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10147, 13005, 13026);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10147_13005_13045(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10147, 13005, 13045);
                    return return_v;
                }


                bool
                f_10147_12960_13046(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10147, 12960, 13046);
                    return return_v;
                }


                int
                f_10147_12947_13047(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10147, 12947, 13047);
                    return 0;
                }


                bool
                f_10147_13069_13090(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10147, 13069, 13090);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedPropertySymbol
                f_10147_13100_13175(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                containingType, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                originalDefinition)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedPropertySymbol((Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedNamedTypeSymbol?)containingType, originalDefinition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10147, 13100, 13175);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10147, 12818, 13187);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10147, 12818, 13187);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override DiagnosticInfo GetUseSiteDiagnostic()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10147, 13239, 13505);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 13319, 13424) || true) && (f_10147_13323_13340(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10147, 13319, 13424);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 13374, 13409);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetUseSiteDiagnostic(), 10147, 13381, 13408);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10147, 13319, 13424);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 13440, 13494);

                return f_10147_13447_13493(f_10147_13447_13470(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10147, 13239, 13505);

                bool
                f_10147_13323_13340(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10147, 13323, 13340);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10147_13447_13470(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10147, 13447, 13470);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10147_13447_13493(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.GetUseSiteDiagnostic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10147, 13447, 13493);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10147, 13239, 13505);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10147, 13239, 13505);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool CalculateUseSiteDiagnostic(ref DiagnosticInfo result)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10147, 13517, 14988);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 13609, 13641);

                f_10147_13609_13640(f_10147_13622_13639(this));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 13725, 14152) || true) && (f_10147_13729_13832(this, ref result, f_10147_13773_13797(this), AllowedRequiredModifierType.None) || (DynAbs.Tracing.TraceSender.Expression_False(10147, 13729, 14004) || f_10147_13853_14004(this, ref result, f_10147_13908_13931(this), AllowedRequiredModifierType.System_Runtime_InteropServices_InAttribute)) || (DynAbs.Tracing.TraceSender.Expression_False(10147, 13729, 14091) || f_10147_14025_14091(this, ref result, f_10147_14075_14090(this))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10147, 13725, 14152);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 14125, 14137);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10147, 13725, 14152);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 14329, 14948) || true) && (f_10147_14333_14375(f_10147_14333_14354(this)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10147, 14329, 14948);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 14409, 14460);

                    HashSet<TypeSymbol>
                    unificationCheckedTypes = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 14478, 14933) || true) && (this.TypeWithAnnotations.GetUnificationUseSiteDiagnosticRecursive(ref result, this, ref unificationCheckedTypes) || (DynAbs.Tracing.TraceSender.Expression_False(10147, 14482, 14731) || f_10147_14619_14731(ref result, f_10147_14672_14695(this), this, ref unificationCheckedTypes)) || (DynAbs.Tracing.TraceSender.Expression_False(10147, 14482, 14860) || f_10147_14756_14860(ref result, f_10147_14809_14824(this), this, ref unificationCheckedTypes)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10147, 14478, 14933);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 14902, 14914);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10147, 14478, 14933);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10147, 14329, 14948);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 14964, 14977);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10147, 13517, 14988);

                bool
                f_10147_13622_13639(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10147, 13622, 13639);
                    return return_v;
                }


                int
                f_10147_13609_13640(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10147, 13609, 13640);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10147_13773_13797(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10147, 13773, 13797);
                    return return_v;
                }


                bool
                f_10147_13729_13832(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param, ref Microsoft.CodeAnalysis.DiagnosticInfo
                result, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type, Microsoft.CodeAnalysis.CSharp.Symbol.AllowedRequiredModifierType
                allowedRequiredModifierType)
                {
                    var return_v = this_param.DeriveUseSiteDiagnosticFromType(ref result, type, allowedRequiredModifierType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10147, 13729, 13832);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10147_13908_13931(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.RefCustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10147, 13908, 13931);
                    return return_v;
                }


                bool
                f_10147_13853_14004(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param, ref Microsoft.CodeAnalysis.DiagnosticInfo
                result, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                customModifiers, Microsoft.CodeAnalysis.CSharp.Symbol.AllowedRequiredModifierType
                allowedRequiredModifierType)
                {
                    var return_v = this_param.DeriveUseSiteDiagnosticFromCustomModifiers(ref result, customModifiers, allowedRequiredModifierType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10147, 13853, 14004);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10147_14075_14090(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10147, 14075, 14090);
                    return return_v;
                }


                bool
                f_10147_14025_14091(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param, ref Microsoft.CodeAnalysis.DiagnosticInfo
                result, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters)
                {
                    var return_v = this_param.DeriveUseSiteDiagnosticFromParameters(ref result, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10147, 14025, 14091);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10147_14333_14354(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10147, 14333, 14354);
                    return return_v;
                }


                bool
                f_10147_14333_14375(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                this_param)
                {
                    var return_v = this_param.HasUnifiedReferences;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10147, 14333, 14375);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10147_14672_14695(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.RefCustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10147, 14672, 14695);
                    return return_v;
                }


                bool
                f_10147_14619_14731(ref Microsoft.CodeAnalysis.DiagnosticInfo
                result, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                modifiers, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                owner, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                checkedTypes)
                {
                    var return_v = GetUnificationUseSiteDiagnosticRecursive(ref result, modifiers, (Microsoft.CodeAnalysis.CSharp.Symbol)owner, ref checkedTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10147, 14619, 14731);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10147_14809_14824(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10147, 14809, 14824);
                    return return_v;
                }


                bool
                f_10147_14756_14860(ref Microsoft.CodeAnalysis.DiagnosticInfo
                result, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                owner, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                checkedTypes)
                {
                    var return_v = GetUnificationUseSiteDiagnosticRecursive(ref result, parameters, (Microsoft.CodeAnalysis.CSharp.Symbol)owner, ref checkedTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10147, 14756, 14860);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10147, 13517, 14988);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10147, 13517, 14988);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override int HighestPriorityUseSiteError
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10147, 15230, 15319);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 15266, 15304);

                    return (int)ErrorCode.ERR_BindToBogus;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10147, 15230, 15319);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10147, 15155, 15330);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10147, 15155, 15330);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool HasUnsupportedMetadata
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10147, 15417, 15666);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 15453, 15498);

                    DiagnosticInfo
                    info = f_10147_15475_15497(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 15516, 15651);

                    return (object)info != null && (DynAbs.Tracing.TraceSender.Expression_True(10147, 15523, 15650) && (f_10147_15548_15557(info) == (int)ErrorCode.ERR_BindToBogus || (DynAbs.Tracing.TraceSender.Expression_False(10147, 15548, 15649) || f_10147_15595_15604(info) == (int)ErrorCode.ERR_ByRefReturnUnsupported)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10147, 15417, 15666);

                    Microsoft.CodeAnalysis.DiagnosticInfo
                    f_10147_15475_15497(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.GetUseSiteDiagnostic();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10147, 15475, 15497);
                        return return_v;
                    }


                    int
                    f_10147_15548_15557(Microsoft.CodeAnalysis.DiagnosticInfo
                    this_param)
                    {
                        var return_v = this_param.Code;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10147, 15548, 15557);
                        return return_v;
                    }


                    int
                    f_10147_15595_15604(Microsoft.CodeAnalysis.DiagnosticInfo
                    this_param)
                    {
                        var return_v = this_param.Code;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10147, 15595, 15604);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10147, 15342, 15677);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10147, 15342, 15677);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected sealed override ISymbol CreateISymbol()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10147, 15711, 15840);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 15785, 15829);

                return f_10147_15792_15828(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10147, 15711, 15840);

                Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.PropertySymbol
                f_10147_15792_15828(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                underlying)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.PropertySymbol(underlying);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10147, 15792, 15828);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10147, 15711, 15840);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10147, 15711, 15840);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(Symbol symbol, TypeCompareKind compareKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10147, 15880, 16739);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 15976, 16024);

                PropertySymbol
                other = symbol as PropertySymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 16040, 16134) || true) && (f_10147_16044_16072(null, other))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10147, 16040, 16134);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 16106, 16119);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10147, 16040, 16134);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 16150, 16243) || true) && (f_10147_16154_16182(this, other))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10147, 16150, 16243);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 16216, 16228);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10147, 16150, 16243);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 16259, 16389) || true) && (other is NativeIntegerPropertySymbol nps)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10147, 16259, 16389);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 16337, 16374);

                    return f_10147_16344_16373(nps, this, compareKind);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10147, 16259, 16389);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 16577, 16728);

                return f_10147_16584_16657(f_10147_16602_16621(this), f_10147_16623_16643(other), compareKind) && (DynAbs.Tracing.TraceSender.Expression_True(10147, 16584, 16727) && f_10147_16661_16727(f_10147_16677_16700(this), f_10147_16702_16726(other)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10147, 15880, 16739);

                bool
                f_10147_16044_16072(object?
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol?
                objB)
                {
                    var return_v = ReferenceEquals(objA, (object?)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10147, 16044, 16072);
                    return return_v;
                }


                bool
                f_10147_16154_16182(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10147, 16154, 16182);
                    return return_v;
                }


                bool
                f_10147_16344_16373(Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerPropertySymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                other, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbol)other, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10147, 16344, 16373);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10147_16602_16621(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10147, 16602, 16621);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10147_16623_16643(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10147, 16623, 16643);
                    return return_v;
                }


                bool
                f_10147_16584_16657(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10147, 16584, 16657);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10147_16677_16700(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10147, 16677, 16700);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10147_16702_16726(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10147, 16702, 16726);
                    return return_v;
                }


                bool
                f_10147_16661_16727(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10147, 16661, 16727);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10147, 15880, 16739);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10147, 15880, 16739);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10147, 16751, 17032);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 16809, 16822);

                int
                hash = 1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 16836, 16883);

                hash = f_10147_16843_16882(f_10147_16856_16875(this), hash);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 16897, 16934);

                hash = f_10147_16904_16933(f_10147_16917_16926(this), hash);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 16948, 16995);

                hash = f_10147_16955_16994(hash, f_10147_16974_16993(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10147, 17009, 17021);

                return hash;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10147, 16751, 17032);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10147_16856_16875(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10147, 16856, 16875);
                    return return_v;
                }


                int
                f_10147_16843_16882(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10147, 16843, 16882);
                    return return_v;
                }


                string
                f_10147_16917_16926(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10147, 16917, 16926);
                    return return_v;
                }


                int
                f_10147_16904_16933(string
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10147, 16904, 16933);
                    return return_v;
                }


                int
                f_10147_16974_16993(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10147, 16974, 16993);
                    return return_v;
                }


                int
                f_10147_16955_16994(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10147, 16955, 16994);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10147, 16751, 17032);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10147, 16751, 17032);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
        f_10147_3290_3309()
        {
            var return_v = TypeWithAnnotations;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10147, 3290, 3309);
            return return_v;
        }


        bool
        f_10147_5150_5159_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10147, 5150, 5159);
            return return_v;
        }

    }
}
