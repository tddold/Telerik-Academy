namespace _64_Bit_array
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class BitArray64 : IEnumerable<int>
    {
        private List<ulong> bitArray;

        public BitArray64(List<ulong> bitArray)
        {
            this.BitArray = bitArray;
        }

        public List<ulong> BitArray
        {
            get { return this.bitArray; }

            set { this.bitArray = value; }
        }

        public ulong this[int number]
        {
            get { return this.bitArray[number]; }

            set { this.bitArray[number] = value; }
        }

        public static bool operator ==(BitArray64 firstBitArray, BitArray64 secondBitArray)
        {
            return firstBitArray.Equals(secondBitArray);
        }

        public static bool operator !=(BitArray64 firstBitArray, BitArray64 secondBitArray)
        {
            return !firstBitArray.Equals(secondBitArray);
        }

        public override bool Equals(object obj)
        {
            var number = obj as BitArray64;

            if (number.BitArray.Count != this.BitArray.Count)
            {
                return false;
            }

            for (int i = 0; i < this.BitArray.Count; i++)
            {
                if (this.BitArray[i] != number.BitArray[i])
                {
                    return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            int hashCode = 0;

            foreach (var num in this.BitArray)
            {
                hashCode += num.GetHashCode();
            }

            return hashCode;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < this.BitArray.Count; i++)
            {
                yield return i;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
