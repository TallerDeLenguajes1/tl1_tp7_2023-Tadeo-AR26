namespace Espacio.Empleados{
    public class Empleado{
        private string? nombre;
        private string? apellido;
        private DateTime fecha_nacimiento;
        private char estado_civil;
        private char genero;
        private DateTime fecha_ingreso;
        private double sueldo_basico;
        private cargos cargo;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime Fecha_nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }
        public char Estado_civil { get => estado_civil; set => estado_civil = value; }
        public char Genero { get => genero; set => genero = value; }
        public DateTime Fecha_ingreso { get => fecha_ingreso; set => fecha_ingreso = value; }
        public double Sueldo_basico { get => sueldo_basico; set => sueldo_basico = value; }
        public cargos Cargo { get => cargo; set => cargo = value; }

        public void antiguedad(DateTime Hoy){
            DateTime antiguedad = Hoy.Subtract(Fecha_ingreso);
            return antiguedad;
        }

        public void edad(DateTime Hoy){
            DateTime edad = Hoy.Subtract(Fecha_nacimiento);
            return edad;
        }
        public void jubilacion(){
            double jubilacion = Hoy.Subtract(Fecha_nacimiento).TotalDays;
            jubilacion = jubilacion/365;
            if(genero == "M"){
                jubilacion = 65-jubilacion;
            }
            if(genero == "F"){
                jubilacion = 60-jubilacion;
            }
            return jubilacion;
        }
    }
}

enum cargos{
    auxilar = 1,
    administrativo = 2,
    Ingeniero = 3,

    Especialista = 4,
    Investigador = 5,
}