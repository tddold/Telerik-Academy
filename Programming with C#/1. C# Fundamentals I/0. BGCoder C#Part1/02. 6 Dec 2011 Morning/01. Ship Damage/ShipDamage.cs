using System;
using System.Collections.Generic;

public class Point
{
    public Point(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }

    public Point()
    {
    }

    public int X
    {
        get;
        set;
    }

    public int Y
    {
        get;
        set;
    }
}

class ShipDamage
{
    private const int bombsCount = 3;

    public static int CalculateDamage(Point bomb, Point shipLeftDownCorner, Point shipRightUpCorner, int h)
    {
        Point newBomb = new Point(bomb.X, (-bomb.Y + 2 * h));

        if (newBomb.X < shipLeftDownCorner.X || newBomb.X > shipRightUpCorner.X ||
            newBomb.Y < shipLeftDownCorner.Y || newBomb.Y > shipRightUpCorner.Y)
        {
            return 0;
        }

        if ((newBomb.Y == shipLeftDownCorner.Y && newBomb.X == shipLeftDownCorner.X) ||
            (newBomb.Y == shipLeftDownCorner.Y && newBomb.X == shipRightUpCorner.X) ||
            (newBomb.Y == shipRightUpCorner.Y && newBomb.X == shipLeftDownCorner.X) ||
            (newBomb.Y == shipRightUpCorner.Y && newBomb.X == shipRightUpCorner.X))
        {
            return 25;
        }
        else if (newBomb.Y == shipLeftDownCorner.Y || newBomb.X == shipLeftDownCorner.X ||
            newBomb.Y == shipRightUpCorner.Y || newBomb.X == shipRightUpCorner.X)
        {
            return 50;
        }
        else
        {
            return 100;
        }
    }

    static void Main()
    {
        Point shipLeftDownCorner = new Point();

        shipLeftDownCorner.X = int.Parse(Console.ReadLine());
        shipLeftDownCorner.Y = int.Parse(Console.ReadLine());

        Point shipRightUpCorner = new Point();

        shipRightUpCorner.X = int.Parse(Console.ReadLine());
        shipRightUpCorner.Y = int.Parse(Console.ReadLine());

        int h = int.Parse(Console.ReadLine());
        List<Point> bombs = new List<Point>();

        for (int i = 0; i < bombsCount; i++)
        {
            bombs.Add(new Point(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
        }

        int result = 0;

        if (shipLeftDownCorner.X > shipRightUpCorner.X)
        {
            int temp = shipLeftDownCorner.X;
            shipLeftDownCorner.X = shipRightUpCorner.X;
            shipRightUpCorner.X = temp;
        }
        if (shipLeftDownCorner.Y > shipRightUpCorner.Y)
        {
            int temp = shipLeftDownCorner.Y;
            shipLeftDownCorner.Y = shipRightUpCorner.Y;
            shipRightUpCorner.Y = temp;
        }

        for (int i = 0; i < bombsCount; i++)
        {
            result += CalculateDamage(bombs[i], shipLeftDownCorner, shipRightUpCorner, h);
        }

        Console.WriteLine(result + "%");
    }
}