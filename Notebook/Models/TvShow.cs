using System;

namespace Notebook.Models
{
    public class TvShow : BaseEntity
    {
        public TvShow(int id, string name, string icoUri) : base(id, name, icoUri)
        {
        }
    }
}
