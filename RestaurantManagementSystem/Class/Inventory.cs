using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantManagementSystem
{
    public class Inventory
    {
        private List <Ingredient> inventoryQuantity;

        public List<Ingredient> InventoryQuantity { get => inventoryQuantity; set => inventoryQuantity = value; }
        
        public bool LowStockInventory()
        {
            if (inventoryQuantity.Count <= RestaurantConfig.StockThreshold || inventoryQuantity == null)
            {
                return true;
            }
            return false;
        }
    }
}