public class NumDigits
{

    public int[] Digits;
    //private int numID;

    public NumDigits(int num)
    {
        int maxIdx = num.ToString().Length;
        Digits = new int[maxIdx];
        for (int i = 0; i < maxIdx; i++)
        {
            Digits[i] = num % 10;
            num /= 10;
        }
    }
    public NumDigits(NumDigits otherDigit)
    {
        Digits = new int [otherDigit.Digits.Length];
        for (int i = 0; i < Digits.Length; i++)
        {
            Digits[i] = otherDigit.Digits[i];
        }
    }
    /*public static NumDigits[] CopyTo(NumDigits[] copy)
    {
        NumDigits[] to = new NumDigits[copy.Length];
        for (int i = 0; i < to.Length; i++)
        {
            to[i] = new NumDigits(copy[i]);
        }
        return to;
    }*/
    public int GetDigit(int order)
    {
        if (Digits[order] > 9 || Digits[order] < 0)
        {
            return -1;
        }
        return Digits[order];
    }
    public static NumDigits[] BubbleSort(NumDigits[] bubble)
    {
        NumDigits tempBubble;
        int tempIndx;
        for (int i = 0; i < bubble.Length - 1; i++)
        {
            for (int j = 0; j < bubble.Length - i - 1; j++)
            {
                tempIndx = j + 1;
                tempBubble = bubble[j];
                if (bubble[tempIndx].GetNum() < bubble[j].GetNum())
                {
                    bubble[j] = bubble[tempIndx];
                    bubble[tempIndx] = tempBubble;
                }
            }
        }

        return bubble;
    }
    public int GetNum()
    {
        int numID = 0;
        int num = 1;
        for (int i = 0; i < Digits.Length; i++, num *= 10)
        {
            numID += Digits[i] * num;
            //numID += Digits[i] * Math.POW(10, i)
        }
        return numID;
    }
    public int IncDigits(int order)
    {
        if (order > Digits.Length - 1)
        {
            order = Digits.Length -1;
        } 
        else if (order < 0) 
        {
            order = 0;
        }
        if (Digits[order] == 9)
        {
            return 0;
        }
        return Digits[order]++;
    }
    public int DecDigits(int order)
    {
        if (order > Digits.Length - 1)
        {
            order = Digits.Length - 1;
        } 
        else if (order < 0) 
        {
            order = 0;
        }
        if (Digits[order] == 0)
        {
            return 9;
        }
        return Digits[order]--;
    }
}