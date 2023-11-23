Console.WriteLine("Hello, World!");

// VALUE TYPES
bool f1; // true or false
System.Boolean f2;

byte b1; // 0..255
System.Byte b2;

sbyte b3; // -128..127
System.SByte b4;

short s1; // -32768..32767
System.Int16 s2;

ushort s3; // 0..65535
System.UInt16 s4;

int i1; // -2147483648..2147483647
System.Int32 i2;

uint i3; // 0..4294967295
System.UInt32 i4;
i3 = 234U;

long l1; // signed 8 byte
System.Int64 l2;
l1 = 34L;


ulong l3; // unsigned 8 byte 0..
System.UInt64 l4;
l3 = 456UL;


float x; // -3.4e38..3.4e38
System.Single x2;
x = 45.6f;


double x3; // 8 byte real number
System.Double x4;


decimal d1; // 16byte +- 10-28 +- 8*10^28
System.Decimal d2;
d1 = 34.6m;

char ch1;
System.Char ch2;


// REFERENCE TYPES

string str1;
System.String str2;

object obj1;
System.Object obj2;

obj1 = 100;
obj1 = 'A';
obj1 = 23.78;
obj1 = true;

// +, -, *, /, %, ++, --
// a / b * c % d
// &, |, ^, ~, <<, >>
// =, +=, -=, *=, /=, %=, &=, |=, ^=, <<=, >>=

char sym1 = 'A';

byte bt1 = 234;
int var1 = 45;

//var1 = bt1;
//bt1 = (byte)var1;
try
{
    sbyte sbt1 = checked((sbyte)bt1);
    Console.WriteLine(sbt1);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

// ==, !=, >, <, >=, <=
// &&, &, ||, |, !, ^

bool flag;

int n = 10;
int m = 5;

flag = m > 0 || ++n > 0;
Console.WriteLine(flag);
Console.WriteLine(n);

if(m > 0)
{

}
else if(m < 0)
{

}
else
{

}

int a = (m > 0) ? 100 : 200;

switch(m)
{
    case 1:
        //
        goto case 30;
    case 20:
        //
        break;
    case 30:
        //
        break;
    default:
        break;
}

string name = "Tom";
switch(name)
{
    case "Bob":
        break;
}


// while(expr1){}
// do{ }while(expr2);
// for( ; ; )
// foreach

// continue, break


string str23 = "Hello world";
foreach(var item in str23)
    Console.WriteLine(item);




int DoOperation(int a, int b, char op)
{
    //switch(op)
    //{
    //    case '+':
    //        return a + b;
    //    case '-':
    //        return a - b;
    //    case '*':
    //        return a * b;
    //    default:
    //        return 0;
    //}

    //int result = op switch
    //{
    //    '+' => a + b,
    //    '-' => a - b,
    //    '*' => a * b,
    //    _ => 0
    //};

    //return result;

    return op switch
    {
        '+' => a + b,
        '-' => a - b,
        '*' => a * b,
        _ => 0
    };
}








