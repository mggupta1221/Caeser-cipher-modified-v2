using System;

namespace CaeserCipherAlgorithm
{
    public class CaeserCipher
    {
        private string cipheredText = "";

        private bool IsAlphabet(int alphabetsAsciiValue)
        {
            return ((IsCapitalAlphabet(alphabetsAsciiValue) || IsSmallAlphabet(alphabetsAsciiValue)));
        }
        private bool IsCapitalAlphabet(int alphabetsAsciiValue)
        {
            return (alphabetsAsciiValue >= 65 && alphabetsAsciiValue <= 90);
        }
        private bool IsSmallAlphabet(int alphabetsAsciiValue)
        {
            return (alphabetsAsciiValue >= 97 && alphabetsAsciiValue <= 122);
        }
        public string DoCeaserCipher(string inputString, int shiftingFactor) 
        {

            for (int count = 0; count < inputString.Length; count++)
            {
                int alphabetsAsciiValue = (int)(inputString[count]);
                if (IsAlphabet(alphabetsAsciiValue))
                {
                    int alphabetsAsciiValueWithShiftinFactor = alphabetsAsciiValue + shiftingFactor;
                    if ((IsCapitalAlphabet(alphabetsAsciiValueWithShiftinFactor) && IsCapitalAlphabet(alphabetsAsciiValue)) || ((IsSmallAlphabet(alphabetsAsciiValueWithShiftinFactor) && IsSmallAlphabet(alphabetsAsciiValue))))
                    {
                        char cipheredCharacter = (char)alphabetsAsciiValueWithShiftinFactor;
                        cipheredText += cipheredCharacter;
                    }
                    else
                    {
                        if (shiftingFactor > 0)
                        {
                            if (IsCapitalAlphabet(alphabetsAsciiValue))
                            {
                               alphabetsAsciiValueWithShiftinFactor = 64 + (alphabetsAsciiValueWithShiftinFactor - 90);
                                char c = (char)alphabetsAsciiValueWithShiftinFactor;
                                cipheredText += c;
                            }
                            else if (IsSmallAlphabet(alphabetsAsciiValue)) 
                            {
                                alphabetsAsciiValueWithShiftinFactor = 96 + (alphabetsAsciiValueWithShiftinFactor - 122);
                                char c = (char)alphabetsAsciiValueWithShiftinFactor;
                                cipheredText += c;
                            }
                        }
                        else
                        {
                            if (IsCapitalAlphabet(alphabetsAsciiValue))
                            {
                                if (alphabetsAsciiValueWithShiftinFactor < 65)
                                {
                                   alphabetsAsciiValueWithShiftinFactor = 90 - (64 - alphabetsAsciiValueWithShiftinFactor);
                                }
                                char c = (char)alphabetsAsciiValueWithShiftinFactor;
                                cipheredText += c;
                            }
                            else if (IsSmallAlphabet(alphabetsAsciiValue) && alphabetsAsciiValueWithShiftinFactor < 97) 
                            {
                               alphabetsAsciiValueWithShiftinFactor = 122 - (96 - alphabetsAsciiValueWithShiftinFactor);
                                char c = (char)alphabetsAsciiValueWithShiftinFactor;
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
