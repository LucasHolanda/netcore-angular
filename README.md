# .netcore-DDD-angular

### Back-End DB
- criar usuario no banco de dados de acordo com arquivo <b>appsettings.json<b>

### Back-End Dotnet core 2.2
- localizar via terminal aplicação <b>Examples.Charge.API<b>
- dotnet restore
- dotnet run
- executar a rota <i>/api/example</i> no browser para Migrate do Database

### Back-End Opcional Docker
- localizar container do docker SQL (arquivo <b>docker-compose</b> fica na raiz do projeto)
- localizar container do docker da Aplicação (arquivo <b>DockerFile</b> fica dentro aplicação <b>Examples.Charge.API</b>)
- docker-compose up
- alterar ConnectionString na classe <b>Startup.cs</b>

### Front-End Angular 6
- npm install -g @angular/cli
- localizar pasta <b>Example.Charge.SPA</b>
- ng serve
- caso tenha optado por Docker alterar a variavel 'baseUrlDotNetRun' por 'baseUrlDocker' na classe <b>person-phone-service.ts</b> em <i>src/app/person-phone/shared</i>
