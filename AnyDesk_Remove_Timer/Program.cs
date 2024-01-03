string path = Environment.ExpandEnvironmentVariables(@"%AppData%\AnyDesk");
bool existeDiretorio = Directory.Exists(path);

if (existeDiretorio)
{
    try
    {
        Directory.Delete(path, true);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"[{DateTime.Now}] Anydesk resetado");
    }
    catch (Exception ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"[{DateTime.Now}] Erro: {ex.Message}");
    }

}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"[{DateTime.Now}] Anydesk não encontrado, abra o AnyDesk, feche e tente novamente");
}

Console.ReadKey();
