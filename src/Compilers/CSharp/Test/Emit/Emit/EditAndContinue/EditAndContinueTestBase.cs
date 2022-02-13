// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp.Test.Utilities;
using Microsoft.CodeAnalysis.CSharp.UnitTests;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.Test.Utilities;
using Microsoft.Metadata.Tools;
using Roslyn.Test.Utilities;
using Roslyn.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests
{
public abstract class EditAndContinueTestBase : EmitMetadataTestBase
{
protected readonly CSharpCompilationOptions ComSafeDebugDll ;

internal static readonly Func<MethodDefinitionHandle, EditAndContinueMethodDebugInformation> EmptyLocalsProvider ;

internal static string Visualize(ModuleMetadata baseline, params PinnedMetadata[] deltas)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23108,1374,1723);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,1488,1520);

var 
result = f_23108_1501_1519()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,1534,1673);

f_23108_1534_1672(f_23108_1534_1646(f_23108_1557_1637(f_23108_1557_1627(new[] { f_23108_1565_1588(baseline)}, f_23108_1598_1626(deltas, d => d.Reader))), result));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,1687,1712);

return f_23108_1694_1711(result);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23108,1374,1723);

System.IO.StringWriter
f_23108_1501_1519()
{
var return_v = new System.IO.StringWriter();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23108, 1501, 1519);
return return_v;
}


System.Reflection.Metadata.MetadataReader
f_23108_1565_1588(Microsoft.CodeAnalysis.ModuleMetadata
this_param)
{
var return_v = this_param.MetadataReader ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23108, 1565, 1588);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Reflection.Metadata.MetadataReader>
f_23108_1598_1626(Roslyn.Test.Utilities.PinnedMetadata[]
source,System.Func<Roslyn.Test.Utilities.PinnedMetadata, System.Reflection.Metadata.MetadataReader>
selector)
{
var return_v = source.Select<Roslyn.Test.Utilities.PinnedMetadata,System.Reflection.Metadata.MetadataReader>( selector);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23108, 1598, 1626);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Reflection.Metadata.MetadataReader>
f_23108_1557_1627(System.Reflection.Metadata.MetadataReader[]
first,System.Collections.Generic.IEnumerable<System.Reflection.Metadata.MetadataReader>
second)
{
var return_v = first.Concat<System.Reflection.Metadata.MetadataReader>( second);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23108, 1557, 1627);
return return_v;
}


System.Reflection.Metadata.MetadataReader[]
f_23108_1557_1637(System.Collections.Generic.IEnumerable<System.Reflection.Metadata.MetadataReader>
source)
{
var return_v = source.ToArray<System.Reflection.Metadata.MetadataReader>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23108, 1557, 1637);
return return_v;
}


Microsoft.Metadata.Tools.MetadataVisualizer
f_23108_1534_1646(System.Reflection.Metadata.MetadataReader[]
readers,System.IO.StringWriter
writer)
{
var return_v = new Microsoft.Metadata.Tools.MetadataVisualizer( (System.Collections.Generic.IReadOnlyList<System.Reflection.Metadata.MetadataReader>)readers, (System.IO.TextWriter)writer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23108, 1534, 1646);
return return_v;
}


int
f_23108_1534_1672(Microsoft.Metadata.Tools.MetadataVisualizer
this_param)
{
this_param.VisualizeAllGenerations();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23108, 1534, 1672);
return 0;
}


string
f_23108_1694_1711(System.IO.StringWriter
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23108, 1694, 1711);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23108,1374,1723);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23108,1374,1723);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static SourceWithMarkedNodes MarkedSource(string markedSource, string fileName = "", CSharpParseOptions options = null, bool removeTags = false)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23108,1735,2086);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,1913,2075);

