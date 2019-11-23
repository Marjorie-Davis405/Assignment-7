using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{
    private static string[] wordList = { "icicle", "return", "seashore", "chalk", "mew", "shrink",
                                          "hoax", "spiky", "fork", "swing", "bray", "rush", "nosy",
                                          "smoke", "know", "true", "dog", "useless", "bright",
                                          "oblige", "hapless", "extra-small", "comment",
                                          "kittens", "boil", "unadvised", "boorish", "sneeze",
                                          "warn", "advice", "accidental", "design", "answer",
                                          "need", "understood", "payment", "temper", "arm",
                                          "share", "spy", "winter", "copy", "mark", "jumbled", "bat",
                                          "choke", "kindhearted", "naughty", "chat", "restrain", "bless",
                                          "mountainous", "scarecrow", "slay", "exultant", "authority",
                                          "umbrella", "spiky", "festive", "sedate", "redo", "striped",
                                          "fragile", "parent", "close", "previous", "consort", "carry",
                                          "shirt", "curly", "dysfunctional", "suggestion", "sofa",
                                          "ceaseless", "shun", "airplane", "create", "creator",
                                          "station", "sad", "cute", "cherries", "past", "trees",  };

    public static string GetRandomWord ()
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];

        return randomWord;
    }

}
