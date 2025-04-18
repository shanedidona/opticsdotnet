(* ::Package:: *)

Solve[
		{
			0==2*A3*xp+A5+A6*yp,
			0==2*A2*yp+A4+A6*xp
		}
	,{xp,yp}]



Table[
	Graphics[Get[f,Method->"String"]]
,{f,StringSplit[Import["C:\\Users\\shane\\opticsdotnet\\Tasks\\ODN-48\\ODN48_1.txt"]]}]


beta=A1+A2*yp^2+A3*xp^2+A4*yp+A5*xp+A6*xp*yp

dbdx=D[beta,xp]
dbdy=D[beta,yp]

Solve[
		{
			0==dbdx,
			0==dbdy
		}
	,{xp,yp}]






Exp1=((y0i-yp)*c+(-x0i+xp)*s)^2
Expand[Exp1]
Collect[Exp1,{xp,yp}]

A1s=(y0i*c-x0i*s)^2
A2s=c^2
A3s=s^2
A4s=2*(-y0i*c^2+c*s*x0i)
A5s=2*(c*s*y0i-x0i*s*s)
A6s=-2*c*s

betaS=A1s+A2s*yp^2+A3s*xp^2+A4s*yp+A5s*xp+A6s*xp*yp


compare1=betaS-Exp1
FullSimplify[compare1]





Expand[Sin[t]*Cos[t]]


Plot[Sin[t],{t,0,2*Pi}];
Plot[Cos[t],{t,0,2*Pi}];
Plot[(Sin[t])^2,{t,0,2*Pi},AxesLabel->{"theta","Sin^2"}]
Plot[(Cos[t])^2,{t,0,2*Pi},AxesLabel->{"theta","Cos^2"}]
Plot[Sin[t]*Cos[t],{t,0,2*Pi},AxesLabel->{"theta","Sin*Cos"}]
Plot[Sin[t]*Cos[t]-0.5*Sin[2*t],{t,0,2*Pi}]



