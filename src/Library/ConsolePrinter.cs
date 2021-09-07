using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter
    {
        public static void PrintRecipe(string recipeText)
        {
            Console.WriteLine(recipeText);
        }
    }
    /*Esta es la clase que inprime toda la reseta, fue creada pensando en los principios SOLID.
    Porque, si bien lo unico que hace hasta el momento es imprimir en pantalla, si en el fututro 
    se quisiera imprimri en una impresa, o se quisieran enviar el texto a algun otro lado, 
    la clase recipe, que es la que poseia esta responsabilidad de imprimir el texto, tendria mas de un
    motivo para cambiar, por lo que estaria incumpliendo el principio de responsabilidad unica */
}