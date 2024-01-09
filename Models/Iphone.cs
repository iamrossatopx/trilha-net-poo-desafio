namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria){}

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string appName){
            Console.WriteLine($"Buscando {appName} na AppStore...");
            Console.WriteLine($"{appName} encontrado!");
            Console.WriteLine($"Instalando aplicativo {appName}...");
            Console.WriteLine($"{appName} instalado com sucesso!");
        }
    }
}