return f_23108_1920_2074(markedSource, s => Parse(s, fileName, options), s => (int)(SyntaxKind)typeof(SyntaxKind).GetField(s).GetValue(null), removeTags);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23108,1735,2086);

Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23108_1920_2074(string
markedSource,System.Func<string, Microsoft.CodeAnalysis.SyntaxTree>
parser,System.Func<string, int>
getSyntaxKind,bool
removeTags)
{
var return_v = new Roslyn.Test.Utilities.SourceWithMarkedNodes( markedSource, parser, getSyntaxKind, removeTags);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23108, 1920, 2074);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23108,1735,2086);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23108,1735,2086);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static Func<SyntaxNode, SyntaxNode> GetSyntaxMapFromMarkers(SourceWithMarkedNodes source0, SourceWithMarkedNodes source1)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23108,2098,2324);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,2253,2313);

return f_23108_2260_2312(source0, source1);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23108,2098,2324);

System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23108_2260_2312(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = SourceWithMarkedNodes.GetSyntaxMap( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23108, 2260, 2312);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23108,2098,2324);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23108,2098,2324);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static ImmutableArray<SyntaxNode> GetAllLocals(MethodSymbol method)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23108,2336,2715);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,2437,2491);

var 
sourceMethod = method as SourceMemberMethodSymbol
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,2505,2618) || true) && (sourceMethod == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(23108,2505,2618);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,2563,2603);

return ImmutableArray<SyntaxNode>.Empty;
DynAbs.Tracing.TraceSender.TraceExitCondition(23108,2505,2618);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,2634,2704);

return f_23108_2641_2703(sourceMethod);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23108,2336,2715);

System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxNode>
f_23108_2641_2703(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
method)
{
var return_v = LocalVariableDeclaratorsCollector.GetDeclarators( method);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23108, 2641, 2703);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23108,2336,2715);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23108,2336,2715);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static Func<SyntaxNode, SyntaxNode> GetSyntaxMapByKind(MethodSymbol method0, params SyntaxKind[] kinds)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23108,2727,3281);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,2864,3270);

return newNode =>
            {
                foreach (SyntaxKind kind in kinds)
                {
                    if (newNode.IsKind(kind))
                    {
                        return method0.DeclaringSyntaxReferences.Single().SyntaxTree.GetRoot().DescendantNodes().Single(n => n.IsKind(kind));
                    }
                }

                return null;
            };
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23108,2727,3281);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23108,2727,3281);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23108,2727,3281);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static Func<SyntaxNode, SyntaxNode> GetEquivalentNodesMap(MethodSymbol method1, MethodSymbol method0)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23108,3293,4360);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,3428,3472);

var 
tree1 = f_23108_3440_3471(f_23108_3440_3457(method1)[0])
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,3486,3530);

var 
tree0 = f_23108_3498_3529(f_23108_3498_3515(method0)[0])
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,3544,3574);

f_23108_3544_3573(tree1, tree0);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,3590,3626);

var 
locals0 = f_23108_3604_3625(method0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,3640,4349);

return s =>
            {
                var s1 = s;
                Assert.Equal(s1.SyntaxTree, tree1);
                foreach (var s0 in locals0)
                {
                    if (!SyntaxFactory.AreEquivalent(s0, s1))
                    {
                        continue;
                    }
                    // Make sure the containing statements are the same.
                    var p0 = GetNearestStatement(s0);
                    var p1 = GetNearestStatement(s1);
                    if (SyntaxFactory.AreEquivalent(p0, p1))
                    {
                        return s0;
                    }
                }
                return null;
            };
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23108,3293,4360);

System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
f_23108_3440_3457(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.Locations;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23108, 3440, 3457);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxTree?
f_23108_3440_3471(Microsoft.CodeAnalysis.Location
this_param)
{
var return_v = this_param.SourceTree;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23108, 3440, 3471);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
f_23108_3498_3515(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.Locations;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23108, 3498, 3515);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxTree?
f_23108_3498_3529(Microsoft.CodeAnalysis.Location
this_param)
{
var return_v = this_param.SourceTree;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23108, 3498, 3529);
return return_v;
}


int
f_23108_3544_3573(Microsoft.CodeAnalysis.SyntaxTree?
expected,Microsoft.CodeAnalysis.SyntaxTree?
actual)
{
Assert.NotEqual( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23108, 3544, 3573);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxNode>
f_23108_3604_3625(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method)
{
var return_v = GetAllLocals( method);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23108, 3604, 3625);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23108,3293,4360);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23108,3293,4360);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static string GetLocalName(SyntaxNode node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23108,4372,4731);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,4449,4720);

