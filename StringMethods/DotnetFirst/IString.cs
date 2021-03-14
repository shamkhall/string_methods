using System;

namespace DotnetFirst
{
    class IString
    {
    

    public int ILenght(string word)
    {
        int i = 0;
        foreach (char c in word)
        {
            i++;
        }
        return i;
    }

    public bool IContains(string word, string secondWord)
    {
        for (int i = 0; i < ILenght(word) - ILenght(secondWord) + 1; i++)
        {
            if (word.Substring(i, ILenght(secondWord)) == secondWord)
            {
                return true;
            }
        }

        return false;
    }
    
    public bool IEndWith(string word, string secondWord)
    {
        if (word.Substring(ILenght(word) - ILenght(secondWord), ILenght(secondWord)) == secondWord)
        {
            return true;
        }
        
        return false;
    }
    
    public int IIndexOf(string word, string secondWord)
    {
        int i = 0;

        while (i < ILenght(word) - ILenght(secondWord))
        {
            if (word.Substring(i, ILenght(secondWord)) == secondWord)
            {
                return i;
            }
            i++;
        }

        return -1;
    } 
    public int ILastIndexOf(string word, string secondWord)
    {
        int i = word.Length;

        while (i > secondWord.Length)
        {
            if (word.Substring(i - ILenght(secondWord), ILenght(secondWord)) == secondWord)
            {
                return i - ILenght(secondWord);
            }
            i--;
        }

        return -1;

    }
    
        
    }
}