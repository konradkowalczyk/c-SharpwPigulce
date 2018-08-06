using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public interface IUndoable { void Undo(); }

        public interface IUndoable2 { int Undo(); }

        public interface IRedoable : IUndoable, IUndoable2 { void Redo();}

        public class TheThing : IRedoable
        {
            public void Redo()
            { }
            public void Undo()
            { }
            int IUndoable2.Undo()
            { return 0; }
        }
    }
}
