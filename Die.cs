using System;

namespace Monopoly
{
    class Dies
    {
        Random rand = new Random();
        public int First { get; private set; }
        public int Second { get; private set; }

        public void Roll()
        {
            First = rand.Next(1, 7);
            Second = rand.Next(1, 7);
        }
    }
}
