namespace _05.BitArray
{
    using System;
    using System.Collections.Generic;
    using System.Collections;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class BitArray64 : IEnumerable<int>, IComparable
    {
        private ulong[] array;

        public ulong Number { get; set; }

        public BitArray64(ulong number)
        {
            this.Number = number;
        }

        public int this[int pos]
        {
            get
            {
                if (pos < 0 || pos >= 64)
                {
                    throw new IndexOutOfRangeException("Invalid position !");
                }
                return ((int)(this.Number >> pos) & 1);
            }
            set
            {
                if (pos < 0 || pos >= 64)
                {
                    throw new IndexOutOfRangeException("Invalid position !");
                }
                if (value < 0 || value > 1)
                {
                    throw new ArgumentException("Invalid bit value !");
                }
                if (((int)(this.Number >> pos) & 1) != value)
                {
                    this.Number ^= (1u << pos);
                }
            }
        }

        public static bool operator ==(BitArray64 arr1, BitArray64 arr2)
        {
            return !(arr1.Equals(arr2));
        }

        public static bool operator !=(BitArray64 arr1, BitArray64 arr2)
        {
            return !(arr1.Equals(arr2));
        }

        public override int GetHashCode()
        {
            return this.Number.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return this.Number.Equals((obj as BitArray64).Number);
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int pos = 0; pos < 64; pos++)
            {
                yield return this[pos];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }



        public int CompareTo(object obj)
        {
            return this.Number.CompareTo((obj as BitArray64).Number);
        }
    }
}
