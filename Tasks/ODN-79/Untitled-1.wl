(* ::Package:: *)

CIE1931=Import["C:\\Users\\shane\\opticsdotnet\\opticsdotnet\\opticsdotnet.Lib\\Data\\WaveLengthToRGB1\\CIE_xyz_1931_2deg.csv"];

ListPlot[
	{Data1[[All,{1,2}]],Data1[[All,{1,3}]],Data1[[All,{1,4}]]}
,PlotRange->All,PlotStyle->{Red,Green,Blue}]

XYZN=CIE1931;

XYZN[[All,2]]=0.0125313*(XYZN[[All,2]]-0.1901);

ListPlot[
	{XYZN[[All,{1,2}]],XYZN[[All,{1,3}]],XYZN[[All,{1,4}]]}
,PlotRange->All,PlotStyle->{Red,Green,Blue}]


ListPlot[Data1[[All,{1,2}]],PlotRange->All]
ListPlot[Data1[[All,{1,3}]],PlotRange->All]
ListPlot[Data1[[All,{1,4}]],PlotRange->All]

1/0.0125313


CIE1931=Import["C:\\Users\\shane\\opticsdotnet\\opticsdotnet\\opticsdotnet.Lib\\Data\\WaveLengthToRGB1\\CIE_xyz_1931_2deg.csv"];

ListPlot[
	{Data1[[All,{1,2}]],Data1[[All,{1,3}]],Data1[[All,{1,4}]]}
,PlotRange->All,PlotStyle->{Red,Green,Blue}]

Matrix1={
	{3.2410,-1.5374,-0.4986},
	{-0.9692,1.8760,0.0416},
	{0.0556,-0.2040,1.0570}
}(*https://www.w3.org/Graphics/Color/sRGB.html*)

Data2=Table[
	RGB1=Dot[Matrix1,f[[2;;4]]];
	Prepend[RGB1,f[[1]]]
,{f,CIE1931}];

Data3=Table[
	RGB1=Clip[Dot[Matrix1,f[[2;;4]]],{0,1}];
	Prepend[RGB1,f[[1]]]
,{f,CIE1931}];

ListPlot[
	{Data2[[All,{1,2}]],Data2[[All,{1,3}]],Data2[[All,{1,4}]]}
,PlotRange->All,PlotStyle->{Red,Green,Blue}]

ListPlot[
	{Data3[[All,{1,2}]],Data3[[All,{1,3}]],Data3[[All,{1,4}]]}
,PlotRange->All,PlotStyle->{Red,Green,Blue}]


Table[
	Style[f[[1]],Bold,RGBColor[f[[2]],f[[3]],f[[4]]]]

,{f,Data3}]




