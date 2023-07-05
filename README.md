# Traz Ins Rest API - ASP.NET App

Es necesario incluir la variable de entorno DB_CONNECTION en un archivo .env

## Install dependencies

    dotnet restore

## Apply Migrations

    dotnet ef database update

## Run application

    dotnet run

## API

`GET /material`

Lista de materiales disponibles

`POST /registro`

Crear un nuevo registro
