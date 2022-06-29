// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    internal sealed class ExternalFileLocation : Location, IEquatable<ExternalFileLocation?>
    {
        private readonly TextSpan _sourceSpan;

        private readonly FileLinePositionSpan _lineSpan;

        internal ExternalFileLocation(string filePath, TextSpan sourceSpan, LinePositionSpan lineSpan)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(189, 623, 849);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(189, 742, 767);

                _sourceSpan = sourceSpan;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(189, 781, 838);

                _lineSpan = f_189_793_837(filePath, lineSpan);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(189, 623, 849);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(189, 623, 849);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(189, 623, 849);
            }
        }

        public override TextSpan SourceSpan
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(189, 921, 991);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(189, 957, 976);

                    return _sourceSpan;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(189, 921, 991);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(189, 861, 1002);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(189, 861, 1002);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public string FilePath
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(189, 1037, 1054);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(189, 1040, 1054);
                    return _lineSpan.Path; DynAbs.Tracing.TraceSender.TraceExitMethod(189, 1037, 1054);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(189, 1037, 1054);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(189, 1037, 1054);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override FileLinePositionSpan GetLineSpan()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(189, 1067, 1170);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(189, 1142, 1159);

                return _lineSpan;
                DynAbs.Tracing.TraceSender.TraceExitMethod(189, 1067, 1170);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(189, 1067, 1170);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(189, 1067, 1170);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override FileLinePositionSpan GetMappedLineSpan()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(189, 1182, 1291);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(189, 1263, 1280);

                return _lineSpan;
                DynAbs.Tracing.TraceSender.TraceExitMethod(189, 1182, 1291);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(189, 1182, 1291);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(189, 1182, 1291);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override LocationKind Kind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(189, 1361, 1445);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(189, 1397, 1430);

                    return LocationKind.ExternalFile;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(189, 1361, 1445);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(189, 1303, 1456);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(189, 1303, 1456);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(189, 1468, 1592);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(189, 1533, 1581);

                return f_189_1540_1580(this, obj as ExternalFileLocation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(189, 1468, 1592);

                bool
                f_189_1540_1580(Microsoft.CodeAnalysis.ExternalFileLocation
                this_param, object?
                obj)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.ExternalFileLocation?)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(189, 1540, 1580);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(189, 1468, 1592);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(189, 1468, 1592);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool Equals(ExternalFileLocation? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(189, 1604, 1914);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(189, 1674, 1765) || true) && (f_189_1678_1704(obj, this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(189, 1674, 1765);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(189, 1738, 1750);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(189, 1674, 1765);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(189, 1781, 1903);

                return obj != null
                && (DynAbs.Tracing.TraceSender.Expression_True(189, 1788, 1850) && _sourceSpan == obj._sourceSpan
                ) && (DynAbs.Tracing.TraceSender.Expression_True(189, 1788, 1902) && _lineSpan.Equals(obj._lineSpan));
                DynAbs.Tracing.TraceSender.TraceExitMethod(189, 1604, 1914);

                bool
                f_189_1678_1704(Microsoft.CodeAnalysis.ExternalFileLocation?
                objA, Microsoft.CodeAnalysis.ExternalFileLocation
                objB)
                {
                    var return_v = ReferenceEquals((object?)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(189, 1678, 1704);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(189, 1604, 1914);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(189, 1604, 1914);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(189, 1926, 2067);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(189, 1984, 2056);

                return f_189_1991_2055(_lineSpan.GetHashCode(), _sourceSpan.GetHashCode());
                DynAbs.Tracing.TraceSender.TraceExitMethod(189, 1926, 2067);

                int
                f_189_1991_2055(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(189, 1991, 2055);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(189, 1926, 2067);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(189, 1926, 2067);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ExternalFileLocation()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(189, 410, 2074);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(189, 410, 2074);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(189, 410, 2074);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(189, 410, 2074);

        static Microsoft.CodeAnalysis.FileLinePositionSpan
        f_189_793_837(string
        path, Microsoft.CodeAnalysis.Text.LinePositionSpan
        span)
        {
            var return_v = new Microsoft.CodeAnalysis.FileLinePositionSpan(path, span);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(189, 793, 837);
            return return_v;
        }

    }
}
