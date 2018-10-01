using System;

namespace LLuvias
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Random random = new Random();
            String x = "",y = "",z = "";
            int precipitacion;
            int mayorlluvia = 0;
            int mayorAguas = 0;
            int menor = 250;

            int[,] lluvias = new int[10, 12];

            String[] estados = new String[10] { "Sonora:\t", "Aguascalientes:", "Oaxaca:\t", "Colima:\t"
                , "Chihuahua","San Luis Potosí:","Durango:","Veracruz:","Yucatan\t","Durango\t" };

            String[] meses = new String[12] {"Enero","Febrero","Marzo","Abril","Mayo","Junio","Julio","Agosto","Septiembre","Octubre","Noviembre","Diciembre"};
                
            int[] promedio = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            
            for (int i = 0; i < 10; i++)
            {
                Console.Write(estados[i] + "\t");
                for (int j = 0; j < 12; j++)
                {
                    precipitacion = random.Next(0, 251);// genera los va
                    lluvias[i, j] = precipitacion;

                    Console.Write(lluvias[i, j] + "\t");
                    if (lluvias[1, j] > mayorAguas)
                    {
                        mayorAguas = lluvias[1, j];
                        z = meses[j];
                    }
                    promedio[i] = promedio[i] + lluvias[i, j];
                }
                promedio[i] = promedio[i] / 12; //calcula el promedio de lluvias por cada estado
                
                if (promedio[i] > mayorlluvia) { //devuelve el nombre del estado con mas lluvias
                    mayorlluvia = promedio[i];
                    x = estados[i];
                }
                if (promedio[i] < menor) { //devuelve el nombre del estado con menor lluvias
                    menor = promedio[i];
                    y = estados[i];
                }
                Console.WriteLine(promedio[i]);
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Estado con mas lluvias: "+x+ "con :"+mayorlluvia);
            Console.WriteLine("Estado con menor lluvias: " + y + "con :" + menor);
            Console.WriteLine("El mes con mas lluvias en Aguascalientes fue " + z + " con :" + mayorAguas);
            
            
        }
            
          
    }
}



         
            
          
           
            
     
        




     
 




