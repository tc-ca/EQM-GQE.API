locals {
  apps = [
    {
      name = "EqmGqeApiDev"
      secrets = {
        "POSTGRES_DBHOST"          = "eqmgqepostgresqldev.postgres.database.azure.com"
        "POSTGRES_DBNAME"          = azurerm_postgresql_database.dev.name
        "POSTGRES_DBPORT"          = "5432"
        "POSTGRES_DBUSER"          = local.postgres_username
        "POSTGRES_DBPASS"          = random_password.main.result
        "WEBSITE_RUN_FROM_PACKAGE" = "1"
      }
    },
    {
      name = "EqmGqeApiQa"
      secrets = {
        "WEBSITE_RUN_FROM_PACKAGE"         = "1"
        "eqmgqepostgresqlConnectionString" = "redacted"
      }
    },
    {
      name    = "eqmgqewebdev"
      secrets = {
		  "WEBSITE_RUN_FROM_PACKAGE" = "1"
	  }
    },
    {
      name    = "eqmgqewebqa"
      secrets = {
		  "WEBSITE_RUN_FROM_PACKAGE" = "1"
	  }
    },
  ]
}

resource "azurerm_app_service" "main" {
  for_each = {
    for app in local.apps :
    app.name => app
  }
  name                    = each.value.name
  resource_group_name     = data.azurerm_resource_group.main.name
  location                = data.azurerm_resource_group.main.location
  client_affinity_enabled = true
  app_service_plan_id     = azurerm_app_service_plan.main.id
  app_settings            = each.value.secrets
}