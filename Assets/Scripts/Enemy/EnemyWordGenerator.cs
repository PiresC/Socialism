﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWordGenerator : MonoBehaviour
{
    private static string[] wordList =
    {
        "long",
"innocent",
"wide-eyed",
"exultant",
"zoo",
"premium",
"stitch",
"cake",
"ratty",
"advise",
"deeply",
"divide",
"look",
"ball",
"train",
"magnificent",
"tasteless",
"statement",
"tearful",
"false",
"face",
"concentrate",
"lowly",
"average",
"rare",
"cultured",
"chubby",
"slip",
"car",
"machine",
"sprout",
"elbow",
"radiate",
"cat",
"agreeable",
"flap",
"hover",
"spicy",
"treatment",
"known",
"wacky",
"acidic",
"clean",
"pink",
"disagreeable",
"subsequent",
"strip",
"thunder",
"action",
"subtract",
"suit",
"lighten",
"trucks",
"side",
"dull",
"pet",
"slimy",
"ossified",
"snake",
"oven",
"versed",
"obscene",
"finicky",
"attractive",
"descriptive",
"disturbed",
"erect",
"previous",
"brick",
"wire",
"profit",
"ocean",
"belligerent",
"puffy",
"magenta",
"whistle",
"glorious",
"dear",
"consist",
"afternoon",
"lake",
"cabbage",
"protective",
"abject",
"dress",
"hospitable",
"spoil",
"squirrel",
"delightful",
"nest",
"queue",
"young",
"redundant",
"common",
"market",
"penitent",
"saw",
"stamp",
"abrupt",
"race",
"dark",
"voice",
"tramp",
"admit",
"face",
"behave",
"grandiose",
"cool",
"ice",
"mere",
"value",
"aware",
"exuberant",
"degree",
"intelligent",
"decision",
"whip",
"scale",
"humor",
"early",
"sisters",
"worried",
"arrest",
"sneeze",
"tacit",
"play",
"fool",
"mountain",
"join",
"toad",
"fumbling",
"heartbreaking",
"request",
"enchanted",
"silk",
"substance",
"sulky",
"leg",
"cross",
"night",
"hot",
"troubled",
"skillful",
"sheep",
"memorise",
"horrible",
"incandescent",
"faded",
"rotten",
"spiders",
"sore",
"wholesale",
"excite",
"proud",
"money",
"nice",
"brush",
"committee",
"blow",
"old-fashioned",
"enter",
"sand",
"enormous",
"glove",
"festive",
"alive",
"numerous",
"dare",
"aloof",
"jittery",
"amount",
"ambitious",
"knowledgeable",
"sloppy",
"gray",
"fancy",
"abashed",
"victorious",
"river",
"wait",
"pail",
"dinner",
"flimsy",
"test",
"complex",
"bad",
"calculate",
"telephone",
"basin",
"hook",
"return",
"fast",
"impartial",
"behavior",
"foot",
"hospital",
"house",
"shaky",
"rightful",
"recognise",
"pick",
"vase",
"third",
"kiss",
"heat",
"territory",
"unpack",
"gleaming",
"wrong",
"furry",
"trashy",
"watch",
"country",
"wish",
"scene",
"yellow",
"unruly",
"concerned",
"vessel",
"chew",
"vanish",
"spring",
"clip",
"welcome",
"identify",
"dry",
"cable",
"attract",
"sip",
"drag",
"kill",
"military",
"snobbish",
"spy",
"many",
"monkey",
"kick",
"brass",
"frequent",
"petite",
"needle",
"remove",
"eggs",
"detect",
"love",
"pot",
"bit",
"rough",
"stomach",
"pump"
    };


    public static string GetRandomWord()
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];

        return randomWord;
    }
}
