namespace GenericClass
{
    using System;

    public class Deque<T>
    {
        private const int InitalSize = 16;
        private T[] data;
        private int frontIndex;
        private int backIndex;

        public Deque()
            : this(InitalSize)
        {

        }

        public Deque(uint initalSize)
        {
            if (initalSize < 2)
            {
                throw new IndexOutOfRangeException("Initial size must be bigger than 2 ");
            }

            this.data = new T[initalSize];
            this.frontIndex = this.Capacity / 2 - 1;
            this.backIndex = this.Capacity / 2;
        }
        public T Min()
        {
            T min = this.data[0];
            for (int i = 0; i < data.Length - 1; i++)
            {
                if (min > (dynamic)this.data[i])
                {
                    min = this.data[i];
                }
            }
            return min;
        }
        public T Max()
        {
            T max = this.data[0];
            for (int i = 0; i < data.Length - 1; i++)
            {
                if (max < (dynamic)this.data[i])
                {
                    max = this.data[i];
                }
            }
            return max;
        }

        public int Count
        {
            get
            {
                return this.backIndex - this.frontIndex - 1;
            }
        }

        public int Capacity
        {
            get
            {
                return this.data.Length;
            }
        }

        public void AddFront(T element)
        {
            if (this.frontIndex < 0)
            {
                this.ResizeData();
            }

            this.data[frontIndex] = element;
            this.frontIndex--;
        }


        public void AddBack(T element)
        {
            if (this.backIndex == this.Capacity)
            {
                this.ResizeData();
            }

            this.data[backIndex] = element;
            this.backIndex++;
        }

        public T RemoveFront()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Deque is empty !");
            }

            this.frontIndex++;
            return this.data[frontIndex];
        }

        public T RemoveBack()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Deque is empty !");
            }

            this.frontIndex--;
            return this.data[frontIndex];
        }

        public T PeekFront()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Deque is empty !");
            }
            return this.data[frontIndex + 1];
        }

        public T PeekBack()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Deque is empty !");
            }
            return this.data[backIndex - 1];
        }

        private void ResizeData()
        {
            int newSize = this.Capacity * 2;
            T[] newData = new T[newSize];

            int currentFrontIndex = this.Capacity / 2 - 1;
            int currentBackIndex = this.Capacity / 2;

            int newFrontIndex = newSize / 2 - 1;
            int newBackIndex = newSize / 2;

            while (true)
            {
                if (currentFrontIndex <= this.frontIndex && currentBackIndex >= this.backIndex)
                {
                    break;
                }

                if (currentFrontIndex > this.frontIndex)
                {
                    newData[newFrontIndex] = this.data[currentFrontIndex];
                    newFrontIndex--;

                }

                if (currentBackIndex < this.backIndex)
                {
                    newData[newBackIndex] = this.data[newBackIndex];
                    newBackIndex++;

                }

                currentBackIndex++;
                currentFrontIndex--;
            }

            this.data = newData;
            this.frontIndex = newFrontIndex;
            this.backIndex = newBackIndex;
        }

    }
}
