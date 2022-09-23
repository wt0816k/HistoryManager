using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectorPlus
{
    public class HistoryManager
    {
        private List<string> _history = new List<string>();

        private int _now;

        private int _last;

        public HistoryManager()
        {
            _last = _history.Count;
        }

        public void Add(string value)
        {
            _history.Add(value);
            _now += 1;
        }

        public void Clear()
        {
            _history.Clear();
        }

        public string GetPrevious()
        {
            int num = _now -= 1;
            return _history[num];
        }

        public string GetNext()
        {
            int num = _now += 1;
            return _history[num];
        }

        public void Undo()
        {

        }

        public void Redo()
        {

        }
    }
}
