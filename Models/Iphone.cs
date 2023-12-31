namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria, bool estaLigado, int capacidadeBateria)
        : base(numero, modelo, imei, memoria, estaLigado, capacidadeBateria)
        {

        }
        public override void InstalarAplicativo(string nomeApp)//modificado
        {
            if (EstaLigado)
            {
                Console.WriteLine($"Instalando o aplicativo {nomeApp} no Iphone.");
            }
            else
            {
                Console.WriteLine($"O IPHONE esta desligado , nao pode instalar nenhum app. ");
            }
        }
    }
}