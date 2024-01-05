// Welcome Text
Console.Write("Welcome to TECHBODIA Notification Channel Parser Application \n\n");

// Helper Key
Console.Write("Using exit Key to Leave the application. \n\n");

// Endless loop
while (true) 
{
    // Console.Write() for output
    Console.Write("Please Input notification channels : ");

    // User Input String
    string readstring = Console.ReadLine(); 

    //Default Output String
    string outPutstring ="OUTPUT: "+ "\"" + "Receive channels: ";

    // Check Condition
    if (readstring.Contains("[BE]")) outPutstring = outPutstring + "BE,";
    if (readstring.Contains("[FE]")) outPutstring = outPutstring + "FE,";
    if (readstring.Contains("[QA]")) outPutstring = outPutstring + "QA,";
    if (readstring.Contains("[Urgent]")) outPutstring = outPutstring + "Urgent,";

    // Check for exit command
    if (readstring.ToLower() == "exit") 
    {
        break;
    }

    //Fomat OutPut string
    outPutstring = outPutstring.Remove(outPutstring.Length - 1);
    outPutstring = outPutstring + "\"";

    // Wring back the Result
    Console.Write("\n" + outPutstring + "\n\n");
}
