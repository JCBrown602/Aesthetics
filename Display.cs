/************************************************************************
 * PROJECT      : Aesthetics
 * FILE         : Display
 * AUTHOR       : Jason Brown (https://github.com/JCBrown602)
 * FRAMEWORK    : 4.5
 * DATE         : 10/9/2018 9:52:12 PM
 * DESCRIPTION  : The date for the original project was 15 AUG 2017.
 * LINK(S)      :
 ************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aesthetics
{
    public class Display
    {
        #region Properties
#if DEBUG
        // These are taken care of by AutoProperties
        //private char _char   = '*';
        //private int _numChar = 75;
#endif
#endregion

        #region Constructors
        // Chaining these for learning purposes
        public Display(char char1, int int1)
        {
            this.Char = char1;
            this.NumChar = int1;
        }
        public Display(char char1) : this(char1, 75) { }
        public Display() : this('*') { }

        public Display(int rndInt)
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
        //public char Char { get => _char; set => _char = value; } = '*';
        //public int NumChar { get => _numChar; set => _numChar = value; } = 50;
        #endregion
    }
}

// Custom C# template including comment header for school and Phill's sanity check.