switch (f_23108_4457_4468(node))
            {

case SyntaxKind.VariableDeclarator:
DynAbs.Tracing.TraceSender.TraceEnterCondition(23108,4449,4720);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,4559,4621);

return ((VariableDeclaratorSyntax)node).Identifier.ToString();
DynAbs.Tracing.TraceSender.TraceExitCondition(23108,4449,4720);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(23108,4449,4720);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,4669,4705);

throw f_23108_4675_4704();
DynAbs.Tracing.TraceSender.TraceExitCondition(23108,4449,4720);
            }
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23108,4372,4731);

Microsoft.CodeAnalysis.CSharp.SyntaxKind
f_23108_4457_4468(Microsoft.CodeAnalysis.SyntaxNode
node)
{
var return_v = node.Kind();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23108, 4457, 4468);
return return_v;
}


System.NotImplementedException
f_23108_4675_4704()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23108, 4675, 4704);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23108,4372,4731);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23108,4372,4731);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static StatementSyntax GetNearestStatement(SyntaxNode node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23108,4743,5135);
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,4836,5098) || true) && (node != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(23108,4836,5098);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,4889,4929);

var 
statement = node as StatementSyntax
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,4947,5046) || true) && (statement != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(23108,4947,5046);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,5010,5027);

return statement;
DynAbs.Tracing.TraceSender.TraceExitCondition(23108,4947,5046);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,5064,5083);

node = f_23108_5071_5082(node);
DynAbs.Tracing.TraceSender.TraceExitCondition(23108,4836,5098);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(23108,4836,5098);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(23108,4836,5098);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,5112,5124);

return null;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23108,4743,5135);

Microsoft.CodeAnalysis.SyntaxNode?
f_23108_5071_5082(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23108, 5071, 5082);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23108,4743,5135);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23108,4743,5135);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static EditAndContinueLogEntry Row(int rowNumber, TableIndex table, EditAndContinueOperation operation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23108,5147,5382);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,5284,5371);

return f_23108_5291_5370(f_23108_5319_5358(table, rowNumber), operation);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23108,5147,5382);

System.Reflection.Metadata.EntityHandle
f_23108_5319_5358(System.Reflection.Metadata.Ecma335.TableIndex
tableIndex,int
rowNumber)
{
var return_v = MetadataTokens.Handle( tableIndex, rowNumber);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23108, 5319, 5358);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23108_5291_5370(System.Reflection.Metadata.EntityHandle
handle,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = new System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry( handle, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23108, 5291, 5370);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23108,5147,5382);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23108,5147,5382);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static EntityHandle Handle(int rowNumber, TableIndex table)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23108,5394,5545);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,5487,5534);

return f_23108_5494_5533(table, rowNumber);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23108,5394,5545);

System.Reflection.Metadata.EntityHandle
f_23108_5494_5533(System.Reflection.Metadata.Ecma335.TableIndex
tableIndex,int
rowNumber)
{
var return_v = MetadataTokens.Handle( tableIndex, rowNumber);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23108, 5494, 5533);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23108,5394,5545);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23108,5394,5545);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static void CheckEncLog(MetadataReader reader, params EditAndContinueLogEntry[] rows)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23108,5557,5781);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,5676,5770);

f_23108_5676_5769(rows, f_23108_5697_5734(reader), itemInspector: EncLogRowToString);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23108,5557,5781);

System.Collections.Generic.IEnumerable<System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry>
f_23108_5697_5734(System.Reflection.Metadata.MetadataReader
reader)
{
var return_v = reader.GetEditAndContinueLogEntries();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23108, 5697, 5734);
return return_v;
}


bool
f_23108_5676_5769(System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry[]
expected,System.Collections.Generic.IEnumerable<System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry>
actual,System.Func<System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry, string>
itemInspector)
{
var return_v = AssertEx.Equal( (System.Collections.Generic.IEnumerable<System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry>)expected, actual, itemInspector:itemInspector);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23108, 5676, 5769);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23108,5557,5781);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23108,5557,5781);
}
		}

