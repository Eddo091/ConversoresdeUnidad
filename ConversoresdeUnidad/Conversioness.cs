using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversoresdeUnidad
{
    class Conversioness
    {
        public string[][] conversor = {
            new string[]{"Dolares","Euros","Quetzalez","Lempira","Cordobas","Colon CR","Dolar Canadience","Peso Chileno","Peso Arg","Yen JPY","Won SurCoreano","Won Norcoreano","MXN","Rupia India","Corona Danesa","Dirham Marroqui", "Escudo caboverdiano", "Pula botsuanés", "Dolar bahameño", "Corona noruega"}, //monedas
            new string[]{"Metros","CM","Pulgadas","Pie","Varas","Yardas"}, //Longitud
            new string[]{"Libra","Gramos","Kilogramos","Onzas","Quintales"} //Peso

        };
        double[][] valores = {
            new double[]{1,0.92,7.65,24.9,34.22,572.26,1.33458,813.003,62.0138, 110.315, 1216.21, 900.072, 19.3635, 71.6572, 6.85392, 9.68004, 101.144, 11.0795, 1.00000, 9.39713}, //monedas
            new double[]{1,100,39.37,3.281,1.196,1.094}, //Longitud
            new double[]{1,0.001, 0.453592, 16, 0.000453592} //Peso
        };
        public double convertir(int opcion, int de, int a, double cantidad)
        {
            return valores[opcion][a] / valores[opcion][de] * cantidad;
        }
    }
}
