namespace Espacio.Calculadoras{
    public class Calculadora{
        private double valor;
        
        public Calculadora(){
            valor = 0;
        }

        public double Resultado {get => valor; }

        public void Sumar(double sumando){
            valor += sumando;
        }

        public void Restar(double restando){
            valor -= restando;
        }

        public void Multiplicar(double multiplicador){
            valor = valor * multiplicador;
        }

        public void Dividir(double dividendo){
            valor = valor / dividendo;
        }
        
        public void Limpiar(double dividendo){
            valor = 0;
        }
    }
}