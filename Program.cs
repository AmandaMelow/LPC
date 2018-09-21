using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            CartaoCredito cartao1 = new CartaoCredito();
            cartao1.numero = "789456123";
            cartao1.validade = DateTime.Now;

            CartaoCredito cartao2 = new CartaoCredito()
            {
                numero = "321654987",
                validade = DateTime.Now
            };
            Console.WriteLine($"O numero do cartão1 é: {cartao1.numero} A validade do cartão2 é: {cartao2.validade}");

            Agencia agencia1 = new Agencia(0001);
            
            Agencia agencia2 = new Agencia(0002);
           
            Console.WriteLine($"A agencia de torres é: {agencia1.numero} A agencia de Capao é: {agencia2.numero} ");

            /* Conta contaA = new Conta()
            {
                id = 01,
                Cliente = "Amanda",
                saldo = 900,
                limite = 100,
                numeroAG = 0001;
            }; */

           /*  Conta contaB = new Conta()
            {
                id = 02,
                Cliente = "Maria",
                saldo = 1000,
                limite = 200,
            }; */

            Conta contaA = new Conta (01, "Amanda", 900, 100, 0001);
            Conta contaB = new Conta (02, "Maria", 1000, 200, 0002);

            Console.WriteLine($"Nome do cliente: {contaA.Cliente}  | Saldo R$: {contaA.saldo}  | Limite R$: {contaA.limite}");
            Console.WriteLine($"Nome do cliente: {contaB.Cliente}  | Saldo R$: {contaB.saldo}  | Limite R$: {contaB.limite}");
        
        
            contaA.Depositar(500);
            Console.WriteLine($"Nome do cliente: {contaA.Cliente}  | Saldo R$: {contaA.saldo}  | Limite R$: {contaA.limite}");
            contaA.Sacar(1000);
            Console.WriteLine($"Nome do cliente: {contaA.Cliente}  | Saldo R$: {contaA.saldo}  | Limite R$: {contaA.limite}");
            Console.WriteLine($"Nome do cliente: {contaB.Cliente}  | Saldo R$: {contaB.saldo}  | Limite R$: {contaB.limite}");
            contaA.Transferir(contaB, 400);
            Console.WriteLine($"Nome do cliente: {contaA.Cliente}  | Saldo R$: {contaA.saldo}  | Limite R$: {contaA.limite}");

        }
    }
}
