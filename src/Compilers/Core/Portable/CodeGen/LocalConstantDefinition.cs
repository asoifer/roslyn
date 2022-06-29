// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Reflection.Metadata;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CodeGen
{
    internal sealed class LocalConstantDefinition : Cci.ILocalDefinition
    {
        public LocalConstantDefinition(
                    string name,
                    Location location,
                    MetadataConstant compileTimeValue,
                    ImmutableArray<bool> dynamicTransformFlags,
                    ImmutableArray<string> tupleElementNames)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(65, 720, 1370);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(65, 1382, 1409);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(65, 1421, 1454);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(65, 1466, 1515);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(65, 994, 1048);

                f_65_994_1047(!f_65_1014_1046(name));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(65, 1062, 1107);

                f_65_1062_1106(compileTimeValue != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(65, 1123, 1135);

                Name = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(65, 1149, 1169);

                Location = location;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(65, 1183, 1219);

                CompileTimeValue = compileTimeValue;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(65, 1233, 1293);

                DynamicTransformFlags = dynamicTransformFlags.NullToEmpty();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(65, 1307, 1359);

                TupleElementNames = tupleElementNames.NullToEmpty();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(65, 720, 1370);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(65, 720, 1370);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(65, 720, 1370);
            }
        }

        public string Name { get; }

        public Location Location { get; }

        public MetadataConstant CompileTimeValue { get; }

        public Cci.ITypeReference Type
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(65, 1558, 1582);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(65, 1561, 1582);
                    return f_65_1561_1582(f_65_1561_1577()); DynAbs.Tracing.TraceSender.TraceExitMethod(65, 1558, 1582);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(65, 1558, 1582);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(65, 1558, 1582);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsConstant
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(65, 1618, 1625);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(65, 1621, 1625);
                    return true; DynAbs.Tracing.TraceSender.TraceExitMethod(65, 1618, 1625);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(65, 1618, 1625);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(65, 1618, 1625);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(65, 1710, 1754);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(65, 1713, 1754);
                    return ImmutableArray<Cci.ICustomModifier>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(65, 1710, 1754);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(65, 1710, 1754);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(65, 1710, 1754);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsModified
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(65, 1790, 1798);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(65, 1793, 1798);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(65, 1790, 1798);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(65, 1790, 1798);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(65, 1790, 1798);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(65, 1832, 1840);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(65, 1835, 1840);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(65, 1832, 1840);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(65, 1832, 1840);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(65, 1832, 1840);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(65, 1877, 1885);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(65, 1880, 1885);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(65, 1877, 1885);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(65, 1877, 1885);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(65, 1877, 1885);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(65, 1938, 1966);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(65, 1941, 1966);
                    return LocalSlotConstraints.None; DynAbs.Tracing.TraceSender.TraceExitMethod(65, 1938, 1966);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(65, 1938, 1966);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(65, 1938, 1966);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(65, 2024, 2055);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(65, 2027, 2055);
                    return LocalVariableAttributes.None; DynAbs.Tracing.TraceSender.TraceExitMethod(65, 2024, 2055);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(65, 2024, 2055);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(65, 2024, 2055);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ImmutableArray<bool> DynamicTransformFlags { get; }

        public ImmutableArray<string> TupleElementNames { get; }

        public int SlotIndex
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(65, 2227, 2232);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(65, 2230, 2232);
                    return -1; DynAbs.Tracing.TraceSender.TraceExitMethod(65, 2227, 2232);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(65, 2227, 2232);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(65, 2227, 2232);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public byte[]? Signature
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(65, 2270, 2277);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(65, 2273, 2277);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(65, 2270, 2277);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(65, 2270, 2277);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(65, 2270, 2277);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(65, 2338, 2416);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(65, 2341, 2416);
                    return f_65_2341_2416(SynthesizedLocalKind.UserDefined, LocalDebugId.None); DynAbs.Tracing.TraceSender.TraceExitMethod(65, 2338, 2416);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(65, 2338, 2416);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(65, 2338, 2416);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static LocalConstantDefinition()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(65, 635, 2424);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(65, 635, 2424);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(65, 635, 2424);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(65, 635, 2424);

        static bool
        f_65_1014_1046(string
        value)
        {
            var return_v = RoslynString.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(65, 1014, 1046);
            return return_v;
        }


        static int
        f_65_994_1047(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(65, 994, 1047);
            return 0;
        }


        static int
        f_65_1062_1106(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(65, 1062, 1106);
            return 0;
        }


        Microsoft.CodeAnalysis.CodeGen.MetadataConstant
        f_65_1561_1577()
        {
            var return_v = CompileTimeValue;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(65, 1561, 1577);
            return return_v;
        }


        Microsoft.Cci.ITypeReference
        f_65_1561_1582(Microsoft.CodeAnalysis.CodeGen.MetadataConstant
        this_param)
        {
            var return_v = this_param.Type;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(65, 1561, 1582);
            return return_v;
        }


        Microsoft.CodeAnalysis.CodeGen.LocalSlotDebugInfo
        f_65_2341_2416(Microsoft.CodeAnalysis.SynthesizedLocalKind
        synthesizedKind, Microsoft.CodeAnalysis.CodeGen.LocalDebugId
        id)
        {
            var return_v = new Microsoft.CodeAnalysis.CodeGen.LocalSlotDebugInfo(synthesizedKind, id);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(65, 2341, 2416);
            return return_v;
        }

    }
}
