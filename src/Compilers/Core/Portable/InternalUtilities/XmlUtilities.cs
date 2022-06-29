// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace Roslyn.Utilities
{
    internal static class XmlUtilities
    {
        internal static TNode Copy<TNode>(this TNode node, bool copyAttributeAnnotations)
                    where TNode : XNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(398, 436, 2348);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(398, 575, 586);

                XNode
                copy
                = default(XNode);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(398, 694, 1046) || true) && (f_398_698_711(node) == XmlNodeType.Document)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(398, 694, 1046);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(398, 769, 817);

                    copy = f_398_776_816(((XDocument)(object)node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(398, 694, 1046);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(398, 694, 1046);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(398, 883, 922);

                    XContainer
                    temp = f_398_901_921("temp")
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(398, 940, 955);

                    f_398_940_954(temp, node);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(398, 973, 994);

                    copy = f_398_980_993(temp);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(398, 1012, 1031);

                    f_398_1012_1030(temp);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(398, 694, 1046);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(398, 1062, 1089);

                f_398_1062_1088(copy != node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(398, 1103, 1137);

                f_398_1103_1136(f_398_1116_1127(copy) == null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(398, 1369, 1397);

                f_398_1369_1396(node, copy);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(398, 1564, 2302) || true) && (copyAttributeAnnotations && (DynAbs.Tracing.TraceSender.Expression_True(398, 1568, 1632) && f_398_1596_1609(node) == XmlNodeType.Element))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(398, 1564, 2302);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(398, 1666, 1711);

                    var
                    sourceElement = ((XElement)(object)node)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(398, 1729, 1766);

                    var
                    targetElement = ((XElement)copy)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(398, 1786, 1872);

                    IEnumerator<XAttribute>
                    sourceAttributes = f_398_1829_1871(f_398_1829_1855(sourceElement))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(398, 1890, 1976);

                    IEnumerator<XAttribute>
                    targetAttributes = f_398_1933_1975(f_398_1933_1959(targetElement))
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(398, 1994, 2287) || true) && (f_398_2001_2028(sourceAttributes) && (DynAbs.Tracing.TraceSender.Expression_True(398, 2001, 2059) && f_398_2032_2059(targetAttributes)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(398, 1994, 2287);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(398, 2101, 2178);

                            f_398_2101_2177(f_398_2114_2143(f_398_2114_2138(sourceAttributes)) == f_398_2147_2176(f_398_2147_2171(targetAttributes)));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(398, 2200, 2268);

                            f_398_2200_2267(f_398_2216_2240(sourceAttributes), f_398_2242_2266(targetAttributes));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(398, 1994, 2287);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(398, 1994, 2287);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(398, 1994, 2287);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(398, 1564, 2302);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(398, 2318, 2337);

                return (TNode)copy;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(398, 436, 2348);

                System.Xml.XmlNodeType
                f_398_698_711(TNode
                this_param)
                {
                    var return_v = this_param.NodeType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(398, 698, 711);
                    return return_v;
                }


                System.Xml.Linq.XDocument
                f_398_776_816(object
                other)
                {
                    var return_v = new System.Xml.Linq.XDocument((System.Xml.Linq.XDocument)other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(398, 776, 816);
                    return return_v;
                }


                System.Xml.Linq.XElement
                f_398_901_921(string
                name)
                {
                    var return_v = new System.Xml.Linq.XElement((System.Xml.Linq.XName)name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(398, 901, 921);
                    return return_v;
                }


                int
                f_398_940_954(System.Xml.Linq.XContainer
                this_param, TNode
                content)
                {
                    this_param.Add((object)content);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(398, 940, 954);
                    return 0;
                }


                System.Xml.Linq.XNode
                f_398_980_993(System.Xml.Linq.XContainer
                this_param)
                {
                    var return_v = this_param.LastNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(398, 980, 993);
                    return return_v;
                }


                int
                f_398_1012_1030(System.Xml.Linq.XContainer
                this_param)
                {
                    this_param.RemoveNodes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(398, 1012, 1030);
                    return 0;
                }


                int
                f_398_1062_1088(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(398, 1062, 1088);
                    return 0;
                }


                System.Xml.Linq.XElement
                f_398_1116_1127(System.Xml.Linq.XNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(398, 1116, 1127);
                    return return_v;
                }


                int
                f_398_1103_1136(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(398, 1103, 1136);
                    return 0;
                }


                int
                f_398_1369_1396(TNode
                source, System.Xml.Linq.XNode
                target)
                {
                    CopyAnnotations((System.Xml.Linq.XObject)source, (System.Xml.Linq.XObject)target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(398, 1369, 1396);
                    return 0;
                }


                System.Xml.XmlNodeType
                f_398_1596_1609(TNode
                this_param)
                {
                    var return_v = this_param.NodeType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(398, 1596, 1609);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute>
                f_398_1829_1855(System.Xml.Linq.XElement
                this_param)
                {
                    var return_v = this_param.Attributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(398, 1829, 1855);
                    return return_v;
                }


                System.Collections.Generic.IEnumerator<System.Xml.Linq.XAttribute>
                f_398_1829_1871(System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(398, 1829, 1871);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute>
                f_398_1933_1959(System.Xml.Linq.XElement
                this_param)
                {
                    var return_v = this_param.Attributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(398, 1933, 1959);
                    return return_v;
                }


                System.Collections.Generic.IEnumerator<System.Xml.Linq.XAttribute>
                f_398_1933_1975(System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(398, 1933, 1975);
                    return return_v;
                }


                bool
                f_398_2001_2028(System.Collections.Generic.IEnumerator<System.Xml.Linq.XAttribute>
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(398, 2001, 2028);
                    return return_v;
                }


                bool
                f_398_2032_2059(System.Collections.Generic.IEnumerator<System.Xml.Linq.XAttribute>
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(398, 2032, 2059);
                    return return_v;
                }


                System.Xml.Linq.XAttribute
                f_398_2114_2138(System.Collections.Generic.IEnumerator<System.Xml.Linq.XAttribute>
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(398, 2114, 2138);
                    return return_v;
                }


                System.Xml.Linq.XName
                f_398_2114_2143(System.Xml.Linq.XAttribute
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(398, 2114, 2143);
                    return return_v;
                }


                System.Xml.Linq.XAttribute
                f_398_2147_2171(System.Collections.Generic.IEnumerator<System.Xml.Linq.XAttribute>
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(398, 2147, 2171);
                    return return_v;
                }


                System.Xml.Linq.XName
                f_398_2147_2176(System.Xml.Linq.XAttribute
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(398, 2147, 2176);
                    return return_v;
                }


                int
                f_398_2101_2177(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(398, 2101, 2177);
                    return 0;
                }


                System.Xml.Linq.XAttribute
                f_398_2216_2240(System.Collections.Generic.IEnumerator<System.Xml.Linq.XAttribute>
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(398, 2216, 2240);
                    return return_v;
                }


                System.Xml.Linq.XAttribute
                f_398_2242_2266(System.Collections.Generic.IEnumerator<System.Xml.Linq.XAttribute>
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(398, 2242, 2266);
                    return return_v;
                }


                int
                f_398_2200_2267(System.Xml.Linq.XAttribute
                source, System.Xml.Linq.XAttribute
                target)
                {
                    CopyAnnotations((System.Xml.Linq.XObject)source, (System.Xml.Linq.XObject)target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(398, 2200, 2267);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(398, 436, 2348);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(398, 436, 2348);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void CopyAnnotations(XObject source, XObject target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(398, 2360, 2600);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(398, 2452, 2589);
                    foreach (var annotation in f_398_2479_2507_I(f_398_2479_2507(source)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(398, 2452, 2589);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(398, 2541, 2574);

                        f_398_2541_2573(target, annotation);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(398, 2452, 2589);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(398, 1, 138);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(398, 1, 138);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(398, 2360, 2600);

                System.Collections.Generic.IEnumerable<object>
                f_398_2479_2507(System.Xml.Linq.XObject
                this_param)
                {
                    var return_v = this_param.Annotations<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(398, 2479, 2507);
                    return return_v;
                }


                int
                f_398_2541_2573(System.Xml.Linq.XObject
                this_param, object
                annotation)
                {
                    this_param.AddAnnotation(annotation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(398, 2541, 2573);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<object>
                f_398_2479_2507_I(System.Collections.Generic.IEnumerable<object>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(398, 2479, 2507);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(398, 2360, 2600);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(398, 2360, 2600);
            }
        }

        internal static XElement[]? TrySelectElements(XNode node, string xpath, out string? errorMessage, out bool invalidXPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(398, 2612, 3562);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(398, 2757, 2777);

                errorMessage = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(398, 2791, 2812);

                invalidXPath = false;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(398, 2864, 2943);

                    var
                    xpathResult = f_398_2882_2942(node, xpath)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(398, 3087, 3145);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(398, 3094, 3113) || ((xpathResult != null && DynAbs.Tracing.TraceSender.Conditional_F2(398, 3116, 3137)) || DynAbs.Tracing.TraceSender.Conditional_F3(398, 3140, 3144))) ? f_398_3116_3137(xpathResult) : null;
                }
                catch (InvalidOperationException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(398, 3174, 3312);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(398, 3242, 3267);

                    errorMessage = f_398_3257_3266(e);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(398, 3285, 3297);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(398, 3174, 3312);
                }
                catch (Exception e) when (f_398_3352_3372(f_398_3352_3363(e)) == "System.Xml.XPath.XPathException")
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(398, 3326, 3551);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(398, 3443, 3468);

                    errorMessage = f_398_3458_3467(e);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(398, 3486, 3506);

                    invalidXPath = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(398, 3524, 3536);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(398, 3326, 3551);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(398, 2612, 3562);

                System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>
                f_398_2882_2942(System.Xml.Linq.XNode
                node, string
                expression)
                {
                    var return_v = System.Xml.XPath.Extensions.XPathSelectElements(node, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(398, 2882, 2942);
                    return return_v;
                }


                System.Xml.Linq.XElement[]
                f_398_3116_3137(System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>
                source)
                {
                    var return_v = source.ToArray<System.Xml.Linq.XElement>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(398, 3116, 3137);
                    return return_v;
                }


                string
                f_398_3257_3266(System.InvalidOperationException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(398, 3257, 3266);
                    return return_v;
                }


                System.Type
                f_398_3352_3363(System.Exception
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(398, 3352, 3363);
                    return return_v;
                }


                string?
                f_398_3352_3372(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(398, 3352, 3372);
                    return return_v;
                }


                string
                f_398_3458_3467(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(398, 3458, 3467);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(398, 2612, 3562);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(398, 2612, 3562);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static XmlUtilities()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(398, 385, 3569);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(398, 385, 3569);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(398, 385, 3569);
        }

    }
}
