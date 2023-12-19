namespace DesafioPOO.Models
{
    public class Iphone: Smartphone
    {
        public Iphone(
            string numero, 
            string modelo, 
            string imei, 
            int memoria) : base(numero, modelo, imei, memoria)
        {
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            if (!isTurnedOn)
            {
                Console.WriteLine("O celular está desligado, primeiro ligue-o!");
                return;
            }
            Console.WriteLine($"Instalando {nomeApp} na AppStore...");
        }
    }
}