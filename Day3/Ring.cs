using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public class Ring
    {
        int ringNumberCount;
        int maxNumberInRing;
        int minNumberInRing;
        int bottomLeft;
        int topRight;
        int bottomRight;
        int topLeft;
        double input;
        int ring;

        public Ring(double input)
        {
            this.input = input;
            SetRing(input);
            SetRingProperties();
            
        }

        public void SetRing(double num)
        {
            if (num == 1)
                this.ring = 1;

            var squareRoot = (int)Math.Ceiling(Math.Sqrt(num));
            if (squareRoot % 2 == 0)
            {
                this.ring = (squareRoot + 1) / 2;
            }
            this.ring =  squareRoot / 2;

        }

        public void SetRingProperties()
        {
            var square = this.ring*2 + 1;
            var maxOfLowerRing = (int)Math.Pow((square - 2), 2);
            this.maxNumberInRing = (int)Math.Pow(square, 2);
            this.ringNumberCount = maxNumberInRing - maxOfLowerRing;
            var side = ringNumberCount / 4;
            this.minNumberInRing = maxOfLowerRing + 1;
            this.bottomRight = maxNumberInRing;
            this.bottomLeft = maxNumberInRing - side;
            this.topLeft = bottomLeft - side;
            this.topRight = topLeft - side;

        }

        public override string ToString()
        {
            return $"For the input {input}:\nThe ring is {ring}\nHighest number in ring is {maxNumberInRing}\nMinimum number in ring is {minNumberInRing}\nTop Left: {topLeft} TopRight: {topRight}\nBottomLeft: {bottomLeft} BottomRight: {bottomRight}";
        }

    }
}
