# .netcore-DDD-angular

### Back-End DB
- Criar usuario no banco de dados de acordo com arquivo <b>appsettings.json</b>

### Back-End Dotnet core 2.2
- Localizar via terminal aplicação <b>Examples.Charge.API</b>
- Executar no terminal `dotnet restore`
- Executar no terminal `dotnet run`
- Navegar na rota `http://localhost:5000/api/example` para Migrate do Database

### Back-End Opcional Docker
- Localizar container do docker SQL (arquivo <b>docker-compose</b> fica na raiz do projeto)
- Localizar container do docker da Aplicação (arquivo <b>DockerFile</b> fica dentro aplicação <b>Examples.Charge.API</b>)
- Executar no terminal `docker-compose up`
- Alterar ConnectionString na classe <b>Startup.cs</b>

### Front-End Angular 6
- Executar no terminal `npm install -g @angular/cli`
- Localizar pasta <b>Example.Charge.SPA</b>
- Executar no terminal `npm install` para instalar os pacotes
- Executar no terminal `ng serve` para rodar aplicação em `http://localhost:4200/`
- Caso tenha optado por Docker alterar a valor da prop <i>baseUrl</i>, trocar <i>baseUrlDotNetRun</i> por <i>baseUrlDocker</i> na classe <b>PersonPhoneService</b> em <i>src/app/person-phone/shared/person-phone-service.ts</i>
