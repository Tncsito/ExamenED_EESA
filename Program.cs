namespace ExamenED_EESA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Datos.Datos datos = new Datos.Datos();
            //############################################################
            /*Dada la siguiente tabla de productos por vendedores, 
             * cree un programa que utilice un arreglo bidimensional 
             * para calcular la ganancia de la venta por producto y 
             * la ganancia generada por cada vendedor.*/
            datos.uno();
            //############################################################
            /*Cree un programa que, dado el CURP de una persona, pueda 
             * determinar su sexo y fecha de nacimiento.*/
            //datos.dos();
            //############################################################
            /*Se tiene un arreglo unidimensional de 100 números enteros, 
             * que representa las calificaciones de un grupo de 
             * estudiantes. Los números están desordenados.*/
            //datos.tres();
            //############################################################
        }
    }
}