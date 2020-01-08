/************************************************************************
 * PROJECT      : Aesthetics
 * FILE         : Spacer.cs
 * AUTHOR       : Jason Brown (https://github.com/JCBrown602)
 * FRAMEWORK    : 4.5
 * DATE         : 10/9/2018 5:56:26 PM
 * DESCRIPTION  : 
 * LINK(S)      :
 ************************************************************************/
using System;

namespace Aesthetics
{
    /// <summary>
    /// 
    /// </summary>
    public class Spacer
    {
        #region Constructors
        // Chaining these for learning purposes
        public Spacer(char char1, int int1)
        {
            this.Char = char1;
            this.NumChar = int1;
            // DEBUG:
            Console.WriteLine(">> Spacer CTOR.");
        }

        public Spacer(char char1) : this(char1, 75) { }

        public Spacer() : this('*') { }

        public Spacer(int rndInt)
        {
            this.NumChar = 75;
            this.Char = (char)rndInt; // This makes ASCII chars...
#if SPACERTEST
            Console.WriteLine("\t>> CTOR: Spacer(int rndInt) <<");
#endif
        }
        #endregion

        #region Getters & Setters
        public char Char { get; set; }
        public int NumChar { get; set; }
        public int IsHeader { get; set; }
        //public char Char { get => _char; set => _char = value; } = '*';
        //public int NumChar { get => _numChar; set => _numChar = value; } = 50;
        #endregion

        #region Methods
        public void DisplayHeader(string title)
        {
            int width = Console.WindowWidth;
            Console.Title = title;
            Console.ForegroundColor = ConsoleColor.Green;
            Spacer sp = new Spacer('x', 127);
            //Spacer sp = new Spacer((char)22, Console.WindowWidth);
            string tagLine = ">>> ALL HAIL THE HYPNO TOAD! <<<";

            sp.ShowSpacer();
            Console.SetCursorPosition((width - title.Length) / 2, Console.CursorTop);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(title);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition((width - tagLine.Length) / 2, Console.CursorTop);
            Console.WriteLine(tagLine);
            sp.ShowSpacer();

            Console.ResetColor();
        }

        public void DisplayHeader(char aChar, string title)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            this.NumChar = Console.WindowWidth;
            Spacer sp = new Spacer((char)22);
            string tagLine = ">>> ALL HAIL THE HYPNO TOAD! <<<";

            sp.ShowSpacer();
            Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
            Console.WriteLine(title);
            sp.ShowSpacer();
            Console.ResetColor();
        }

        public void ShowSpacer()
        {
            for (int i = 0; i < this.NumChar; i++)
            {
                Console.Write(this.Char);
            }
            //Console.WriteLine();
            CurPos();
        }
        public void ShowSpacer(char c)
        {
            this.Char = c;
            for (int i = 0; i < this.NumChar; i++)
            {
                Console.Write(this.Char);
            }
            //Console.WriteLine();
            CurPos();
        }
        public void ShowSpacer(char c, int num)
        {
            this.Char = c;
            this.NumChar = num;
            for (int i = 0; i < this.NumChar; i++)
            {
                Console.Write(this.Char);
            }
            //Console.WriteLine();
            CurPos();
        }
        public void ShowSpacer(char c, bool full)
        {
            this.Char = c;
            this.NumChar = (full == true) ? Console.WindowWidth : this.NumChar;
            for (int i = 0; i < this.NumChar; i++)
            {
                Console.Write(this.Char);
            }
            //Console.WriteLine();
            CurPos();
        }

        public static void ShowSpacer(Spacer s)
        {
            for (int i = 0; i < s.NumChar; i++)
                Console.Write(s.Char);
            //Console.WriteLine();
            CurPos();
        }

        public static void CurPos()
        {
            //Console.SetCursorPosition(Console.CursorLeft, 0);
            
            //Console.WriteLine();
        }
#if DEBUG
        // Reference for selecting characters to use as spacer chars
        public void AvailableChars()
        {
            Console.Write("Decimal".PadRight(10));
            Console.Write("ASCII".PadRight(10));
            Console.Write("Hex".PadRight(10));
            Console.WriteLine();

            int min = 0;
            int max = 128;
            for (int i = min; i < max; i++)
            {
                // Get ASCII character.
                char c = (char)i;

                // Get display string.
                string display = string.Empty;
                if (char.IsWhiteSpace(c))
                {
                    display = c.ToString();
                    switch (c)
                    {
                        case '\t':
                            display = "\\t";
                            break;
                        case ' ':
                            display = "space";
                            break;
                        case '\n':
                            display = "\\n";
                            break;
                        case '\r':
                            display = "\\r";
                            break;
                        case '\v':
                            display = "\\v";
                            break;
                        case '\f':
                            display = "\\f";
                            break;
                    }
                }
                //else if (char.IsControl(c))
                //{
                //    display = "control";
                //}
                else
                {
                    display = c.ToString();
                }
                // Write table row.
                Console.Write(i.ToString().PadRight(10));
                Console.Write(display.PadRight(10));
                Console.Write(i.ToString("X2"));
                Console.WriteLine();
            }
        }
#endif
#endregion
    }

 
}
