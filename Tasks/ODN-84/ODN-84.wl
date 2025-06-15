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
