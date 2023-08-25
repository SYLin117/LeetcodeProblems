namespace Solutions.Mathworks;

public static class CustomCode
{
    public static int VersionCompare( string version1, string version2 ) {
        //Insert your code here 
        var v1 = version1.Split('.').ToList();
        var v2 = version2.Split('.').ToList();
        while (v1.Count > v2.Count)
        {
            v2.Add("0");
        }

        while (v1.Count < v2.Count)
        {
            v1.Add("0");
        }

        for (int i = 0; i < v1.Count; i++)
        {
            int one = Int32.Parse(v1[i]);
            int two = Int32.Parse(v2[i]);
            if (one < two) return -1;
            else if (one > two) return 1;
        }

        return 0;
    }
}