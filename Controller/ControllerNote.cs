using System;
using System.Collections.Generic;
using System.Text;


namespace NoteApp
{
        class ControllerNote
        {
            private List<Note> notes = NoteRepository.getInstance().getNotes();
            private View view = new View();
            private string[] commandList = {
            "create",
            "edit",
            "show",
            "delete",
            "exit"
            };

            public string[] CommandList { get => commandList; }

            public void doCommand(String command)
            {
                switch (command)
                {
                    case "create":
                        CreateNote();
                        break;
                    case "show":
                        if (!EmptyCheck())
                        {
                            Show();
                        }
                        break;
                    case "edit":
                        if (!EmptyCheck())
                        {
                            Edit();
                        }
                        break;
                    case "delete":
                        if (!EmptyCheck())
                        {
                            Delete();
                        }
                        break;
                }
            }

            public bool EmptyCheck()
            {
                if (notes.Count == 0)
                {
                    view.ViewOutLine("Note List is empty!");
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public bool CheckCommand(String command)
            {
                foreach(var commandStr in commandList)
                {
                    if (commandStr.Equals(command))
                    {
                        return true;
                    }
                }
                return false;
            }
            public void NoteSetData(Note note)
            {
                view.ViewOutLine("Input note text:");
                note.Text = view.UserInput();

                view.ViewOutLine("Input Label:");
                note.Label = view.UserInput();

                view.ViewOutLine("Input Is Note complete? (done or to do)");
                note.Check = true;
                note.Date = DateTime.Now.ToString();
            }
            public void CreateNote()
            {
                Note note = new Note();
                NoteSetData(note);
                notes.Add(note);
                view.ViewOutLine("note " + note.Label + " created");
            }
            public void Edit()
            {
                view.ViewOutLine("Witch one? Enter note label:");
                String str = view.UserInput();
                foreach(Note note in notes)
                {
                    if (note.Label.Equals(str))
                    {
                        NoteSetData(note);
                        view.ViewOutLine("note " + note.Label + " edited");
                        break;
                    }
                }
            }
            public void Delete()
            {
                view.ViewOutLine("Witch one? Enter note label:");
                String str = view.UserInput();
                foreach(Note note in notes)
                {
                    if (note.Label.Equals(str))
                    {
                        view.ViewOutLine("note " + note.Label + " removed");
                        notes.Remove(note);
                        break;
                    }
                }
            }
            public void Show()
            {
                string[] notesList = new string[notes.Count];
                int i = 0;

                foreach(Note note in notes)
                {
                    notesList[i] = note.ToString();
                    i++;
                }
                view.ViewOutList(notesList);
            }
        }    
}
