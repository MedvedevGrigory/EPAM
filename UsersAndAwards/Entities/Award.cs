using System;

namespace Entities
{
    public class Award
    {
        public int ID;

        private string title;

        private string description;

        public Award(string title, string description, int iD = 0)
        {
            ID = iD;
            Title = title ?? throw new ArgumentNullException(nameof(title));
            Description = description ?? throw new ArgumentNullException(nameof(description));
        }

        public string Title
        {
            get => title;
            set
            {
                if (value.Length > 50)
                {
                    throw new Exception("Length is too long.");
                }
                title = value;
            }
        }

        public string Description
        {
            get => description;
            set
            {
                if (value.Length > 250)
                {
                    throw new Exception("Description is too long.");
                }
                description = value;
            }
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
