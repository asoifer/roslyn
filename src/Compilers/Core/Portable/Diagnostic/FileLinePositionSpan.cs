// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{

    public struct FileLinePositionSpan : IEquatable<FileLinePositionSpan>
    {

        private readonly string _path;

        private readonly LinePositionSpan _span;

        private readonly bool _hasMappedPath;

        public string Path
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(190, 1076, 1097);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(190, 1082, 1095);

                    return _path;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(190, 1076, 1097);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(190, 1055, 1099);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(190, 1055, 1099);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool HasMappedPath
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(190, 1417, 1447);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(190, 1423, 1445);

                    return _hasMappedPath;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(190, 1417, 1447);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(190, 1389, 1449);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(190, 1389, 1449);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public LinePosition StartLinePosition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(190, 1656, 1683);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(190, 1662, 1681);

                    return _span.Start;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(190, 1656, 1683);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(190, 1616, 1685);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(190, 1616, 1685);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public LinePosition EndLinePosition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(190, 1888, 1913);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(190, 1894, 1911);

                    return _span.End;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(190, 1888, 1913);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(190, 1850, 1915);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(190, 1850, 1915);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public LinePositionSpan Span
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(190, 2055, 2119);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(190, 2091, 2104);

                    return _span;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(190, 2055, 2119);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(190, 2002, 2130);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(190, 2002, 2130);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public FileLinePositionSpan(string path, LinePosition start, LinePosition end)
        : this(f_190_2689_2693_C(path), f_190_2695_2727(start, end))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(190, 2590, 2750);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(190, 2590, 2750);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(190, 2590, 2750);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(190, 2590, 2750);
            }
        }

        public FileLinePositionSpan(string path, LinePositionSpan span)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(190, 3132, 3435);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(190, 3220, 3331) || true) && (path == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(190, 3220, 3331);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(190, 3270, 3316);

                    throw f_190_3276_3315(nameof(path));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(190, 3220, 3331);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(190, 3347, 3360);

                _path = path;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(190, 3374, 3387);

                _span = span;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(190, 3401, 3424);

                _hasMappedPath = false;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(190, 3132, 3435);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(190, 3132, 3435);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(190, 3132, 3435);
            }
        }

        internal FileLinePositionSpan(string path, LinePositionSpan span, bool hasMappedPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(190, 3447, 3653);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(190, 3557, 3570);

                _path = path;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(190, 3584, 3597);

                _span = span;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(190, 3611, 3642);

                _hasMappedPath = hasMappedPath;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(190, 3447, 3653);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(190, 3447, 3653);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(190, 3447, 3653);
            }
        }

        public bool IsValid
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(190, 3823, 3977);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(190, 3941, 3962);

                    return _path != null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(190, 3823, 3977);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(190, 3779, 3988);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(190, 3779, 3988);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool Equals(FileLinePositionSpan other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(190, 4261, 4515);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(190, 4332, 4504);

                return _span.Equals(other._span) && (DynAbs.Tracing.TraceSender.Expression_True(190, 4339, 4423) && _hasMappedPath == other._hasMappedPath
                ) && (DynAbs.Tracing.TraceSender.Expression_True(190, 4339, 4503) && f_190_4444_4503(_path, other._path, StringComparison.Ordinal));
                DynAbs.Tracing.TraceSender.TraceExitMethod(190, 4261, 4515);

                bool
                f_190_4444_4503(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(190, 4444, 4503);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(190, 4261, 4515);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(190, 4261, 4515);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object? other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(190, 4645, 4799);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(190, 4712, 4788);

                return other is FileLinePositionSpan && (DynAbs.Tracing.TraceSender.Expression_True(190, 4719, 4787) && Equals(other));
                DynAbs.Tracing.TraceSender.TraceExitMethod(190, 4645, 4799);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(190, 4645, 4799);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(190, 4645, 4799);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(190, 5113, 5260);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(190, 5171, 5249);

                return f_190_5178_5248(_path, f_190_5198_5247(_hasMappedPath, _span.GetHashCode()));
                DynAbs.Tracing.TraceSender.TraceExitMethod(190, 5113, 5260);

                int
                f_190_5198_5247(bool
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(190, 5198, 5247);
                    return return_v;
                }


                int
                f_190_5178_5248(string
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(190, 5178, 5248);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(190, 5113, 5260);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(190, 5113, 5260);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(190, 5541, 5638);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(190, 5599, 5627);

                // LAFHIS
                var temp1 = _path + ": " + _span.ToString(); //DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (_span).ToString(), 190, 5621, 5626);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(190, 5621, 5626);
                return temp1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(190, 5541, 5638);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(190, 5541, 5638);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(190, 5541, 5638);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static FileLinePositionSpan()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(190, 598, 5645);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(190, 598, 5645);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(190, 598, 5645);
        }

        static Microsoft.CodeAnalysis.Text.LinePositionSpan
        f_190_2695_2727(Microsoft.CodeAnalysis.Text.LinePosition
        start, Microsoft.CodeAnalysis.Text.LinePosition
        end)
        {
            var return_v = new Microsoft.CodeAnalysis.Text.LinePositionSpan(start, end);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(190, 2695, 2727);
            return return_v;
        }


        static string
        f_190_2689_2693_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(190, 2590, 2750);
            return return_v;
        }


        static System.ArgumentNullException
        f_190_3276_3315(string
        paramName)
        {
            var return_v = new System.ArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(190, 3276, 3315);
            return return_v;
        }

    }
}
