using System.Text.Json;

namespace ArquivoJson.Modelos;

internal class EmailJson
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Email { get; set; }

    public EmailJson(string nome, int idade, string email)
    {
        Nome = nome;
        Idade = idade;
        Email = email;
    }

    public  void ConverterJson( EmailJson email)
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            idade = Idade,
            email = Email
        });

        string nomeDoArquivo = $"email-{Nome}.json";

        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine($"O arquivo {nomeDoArquivo} foi criado com sucesso no {Path.GetFullPath(nomeDoArquivo)}");
        Console.WriteLine();
    }
}
