using System;
using System.Reflection;

namespace TestTask;

public class Solution
{
    public string solution(string S, string T)
    {
        if (S.Equals(T))
        {
            return "EQUAL";
        }
        if (S.Length == T.Length)
        {
            var difference = S.Zip(T, (s, t) => (s, t)).Where(tupleItem => tupleItem.s != tupleItem.t).ToList();
            if (difference.Count() == 1)
            {
                return $"REPLACE {difference.First().s} {difference.First().t}";
            }
            if (difference.Count() == 2)
            {
                if (difference.First().s == difference.Last().t && difference.First().t == difference.Last().s)
                {
                    return $"SWAP {difference.First().s} {difference.First().t}";
                }
            }
        }
        if (S.Length == (T.Length - 1))
        {
            for (int c = 0; c < T.Length; c++)
            {
                if (S.Length <= c || T[c] != S[c])
                {
                    if (S.Insert(c, T[c].ToString()).Equals(T))
                    {
                        return $"INSERT {T[c]}";
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        return "IMPOSSIBLE";
    }
}