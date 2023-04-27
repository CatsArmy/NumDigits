Random rand = new Random();
int num = 0;
NumDigits[] digiArray= new NumDigits[15];
for (int i = 0; i < digiArray.Length; i++)
{
    num = rand.Next(100000, 1000000);
    NumDigits digits = new NumDigits(num);
    digiArray[i] = digits;
    Console.WriteLine($"Num = {num} digitArray[{i}].Digits[5] == {digits.Digits[5]}");
}
for (int i = 0; i < digiArray.Length; i += 2)
{
    num = rand.Next(1, 10);
    if (digiArray[i].Digits.Length % 2 == 0)
    {
        digiArray[i].IncDigits(num);
    }
    else
        digiArray[i].DecDigits(num);
}
NumDigits[] otherDigiArray = new NumDigits[digiArray.Length];
for (int i = 0; i < otherDigiArray.Length; i++)
{
    otherDigiArray[i] = new NumDigits(digiArray[i]);
}
otherDigiArray = NumDigits.BubbleSort(otherDigiArray);
for (int i = 0; i < 15; i++)
{
    Console.WriteLine($"digiArray[{i}].GetNum = {digiArray[i].GetNum()} | otherDigiArray[{i}].GetNum = {otherDigiArray[i].GetNum()}");
}