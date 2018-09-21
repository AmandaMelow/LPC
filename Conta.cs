namespace HelloWorld
{
    
    public class Conta
    {
        public int id;

        public string Cliente;

        public decimal saldo;

        public decimal limite=100;

        public int Agencia;

        public Conta(int id, string Cliente, decimal saldo, decimal limite,int Agencia) {
            this.id = id;
            this.Cliente = Cliente;
            this.saldo = saldo;            
            this.limite = 100;
            this.Agencia = Agencia; 
        }

     public string Sacar (decimal valor) {
         
        if (this.saldo < valor && this.saldo < limite){
            return "SALDO INSUFICIENTE!!";
        }else{
            this.saldo -=  valor;
            return $"SAQUE EFETUADO COM SUCESSO. SALDO RESTANTE R$ {this.saldo} ";
        }
     }

     public string Depositar (decimal valor){
         this.saldo += valor;
         return $"DEPOSITO REALIZADO COM SUCESSO. SALDO RESTANTE R$ {this.saldo} ";
     }

     public string Transferir (Conta Destino, decimal valor){
            this.saldo -= valor;
            Destino.saldo += valor;
            return $"DEPOSITO REALIZADO COM SUCESSO. SALDO RESTANTE R$ {this.saldo}";
     }
        public string GetSaldo()
        {
            return $"SALDO DA CONTA: R$ {this.saldo}";
        }
        
    }
  
 }
