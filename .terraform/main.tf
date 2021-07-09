terraform {
  required_providers {
    azurerm = {
      source  = "hashicorp/azurerm"
      version = ">= 2.61.0"
    }
  }
}

provider "azurerm" {
  features {}
}

resource "azurerm_app_service_plan" "main" {
  name                = "EqmGqeAppServicePlan"
  location            = data.azurerm_resource_group.main.location
  resource_group_name = data.azurerm_resource_group.main.name

  sku {
    tier     = "Free"
    size     = "F1"
    capacity = 0
  }

  kind = "app"
}
