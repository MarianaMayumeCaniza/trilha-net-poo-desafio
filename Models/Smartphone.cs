namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        //Propriedades da minha classe smartphone
        public string Numero { get; set; }
        private string modelo;
        private string imei;
        private int memoria;


        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            this.modelo = modelo;
            this.imei = imei;
            this.memoria = memoria;

            //Aqui estou passando todas as propriedades para a meu metodo Smartphone dentro da minha classe Smartphone
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}