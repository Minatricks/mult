using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Conccurency
{
    public class SelfMultiplyArray
    {
        private double[] _array;
        private int _countLogicProccesor;
        public int Count { get; set; }

        public SelfMultiplyArray(int count, int value)
        {
            _countLogicProccesor = Environment.ProcessorCount;
            Count = count - 1;
            _array = new double[Count];
            for (int i = 0; i < Count; i++)
            {
                _array[i] = value;
            }
        }

        public double this[int index]
        {
            get
            {
                return _array[index];
            }
        }

        private void SelfMultiply(int index)
        {
            if (index > 0 && index < Count)
                _array[index] = _array[index] * _array[index];
        }

        public ParallelLoopResult Multiply()
        {
            var options = new ParallelOptions() { MaxDegreeOfParallelism = _countLogicProccesor };
           return Parallel.For(0, _array.Length, options, SelfMultiply);
        }
    }
}
