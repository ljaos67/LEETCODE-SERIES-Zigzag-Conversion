public class Solution {
    public string Convert(string s, int numRows) 
    {
        List<string> li = new List<string>();
        for(int i = 0; i<numRows;i++) li.Add(string.Empty);
        int j = 0, dir = -1;
        string ret = "";
        if(numRows <= 1) return s;
        for(int i = 0; i < s.Length; i++)
        {
            if(j == numRows -1 || j == 0)
            {
                dir *= (-1);
            }
            li[j] += s[i];
            if(dir == 1) j++;
            else j--;
        }
        foreach(string w in li)
        {
            ret += w;
        }
        return ret;
    }
}
