namespace Programa_2_ITLA
{
    public class CuentaBancaria
    {
        private Banco Banco { get; set; }
        private Cliente Cliente { get; set; }
        public List<Retiro> Retiros { get; set; } = new List<Retiro>();
        public List<Deposito> Depositos { get; set; } = new List<Deposito>();

        public CuentaBancaria(Cliente cliente, Banco banco)
        {
            this.Banco = banco;
            this.Cliente = cliente;
        }


        public void Retirar(decimal cantidad)
        {
            Console.WriteLine($@"El cliente {Cliente.Nombre}  retiro la cantidad: {cantidad} de su cuenta bancaria

            ");
            this.Retiros.Add(new Retiro { Cantidad = cantidad});
        }
        
        public void Depositar(decimal cantidad)
        {
            Console.WriteLine($@"El cliente {Cliente.Nombre} deposito la cantidad: {cantidad} a su cuenta bancaria

            ");
            this.Depositos.Add(new Deposito { Cantidad= cantidad});
        }


    }
}
