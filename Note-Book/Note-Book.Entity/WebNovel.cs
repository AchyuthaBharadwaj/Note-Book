using System;
using System.Collections.Generic;
using System.Text;

namespace Note_Book.Entity
{
    public class WebNovel : BaseEntity
    {
        public WebNovel(int id, string name, string icoUri) : base(id, name, icoUri)
        {
        }
    }
}