internal static void CheckEncLogDefinitions(MetadataReader reader, params EditAndContinueLogEntry[] rows)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23108,5793,6048);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,5923,6037);

f_23108_5923_6036(rows, f_23108_5944_6001(f_23108_5944_5981(reader), IsDefinition), itemInspector: EncLogRowToString);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23108,5793,6048);

System.Collections.Generic.IEnumerable<System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry>
f_23108_5944_5981(System.Reflection.Metadata.MetadataReader
reader)
{
var return_v = reader.GetEditAndContinueLogEntries();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23108, 5944, 5981);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry>
f_23108_5944_6001(System.Collections.Generic.IEnumerable<System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry>
source,System.Func<System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry, bool>
predicate)
{
var return_v = source.Where<System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry>( predicate);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23108, 5944, 6001);
return return_v;
}


bool
f_23108_5923_6036(System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry[]
expected,System.Collections.Generic.IEnumerable<System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry>
actual,System.Func<System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry, string>
itemInspector)
{
var return_v = AssertEx.Equal( (System.Collections.Generic.IEnumerable<System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry>)expected, actual, itemInspector:itemInspector);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23108, 5923, 6036);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23108,5793,6048);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23108,5793,6048);
}
		}

private static bool IsDefinition(EditAndContinueLogEntry entry)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23108,6060,7609);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,6148,6165);

TableIndex 
index
=default(TableIndex);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,6179,6254);

f_23108_6179_6253(f_23108_6191_6252(entry.Handle.Kind, out index));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,6270,7569);

switch (index)
            {

case TableIndex.MethodDef:
                case TableIndex.Field:
                case TableIndex.Constant:
                case TableIndex.GenericParam:
                case TableIndex.GenericParamConstraint:
                case TableIndex.Event:
                case TableIndex.CustomAttribute:
                case TableIndex.DeclSecurity:
                case TableIndex.Assembly:
                case TableIndex.MethodImpl:
                case TableIndex.Param:
                case TableIndex.Property:
                case TableIndex.TypeDef:
                case TableIndex.ExportedType:
                case TableIndex.StandAloneSig:
                case TableIndex.ClassLayout:
                case TableIndex.FieldLayout:
                case TableIndex.FieldMarshal:
                case TableIndex.File:
                case TableIndex.ImplMap:
                case TableIndex.InterfaceImpl:
                case TableIndex.ManifestResource:
                case TableIndex.MethodSemantics:
                case TableIndex.Module:
                case TableIndex.NestedClass:
                case TableIndex.EventMap:
                case TableIndex.PropertyMap:
DynAbs.Tracing.TraceSender.TraceEnterCondition(23108,6270,7569);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,7542,7554);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(23108,6270,7569);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,7585,7598);

return false;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23108,6060,7609);

bool
f_23108_6191_6252(System.Reflection.Metadata.HandleKind
type,out System.Reflection.Metadata.Ecma335.TableIndex
index)
{
var return_v = MetadataTokens.TryGetTableIndex( type, out index);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23108, 6191, 6252);
return return_v;
}


int
f_23108_6179_6253(bool
condition)
{
Assert.True( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23108, 6179, 6253);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23108,6060,7609);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23108,6060,7609);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static void CheckEncMap(MetadataReader reader, params EntityHandle[] handles)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23108,7621,7840);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,7732,7829);

f_23108_7732_7828(handles, f_23108_7756_7793(reader), itemInspector: EncMapRowToString);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23108,7621,7840);

System.Collections.Generic.IEnumerable<System.Reflection.Metadata.EntityHandle>
f_23108_7756_7793(System.Reflection.Metadata.MetadataReader
reader)
{
var return_v = reader.GetEditAndContinueMapEntries();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23108, 7756, 7793);
return return_v;
}


