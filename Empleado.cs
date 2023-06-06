namespace Espacio.Empleados{
    public class Empleado{
        private string? nombre;
        private string? apellido;
        private DateTime fecha_nacimiento;
        private char estado_civil;
        private char genero;
        private DateTime fecha_ingreso;
        private double sueldo_basico;
        private Cargos cargo;

        public string Nombre { set => nombre = value; }
        public string Apellido { set => apellido = value; }
        public DateTime Fecha_nacimiento { set => fecha_nacimiento = value; }
        public char Estado_civil { set => estado_civil = value; }
        public char Genero { set => genero = value; }
        public DateTime Fecha_ingreso { set => fecha_ingreso = value; }
        public double Sueldo_basico { set => sueldo_basico = value; }
        public Cargos Cargo { set => cargo = value; }

        public int Antiguedad(){
            return ((DateTime.Now.Subtract(fecha_ingreso).Days) / 365);
        }

        public int Edad(){
            return ((DateTime.Now.Subtract(fecha_nacimiento).Days) / 365);
        }

        public int Jubilacion(){
            if(genero == 'M'){
                return (65 - Edad());
            }
            else{
                return (60 - Edad());
            }
        }
        private double Adicional(){
            double adicional = 0;
            if(Antiguedad() < 20) adicional = sueldo_basico*(Antiguedad() / 100);
            if((cargo == Cargos.Ingeniero) || (cargo == Cargos.Especialista)) adicional = adicional * 1.5;
            if(estado_civil == 'C') adicional += 15000;

            return adicional;
        }

        public double Salario(){
            return (sueldo_basico + Adicional());
        }

        public void MostrarDatos(){
            Console.WriteLine($"Apellido: {apellido}");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Fecha de Nacimiento: {fecha_nacimiento.ToShortDateString()}");
            Console.WriteLine($"Estado Civil: {estado_civil}");
            Console.WriteLine($"Genero: {genero}");
            Console.WriteLine($"Fecha de Ingreso: {fecha_ingreso.ToShortDateString()}");
            Console.WriteLine($"Sueldo basico: {sueldo_basico}");
            Console.WriteLine($"Cargo: {cargo}");
            Console.WriteLine($"Edad: {Edad()}");
            Console.WriteLine($"Antiguedad: {Antiguedad()}");
            Console.WriteLine($"Años para jubilarse: {Jubilacion()}");
            Console.WriteLine($"Salario: {Salario()}");
        }
    }
}

public enum Cargos{
    auxilar = 1,
    administrativo = 2,
    Ingeniero = 3,

    Especialista = 4,
    Investigador = 5,
}