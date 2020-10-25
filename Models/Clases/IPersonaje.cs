

using VisitorPatron.Models.VisitorConcreto;

namespace VisitorPatron.Models.Clases
{
    public interface IPersonaje
    {
        public void Accept(IVisitante visitante);
    }
}