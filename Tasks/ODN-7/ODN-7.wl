(* ::Package:: *)

x=x0+a*Cos[theta];
y=y0+a*Sin[theta];

distSquared=(x-xp)^2+(y-yp)^2

dDistSquared=D[distSquared,a]

FullSimplify[Solve[dDistSquared==0,a]]
aMin=a/.FullSimplify[Solve[dDistSquared==0,a]][[1,1]]

dMin=FullSimplify[distSquared/.a->aMin]



