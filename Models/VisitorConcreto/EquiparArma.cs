using System.Collections.Generic;
using VisitorPatron.Models.Clases;
using VisitorPatron.Models;

namespace VisitorPatron.Models.VisitorConcreto
{
    public class EquiparArma : IVisitante
    {
        public void Visitar(Mago m){
            m.Arma = "Daga";
        }

        public void Visitar(Guerrero g){
            g.Arma = "Hacha";
        }

        public void Visitar(List<IPersonaje> personajes){
            foreach (var item in personajes){
                item.Accept(this);
            }
        }
    }
}