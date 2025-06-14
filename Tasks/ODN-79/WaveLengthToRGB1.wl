(* ::Package:: *)

(*https://cie.co.at/datatable/cie-1931-colour-matching-functions-2-degree-observer*)
CIE1931=Import["C:\\Users\\shane\\opticsdotnet\\opticsdotnet\\opticsdotnet.Lib\\Data\\WaveLengthToRGB1\\CIE_xyz_1931_2deg.csv"];

ListPlot[
	{CIE1931[[All,{1,2}]],Data1[[All,{1,3}]],Data1[[All,{1,4}]]}
,PlotRange->All,PlotStyle->{Red,Green,Blue},PlotLabel->"CIE1931"]

Matrix1={
	{3.2410,-1.5374,-0.4986},
	{-0.9692,1.8760,0.0416},
	{0.0556,-0.2040,1.0570}
};(*https://www.w3.org/Graphics/Color/sRGB.html*)

AfterMatrix=Table[
	RGB1=Dot[Matrix1,f[[2;;4]]];
	Prepend[RGB1,f[[1]]]
,{f,CIE1931}];

ListPlot[
	{AfterMatrix[[All,{1,2}]],AfterMatrix[[All,{1,3}]],AfterMatrix[[All,{1,4}]]}
,PlotRange->All,PlotStyle->{Red,Green,Blue},PlotLabel->"After Matrix"]

ClippedAfterMatrix=Table[
	RGB1=Clip[Dot[Matrix1,f[[2;;4]]],{0,1}];
	Prepend[RGB1,f[[1]]]
,{f,CIE1931}];

ListPlot[
	{ClippedAfterMatrix[[All,{1,2}]],ClippedAfterMatrix[[All,{1,3}]],ClippedAfterMatrix[[All,{1,4}]]}
,PlotRange->All,PlotStyle->{Red,Green,Blue},PlotLabel->"Clipped After Matrix"]

Table[
	Style[f[[1]],Bold,RGBColor[f[[2]],f[[3]],f[[4]]]]
,{f,ClippedAfterMatrix}]







