List<String> ToDo = new List<string>();
List<String> ToDoDone = new List<string>();

int Exit = 0;
int index = 0;
while (Exit < 1)
{
    Console.Clear();
    Console.WriteLine("This is a to do list. \nPlease type in a number to select an option.");
    Console.WriteLine("What would you like to do? \nYour options are: \n 1: View the entire list \n 2: View all of the to do items  \n 3: View all of the completed items \n 4: Add an item to the to do list \n 5: Mark a item as completed \n 6: View the stats \n 7: Exit");
    string choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            index = 1;
            Console.Clear();
            foreach (String a in ToDo)
                Console.WriteLine("To do item " + index++ + ": " + a);
            index = 1;
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (String b in ToDoDone)
                Console.WriteLine("To do item completed " + index++ + ": " + b);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            break;
        case "2":
            index = 0;
            Console.Clear();
            foreach (String a in ToDo)
                Console.WriteLine("To do item " + index++ + ": " + a);
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            break;
        case "3":
            index = 0;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (String b in ToDoDone)
                Console.WriteLine("To do item completed " + index++ + ": " + b);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            break;
        case "4":
            index = 0;
            DateTime StartTime = DateTime.Now;
            Console.Clear();
            Console.WriteLine("Please Write a name and a descriton for your to do item.");
            ToDo.Add(Console.ReadLine() + " :Started on " + StartTime);
            index++;
            break;
        case "5":
            index = 0;
            Console.Clear();
            Console.WriteLine("please choose an item to mark as completed by typing in its corresponding number.\nTo Go back Type Back.");
            DateTime FinishedTime = DateTime.Now;
            foreach (String a in ToDo)
                Console.WriteLine("To do item " + index++ + ": " + a);
            string ListChoice = Console.ReadLine();
            if (ListChoice == "Back")
            {
                break;
            }
            else
            {
                int ListChoice2 = int.Parse(ListChoice);
                if (ListChoice2 >= ToDo.Count)
                {
                    Console.WriteLine("That was not a valid option please try again. \nPress any key to continue.");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    ToDoDone.Add(ToDo[ListChoice2] + (": Finished on: ") + FinishedTime);
                    ToDo.RemoveAt(ListChoice2);
                    break;
                }
            }

            break;
        case "6":
            Console.Clear();
            int ToDoSize = ToDo.Count;
            int ToDoDoneSize = ToDoDone.Count;
            int TotalSize = ToDoSize + ToDoDoneSize;
            Console.WriteLine("Stats");
            Console.WriteLine(" There are " + TotalSize + " total items. \n There are " + ToDoSize + " items to do. \n there are " + ToDoDoneSize + " items that are done.");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            break;
        case "7":
            Exit++;
            Console.Clear();
            break;
        default:
            Console.Clear();
            Console.WriteLine("Incorrect option. Press any key to try again");
            Console.ReadKey();
            break;
    }
}

