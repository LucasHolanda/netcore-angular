# .netcore-DDD-angular

### Back-End DB
- criar usuario no banco de dados de acordo com arquivo appsettings.json

### Back-End Dotnet core 2.2
- localizar via terminal aplicação Examples.Charge.API
- dotnet restore
- dotnet run
- executar a rota /api/example no browser para Migrate do Database

### Back-End Opcional Docker
- localizar container do docker SQL (arquivo docker-compose fica na raiz do projeto)
- localizar container do docker da Aplicação (arquivo DockerFile fica dentro aplicação Examples.Charge.API)
- docker-compose up
- alterar ConnectionString na classe Startup.cs

### Front-End Angular 6
- npm install -g @angular/cli
- localizar pasta AngularSPA
- ng serve
- caso tenha optado por Docker basta alterar na classe <i>person-phone-service</i> a variavel 'baseUrlDotNetRun' por 'baseUrlDocker'
