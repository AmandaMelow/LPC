using System;

namespace HelloWorld
{
    public class CartaoCredito
    {
        public string numero { get; set; }

        public DateTime validade { get; set; }

        public Cliente cliente{ get; set; }
    }
}