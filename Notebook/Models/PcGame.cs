using System;

namespace Notebook.Models
{
    public class PcGame : BaseEntity
    {
        public PcGame(int id, string name, string icoUri) : base(id, name, icoUri)
        {
        }
    }
}
