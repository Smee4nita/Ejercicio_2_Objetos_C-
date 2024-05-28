using System.Runtime.CompilerServices;

namespace Biblioteca_Escuela
{
    public class Alumno
    {
        private string apellido;
        private string nombre;
        private string legajo;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        public Alumno(string apellido, string nombre, string legajo)
        { 
            this.apellido = apellido;
            this.nombre = nombre;
            this.legajo = legajo;
            
        }

        static Alumno()
        {
            Alumno.random = new Random();
        }
        public void SetNotaPrimerParcial(int notaPrimerParcial)
        {
            this.notaPrimerParcial = notaPrimerParcial;
        }
        public void SetNotaSegundoParcial(int notaSegundoParcial)
        {
            this.notaSegundoParcial = notaSegundoParcial;
        }
        private double CalcularPromedio()
        {
            double promedio = ((double)notaPrimerParcial + notaSegundoParcial)/2;
            return promedio;
        }
        //El método CalcularNotaFinal deberá retornar la nota del final con un número aleatorio
        //entre 6 y 10 incluidos siempre y cuando las notas del primer y segundo parcial sean mayores
        //o iguales a 4, caso contrario la inicializará con el valor -1.
        public double CalcularNotaFinal()
        {
            if (notaPrimerParcial >= 4 && notaSegundoParcial >= 4)
            {
                Random rnd = new Random();
                int notaFinal = rnd.Next(6, 11);
                return notaFinal;
            }
            else
            {
                return -1;
            }
        }
        public string AlumnoToString()
        {
            return $"El nombre del alumno es: {nombre}, el apellido del alumno es: {apellido} y el legajo es: {legajo}";
        }

    }
}
