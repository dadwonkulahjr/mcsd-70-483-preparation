using System;
using System.Collections;
using System.Collections.Generic;

namespace MCSDeveloper
{
    public class MyGenricList<TOutput> : IEnumerable<TOutput> where TOutput : class
    {
        int index = -1;
        TOutput[] _outputs;
        public TOutput First { get; set; }
        public TOutput Second { get; set; }

        public int Count
        {
            get { return _outputs.Length; }
        }
        public TOutput this[int index]
        {
            get
            {
                return _outputs[index];
            }
            set { _outputs[index] = value; }
        }
        public MyGenricList()
        {
            _outputs = new TOutput[3];
        }
        public MyGenricList(TOutput first, TOutput second)
        {
            First = first;
            Second = second;
        }
        public MyGenricList(int sizeOfTheArray)
        {
            _outputs = new TOutput[sizeOfTheArray];
        }
        public void Add(TOutput arg)
        {
            if(++index < _outputs.Length)
            {
                _outputs[index] = arg;
            }
        }

        public IEnumerator<TOutput> GetEnumerator()
        {
            foreach (var item in _outputs)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
