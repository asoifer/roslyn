// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    public class XmlFileResolver : XmlReferenceResolver
    {
        public static XmlFileResolver Default { get; }

        private readonly string? _baseDirectory;

        public XmlFileResolver(string? baseDirectory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(46, 704, 1066);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(46, 677, 691);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(46, 774, 1008) || true) && (baseDirectory != null && (DynAbs.Tracing.TraceSender.Expression_True(46, 778, 864) && f_46_803_843(baseDirectory) != PathKind.Absolute))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(46, 774, 1008);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(46, 898, 993);

                    throw f_46_904_992(f_46_926_968(), nameof(baseDirectory));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(46, 774, 1008);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(46, 1024, 1055);

                _baseDirectory = baseDirectory;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(46, 704, 1066);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(46, 704, 1066);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(46, 704, 1066);
            }
        }

        public string? BaseDirectory
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(46, 1131, 1161);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(46, 1137, 1159);

                    return _baseDirectory;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(46, 1131, 1161);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(46, 1078, 1172);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(46, 1078, 1172);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string? ResolveReference(string path, string? baseFilePath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(46, 1973, 3219);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(46, 2299, 2320);

                string?
                resolvedPath
                = default(string?);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(46, 2336, 2756) || true) && (baseFilePath != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(46, 2336, 2756);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(46, 2394, 2479);

                    resolvedPath = f_46_2409_2478(path, baseFilePath, _baseDirectory);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(46, 2497, 2574);

                    f_46_2497_2573(resolvedPath == null || (DynAbs.Tracing.TraceSender.Expression_False(46, 2510, 2572) || f_46_2534_2572(resolvedPath)));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(46, 2592, 2741) || true) && (f_46_2596_2620(this, resolvedPath))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(46, 2592, 2741);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(46, 2662, 2722);

                        return f_46_2669_2721(resolvedPath);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(46, 2592, 2741);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(46, 2336, 2756);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(46, 2772, 3180) || true) && (_baseDirectory != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(46, 2772, 3180);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(46, 2832, 2903);

                    resolvedPath = f_46_2847_2902(path, _baseDirectory);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(46, 2921, 2998);

                    f_46_2921_2997(resolvedPath == null || (DynAbs.Tracing.TraceSender.Expression_False(46, 2934, 2996) || f_46_2958_2996(resolvedPath)));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(46, 3016, 3165) || true) && (f_46_3020_3044(this, resolvedPath))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(46, 3016, 3165);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(46, 3086, 3146);

                        return f_46_3093_3145(resolvedPath);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(46, 3016, 3165);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(46, 2772, 3180);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(46, 3196, 3208);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(46, 1973, 3219);

                string?
                f_46_2409_2478(string
                path, string
                basePath, string?
                baseDirectory)
                {
                    var return_v = FileUtilities.ResolveRelativePath(path, basePath, baseDirectory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(46, 2409, 2478);
                    return return_v;
                }


                bool
                f_46_2534_2572(string
                path)
                {
                    var return_v = PathUtilities.IsAbsolute(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(46, 2534, 2572);
                    return return_v;
                }


                int
                f_46_2497_2573(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(46, 2497, 2573);
                    return 0;
                }


                bool
                f_46_2596_2620(Microsoft.CodeAnalysis.XmlFileResolver
                this_param, string?
                resolvedPath)
                {
                    var return_v = this_param.FileExists(resolvedPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(46, 2596, 2620);
                    return return_v;
                }


                string?
                f_46_2669_2721(string
                path)
                {
                    var return_v = FileUtilities.TryNormalizeAbsolutePath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(46, 2669, 2721);
                    return return_v;
                }


                string?
                f_46_2847_2902(string
                path, string
                baseDirectory)
                {
                    var return_v = FileUtilities.ResolveRelativePath(path, baseDirectory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(46, 2847, 2902);
                    return return_v;
                }


                bool
                f_46_2958_2996(string
                path)
                {
                    var return_v = PathUtilities.IsAbsolute(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(46, 2958, 2996);
                    return return_v;
                }


                int
                f_46_2921_2997(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(46, 2921, 2997);
                    return 0;
                }


                bool
                f_46_3020_3044(Microsoft.CodeAnalysis.XmlFileResolver
                this_param, string?
                resolvedPath)
                {
                    var return_v = this_param.FileExists(resolvedPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(46, 3020, 3044);
                    return return_v;
                }


                string?
                f_46_3093_3145(string
                path)
                {
                    var return_v = FileUtilities.TryNormalizeAbsolutePath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(46, 3093, 3145);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(46, 1973, 3219);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(46, 1973, 3219);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Stream OpenRead(string resolvedPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(46, 3231, 3455);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(46, 3308, 3386);

                f_46_3308_3385(resolvedPath, nameof(resolvedPath));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(46, 3400, 3444);

                return f_46_3407_3443(resolvedPath);
                DynAbs.Tracing.TraceSender.TraceExitMethod(46, 3231, 3455);

                int
                f_46_3308_3385(string
                path, string
                argumentName)
                {
                    CompilerPathUtilities.RequireAbsolutePath(path, argumentName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(46, 3308, 3385);
                    return 0;
                }


                System.IO.Stream
                f_46_3407_3443(string
                fullPath)
                {
                    var return_v = FileUtilities.OpenRead(fullPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(46, 3407, 3443);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(46, 3231, 3455);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(46, 3231, 3455);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual bool FileExists([NotNullWhen(true)] string? resolvedPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(46, 3467, 3611);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(46, 3567, 3600);

                return f_46_3574_3599(resolvedPath);
                DynAbs.Tracing.TraceSender.TraceExitMethod(46, 3467, 3611);

                bool
                f_46_3574_3599(string?
                path)
                {
                    var return_v = File.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(46, 3574, 3599);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(46, 3467, 3611);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(46, 3467, 3611);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(46, 3623, 4035);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(46, 3769, 3876) || true) && (obj == null || (DynAbs.Tracing.TraceSender.Expression_False(46, 3773, 3814) || f_46_3788_3797(this) != f_46_3801_3814(obj)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(46, 3769, 3876);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(46, 3848, 3861);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(46, 3769, 3876);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(46, 3892, 3925);

                var
                other = (XmlFileResolver)obj
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(46, 3939, 4024);

                return f_46_3946_4023(_baseDirectory, other._baseDirectory, StringComparison.Ordinal);
                DynAbs.Tracing.TraceSender.TraceExitMethod(46, 3623, 4035);

                System.Type
                f_46_3788_3797(Microsoft.CodeAnalysis.XmlFileResolver
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(46, 3788, 3797);
                    return return_v;
                }


                System.Type
                f_46_3801_3814(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(46, 3801, 3814);
                    return return_v;
                }


                bool
                f_46_3946_4023(string?
                a, string?
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(46, 3946, 4023);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(46, 3623, 4035);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(46, 3623, 4035);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(46, 4047, 4203);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(46, 4105, 4192);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(46, 4112, 4134) || ((_baseDirectory != null && DynAbs.Tracing.TraceSender.Conditional_F2(46, 4137, 4187)) || DynAbs.Tracing.TraceSender.Conditional_F3(46, 4190, 4191))) ? f_46_4137_4187(f_46_4137_4159(), _baseDirectory) : 0;
                DynAbs.Tracing.TraceSender.TraceExitMethod(46, 4047, 4203);

                System.StringComparer
                f_46_4137_4159()
                {
                    var return_v = StringComparer.Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(46, 4137, 4159);
                    return return_v;
                }


                int
                f_46_4137_4187(System.StringComparer
                this_param, string
                obj)
                {
                    var return_v = this_param.GetHashCode(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(46, 4137, 4187);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(46, 4047, 4203);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(46, 4047, 4203);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static XmlFileResolver()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(46, 482, 4210);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(46, 550, 640);
            Default = f_46_599_639(baseDirectory: null); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(46, 482, 4210);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(46, 482, 4210);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(46, 482, 4210);

        static Microsoft.CodeAnalysis.XmlFileResolver
        f_46_599_639(string?
        baseDirectory)
        {
            var return_v = new Microsoft.CodeAnalysis.XmlFileResolver(baseDirectory: baseDirectory);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(46, 599, 639);
            return return_v;
        }


        static Roslyn.Utilities.PathKind
        f_46_803_843(string
        path)
        {
            var return_v = PathUtilities.GetPathKind(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(46, 803, 843);
            return return_v;
        }


        static string
        f_46_926_968()
        {
            var return_v = CodeAnalysisResources.AbsolutePathExpected;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(46, 926, 968);
            return return_v;
        }


        static System.ArgumentException
        f_46_904_992(string
        message, string
        paramName)
        {
            var return_v = new System.ArgumentException(message, paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(46, 904, 992);
            return return_v;
        }

    }
}
