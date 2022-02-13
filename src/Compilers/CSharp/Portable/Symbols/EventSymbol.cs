// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal abstract partial class EventSymbol : Symbol
    {
        internal EventSymbol()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10107, 941, 985);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10185, 4775, 4787);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10107, 941, 985);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10107, 941, 985);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10107, 941, 985);
            }
        }

        public new virtual EventSymbol OriginalDefinition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10107, 1358, 1421);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10107, 1394, 1406);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10107, 1358, 1421);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10107, 1284, 1432);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10107, 1284, 1432);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10107, 1526, 1608);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10107, 1562, 1593);

                    return f_10107_1569_1592(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10107, 1526, 1608);

                    Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    f_10107_1569_1592(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        var return_v = this_param.OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10107, 1569, 1592);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10107, 1444, 1619);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10107, 1444, 1619);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public abstract TypeWithAnnotations TypeWithAnnotations { get; }

        public TypeSymbol Type
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10107, 1923, 1950);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10107, 1926, 1950);
                    return f_10107_1926_1945().Type; DynAbs.Tracing.TraceSender.TraceExitMethod(10107, 1923, 1950);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10107, 1923, 1950);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10107, 1923, 1950);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public abstract MethodSymbol? AddMethod { get; }

        public abstract MethodSymbol? RemoveMethod { get; }

        internal bool HasAssociatedField
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10107, 2394, 2490);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10107, 2430, 2475);

                    return (object?)f_10107_2446_2466(this) != null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10107, 2394, 2490);

                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                    f_10107_2446_2466(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        var return_v = this_param.AssociatedField;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10107, 2446, 2466);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10107, 2337, 2501);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10107, 2337, 2501);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10107, 2742, 2754);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10107, 2745, 2754);
                    return f_10107_2745_2754_M(!IsStatic); DynAbs.Tracing.TraceSender.TraceExitMethod(10107, 2742, 2754);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10107, 2742, 2754);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10107, 2742, 2754);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public abstract bool IsWindowsRuntimeEvent { get; }

        internal virtual bool IsDirectlyExcludedFromCodeCoverage
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10107, 3579, 3587);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10107, 3582, 3587);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10107, 3579, 3587);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10107, 3516, 3590);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10107, 3516, 3590);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal abstract bool HasSpecialName { get; }

        public ImmutableArray<CSharpAttributeData> GetFieldAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10107, 4161, 4422);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10107, 4249, 4411);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10107, 4256, 4293) || (((object?)f_10107_4265_4285(this) == null && DynAbs.Tracing.TraceSender.Conditional_F2(10107, 4313, 4354)) || DynAbs.Tracing.TraceSender.Conditional_F3(10107, 4374, 4410))) ? ImmutableArray<CSharpAttributeData>.Empty : f_10107_4374_4410(f_10107_4374_4394(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10107, 4161, 4422);

                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                f_10107_4265_4285(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.AssociatedField;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10107, 4265, 4285);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10107_4374_4394(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.AssociatedField;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10107, 4374, 4394);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10107_4374_4410(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10107, 4374, 4410);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10107, 4161, 4422);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10107, 4161, 4422);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual FieldSymbol? AssociatedField
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10107, 4504, 4567);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10107, 4540, 4552);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10107, 4504, 4567);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10107, 4434, 4578);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10107, 4434, 4578);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public EventSymbol? OverriddenEvent
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10107, 4749, 5205);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10107, 4785, 5160) || true) && (f_10107_4789_4804(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10107, 4785, 5160);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10107, 4846, 5003) || true) && (f_10107_4850_4862())
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10107, 4846, 5003);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10107, 4912, 4980);

                            return (EventSymbol)f_10107_4932_4979(f_10107_4932_4957());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10107, 4846, 5003);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10107, 5027, 5141);

                        return (EventSymbol)f_10107_5047_5140(this, f_10107_5105_5139(f_10107_5105_5123()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10107, 4785, 5160);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10107, 5178, 5190);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10107, 4749, 5205);

                    bool
                    f_10107_4789_4804(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        var return_v = this_param.IsOverride;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10107, 4789, 4804);
                        return return_v;
                    }


                    bool
                    f_10107_4850_4862()
                    {
                        var return_v = IsDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10107, 4850, 4862);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                    f_10107_4932_4957()
                    {
                        var return_v = OverriddenOrHiddenMembers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10107, 4932, 4957);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10107_4932_4979(Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                    this_param)
                    {
                        var return_v = this_param.GetOverriddenMember();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10107, 4932, 4979);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    f_10107_5105_5123()
                    {
                        var return_v = OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10107, 5105, 5123);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol?
                    f_10107_5105_5139(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        var return_v = this_param.OverriddenEvent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10107, 5105, 5139);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10107_5047_5140(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    substitutedOverridingMember, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol?
                    overriddenByDefinitionMember)
                    {
                        var return_v = OverriddenOrHiddenMembersResult.GetOverriddenMember((Microsoft.CodeAnalysis.CSharp.Symbol)substitutedOverridingMember, (Microsoft.CodeAnalysis.CSharp.Symbol?)overriddenByDefinitionMember);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10107, 5047, 5140);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10107, 4689, 5216);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10107, 4689, 5216);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10107, 5327, 5422);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10107, 5363, 5407);

                    return f_10107_5370_5406(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10107, 5327, 5422);

                    Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                    f_10107_5370_5406(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    member)
                    {
                        var return_v = member.MakeOverriddenOrHiddenMembers();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10107, 5370, 5406);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10107, 5228, 5433);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10107, 5228, 5433);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool HidesBaseEventsByName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10107, 5505, 5693);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10107, 5541, 5592);

                    MethodSymbol?
                    accessor = f_10107_5566_5575() ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?>(10107, 5566, 5591) ?? f_10107_5579_5591())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10107, 5610, 5678);

                    return (object?)accessor != null && (DynAbs.Tracing.TraceSender.Expression_True(10107, 5617, 5677) && f_10107_5646_5677(accessor));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10107, 5505, 5693);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                    f_10107_5566_5575()
                    {
                        var return_v = AddMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10107, 5566, 5575);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                    f_10107_5579_5591()
                    {
                        var return_v = RemoveMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10107, 5579, 5591);
                        return return_v;
                    }


                    bool
                    f_10107_5646_5677(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.HidesBaseMethodsByName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10107, 5646, 5677);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10107, 5445, 5704);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10107, 5445, 5704);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal EventSymbol GetLeastOverriddenEvent(NamedTypeSymbol? accessingTypeOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10107, 5716, 7410);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10107, 5820, 5876);

                accessingTypeOpt = f_10107_5839_5875_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(accessingTypeOpt, 10107, 5839, 5875)?.OriginalDefinition);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10107, 5890, 5911);

                EventSymbol
                e = this
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10107, 5925, 7374) || true) && (f_10107_5932_5944(e) && (DynAbs.Tracing.TraceSender.Expression_True(10107, 5932, 5972) && f_10107_5948_5972_M(!e.HidesBaseEventsByName)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10107, 5925, 7374);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10107, 6956, 7000);

                        EventSymbol?
                        overridden = f_10107_6982_6999(e)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10107, 7018, 7069);

                        HashSet<DiagnosticInfo>?
                        useSiteDiagnostics = null
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10107, 7087, 7324) || true) && ((object?)overridden == null || (DynAbs.Tracing.TraceSender.Expression_False(10107, 7091, 7257) || (accessingTypeOpt is { } && (DynAbs.Tracing.TraceSender.Expression_True(10107, 7144, 7256) && !f_10107_7172_7256(overridden, accessingTypeOpt, ref useSiteDiagnostics)))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10107, 7087, 7324);
                            DynAbs.Tracing.TraceSender.TraceBreak(10107, 7299, 7305);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10107, 7087, 7324);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10107, 7344, 7359);

                        e = overridden;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10107, 5925, 7374);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10107, 5925, 7374);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10107, 5925, 7374);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10107, 7390, 7399);

                return e;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10107, 5716, 7410);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10107_5839_5875_M(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10107, 5839, 5875);
                    return return_v;
                }


                bool
                f_10107_5932_5944(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.IsOverride;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10107, 5932, 5944);
                    return return_v;
                }


                bool
                f_10107_5948_5972_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10107, 5948, 5972);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol?
                f_10107_6982_6999(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.OverriddenEvent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10107, 6982, 6999);
                    return return_v;
                }


                bool
                f_10107_7172_7256(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                within, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = AccessCheck.IsSymbolAccessible((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, within, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10107, 7172, 7256);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10107, 5716, 7410);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10107, 5716, 7410);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual bool IsExplicitInterfaceImplementation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10107, 7876, 7973);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10107, 7912, 7958);

                    return f_10107_7919_7951().Any();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10107, 7876, 7973);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol>
                    f_10107_7919_7951()
                    {
                        var return_v = ExplicitInterfaceImplementations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10107, 7919, 7951);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10107, 7796, 7984);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10107, 7796, 7984);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public abstract ImmutableArray<EventSymbol> ExplicitInterfaceImplementations { get; }

        public sealed override SymbolKind Kind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10107, 8505, 8580);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10107, 8541, 8565);

                    return SymbolKind.Event;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10107, 8505, 8580);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10107, 8442, 8591);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10107, 8442, 8591);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override TResult Accept<TArgument, TResult>(CSharpSymbolVisitor<TArgument, TResult> visitor, TArgument argument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10107, 8691, 8890);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10107, 8837, 8879);

                return f_10107_8844_8878<TResult, TArgument>(visitor, this, argument);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10107, 8691, 8890);

                TResult
                f_10107_8844_8878<TResult, TArgument>(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TArgument, TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                symbol, TArgument
                argument)
                {
                    var return_v = this_param.VisitEvent(symbol, argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10107, 8844, 8878);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10107, 8691, 8890);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10107, 8691, 8890);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void Accept(CSharpSymbolVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10107, 8902, 9019);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10107, 8983, 9008);

                f_10107_8983_9007(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10107, 8902, 9019);

                int
                f_10107_8983_9007(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                symbol)
                {
                    this_param.VisitEvent(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10107, 8983, 9007);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10107, 8902, 9019);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10107, 8902, 9019);
            }
        }

        public override TResult Accept<TResult>(CSharpSymbolVisitor<TResult> visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10107, 9031, 9176);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10107, 9133, 9165);

                return f_10107_9140_9164<TResult>(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10107, 9031, 9176);

                TResult
                f_10107_9140_9164<TResult>(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                symbol)
                {
                    var return_v = this_param.VisitEvent(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10107, 9140, 9164);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10107, 9031, 9176);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10107, 9031, 9176);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal EventSymbol AsMember(NamedTypeSymbol newOwner)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10107, 9188, 9646);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10107, 9268, 9300);

                f_10107_9268_9299(f_10107_9281_9298(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10107, 9314, 9415);

                f_10107_9314_9414(f_10107_9327_9413(f_10107_9343_9370(newOwner), f_10107_9372_9412(f_10107_9372_9393(this))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10107, 9429, 9507);

                f_10107_9429_9506(f_10107_9442_9463(newOwner) || (DynAbs.Tracing.TraceSender.Expression_False(10107, 9442, 9505) || newOwner is SubstitutedNamedTypeSymbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10107, 9521, 9635);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10107, 9528, 9549) || ((f_10107_9528_9549(newOwner) && DynAbs.Tracing.TraceSender.Conditional_F2(10107, 9552, 9556)) || DynAbs.Tracing.TraceSender.Conditional_F3(10107, 9559, 9634))) ? this : f_10107_9559_9634((newOwner as SubstitutedNamedTypeSymbol)!, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10107, 9188, 9646);

                bool
                f_10107_9281_9298(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10107, 9281, 9298);
                    return return_v;
                }


                int
                f_10107_9268_9299(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10107, 9268, 9299);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10107_9343_9370(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10107, 9343, 9370);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10107_9372_9393(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10107, 9372, 9393);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10107_9372_9412(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10107, 9372, 9412);
                    return return_v;
                }


                bool
                f_10107_9327_9413(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10107, 9327, 9413);
                    return return_v;
                }


                int
                f_10107_9314_9414(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10107, 9314, 9414);
                    return 0;
                }


                bool
                f_10107_9442_9463(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10107, 9442, 9463);
                    return return_v;
                }


                int
                f_10107_9429_9506(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10107, 9429, 9506);
                    return 0;
                }


                bool
                f_10107_9528_9549(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10107, 9528, 9549);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedEventSymbol
                f_10107_9559_9634(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                containingType, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                originalDefinition)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedEventSymbol((Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedNamedTypeSymbol)containingType, originalDefinition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10107, 9559, 9634);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10107, 9188, 9646);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10107, 9188, 9646);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal abstract bool MustCallMethodsDirectly { get; }

        internal override DiagnosticInfo? GetUseSiteDiagnostic()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10107, 9765, 10032);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10107, 9846, 9951) || true) && (f_10107_9850_9867(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10107, 9846, 9951);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10107, 9901, 9936);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetUseSiteDiagnostic(), 10107, 9908, 9935);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10107, 9846, 9951);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10107, 9967, 10021);

                return f_10107_9974_10020(f_10107_9974_9997(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10107, 9765, 10032);

                bool
                f_10107_9850_9867(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10107, 9850, 9867);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                f_10107_9974_9997(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10107, 9974, 9997);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo?
                f_10107_9974_10020(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.GetUseSiteDiagnostic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10107, 9974, 10020);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10107, 9765, 10032);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10107, 9765, 10032);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool CalculateUseSiteDiagnostic(ref DiagnosticInfo? result)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10107, 10044, 10966);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10107, 10137, 10169);

                f_10107_10137_10168(f_10107_10150_10167(this));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10107, 10219, 10387) || true) && (f_10107_10223_10326(this, ref result, f_10107_10267_10291(this), AllowedRequiredModifierType.None))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10107, 10219, 10387);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10107, 10360, 10372);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10107, 10219, 10387);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10107, 10403, 10926) || true) && (f_10107_10407_10449(f_10107_10407_10428(this)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10107, 10403, 10926);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10107, 10652, 10704);

                    HashSet<TypeSymbol>?
                    unificationCheckedTypes = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10107, 10722, 10911) || true) && (this.TypeWithAnnotations.GetUnificationUseSiteDiagnosticRecursive(ref result, this, ref unificationCheckedTypes))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10107, 10722, 10911);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10107, 10880, 10892);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10107, 10722, 10911);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10107, 10403, 10926);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10107, 10942, 10955);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10107, 10044, 10966);

                bool
                f_10107_10150_10167(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10107, 10150, 10167);
                    return return_v;
                }


                int
                f_10107_10137_10168(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10107, 10137, 10168);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10107_10267_10291(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10107, 10267, 10291);
                    return return_v;
                }


                bool
                f_10107_10223_10326(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param, ref Microsoft.CodeAnalysis.DiagnosticInfo?
                result, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type, Microsoft.CodeAnalysis.CSharp.Symbol.AllowedRequiredModifierType
                allowedRequiredModifierType)
                {
                    var return_v = this_param.DeriveUseSiteDiagnosticFromType(ref result, type, allowedRequiredModifierType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10107, 10223, 10326);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10107_10407_10428(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10107, 10407, 10428);
                    return return_v;
                }


                bool
                f_10107_10407_10449(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                this_param)
                {
                    var return_v = this_param.HasUnifiedReferences;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10107, 10407, 10449);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10107, 10044, 10966);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10107, 10044, 10966);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override int HighestPriorityUseSiteError
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10107, 11053, 11142);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10107, 11089, 11127);

                    return (int)ErrorCode.ERR_BindToBogus;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10107, 11053, 11142);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10107, 10978, 11153);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10107, 10978, 11153);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10107, 11240, 11431);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10107, 11276, 11322);

                    DiagnosticInfo?
                    info = f_10107_11299_11321(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10107, 11340, 11416);

                    return (object?)info != null && (DynAbs.Tracing.TraceSender.Expression_True(10107, 11347, 11415) && f_10107_11372_11381(info) == (int)ErrorCode.ERR_BindToBogus);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10107, 11240, 11431);

                    Microsoft.CodeAnalysis.DiagnosticInfo?
                    f_10107_11299_11321(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        var return_v = this_param.GetUseSiteDiagnostic();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10107, 11299, 11321);
                        return return_v;
                    }


                    int
                    f_10107_11372_11381(Microsoft.CodeAnalysis.DiagnosticInfo
                    this_param)
                    {
                        var return_v = this_param.Code;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10107, 11372, 11381);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10107, 11165, 11442);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10107, 11165, 11442);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected sealed override ISymbol CreateISymbol()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10107, 11476, 11602);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10107, 11550, 11591);

                return f_10107_11557_11590(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10107, 11476, 11602);

                Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.EventSymbol
                f_10107_11557_11590(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                underlying)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.EventSymbol(underlying);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10107, 11557, 11590);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10107, 11476, 11602);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10107, 11476, 11602);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(Symbol? obj, TypeCompareKind compareKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10107, 11642, 12343);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10107, 11736, 11776);

                EventSymbol?
                other = obj as EventSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10107, 11792, 11886) || true) && (f_10107_11796_11824(null, other))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10107, 11792, 11886);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10107, 11858, 11871);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10107, 11792, 11886);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10107, 11902, 11995) || true) && (f_10107_11906_11934(this, other))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10107, 11902, 11995);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10107, 11968, 11980);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10107, 11902, 11995);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10107, 12181, 12332);

                return f_10107_12188_12261(f_10107_12206_12225(this), f_10107_12227_12247(other), compareKind) && (DynAbs.Tracing.TraceSender.Expression_True(10107, 12188, 12331) && f_10107_12265_12331(f_10107_12281_12304(this), f_10107_12306_12330(other)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10107, 11642, 12343);

                bool
                f_10107_11796_11824(object?
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol?
                objB)
                {
                    var return_v = ReferenceEquals(objA, (object?)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10107, 11796, 11824);
                    return return_v;
                }


                bool
                f_10107_11906_11934(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10107, 11906, 11934);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10107_12206_12225(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10107, 12206, 12225);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10107_12227_12247(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10107, 12227, 12247);
                    return return_v;
                }


                bool
                f_10107_12188_12261(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10107, 12188, 12261);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                f_10107_12281_12304(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10107, 12281, 12304);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                f_10107_12306_12330(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10107, 12306, 12330);
                    return return_v;
                }


                bool
                f_10107_12265_12331(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10107, 12265, 12331);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10107, 11642, 12343);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10107, 11642, 12343);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10107, 12355, 12575);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10107, 12413, 12426);

                int
                hash = 1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10107, 12440, 12487);

                hash = f_10107_12447_12486(f_10107_12460_12479(this), hash);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10107, 12501, 12538);

                hash = f_10107_12508_12537(f_10107_12521_12530(this), hash);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10107, 12552, 12564);

                return hash;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10107, 12355, 12575);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10107_12460_12479(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10107, 12460, 12479);
                    return return_v;
                }


                int
                f_10107_12447_12486(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10107, 12447, 12486);
                    return return_v;
                }


                string
                f_10107_12521_12530(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10107, 12521, 12530);
                    return return_v;
                }


                int
                f_10107_12508_12537(string
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10107, 12508, 12537);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10107, 12355, 12575);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10107, 12355, 12575);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
        f_10107_1926_1945()
        {
            var return_v = TypeWithAnnotations;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10107, 1926, 1945);
            return return_v;
        }


        bool
        f_10107_2745_2754_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10107, 2745, 2754);
            return return_v;
        }

    }
}
