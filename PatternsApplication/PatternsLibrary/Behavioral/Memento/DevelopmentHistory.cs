using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Patterns.Library.Behavioral.Memento.DevelopedSheep;

namespace Patterns.Library.Behavioral.Memento
{
    public class DevelopmentHistory
    {
        private Stack<MementoSheep> _mementoRecords;
        private DevelopedSheep _developedSheep;

        public DevelopmentHistory(DevelopedSheep developedSheep)
        {
            _mementoRecords = new Stack<MementoSheep>();
            _developedSheep = developedSheep;
        }

        public void SaveMemento()
        {
            _mementoRecords.Push(_developedSheep.Save());
        }
        public void Undo()
        {
            _developedSheep.Undo(_mementoRecords.Pop());
        }
    }
}
