using ConsoleApp1;


LeituraArquivo arquivo = new LeituraArquivo();

var (sucesso, Linhas, QntLinhas) = arquivo.LerArquivo("C:\\TA_BLZ\\Aula_2\\ConsoleApp1\\Arquivos\\TextFile1.txt");
if (sucesso)
{
    Console.WriteLine("o Numero de linhas no arquivo e: "+ QntLinhas);
    foreach (string linha in Linhas)
    {
        Console.WriteLine(linha);
    }
}else
{
    Console.WriteLine("Erro na leitura do arquivo");
}
