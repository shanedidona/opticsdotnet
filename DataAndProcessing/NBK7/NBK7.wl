(* ::Package:: *)

Data1=Import["C:\\Users\\shane\\opticsdotnet\\DataAndProcessing\\NBK7\\Uncoated_N-BK7_Transmission_4microns.xlsx"];
Data1=Data1[[1]][[3;;-1]][[All,3;;4]]
Data1[[All,2]]=Data1[[All,2]]/100.0;
Solve[Exp[-a*0.01]==t1,a]
Exp1=a/.Solve[Exp[-a*0.01]==t1,a][[1]]

MinMax[Data1[[All,1]]]
MinMax[Data1[[All,2]]]

AttenuationCoeffs=Table[
{
	f[[1]],
	If[f[[2]]<=0.0,Infinity,Exp1/.t1->f[[2]]]
}
,{f,Data1}]

Export["C:\\Users\\shane\\opticsdotnet\\opticsdotnet\\opticsdotnet.Lib\\Data\\NBK7\\NBK7_AttenuationCoeffs.csv",AttenuationCoeffs]
Export["C:\\Users\\shane\\opticsdotnet\\opticsdotnet\\opticsdotnet.Lib\\Data\\NBK7\\Test1.csv",{{0.0000000001}}]



