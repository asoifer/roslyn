// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{

    [DebuggerDisplay("{Reference,nq}")]
    public struct CommandLineReference : IEquatable<CommandLineReference>
    {

        private readonly string _reference;

        private readonly MetadataReferenceProperties _properties;

        public CommandLineReference(string reference, MetadataReferenceProperties properties)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(124, 690, 934);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(124, 800, 847);

                f_124_800_846(!f_124_814_845(reference));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(124, 861, 884);

                _reference = reference;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(124, 898, 923);

                _properties = properties;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(124, 690, 934);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(124, 690, 934);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(124, 690, 934);
            }
        }

        public string Reference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(124, 1102, 1128);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(124, 1108, 1126);

                    return _reference;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(124, 1102, 1128);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(124, 1054, 1139);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(124, 1054, 1139);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public MetadataReferenceProperties Properties
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(124, 1312, 1339);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(124, 1318, 1337);

                    return _properties;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(124, 1312, 1339);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(124, 1242, 1350);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(124, 1242, 1350);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(124, 1362, 1515);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(124, 1427, 1504);

                // LAFHIS
                var temp1 = obj is CommandLineReference;
                var temp2 = false;
                if (temp1)
                {
                    DynAbs.Tracing.TraceSender.Expression_True(124, 1434, 1503);
                    temp2 = base.Equals(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 1465, 1503);
                }

                return temp1 && temp2;
                DynAbs.Tracing.TraceSender.TraceExitMethod(124, 1362, 1515);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(124, 1362, 1515);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(124, 1362, 1515);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool Equals(CommandLineReference other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(124, 1527, 1705);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(124, 1598, 1694);

                return _reference == other._reference
                && (DynAbs.Tracing.TraceSender.Expression_True(124, 1605, 1693) && _properties.Equals(other._properties));
                DynAbs.Tracing.TraceSender.TraceExitMethod(124, 1527, 1705);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(124, 1527, 1705);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(124, 1527, 1705);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(124, 1717, 1845);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(124, 1775, 1834);

                return f_124_1782_1833(_reference, _properties.GetHashCode());
                DynAbs.Tracing.TraceSender.TraceExitMethod(124, 1717, 1845);

                int
                f_124_1782_1833(string
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 1782, 1833);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(124, 1717, 1845);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(124, 1717, 1845);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static CommandLineReference()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(124, 449, 1852);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(124, 449, 1852);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(124, 449, 1852);
        }

        static bool
        f_124_814_845(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 814, 845);
            return return_v;
        }


        static int
        f_124_800_846(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(124, 800, 846);
            return 0;
        }

    }
}
