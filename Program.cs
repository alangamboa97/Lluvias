using System;

namespace LLuvias
{
    class Program
    {
        static void Main(string[] args)
        {
           int filas, columnas, random;
           int suma =0, p=0;
           
           String[] estados = {"Sonora","Aguascalientes","Oaxaca","Colima","Chihuahua","San Luis","Durango","Veracruz","Yucatan","Tabasco"};
           
           
           int sonora =0;
           int aguas =0;
           int oaxaca =0;
           int colima =0;
           int chihuahua =0;
           int sanluis =0;
           int durango =0;
           int veracruz =0;
           int yucatan =0;
           int tabasco=0;
           int contador;
           

           Random r = new Random();
           int[,] lluvias = new int[10,12];
           

           for(filas=0;filas<10;filas++){ //llena las filas
               
               for(columnas=0; columnas<12; columnas++){ //llena las columnas
                
                   random = r.Next(1,101);
                   lluvias[filas,columnas] = random;
                   
                   Console.Write("{0}\t",random);
                  

                   
                   }
                    
                     Console.WriteLine();
            }       
           

            for(filas =0; filas <=0; filas++){
                for (columnas =0; columnas<12; columnas ++){
                    sonora = sonora + lluvias[filas,columnas];
                }

            }
            for(filas=1; filas<=1; filas++){
                for (columnas =0; columnas<12; columnas++){
                    aguas = aguas+ lluvias[filas,columnas];
                }
            }
            for(filas =2; filas<=2; filas++){
                for(columnas=0; columnas<12; columnas++){
                    oaxaca = oaxaca + lluvias[filas,columnas];
                }

            }
            for(filas =3; filas<=3; filas++){
                for(columnas=0; columnas<12; columnas++){
                    colima = colima + lluvias[filas,columnas];
                }

            }
            for(filas =4; filas<=4; filas++){
                for(columnas=0; columnas<12; columnas++){
                    chihuahua = chihuahua + lluvias[filas,columnas];
                }

            }for(filas =5; filas<=5; filas++){
                for(columnas=0; columnas<12; columnas++){
                    sanluis = sanluis + lluvias[filas,columnas];
                }

            }for(filas =6; filas<=6; filas++){
                for(columnas=0; columnas<12; columnas++){
                    durango = durango + lluvias[filas,columnas];
                }

            }for(filas =7; filas<=7; filas++){
                for(columnas=0; columnas<12; columnas++){
                    veracruz = veracruz + lluvias[filas,columnas];
                }

            }for(filas =8; filas<=8; filas++){
                for(columnas=0; columnas<12; columnas++){
                    yucatan = yucatan + lluvias[filas,columnas];
                }

            }for(filas =9; filas<=9; filas++){
                for(columnas=0; columnas<12; columnas++){
                    tabasco = tabasco + lluvias[filas,columnas];
                }
            }
                
            int[] lluviaestados = {sonora,colima,veracruz,chihuahua,durango,sanluis,tabasco,aguas,oaxaca};
           
          
        for(filas =0; filas <9; filas++){
            for(columnas=0; columnas <=0; columnas++){
                Console.Write("\t{0}", lluviaestados[filas]);
                Console.Write("\t{0}",estados[filas]);
                    
                
            }
            Console.WriteLine();

            
        }
      
        int [] lluviasordenadas = new int[10];
        
         //metodo de ordenamiento burbuja
        
        int t;
            for (int a = 1; a < lluviaestados.Length; a++){
                for (int b = lluviaestados.Length - 1; b >= a; b--)
                {
                    if (lluviaestados[b - 1] > lluviaestados[b])
                    {
                        t = lluviaestados[b - 1];
                        lluviaestados[b - 1] = lluviaestados[b];
                        lluviaestados[b] = t;
                    }
                }
            }
            
            //ordenamiento burbuja para aguascalientes
           
        Console.WriteLine("El estado con menor lluvias es :{0}",lluviaestados[0]);
        Console.WriteLine("El estado con mayor lluvia es : {0}", lluviaestados[8]);

         
            
          
           
            
     
        




     }
 }
}



