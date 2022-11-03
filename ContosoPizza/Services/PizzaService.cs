using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoPizza.Models;

namespace ContosoPizza.Services
{
    public static class PizzaService
    {
        // Atributos
        static List<Pizza> Pizzas {get;}
        static int nextId = 7;
        
        // Construtor
        static PizzaService()
        {
            Pizzas = new List<Pizza> 
            {
                new Pizza {Id = 1, Name = "Italiana (Clássica)", IsGlutenFree = false },
                new Pizza {Id = 2, Name = "Calabresa", IsGlutenFree = false },
                new Pizza {Id = 3, Name = "Frango com Catupiri", IsGlutenFree = false },
                new Pizza {Id = 4, Name = "Presunto e Queijo", IsGlutenFree = false },
                new Pizza {Id = 5, Name = "Pizza Doce", IsGlutenFree = false },
                new Pizza {Id = 6, Name = "Vegana", IsGlutenFree = true }
            };
        }

        // Metodos
        public static List<Pizza> GetAll() => Pizzas; // lista todas as pizzas
        public static Pizza? Get(int id) => Pizzas.FirstOrDefault(p => p.Id == id); // retorna pizza por id
        public static void Add(Pizza pizza) // adiciona nova pizza
        {
            pizza.Id = nextId++;
            Pizzas.Add(pizza);
        }
        public static void Delete(int id)
        {
            var pizza = Get(id);
            if(pizza is null)
            {
                return;
            }
            Pizzas.Remove(pizza); 
        }
        public static void Update(Pizza pizza){
            var index = Pizzas.FindIndex(p => p.Id == pizza.Id);
            if(pizza is null)
            {
                return;
            }
            Pizzas[index] = pizza;
        }
    }
}