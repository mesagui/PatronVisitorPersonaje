using System.Collections.Generic;
using VisitorPatron.Models.Clases;

namespace VisitorPatron.Models
{
    public interface IVisitante
    {
        public void Visitar(Guerrero g);
        public void Visitar(Mago m);
        public void Visitar(List<IPersonaje> personajes);
    }
}