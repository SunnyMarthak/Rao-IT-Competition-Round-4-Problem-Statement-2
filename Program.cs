int n = Convert.ToInt32(Console.ReadLine());
Dictionary<string, string> dctSF = new Dictionary<string, string>();
for(int i = 0; i < n; i++)
{
    string key = Console.ReadLine();
    string value = Console.ReadLine();
    dctSF.Add(key, value);
}
foreach (KeyValuePair<string, string> kvp in dctSF)
{
    string S = kvp.Key;
    string F = kvp.Value;
    List<int> lstOperationSize = new List<int>();
    foreach (char s in S)
    {
        List<int> lstOperations = new List<int>();
        foreach (char f in F)
        {
            lstOperations.Add(Math.Abs(Convert.ToInt32(f) - Convert.ToInt32(s)));
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