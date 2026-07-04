##### **TITLE**
    ecommerce

##### **TYPE**
    small scale full stack rest api & web ui project

##### **REFERENCES**
    amazon, temu

##### **TECH STACK**
    C#
    ASP.NET Web API
    Identity
    EFCore
    JWT Bearer
    Stripe
    MSSQL
    Swagger
    Docker
    HTML
    CSS
    JavaScript
    React
    TanStack Query
    React Router Dom
    Cookie Parser
    JWT Decoder

##### **FRONTEND INSTALLATION**
    npm create vite@5;
    npm install;
    npm install react-router-dom cookie-parser jwt-decode axios @stripe/stripe-js @stripe/react-stripe-js @tanstack/react-query bootstrap-icons;
    npm run dev;

##### **BACKEND INSTALLATION**
    dotnet new webapi -o . --framework net10.0; (mkdir ./src; mkdir ./src/Entities | dotnet new classlib -n Entities)
    dotnet new sln -n ECommerceNTierAPI --format sln;
    dotnet sln add .;
    dotnet add package AutoMapper --version 12.0.1;
    dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection --version 12.0.1;
    dotnet add package Dapper;
    dotnet add package FluentMigrator;
    dotnet add package FluentMigrator.Runner.Core;
    dotnet add package FluentMigrator.Runner.SqlServer;
    dotnet add package FluentMigrator.Tools;
    dotnet add package FluentValidation;
    dotnet add package FluentValidation.AspNetCore;
    dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer;
    dotnet add package Microsoft.AspNetCore.Identity;
    dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    dotnet add package Microsoft.AspNetCore.OpenApi;
    dotnet add package Microsoft.Data.SqlClient;
    dotnet add package Microsoft.EntityFrameworkCore;
    dotnet add package Microsoft.EntityFrameworkCore.Design;
    dotnet add package Microsoft.EntityFrameworkCore.SqlServer;
    dotnet add package Microsoft.EntityFrameworkCore.Tools;
    dotnet add package Swashbuckle.AspNetCore;
    dotnet new tool-manifest;
    dotnet tool install dotnet-ef;
    dotnet build ./ECommerceNTierAPI.sln;
    dotnet ef migrations remove;
    dotnet ef database drop;
    mkdir ./src; mkdir ./src/Business ./src/Core ./src/Entities ./src/WebAPI ./src/DataAccessLayer; mkdir ./src/DataAccessLayer/Migrations;
    dotnet ef migrations add Init -o ./src/DataAccessLayer/Migrations;
    dotnet ef database update;
    dotnet run;
