string userInput;
List <string> shoppingList = new ();

Dictionary<string, decimal> menuItems = new()
{
    { "apples", 2.13m},
    { "yogurt", 3.29m },
    { "broccoli", 2.15m },
    { "edelberries", 3.05m },
    { "blueberries", 4.29m },
    { "pasta", 5.32m },
    { "eggs", 4.12m },
    { "milk", 3.20m },
};

Console.WriteLine("Welcome to Tropical Market\n");
Console.WriteLine("==========================\n");

foreach (KeyValuePair<string, decimal> item in menuItems)
{
    Console.WriteLine($"{item.Key}, ${item.Value}");
}

Console.WriteLine("What item would you to order?:\n");
userInput = Console.ReadLine();
if (menuItems.ContainsKey(userInput))
{
    {
        Console.WriteLine("adding " + userInput + " to cart at $" + menuItems[userInput]);
        shoppingList.Add(userInput);
    }
}
else
{
    Console.WriteLine("Sorry, we don't have those. Please try again.");
}

foreach (string i in shoppingList)
{
    if (menuItems.ContainsKey(i))
    {
        //some loop here
    }
}

