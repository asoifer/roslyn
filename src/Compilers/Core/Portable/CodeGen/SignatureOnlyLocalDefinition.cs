// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using System.Reflection.Metadata;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CodeGen
{
    internal sealed class SignatureOnlyLocalDefinition : Cci.ILocalDefinition
    {
        private readonly byte[] _signature;

        private readonly int _slot;

        internal SignatureOnlyLocalDefinition(byte[] signature, int slot)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(83, 820, 971);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(83, 760, 770);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(83, 802, 807);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(83, 910, 933);

                _signature = signature;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(83, 947, 960);

                _slot = slot;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(83, 820, 971);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(83, 820, 971);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(83, 820, 971);
            }
        }

        public MetadataConstant CompileTimeValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(83, 1048, 1093);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(83, 1054, 1091);

                    throw f_83_1060_1090();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(83, 1048, 1093);

                    System.Exception
                    f_83_1060_1090()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(83, 1060, 1090);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(83, 983, 1104);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(83, 983, 1104);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ImmutableArray<Cci.ICustomModifier> CustomModifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(83, 1199, 1244);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(83, 1205, 1242);

                    throw f_83_1211_1241();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(83, 1199, 1244);

                    System.Exception
                    f_83_1211_1241()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(83, 1211, 1241);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(83, 1116, 1255);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(83, 1116, 1255);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ImmutableArray<bool> DynamicTransformFlags
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(83, 1341, 1383);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(83, 1347, 1381);

                    return ImmutableArray<bool>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(83, 1341, 1383);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(83, 1267, 1394);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(83, 1267, 1394);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ImmutableArray<string> TupleElementNames
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(83, 1478, 1522);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(83, 1484, 1520);

                    return ImmutableArray<string>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(83, 1478, 1522);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(83, 1406, 1533);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(83, 1406, 1533);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public LocalVariableAttributes PdbAttributes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(83, 1792, 1833);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(83, 1795, 1833);
                    return LocalVariableAttributes.DebuggerHidden; DynAbs.Tracing.TraceSender.TraceExitMethod(83, 1792, 1833);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(83, 1792, 1833);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(83, 1792, 1833);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsPinned
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(83, 1891, 1936);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(83, 1897, 1934);

                    throw f_83_1903_1933();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(83, 1891, 1936);

                    System.Exception
                    f_83_1903_1933()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(83, 1903, 1933);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(83, 1846, 1947);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(83, 1846, 1947);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(83, 2007, 2052);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(83, 2013, 2050);

                    throw f_83_2019_2049();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(83, 2007, 2052);

                    System.Exception
                    f_83_2019_2049()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(83, 2019, 2049);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(83, 1959, 2063);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(83, 1959, 2063);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public LocalSlotConstraints Constraints
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(83, 2139, 2184);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(83, 2145, 2182);

                    throw f_83_2151_2181();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(83, 2139, 2184);

                    System.Exception
                    f_83_2151_2181()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(83, 2151, 2181);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(83, 2075, 2195);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(83, 2075, 2195);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Location Location
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(83, 2232, 2248);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(83, 2235, 2248);
                    return f_83_2235_2248(); DynAbs.Tracing.TraceSender.TraceExitMethod(83, 2232, 2248);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(83, 2232, 2248);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(83, 2232, 2248);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public string? Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(83, 2281, 2288);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(83, 2284, 2288);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(83, 2281, 2288);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(83, 2281, 2288);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(83, 2281, 2288);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int SlotIndex
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(83, 2322, 2330);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(83, 2325, 2330);
                    return _slot; DynAbs.Tracing.TraceSender.TraceExitMethod(83, 2322, 2330);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(83, 2322, 2330);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(83, 2322, 2330);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Cci.ITypeReference Type
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(83, 2398, 2443);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(83, 2404, 2441);

                    throw f_83_2410_2440();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(83, 2398, 2443);

                    System.Exception
                    f_83_2410_2440()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(83, 2410, 2440);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(83, 2343, 2454);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(83, 2343, 2454);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public byte[] Signature
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(83, 2490, 2503);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(83, 2493, 2503);
                    return _signature; DynAbs.Tracing.TraceSender.TraceExitMethod(83, 2490, 2503);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(83, 2490, 2503);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(83, 2490, 2503);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public LocalSlotDebugInfo SlotInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(83, 2564, 2642);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(83, 2567, 2642);
                    return f_83_2567_2642(SynthesizedLocalKind.EmitterTemp, LocalDebugId.None); DynAbs.Tracing.TraceSender.TraceExitMethod(83, 2564, 2642);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(83, 2564, 2642);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(83, 2564, 2642);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static SignatureOnlyLocalDefinition()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(83, 646, 2650);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(83, 646, 2650);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(83, 646, 2650);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(83, 646, 2650);

        Microsoft.CodeAnalysis.Location
        f_83_2235_2248()
        {
            var return_v = Location.None;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(83, 2235, 2248);
            return return_v;
        }


        Microsoft.CodeAnalysis.CodeGen.LocalSlotDebugInfo
        f_83_2567_2642(Microsoft.CodeAnalysis.SynthesizedLocalKind
        synthesizedKind, Microsoft.CodeAnalysis.CodeGen.LocalDebugId
        id)
        {
            var return_v = new Microsoft.CodeAnalysis.CodeGen.LocalSlotDebugInfo(synthesizedKind, id);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(83, 2567, 2642);
            return return_v;
        }

    }
}
