public class Solution {
    public string MinRemoveToMakeValid(string s) {
        int openCnt = 0, closeCnt = 0;
        foreach (char c in s) {
            if (c == ')') closeCnt++;
        }

        StringBuilder res = new StringBuilder();
        foreach (char c in s) {
            if (c == '(') {
                if (openCnt == closeCnt) continue;
                openCnt++;
            } else if (c == ')') {
                closeCnt--;
                if (openCnt == 0) continue;
                openCnt--;
            }
            res.Append(c);
        }

        return res.ToString();
    }
}
