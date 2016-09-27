using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This program will allow the user to toggle through a Stack, Queue, and Dicitionary to store, search, and delete strings the
//user wants to add.

//Tyler Evertsen
//Section 2
//Group 7
//Date Created: September 26, 2016

namespace GroupDataStructuresAssignment
{
    class Program
    {
        static void Main(string[] args){
            //declare variables and data structures
            bool a = true;
            int responseA = 0;
            bool mainmenu = true;
            Stack<string> myStack = new Stack<string>();
            Queue<string> myQueue = new Queue<string>();
            Stack<string> cStack = new Stack<string>();
            Queue<string> cQueue = new Queue<string>();
            Dictionary<string, int> myDictionary = new Dictionary<string, int>();
            string dString;
            bool foundString = false;

            //load main menu at beginning, and if user selects to load main menu in one of the submenus
            while (mainmenu)
            {
                //print menu, and reprint menu if the response is invalid

                    //set response value to 0
                    //responseA = 0;

                    //print first menu
                    Console.WriteLine("1. Stack\n2. Queue\n3. Dictionary\n4. Exit");
                    //exception handle the response ensuring that it is a valid response
                    try
                    {
                        responseA = Convert.ToInt32(Console.ReadLine());
                        if (responseA > 4 || responseA < 1)
                        {
                            Console.WriteLine("Enter a valid number.");
                        }
                        else
                        {
                            a = false;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("\n\nEnter a valid number.\n\n");
                    }
                

                //depending on answer guide user to next menu
                switch (responseA)
                {
                    case 1:
                    
                        //create blank line for looks
                        Console.WriteLine();

                        //set while loop and declare variables
                        int responseA1 = 0;

                        while (responseA1 != 7)
                        {
                            //print the menu
                            Console.WriteLine("1. Add one time to Stack\n" +
                                "2. Add Huge List of Items to Stack\n" +
                                "3. Display Stack\n4. Delete from Stack\n" +
                                "5. Clear Stack\n" +
                                "6. Search Stack\n" +
                                "7. Return to Main Menu\n");
                            //exception handle the response
                            try
                            {
                                responseA1 = Convert.ToInt32(Console.ReadLine());
                                if (responseA1 > 7 || responseA1 < 1)
                                {
                                    Console.WriteLine("\n\nEnter a valid number.\n\n");
                                }
                            }
                            catch
                            {
                                Console.WriteLine("\n\nEnter a valid number.\n\n");
                                responseA1 = 0;
                            }


                            //respond to user response
                            switch (responseA1)
                            {
                                case 1:
                                    Console.WriteLine("\nEnter new entry:");
                                    myStack.Push(Console.ReadLine());
                                    Console.WriteLine();
                                    break;

                                case 2:
                                    myStack.Clear();
                                    for (int i = 0; i < 2000; i++)
                                    {
                                        myStack.Push("New Entry " + (i + 1));
                                    }
                                    break;

                                case 3:
                                    if (myStack.Count() == 0) 
                                    {
                                        Console.WriteLine("\nThere are no contents in the stack.\n");
                                    } 
                                    else
                                    {
                                        foreach (string s in myStack)
                                        {
                                            Console.WriteLine(s);
                                        }
                                        Console.WriteLine("\n");
                                    }
                                    break;

                                case 4:
                                    //prompt for which string to delete
                                    Console.Write("\nEnter the string that you would like to delete from the stack: ");
                                    dString = Console.ReadLine();
                                    //unload stack into temporary stack while searching for and deleting specified string
                                    foundString = false;
                                    foreach (string s in myStack)
                                    {
                                        if (s != dString)
                                        {
                                            cStack.Push(s);
                                        }
                                        else
                                        {
                                            foundString = true;
                                        }

                                    }
                                    if (foundString)
                                    {
                                        Console.WriteLine("Your string has been found and has been deleted.");
                                        myStack.Clear();
                                        foreach (string s in cStack)
                                        {
                                            myStack.Push(s);
                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine("The string was not found in the stack, and therefore could not be deleted.");
                                    }
                                    break;

                                case 5:
                                    myStack.Clear();
                                    break;

                                case 6:
                                    //prompt for which string to delete
                                    Console.Write("\nEnter the string that you would like to find: ");
                                    dString = Console.ReadLine();
                                    Console.WriteLine();
                                    System.Diagnostics.Stopwatch swStack = new System.Diagnostics.Stopwatch();
                                    foundString = false;
                                    swStack.Start();
                                    foreach (string s in myStack)
                                    {
                                        if (s == dString)
                                        {
                                            foundString = true;
                                            swStack.Stop();
                                        }
                                    }
                                    if (foundString)
                                    {
                                        Console.WriteLine("Your string has been found. And it took "+Convert.ToString((swStack.Elapsed.TotalMilliseconds*1000000))+" nanoseconds to find that string.");
                                    }
                                    else
                                    {
                                        swStack.Stop();
                                        Console.WriteLine("The string was not found in the stack, and it took " + Convert.ToString((swStack.Elapsed.TotalMilliseconds*1000000)) + " nanoseconds to complete the search.");
                                    }
                                    Console.WriteLine();
                                    break;

                            }
                        }
                        break;

                    case 2:
                                            
                        //create blank line for looks
                        Console.WriteLine();

                        //set while loop and declare variables
                        int responseA2 = 0;
                        while (responseA2 != 7)
                        {
                            Console.WriteLine("1. Add one time to Queue\n" +
                                "2. Add Huge List of Items to Queue\n" +
                                "3. Display Queue\n" +
                                "4. Delete from Queue\n" +
                                "5. Clear Queue\n" +
                                "6. Search Queue\n" +
                                "7. Return to Main Menu\n");

                            //exception handle the response
                            try
                            {
                                responseA2 = Convert.ToInt32(Console.ReadLine());
                                if (responseA2 > 7 || responseA2 < 1)
                                {
                                    Console.WriteLine("\n\nEnter a valid number.\n\n");
                                }
                            }
                            catch
                            {
                                Console.WriteLine("\n\nEnter a valid number.\n\n");
                                responseA2 = 0;
                            }
                            
                            switch (responseA2)
                            {
                                case 1:
                                    Console.WriteLine("\nEnter new entry:");
                                    myQueue.Enqueue(Console.ReadLine());
                                    Console.WriteLine();
                                    break;

                                case 2:
                                    myQueue.Clear();
                                    for (int i = 0; i < 2000; i++)
                                    {
                                        myQueue.Enqueue("New Entry " + (i + 1));
                                    }
                                    break;

                                case 3:
                                    if (myQueue.Count() == 0)
                                    {
                                        Console.WriteLine("\nThere are no contents in the stack.\n");
                                    }
                                    else
                                    {
                                        foreach (string s in myQueue)
                                        {
                                            Console.WriteLine(s);
                                        }
                                        Console.WriteLine("\n");
                                    }
                                    break;

                                case 4:
                                    //prompt for which string to delete
                                    Console.Write("\nEnter the string that you would like to delete from the queue: ");
                                    dString = Console.ReadLine();
                                    //unload stack into temporary stack while searching for and deleting specified string
                                    foundString = false;
                                    foreach (string s in myQueue)
                                    {
                                        if (s != dString)
                                        {
                                            cQueue.Enqueue(s);
                                        }
                                        else
                                        {
                                            foundString = true;
                                        }

                                    }
                                    if (foundString)
                                    {
                                        Console.WriteLine("Your string has been found and has been deleted.");
                                        myQueue.Clear();
                                        foreach (string s in cQueue)
                                        {
                                            myQueue.Enqueue(s);
                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine("The string was not found in the stack, and therefore could not be deleted.");
                                    }
                                    break;

                                case 5:
                                    myQueue.Clear();
                                    break;

                                case 6:
                                    //prompt for which string to delete
                                    Console.Write("\nEnter the string that you would like to find: ");
                                    dString = Console.ReadLine();
                                    Console.WriteLine();
                                    System.Diagnostics.Stopwatch swQueue = new System.Diagnostics.Stopwatch();
                                    foundString = false;
                                    swQueue.Start();
                                    foreach (string s in myQueue)
                                    {
                                        if (s == dString)
                                        {
                                            foundString = true;
                                            swQueue.Stop();
                                        }
                                    }
                                    if (foundString)
                                    {
                                        Console.WriteLine("Your string has been found. And it took " + Convert.ToString((swQueue.Elapsed.TotalMilliseconds * 1000000)) + " nanoseconds to find that string.");
                                    }
                                    else
                                    {
                                        swQueue.Stop();
                                        Console.WriteLine("The string was not found in the stack, and it took " + Convert.ToString((swQueue.Elapsed.TotalMilliseconds * 1000000)) + " nanoseconds to complete the search.");
                                    }
                                    Console.WriteLine();
                                    break;
                            }

                        }
                        break;

                    case 3:
                         //create blank line for looks
                        Console.WriteLine();

                        //set while loop and declare variables
                        int responseA3 = 0;
                        while (responseA3 != 7)
                        {
                            Console.WriteLine("1. Add one item to Dictionary\n" +
                                "2. Add Huge List of Items to Dictionary\n" +
                                "3. Display Dictionary\n" +
                                "4. Delete from Dictionary\n" +
                                "5. Clear Dictionary\n" +
                                "6. Search Dictionary\n" +
                                "7. Return to Main Menu\n");

                            //exception handle the response
                            try
                            {
                                responseA3 = Convert.ToInt32(Console.ReadLine());
                                if (responseA3 > 7 || responseA3 < 1)
                                {
                                    Console.WriteLine("\n\nEnter a valid number.\n\n");
                                }
                            }
                            catch
                            {
                                Console.WriteLine("\n\nEnter a valid number.\n\n");
                                responseA3 = 0;
                            }

                            switch (responseA3)
                            {
                                case 1:
                                    int entrynum = myDictionary.Count + 1;
                                    Console.WriteLine("\nEnter new entry:");
                                    myDictionary.Add(Console.ReadLine(),entrynum);
                                    Console.WriteLine();
                                    break;

                                case 2:
                                    myDictionary.Clear();
                                    for (int i = 0; i < 2000;i++ )
                                    {
                                        int num = i + 1;
                                        string sKey = "New Entry " + Convert.ToString(num);
                                        myDictionary.Add(sKey,num);
                                    }
                                    break;

                                case 3:
                                    if (myDictionary.Count() == 0)
                                    {
                                        Console.WriteLine("\nThere are no contents in the stack.\n");
                                    }
                                    else
                                    {
                                        foreach (KeyValuePair<string, int> entry in myDictionary)
                                        {
                                            Console.WriteLine(entry.Key);
                                        }
                                        Console.WriteLine("\n");
                                    }
                                    break;

                                case 4:
                                    Console.Write("\nEnter the key of the entry that you would like to delete: ");
                                    dString = Console.ReadLine();
                                    if (myDictionary.ContainsKey(dString))
                                    {

                                    }
                                    
                                    break;

                                case 5:
                                    myDictionary.Clear();
                                    break;

                                case 6:
                                    //prompt for which string to delete
                                    Console.Write("\nEnter the value that you would like to find: ");
                                    dString = Console.ReadLine();
                                    Console.WriteLine();
                                    System.Diagnostics.Stopwatch swDict = new System.Diagnostics.Stopwatch();
                                    foundString = false;
                                    //prompt for which to search (key or value), keep prompting after invalid responses
                                    string responsedict = "k";
                                    bool bDict = true;
                                    while (bDict)
                                    {
                                        Console.WriteLine("\nWhich would you like to search, dictionary keys or values? (k/v)");
                                        responsedict = Console.ReadLine();
                                        responsedict = responsedict.ToLower();
                                        switch (responsedict)
                                        {
                                            case "k":
                                                swDict.Start();
                                                foreach (KeyValuePair<string, int> entry in myDictionary)
                                                {
                                                    if (entry.Key == dString)
                                                    {
                                                        foundString = true;
                                                        swDict.Stop();
                                                    }
                                                }
                                                if (foundString)
                                                {
                                                    Console.WriteLine("Your entry has been found. And it took " + Convert.ToString((swDict.Elapsed.TotalMilliseconds * 1000000)) + " nanoseconds to find that string.");
                                                }
                                                else
                                                {
                                                    swDict.Stop();
                                                    Console.WriteLine("The entry was not found in the stack, and it took " + Convert.ToString((swDict.Elapsed.TotalMilliseconds * 1000000)) + " nanoseconds to complete the search.");
                                                }
                                                Console.WriteLine();
                                                bDict = false;
                                                break;

                                            case "v":
                                                swDict.Start();
                                                foreach (KeyValuePair<string, int> entry in myDictionary)
                                                {
                                                    if (Convert.ToString(entry.Value).Equals(dString))
                                                    {
                                                        foundString = true;
                                                        swDict.Stop();
                                                    }
                                                }
                                                if (foundString)
                                                {
                                                    Console.WriteLine("Your entry has been found. And it took " + Convert.ToString((swDict.Elapsed.TotalMilliseconds * 1000000)) + " nanoseconds to find that string.");
                                                }
                                                else
                                                {
                                                    swDict.Stop();
                                                    Console.WriteLine("The entry was not found in the stack, and it took " + Convert.ToString((swDict.Elapsed.TotalMilliseconds * 1000000)) + " nanoseconds to complete the search.");
                                                }
                                                Console.WriteLine();
                                                bDict = false;
                                                break;
                                        }

                                        
                                        
                                    }
                                    break;
                            }


                        }
                        break;

                    case 4:
                        Environment.Exit(0);
                        break;

                }

            }
            //close application when user presses enter
            Console.Read();

        }
    }
}
        
        
            
