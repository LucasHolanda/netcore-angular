# .netcore-DDD-angular

### Back-End Dotnet core 2.2
- localizar via terminal aplicação Examples.Charge.API
- dotnet restore
- dotnet run

### Back-End Opcional Docker
- localizar container do docker SQL (arquivo docker-compose fica na raiz do projeto)
- localizar container do docker da Aplicação (arquivo DockerFile fica dentro aplicação Examples.Charge.API)
- docker-compose up
- alterar ConnectionString na classe Startup.cs

### Front-End Angular 6
- localizar pasta AngularSPA
- ng serve
- caso tenha optado por Docker basta alterar na classe <b>person-phone-service</b> a variavel 'baseUrlDotNetRun' por 'baseUrlDocker'
