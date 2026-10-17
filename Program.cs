string[] inventoryItems = { "Sword", "Shield", "Potion", "Bow", "Arrow" };

for(int i = 0; i < inventoryItems.Length; i++)
{
    Console.WriteLine($"Slot {i} = {inventoryItems[i]}");
}
Console.WriteLine($"\nTotal Items: {inventoryItems.Length}");
