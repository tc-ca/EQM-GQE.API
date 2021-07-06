# EQM-GQE.API
Enterprise Questionnaire Management - Gestion des questionnaires d'entreprise Microservice

## Project Setup

**PostgreSQL**

For local setup download and install postgreSQL.

[Download PostgreSQL](https://www.postgresql.org/download/)


**Connection Strings**

Add the connection string to your user secerts in the EQM-GQE.API project, update the values to match the progresSQL db you are trying to connect too.

**Example string**

```JSON
"ConnectionStrings": {
    "EQMConnection": "User ID='userid'; Password='password'; Server=dbserver;Port=5432;Database=dbname;Integrated Security=true;Pooling=true;"
  }
```


## Database Migrations
In the EQM-GQE.DATA project run the following command to add a database migration.
```
dotnet ef --startup-project ../EQM-GQE.API migrations add *NameOfMigration* -c QuestionnaireContext
```

## VS Code extentions

Name: VSC Export & Import

VS Marketplace Link: https://marketplace.visualstudio.com/items?itemName=aslamanver.vsc-export

Use this extention along with the vsc-extensions.txt file in the repo to download the needed extentions for the project.

## Terraform for Azure Portal


