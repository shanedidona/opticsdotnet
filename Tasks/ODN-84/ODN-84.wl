(* ::Package:: *)

Graphics[
{RGBColor[0,0,1],
	Circle[{1,1},4],
	Red
},Axes->True]

Graphics[Translate[
{RGBColor[0,0,1],
	Circle[{1,1},4],
	Red
},{-1,-1}],Axes->True]


Graphics[{Dashed,Circle[{1,2},3]}]
Graphics[{Dashed,1}]
Graphics[{Bold,1}]


Graphics[{Red,{Dashed,Circle[{1,2},3]}}]


Graphics[{Directive[Dashed],Circle[{1,2},3]}]
Graphics[{Directive[],Circle[{1,2},3]}]
Graphics[{Directive[Dashed],Circle[{1,2},3]}]


T1=Table[
	Graphics[Get[f,Method->"String"],Axes->True]
,{f,StringSplit[Import["C:\\Users\\shane\\opticsdotnet\\Tasks\\ODN-84\\ODN-84.txt"],"\n"]}]
