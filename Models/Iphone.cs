namespace DesafioPOO.Models
{
    // Classe Iphone herda da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }

        // Método "InstalarAplicativo" sobrescrito
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Aplicativo para Iphone {Modelo}: {nomeApp} instalado.");
        }
    }
}