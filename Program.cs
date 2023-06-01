using Espacio.Calculadoras;

Calculadora cal = new Calculadora();
double a = 0;
string? operacion;
Console.WriteLine("Ingrese la operacion que desea realizar");
Console.WriteLine("Suma: +");
Console.WriteLine("Resta: -");
Console.WriteLine("Multiplicacion: *");
Console.WriteLine("Division: /");
Console.WriteLine("Limpiar: L");
Console.WriteLine("Salir: e");

do{
    operacion = Console.ReadLine();
    switch(operacion){
        case "+":
            bool control = double.TryParse(Console.ReadLine(), out a);
            cal.Sumar(a);
            Console.WriteLine(cal.Resultado);
            break;
        case "-":
            control = double.TryParse(Console.ReadLine(), out a);
            cal.Restar(a);
            Console.WriteLine(cal.Resultado);
            break;
        case "*":
            control = double.TryParse(Console.ReadLine(), out a);
            cal.Multiplicar(a);
            Console.WriteLine(cal.Resultado);
            break;
        case "/":
            control = double.TryParse(Console.ReadLine(), out a);
            cal.Dividir(a);
            Console.WriteLine(cal.Resultado);
            break;
        case "L":
            control = double.TryParse(Console.ReadLine(), out a);
            cal.Limpiar(a);
            Console.WriteLine(cal.Resultado);
            break;
    }
}while(operacion != "e");
