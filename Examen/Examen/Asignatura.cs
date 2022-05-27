using System;


namespace EDexamenT6a8 //mal identado
{
    /*Clase que representa la gestíon de las notas para una asignatura.
 * Se puede(métodos): Introducir la asignatura
 *                    Registrar las notas de prácticas y examen para cada evaluación.
 *                    Calcular las notas por cada trimestre.
 *                    Calcular la nota final de curso.
 * Estos comentarios se deben eliminar y usar comentarios de documentación en su lugar.
 */

    /// <summary>
    /// Clase que representa la gestíon de las notas para una asignatura.
    /// </summary>
    /// <
    class Asignatura
    {
        //Atributos al principio
        private string codigodelaAsignatura;
        private string nombredelaAsignatura;
        private double notadelPrimertrimestre;
        private double notadelSegungoTrimestre;
        private double notadelTercerTrimestre;
        private double notaFinaldelCurso;

        //He generado unas properties y he encapsulado los campos
        public string CodigodelaAsignatura { get => codigodelaAsignatura; set => codigodelaAsignatura = value; }
        public string NombredelaAsignatura { get => nombredelaAsignatura; set => nombredelaAsignatura = value; }
        public double NotadelPrimertrimestre { get => notadelPrimertrimestre; set => notadelPrimertrimestre = value; }
        public double NotadelSegungoTrimestre { get => notadelSegungoTrimestre; set => notadelSegungoTrimestre = value; }
        public double NotadelTercerTrimestre { get => notadelTercerTrimestre; set => notadelTercerTrimestre = value; }
        public double NotaFinaldelCurso { get => notaFinaldelCurso; set => notaFinaldelCurso = value; }

        // Comentarios?
        public Asignatura(string CodigodelaAsignatura, string NombredelaAsignatura, double NotadelPrimertrimestre, double NotadelSegungoTrimestre, double NotadelTercerTrimestre, double NotaFinaldelCurso)
        {
            this.CodigodelaAsignatura = CodigodelaAsignatura; //Codigo de la asignatura.
            this.NombredelaAsignatura = NombredelaAsignatura; //Nombre de la asignatura.
            this.NotadelPrimertrimestre = NotadelPrimertrimestre; // Nota de los trimestres (1, 2   y 3) y nota final.
            this.NotadelSegungoTrimestre = NotadelSegungoTrimestre;
            this.NotadelTercerTrimestre = NotadelTercerTrimestre;
            this.NotaFinaldelCurso = NotaFinaldelCurso;
        }

        public void IntroducirMateria(string Cod_de_Asignatura, string Nombre_de_Asignatura)
        {
            this.CodigodelaAsignatura = Cod_de_Asignatura; //Esto estaba en linea le di salto de pagina
            this.NombredelaAsignatura = Nombre_de_Asignatura;

        }
        
        //Corchetes de más, y saltos de linea de más
        public void IntroducirlasNotas(double notadelExamen1, double notadelExamen2, double notadelExamen3, double notadelasPracticas1, double notadelasPracticas2, double notadelasPracticas3)
        {
            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine("Trimestre evaluado 1, 2 ó 3: ");
                var Trimestre = Console.ReadLine();

                switch (Trimestre)
                {
                    case "1":
                        MostrarNotas(out notadelExamen1, out notadelasPracticas1);
                        break;

                    case "2":
                        MostrarNotas(out notadelExamen2, out notadelasPracticas2);
                        break;

                    case "3":   
                        MostrarNotas(out notadelExamen3, out notadelasPracticas3);
                        break;
                }
            }
        }

        //He creado este metodo lo he extraido, se repetia en el case
        private static void MostrarNotas(out double notadelExamen1, out double notadelasPracticas1)
        {
            Console.WriteLine("Nota de las prácticas: ");
            notadelasPracticas1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nota del examen: ");
            notadelExamen1 = Convert.ToDouble(Console.ReadLine());
        }

        //Nomenclatura mal Primera letra en mayus + espacios
        public double CalculodelaNota1(double notadelExamen1, double notadelasPracticas1)
        {
            this.NotadelPrimertrimestre = (notadelExamen1 * 0.8) + (notadelasPracticas1) * 0.2; //La nota está comupuesta  por 20 % de la nota de prácticas y 80 % de la nota del examen. 
            return this.NotadelPrimertrimestre;
        }

        public double CalculodelaNota2(double notadelExamen2, double notadelasPracticas2)
        {
            this.NotadelSegungoTrimestre = (notadelExamen2 * 0.8) + (notadelasPracticas2) * 0.2;
            return this.NotadelSegungoTrimestre;
        }

        public double CalculodelaNota3(double notadelExamen3, double notadelasPracticas3)
        {
            this.NotadelTercerTrimestre = (notadelExamen3 * 0.8) + (notadelasPracticas3) * 0.2;
            return this.NotadelTercerTrimestre;
        }

        public double Calculodelamedia()
        {
            this.NotaFinaldelCurso = (this.NotadelPrimertrimestre + this.NotadelSegungoTrimestre + this.NotadelTercerTrimestre) / 3; //Nota final del curso
            return this.NotaFinaldelCurso;
        }

    }

    class ejemplodeunaAsignatura
    {

        //TODO
        /*
         *   
        static void main()
        {
            * 
            * 
            * 
            asignatura mi_asignatura_ejemplo = new asignatura("0521385", "Entornos  de Desarrollo");

            /
        */
    }
}


