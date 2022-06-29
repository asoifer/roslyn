// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

namespace Microsoft.CodeAnalysis
{
    public abstract partial class LocalizableString : IFormattable, IEquatable<LocalizableString?>
    {        /// <summary>
             /// Fired when an exception is raised by any of the public methods of <see cref="LocalizableString"/>.
             /// If the exception handler itself throws an exception, that exception is ignored.
             /// </summary>
        public event EventHandler<Exception>?
OnException
;

        public string ToString(IFormatProvider? formatProvider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(193, 1043, 1357);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(193, 1159, 1190);

                    return f_193_1166_1189(this, formatProvider);
                }
                catch (Exception ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(193, 1219, 1346);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(193, 1272, 1293);

                    f_193_1272_1292(this, ex);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(193, 1311, 1331);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(193, 1219, 1346);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(193, 1043, 1357);

                string
                f_193_1166_1189(Microsoft.CodeAnalysis.LocalizableString
                this_param, System.IFormatProvider?
                formatProvider)
                {
                    var return_v = this_param.GetText(formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(193, 1166, 1189);
                    return return_v;
                }


                int
                f_193_1272_1292(Microsoft.CodeAnalysis.LocalizableString
                this_param, System.Exception
                ex)
                {
                    this_param.RaiseOnException(ex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(193, 1272, 1292);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(193, 1043, 1357);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(193, 1043, 1357);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static explicit operator string?(LocalizableString localizableResource)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(193, 1369, 1525);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(193, 1472, 1514);

                return f_193_1479_1513(localizableResource, null);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(193, 1369, 1525);

                string
                f_193_1479_1513(Microsoft.CodeAnalysis.LocalizableString
                this_param, System.IFormatProvider?
                formatProvider)
                {
                    var return_v = this_param.ToString(formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(193, 1479, 1513);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(193, 1369, 1525);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(193, 1369, 1525);
            }
        }
        public static implicit operator LocalizableString(string? fixedResource)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(193, 1537, 1697);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(193, 1634, 1686);

                return f_193_1641_1685(fixedResource);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(193, 1537, 1697);

                Microsoft.CodeAnalysis.LocalizableString.FixedLocalizableString
                f_193_1641_1685(string?
                fixedResource)
                {
                    var return_v = FixedLocalizableString.Create(fixedResource);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(193, 1641, 1685);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(193, 1537, 1697);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(193, 1537, 1697);
            }
        }
        public sealed override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(193, 1709, 1807);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(193, 1774, 1796);

                return f_193_1781_1795(this, null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(193, 1709, 1807);

                string
                f_193_1781_1795(Microsoft.CodeAnalysis.LocalizableString
                this_param, System.IFormatProvider?
                formatProvider)
                {
                    var return_v = this_param.ToString(formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(193, 1781, 1795);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(193, 1709, 1807);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(193, 1709, 1807);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        string IFormattable.ToString(string? ignored, IFormatProvider? formatProvider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(193, 1819, 1965);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(193, 1922, 1954);

                return f_193_1929_1953(this, formatProvider);
                DynAbs.Tracing.TraceSender.TraceExitMethod(193, 1819, 1965);

                string
                f_193_1929_1953(Microsoft.CodeAnalysis.LocalizableString
                this_param, System.IFormatProvider?
                formatProvider)
                {
                    var return_v = this_param.ToString(formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(193, 1929, 1953);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(193, 1819, 1965);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(193, 1819, 1965);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(193, 1977, 2251);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(193, 2078, 2095);

                    return f_193_2085_2094(this);
                }
                catch (Exception ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(193, 2124, 2240);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(193, 2177, 2198);

                    f_193_2177_2197(this, ex);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(193, 2216, 2225);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(193, 2124, 2240);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(193, 1977, 2251);

                int
                f_193_2085_2094(Microsoft.CodeAnalysis.LocalizableString
                this_param)
                {
                    var return_v = this_param.GetHash();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(193, 2085, 2094);
                    return return_v;
                }


                int
                f_193_2177_2197(Microsoft.CodeAnalysis.LocalizableString
                this_param, System.Exception
                ex)
                {
                    this_param.RaiseOnException(ex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(193, 2177, 2197);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(193, 1977, 2251);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(193, 1977, 2251);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override bool Equals(object? other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(193, 2263, 2556);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(193, 2373, 2396);

                    return f_193_2380_2395(this, other);
                }
                catch (Exception ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(193, 2425, 2545);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(193, 2478, 2499);

                    f_193_2478_2498(this, ex);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(193, 2517, 2530);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(193, 2425, 2545);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(193, 2263, 2556);

                bool
                f_193_2380_2395(Microsoft.CodeAnalysis.LocalizableString
                this_param, object?
                other)
                {
                    var return_v = this_param.AreEqual(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(193, 2380, 2395);
                    return return_v;
                }


                int
                f_193_2478_2498(Microsoft.CodeAnalysis.LocalizableString
                this_param, System.Exception
                ex)
                {
                    this_param.RaiseOnException(ex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(193, 2478, 2498);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(193, 2263, 2556);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(193, 2263, 2556);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool Equals(LocalizableString? other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(193, 2568, 2678);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(193, 2637, 2667);

                return f_193_2644_2666(this, other);
                DynAbs.Tracing.TraceSender.TraceExitMethod(193, 2568, 2678);

                bool
                f_193_2644_2666(Microsoft.CodeAnalysis.LocalizableString
                this_param, Microsoft.CodeAnalysis.LocalizableString?
                other)
                {
                    var return_v = this_param.Equals((object?)other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(193, 2644, 2666);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(193, 2568, 2678);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(193, 2568, 2678);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract string GetText(IFormatProvider? formatProvider);

        protected abstract int GetHash();

        protected abstract bool AreEqual(object? other);

        private void RaiseOnException(Exception ex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(193, 3600, 3995);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(193, 3668, 3760) || true) && (ex is OperationCanceledException)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(193, 3668, 3760);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(193, 3738, 3745);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(193, 3668, 3760);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(193, 3812, 3842);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(OnException, 193, 3812, 3841)?.Invoke(this, ex), 193, 3824, 3841);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(193, 3871, 3984);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(193, 3871, 3984);
                    // Ignore exceptions from the exception handlers themselves.
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(193, 3600, 3995);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(193, 3600, 3995);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(193, 3600, 3995);
            }
        }

        internal virtual bool CanThrowExceptions
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(193, 4198, 4205);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(193, 4201, 4205);
                    return true; DynAbs.Tracing.TraceSender.TraceExitMethod(193, 4198, 4205);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(193, 4198, 4205);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(193, 4198, 4205);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }
    }
}
