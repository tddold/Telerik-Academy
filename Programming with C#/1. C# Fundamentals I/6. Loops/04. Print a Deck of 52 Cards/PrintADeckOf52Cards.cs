/*Problem 4. Print a Deck of 52 Cards
Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
The card faces should start from 2 to A.
Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.*/

using System;

class PrintADeckOf52Cards
{
    static void Main()
    {
        // First method        
        for (int i = 2; i <= 14; i++)
        {
            char card = '\u0042'; // Jack
            switch (i)
            {
                case 12:
                    card = '\u0051'; // Queen
                    break;
                case 13:
                    card = '\u004B'; // King
                    break;
                case 14:
                    card = '\u0041'; // Ace
                    break;
                default:
                    break;
            }

            if (i <= 10)
            {
                int counter = 1;
                while (counter <= 4)
                {
                    char suit = '\u2663';
                    switch (counter)
                    {
                        case 1:
                            suit = '\u2663'; // Clubs
                            break;
                        case 2:
                            suit = '\u2666'; // Diamonds
                            break;
                        case 3:
                            suit = '\u2665'; // Heart
                            break;
                        case 4:
                            suit = '\u2660'; // Spades
                            break;
                        default:
                            break;
                    }

                    Console.Write("{0, 3}{1}", i, suit);
                    counter++;
                }

                Console.WriteLine();
            }
            else
            {
                int counter = 1;
                while (counter <= 4)
                {
                    char suit = '\u2663';
                    switch (counter)
                    {
                        case 1:
                            suit = '\u2663'; // Clubs
                            break;
                        case 2:
                            suit = '\u2666'; // Diamonds
                            break;
                        case 3:
                            suit = '\u2665'; // Heart
                            break;
                        case 4:
                            suit = '\u2660'; // Spades
                            break;
                        default:
                            break;
                    }

                    Console.Write("{0, 3}{1}", card, suit);
                    counter++;
                }

                Console.WriteLine();
            }
        }

        // Second method
        Console.WriteLine();
        Console.WriteLine();
        char suitTwo;
        for (int i = 2; i <= 14; i++)
        {
            switch (i)
            {
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    for (int j = 1; j <= 4; j++)
                    {
                        switch (j)
                        {
                            case 1:
                                suitTwo = '\u2663';
                                Console.Write("{0, 3}{1}", i, '\u2663');
                                break;
                            case 2:
                                Console.Write("{0, 3}{1}", i, '\u2666');
                                break;
                            case 3:
                                Console.Write("{0, 3}{1}", i, '\u2665');
                                break;
                            case 4:
                                Console.Write("{0, 3}{1}", i, '\u2660');
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                case 11:
                    for (int j = 1; j <= 4; j++)
                    {
                        suitTwo = '\u0042';
                        switch (j)
                        {
                            case 1:
                                Console.Write("{0, 3}{1}", suitTwo, '\u2663');
                                break;
                            case 2:
                                Console.Write("{0, 3}{1}", suitTwo, '\u2666');
                                break;
                            case 3:
                                Console.Write("{0, 3}{1}", suitTwo, '\u2665');
                                break;
                            case 4:
                                Console.Write("{0, 3}{1}", suitTwo, '\u2660');
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                case 12:
                    for (int j = 1; j <= 4; j++)
                    {
                        suitTwo = '\u0051';
                        switch (j)
                        {
                            case 1:
                                Console.Write("{0, 3}{1}", suitTwo, '\u2663');
                                break;
                            case 2:
                                Console.Write("{0, 3}{1}", suitTwo, '\u2666');
                                break;
                            case 3:
                                Console.Write("{0, 3}{1}", suitTwo, '\u2665');
                                break;
                            case 4:
                                Console.Write("{0, 3}{1}", suitTwo, '\u2660');
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                case 13:
                    for (int j = 1; j <= 4; j++)
                    {
                        suitTwo = '\u004B';
                        switch (j)
                        {
                            case 1:
                                Console.Write("{0, 3}{1}", suitTwo, '\u2663');
                                break;
                            case 2:
                                Console.Write("{0, 3}{1}", suitTwo, '\u2666');
                                break;
                            case 3:
                                Console.Write("{0, 3}{1}", suitTwo, '\u2665');
                                break;
                            case 4:
                                Console.Write("{0, 3}{1}", suitTwo, '\u2660');
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                case 14:
                    suitTwo = '\u0041';
                    for (int j = 1; j <= 4; j++)
                    {
                        switch (j)
                        {
                            case 1:
                                Console.Write("{0, 3}{1}", suitTwo, '\u2663');
                                break;
                            case 2:
                                Console.Write("{0, 3}{1}", suitTwo, '\u2666');
                                break;
                            case 3:
                                Console.Write("{0, 3}{1}", suitTwo, '\u2665');
                                break;
                            case 4:
                                Console.Write("{0, 3}{1}", suitTwo, '\u2660');
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                default:
                    break;
            }

            Console.WriteLine();
        }
    }
}