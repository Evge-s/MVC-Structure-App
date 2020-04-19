using System;
using System.Collections.Generic;
using System.Text;

namespace NoteApp
{
        class NoteRepository
        {
            private List<Note> notes;
            private static NoteRepository noteRepository = new NoteRepository();

            public NoteRepository()
            {
                notes = new List<Note>();
            }

            public static NoteRepository getInstance() { return noteRepository; }

            public List<Note> getNotes() { return notes; }
        }
}