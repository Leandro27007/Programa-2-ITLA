using Programa_2_ITLA;

//Creo un banco

Banco banco = new Banco("Ban reservas");

//Muestro el balance inicial del banco
banco.ImprimirLiquidezTotal();

//Creo un cliente
Cliente cliente1 = new Cliente("Juan");

//Le creo una cuenta al cliente al banco
banco.CrearCuentaBancaria(cliente1);

//Hago un deposito con el cliente1
cliente1.CuentaBancaria.Depositar(1800m);

//Muestro otra vez la liquidez del banco
banco.ImprimirLiquidezTotal();

//hago un retiro con el cliente1
cliente1.CuentaBancaria.Retirar(800m);

//Muestro otra vez la liquidez del banco
banco.ImprimirLiquidezTotal();


//Creo mas clientes, creo su cuenta bancaria y hago retiros y depositos
Cliente cliente2 = new Cliente("Pablo");
Cliente cliente3 = new Cliente("Pedro");

banco.CrearCuentaBancaria(cliente2);
banco.CrearCuentaBancaria(cliente3);

cliente2.CuentaBancaria.Depositar(452m);
cliente1.CuentaBancaria.Depositar(46m);
cliente3.CuentaBancaria.Depositar(488m);
cliente2.CuentaBancaria.Depositar(800m);

cliente2.CuentaBancaria.Retirar(100m);
cliente3.CuentaBancaria.Retirar(200m);
cliente2.CuentaBancaria.Retirar(100m);


//Muestro el balance inicial del banco
banco.ImprimirLiquidezTotal();

