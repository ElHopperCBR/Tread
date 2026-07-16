using static System.Console;

static async Task Main()
{
    WriteLine("Pedido realizado.");
    Task cafe = PrepararCafe();
    Task hamburguer = PrepararHamburguer();
    Task batata = PrepararBatata();
    await Task.WhenAll(cafe, hamburguer, batata);
    WriteLine();
    WriteLine("Pedido entregue.");
}

static async Task PrepararCafe()
{
    WriteLine("Preparando café...");
    await Task.Delay(2000);
    WriteLine("Café pronto!");
}

static async Task PrepararHamburguer()
{
    WriteLine("Preparando hambúrguer...");
    await Task.Delay(3000);
    WriteLine("Hambúrguer pronto!");
}

static async Task PrepararBatata()
{
    WriteLine("Preparando batata...");
    await Task.Delay(2500);
    WriteLine("Batata pronta!");
}

try
{
await Main(); // Chamada do método Main para iniciar a execução do programa, porém sem aguardar sua conclusão, pois Main é um método assíncrono.
}

catch (Exception ex)
{
    WriteLine($"Ocorreu um erro: {ex.Message}");
}

finally
{
    WriteLine("Execução finalizada.");
}