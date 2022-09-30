
//Constructor til choice 
using PizzariaSystem;

Pizza p1 = new Pizza(4, "Vezuvi", "skinke, ost, tomat", 85);
Pizza p2 = new Pizza(8, "Matador", "oksekød, ost, løg", 75);
Customer c1 = new Customer("Frederik", 87654321);
Customer c2 = new Customer("John", 12345678);
Order o1 = new Order(p1, c1);
Order o2 = new Order(p2, c2);

Console.WriteLine($" ███████████   ███              ██████   ██████                                                        ███████████   ███                                             ███           \r\n" +
                  $"░░███░░░░░███ ░░░              ░░██████ ██████                                                        ░░███░░░░░███ ░░░                                             ░░░            \r\n" +
                  $" ░███    ░███ ████   ███████    ░███░█████░███   ██████   █████████████   █████████████    ██████      ░███    ░███ ████   █████████  █████████  ██████   ████████  ████   ██████  \r\n" +
                  $" ░██████████ ░░███  ███░░███    ░███░░███ ░███  ░░░░░███ ░░███░░███░░███ ░░███░░███░░███  ░░░░░███     ░██████████ ░░███  ░█░░░░███  ░█░░░░███  ░░░░░███ ░░███░░███░░███  ░░░░░███ \r\n" +
                  $" ░███░░░░░███ ░███ ░███ ░███    ░███ ░░░  ░███   ███████  ░███ ░███ ░███  ░███ ░███ ░███   ███████     ░███░░░░░░   ░███  ░   ███░   ░   ███░    ███████  ░███ ░░░  ░███   ███████ \r\n" +
                  $" ░███    ░███ ░███ ░███ ░███    ░███      ░███  ███░░███  ░███ ░███ ░███  ░███ ░███ ░███  ███░░███     ░███         ░███    ███░   █   ███░   █ ███░░███  ░███      ░███  ███░░███ \r\n" +
                  $" ███████████  █████░░███████    █████     █████░░████████ █████░███ █████ █████░███ █████░░████████    █████        █████  █████████  █████████░░████████ █████     █████░░████████\r\n" +
                  $"░░░░░░░░░░░  ░░░░░  ░░░░░███   ░░░░░     ░░░░░  ░░░░░░░░ ░░░░░ ░░░ ░░░░░ ░░░░░ ░░░ ░░░░░  ░░░░░░░░    ░░░░░        ░░░░░  ░░░░░░░░░  ░░░░░░░░░  ░░░░░░░░ ░░░░░     ░░░░░  ░░░░░░░░ \r\n" +
                  $"                    ███ ░███                                                                                                                                                       \r\n" +
                  $"                   ░░██████                                                                                                                                                        \r\n" +
                  $"                    ░░░░░░                                                                                                                                                         ");

Console.WriteLine($" Welcome Dear Customer\n\n\n " +
                  $"{o1.ToString()}\n " +
                  $"==================================\n " +
                  $"Second order.\n " +
                  $"==================================\n\n\n " +
                  $"{o2.ToString()}\n ");

Console.ReadKey();

/*Console.WriteLine("Welcome to Big Mama's pizzaria.\nPlease pick from our menu below.\n\n");

Console.WriteLine($"Build your own:  1\n" +
                  $"--------------------\n" +
                  $"Favorites:\t 2\n" +
                  $"--------------------\n" +
                  $"Calzones:\t 3\n" +
                  $"--------------------\n" +
                  $"Vegetarian:\t 4\n" +
                  $"--------------------\n" +
                  $"Special:\t 5\n" +
                  $"--------------------\n" +
                  $"Drinks:\t\t 6\n" +
                  $"\n\nEnter menu number:");
choice = Convert.ToInt32(Console.ReadLine());
*/

//if statement or switch statement
//Make a class for every UML class with subsequent methodes
//for the options and make sure the users input is registeret and used correctly 


