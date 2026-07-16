using static System.Console;

WriteLine("Iniciando o programa de testes...");

Thread minhaThread = new Thread(PreparaCafe); //Para gerenciar operação assincrona, é necessário criar uma thread separada para a operação de preparo do café.

minhaThread.Start();

WriteLine("Enquanto o café está sendo preparado, você pode fazer outras coisas...");
Thread.Sleep(3000);
WriteLine("Pode atender outros clientes, ler um livro, ou até mesmo tomar um banho.");
ReadKey();


static void PreparaCafe()
{
    WriteLine("Preparando o café...");
    Thread.Sleep(2000);
    WriteLine("Café pronto!");
}