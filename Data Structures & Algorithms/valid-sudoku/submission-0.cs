public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<string> data = new HashSet<string>();

        for (int row = 0; row < 9; row++)
        {
            for (int col = 0; col < 9; col++)
            {
                char c = board[row][col];

                if (c != '.')
                {
                    string nrow = c + " in row " + row;
                    string crow = c + " in col " + col;
                    string box  = c + " in box " + (row / 3) + "-" + (col / 3);

                    if (!data.Add(nrow)) return false;
                    if (!data.Add(crow)) return false;
                    if (!data.Add(box)) return false;
                }
            }
        }

        return true;
    }
}
