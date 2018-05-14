using System;

namespace Notebook.Models
{
    public class XboxGame : BaseEntity
    {
        public XboxGame(int id, string name, string icoUri) : base(id, name, icoUri)
        {
        }
    }
}
