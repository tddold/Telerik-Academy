/*Problem 3. Read file contents
Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
Find in MSDN how to use System.IO.File.ReadAllText(…).
Be sure to catch all possible exceptions and print user-friendly error messages.*/

using System;
using System.IO;

class ReadFileContents
{
    static void Main()
    {
        Console.WriteLine("Problem 3. Read file contents");
        PrintSeparateLine();

        try
        {
            Console.WriteLine("> Trying to read file content...\n");

            using (StreamReader reader = new StreamReader(@"C:\WINDOWS\win.ini"))
            {
                Console.WriteLine(File.ReadAllText(@"C:\WINDOWS\win.ini"));
            }

            Console.WriteLine("> File's content was sucessfully read!\n");
        }
        catch (DriveNotFoundException ex)
        {
            PrintErrorMessage(ex);
        }
        catch (DirectoryNotFoundException ex)
        {
            PrintErrorMessage(ex);
        }
        catch (EndOfStreamException ex)
        {
            PrintErrorMessage(ex);
        }
        catch (FileNotFoundException ex)
        {
            PrintErrorMessage(ex);
        }
        catch (FileLoadException ex)
        {
            PrintErrorMessage(ex);
        }
        catch (PathTooLongException ex)
        {
            PrintErrorMessage(ex);
        }
        catch (UnauthorizedAccessException ex)
        {
            PrintErrorMessage(ex);
        }
        catch (IOException ex)
        {
            PrintErrorMessage(ex);
        }
        catch
        {
            Console.WriteLine("Fatal error occurred.");
        }
        finally
        {
            Console.WriteLine("Good bay!");
        }

        PrintSeparateLine();
    }

    static void PrintErrorMessage(Exception error)
    {
        Console.Error.WriteLine("-> Error! {0}\n", error.Message);
    }

    public static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }
}