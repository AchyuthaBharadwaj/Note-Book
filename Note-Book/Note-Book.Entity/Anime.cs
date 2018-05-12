using System;

namespace Note_Book.Entity
{
    public class Anime : BaseEntity
    {
        public Anime(int id, string name, string icoUri) : base(id, name, icoUri)
        {
        }
    }
}
