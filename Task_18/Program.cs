// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y


bool x1 = false;
bool y1 = false;

if( !(x1|| y1) == (!x1 && !y1) )
    Console.WriteLine("false" );
else
{
     Console.WriteLine("true");
}
bool x2 = false;
bool y2 = true;

if( !(x2|| y2) == (!x2 && !y2) )
    Console.WriteLine("false" );
else
{
     Console.WriteLine("true");
}
bool x3 = true;
bool y3 = false;

if( !(x3|| y3) == (!x3 && !y3) )
    Console.WriteLine("false" );
else
{
     Console.WriteLine("true");
}
bool x4 = true;
bool y4 = true;
if ( !(x4|| y4) == (!x4 && !y4) )
    Console.WriteLine( "true" );
else
{
     Console.WriteLine("false");
}


//другое решение

bool X1 = false;
bool Y1 = false;

bool X2 = false;
bool Y2 = true;

bool X3 = true;
bool Y3 = false;

bool X4 = true;
bool Y4 = true;

if ( (!(X1 || Y1) == !X1 && !Y1) && (!(X2 || Y2) == !X2 && !Y2) && (!(X3 || Y3) == !X3 && !Y3) && (!(X4 || Y4) == !X4 && !Y4))
{
    Console.WriteLine("true");
}
else
{
    Console.WriteLine("false");
}
































