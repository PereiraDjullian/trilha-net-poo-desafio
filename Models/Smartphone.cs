namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; set; }

        public string Imei { get; set; }

        public int Memoria { get; set; }

        public bool EstaLigado { get; set; }  //nova propriedade

        public int CapacidadeBateria { get; set; } //nova propriedade

        public Smartphone()
        {

        }

        public Smartphone(string numero, string modelo, string imei,int memoria,bool estaLigado, int capacidadeBateria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
            EstaLigado = estaLigado;
            CapacidadeBateria = capacidadeBateria;

        }

        public void Ligar()
        {
            if (!EstaLigado)
            {
                Console.WriteLine("Ligando . . .");
                EstaLigado = true;

            }
            else
            {
                Console.WriteLine("O smarthpgone já esta ligado.");
            }
        }

        public void Desligar()//novo método
        {
            if (EstaLigado)
            {
                Console.WriteLine("Desligando . . .");
                EstaLigado = false;
            }
            else
            {
                Console.WriteLine("O smarthpgone já esta desligado.");
            }
        }

        public void ReceberLigacao() //modificado
        {
            if (EstaLigado)
            {
                Console.WriteLine("Recebendo ligação...");
            }
            else
            {
                Console.WriteLine("O Smarthphone esta desligado nao pode receber ligação...");

            }
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}