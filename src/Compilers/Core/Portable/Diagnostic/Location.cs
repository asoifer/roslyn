// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Microsoft.CodeAnalysis.Symbols;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis
{
    [DebuggerDisplay("{GetDebuggerDisplay(), nq}")]
    public abstract class Location
    {
        internal Location()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(194, 591, 632);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(194, 591, 632);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(194, 591, 632);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(194, 591, 632);
            }
        }

        public abstract LocationKind Kind { get; }

        [MemberNotNullWhen(true, nameof(SourceTree))]
        public bool IsInSource
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(194, 1027, 1061);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(194, 1033, 1059);

                    return f_194_1040_1050() != null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(194, 1027, 1061);

                    Microsoft.CodeAnalysis.SyntaxTree?
                    f_194_1040_1050()
                    {
                        var return_v = SourceTree;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(194, 1040, 1050);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(194, 947, 1063);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(194, 947, 1063);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsInMetadata
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(194, 1207, 1253);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(194, 1213, 1251);

                    return f_194_1220_1242() != null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(194, 1207, 1253);

                    Microsoft.CodeAnalysis.Symbols.IModuleSymbolInternal?
                    f_194_1220_1242()
                    {
                        var return_v = MetadataModuleInternal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(194, 1220, 1242);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(194, 1180, 1255);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(194, 1180, 1255);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual SyntaxTree? SourceTree
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(194, 1451, 1471);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(194, 1457, 1469);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(194, 1451, 1471);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(194, 1411, 1473);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(194, 1411, 1473);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public IModuleSymbol? MetadataModule
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(194, 1943, 2011);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(194, 1949, 2009);

                    return (IModuleSymbol?)f_194_1972_2008_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_194_1972_1994(), 194, 1972, 2008)?.GetISymbol());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(194, 1943, 2011);

                    Microsoft.CodeAnalysis.Symbols.IModuleSymbolInternal?
                    f_194_1972_1994()
                    {
                        var return_v = MetadataModuleInternal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(194, 1972, 1994);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ISymbol?
                    f_194_1972_2008_I(Microsoft.CodeAnalysis.ISymbol?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(194, 1972, 2008);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(194, 1904, 2013);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(194, 1904, 2013);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual IModuleSymbolInternal? MetadataModuleInternal
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(194, 2090, 2110);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(194, 2096, 2108);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(194, 2090, 2110);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(194, 2025, 2112);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(194, 2025, 2112);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual TextSpan SourceSpan
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(194, 2478, 2511);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(194, 2484, 2509);

                    return default(TextSpan);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(194, 2478, 2511);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(194, 2441, 2513);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(194, 2441, 2513);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual FileLinePositionSpan GetLineSpan()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(194, 3041, 3163);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(194, 3115, 3152);

                return default(FileLinePositionSpan);
                DynAbs.Tracing.TraceSender.TraceExitMethod(194, 3041, 3163);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(194, 3041, 3163);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(194, 3041, 3163);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual FileLinePositionSpan GetMappedLineSpan()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(194, 3643, 3771);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(194, 3723, 3760);

                return default(FileLinePositionSpan);
                DynAbs.Tracing.TraceSender.TraceExitMethod(194, 3643, 3771);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(194, 3643, 3771);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(194, 3643, 3771);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public abstract override bool Equals(object? obj);

        public abstract override int GetHashCode();

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(194, 3967, 4888);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(194, 4025, 4057);

                string
                result = f_194_4041_4056(f_194_4041_4045())
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(194, 4071, 4847) || true) && (f_194_4075_4085())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(194, 4071, 4847);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(194, 4119, 4185);

                    result += "(" + f_194_4135_4160_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_194_4135_4150(this), 194, 4135, 4160)?.FilePath) + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (f_194_4163_4178(this)).ToString(), 194, 4163, 4178) + ")";
                    DynAbs.Tracing.TraceSender.TraceExitCondition(194, 4071, 4847);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(194, 4071, 4847);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(194, 4219, 4847) || true) && (f_194_4223_4235())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(194, 4219, 4847);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(194, 4269, 4424) || true) && (f_194_4273_4300(this) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(194, 4269, 4424);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(194, 4350, 4405);

                            result += "(" + f_194_4366_4398(f_194_4366_4393(this)) + ")";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(194, 4269, 4424);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(194, 4219, 4847);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(194, 4219, 4847);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(194, 4490, 4514);

                        var
                        pos = f_194_4500_4513(this)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(194, 4532, 4832) || true) && (pos.Path != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(194, 4532, 4832);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(194, 4695, 4813);

                            result += "(" + pos.Path + "@" + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => ((pos.StartLinePosition.Line + 1)).ToString(), 194, 4728, 4760) + ":" + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => ((pos.StartLinePosition.Character + 1)).ToString(), 194, 4769, 4806) + ")";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(194, 4532, 4832);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(194, 4219, 4847);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(194, 4071, 4847);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(194, 4863, 4877);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(194, 3967, 4888);

                Microsoft.CodeAnalysis.LocationKind
                f_194_4041_4045()
                {
                    var return_v = Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(194, 4041, 4045);
                    return return_v;
                }


                string
                f_194_4041_4056(Microsoft.CodeAnalysis.LocationKind
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(194, 4041, 4056);
                    return return_v;
                }


                bool
                f_194_4075_4085()
                {
                    var return_v = IsInSource;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(194, 4075, 4085);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_194_4135_4150(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.SourceTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(194, 4135, 4150);
                    return return_v;
                }


                string?
                f_194_4135_4160_M(string?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(194, 4135, 4160);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_194_4163_4178(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.SourceSpan;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(194, 4163, 4178);
                    return return_v;
                }


                bool
                f_194_4223_4235()
                {
                    var return_v = IsInMetadata;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(194, 4223, 4235);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Symbols.IModuleSymbolInternal?
                f_194_4273_4300(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.MetadataModuleInternal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(194, 4273, 4300);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Symbols.IModuleSymbolInternal
                f_194_4366_4393(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.MetadataModuleInternal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(194, 4366, 4393);
                    return return_v;
                }


                string
                f_194_4366_4398(Microsoft.CodeAnalysis.Symbols.IModuleSymbolInternal
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(194, 4366, 4398);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FileLinePositionSpan
                f_194_4500_4513(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.GetLineSpan();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(194, 4500, 4513);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(194, 3967, 4888);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(194, 3967, 4888);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool operator ==(Location? left, Location? right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(194, 4900, 5171);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(194, 4988, 5118) || true) && (f_194_4992_5026(left, null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(194, 4988, 5118);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(194, 5060, 5103);

                    return f_194_5067_5102(right, null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(194, 4988, 5118);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(194, 5134, 5160);

                return f_194_5141_5159(left, right);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(194, 4900, 5171);

                bool
                f_194_4992_5026(Microsoft.CodeAnalysis.Location?
                objA, object?
                objB)
                {
                    var return_v = object.ReferenceEquals((object?)objA, objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(194, 4992, 5026);
                    return return_v;
                }


                bool
                f_194_5067_5102(Microsoft.CodeAnalysis.Location?
                objA, object?
                objB)
                {
                    var return_v = object.ReferenceEquals((object?)objA, objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(194, 5067, 5102);
                    return return_v;
                }


                bool
                f_194_5141_5159(Microsoft.CodeAnalysis.Location
                this_param, Microsoft.CodeAnalysis.Location?
                obj)
                {
                    var return_v = this_param.Equals((object?)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(194, 5141, 5159);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(194, 4900, 5171);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(194, 4900, 5171);
            }
        }

        public static bool operator !=(Location? left, Location? right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(194, 5183, 5306);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(194, 5271, 5295);

                return !(left == right);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(194, 5183, 5306);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(194, 5183, 5306);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(194, 5183, 5306);
            }
        }

        protected virtual string GetDebuggerDisplay()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(194, 5318, 5801);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(194, 5388, 5424);

                string
                result = f_194_5404_5423(f_194_5404_5418(this))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(194, 5438, 5462);

                var
                pos = f_194_5448_5461(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(194, 5476, 5760) || true) && (pos.Path != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(194, 5476, 5760);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(194, 5627, 5745);

                    result += "(" + pos.Path + "@" + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => ((pos.StartLinePosition.Line + 1)).ToString(), 194, 5660, 5692) + ":" + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => ((pos.StartLinePosition.Character + 1)).ToString(), 194, 5701, 5738) + ")";
                    DynAbs.Tracing.TraceSender.TraceExitCondition(194, 5476, 5760);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(194, 5776, 5790);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(194, 5318, 5801);

                System.Type
                f_194_5404_5418(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(194, 5404, 5418);
                    return return_v;
                }


                string
                f_194_5404_5423(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(194, 5404, 5423);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FileLinePositionSpan
                f_194_5448_5461(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.GetLineSpan();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(194, 5448, 5461);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(194, 5318, 5801);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(194, 5318, 5801);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Location None
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(194, 5942, 5978);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(194, 5948, 5976);

                    return NoLocation.Singleton;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(194, 5942, 5978);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(194, 5912, 5980);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(194, 5912, 5980);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static Location Create(SyntaxTree syntaxTree, TextSpan textSpan)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(194, 6142, 6436);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(194, 6238, 6361) || true) && (syntaxTree == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(194, 6238, 6361);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(194, 6294, 6346);

                    throw f_194_6300_6345(nameof(syntaxTree));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(194, 6238, 6361);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(194, 6377, 6425);

                return f_194_6384_6424(syntaxTree, textSpan);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(194, 6142, 6436);

                System.ArgumentNullException
                f_194_6300_6345(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(194, 6300, 6345);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceLocation
                f_194_6384_6424(Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = new Microsoft.CodeAnalysis.SourceLocation(syntaxTree, span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(194, 6384, 6424);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(194, 6142, 6436);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(194, 6142, 6436);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Location Create(string filePath, TextSpan textSpan, LinePositionSpan lineSpan)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(194, 6578, 6903);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(194, 6695, 6814) || true) && (filePath == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(194, 6695, 6814);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(194, 6749, 6799);

                    throw f_194_6755_6798(nameof(filePath));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(194, 6695, 6814);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(194, 6830, 6892);

                return f_194_6837_6891(filePath, textSpan, lineSpan);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(194, 6578, 6903);

                System.ArgumentNullException
                f_194_6755_6798(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(194, 6755, 6798);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ExternalFileLocation
                f_194_6837_6891(string
                filePath, Microsoft.CodeAnalysis.Text.TextSpan
                sourceSpan, Microsoft.CodeAnalysis.Text.LinePositionSpan
                lineSpan)
                {
                    var return_v = new Microsoft.CodeAnalysis.ExternalFileLocation(filePath, sourceSpan, lineSpan);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(194, 6837, 6891);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(194, 6578, 6903);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(194, 6578, 6903);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static Location()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(194, 491, 6910);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(194, 491, 6910);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(194, 491, 6910);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(194, 491, 6910);
    }
}
