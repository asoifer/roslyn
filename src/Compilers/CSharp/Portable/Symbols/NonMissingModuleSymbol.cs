// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal abstract class NonMissingModuleSymbol : ModuleSymbol
    {
        private ModuleReferences<AssemblySymbol> _moduleReferences;

        internal sealed override bool IsMissing
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10062, 1373, 1437);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10062, 1409, 1422);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10062, 1373, 1437);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10062, 1309, 1448);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10062, 1309, 1448);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override ImmutableArray<AssemblyIdentity> GetReferencedAssemblies()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10062, 1756, 1955);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10062, 1864, 1894);

                f_10062_1864_1893(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10062, 1908, 1944);

                return _moduleReferences.Identities;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10062, 1756, 1955);

                int
                f_10062_1864_1893(Microsoft.CodeAnalysis.CSharp.Symbols.NonMissingModuleSymbol
                this_param)
                {
                    this_param.AssertReferencesInitialized();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10062, 1864, 1893);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10062, 1756, 1955);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10062, 1756, 1955);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override ImmutableArray<AssemblySymbol> GetReferencedAssemblySymbols()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10062, 2435, 2634);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10062, 2546, 2576);

                f_10062_2546_2575(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10062, 2590, 2623);

                return _moduleReferences.Symbols;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10062, 2435, 2634);

                int
                f_10062_2546_2575(Microsoft.CodeAnalysis.CSharp.Symbols.NonMissingModuleSymbol
                this_param)
                {
                    this_param.AssertReferencesInitialized();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10062, 2546, 2575);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10062, 2435, 2634);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10062, 2435, 2634);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ImmutableArray<UnifiedAssembly<AssemblySymbol>> GetUnifiedAssemblies()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10062, 2646, 2848);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10062, 2750, 2780);

                f_10062_2750_2779(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10062, 2794, 2837);

                return _moduleReferences.UnifiedAssemblies;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10062, 2646, 2848);

                int
                f_10062_2750_2779(Microsoft.CodeAnalysis.CSharp.Symbols.NonMissingModuleSymbol
                this_param)
                {
                    this_param.AssertReferencesInitialized();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10062, 2750, 2779);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10062, 2646, 2848);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10062, 2646, 2848);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool HasUnifiedReferences
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10062, 2928, 2977);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10062, 2934, 2975);

                    return f_10062_2941_2963(this).Length > 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10062, 2928, 2977);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.UnifiedAssembly<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>>
                    f_10062_2941_2963(Microsoft.CodeAnalysis.CSharp.Symbols.NonMissingModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.GetUnifiedAssemblies();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10062, 2941, 2963);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10062, 2860, 2988);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10062, 2860, 2988);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool GetUnificationUseSiteDiagnostic(ref DiagnosticInfo result, TypeSymbol dependentType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10062, 3000, 6620);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10062, 3132, 3162);

                f_10062_3132_3161(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10062, 3178, 3201);

                var
                ownerModule = this
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10062, 3215, 3266);

                var
                ownerAssembly = f_10062_3235_3265(ownerModule)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10062, 3280, 3337);

                var
                dependentAssembly = f_10062_3304_3336(dependentType)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10062, 3351, 3451) || true) && (ownerAssembly == dependentAssembly)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10062, 3351, 3451);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10062, 3423, 3436);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10062, 3351, 3451);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10062, 3585, 6580);
                    foreach (var unifiedAssembly in f_10062_3617_3639_I(f_10062_3617_3639(this)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10062, 3585, 6580);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10062, 3673, 3814) || true) && (!f_10062_3678_3744(unifiedAssembly.TargetAssembly, dependentAssembly))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10062, 3673, 3814);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10062, 3786, 3795);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10062, 3673, 3814);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10062, 3834, 3886);

                        var
                        referenceId = unifiedAssembly.OriginalReference
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10062, 3904, 3950);

                        var
                        definitionId = f_10062_3923_3949(dependentAssembly)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10062, 3968, 4057);

                        var
                        involvedAssemblies = f_10062_3993_4056(ownerAssembly, dependentAssembly)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10062, 4077, 4097);

                        DiagnosticInfo
                        info
                        = default(DiagnosticInfo);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10062, 4115, 6427) || true) && (f_10062_4119_4139(definitionId) > f_10062_4142_4161(referenceId))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10062, 4115, 6427);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10062, 4316, 4568);

                            ErrorCode
                            warning = (DynAbs.Tracing.TraceSender.Conditional_F1(10062, 4336, 4452) || (((f_10062_4337_4363(f_10062_4337_4357(definitionId)) == f_10062_4367_4392(f_10062_4367_4386(referenceId)) && (DynAbs.Tracing.TraceSender.Expression_True(10062, 4337, 4451) && f_10062_4396_4422(f_10062_4396_4416(definitionId)) == f_10062_4426_4451(f_10062_4426_4445(referenceId)))) && DynAbs.Tracing.TraceSender.Conditional_F2(10062, 4496, 4530)) || DynAbs.Tracing.TraceSender.Conditional_F3(10062, 4533, 4567))) ? ErrorCode.WRN_UnifyReferenceBldRev : ErrorCode.WRN_UnifyReferenceMajMin
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10062, 4745, 5315);

                            info = f_10062_4752_5314(warning, new object[]
                                                    {
f_10062_4902_4930(                            referenceId),
f_10062_4961_4979(ownerAssembly), // TODO (tomat): should rather be MetadataReference.Display for the corresponding reference
f_10062_5102_5131(                            definitionId),
f_10062_5162_5184(dependentAssembly)                        }, involvedAssemblies, ImmutableArray<Location>.Empty);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10062, 4115, 6427);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10062, 4115, 6427);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10062, 5646, 6408);

                            info = f_10062_5653_6407(ErrorCode.ERR_AssemblyMatchBadVersion, new object[]
                                                    {
f_10062_5833_5851(ownerAssembly), // TODO (tomat): should rather be MetadataReference.Display for the corresponding reference
f_10062_5974_6013(f_10062_5974_5996(ownerAssembly)),
f_10062_6044_6072(                            referenceId),
f_10062_6103_6125(dependentAssembly), // TODO (tomat): should rather be MetadataReference.Display for the corresponding reference
f_10062_6248_6277(                            definitionId)                        }, involvedAssemblies, ImmutableArray<Location>.Empty);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10062, 4115, 6427);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10062, 6447, 6565) || true) && (f_10062_6451_6492(this, ref result, info))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10062, 6447, 6565);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10062, 6534, 6546);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10062, 6447, 6565);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10062, 3585, 6580);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10062, 1, 2996);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10062, 1, 2996);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10062, 6596, 6609);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10062, 3000, 6620);

                int
                f_10062_3132_3161(Microsoft.CodeAnalysis.CSharp.Symbols.NonMissingModuleSymbol
                this_param)
                {
                    this_param.AssertReferencesInitialized();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10062, 3132, 3161);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10062_3235_3265(Microsoft.CodeAnalysis.CSharp.Symbols.NonMissingModuleSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10062, 3235, 3265);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10062_3304_3336(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10062, 3304, 3336);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.UnifiedAssembly<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>>
                f_10062_3617_3639(Microsoft.CodeAnalysis.CSharp.Symbols.NonMissingModuleSymbol
                this_param)
                {
                    var return_v = this_param.GetUnifiedAssemblies();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10062, 3617, 3639);
                    return return_v;
                }


                bool
                f_10062_3678_3744(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10062, 3678, 3744);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_10062_3923_3949(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.Identity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10062, 3923, 3949);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10062_3993_4056(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                item1, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                item2)
                {
                    var return_v = ImmutableArray.Create<Symbol>((Microsoft.CodeAnalysis.CSharp.Symbol)item1, (Microsoft.CodeAnalysis.CSharp.Symbol)item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10062, 3993, 4056);
                    return return_v;
                }


                System.Version
                f_10062_4119_4139(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10062, 4119, 4139);
                    return return_v;
                }


                System.Version
                f_10062_4142_4161(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10062, 4142, 4161);
                    return return_v;
                }


                System.Version
                f_10062_4337_4357(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10062, 4337, 4357);
                    return return_v;
                }


                int
                f_10062_4337_4363(System.Version
                this_param)
                {
                    var return_v = this_param.Major;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10062, 4337, 4363);
                    return return_v;
                }


                System.Version
                f_10062_4367_4386(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10062, 4367, 4386);
                    return return_v;
                }


                int
                f_10062_4367_4392(System.Version
                this_param)
                {
                    var return_v = this_param.Major;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10062, 4367, 4392);
                    return return_v;
                }


                System.Version
                f_10062_4396_4416(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10062, 4396, 4416);
                    return return_v;
                }


                int
                f_10062_4396_4422(System.Version
                this_param)
                {
                    var return_v = this_param.Minor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10062, 4396, 4422);
                    return return_v;
                }


                System.Version
                f_10062_4426_4445(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10062, 4426, 4445);
                    return return_v;
                }


                int
                f_10062_4426_4451(System.Version
                this_param)
                {
                    var return_v = this_param.Minor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10062, 4426, 4451);
                    return return_v;
                }


                string
                f_10062_4902_4930(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.GetDisplayName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10062, 4902, 4930);
                    return return_v;
                }


                string
                f_10062_4961_4979(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10062, 4961, 4979);
                    return return_v;
                }


                string
                f_10062_5102_5131(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.GetDisplayName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10062, 5102, 5131);
                    return return_v;
                }


                string
                f_10062_5162_5184(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.Name
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10062, 5162, 5184);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10062_4752_5314(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, object[]
                args, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                additionalLocations)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args, symbols, additionalLocations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10062, 4752, 5314);
                    return return_v;
                }


                string
                f_10062_5833_5851(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10062, 5833, 5851);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_10062_5974_5996(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.Identity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10062, 5974, 5996);
                    return return_v;
                }


                string
                f_10062_5974_6013(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.GetDisplayName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10062, 5974, 6013);
                    return return_v;
                }


                string
                f_10062_6044_6072(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.GetDisplayName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10062, 6044, 6072);
                    return return_v;
                }


                string
                f_10062_6103_6125(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10062, 6103, 6125);
                    return return_v;
                }


                string
                f_10062_6248_6277(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.GetDisplayName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10062, 6248, 6277);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10062_5653_6407(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, object[]
                args, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                additionalLocations)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args, symbols, additionalLocations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10062, 5653, 6407);
                    return return_v;
                }


                bool
                f_10062_6451_6492(Microsoft.CodeAnalysis.CSharp.Symbols.NonMissingModuleSymbol
                this_param, ref Microsoft.CodeAnalysis.DiagnosticInfo
                result, Microsoft.CodeAnalysis.DiagnosticInfo
                info)
                {
                    var return_v = this_param.MergeUseSiteDiagnostics(ref result, info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10062, 6451, 6492);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.UnifiedAssembly<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>>
                f_10062_3617_3639_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.UnifiedAssembly<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10062, 3617, 3639);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10062, 3000, 6620);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10062, 3000, 6620);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void SetReferences(ModuleReferences<AssemblySymbol> moduleReferences, SourceAssemblySymbol originatingSourceAssemblyDebugOnly = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10062, 6846, 7173);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10062, 7022, 7061);

                f_10062_7022_7060(moduleReferences != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10062, 7077, 7109);

                f_10062_7077_7108(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10062, 7125, 7162);

                _moduleReferences = moduleReferences;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10062, 6846, 7173);

                int
                f_10062_7022_7060(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10062, 7022, 7060);
                    return 0;
                }


                int
                f_10062_7077_7108(Microsoft.CodeAnalysis.CSharp.Symbols.NonMissingModuleSymbol
                this_param)
                {
                    this_param.AssertReferencesUninitialized();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10062, 7077, 7108);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10062, 6846, 7173);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10062, 6846, 7173);
            }
        }

        [Conditional("DEBUG")]
        internal void AssertReferencesUninitialized()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10062, 7185, 7338);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10062, 7287, 7327);

                f_10062_7287_7326(_moduleReferences == null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10062, 7185, 7338);

                int
                f_10062_7287_7326(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10062, 7287, 7326);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10062, 7185, 7338);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10062, 7185, 7338);
            }
        }

        [Conditional("DEBUG")]
        internal void AssertReferencesInitialized()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10062, 7350, 7501);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10062, 7450, 7490);

                f_10062_7450_7489(_moduleReferences != null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10062, 7350, 7501);

                int
                f_10062_7450_7489(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10062, 7450, 7489);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10062, 7350, 7501);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10062, 7350, 7501);
            }
        }

        internal sealed override NamedTypeSymbol LookupTopLevelMetadataType(ref MetadataTypeName emittedName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10062, 7971, 8656);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10062, 8097, 8120);

                NamedTypeSymbol
                result
                = default(NamedTypeSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10062, 8134, 8232);

                NamespaceSymbol
                scope = f_10062_8158_8231(f_10062_8158_8178(this), emittedName.NamespaceSegments)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10062, 8248, 8564) || true) && ((object)scope == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10062, 8248, 8564);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10062, 8361, 8432);

                    result = f_10062_8370_8431(this, ref emittedName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10062, 8248, 8564);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10062, 8248, 8564);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10062, 8498, 8549);

                    result = f_10062_8507_8548(scope, ref emittedName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10062, 8248, 8564);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10062, 8580, 8617);

                f_10062_8580_8616((object)result != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10062, 8631, 8645);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10062, 7971, 8656);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10062_8158_8178(Microsoft.CodeAnalysis.CSharp.Symbols.NonMissingModuleSymbol
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10062, 8158, 8178);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10062_8158_8231(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, System.Collections.Immutable.ImmutableArray<string>
                names)
                {
                    var return_v = this_param.LookupNestedNamespace(names);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10062, 8158, 8231);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MissingMetadataTypeSymbol.TopLevel
                f_10062_8370_8431(Microsoft.CodeAnalysis.CSharp.Symbols.NonMissingModuleSymbol
                module, ref Microsoft.CodeAnalysis.MetadataTypeName
                fullName)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.MissingMetadataTypeSymbol.TopLevel((Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol)module, ref fullName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10062, 8370, 8431);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10062_8507_8548(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, ref Microsoft.CodeAnalysis.MetadataTypeName
                emittedTypeName)
                {
                    var return_v = this_param.LookupMetadataType(ref emittedTypeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10062, 8507, 8548);
                    return return_v;
                }


                int
                f_10062_8580_8616(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10062, 8580, 8616);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10062, 7971, 8656);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10062, 7971, 8656);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public NonMissingModuleSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(10062, 751, 8663);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10062, 1174, 1191);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(10062, 751, 8663);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10062, 751, 8663);
        }


        static NonMissingModuleSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10062, 751, 8663);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10062, 751, 8663);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10062, 751, 8663);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10062, 751, 8663);
    }
}
