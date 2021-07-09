resource "random_password" "main" {
  length           = 16
  special          = true
  override_special = "_%@"
}

locals {
	postgres_username = "psqladmin"
}

resource "azurerm_postgresql_server" "main" {
  name                = "eqmgqepostgresserver"
  location            = data.azurerm_resource_group.main.location
  resource_group_name = data.azurerm_resource_group.main.name

  sku_name = "B_Gen5_2"

  storage_mb                   = 5120
  backup_retention_days        = 7
  geo_redundant_backup_enabled = false
  auto_grow_enabled            = true

  administrator_login          = local.postgres_username
  administrator_login_password = random_password.main.result

  version                      = "9.5"
  ssl_enforcement_enabled      = true
}



resource "azurerm_postgresql_database" "dev" {
  name                = "eqmgqepostgresqldev"
  resource_group_name = data.azurerm_resource_group.main.name
  server_name         = azurerm_postgresql_server.main.name
  charset             = "UTF8"
  collation           = "English_United States.1252"
}

resource "azurerm_postgresql_database" "qa" {
  name                = "eqmgqepostgresqlqa"
  resource_group_name = data.azurerm_resource_group.main.name
  server_name         = azurerm_postgresql_server.main.name
  charset             = "UTF8"
  collation           = "English_United States.1252"
}