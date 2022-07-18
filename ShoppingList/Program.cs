string userInput;
bool runAgain = true;
bool wantToContinue = true;
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

#region Display menu to user
Console.WriteLine("Welcome to Tropical Market\n");
Console.WriteLine("==========================\n");

foreach (KeyValuePair<string, decimal> item in menuItems)
{
    Console.WriteLine($"{item.Key}, ${item.Value}");
}
#endregion


while (wantToContinue)
{
    Console.WriteLine("What item would you to order?:\n");
    userInput = Console.ReadLine();
    if (menuItems.ContainsKey(userInput))
    {
        {
            Console.WriteLine("adding " + userInput + " to cart at $" + menuItems[userInput]);
            shoppingList.Add(userInput);
            Console.WriteLine("Would you like to continue? (y/n)?");
            string restartValue = Console.ReadLine().ToLower();
            if (restartValue == "y")
                continue;
            else
                break;
        }
    }
    else
    {
        Console.WriteLine("Sorry, we don't have those. Please try again.");
        Console.WriteLine("Would you like to continue? (y/n)?");
        string restartValue = Console.ReadLine().ToLower();
        if (restartValue == "y")
            continue;
        else
            break;
    } 
}


foreach (string i in shoppingList.ToList())
{
    if (menuItems.ContainsKey(i))
    {
        var newlist = menuItems.Where(x => shoppingList.Contains(x.Key)).Select(y => y.Value).ToList();
        Console.WriteLine(menuItems);
    }
}
