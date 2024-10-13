using ArquivoJson.Modelos;
using System.Text.Json;

EmailJson vitoremail = new("Vitor", 25, "vitor.email@gmail.com");
vitoremail.ConverterJson(vitoremail);

using(HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("C:\\Users\\vitor\\OneDrive\\Área de Trabalho\\Área de trabalho\\.CursoC#-alura\\Projetos\\API\\ArquivoJson\\bin\\Debug\\net8.0\\email-Vitor-json");
        var emailCadastrado = JsonSerializer.Deserialize<EmailJson>(resposta);
        vitoremail.ConverterJson(emailCadastrado);
    }
    catch(Exception ex)
    {
        Console.WriteLine($"Erro: {ex.Message}");
    }
}