bool
f_23108_7732_7828(System.Reflection.Metadata.EntityHandle[]
expected,System.Collections.Generic.IEnumerable<System.Reflection.Metadata.EntityHandle>
actual,System.Func<System.Reflection.Metadata.EntityHandle, string>
itemInspector)
{
var return_v = AssertEx.Equal( (System.Collections.Generic.IEnumerable<System.Reflection.Metadata.EntityHandle>)expected, actual, itemInspector:itemInspector);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23108, 7732, 7828);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23108,7621,7840);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23108,7621,7840);
}
		}

internal static void CheckAttributes(MetadataReader reader, params CustomAttributeRow[] rows)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23108,7852,8072);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,7970,8061);

f_23108_7970_8060(rows, f_23108_7991_8022(reader), itemInspector: AttributeRowToString);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23108,7852,8072);

System.Collections.Generic.IEnumerable<Roslyn.Test.Utilities.CustomAttributeRow>
f_23108_7991_8022(System.Reflection.Metadata.MetadataReader
reader)
{
var return_v = reader.GetCustomAttributeRows();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23108, 7991, 8022);
return return_v;
}


bool
f_23108_7970_8060(Roslyn.Test.Utilities.CustomAttributeRow[]
expected,System.Collections.Generic.IEnumerable<Roslyn.Test.Utilities.CustomAttributeRow>
actual,System.Func<Roslyn.Test.Utilities.CustomAttributeRow, string>
itemInspector)
{
var return_v = AssertEx.Equal( (System.Collections.Generic.IEnumerable<Roslyn.Test.Utilities.CustomAttributeRow>)expected, actual, itemInspector:itemInspector);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23108, 7970, 8060);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23108,7852,8072);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23108,7852,8072);
}
		}

internal static void CheckNames(MetadataReader reader, IEnumerable<StringHandle> handles, params string[] expectedNames)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23108,8084,8293);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,8229,8282);

f_23108_8229_8281(new[] { reader }, handles, expectedNames);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23108,8084,8293);

int
f_23108_8229_8281(System.Reflection.Metadata.MetadataReader[]
readers,System.Collections.Generic.IEnumerable<System.Reflection.Metadata.StringHandle>
handles,params string[]
expectedNames)
{
CheckNames( (System.Collections.Generic.IEnumerable<System.Reflection.Metadata.MetadataReader>)readers, handles, expectedNames);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23108, 8229, 8281);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23108,8084,8293);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23108,8084,8293);
}
		}

internal static void CheckNames(IEnumerable<MetadataReader> readers, IEnumerable<StringHandle> handles, params string[] expectedNames)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23108,8305,8578);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,8464,8510);

var 
actualNames = f_23108_8482_8509(readers, handles)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,8524,8567);

f_23108_8524_8566(expectedNames, actualNames);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23108,8305,8578);

string[]
f_23108_8482_8509(System.Collections.Generic.IEnumerable<System.Reflection.Metadata.MetadataReader>
readers,System.Collections.Generic.IEnumerable<System.Reflection.Metadata.StringHandle>
handles)
{
var return_v = readers.GetStrings( handles);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23108, 8482, 8509);
return return_v;
}


bool
f_23108_8524_8566(string[]
expected,string[]
actual)
{
var return_v = AssertEx.Equal( (System.Collections.Generic.IEnumerable<string>)expected, (System.Collections.Generic.IEnumerable<string>)actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23108, 8524, 8566);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23108,8305,8578);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23108,8305,8578);
}
		}

internal static void CheckNames(IList<MetadataReader> readers, IEnumerable<(StringHandle Namespace, StringHandle Name)> handles, params string[] expectedNames)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23108,8590,8994);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,8774,8926);

var 
actualNames = f_23108_8792_8925(f_23108_8792_8915(handles, handlePair => string.Join(".", readers.GetString(handlePair.Namespace), readers.GetString(handlePair.Name))))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,8940,8983);

f_23108_8940_8982(expectedNames, actualNames);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23108,8590,8994);

