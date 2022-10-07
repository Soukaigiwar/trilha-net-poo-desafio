namespace DesafioPOO.Models
{
    // Classe Nokia herda da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }
        // Método "InstalarAplicativo" sobrescrito
        public override void InstalarAplicativo(string nomeApp)
        {
            System.Console.WriteLine($"Aplicativo para Nokia modelo {Modelo}: {nomeApp} instalado.");
        }
    }
}