Hetmani hetmani = new Hetmani();
//hetmani.Koloruj();
hetmani.isSafe(7, 7);
hetmani.Wstawianie();
hetmani.Rysuj();

class Hetmani
{
    public int[,] plansza = new int[8, 8];

    public bool isSafe(int row, int col)
    {
        //sprawdza czy w jednym rzedzie jest hetman
        for (int i = 0; i < 8 && i >= 0; i++)
        {
            if (plansza[row, i] == 1)
            {
                return false;
            }
        }
        //sprawdza w pionie
        for (int x = row, y = col; x >= 0 && y < 8; x--)
        {
            if (plansza[x, y] == 1)
            {
                return false;
            }
        }
        //sprawdza czy w skosie prawy gorny-lewy dolny
        for (int x = row, y = col; x >= 0 && x < 8 && y < 8 && y >= 0; x--, y++)
        {
            if (plansza[x, y] == 1)
            {
                return false;
            }
        }
        //sprawdza czy w skosie prawy dolny-lewy gorny
        for (int x = row, y = col; x < 8 && x >= 0 && y < 8 && y >= 0; x--, y--)
        {
            if (plansza[x, y] == 1)
            {
                return false;
            }
        }

        return true;
    }

    public void Rysuj()
    {
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                Console.Write(plansza[i, j] + "   ");
            }
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }

    public void Wstawianie()
    {
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                if (isSafe(i, j))
                {
                    plansza[i, j] = 1;
                }
            }   
        }
    }

    //public void Koloruj()
    //{
    //    Console.BackgroundColor = ConsoleColor.White;
    //}
}