System.Collections.Generic.IEnumerable<string>
f_23108_8792_8915(System.Collections.Generic.IEnumerable<(System.Reflection.Metadata.StringHandle Namespace, System.Reflection.Metadata.StringHandle Name)>
source,System.Func<(System.Reflection.Metadata.StringHandle Namespace, System.Reflection.Metadata.StringHandle Name), string>
selector)
{
var return_v = source.Select<(System.Reflection.Metadata.StringHandle Namespace, System.Reflection.Metadata.StringHandle Name),string>( selector);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23108, 8792, 8915);
return return_v;
}


string[]
f_23108_8792_8925(System.Collections.Generic.IEnumerable<string>
source)
{
var return_v = source.ToArray<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23108, 8792, 8925);
return return_v;
}


bool
f_23108_8940_8982(string[]
expected,string[]
actual)
{
var return_v = AssertEx.Equal( (System.Collections.Generic.IEnumerable<string>)expected, (System.Collections.Generic.IEnumerable<string>)actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23108, 8940, 8982);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23108,8590,8994);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23108,8590,8994);
}
		}

internal static string EncLogRowToString(EditAndContinueLogEntry row)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23108,9006,9444);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,9100,9122);

TableIndex 
tableIndex
=default(TableIndex);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,9136,9201);

f_23108_9136_9200(row.Handle.Kind, out tableIndex);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,9217,9433);

return f_23108_9224_9432("Row({0}, TableIndex.{1}, EditAndContinueOperation.{2})", f_23108_9331_9370(row.Handle), tableIndex, row.Operation);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23108,9006,9444);

bool
f_23108_9136_9200(System.Reflection.Metadata.HandleKind
type,out System.Reflection.Metadata.Ecma335.TableIndex
index)
{
var return_v = MetadataTokens.TryGetTableIndex( type, out index);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23108, 9136, 9200);
return return_v;
}


int
f_23108_9331_9370(System.Reflection.Metadata.EntityHandle
handle)
{
var return_v = MetadataTokens.GetRowNumber( handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23108, 9331, 9370);
return return_v;
}


string
f_23108_9224_9432(string
format,int
arg0,System.Reflection.Metadata.Ecma335.TableIndex
arg1,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
arg2)
{
var return_v = string.Format( format, (object)arg0, (object)arg1, (object)arg2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23108, 9224, 9432);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23108,9006,9444);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23108,9006,9444);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static string EncMapRowToString(EntityHandle handle)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23108,9456,9819);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,9542,9564);

TableIndex 
tableIndex
=default(TableIndex);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,9578,9639);

f_23108_9578_9638(handle.Kind, out tableIndex);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,9655,9808);

return f_23108_9662_9807("Handle({0}, TableIndex.{1})", f_23108_9742_9777(handle), tableIndex);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23108,9456,9819);

bool
f_23108_9578_9638(System.Reflection.Metadata.HandleKind
type,out System.Reflection.Metadata.Ecma335.TableIndex
index)
{
var return_v = MetadataTokens.TryGetTableIndex( type, out index);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23108, 9578, 9638);
return return_v;
}


int
f_23108_9742_9777(System.Reflection.Metadata.EntityHandle
handle)
{
var return_v = MetadataTokens.GetRowNumber( handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23108, 9742, 9777);
return return_v;
}


string
f_23108_9662_9807(string
format,int
arg0,System.Reflection.Metadata.Ecma335.TableIndex
arg1)
{
var return_v = string.Format( format, (object)arg0, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23108, 9662, 9807);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23108,9456,9819);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23108,9456,9819);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static string AttributeRowToString(CustomAttributeRow row)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23108,9831,10520);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,9923,9974);

TableIndex 
parentTableIndex
=default(TableIndex),
constructorTableIndex
=default(TableIndex);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,9988,10064);

f_23108_9988_10063(row.ParentToken.Kind, out parentTableIndex);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,10078,10164);

f_23108_10078_10163(row.ConstructorToken.Kind, out constructorTableIndex);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,10180,10509);

return f_23108_10187_10508("new CustomAttributeRow(Handle({0}, TableIndex.{1}), Handle({2}, TableIndex.{3}))", f_23108_10320_10364(row.ParentToken), parentTableIndex, f_23108_10418_10467(row.ConstructorToken), constructorTableIndex);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23108,9831,10520);

