# .netcore-DDD-angular

### Banco de Dados
- Criar um usuario no banco de dados de acordo com arquivo <b>appsettings.json</b> localizado no projeto Back-End <b>Examples.Charge.API</b> 

### Back-End Dotnet Core 2.2 (Necessita do .NET Core 2.2 SDK e .NET Core 2.2 Runtime)
- Localizar pasta do projeto <b>Examples.Charge.API</b>
- Executar no terminal `dotnet restore`
- Executar no terminal `dotnet run`
- Navegar na rota `http://localhost:5000/api/example` para Migrate do Database

### Back-End Opcional Docker
- Localizar container do docker SQL (arquivo <b>docker-compose</b> fica na raiz do projeto)
- Localizar container do docker da Aplicação (arquivo <b>DockerFile</b> fica dentro projeto <b>Examples.Charge.API</b>)
- Executar no terminal `docker-compose up`
- Alterar <i>ConnectionString</i> na classe <b>Startup.cs</b>

### Front-End Angular 
- Executar no terminal `npm install -g @angular/cli`
- Localizar pasta do projeto <b>Example.Charge.SPA</b>
- Executar no terminal `npm install` para instalação dos pacotes do projeto
- Executar no terminal `ng serve` para rodar aplicação em `http://localhost:4200/`
- Caso tenha optado por Docker alterar a valor da prop <i>baseUrl</i>, trocar <i>baseUrlDotNetRun</i> por <i>baseUrlDocker</i> na classe <b>PersonPhoneService</b> em <i>src/app/person-phone/shared/person-phone-service.ts</i>
