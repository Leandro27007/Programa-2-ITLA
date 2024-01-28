namespace Programa_2_ITLA
{
    public class Cliente
    {
        public string Nombre { get; private set; }
        private CuentaBancaria _cuentaBancaria;

        public CuentaBancaria CuentaBancaria 
        { 
            get { return this._cuentaBancaria; } 
            private set { _cuentaBancaria = value; } 
        }

        public Cliente(string nombre)
        {
            this.Nombre = nombre;
        }

        public void SetCuentaBancaria(CuentaBancaria cuenta)
        {
            this.CuentaBancaria = cuenta;
        }

    }
}