bool
f_23108_9988_10063(System.Reflection.Metadata.HandleKind
type,out System.Reflection.Metadata.Ecma335.TableIndex
index)
{
var return_v = MetadataTokens.TryGetTableIndex( type, out index);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23108, 9988, 10063);
return return_v;
}


bool
f_23108_10078_10163(System.Reflection.Metadata.HandleKind
type,out System.Reflection.Metadata.Ecma335.TableIndex
index)
{
var return_v = MetadataTokens.TryGetTableIndex( type, out index);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23108, 10078, 10163);
return return_v;
}


int
f_23108_10320_10364(System.Reflection.Metadata.EntityHandle
handle)
{
var return_v = MetadataTokens.GetRowNumber( handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23108, 10320, 10364);
return return_v;
}


int
f_23108_10418_10467(System.Reflection.Metadata.EntityHandle
handle)
{
var return_v = MetadataTokens.GetRowNumber( handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23108, 10418, 10467);
return return_v;
}


string
f_23108_10187_10508(string
format,params object?[]
args)
{
var return_v = string.Format( format, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23108, 10187, 10508);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23108,9831,10520);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23108,9831,10520);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static void SaveImages(string outputDirectory, CompilationVerifier baseline, params CompilationDifference[] diffs)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23108,10532,11663);

bool IsPortablePdb(ImmutableArray<byte> image) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(23108,10727,10802);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,10730,10802);
return image[0] == 'B' &&(DynAbs.Tracing.TraceSender.Expression_True(23108, 10730, 10764)&&image[1] == 'S' )&&(DynAbs.Tracing.TraceSender.Expression_True(23108, 10730, 10783)&&image[2] == 'J' )&&(DynAbs.Tracing.TraceSender.Expression_True(23108, 10730, 10802)&&image[3] == 'B');DynAbs.Tracing.TraceSender.TraceExitMethod(23108,10727,10802);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23108,10727,10802);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23108,10727,10802);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,10819,10871);

string 
baseName = f_23108_10837_10870(f_23108_10837_10857(baseline))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,10885,10958);

string 
extSuffix = (DynAbs.Tracing.TraceSender.Conditional_F1(23108, 10904, 10946)||((f_23108_10904_10946(baseline.EmittedAssemblyPdb)&&DynAbs.Tracing.TraceSender.Conditional_F2(23108, 10949, 10952))||DynAbs.Tracing.TraceSender.Conditional_F3(23108, 10955, 10957)))?"x" :""
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,10974,11017);

f_23108_10974_11016(outputDirectory);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,11033,11154);

f_23108_11033_11153(f_23108_11052_11112(outputDirectory, baseName + ".dll" + extSuffix), baseline.EmittedAssemblyData.ToArray());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,11168,11288);

f_23108_11168_11287(f_23108_11187_11247(outputDirectory, baseName + ".pdb" + extSuffix), baseline.EmittedAssemblyPdb.ToArray());
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,11313,11318);

            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,11304,11652) || true) && (i < f_23108_11324_11336(diffs))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,11338,11341)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(23108,11304,11652))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(23108,11304,11652);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,11375,11502);

f_23108_11375_11501(f_23108_11394_11466(outputDirectory, $"{baseName}.{i + 1}.metadata{extSuffix}"), diffs[i].MetadataDelta.ToArray());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,11520,11637);

f_23108_11520_11636(f_23108_11539_11606(outputDirectory, $"{baseName}.{i + 1}.pdb{extSuffix}"), diffs[i].PdbDelta.ToArray());
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(23108,1,349);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(23108,1,349);
}DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23108,10532,11663);

Microsoft.CodeAnalysis.Compilation
f_23108_10837_10857(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param)
{
var return_v = this_param.Compilation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23108, 10837, 10857);
return return_v;
}


string?
f_23108_10837_10870(Microsoft.CodeAnalysis.Compilation
this_param)
{
var return_v = this_param.AssemblyName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23108, 10837, 10870);
return return_v;
}


