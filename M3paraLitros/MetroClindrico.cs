using System;
namespace M3paraLitros
{
    class MetroClindrico
    {
        private double raio;
        private double altura;
        private double resultado { get; set; }
        private double resultadolitro { get; set; }

        public MetroClindrico(double raio, double altura)
        {
            this.raio = raio;
            this.altura = altura;
            Metro();
        }

        private void Metro()
        {
            this.resultado = Math.PI * Math.Pow(this.raio, 2) * this.altura;
            this.resultadolitro = Math.Round(resultado * 1000, 3);
        }

        public override string ToString()
        {
            return
                "M3 " + resultado.ToString() + "\r\n" +
                "Litro " + resultadolitro.ToString();
        }
    }
}