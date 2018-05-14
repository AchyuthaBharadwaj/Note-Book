using System;
using System.Collections.Generic;
using System.Text;

namespace Notebook.Models
{
    public class WebNovel : BaseEntity
    {
        public WebNovel(int id, string name, string icoUri) : base(id, name, icoUri)
        {
        }
    }
}
