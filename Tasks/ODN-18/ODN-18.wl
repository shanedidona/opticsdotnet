(* ::Package:: *)

x=x0+a*Cos[theta];
y=y0+a*Sin[theta];

distSquared=(x-xc)^2+(y-yc)^2;

error=(distSquared-rCircle^2)^2

derror=D[error,a]

TableForm[
FullSimplify[Solve[derror==0,a]]
]


Table[
	Get[f,Method->"String"]
,{f,StringSplit[Import["C:\\Users\\shane\\opticsdotnet\\Tasks\\ODN-18\\ODN18_1.txt"]]}]
