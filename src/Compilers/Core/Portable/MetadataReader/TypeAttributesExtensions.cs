// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Reflection;
using System.Runtime.InteropServices;

namespace Microsoft.CodeAnalysis
{
    internal static class TypeAttributesExtensions
    {
        public static bool IsInterface(this TypeAttributes flags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(417, 400, 540);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(417, 482, 529);

                return (flags & TypeAttributes.Interface) != 0;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(417, 400, 540);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(417, 400, 540);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(417, 400, 540);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsWindowsRuntime(this TypeAttributes flags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(417, 552, 702);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(417, 639, 691);

                return (flags & TypeAttributes.WindowsRuntime) != 0;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(417, 552, 702);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(417, 552, 702);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(417, 552, 702);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsPublic(this TypeAttributes flags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(417, 714, 848);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(417, 793, 837);

                return (flags & TypeAttributes.Public) != 0;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(417, 714, 848);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(417, 714, 848);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(417, 714, 848);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsSpecialName(this TypeAttributes flags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(417, 860, 1004);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(417, 944, 993);

                return (flags & TypeAttributes.SpecialName) != 0;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(417, 860, 1004);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(417, 860, 1004);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(417, 860, 1004);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static CharSet ToCharSet(this TypeAttributes flags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(417, 1187, 1714);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(417, 1272, 1703);

                switch (flags & TypeAttributes.StringFormatMask)
                {

                    case TypeAttributes.AutoClass:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(417, 1272, 1703);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(417, 1405, 1439);

                        return Cci.Constants.CharSet_Auto;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(417, 1272, 1703);

                    case TypeAttributes.AnsiClass:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(417, 1272, 1703);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(417, 1511, 1531);

                        return CharSet.Ansi;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(417, 1272, 1703);

                    case TypeAttributes.UnicodeClass:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(417, 1272, 1703);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(417, 1606, 1629);

                        return CharSet.Unicode;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(417, 1272, 1703);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(417, 1272, 1703);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(417, 1679, 1688);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(417, 1272, 1703);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(417, 1187, 1714);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(417, 1187, 1714);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(417, 1187, 1714);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static TypeAttributesExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(417, 337, 1721);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(417, 337, 1721);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(417, 337, 1721);
        }

    }
}
