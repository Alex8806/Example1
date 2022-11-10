int A =new Random().Next(1,191);
Console.WriteLine(A);
int B=new Random().Next(1,191);
Console.WriteLine(B);
int C=new Random().Next(1,191);
Console.WriteLine(C);
int D=new Random().Next(1,191);
Console.WriteLine(D);
int E=new Random().Next(1,191);
Console.WriteLine(E);

int max = A;

if (A>max) max =A;
if (B>max) max =B;
if (C>max) max =C;
if (D>max) max =D;
if (E>max) max =E;
Console.WriteLine("max "+ max);
