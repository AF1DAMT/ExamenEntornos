using System;


//namespace EDexamenT6a8


/*Clase que representa la gestíon de las notas para una asignatura.
 * Se puede(métodos): Introducir la asignatura
 *                    Registrar las notas de prácticas y examen para cada evaluación.
 *                    Calcular las notas por cada trimestre.
 *                    Calcular la nota final de curso.
 * Estos comentarios se deben eliminar y usar comentarios de documentación en su lugar.
 */


class Asignatura
    {
    public Asignatura(string CodigodelaAsignatura, string NombredelaAsignatura, double NotadelPrimertrimestre, double NotadelSegungoTrimestre, double NotadelTercerTrimestre, double NotaFinaldelCurso)
    {  
    this.CodigodelaAsignatura  = CodigodelaAsignatura; //Codigo de la asignatura.
    this.NombredelaAsignatura = NombredelaAsignatura; //Nombre de la asignatura.
    // Nota de los trimestres (1, 2   y 3) y nota final.
    this.NotadelPrimertrimestre = NotadelPrimertrimestre; 
    this.NotadelSegungoTrimestre = NotadelSegungoTrimestre;
    this.NotadelTercerTrimestre = NotadelTercerTrimestre;
    this.NotaFinaldelCurso = NotaFinaldelCurso;
    }



            public string CodigodelaAsignatura;
            public string NombredelaAsignatura;
            public double NotadelPrimertrimestre;
            public double NotadelSegungoTrimestre;
            public double NotadelTercerTrimestre;
            public double NotaFinaldelCurso;



        public void IntroducirMateria(string Cod_de_Asignatura, string Nombre_de_Asignatura)
        {this.CodigodelaAsignatura = Cod_de_Asignatura; this.NombredelaAsignatura = Nombre_de_Asignatura;
        
        }

        public void IntroducirlasNotas(double notadelExamen1, double notadelExamen2, double notadelExamen3, double notadelasPracticas1, double notadelasPracticas2, double notadelasPracticas3)
        {
        
            {
                for (int i=1;i<4;i++)
                {   Console.WriteLine("Trimestre evaluado 1, 2 ó 3: ");
                    var Trimestre=Console.ReadLine();




                    switch (Trimestre)
                    {   case "1": Console.WriteLine("Nota de las prácticas: ");
                            notadelasPracticas1=Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Nota del examen: ");
                            notadelExamen1=Convert.ToDouble(Console.ReadLine());
                            break;

                        case "2": Console.WriteLine("Nota de las prácticas: ");
                            notadelasPracticas2=Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Nota del examen: ");
                            notadelExamen2=Convert.ToDouble(Console.ReadLine());
                            break;

                        case "3": Console.WriteLine("Nota de las prácticas: ");
                            notadelasPracticas3=Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Nota del examen: ");
                            notadelExamen3=Convert.ToDouble(Console.ReadLine());
                            break;}
               

                }

            }
        }









    public double calculodelaNota1(double notadelExamen1, double notadelasPracticas1)
    {    this.NotadelPrimertrimestre=(notadelExamen1*0.8)+(notadelasPracticas1)*0.2; //La nota está comupuesta  por 20 % de la nota de prácticas y 80 % de la nota del examen. 
    return this.NotadelPrimertrimestre;}
    public double calculodelaNota2(double notadelExamen2, double notadelasPracticas2)
    {   this.NotadelSegungoTrimestre=(notadelExamen2*0.8)+(notadelasPracticas2)*0.2;
        return this.NotadelSegungoTrimestre;}
    public double calculodelaNota3(double notadelExamen3, double notadelasPracticas3)
    {   this.NotadelTercerTrimestre=(notadelExamen3*0.8)+(notadelasPracticas3)*0.2;
        return this.NotadelTercerTrimestre;}
    public double Calculodelamedia()
    {   this.NotaFinaldelCurso=(this.NotadelPrimertrimestre+this.NotadelSegungoTrimestre+this.NotadelTercerTrimestre)/3; //Nota final del curso
        return this.NotaFinaldelCurso;}

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