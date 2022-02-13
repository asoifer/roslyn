// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal abstract class MissingMetadataTypeSymbol : ErrorTypeSymbol
    {
        protected readonly string name;

        protected readonly int arity;

        protected readonly bool mangleName;

        private MissingMetadataTypeSymbol(string name, int arity, bool mangleName, TupleExtraData? tupleData = null)
        : base(f_10123_1287_1296_C(tupleData))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10123, 1158, 1490);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 1057, 1061);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 1095, 1100);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 1135, 1145);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 1322, 1355);

                f_10123_1322_1354(name != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 1371, 1388);

                this.name = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 1402, 1421);

                this.arity = arity;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 1435, 1479);

                this.mangleName = (mangleName && (DynAbs.Tracing.TraceSender.Expression_True(10123, 1454, 1477) && arity > 0));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10123, 1158, 1490);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10123, 1158, 1490);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10123, 1158, 1490);
            }
        }

        public override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10123, 1554, 1574);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 1560, 1572);

                    return name;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10123, 1554, 1574);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10123, 1502, 1585);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10123, 1502, 1585);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool MangleName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10123, 1655, 1724);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 1691, 1709);

                    return mangleName;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10123, 1655, 1724);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10123, 1597, 1735);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10123, 1597, 1735);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Arity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10123, 1890, 1911);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 1896, 1909);

                    return arity;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10123, 1890, 1911);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10123, 1840, 1922);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10123, 1840, 1922);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override DiagnosticInfo ErrorInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10123, 2001, 5636);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 2037, 2097);

                    AssemblySymbol
                    containingAssembly = f_10123_2073_2096(this)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 2662, 5621) || true) && (f_10123_2666_2694(containingAssembly))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10123, 2662, 5621);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 2884, 2972);

                        return f_10123_2891_2971(ErrorCode.ERR_NoTypeDef, this, f_10123_2943_2970(containingAssembly));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10123, 2662, 5621);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10123, 2662, 5621);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 3054, 3108);

                        ModuleSymbol
                        containingModule = f_10123_3086_3107(this)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 3132, 3418) || true) && (f_10123_3136_3162(containingModule))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10123, 3132, 3418);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 3303, 3395);

                            return f_10123_3310_3394(ErrorCode.ERR_NoTypeDefFromModule, this, f_10123_3372_3393(containingModule));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10123, 3132, 3418);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 4144, 5602) || true) && (f_10123_4148_4198(containingAssembly))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10123, 4144, 5602);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 4927, 4996);

                            return f_10123_4934_4995(ErrorCode.ERR_MissingTypeInSource, this);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10123, 4144, 5602);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10123, 4144, 5602);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 5483, 5579);

                            return f_10123_5490_5578(ErrorCode.ERR_MissingTypeInAssembly, this, f_10123_5554_5577(containingAssembly));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10123, 4144, 5602);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10123, 2662, 5621);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10123, 2001, 5636);

                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10123_2073_2096(Microsoft.CodeAnalysis.CSharp.Symbols.MissingMetadataTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10123, 2073, 2096);
                        return return_v;
                    }


                    bool
                    f_10123_2666_2694(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.IsMissing;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10123, 2666, 2694);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.AssemblyIdentity
                    f_10123_2943_2970(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.Identity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10123, 2943, 2970);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                    f_10123_2891_2971(Microsoft.CodeAnalysis.CSharp.ErrorCode
                    code, params object[]
                    args)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10123, 2891, 2971);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    f_10123_3086_3107(Microsoft.CodeAnalysis.CSharp.Symbols.MissingMetadataTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10123, 3086, 3107);
                        return return_v;
                    }


                    bool
                    f_10123_3136_3162(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.IsMissing;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10123, 3136, 3162);
                        return return_v;
                    }


                    string
                    f_10123_3372_3393(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10123, 3372, 3393);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                    f_10123_3310_3394(Microsoft.CodeAnalysis.CSharp.ErrorCode
                    code, params object[]
                    args)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10123, 3310, 3394);
                        return return_v;
                    }


                    bool
                    f_10123_4148_4198(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.Dangerous_IsFromSomeCompilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10123, 4148, 4198);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                    f_10123_4934_4995(Microsoft.CodeAnalysis.CSharp.ErrorCode
                    code, params object[]
                    args)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10123, 4934, 4995);
                        return return_v;
                    }


                    string
                    f_10123_5554_5577(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10123, 5554, 5577);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                    f_10123_5490_5578(Microsoft.CodeAnalysis.CSharp.ErrorCode
                    code, params object[]
                    args)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10123, 5490, 5578);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10123, 1934, 5647);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10123, 1934, 5647);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }
        internal sealed class TopLevel : MissingMetadataTypeSymbol
        {
            private readonly string _namespaceName;

            private readonly ModuleSymbol _containingModule;

            private readonly bool _isNativeInt;

            private DiagnosticInfo? _lazyErrorInfo;

            private NamespaceSymbol? _lazyContainingNamespace;

            private int _lazyTypeId;

            public TopLevel(ModuleSymbol module, string @namespace, string name, int arity, bool mangleName)
            : this(f_10123_6443_6449_C(module), @namespace, name, arity, mangleName, errorInfo: null, isNativeInt: false, containingNamespace: null, typeId: -1, tupleData: null)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10123, 6322, 6610);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10123, 6322, 6610);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10123, 6322, 6610);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10123, 6322, 6610);
                }
            }

            public TopLevel(ModuleSymbol module, ref MetadataTypeName fullName, DiagnosticInfo? errorInfo = null)
            : this(f_10123_6752_6758_C(module), ref fullName, -1, errorInfo)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10123, 6626, 6818);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10123, 6626, 6818);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10123, 6626, 6818);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10123, 6626, 6818);
                }
            }

            public TopLevel(ModuleSymbol module, ref MetadataTypeName fullName, SpecialType specialType, DiagnosticInfo? errorInfo = null)
            : this(f_10123_6985_6991_C(module), ref fullName, (int)specialType, errorInfo)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10123, 6834, 7065);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10123, 6834, 7065);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10123, 6834, 7065);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10123, 6834, 7065);
                }
            }

            public TopLevel(ModuleSymbol module, ref MetadataTypeName fullName, WellKnownType wellKnownType, DiagnosticInfo? errorInfo = null)
            : this(f_10123_7236_7242_C(module), ref fullName, (int)wellKnownType, errorInfo)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10123, 7081, 7318);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10123, 7081, 7318);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10123, 7081, 7318);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10123, 7081, 7318);
                }
            }

            private TopLevel(ModuleSymbol module, ref MetadataTypeName fullName, int typeId, DiagnosticInfo? errorInfo)
            : this(f_10123_7466_7472_C(module), ref fullName, fullName.ForcedArity == -1 || (DynAbs.Tracing.TraceSender.Expression_False(10123, 7488, 7564) || fullName.ForcedArity == fullName.InferredArity), errorInfo, typeId)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10123, 7334, 7614);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10123, 7334, 7614);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10123, 7334, 7614);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10123, 7334, 7614);
                }
            }

            private TopLevel(ModuleSymbol module, ref MetadataTypeName fullName, bool mangleName, DiagnosticInfo? errorInfo, int typeId)
            : this(f_10123_7779_7785_C(module), fullName.NamespaceName, (DynAbs.Tracing.TraceSender.Conditional_F1(10123, 7835, 7845) || ((mangleName && DynAbs.Tracing.TraceSender.Conditional_F2(10123, 7848, 7874)) || DynAbs.Tracing.TraceSender.Conditional_F3(10123, 7877, 7894))) ? fullName.UnmangledTypeName : fullName.TypeName, (DynAbs.Tracing.TraceSender.Conditional_F1(10123, 7920, 7930) || ((mangleName && DynAbs.Tracing.TraceSender.Conditional_F2(10123, 7933, 7955)) || DynAbs.Tracing.TraceSender.Conditional_F3(10123, 7958, 7978))) ? fullName.InferredArity : fullName.ForcedArity, mangleName, isNativeInt: false, errorInfo, containingNamespace: null, typeId, tupleData: null)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10123, 7630, 8248);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10123, 7630, 8248);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10123, 7630, 8248);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10123, 7630, 8248);
                }
            }

            private TopLevel(ModuleSymbol module, string @namespace, string name, int arity, bool mangleName, bool isNativeInt, DiagnosticInfo? errorInfo, NamespaceSymbol? containingNamespace, int typeId, TupleExtraData? tupleData)
            : base(f_10123_8508_8512_C(name), arity, mangleName, tupleData)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10123, 8264, 9092);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 5862, 5876);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 5921, 5938);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 5975, 5987);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 6026, 6040);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 6080, 6104);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 6294, 6305);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 8576, 8619);

                    f_10123_8576_8618((object)module != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 8637, 8676);

                    f_10123_8637_8675(@namespace != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 8694, 8790);

                    f_10123_8694_8789(typeId == -1 || (DynAbs.Tracing.TraceSender.Expression_False(10123, 8713, 8760) || typeId == (int)SpecialType.None) || (DynAbs.Tracing.TraceSender.Expression_False(10123, 8713, 8774) || arity == 0) || (DynAbs.Tracing.TraceSender.Expression_False(10123, 8713, 8788) || mangleName));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 8810, 8838);

                    _namespaceName = @namespace;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 8856, 8883);

                    _containingModule = module;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 8901, 8928);

                    _isNativeInt = isNativeInt;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 8946, 8973);

                    _lazyErrorInfo = errorInfo;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 8991, 9038);

                    _lazyContainingNamespace = containingNamespace;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 9056, 9077);

                    _lazyTypeId = typeId;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10123, 8264, 9092);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10123, 8264, 9092);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10123, 8264, 9092);
                }
            }

            protected override NamedTypeSymbol WithTupleDataCore(TupleExtraData newData)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10123, 9108, 9390);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 9217, 9375);

                    return f_10123_9224_9374(_containingModule, _namespaceName, name, arity, mangleName, _isNativeInt, _lazyErrorInfo, _lazyContainingNamespace, _lazyTypeId, newData);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10123, 9108, 9390);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MissingMetadataTypeSymbol.TopLevel
                    f_10123_9224_9374(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    module, string
                    @namespace, string
                    name, int
                    arity, bool
                    mangleName, bool
                    isNativeInt, Microsoft.CodeAnalysis.DiagnosticInfo?
                    errorInfo, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol?
                    containingNamespace, int
                    typeId, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol.TupleExtraData
                    tupleData)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.MissingMetadataTypeSymbol.TopLevel(module, @namespace, name, arity, mangleName, isNativeInt, errorInfo, containingNamespace, typeId, tupleData);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10123, 9224, 9374);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10123, 9108, 9390);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10123, 9108, 9390);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public string NamespaceName
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10123, 9660, 9690);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 9666, 9688);

                        return _namespaceName;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10123, 9660, 9690);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10123, 9600, 9705);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10123, 9600, 9705);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override ModuleSymbol ContainingModule
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10123, 9801, 9889);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 9845, 9870);

                        return _containingModule;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10123, 9801, 9889);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10123, 9721, 9904);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10123, 9721, 9904);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override AssemblySymbol ContainingAssembly
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10123, 10002, 10109);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 10046, 10090);

                        return f_10123_10053_10089(_containingModule);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10123, 10002, 10109);

                        Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                        f_10123_10053_10089(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                        this_param)
                        {
                            var return_v = this_param.ContainingAssembly;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10123, 10053, 10089);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10123, 9920, 10124);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10123, 9920, 10124);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override Symbol ContainingSymbol
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10123, 10212, 12110);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 10256, 12035) || true) && ((object?)_lazyContainingNamespace == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10123, 10256, 12035);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 10351, 10413);

                            NamespaceSymbol
                            container = f_10123_10379_10412(_containingModule)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 10441, 11909) || true) && (f_10123_10445_10466(_namespaceName) > 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10123, 10441, 11909);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 10528, 10596);

                                var
                                namespaces = f_10123_10545_10595(_namespaceName)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 10626, 10632);

                                int
                                i
                                = default(int);
                                try
                                {
                                    for (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 10669, 10674)
        , i = 0; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 10664, 11586) || true) && (i < namespaces.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 10699, 10702)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10123, 10664, 11586))

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10123, 10664, 11586);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 10768, 10805);

                                        NamespaceSymbol?
                                        newContainer = null
                                        ;
                                        try
                                        {
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 10841, 11310);
                                            foreach (NamespaceOrTypeSymbol symbol in f_10123_10882_10917_I(f_10123_10882_10917(container, namespaces[i])))
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10123, 10841, 11310);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 10991, 11275) || true) && (f_10123_10995_11006(symbol) == SymbolKind.Namespace)
                                                ) // VB should also check name casing.

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10123, 10991, 11275);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 11149, 11188);

                                                    newContainer = (NamespaceSymbol)symbol;
                                                    DynAbs.Tracing.TraceSender.TraceBreak(10123, 11230, 11236);

                                                    break;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10123, 10991, 11275);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10123, 10841, 11310);
                                            }
                                        }
                                        catch (System.Exception)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10123, 1, 470);
                                            throw;
                                        }
                                        finally
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoop(10123, 1, 470);
                                        }
                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 11346, 11494) || true) && ((object?)newContainer == null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10123, 11346, 11494);
                                            DynAbs.Tracing.TraceSender.TraceBreak(10123, 11453, 11459);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10123, 11346, 11494);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 11530, 11555);

                                        container = newContainer;
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10123, 1, 923);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(10123, 1, 923);
                                }
                                try
                                {
                                    // now create symbols we couldn't find.
                                    for (; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 11687, 11882) || true) && (i < namespaces.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 11717, 11720)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10123, 11687, 11882))

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10123, 11687, 11882);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 11786, 11851);

                                        container = f_10123_11798_11850(container, namespaces[i]);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10123, 1, 196);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(10123, 1, 196);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10123, 10441, 11909);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 11937, 12012);

                            f_10123_11937_12011(ref _lazyContainingNamespace, container, null);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10123, 10256, 12035);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 12059, 12091);

                        return _lazyContainingNamespace;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10123, 10212, 12110);

                        Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                        f_10123_10379_10412(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                        this_param)
                        {
                            var return_v = this_param.GlobalNamespace;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10123, 10379, 10412);
                            return return_v;
                        }


                        int
                        f_10123_10445_10466(string
                        this_param)
                        {
                            var return_v = this_param.Length;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10123, 10445, 10466);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<string>
                        f_10123_10545_10595(string
                        name)
                        {
                            var return_v = MetadataHelpers.SplitQualifiedName(name);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10123, 10545, 10595);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                        f_10123_10882_10917(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                        this_param, string
                        name)
                        {
                            var return_v = this_param.GetMembers(name);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10123, 10882, 10917);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SymbolKind
                        f_10123_10995_11006(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10123, 10995, 11006);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                        f_10123_10882_10917_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10123, 10882, 10917);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.MissingNamespaceSymbol
                        f_10123_11798_11850(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                        containingNamespace, string
                        name)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.MissingNamespaceSymbol(containingNamespace, name);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10123, 11798, 11850);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol?
                        f_10123_11937_12011(ref Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol?
                        location1, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                        value, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol?
                        comparand)
                        {
                            var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10123, 11937, 12011);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10123, 10140, 12125);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10123, 10140, 12125);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private int TypeId
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10123, 12192, 13129);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 12236, 13067) || true) && (_lazyTypeId == -1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10123, 12236, 13067);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 12307, 12345);

                            SpecialType
                            typeId = SpecialType.None
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 12373, 12446);

                            AssemblySymbol
                            containingAssembly = f_10123_12409_12445(_containingModule)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 12474, 12954) || true) && ((f_10123_12479_12484() == 0 || (DynAbs.Tracing.TraceSender.Expression_False(10123, 12479, 12503) || f_10123_12493_12503())) && (DynAbs.Tracing.TraceSender.Expression_True(10123, 12478, 12542) && (object)containingAssembly != null) && (DynAbs.Tracing.TraceSender.Expression_True(10123, 12478, 12612) && f_10123_12546_12612(containingAssembly, f_10123_12582_12611(containingAssembly))) && (DynAbs.Tracing.TraceSender.Expression_True(10123, 12478, 12646) && f_10123_12616_12641(_containingModule) == 0))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10123, 12474, 12954);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 12752, 12838);

                                string
                                emittedName = f_10123_12773_12837(_namespaceName, f_10123_12824_12836())
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 12868, 12927);

                                typeId = f_10123_12877_12926(emittedName);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10123, 12474, 12954);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 12982, 13044);

                            f_10123_12982_13043(ref _lazyTypeId, typeId, -1);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10123, 12236, 13067);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 13091, 13110);

                        return _lazyTypeId;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10123, 12192, 13129);

                        Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                        f_10123_12409_12445(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                        this_param)
                        {
                            var return_v = this_param.ContainingAssembly;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10123, 12409, 12445);
                            return return_v;
                        }


                        int
                        f_10123_12479_12484()
                        {
                            var return_v = Arity;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10123, 12479, 12484);
                            return return_v;
                        }


                        bool
                        f_10123_12493_12503()
                        {
                            var return_v = MangleName;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10123, 12493, 12503);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                        f_10123_12582_12611(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                        this_param)
                        {
                            var return_v = this_param.CorLibrary;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10123, 12582, 12611);
                            return return_v;
                        }


                        bool
                        f_10123_12546_12612(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                        objA, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                        objB)
                        {
                            var return_v = ReferenceEquals((object)objA, (object)objB);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10123, 12546, 12612);
                            return return_v;
                        }


                        int
                        f_10123_12616_12641(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                        this_param)
                        {
                            var return_v = this_param.Ordinal;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10123, 12616, 12641);
                            return return_v;
                        }


                        string
                        f_10123_12824_12836()
                        {
                            var return_v = MetadataName;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10123, 12824, 12836);
                            return return_v;
                        }


                        string
                        f_10123_12773_12837(string
                        qualifier, string
                        name)
                        {
                            var return_v = MetadataHelpers.BuildQualifiedName(qualifier, name);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10123, 12773, 12837);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SpecialType
                        f_10123_12877_12926(string
                        metadataName)
                        {
                            var return_v = SpecialTypes.GetTypeFromMetadataName(metadataName);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10123, 12877, 12926);
                            return return_v;
                        }


                        int
                        f_10123_12982_13043(ref int
                        location1, Microsoft.CodeAnalysis.SpecialType
                        value, int
                        comparand)
                        {
                            var return_v = Interlocked.CompareExchange(ref location1, (int)value, comparand);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10123, 12982, 13043);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10123, 12141, 13144);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10123, 12141, 13144);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override SpecialType SpecialType
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10123, 13232, 13427);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 13276, 13296);

                        int
                        typeId = f_10123_13289_13295()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 13318, 13408);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(10123, 13325, 13361) || (((typeId >= (int)WellKnownType.First) && DynAbs.Tracing.TraceSender.Conditional_F2(10123, 13364, 13380)) || DynAbs.Tracing.TraceSender.Conditional_F3(10123, 13383, 13407))) ? SpecialType.None : (SpecialType)_lazyTypeId;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10123, 13232, 13427);

                        int
                        f_10123_13289_13295()
                        {
                            var return_v = TypeId;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10123, 13289, 13295);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10123, 13160, 13442);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10123, 13160, 13442);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override DiagnosticInfo ErrorInfo
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10123, 13533, 14085);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 13577, 14022) || true) && (_lazyErrorInfo == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10123, 13577, 14022);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 13653, 13908);

                            var
                            errorInfo = (DynAbs.Tracing.TraceSender.Conditional_F1(10123, 13669, 13705) || ((f_10123_13669_13680(this) != (int)SpecialType.None && DynAbs.Tracing.TraceSender.Conditional_F2(10123, 13737, 13861)) || DynAbs.Tracing.TraceSender.Conditional_F3(10123, 13893, 13907))) ? f_10123_13737_13861(ErrorCode.ERR_PredefinedTypeNotFound, f_10123_13796_13860(_namespaceName, f_10123_13847_13859())) : DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.ErrorInfo, 10123, 13893, 13907)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 13934, 13999);

                            f_10123_13934_13998(ref _lazyErrorInfo, errorInfo, null);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10123, 13577, 14022);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 14044, 14066);

                        return _lazyErrorInfo;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10123, 13533, 14085);

                        int
                        f_10123_13669_13680(Microsoft.CodeAnalysis.CSharp.Symbols.MissingMetadataTypeSymbol.TopLevel
                        this_param)
                        {
                            var return_v = this_param.TypeId;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10123, 13669, 13680);
                            return return_v;
                        }


                        string
                        f_10123_13847_13859()
                        {
                            var return_v = MetadataName;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10123, 13847, 13859);
                            return return_v;
                        }


                        string
                        f_10123_13796_13860(string
                        qualifier, string
                        name)
                        {
                            var return_v = MetadataHelpers.BuildQualifiedName(qualifier, name);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10123, 13796, 13860);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                        f_10123_13737_13861(Microsoft.CodeAnalysis.CSharp.ErrorCode
                        code, params object[]
                        args)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10123, 13737, 13861);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.DiagnosticInfo?
                        f_10123_13934_13998(ref Microsoft.CodeAnalysis.DiagnosticInfo?
                        location1, Microsoft.CodeAnalysis.DiagnosticInfo
                        value, Microsoft.CodeAnalysis.DiagnosticInfo?
                        comparand)
                        {
                            var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10123, 13934, 13998);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10123, 13458, 14100);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10123, 13458, 14100);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override int GetHashCode()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10123, 14116, 14602);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 14269, 14463) || true) && (f_10123_14273_14289(this) == Microsoft.CodeAnalysis.SpecialType.System_Object)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10123, 14269, 14463);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 14383, 14444);

                        return (int)Microsoft.CodeAnalysis.SpecialType.System_Object;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10123, 14269, 14463);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 14483, 14587);

                    return f_10123_14490_14586(f_10123_14503_14515(), f_10123_14517_14585(_containingModule, f_10123_14549_14584(_namespaceName, arity)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10123, 14116, 14602);

                    Microsoft.CodeAnalysis.SpecialType
                    f_10123_14273_14289(Microsoft.CodeAnalysis.CSharp.Symbols.MissingMetadataTypeSymbol.TopLevel
                    this_param)
                    {
                        var return_v = this_param.SpecialType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10123, 14273, 14289);
                        return return_v;
                    }


                    string
                    f_10123_14503_14515()
                    {
                        var return_v = MetadataName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10123, 14503, 14515);
                        return return_v;
                    }


                    int
                    f_10123_14549_14584(string
                    newKeyPart, int
                    currentKey)
                    {
                        var return_v = Hash.Combine(newKeyPart, currentKey);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10123, 14549, 14584);
                        return return_v;
                    }


                    int
                    f_10123_14517_14585(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    newKeyPart, int
                    currentKey)
                    {
                        var return_v = Hash.Combine(newKeyPart, currentKey);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10123, 14517, 14585);
                        return return_v;
                    }


                    int
                    f_10123_14490_14586(string
                    newKeyPart, int
                    currentKey)
                    {
                        var return_v = Hash.Combine(newKeyPart, currentKey);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10123, 14490, 14586);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10123, 14116, 14602);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10123, 14116, 14602);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal sealed override NamedTypeSymbol AsNativeInteger()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10123, 14677, 14714);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 14680, 14714);
                    return f_10123_14680_14714(this, asNativeInt: true); DynAbs.Tracing.TraceSender.TraceExitMethod(10123, 14677, 14714);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10123, 14677, 14714);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10123, 14677, 14714);
                }
                throw new System.Exception("Slicer error: unreachable code");

                Microsoft.CodeAnalysis.CSharp.Symbols.MissingMetadataTypeSymbol.TopLevel
                f_10123_14680_14714(Microsoft.CodeAnalysis.CSharp.Symbols.MissingMetadataTypeSymbol.TopLevel
                this_param, bool
                asNativeInt)
                {
                    var return_v = this_param.AsNativeInteger(asNativeInt: asNativeInt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10123, 14680, 14714);
                    return return_v;
                }

            }

            private TopLevel AsNativeInteger(bool asNativeInt)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10123, 14731, 15435);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 14814, 14924);

                    f_10123_14814_14923(f_10123_14827_14843(this) == SpecialType.System_IntPtr || (DynAbs.Tracing.TraceSender.Expression_False(10123, 14827, 14922) || f_10123_14876_14892(this) == SpecialType.System_UIntPtr));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 14944, 15048) || true) && (asNativeInt == _isNativeInt)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10123, 14944, 15048);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 15017, 15029);

                        return this;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10123, 14944, 15048);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 15068, 15245);

                    var
                    other = f_10123_15080_15244(_containingModule, _namespaceName, name, arity, mangleName, isNativeInt: asNativeInt, _lazyErrorInfo, _lazyContainingNamespace, _lazyTypeId, f_10123_15234_15243())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 15265, 15317);

                    f_10123_15265_15316(this, other);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 15335, 15387);

                    f_10123_15335_15386(f_10123_15348_15365(other) == f_10123_15369_15385(this));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 15407, 15420);

                    return other;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10123, 14731, 15435);

                    Microsoft.CodeAnalysis.SpecialType
                    f_10123_14827_14843(Microsoft.CodeAnalysis.CSharp.Symbols.MissingMetadataTypeSymbol.TopLevel
                    this_param)
                    {
                        var return_v = this_param.SpecialType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10123, 14827, 14843);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SpecialType
                    f_10123_14876_14892(Microsoft.CodeAnalysis.CSharp.Symbols.MissingMetadataTypeSymbol.TopLevel
                    this_param)
                    {
                        var return_v = this_param.SpecialType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10123, 14876, 14892);
                        return return_v;
                    }


                    int
                    f_10123_14814_14923(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10123, 14814, 14923);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol.TupleExtraData?
                    f_10123_15234_15243()
                    {
                        var return_v = TupleData;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10123, 15234, 15243);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MissingMetadataTypeSymbol.TopLevel
                    f_10123_15080_15244(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    module, string
                    @namespace, string
                    name, int
                    arity, bool
                    mangleName, bool
                    isNativeInt, Microsoft.CodeAnalysis.DiagnosticInfo?
                    errorInfo, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol?
                    containingNamespace, int
                    typeId, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol.TupleExtraData?
                    tupleData)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.MissingMetadataTypeSymbol.TopLevel(module, @namespace, name, arity, mangleName, isNativeInt: isNativeInt, errorInfo, containingNamespace, typeId, tupleData);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10123, 15080, 15244);
                        return return_v;
                    }


                    int
                    f_10123_15265_15316(Microsoft.CodeAnalysis.CSharp.Symbols.MissingMetadataTypeSymbol.TopLevel
                    symbolA, Microsoft.CodeAnalysis.CSharp.Symbols.MissingMetadataTypeSymbol.TopLevel
                    symbolB)
                    {
                        NativeIntegerTypeSymbol.VerifyEquality((Microsoft.CodeAnalysis.CSharp.Symbol)symbolA, (Microsoft.CodeAnalysis.CSharp.Symbol)symbolB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10123, 15265, 15316);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.SpecialType
                    f_10123_15348_15365(Microsoft.CodeAnalysis.CSharp.Symbols.MissingMetadataTypeSymbol.TopLevel
                    this_param)
                    {
                        var return_v = this_param.SpecialType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10123, 15348, 15365);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SpecialType
                    f_10123_15369_15385(Microsoft.CodeAnalysis.CSharp.Symbols.MissingMetadataTypeSymbol.TopLevel
                    this_param)
                    {
                        var return_v = this_param.SpecialType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10123, 15369, 15385);
                        return return_v;
                    }


                    int
                    f_10123_15335_15386(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10123, 15335, 15386);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10123, 14731, 15435);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10123, 14731, 15435);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal sealed override bool IsNativeIntegerType
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10123, 15501, 15516);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 15504, 15516);
                        return _isNativeInt; DynAbs.Tracing.TraceSender.TraceExitMethod(10123, 15501, 15516);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10123, 15501, 15516);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10123, 15501, 15516);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal sealed override NamedTypeSymbol? NativeIntegerUnderlyingType
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10123, 15603, 15663);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 15606, 15663);
                        return (DynAbs.Tracing.TraceSender.Conditional_F1(10123, 15606, 15618) || ((_isNativeInt && DynAbs.Tracing.TraceSender.Conditional_F2(10123, 15621, 15656)) || DynAbs.Tracing.TraceSender.Conditional_F3(10123, 15659, 15663))) ? f_10123_15621_15656(this, asNativeInt: false) : null; DynAbs.Tracing.TraceSender.TraceExitMethod(10123, 15603, 15663);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10123, 15603, 15663);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10123, 15603, 15663);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override bool Equals(TypeSymbol t2, TypeCompareKind comparison)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10123, 15680, 17020);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 15785, 15887) || true) && (f_10123_15789_15814(this, t2))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10123, 15785, 15887);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 15856, 15868);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10123, 15785, 15887);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 15997, 16315) || true) && ((comparison & TypeCompareKind.IgnoreDynamic) != 0 && (DynAbs.Tracing.TraceSender.Expression_True(10123, 16001, 16093) && (object)t2 != null) && (DynAbs.Tracing.TraceSender.Expression_True(10123, 16001, 16149) && f_10123_16118_16129(t2) == TypeKind.Dynamic) && (DynAbs.Tracing.TraceSender.Expression_True(10123, 16001, 16242) && f_10123_16174_16190(this) == Microsoft.CodeAnalysis.SpecialType.System_Object))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10123, 15997, 16315);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 16284, 16296);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10123, 15997, 16315);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 16335, 16362);

                    var
                    other = t2 as TopLevel
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 16380, 16471) || true) && (other is null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10123, 16380, 16471);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 16439, 16452);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10123, 16380, 16471);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 16491, 16684) || true) && ((comparison & TypeCompareKind.IgnoreNativeIntegers) == 0 && (DynAbs.Tracing.TraceSender.Expression_True(10123, 16495, 16610) && _isNativeInt != other._isNativeInt))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10123, 16491, 16684);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 16652, 16665);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10123, 16491, 16684);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 16704, 17005);

                    return f_10123_16711_16784(f_10123_16725_16737(), f_10123_16739_16757(other), StringComparison.Ordinal) && (DynAbs.Tracing.TraceSender.Expression_True(10123, 16711, 16829) && arity == other.arity) && (DynAbs.Tracing.TraceSender.Expression_True(10123, 16711, 16930) && f_10123_16854_16930(_namespaceName, f_10123_16884_16903(other), StringComparison.Ordinal)) && (DynAbs.Tracing.TraceSender.Expression_True(10123, 16711, 17004) && f_10123_16955_17004(_containingModule, other._containingModule));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10123, 15680, 17020);

                    bool
                    f_10123_15789_15814(Microsoft.CodeAnalysis.CSharp.Symbols.MissingMetadataTypeSymbol.TopLevel
                    objA, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    objB)
                    {
                        var return_v = ReferenceEquals((object)objA, (object)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10123, 15789, 15814);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.TypeKind
                    f_10123_16118_16129(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10123, 16118, 16129);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SpecialType
                    f_10123_16174_16190(Microsoft.CodeAnalysis.CSharp.Symbols.MissingMetadataTypeSymbol.TopLevel
                    this_param)
                    {
                        var return_v = this_param.SpecialType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10123, 16174, 16190);
                        return return_v;
                    }


                    string
                    f_10123_16725_16737()
                    {
                        var return_v = MetadataName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10123, 16725, 16737);
                        return return_v;
                    }


                    string
                    f_10123_16739_16757(Microsoft.CodeAnalysis.CSharp.Symbols.MissingMetadataTypeSymbol.TopLevel
                    this_param)
                    {
                        var return_v = this_param.MetadataName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10123, 16739, 16757);
                        return return_v;
                    }


                    bool
                    f_10123_16711_16784(string
                    a, string
                    b, System.StringComparison
                    comparisonType)
                    {
                        var return_v = string.Equals(a, b, comparisonType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10123, 16711, 16784);
                        return return_v;
                    }


                    string
                    f_10123_16884_16903(Microsoft.CodeAnalysis.CSharp.Symbols.MissingMetadataTypeSymbol.TopLevel
                    this_param)
                    {
                        var return_v = this_param.NamespaceName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10123, 16884, 16903);
                        return return_v;
                    }


                    bool
                    f_10123_16854_16930(string
                    a, string
                    b, System.StringComparison
                    comparisonType)
                    {
                        var return_v = string.Equals(a, b, comparisonType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10123, 16854, 16930);
                        return return_v;
                    }


                    bool
                    f_10123_16955_17004(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    obj)
                    {
                        var return_v = this_param.Equals((object)obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10123, 16955, 17004);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10123, 15680, 17020);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10123, 15680, 17020);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static TopLevel()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10123, 5755, 17031);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10123, 5755, 17031);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10123, 5755, 17031);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10123, 5755, 17031);

            static Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
            f_10123_6443_6449_C(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10123, 6322, 6610);
                return return_v;
            }


            static Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
            f_10123_6752_6758_C(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10123, 6626, 6818);
                return return_v;
            }


            static Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
            f_10123_6985_6991_C(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10123, 6834, 7065);
                return return_v;
            }


            static Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
            f_10123_7236_7242_C(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10123, 7081, 7318);
                return return_v;
            }


            static Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
            f_10123_7466_7472_C(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10123, 7334, 7614);
                return return_v;
            }


            static Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
            f_10123_7779_7785_C(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10123, 7630, 8248);
                return return_v;
            }


            int
            f_10123_8576_8618(bool
            b)
            {
                RoslynDebug.Assert(b);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10123, 8576, 8618);
                return 0;
            }


            int
            f_10123_8637_8675(bool
            b)
            {
                RoslynDebug.Assert(b);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10123, 8637, 8675);
                return 0;
            }


            int
            f_10123_8694_8789(bool
            b)
            {
                RoslynDebug.Assert(b);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10123, 8694, 8789);
                return 0;
            }


            static string
            f_10123_8508_8512_C(string
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10123, 8264, 9092);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.MissingMetadataTypeSymbol.TopLevel
            f_10123_15621_15656(Microsoft.CodeAnalysis.CSharp.Symbols.MissingMetadataTypeSymbol.TopLevel
            this_param, bool
            asNativeInt)
            {
                var return_v = this_param.AsNativeInteger(asNativeInt: asNativeInt);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10123, 15621, 15656);
                return return_v;
            }

        }
        internal sealed class Nested : MissingMetadataTypeSymbol
        {
            private readonly NamedTypeSymbol _containingType;

            public Nested(NamedTypeSymbol containingType, string name, int arity, bool mangleName)
            : base(f_10123_17392_17396_C(name), arity, mangleName)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10123, 17281, 17568);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 17249, 17264);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 17449, 17500);

                    f_10123_17449_17499((object)containingType != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 17520, 17553);

                    _containingType = containingType;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10123, 17281, 17568);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10123, 17281, 17568);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10123, 17281, 17568);
                }
            }

            public Nested(NamedTypeSymbol containingType, ref MetadataTypeName emittedName)
            : this(f_10123_17688_17702_C(containingType), ref emittedName, emittedName.ForcedArity == -1 || (DynAbs.Tracing.TraceSender.Expression_False(10123, 17721, 17806) || emittedName.ForcedArity == emittedName.InferredArity))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10123, 17584, 17837);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10123, 17584, 17837);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10123, 17584, 17837);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10123, 17584, 17837);
                }
            }

            private Nested(NamedTypeSymbol containingType, ref MetadataTypeName emittedName, bool mangleName)
            : this(f_10123_17975_17989_C(containingType), (DynAbs.Tracing.TraceSender.Conditional_F1(10123, 18015, 18025) || ((mangleName && DynAbs.Tracing.TraceSender.Conditional_F2(10123, 18028, 18057)) || DynAbs.Tracing.TraceSender.Conditional_F3(10123, 18060, 18080))) ? emittedName.UnmangledTypeName : emittedName.TypeName, (DynAbs.Tracing.TraceSender.Conditional_F1(10123, 18106, 18116) || ((mangleName && DynAbs.Tracing.TraceSender.Conditional_F2(10123, 18119, 18144)) || DynAbs.Tracing.TraceSender.Conditional_F3(10123, 18147, 18170))) ? emittedName.InferredArity : emittedName.ForcedArity, mangleName)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10123, 17853, 18237);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10123, 17853, 18237);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10123, 17853, 18237);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10123, 17853, 18237);
                }
            }

            public override Symbol ContainingSymbol
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10123, 18325, 18411);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 18369, 18392);

                        return _containingType;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10123, 18325, 18411);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10123, 18253, 18426);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10123, 18253, 18426);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override SpecialType SpecialType
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10123, 18516, 18653);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 18560, 18584);

                        return SpecialType.None;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10123, 18516, 18653);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10123, 18444, 18668);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10123, 18444, 18668);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            protected override NamedTypeSymbol WithTupleDataCore(TupleExtraData newData)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10123, 18684, 18845);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 18793, 18830);

                    throw f_10123_18799_18829();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10123, 18684, 18845);

                    System.Exception
                    f_10123_18799_18829()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10123, 18799, 18829);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10123, 18684, 18845);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10123, 18684, 18845);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override int GetHashCode()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10123, 18861, 19014);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 18927, 18999);

                    return f_10123_18934_18998(_containingType, f_10123_18964_18997(f_10123_18977_18989(), arity));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10123, 18861, 19014);

                    string
                    f_10123_18977_18989()
                    {
                        var return_v = MetadataName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10123, 18977, 18989);
                        return return_v;
                    }


                    int
                    f_10123_18964_18997(string
                    newKeyPart, int
                    currentKey)
                    {
                        var return_v = Hash.Combine(newKeyPart, currentKey);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10123, 18964, 18997);
                        return return_v;
                    }


                    int
                    f_10123_18934_18998(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    newKeyPart, int
                    currentKey)
                    {
                        var return_v = Hash.Combine(newKeyPart, currentKey);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10123, 18934, 18998);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10123, 18861, 19014);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10123, 18861, 19014);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override bool Equals(TypeSymbol t2, TypeCompareKind comparison)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10123, 19030, 19549);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 19135, 19237) || true) && (f_10123_19139_19164(this, t2))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10123, 19135, 19237);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 19206, 19218);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10123, 19135, 19237);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 19257, 19282);

                    var
                    other = t2 as Nested
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10123, 19300, 19534);

                    return (object?)other != null && (DynAbs.Tracing.TraceSender.Expression_True(10123, 19307, 19406) && f_10123_19333_19406(f_10123_19347_19359(), f_10123_19361_19379(other), StringComparison.Ordinal)) && (DynAbs.Tracing.TraceSender.Expression_True(10123, 19307, 19451) && arity == other.arity) && (DynAbs.Tracing.TraceSender.Expression_True(10123, 19307, 19533) && f_10123_19476_19533(_containingType, other._containingType, comparison));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10123, 19030, 19549);

                    bool
                    f_10123_19139_19164(Microsoft.CodeAnalysis.CSharp.Symbols.MissingMetadataTypeSymbol.Nested
                    objA, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    objB)
                    {
                        var return_v = ReferenceEquals((object)objA, (object)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10123, 19139, 19164);
                        return return_v;
                    }


                    string
                    f_10123_19347_19359()
                    {
                        var return_v = MetadataName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10123, 19347, 19359);
                        return return_v;
                    }


                    string
                    f_10123_19361_19379(Microsoft.CodeAnalysis.CSharp.Symbols.MissingMetadataTypeSymbol.Nested
                    this_param)
                    {
                        var return_v = this_param.MetadataName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10123, 19361, 19379);
                        return return_v;
                    }


                    bool
                    f_10123_19333_19406(string
                    a, string
                    b, System.StringComparison
                    comparisonType)
                    {
                        var return_v = string.Equals(a, b, comparisonType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10123, 19333, 19406);
                        return return_v;
                    }


                    bool
                    f_10123_19476_19533(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    t2, Microsoft.CodeAnalysis.TypeCompareKind
                    comparison)
                    {
                        var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)t2, comparison);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10123, 19476, 19533);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10123, 19030, 19549);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10123, 19030, 19549);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static Nested()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10123, 17135, 19560);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10123, 17135, 19560);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10123, 17135, 19560);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10123, 17135, 19560);

            int
            f_10123_17449_17499(bool
            b)
            {
                RoslynDebug.Assert(b);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10123, 17449, 17499);
                return 0;
            }


            static string
            f_10123_17392_17396_C(string
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10123, 17281, 17568);
                return return_v;
            }


            static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            f_10123_17688_17702_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10123, 17584, 17837);
                return return_v;
            }


            static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            f_10123_17975_17989_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10123, 17853, 18237);
                return return_v;
            }

        }

        static MissingMetadataTypeSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10123, 947, 19567);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10123, 947, 19567);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10123, 947, 19567);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10123, 947, 19567);

        int
        f_10123_1322_1354(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10123, 1322, 1354);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol.TupleExtraData?
        f_10123_1287_1296_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol.TupleExtraData?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10123, 1158, 1490);
            return return_v;
        }

    }
}
