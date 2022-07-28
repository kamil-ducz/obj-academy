using System;

namespace PseudoNotepad.Core.Models
{
    public class Note
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }

        public Note(string title, string content, DateTime createdAt)
        {
            Title = title;
            Content = content;
            CreatedAt = createdAt;
        }
    }
}
