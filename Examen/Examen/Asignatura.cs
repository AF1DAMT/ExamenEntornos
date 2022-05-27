using System;


namespace EDexamenT6a8 //mal identado
{
    /*Clase que representa la gestíon de las notas para una asignatura.
 * Se puede(métodos): 
 *                    .
 *                    .
 *                    .
 * Estos comentarios se deben eliminar y usar comentarios de documentación en su lugar.
 */

    /// <summary>
    ///     Clase que representa la gestíon de las notas para una asignatura.
    /// </summary>
    /// <remarks> 
    ///     Utilice esta clase para: Introducir la asignatura, Registrar las notas de prácticas y examen para cada evaluación,
    ///     Calcular las notas por cada trimestre y Calcular la nota final de curso
    /// </remarks>
    /// <param name="codigodelaAsignatura"> string codigo de la asignatura </param>
    /// <param name="nombredelaAsignatura"> string nombre de la asignatura </param>
    /// <param name="notadelPrimertrimestre"> string nota del primer trimestre </param>
    /// <param name="notadelSegungoTrimestre"> string nota del segundo trimestre </param>
    /// <param name="notadelTercerTrimestre"> string nota del tercer trimestre </param>
    /// <example> 
    ///     Ejemplo de como crear una instancia de la clase
    ///     <code>
    ///         static void main()
    ///         {
    ///             asignatura mi_asignatura_ejemplo = new asignatura("0521385", "Entornos  de Desarrollo");
    ///         }
    ///     </code>
    /// </example>
    /// <returns> Devuelve un objeto del tipo asignatura</returns>
class Asignatura
    {
        /// <summary>
        /// Atributos al principio para una mejor legibilidad
        /// </summary>
        private string codigodelaAsignatura;
        private string nombredelaAsignatura;
        private double notadelPrimertrimestre;
        private double notadelSegungoTrimestre;
        private double notadelTercerTrimestre;
        private double notaFinaldelCurso;

        /// <summary>
        /// He generado unas properties y he encapsulado los campos para no dejarlas publicas
        /// </summary>
        public string CodigodelaAsignatura { get => codigodelaAsignatura; set => codigodelaAsignatura = value; }
        public string NombredelaAsignatura { get => nombredelaAsignatura; set => nombredelaAsignatura = value; }
        public double NotaTrimestr { get => notadelPrimertrimestre; set => notadelPrimertrimestre = value; }
        public double NotadelSegungoTrimestre { get => notadelSegungoTrimestre; set => notadelSegungoTrimestre = value; }
        public double NotadelTercerTrimestre { get => notadelTercerTrimestre; set => notadelTercerTrimestre = value; }
        public double NotaFinaldelCurso { get => notaFinaldelCurso; set => notaFinaldelCurso = value; }

        /// <summary>
        /// <para>Constructor</para>
        /// <para>He corregido los comentarios y he quitado algun salto de linea que habia innecesario </para>
        /// </summary>
        /// <param name="CodigodelaAsignatura"></param>
        /// <param name="NombredelaAsignatura"></param>
        /// <param name="NotadelPrimertrimestre"></param>
        /// <param name="NotadelSegungoTrimestre"></param>
        /// <param name="NotadelTercerTrimestre"></param>
        /// <param name="NotaFinaldelCurso"></param>
        public Asignatura(string CodigodelaAsignatura, string NombredelaAsignatura, double NotadelPrimertrimestre, double NotadelSegungoTrimestre, double NotadelTercerTrimestre, double NotaFinaldelCurso)
        {
            this.CodigodelaAsignatura = CodigodelaAsignatura; //Codigo de la asignatura.
            this.NombredelaAsignatura = NombredelaAsignatura; //Nombre de la asignatura.
            this.NotaTrimestr = NotadelPrimertrimestre; // Nota de los trimestres (1, 2   y 3) y nota final.
            this.NotadelSegungoTrimestre = NotadelSegungoTrimestre;
            this.NotadelTercerTrimestre = NotadelTercerTrimestre;
            this.NotaFinaldelCurso = NotaFinaldelCurso;
        }

        /// <summary>
        /// Funcion para introducir una materia a modo de Setter
        /// <para> He corregido la funcion estaba todo el codigo en una línea, lo he separado con un salto de linea</para>
        /// </summary>
        /// <param name="Cod_de_Asignatura"></param>
        /// <param name="Nombre_de_Asignatura"></param>
        public void IntroducirMateria(string Cod_de_Asignatura, string Nombre_de_Asignatura)
        {
            this.CodigodelaAsignatura = Cod_de_Asignatura; //Esto estaba en linea le di salto de pagina
            this.NombredelaAsignatura = Nombre_de_Asignatura;

        }
        
        /// <summary>
        /// Funcion para introducir las notas
        /// <para> Este metodo estaba mal tabulado, con corchetes innecesarios y espacios
        /// Además he extraido el método introducir las notas 
        /// </para>
        /// </summary>
        /// <param name="notadelExamen1"></param>
        /// <param name="notadelExamen2"></param>
        /// <param name="notadelExamen3"></param>
        /// <param name="notadelasPracticas1"></param>
        /// <param name="notadelasPracticas2"></param>
        /// <param name="notadelasPracticas3"></param>
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

        /// <summary>
        /// He extraido este metodo de la funcion anterior dado que se repetía inedesaria
        /// </summary>
        /// <param name="notadelExamen1"></param>
        /// <param name="notadelasPracticas1"></param>
        private static void MostrarNotas(out double notadelExamen1, out double notadelasPracticas1)
        {
            Console.WriteLine("Nota de las prácticas: ");
            notadelasPracticas1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nota del examen: ");
            notadelExamen1 = Convert.ToDouble(Console.ReadLine());
        }

        //Nomenclatura mal Primera letra en mayus + espacios, cambiado nombres y juntado 3 funciones que eran lo mismo
        /// <summary>
        /// Esta funcion calcula la nota, La nota está comupuesta  por 20 % de la nota de prácticas y 80 % de la nota del examen.
        /// <para>
        /// La nomenclatura estaba mal la primera letra era en mayusculas, he añadido saltos de linea y he juntado las 3 funciones
        /// </para>
        /// </summary>
        /// <param name="notaExamen"></param>
        /// <param name="notaPracticas"></param>
        /// <returns> double nota del trimestre que queremos calcular </returns>
        public double CalculodelaNota(double notaExamen, double notaPracticas)
        {
            double NotaTrimestre = (notaExamen * 0.8) + (notaPracticas) * 0.2;  
            return NotaTrimestre;
        }

        /// <summary>
        /// Calcula la media, le he cambiado el nombre para que se entienda más
        /// </summary>
        /// <returns>double Nota final del curso</returns>
        public double CalcularNotaFinal()
        {
            double NotaFinaldelCurso = (this.NotaTrimestr + this.NotadelSegungoTrimestre + this.NotadelTercerTrimestre) / 3; 
            return NotaFinaldelCurso;
        }

    }

    class ejemplodeunaAsignatura
    {

        //TODO
        /*
         *   
        static void main()
        {
           
            
            asignatura mi_asignatura_ejemplo = new asignatura("0521385", "Entornos  de Desarrollo");

         }
        */
    }
}


