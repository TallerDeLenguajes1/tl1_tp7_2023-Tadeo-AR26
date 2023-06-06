using Espacio.Empleados;

Empleado[] empleados = new Empleado[3];

void empleadoProximoJubilarse(Empleado[] empleados){
    int j = 0;
    int proximo = 9999;
    for(int i = 0; i < empleados.Count(); i++){
    if(empleados[i].Jubilacion() <= proximo){
        proximo = empleados[i].Jubilacion();
        j = i;
        }
    }
    empleados[j].MostrarDatos();
}

double totalSalarios = 0;

//Datos Empleado 1
empleados[0] = new Empleado();
empleados[0].Apellido = "Alonso Ruiz";
empleados[0].Nombre = "Tadeo";
empleados[0].Fecha_nacimiento = new DateTime(2003, 6, 26);
empleados[0].Estado_civil = 'S';
empleados[0].Genero = 'M';
empleados[0].Fecha_ingreso = new DateTime(2020, 5, 20);
empleados[0].Sueldo_basico = 50000;
empleados[0].Cargo = Cargos.Ingeniero;

//Datos Empleado 2
empleados[1] = new Empleado();
empleados[1].Apellido = "Marquez";
empleados[1].Nombre = "Juan Cruz";
empleados[1].Fecha_nacimiento = new DateTime(2002, 2, 1);
empleados[1].Estado_civil = 'C';
empleados[1].Genero = 'M';
empleados[1].Fecha_ingreso = new DateTime(2015, 10, 10);
empleados[1].Sueldo_basico = 35000;
empleados[1].Cargo = Cargos.Investigador;

//Datos Empleado 3
empleados[2] = new Empleado();
empleados[2].Apellido = "Soltermann";
empleados[2].Nombre = "Francisca";
empleados[2].Fecha_nacimiento = new DateTime(2002, 5, 26);
empleados[2].Estado_civil = 'S';
empleados[2].Genero = 'F';
empleados[2].Fecha_ingreso = new DateTime(2015, 10, 10);
empleados[2].Sueldo_basico = 40000;
empleados[2].Cargo = Cargos.administrativo;

foreach(Empleado empleado in empleados){
    totalSalarios += empleado.Salario();
}

Console.WriteLine($"Monto Total en Salarios: {totalSalarios}");
Console.WriteLine($"Empleado Proximo a jubilarse:");
empleadoProximoJubilarse(empleados);