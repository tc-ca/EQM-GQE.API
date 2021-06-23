# EQM-GQE.API
Enterprise Questionnaire Management - Gestion des questionnaires d'entreprise Microservice

## Project Setup

**Connection Strings**

Add the connection string to your user secerts in the EQM-GQE.API project, update the values to match the progresSQL db you are trying to connect too.

**Example string**

```JSON
"ConnectionStrings": {
    "EQMConnection": "User ID='userid'; Password='password'; Server=dbserver;Port=5432;Database=dbname;Integrated Security=true;Pooling=true;"
  }
```


## Database Migrations
In the EQM-GQE.DATA project run the following command to add a database migration
```
dotnet ef --startup-project ../EQM-GQE.API migrations add *NameOfMigration* -c QuestionnaireContext
```


