using VisitorPatron.Models;

namespace VisitorPatron.Models.Clases
{
    public class Mago : IPersonaje
    {

        public string Arma { get; set; }


        public Mago()
        {
            Arma = "Daga";
        }

        


        public void Accept(IVisitante visitante)
        {
            visitante.Visitar(this);
        }
    }
}