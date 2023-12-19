namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo;
        private string IMEI;
        private int Memoria;

        protected bool isTurnedOn = false;
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            if (isTurnedOn)
            {
                Console.WriteLine("O celular já está ligado!");
                return;
            }
            isTurnedOn = true;
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            if (!isTurnedOn)
            {
                Console.WriteLine("O celular está desligado, primeiro ligue-o!");
                return;
            }
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}