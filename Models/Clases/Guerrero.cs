
using VisitorPatron.Models.VisitorConcreto;

namespace VisitorPatron.Models.Clases
{
    public class Guerrero : IPersonaje
    {
        public string Arma { get; set; }
        public Guerrero()
        {   
            Arma="Hacha";
        }

        public void Accept(IVisitante visitante)
        {
            visitante.Visitar(this);
        }
    }
}