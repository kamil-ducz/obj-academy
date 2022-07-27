using System;

namespace PseudoNotepad.Core.Models
{
    public class Database
    {
        public string Name { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime LastModified { get; set; }

        public Database(string name, string title, DateTime createdAt, DateTime lastModified)
        {
            Name = name;
            Title = title;
            CreatedAt = createdAt;
            LastModified = lastModified;
        }
    }
}
