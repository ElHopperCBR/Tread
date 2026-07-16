using static System.Console;

WriteLine("Iniciando o programa de testes...");

Thread minhaThread = new Thread(PreparaCafe);

minhaThread.Start();

WriteLine("Enquanto o café está sendo preparado, você pode fazer outras coisas...");
ReadKey();


static void PreparaCafe()
{
    WriteLine("Preparando o café...");
    Thread.Sleep(2000);
    WriteLine("Café pronto!");
}