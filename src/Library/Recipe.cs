//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;
using System.Text;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }

        public double GetProductCost() // Este metodo calcula el total del producto. Se implemento sigueindo los principios SOLID  patrones GRASP
        {
            double sumatoriaTotal = 0;
            foreach (Step item in steps)
            {
                sumatoriaTotal+=item.StepTotal();
            }
            return sumatoriaTotal;
        }

        public string GetRecipeText() 
        {
            StringBuilder recipeText = new StringBuilder($"Receta de {this.FinalProduct.Description}:\n");
            foreach (Step step in this.steps)
            {
                recipeText.Append($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time} minutos.\n");
            }
            recipeText.Append($"Total: {this.GetProductCost()}"); // Aca agrego el total al texto.
            return recipeText.ToString();
        }
        /* Aca estoy haciendo uso del patron expert, ya que como la clase recipe es la que contiene 
        todos los datos necesarios para armar el texto a imprimir, creo un metodo que haga esa labor.
        Porque si lo hiciera en "ConsolePrinter" estaria incumpliendo dicho patron. °o° */
    }
}