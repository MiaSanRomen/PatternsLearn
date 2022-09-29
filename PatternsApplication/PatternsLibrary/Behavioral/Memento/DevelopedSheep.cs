using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Behavioral.Memento
{
    public class DevelopedSheep
    {
        private int _sails;
        private int _length;
        private int _oars;

        public MementoSheep Save()
        {
            return new MementoSheep(this);
        }

        public void SetSails(int sails)
        {
            _sails = sails;
        }

        public void SetLength(int length)
        {
            _length = length;
        }

        public void SetOars(int oars)
        {
            _oars = oars;
        }

        public void Undo(MementoSheep memento)
        {
            _sails = memento.Restore(this)._sails;
            _length = memento.Restore(this)._length;
            _oars = memento.Restore(this)._oars;
        }

        public override string? ToString()
        {
            return $"Sheep characteristics: \n      length: {_length}\n      oars: {_oars}\n      sails: {_sails}";
        }

        public class MementoSheep
        {
            private int _sails;
            private int _length;
            private int _oars;

            public MementoSheep(DevelopedSheep sheep)
            {
                _sails = sheep._sails;
                _length = sheep._length;
                _oars = sheep._oars;
            }

            public DevelopedSheep Restore(DevelopedSheep sheep)
            {
                sheep._sails = _sails;
                sheep._length = _length;
                sheep._oars = _oars;
                return sheep;
            }
        }
    }
}
