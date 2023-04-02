using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zd1.Models;

namespace zd1.Interfaces
{
    public interface IXmlWorker
    {
        void Load(string xmlDocPath);
        void Add(Note note);
        void Delete(string name);
        Note FindBy(string name);
        List<Note> GetAll();
    }
}
