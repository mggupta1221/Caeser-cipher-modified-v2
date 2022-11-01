using System;

namespace CaeserCipherAlgorithm
{
    public class CaeserCipher
    {
        private string cipheredText = "";

        private bool IsAlphabet(int charAsciiCheck)
        {
            return ((IsCapitalAlphabet(charAsciiCheck) || IsSmallAlphabet(charAsciiCheck)));
        }
        private bool IsCapitalAlphabet(int charAsciiCheck)
        {
            return (charAsciiCheck >= 65 && charAsciiCheck <= 90);
        }
        private bool IsSmallAlphabet(int charAsciiCheck)
        {
            return (charAsciiCheck >= 97 && charAsciiCheck <= 122);
        }
        public string DoCeaserCipher(string inputString, int shiftingFactor) 
        {

            for (int count = 0; count < inputString.Length; count++)
            {
                int charAsciiValue = (int)(inputString[count]);
                if (IsAlphabet(charAsciiValue))
                {
                    int charAsciiValueWithShiftinFactor = charAsciiValue + shiftingFactor;
                    if ((IsCapitalAlphabet(charAsciiValueWithShiftinFactor) && IsCapitalAlphabet(charAsciiValue)) || ((IsSmallAlphabet(charAsciiValueWithShiftinFactor) && IsSmallAlphabet(charAsciiValue))))
                    {
                        char cipheredCharacter = (char)charAsciiValueWithShiftinFactor;
                        cipheredText += cipheredCharacter;
                    }
                    else
                    {
                        if (shiftingFactor > 0)
                        {
                            if (IsCapitalAlphabet(charAsciiValue))
                            {
                                charAsciiValueWithShiftinFactor = 64 + (charAsciiValueWithShiftinFactor - 90);
                                char c = (char)charAsciiValueWithShiftinFactor;
                                cipheredText += c;
                            }
                            else if (IsSmallAlphabet(charAsciiValue)) 
                            {
                                charAsciiValueWithShiftinFactor = 96 + (charAsciiValueWithShiftinFactor - 122);
                                char c = (char)charAsciiValueWithShiftinFactor;
                                cipheredText += c;
                            }
                        }
                        else
                        {
                            if (IsCapitalAlphabet(charAsciiValue))
                            {
                                if (charAsciiValueWithShiftinFactor < 65)
                                {
                                    charAsciiValueWithShiftinFactor = 90 - (64 - charAsciiValueWithShiftinFactor);
                                }
                                char c = (char)charAsciiValueWithShiftinFactor;
                                cipheredText += c;
                            }
                            else if (IsSmallAlphabet(charAsciiValue) && charAsciiValueWithShiftinFactor < 97) 
                            {
                                charAsciiValueWithShiftinFactor = 122 - (96 - charAsciiValueWithShiftinFactor);
                                char c = (char)charAsciiValueWithShiftinFactor;
                                cipheredText += c;
                            }
                        }

                    }
                }
                else
                {
                    cipheredText += inputString[count];
                }
            }
            return cipheredText;
        }
    }
}
