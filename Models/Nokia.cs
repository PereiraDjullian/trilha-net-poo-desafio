namespace DesafioPOO.Models
{
    
    public class Nokia : Smartphone
    {

        public Nokia(string numero, string modelo, string imei, int memoria, bool estaLigado, int capacidadeBateria)
                :base(numero, modelo, imei, memoria, estaLigado, capacidadeBateria)
        {
            EstaLigado = false;
        }
        public override void InstalarAplicativo(string nomeApp)//modificado
        {
           if (EstaLigado)
            {
                Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia.");
            }
            else
            {
                Console.WriteLine($"O NOKIA esta desligado , nao pode instalar nenhum app. ");
            }
        }
    }
}