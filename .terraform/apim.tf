resource "azurerm_api_management" "main" {
  name                = "EqmGqeApi-apim"
  location            = data.azurerm_resource_group.main.location
  resource_group_name = data.azurerm_resource_group.main.name
  publisher_email            = "stephen.mouland@tc.gc.ca"
  publisher_name             = "Transport Canada"
  sku_name                   = "Developer_1"
}