using System;

namespace PseudoNotepad.Core.Models
{
    public class Database
    {
        public string Name { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime LastModified { get; set; }

        public Database(string name, string title, string content, DateTime createdAt, DateTime lastModified)
        {
            Name = name;
            Title = title;
            Content = content;
            CreatedAt = createdAt;
            LastModified = lastModified;
        }
    }
}
