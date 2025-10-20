public struct Cell
{
    public bool HasMine;
    public bool Revealed;
    public int AdjacentMines;
}

class Program
{
    static int size = 9; // 9x9 grid
    static int mines = 10;
    static Cell[,] board = new Cell[size, size];
    static bool gameOver = false;

    static void Main()
    {
        SetupBoard();
        while (!gameOver)
        {
            PrintBoard();
            PlayerMove();
        }
    }

    static void SetupBoard()
    {
        Random rand = new Random();

        // Place mines randomly
        int placed = 0;
        while (placed < mines)
        {
            int r = rand.Next(size);
            int c = rand.Next(size);
            if (!board[r, c].HasMine)
            {
                board[r, c].HasMine = true;
                placed++;
            }
        }

        // Calculate adjacent mines
        for (int r = 0; r < size; r++)
        {
            for (int c = 0; c < size; c++)
            {
                if (board[r, c].HasMine) continue;
                int count = 0;
                for (int dr = -1; dr <= 1; dr++)
                {
                    for (int dc = -1; dc <= 1; dc++)
                    {
                        int nr = r + dr, nc = c + dc;
                        if (nr >= 0 && nr < size && nc >= 0 && nc < size && board[nr, nc].HasMine)
                            count++;
                    }
                }
                board[r, c].AdjacentMines = count;
            }
        }
    }

    static void PrintBoard()
    {
        Console.Clear();
        Console.WriteLine("Minesweeper\n");

        Console.Write("   ");
        for (int i = 0; i < size; i++) Console.Write(i + " ");
        Console.WriteLine();

        for (int r = 0; r < size; r++)
        {
            Console.Write(r + " |");
            for (int c = 0; c < size; c++)
            {
                if (!board[r, c].Revealed)
                    Console.Write("? ");
                else if (board[r, c].HasMine)
                    Console.Write("* ");
                else
                    Console.Write(board[r, c].AdjacentMines + " ");
            }
            Console.WriteLine();
        }
    }

    static void PlayerMove()
    {
        Console.Write("\nEnter row and column (e.g. 3 5): ");
        string? input = Console.ReadLine();
        if (string.IsNullOrEmpty(input)) return;

        string[] parts = input.Split(' ');
        if (parts.Length != 2) return;

        if (int.TryParse(parts[0], out int r) && int.TryParse(parts[1], out int c))
        {
            if (r < 0 || r >= size || c < 0 || c >= size) return;

            if (board[r, c].HasMine)
            {
                Console.Clear();
                Console.WriteLine("💥 You hit a mine! Game Over!");
                RevealAll();
                PrintBoard();
                gameOver = true;
                return;
            }

            RevealCell(r, c);

            if (CheckWin())
            {
                Console.Clear();
                Console.WriteLine("🎉 You won!");
                RevealAll();
                PrintBoard();
                gameOver = true;
            }
        }
    }

    static void RevealCell(int r, int c)
    {
        if (r < 0 || r >= size || c < 0 || c >= size) return;
        if (board[r, c].Revealed) return;

        board[r, c].Revealed = true;

        // If it's 0, reveal neighbors
        if (board[r, c].AdjacentMines == 0)
        {
            for (int dr = -1; dr <= 1; dr++)
            {
                for (int dc = -1; dc <= 1; dc++)
                {
                    if (dr != 0 || dc != 0)
                        RevealCell(r + dr, c + dc);
                }
            }
        }
    }

    static bool CheckWin()
    {
        for (int r = 0; r < size; r++)
        {
            for (int c = 0; c < size; c++)
            {
                if (!board[r, c].HasMine && !board[r, c].Revealed)
                    return false;
            }
        }
        return true;
    }

    static void RevealAll()
    {
        for (int r = 0; r < size; r++)
        {
            for (int c = 0; c < size; c++)
                board[r, c].Revealed = true;
        }
    }
}
