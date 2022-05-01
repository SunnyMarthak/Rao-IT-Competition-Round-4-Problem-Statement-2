using (StreamReader sr = new StreamReader("../../../Input.txt"))
{
    int n = Convert.ToInt32(sr.ReadLine());
    while (n-- > 0)
    {
        string S = sr.ReadLine();
        string F = sr.ReadLine();
        List<int> lstOperationSize = new List<int>();
        foreach (char s in S)
        {
            List<int> lstOperations = new List<int>();
            foreach (char f in F)
            {
                int Count = Math.Abs(Convert.ToInt32(f) - Convert.ToInt32(s));
                int ReverseCount = 26 - Count;
                if (Count > ReverseCount)
                {
                    lstOperations.Add(ReverseCount);
                }
                else
                {
                    lstOperations.Add(Count);
                }
            }
            lstOperations.Sort();
            lstOperationSize.Add(lstOperations.First());
        }
        int Sum = 0;
        for (int i = 0; i < lstOperationSize.Count; i++)
        {
            Sum += lstOperationSize[i];
        }
        Console.WriteLine(Sum);
    }
}