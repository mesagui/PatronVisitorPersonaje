using VisitorPatron.Models;

namespace VisitorPatron.Models.Clases
{
    public class Mago : IPersonaje
    {
        public Mago()
        {
            Arma = "Daga";
        }

        public string Arma { get; set; }


        public void Accept(IVisitante visitante)
        {
            visitante.Visitar(this);
        }
    }
}