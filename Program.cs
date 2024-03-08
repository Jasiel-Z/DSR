namespace AppSinHilos;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("El Main thread comienza aquí");
        Console.WriteLine("Jasiel Zavaleta: Desarrollo de sistemas en red");

        Program.DoTrabajoPesado();

        Program.DoAalgo();

        Console.WriteLine("El Main thread termina aquí ");
        Console.WriteLine("Presiona cualquier tecla para terminar...");
        Console.ReadKey(true);



    }

    public static void DoTrabajoPesado(){
        Console.WriteLine("DoTrabajoPesado: Estoy levantando un camión!!\n");
        Thread.Sleep(1000);

        Console.WriteLine("DoTrabajoPesado: Cansado! Necesito una siesta de 3 seg.\n");
        Thread.Sleep(1000);

        Console.WriteLine("DoTrabajoPesado: 1...\n");
        Thread.Sleep(1000);
        
        Console.WriteLine("DoTrabajoPesado: 2...\n");
        Thread.Sleep(1000);

        Console.WriteLine("DoTrabajoPesado: 3...\n");
        Console.WriteLine("DoTrabajoPesado: Ya desperté del sueño");

    }
    
    private static void DoAalgo(){
        Console.WriteLine("DoAlgo: Oye! Haciendo algo aquí\n");
        for(int i=0; i < 20; i++){
            Console.WriteLine($"{i}");
        }
        Console.WriteLine();
        Console.WriteLine("DoAlgo: Ya terminé");
   
 
    }


}
