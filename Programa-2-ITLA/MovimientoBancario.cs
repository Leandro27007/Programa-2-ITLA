namespace Programa_2_ITLA
{
    public abstract class MovimientoBancario
    {
        private DateTime Fecha { get;  set; }
        public MovimientoBancario()
        {
            Fecha = new();
            Fecha = DateTime.Now;
        }

    }
}
