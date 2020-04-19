using System;

namespace NoteApp
{
    class Program
    {
        static void Main(string[] args)
        {
            String command = "";
            View view = new View();
            ControllerNote controllerNote = new ControllerNote();

            view.ViewOutLine("\t\t\t\t\tNOTE++\nAll commands:");
            view.ViewOutList(controllerNote.CommandList);

            while (true)
            {
                command = view.UserInput();
                switch (command)
                {
                    case "exit":                        
                        Console.WriteLine("Bay");
                        Environment.Exit(0);
                        break;
                    case "help":
                        view.ViewOutLine("All commands:");
                        view.ViewOutList(controllerNote.CommandList);
                        break;
                    default:
                        if (controllerNote.CheckCommand(command))
                        {
                            controllerNote.doCommand(command);
                        }
                        else if (!controllerNote.CheckCommand(command))
                        {
                            view.ViewOutLine("Incorrect command!");
                        }
                        break;
                }
            }
        }
    }
}
