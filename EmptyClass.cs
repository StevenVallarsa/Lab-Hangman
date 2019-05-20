using System;
namespace HangManStarterKit
{
    class EmptyClass : Player
    {
        private char CurrentChar;

        public EmptyClass()
        {
            CurrentChar = '`';
        }

        public override char Guess()
        {
            if (CurrentChar < 'z')
            {
                CurrentChar++;
                return CurrentChar;
            }
            else
            {
                ResetChar();
                return Guess();
            }
        }

        public void ResetChar()
        {
            CurrentChar = '`';
        }
    }
}
