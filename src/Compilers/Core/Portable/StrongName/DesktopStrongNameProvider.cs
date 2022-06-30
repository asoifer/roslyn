// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using Microsoft.Cci;
using Microsoft.CodeAnalysis.Interop;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    public class DesktopStrongNameProvider : StrongNameProvider
    {
        internal sealed class ClrStrongNameMissingException : Exception
        {
            public ClrStrongNameMissingException()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(561, 1327, 1412);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(561, 1327, 1412);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(561, 1327, 1412);
            }


            static ClrStrongNameMissingException()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(561, 1327, 1412);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(561, 1327, 1412);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(561, 1327, 1412);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(561, 1327, 1412);
        }

        private readonly ImmutableArray<string> _keyFileSearchPaths;

        internal override StrongNameFileSystem FileSystem { get; }

        public DesktopStrongNameProvider(ImmutableArray<string> keyFileSearchPaths) : this(f_561_1647_1665_C(keyFileSearchPaths), StrongNameFileSystem.Instance)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(561, 1564, 1719);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(561, 1564, 1719);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(561, 1564, 1719);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(561, 1564, 1719);
            }
        }

        public DesktopStrongNameProvider(ImmutableArray<string> keyFileSearchPaths = default, string? tempPath = null)
        : this(f_561_2229_2247_C(keyFileSearchPaths), (DynAbs.Tracing.TraceSender.Conditional_F1(561, 2249, 2265) || ((tempPath == null && DynAbs.Tracing.TraceSender.Conditional_F2(561, 2268, 2297)) || DynAbs.Tracing.TraceSender.Conditional_F3(561, 2300, 2334))) ? StrongNameFileSystem.Instance : f_561_2300_2334(tempPath))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(561, 2099, 2359);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(561, 2099, 2359);

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(561, 2099, 2359);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(561, 2099, 2359);
            }
        }

        internal DesktopStrongNameProvider(ImmutableArray<string> keyFileSearchPaths, StrongNameFileSystem strongNameFileSystem)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(561, 2371, 2928);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 1494, 1552);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 2516, 2765) || true) && (f_561_2520_2549_M(!keyFileSearchPaths.IsDefault) && (DynAbs.Tracing.TraceSender.Expression_True(561, 2520, 2616) && keyFileSearchPaths.Any(path => !PathUtilities.IsAbsolute(path))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(561, 2516, 2765);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 2650, 2750);

                    throw f_561_2656_2749(f_561_2678_2720(), nameof(keyFileSearchPaths));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(561, 2516, 2765);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 2781, 2848);

                FileSystem = strongNameFileSystem ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.StrongNameFileSystem>(561, 2794, 2847) ?? StrongNameFileSystem.Instance);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 2862, 2917);

                _keyFileSearchPaths = keyFileSearchPaths.NullToEmpty();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(561, 2371, 2928);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(561, 2371, 2928);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(561, 2371, 2928);
            }
        }

        internal override StrongNameKeys CreateKeys(string? keyFilePath, string? keyContainerName, bool hasCounterSignature, CommonMessageProvider messageProvider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(561, 2940, 5224);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 3120, 3164);

                var
                keyPair = default(ImmutableArray<byte>)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 3178, 3224);

                var
                publicKey = default(ImmutableArray<byte>)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 3238, 3263);

                string?
                container = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 3279, 5088) || true) && (!f_561_3284_3317(keyFilePath))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(561, 3279, 5088);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 3395, 3492);

                        string?
                        resolvedKeyFile = f_561_3421_3491(keyFilePath, f_561_3459_3469(), _keyFileSearchPaths)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 3514, 3738) || true) && (resolvedKeyFile == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(561, 3514, 3738);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 3591, 3715);

                            return f_561_3598_3714(f_561_3617_3713(messageProvider, keyFilePath, f_561_3678_3712()));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(561, 3514, 3738);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 3762, 3818);

                        f_561_3762_3817(f_561_3775_3816(resolvedKeyFile));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 3840, 3922);

                        var
                        fileContent = f_561_3858_3921(f_561_3880_3920(f_561_3880_3890(), resolvedKeyFile))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 3944, 4026);

                        return f_561_3951_4025(fileContent, keyFilePath, hasCounterSignature);
                    }
                    catch (Exception ex)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(561, 4063, 4243);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 4124, 4224);

                        return f_561_4131_4223(f_561_4150_4222(messageProvider, keyFilePath, f_561_4211_4221(ex)));
                        DynAbs.Tracing.TraceSender.TraceExitCatch(561, 4063, 4243);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(561, 3279, 5088);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(561, 3279, 5088);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 4277, 5088) || true) && (!f_561_4282_4320(keyContainerName))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(561, 4277, 5088);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 4398, 4453);

                            f_561_4398_4452(this, keyContainerName, out publicKey);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 4475, 4504);

                            container = keyContainerName;
                        }
                        catch (ClrStrongNameMissingException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(561, 4541, 4868);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 4619, 4849);

                            return f_561_4626_4848(f_561_4645_4847(messageProvider, keyContainerName, f_561_4738_4846(nameof(CodeAnalysisResources.AssemblySigningNotSupported))));
                            DynAbs.Tracing.TraceSender.TraceExitCatch(561, 4541, 4868);
                        }
                        catch (Exception ex)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(561, 4886, 5073);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 4947, 5054);

                            return f_561_4954_5053(f_561_4973_5052(messageProvider, keyContainerName, f_561_5041_5051(ex)));
                            DynAbs.Tracing.TraceSender.TraceExitCatch(561, 4886, 5073);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(561, 4277, 5088);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(561, 3279, 5088);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 5104, 5213);

                return f_561_5111_5212(keyPair, publicKey, privateKey: null, container, keyFilePath, hasCounterSignature);
                DynAbs.Tracing.TraceSender.TraceExitMethod(561, 2940, 5224);

                bool
                f_561_3284_3317(string?
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(561, 3284, 3317);
                    return return_v;
                }


                Microsoft.CodeAnalysis.StrongNameFileSystem
                f_561_3459_3469()
                {
                    var return_v = FileSystem;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(561, 3459, 3469);
                    return return_v;
                }


                string?
                f_561_3421_3491(string
                path, Microsoft.CodeAnalysis.StrongNameFileSystem
                fileSystem, System.Collections.Immutable.ImmutableArray<string>
                keyFileSearchPaths)
                {
                    var return_v = ResolveStrongNameKeyFile(path, fileSystem, keyFileSearchPaths);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(561, 3421, 3491);
                    return return_v;
                }


                string
                f_561_3678_3712()
                {
                    var return_v = CodeAnalysisResources.FileNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(561, 3678, 3712);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_561_3617_3713(Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, string
                path, string
                message)
                {
                    var return_v = StrongNameKeys.GetKeyFileError(messageProvider, path, (object)message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(561, 3617, 3713);
                    return return_v;
                }


                Microsoft.CodeAnalysis.StrongNameKeys
                f_561_3598_3714(Microsoft.CodeAnalysis.Diagnostic
                diagnostic)
                {
                    var return_v = new Microsoft.CodeAnalysis.StrongNameKeys(diagnostic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(561, 3598, 3714);
                    return return_v;
                }


                bool
                f_561_3775_3816(string
                path)
                {
                    var return_v = PathUtilities.IsAbsolute(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(561, 3775, 3816);
                    return return_v;
                }


                int
                f_561_3762_3817(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(561, 3762, 3817);
                    return 0;
                }


                Microsoft.CodeAnalysis.StrongNameFileSystem
                f_561_3880_3890()
                {
                    var return_v = FileSystem;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(561, 3880, 3890);
                    return return_v;
                }


                byte[]
                f_561_3880_3920(Microsoft.CodeAnalysis.StrongNameFileSystem
                this_param, string
                fullPath)
                {
                    var return_v = this_param.ReadAllBytes(fullPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(561, 3880, 3920);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_561_3858_3921(params byte[]
                items)
                {
                    var return_v = ImmutableArray.Create(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(561, 3858, 3921);
                    return return_v;
                }


                Microsoft.CodeAnalysis.StrongNameKeys
                f_561_3951_4025(System.Collections.Immutable.ImmutableArray<byte>
                keyFileContent, string
                keyFilePath, bool
                hasCounterSignature)
                {
                    var return_v = StrongNameKeys.CreateHelper(keyFileContent, keyFilePath, hasCounterSignature);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(561, 3951, 4025);
                    return return_v;
                }


                string
                f_561_4211_4221(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(561, 4211, 4221);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_561_4150_4222(Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, string
                path, string
                message)
                {
                    var return_v = StrongNameKeys.GetKeyFileError(messageProvider, path, (object)message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(561, 4150, 4222);
                    return return_v;
                }


                Microsoft.CodeAnalysis.StrongNameKeys
                f_561_4131_4223(Microsoft.CodeAnalysis.Diagnostic
                diagnostic)
                {
                    var return_v = new Microsoft.CodeAnalysis.StrongNameKeys(diagnostic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(561, 4131, 4223);
                    return return_v;
                }


                bool
                f_561_4282_4320(string?
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(561, 4282, 4320);
                    return return_v;
                }


                int
                f_561_4398_4452(Microsoft.CodeAnalysis.DesktopStrongNameProvider
                this_param, string
                keyContainer, out System.Collections.Immutable.ImmutableArray<byte>
                publicKey)
                {
                    this_param.ReadKeysFromContainer(keyContainer, out publicKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(561, 4398, 4452);
                    return 0;
                }


                Microsoft.CodeAnalysis.CodeAnalysisResourcesLocalizableErrorArgument
                f_561_4738_4846(string
                targetResourceId)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeAnalysisResourcesLocalizableErrorArgument(targetResourceId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(561, 4738, 4846);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_561_4645_4847(Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, string
                name, Microsoft.CodeAnalysis.CodeAnalysisResourcesLocalizableErrorArgument
                message)
                {
                    var return_v = StrongNameKeys.GetContainerError(messageProvider, name, (object)message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(561, 4645, 4847);
                    return return_v;
                }


                Microsoft.CodeAnalysis.StrongNameKeys
                f_561_4626_4848(Microsoft.CodeAnalysis.Diagnostic
                diagnostic)
                {
                    var return_v = new Microsoft.CodeAnalysis.StrongNameKeys(diagnostic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(561, 4626, 4848);
                    return return_v;
                }


                string
                f_561_5041_5051(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(561, 5041, 5051);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_561_4973_5052(Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, string
                name, string
                message)
                {
                    var return_v = StrongNameKeys.GetContainerError(messageProvider, name, (object)message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(561, 4973, 5052);
                    return return_v;
                }


                Microsoft.CodeAnalysis.StrongNameKeys
                f_561_4954_5053(Microsoft.CodeAnalysis.Diagnostic
                diagnostic)
                {
                    var return_v = new Microsoft.CodeAnalysis.StrongNameKeys(diagnostic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(561, 4954, 5053);
                    return return_v;
                }


                Microsoft.CodeAnalysis.StrongNameKeys
                f_561_5111_5212(System.Collections.Immutable.ImmutableArray<byte>
                keyPair, System.Collections.Immutable.ImmutableArray<byte>
                publicKey, System.Security.Cryptography.RSAParameters?
                privateKey, string?
                keyContainerName, string?
                keyFilePath, bool
                hasCounterSignature)
                {
                    var return_v = new Microsoft.CodeAnalysis.StrongNameKeys(keyPair, publicKey, privateKey: privateKey, keyContainerName, keyFilePath, hasCounterSignature);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(561, 5111, 5212);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(561, 2940, 5224);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(561, 2940, 5224);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string? ResolveStrongNameKeyFile(string path, StrongNameFileSystem fileSystem, ImmutableArray<string> keyFileSearchPaths)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(561, 5420, 6572);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 5799, 6058) || true) && (f_561_5803_5833(path))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(561, 5799, 6058);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 5867, 6011) || true) && (f_561_5871_5898(fileSystem, path))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(561, 5867, 6011);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 5940, 5992);

                        return f_561_5947_5991(path);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(561, 5867, 6011);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 6031, 6043);

                    return path;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(561, 5799, 6058);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 6074, 6533);
                    foreach (var searchPath in f_561_6101_6119_I(keyFileSearchPaths))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(561, 6074, 6533);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 6153, 6240);

                        string?
                        combinedPath = f_561_6176_6239(searchPath, path)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 6260, 6337);

                        f_561_6260_6336(combinedPath == null || (DynAbs.Tracing.TraceSender.Expression_False(561, 6273, 6335) || f_561_6297_6335(combinedPath)));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 6357, 6518) || true) && (f_561_6361_6396(fileSystem, combinedPath))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(561, 6357, 6518);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 6438, 6499);

                            return f_561_6445_6498(combinedPath!);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(561, 6357, 6518);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(561, 6074, 6533);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(561, 1, 460);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(561, 1, 460);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 6549, 6561);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(561, 5420, 6572);

                bool
                f_561_5803_5833(string
                path)
                {
                    var return_v = PathUtilities.IsAbsolute(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(561, 5803, 5833);
                    return return_v;
                }


                bool
                f_561_5871_5898(Microsoft.CodeAnalysis.StrongNameFileSystem
                this_param, string
                fullPath)
                {
                    var return_v = this_param.FileExists(fullPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(561, 5871, 5898);
                    return return_v;
                }


                string?
                f_561_5947_5991(string
                path)
                {
                    var return_v = FileUtilities.TryNormalizeAbsolutePath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(561, 5947, 5991);
                    return return_v;
                }


                string?
                f_561_6176_6239(string
                root, string
                relativePath)
                {
                    var return_v = PathUtilities.CombineAbsoluteAndRelativePaths(root, relativePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(561, 6176, 6239);
                    return return_v;
                }


                bool
                f_561_6297_6335(string
                path)
                {
                    var return_v = PathUtilities.IsAbsolute(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(561, 6297, 6335);
                    return return_v;
                }


                int
                f_561_6260_6336(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(561, 6260, 6336);
                    return 0;
                }


                bool
                f_561_6361_6396(Microsoft.CodeAnalysis.StrongNameFileSystem
                this_param, string?
                fullPath)
                {
                    var return_v = this_param.FileExists(fullPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(561, 6361, 6396);
                    return return_v;
                }


                string?
                f_561_6445_6498(string
                path)
                {
                    var return_v = FileUtilities.TryNormalizeAbsolutePath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(561, 6445, 6498);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_561_6101_6119_I(System.Collections.Immutable.ImmutableArray<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(561, 6101, 6119);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(561, 5420, 6572);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(561, 5420, 6572);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual void ReadKeysFromContainer(string keyContainer, out ImmutableArray<byte> publicKey)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(561, 6584, 7102);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 6745, 6784);

                    publicKey = f_561_6757_6783(this, keyContainer);
                }
                catch (ClrStrongNameMissingException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(561, 6813, 6975);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 6954, 6960);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(561, 6813, 6975);
                }
                catch (Exception ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(561, 6989, 7091);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 7042, 7076);

                    throw f_561_7048_7075(f_561_7064_7074(ex));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(561, 6989, 7091);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(561, 6584, 7102);

                System.Collections.Immutable.ImmutableArray<byte>
                f_561_6757_6783(Microsoft.CodeAnalysis.DesktopStrongNameProvider
                this_param, string
                keyContainer)
                {
                    var return_v = this_param.GetPublicKey(keyContainer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(561, 6757, 6783);
                    return return_v;
                }


                string
                f_561_7064_7074(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(561, 7064, 7074);
                    return return_v;
                }


                System.IO.IOException
                f_561_7048_7075(string
                message)
                {
                    var return_v = new System.IO.IOException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(561, 7048, 7075);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(561, 6584, 7102);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(561, 6584, 7102);
            }
        }

        internal override void SignFile(StrongNameKeys keys, string filePath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(561, 7114, 7553);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 7208, 7304);

                f_561_7208_7303(f_561_7221_7259(keys.KeyFilePath) != f_561_7263_7302(keys.KeyContainer));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 7320, 7542) || true) && (!f_561_7325_7363(keys.KeyFilePath))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(561, 7320, 7542);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 7397, 7426);

                    f_561_7397_7425(this, filePath, keys.KeyPair);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(561, 7320, 7542);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(561, 7320, 7542);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 7492, 7527);

                    f_561_7492_7526(this, filePath, keys.KeyContainer!);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(561, 7320, 7542);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(561, 7114, 7553);

                bool
                f_561_7221_7259(string?
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(561, 7221, 7259);
                    return return_v;
                }


                bool
                f_561_7263_7302(string?
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(561, 7263, 7302);
                    return return_v;
                }


                int
                f_561_7208_7303(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(561, 7208, 7303);
                    return 0;
                }


                bool
                f_561_7325_7363(string?
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(561, 7325, 7363);
                    return return_v;
                }


                int
                f_561_7397_7425(Microsoft.CodeAnalysis.DesktopStrongNameProvider
                this_param, string
                filePath, System.Collections.Immutable.ImmutableArray<byte>
                keyPair)
                {
                    this_param.Sign(filePath, keyPair);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(561, 7397, 7425);
                    return 0;
                }


                int
                f_561_7492_7526(Microsoft.CodeAnalysis.DesktopStrongNameProvider
                this_param, string
                filePath, string
                keyName)
                {
                    this_param.Sign(filePath, keyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(561, 7492, 7526);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(561, 7114, 7553);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(561, 7114, 7553);
            }
        }

        internal override void SignBuilder(ExtendedPEBuilder peBuilder, BlobBuilder peBlob, RSAParameters privateKey)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(561, 7565, 7805);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 7699, 7794);

                f_561_7699_7793(peBuilder, peBlob, content => SigningUtilities.CalculateRsaSignature(content, privateKey));
                DynAbs.Tracing.TraceSender.TraceExitMethod(561, 7565, 7805);

                int
                f_561_7699_7793(Microsoft.Cci.ExtendedPEBuilder
                this_param, System.Reflection.Metadata.BlobBuilder
                peImage, System.Func<System.Collections.Generic.IEnumerable<System.Reflection.Metadata.Blob>, byte[]>
                signatureProvider)
                {
                    this_param.Sign(peImage, signatureProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(561, 7699, 7793);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(561, 7565, 7805);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(561, 7565, 7805);
            }
        }

        internal virtual IClrStrongName GetStrongNameInterface()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(561, 8135, 9278);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 8252, 8287);

                    return f_561_8259_8286();
                }
                catch (MarshalDirectiveException) when (f_561_8356_8388())
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(561, 8316, 9267);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 9210, 9252);

                    throw f_561_9216_9251();
                    DynAbs.Tracing.TraceSender.TraceExitCatch(561, 8316, 9267);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(561, 8135, 9278);

                Microsoft.CodeAnalysis.Interop.IClrStrongName
                f_561_8259_8286()
                {
                    var return_v = ClrStrongName.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(561, 8259, 8286);
                    return return_v;
                }


                bool
                f_561_8356_8388()
                {
                    var return_v = PathUtilities.IsUnixLikePlatform;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(561, 8356, 8388);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DesktopStrongNameProvider.ClrStrongNameMissingException
                f_561_9216_9251()
                {
                    var return_v = new Microsoft.CodeAnalysis.DesktopStrongNameProvider.ClrStrongNameMissingException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(561, 9216, 9251);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(561, 8135, 9278);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(561, 8135, 9278);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ImmutableArray<byte> GetPublicKey(string keyContainer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(561, 9290, 9859);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 9378, 9431);

                IClrStrongName
                strongName = f_561_9406_9430(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 9447, 9462);

                IntPtr
                keyBlob
                = default(IntPtr);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 9476, 9497);

                int
                keyBlobByteCount
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 9513, 9619);

                f_561_9513_9618(
                            strongName, keyContainer, pbKeyBlob: default, 0, out keyBlob, out keyBlobByteCount);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 9635, 9678);

                byte[]
                pubKey = new byte[keyBlobByteCount]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 9692, 9743);

                f_561_9692_9742(keyBlob, pubKey, 0, keyBlobByteCount);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 9757, 9798);

                f_561_9757_9797(strongName, keyBlob);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 9814, 9848);

                return f_561_9821_9847(pubKey);
                DynAbs.Tracing.TraceSender.TraceExitMethod(561, 9290, 9859);

                Microsoft.CodeAnalysis.Interop.IClrStrongName
                f_561_9406_9430(Microsoft.CodeAnalysis.DesktopStrongNameProvider
                this_param)
                {
                    var return_v = this_param.GetStrongNameInterface();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(561, 9406, 9430);
                    return return_v;
                }


                int
                f_561_9513_9618(Microsoft.CodeAnalysis.Interop.IClrStrongName
                this_param, string
                pwzKeyContainer, System.IntPtr
                pbKeyBlob, int
                cbKeyBlob, out System.IntPtr
                ppbPublicKeyBlob, out int
                pcbPublicKeyBlob)
                {
                    this_param.StrongNameGetPublicKey(pwzKeyContainer, pbKeyBlob: pbKeyBlob, cbKeyBlob, out ppbPublicKeyBlob, out pcbPublicKeyBlob);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(561, 9513, 9618);
                    return 0;
                }


                int
                f_561_9692_9742(System.IntPtr
                source, byte[]
                destination, int
                startIndex, int
                length)
                {
                    Marshal.Copy(source, destination, startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(561, 9692, 9742);
                    return 0;
                }


                int
                f_561_9757_9797(Microsoft.CodeAnalysis.Interop.IClrStrongName
                this_param, System.IntPtr
                pbMemory)
                {
                    this_param.StrongNameFreeBuffer(pbMemory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(561, 9757, 9797);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_561_9821_9847(byte[]
                items)
                {
                    var return_v = items.AsImmutableOrNull<byte>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(561, 9821, 9847);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(561, 9290, 9859);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(561, 9290, 9859);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void Sign(string filePath, string keyName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(561, 9916, 10527);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 10027, 10080);

                    IClrStrongName
                    strongName = f_561_10055_10079(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 10098, 10205);

                    f_561_10098_10204(strongName, filePath, keyName, IntPtr.Zero, 0, null, pcbSignatureBlob: out _);
                }
                catch (ClrStrongNameMissingException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(561, 10234, 10396);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 10375, 10381);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(561, 10234, 10396);
                }
                catch (Exception ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(561, 10410, 10516);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 10463, 10501);

                    throw f_561_10469_10500(f_561_10485_10495(ex), ex);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(561, 10410, 10516);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(561, 9916, 10527);

                Microsoft.CodeAnalysis.Interop.IClrStrongName
                f_561_10055_10079(Microsoft.CodeAnalysis.DesktopStrongNameProvider
                this_param)
                {
                    var return_v = this_param.GetStrongNameInterface();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(561, 10055, 10079);
                    return return_v;
                }


                int
                f_561_10098_10204(Microsoft.CodeAnalysis.Interop.IClrStrongName
                this_param, string
                pwzFilePath, string
                pwzKeyContainer, System.IntPtr
                pbKeyBlob, int
                cbKeyBlob, byte[]
                ppbSignatureBlob, out int
                pcbSignatureBlob)
                {
                    this_param.StrongNameSignatureGeneration(pwzFilePath, pwzKeyContainer, pbKeyBlob, cbKeyBlob, ppbSignatureBlob, out pcbSignatureBlob);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(561, 10098, 10204);
                    return 0;
                }


                string
                f_561_10485_10495(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(561, 10485, 10495);
                    return return_v;
                }


                System.IO.IOException
                f_561_10469_10500(string
                message, System.Exception
                innerException)
                {
                    var return_v = new System.IO.IOException(message, innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(561, 10469, 10500);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(561, 9916, 10527);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(561, 9916, 10527);
            }
        }

        private unsafe void Sign(string filePath, ImmutableArray<byte> keyPair)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(561, 10539, 11286);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 10671, 10724);

                    IClrStrongName
                    strongName = f_561_10699_10723(this)
                    ;

                    fixed (byte*
    pinned = keyPair.ToArray()
    )
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 10825, 10945);

                        f_561_10825_10944(strongName, filePath, null, pinned, keyPair.Length, null, pcbSignatureBlob: out _);
                    }
                }
                catch (ClrStrongNameMissingException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(561, 10993, 11155);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 11134, 11140);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(561, 10993, 11155);
                }
                catch (Exception ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(561, 11169, 11275);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 11222, 11260);

                    throw f_561_11228_11259(f_561_11244_11254(ex), ex);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(561, 11169, 11275);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(561, 10539, 11286);

                Microsoft.CodeAnalysis.Interop.IClrStrongName
                f_561_10699_10723(Microsoft.CodeAnalysis.DesktopStrongNameProvider
                this_param)
                {
                    var return_v = this_param.GetStrongNameInterface();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(561, 10699, 10723);
                    return return_v;
                }


                unsafe int
                f_561_10825_10944(Microsoft.CodeAnalysis.Interop.IClrStrongName
                this_param, string
                pwzFilePath, string
                pwzKeyContainer, byte*
                pbKeyBlob, int
                cbKeyBlob, byte[]
                ppbSignatureBlob, out int
                pcbSignatureBlob)
                {
                    this_param.StrongNameSignatureGeneration(pwzFilePath, pwzKeyContainer, (System.IntPtr)pbKeyBlob, cbKeyBlob, ppbSignatureBlob, out pcbSignatureBlob);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(561, 10825, 10944);
                    return 0;
                }


                string
                f_561_11244_11254(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(561, 11244, 11254);
                    return return_v;
                }


                System.IO.IOException
                f_561_11228_11259(string
                message, System.Exception
                innerException)
                {
                    var return_v = new System.IO.IOException(message, innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(561, 11228, 11259);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(561, 10539, 11286);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(561, 10539, 11286);
            }
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(561, 11298, 11438);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 11356, 11427);

                return f_561_11363_11426(_keyFileSearchPaths, f_561_11403_11425());
                DynAbs.Tracing.TraceSender.TraceExitMethod(561, 11298, 11438);

                System.StringComparer
                f_561_11403_11425()
                {
                    var return_v = StringComparer.Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(561, 11403, 11425);
                    return return_v;
                }


                int
                f_561_11363_11426(System.Collections.Immutable.ImmutableArray<string>
                values, System.StringComparer
                stringComparer)
                {
                    var return_v = Hash.CombineValues((System.Collections.Generic.IEnumerable<string?>)values, stringComparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(561, 11363, 11426);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(561, 11298, 11438);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(561, 11298, 11438);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(561, 11450, 11997);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 11515, 11622) || true) && (obj is null || (DynAbs.Tracing.TraceSender.Expression_False(561, 11519, 11560) || f_561_11534_11543(this) != f_561_11547_11560(obj)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(561, 11515, 11622);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 11594, 11607);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(561, 11515, 11622);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 11638, 11681);

                var
                other = (DesktopStrongNameProvider)obj
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 11695, 11791) || true) && (f_561_11699_11709() != f_561_11713_11729(other))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(561, 11695, 11791);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 11763, 11776);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(561, 11695, 11791);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 11807, 11958) || true) && (!_keyFileSearchPaths.SequenceEqual(other._keyFileSearchPaths, f_561_11873_11895()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(561, 11807, 11958);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 11930, 11943);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(561, 11807, 11958);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(561, 11974, 11986);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(561, 11450, 11997);

                System.Type
                f_561_11534_11543(Microsoft.CodeAnalysis.DesktopStrongNameProvider
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(561, 11534, 11543);
                    return return_v;
                }


                System.Type
                f_561_11547_11560(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(561, 11547, 11560);
                    return return_v;
                }


                Microsoft.CodeAnalysis.StrongNameFileSystem
                f_561_11699_11709()
                {
                    var return_v = FileSystem;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(561, 11699, 11709);
                    return return_v;
                }


                Microsoft.CodeAnalysis.StrongNameFileSystem
                f_561_11713_11729(Microsoft.CodeAnalysis.DesktopStrongNameProvider
                this_param)
                {
                    var return_v = this_param.FileSystem;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(561, 11713, 11729);
                    return return_v;
                }


                System.StringComparer
                f_561_11873_11895()
                {
                    var return_v = StringComparer.Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(561, 11873, 11895);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(561, 11450, 11997);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(561, 11450, 11997);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static DesktopStrongNameProvider()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(561, 663, 12004);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(561, 663, 12004);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(561, 663, 12004);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(561, 663, 12004);

        static System.Collections.Immutable.ImmutableArray<string>
        f_561_1647_1665_C(System.Collections.Immutable.ImmutableArray<string>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(561, 1564, 1719);
            return return_v;
        }


        static Microsoft.CodeAnalysis.StrongNameFileSystem
        f_561_2300_2334(string
        customTempPath)
        {
            var return_v = new Microsoft.CodeAnalysis.StrongNameFileSystem(customTempPath);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(561, 2300, 2334);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<string>
        f_561_2229_2247_C(System.Collections.Immutable.ImmutableArray<string>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(561, 2099, 2359);
            return return_v;
        }


        bool
        f_561_2520_2549_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(561, 2520, 2549);
            return return_v;
        }


        static string
        f_561_2678_2720()
        {
            var return_v = CodeAnalysisResources.AbsolutePathExpected;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(561, 2678, 2720);
            return return_v;
        }


        static System.ArgumentException
        f_561_2656_2749(string
        message, string
        paramName)
        {
            var return_v = new System.ArgumentException(message, paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(561, 2656, 2749);
            return return_v;
        }

    }
}