bool
f_23108_10904_10946(System.Collections.Immutable.ImmutableArray<byte>
image)
{
var return_v = IsPortablePdb( image);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23108, 10904, 10946);
return return_v;
}


System.IO.DirectoryInfo
f_23108_10974_11016(string
path)
{
var return_v = Directory.CreateDirectory( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23108, 10974, 11016);
return return_v;
}


string
f_23108_11052_11112(string
path1,string
path2)
{
var return_v = Path.Combine( path1, path2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23108, 11052, 11112);
return return_v;
}


int
f_23108_11033_11153(string
path,byte[]
bytes)
{
File.WriteAllBytes( path, bytes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23108, 11033, 11153);
return 0;
}


string
f_23108_11187_11247(string
path1,string
path2)
{
var return_v = Path.Combine( path1, path2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23108, 11187, 11247);
return return_v;
}


int
f_23108_11168_11287(string
path,byte[]
bytes)
{
File.WriteAllBytes( path, bytes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23108, 11168, 11287);
return 0;
}


int
f_23108_11324_11336(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23108, 11324, 11336);
return return_v;
}


string
f_23108_11394_11466(string
path1,string
path2)
{
var return_v = Path.Combine( path1, path2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23108, 11394, 11466);
return return_v;
}


int
f_23108_11375_11501(string
path,byte[]
bytes)
{
File.WriteAllBytes( path, bytes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23108, 11375, 11501);
return 0;
}


string
f_23108_11539_11606(string
path1,string
path2)
{
var return_v = Path.Combine( path1, path2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23108, 11539, 11606);
return return_v;
}


int
f_23108_11520_11636(string
path,byte[]
bytes)
{
File.WriteAllBytes( path, bytes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23108, 11520, 11636);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23108,10532,11663);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23108,10532,11663);
}
		}

public EditAndContinueTestBase()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(23108,884,11670);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,1112,1177);
this.ComSafeDebugDll = f_23108_1130_1177(TestOptions.DebugDll, false);DynAbs.Tracing.TraceSender.TraceExitConstructor(23108,884,11670);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23108,884,11670);
}


static EditAndContinueTestBase()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(23108,884,11670);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,1283,1361);
EmptyLocalsProvider = handle => default(EditAndContinueMethodDebugInformation);DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(23108,884,11670);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23108,884,11670);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(23108,884,11670);

Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23108_1130_1177(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,bool
concurrentBuild)
{
var return_v = this_param.WithConcurrentBuild( concurrentBuild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23108, 1130, 1177);
return return_v;
}

}
public static class EditAndContinueTestExtensions
{
internal static CSharpCompilation WithSource(this CSharpCompilation compilation, string newSource)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23108,11744,11968);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,11867,11957);

return f_23108_11874_11956(f_23108_11874_11908(compilation), f_23108_11924_11955(newSource));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23108,11744,11968);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23108_11874_11908(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.RemoveAllSyntaxTrees();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23108, 11874, 11908);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxTree
f_23108_11924_11955(string
text)
{
var return_v = CSharpTestBase.Parse( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23108, 11924, 11955);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23108_11874_11956(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,params Microsoft.CodeAnalysis.SyntaxTree[]
trees)
{
var return_v = this_param.AddSyntaxTrees( trees);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23108, 11874, 11956);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23108,11744,11968);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23108,11744,11968);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static CSharpCompilation WithSource(this CSharpCompilation compilation, SyntaxTree newTree)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23108,11980,12182);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23108,12105,12171);

return f_23108_12112_12170(f_23108_12112_12146(compilation), newTree);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23108,11980,12182);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23108_12112_12146(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.RemoveAllSyntaxTrees();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23108, 12112, 12146);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23108_12112_12170(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,params Microsoft.CodeAnalysis.SyntaxTree[]
trees)
{
var return_v = this_param.AddSyntaxTrees( trees);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23108, 12112, 12170);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23108,11980,12182);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23108,11980,12182);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static EditAndContinueTestExtensions()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(23108,11678,12189);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(23108,11678,12189);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23108,11678,12189);
}

}
}
