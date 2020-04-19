using System;
using System.Collections.Generic;
using System.Text;

namespace NoteApp
{
    class Note
    {
        private string text;
        private string date;
        private string label;
        private bool check;

        public Note() { }

        public Note(string text, string date, string label, bool check)
        {
            this.Text = text;
            this.Date = date;
            this.Label = label;
            this.Check = check;
        }

        public string Text { get => text; set => text = value; }
        public string Date { get => date; set => date = value; }
        public string Label { get => label; set => label = value; }
        public bool Check { get => check; set => check = value; }

        public override string ToString()
        {
            return $"Label: {Label}, Text: {Text}, Date: {Date}, Done: {Check}";
        }
    }
}
