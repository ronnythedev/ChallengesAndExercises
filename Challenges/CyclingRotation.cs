namespace Challenges
{
    public class CyclingRotation
    {
        public static int[] Rotate(int[] originalArray, int numberOfRotation)
        {
            int counter = 1;
            int[] resultingArray = (int[])originalArray.Clone();

            while (counter <= numberOfRotation)
            {
                // save last position before the rotation
                int lastPosition = resultingArray[resultingArray.Length - 1];

                // iterate through the array and move each item one position forward
                for (int innerCounter = resultingArray.Length - 1; innerCounter >= 1; innerCounter--)
                {
                    resultingArray[innerCounter] = resultingArray[innerCounter - 1];
                }

                resultingArray[0] = lastPosition;

                counter += 1;
            }

            return resultingArray;
        }
    }
}
