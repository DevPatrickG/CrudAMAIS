<h1> ETAPAS DO PROJETO </h2>
<h3> ARQUITETURA DO PROJETO </h3>
° IDE - Visual Studio 2022 .Net Core 6.0 <br>
° Pacotes NuGet: Microsoft.AspNet.Mvc 5.2.9 <br>
° Pacotes NuGet: Microsoft.EntityFrameworkCore 6.0.6 <br>
° Pacotes NuGet: Microsoft.EntityFrameworkCore.Design 6.0.6 <br>
° Pacotes NuGet: Microsoft.EntityFrameworkCore.SqlServer 6.0.6 <br>
° Pacotes NuGet: Microsoft.EntityFrameworkCore.Tools 6.0.6 <br>
° Pacotes NuGet: Microsoft.VisualStudio.Web.CodeGeneration.Design 6.0.6 <br>

<b>Foi optada essa arquitetura mais recente, pois possuem manuseamentos essênciais nas quais utilizei nesse CRUD.</b>
<h3> Banco de dados </h3>
Executei o Migration onde se criou o banco de dados no SQL dentro do próprio Visual Studio. <br>
Fui em Ferramentas > Gerenciador de Pacotes do NuGet > Console do Gerenciador de Pacotes <br>
<b> OBS: Lembrem-se de mudar o caminho do banco de dados para o local de sua maquina no "Program.cs", na linha 17, pois está configurado com o caminho de minha maquina. </b> <br>

Executei os comandos na seguinte ordem: <br>
1° Add-Migration Inicial-criacao -Context Contexto (Se cria a estrutura da Tabela) <br>
2° Update-database -Context Contexto (Se cria a base de dados) <br>
<b>Se criou uma Tabela:</b><br> [RA] <b>(PRIMARY-KEY)</b> Varchar(256), <br> [Nome] Varchar(256), <br> [Email] Varchar(256), <br> [Cpf] Varchar(256).<br>

<h3> Observações Finais </h3>
- Minhas Melhorias caso tivesse mais tempo: Realizar uma mensagem de retorno informando que já existe o cadastro, caso o RA inserido já exista no sistema, através da chave Primaria, <br>
- Criar uma textBox para consultar Alunos através do RA, <br>
- Melhorar o Front-END. <br> <br>

Teste para a vaga de Desenvolvedor - FullStack Web
