using System;

namespace _08_Orange_Tree
{
    internal class OrangeTree
    {
        public int Age;
        public int Height;
        public bool TreeAlive = true;
        public int NumOranges;
        public int OrangesEaten;

        public OrangeTree(int age, int height)
        {
            this.Age = age;
            this.Height = height;
        }

        internal void OneYearPasses()
        {
            Age = Age+1;
            Height = Height + 2;
            if(Age>=2)
            {
                NumOranges = NumOranges + 5;
            }

            if (Age >= 80) TreeAlive = false;
        }

        internal void EatOrange(int v)
        {
            if (NumOranges-v<= 0) throw new IndexOutOfRangeException("You can't eat an orange that isn't there!  There are 0 oranges available to eat");
            else
            {
                NumOranges = NumOranges -v;
                OrangesEaten = OrangesEaten + v;
            }
        }
    }
}