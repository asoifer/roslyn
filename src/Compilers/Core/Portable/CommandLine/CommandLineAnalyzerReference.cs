// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{

    [DebuggerDisplay("{FilePath,nq}")]
    public struct CommandLineAnalyzerReference : IEquatable<CommandLineAnalyzerReference>
    {

        private readonly string _path;

        public CommandLineAnalyzerReference(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(121, 608, 705);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(121, 681, 694);

                _path = path;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(121, 608, 705);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(121, 608, 705);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(121, 608, 705);
            }
        }

        public string FilePath
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(121, 844, 908);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(121, 880, 893);

                    return _path;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(121, 844, 908);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(121, 797, 919);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(121, 797, 919);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(121, 931, 1100);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(121, 996, 1089);

                // LAFHIS
                var temp1 = obj is CommandLineAnalyzerReference;
                var temp2 = false;
                if (temp1)
                {
                    DynAbs.Tracing.TraceSender.Expression_True(121, 1003, 1088);
                    temp2 = base.Equals(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 1042, 1088);
                }

                return temp1 && temp2;
                DynAbs.Tracing.TraceSender.TraceExitMethod(121, 931, 1100);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(121, 931, 1100);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(121, 931, 1100);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool Equals(CommandLineAnalyzerReference other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(121, 1112, 1230);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(121, 1191, 1219);

                return _path == other._path;
                DynAbs.Tracing.TraceSender.TraceExitMethod(121, 1112, 1230);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(121, 1112, 1230);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(121, 1112, 1230);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(121, 1242, 1341);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(121, 1300, 1330);

                return f_121_1307_1329(_path, 0);
                DynAbs.Tracing.TraceSender.TraceExitMethod(121, 1242, 1341);

                int
                f_121_1307_1329(string
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(121, 1307, 1329);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(121, 1242, 1341);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(121, 1242, 1341);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static CommandLineAnalyzerReference()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(121, 424, 1348);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(121, 424, 1348);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(121, 424, 1348);
        }
    }
}
