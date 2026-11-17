namespace Tarea
{
    public class ConversorTemperatura
    {
        public decimal Convertir(decimal valor, string origen, string destino)
        {
            decimal celsius = 0;

            switch (origen)
            {
                case "Celsius (°C)":
                    celsius = valor;
                    break;

                case "Fahrenheit (°F)":
                    celsius = (valor - 32) * 5 / 9;
                    break;

                case "Kelvin (K)":
                    celsius = valor - 273.15m;
                    break;
            }

            switch (destino)
            {
                case "Celsius (°C)":
                    return celsius;

                case "Fahrenheit (°F)":
                    return (celsius * 9 / 5) + 32;

                case "Kelvin (K)":
                    return celsius + 273.15m;

                default:
                    return celsius;
            }
        }
    }
}