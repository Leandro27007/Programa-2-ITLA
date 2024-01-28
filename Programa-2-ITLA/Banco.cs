namespace Programa_2_ITLA
{
    public class Banco
    {
        public string Nombre { get; private set; }

        private List<Cliente> clientes = new();
        private List<CuentaBancaria> cuentasBancarias { get; set; } = new();
        private decimal LiquidezTotal {get; set;}


        public Banco(string nombre)
        {
            this.Nombre = nombre;
        }

        private void CalcularLiquidezTotal()
        {
            decimal retirosTotal = cuentasBancarias.Select(x => x.Retiros.Select(x => x.Cantidad).Sum()).ToList().Sum();
            decimal depositosTotal = cuentasBancarias.Select(x => x.Depositos.Select(x => x.Cantidad).Sum()).ToList().Sum();

            LiquidezTotal = depositosTotal - retirosTotal;
        }

        public void ImprimirLiquidezTotal()
        {
            CalcularLiquidezTotal();
            Console.WriteLine($"-----------------------------------------------------------------");
            Console.WriteLine($"La liquidez total del banco es: {LiquidezTotal}$");
            Console.WriteLine($"-----------------------------------------------------------------");
        }

        public void CrearCuentaBancaria(Cliente cliente) 
        {
            //Restriccion no mas de 3 clientes.
            if(clientes.Count == 3)
            {
                Console.WriteLine("El banco alcanzo su limite de clientes");
                return;
            }

            
            CuentaBancaria cuenta = new(cliente, this);
            cliente.SetCuentaBancaria(cuenta);

            clientes.Add(cliente);
            cuentasBancarias.Add(cuenta);
        }

    }
}