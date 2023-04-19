
 //error  es que trata de sumar un tipo string a un int el cual intenta convertirlo con un 
 // toint 32 pero este tiene una letra "G" el cual lodeja en string siempre 
try
{
    int dato1 = 16;
    string dato2= "25g";
    int Resultado = dato1 + Convert.ToInt32(dato2);
}
catch
{
    Console.WriteLine("Lo sentimos no se puede realizar su operaciòn ");
}