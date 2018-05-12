using System;
using System.Collections.Generic;
using System.Text;

namespace Note_Book.Entity
{
    public abstract class BaseEntity
    {
        protected BaseEntity(int id, string name, string icoUri)
        {
            Id = id;
            Name = name;
            IcoUri = icoUri;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string IcoUri { get; set; }

    }
}
