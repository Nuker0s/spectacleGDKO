using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jokes : MonoBehaviour
{
    public List<List<List<string>>> terribleJokes = new List<List<List<string>>>
{
    new List<List<string>>
    {
        new List<string> {"Why", "don't", "scientists", "trust", "atoms?"},
        new List<string> {"Because", "they", "make", "up", "everything!"}
    },

    new List<List<string>>
    {
        new List<string> {"Why", "don't", "skeletons", "fight", "each", "other?"},
        new List<string> {"They", "don't", "have", "the", "guts."}
    },

    new List<List<string>>
    {
        new List<string> {"I", "only", "know", "25", "letters", "of", "the", "alphabet."},
        new List<string> {"I", "don't", "know", "y."}
    },

    new List<List<string>>
    {
        new List<string> {"Why", "did", "the", "scarecrow", "win", "an", "award?"},
        new List<string> {"Because", "he", "was", "outstanding", "in", "his", "field."}
    },

    new List<List<string>>
    {
        new List<string> {"What", "do", "you", "call", "fake", "spaghetti?"},
        new List<string> {"An", "impasta."}
    },

    new List<List<string>>
    {
        new List<string> {"Why", "did", "the", "bicycle", "fall", "over?"},
        new List<string> {"Because", "it", "was", "two-tired."}
    },

    new List<List<string>>
    {
        new List<string> {"Did", "you", "hear", "about", "the", "mathematician", "who's", "afraid", "of", "negative", "numbers?"},
        new List<string> {"He'll", "stop", "at", "nothing", "to", "avoid", "them."}
    },

    new List<List<string>>
    {
        new List<string> {"Why", "did", "the", "tomato", "turn", "red?"},
        new List<string> {"Because", "it", "saw", "the", "salad", "dressing."}
    },

    new List<List<string>>
    {
        new List<string> {"Why", "did", "the", "golfer", "bring", "two", "pairs", "of", "pants?"},
        new List<string> {"In", "case", "he", "got", "a", "hole", "in", "one."}
    },

    new List<List<string>>
    {
        new List<string> {"How", "do", "you", "organize", "a", "space", "party?"},
        new List<string> {"You", "planet."}
    },

    new List<List<string>>
    {
        new List<string> {"What", "do", "you", "call", "a", "fish", "with", "no", "eyes?"},
        new List<string> {"Fsh."}
    },

    new List<List<string>>
    {
        new List<string> {"Why", "did", "the", "chicken", "go", "to", "the", "seance?"},
        new List<string> {"To", "talk", "to", "the", "other", "side."}
    },

    new List<List<string>>
    {
        new List<string> {"Why", "did", "the", "coffee", "file", "a", "police", "report?"},
        new List<string> {"It", "got", "mugged."}
    },

    new List<List<string>>
    {
        new List<string> {"What", "did", "the", "janitor", "say", "when", "he", "jumped", "out", "of", "the", "closet?"},
        new List<string> {"Supplies!"}
    },

    new List<List<string>>
    {
        new List<string> {"Why", "don't", "scientists", "trust", "atoms?"},
        new List<string> {"Because", "they", "make", "up", "everything."}
    },

    new List<List<string>>
    {
        new List<string> {"What", "did", "one", "plate", "say", "to", "another", "plate?"},
        new List<string> {"Tonight,", "dinner's", "on", "me."}
    },

    new List<List<string>>
    {
        new List<string> {"I", "told", "my", "wife", "she", "should", "embrace", "her", "mistakes."},
        new List<string> {"She", "gave", "me", "a", "hug."}
    },

    new List<List<string>>
    {
        new List<string> {"What", "do", "you", "get", "when", "you", "cross", "a", "snowman", "and", "a", "vampire?"},
        new List<string> {"Frostbite."}
    },

    new List<List<string>>
    {
        new List<string> {"I", "used", "to", "play", "piano", "by", "ear,"},
        new List<string> {"but", "now", "I", "use", "my", "hands." }
    },

    new List<List<string>>
    {
        new List<string> {"What", "did", "the", "grape", "do", "when", "it", "got", "stepped", "on?"},
        new List<string> {"Nothing", "but", "let", "out", "a", "little", "wine."}
    },

    new List<List<string>>
    {
        new List<string> {"Why", "did", "the", "math", "book", "look", "sad?"},
        new List<string> {"Because", "it", "had", "too", "many", "problems."}
    },

    new List<List<string>>
    {
        new List<string> {"Why", "did", "the", "scarecrow", "win", "an", "award?"},
        new List<string> {"Because", "he", "was", "outstanding", "in", "his", "field."}
    },

    new List<List<string>>
    {
        new List<string> {"What", "do", "you", "call", "a", "pile", "of", "cats?"},
        new List<string> {"A", "meowtain."}
    },

    new List<List<string>>
    {
        new List<string> {"Why", "don't", "scientists", "trust", "atoms?"},
        new List<string> {"Because", "they", "make", "up", "everything."}
    },

    new List<List<string>>
    {
        new List<string> {"Did", "you", "hear", "about", "the", "cheese", "factory", "explosion?"},
        new List<string> {"There", "was", "nothing", "left", "but", "de-brie."}
    },

    new List<List<string>>
    {
        new List<string> {"What", "do", "you", "call", "fake", "spaghetti?"},
        new List<string> {"An", "impasta."}
    },

    new List<List<string>>
    {
        new List<string> {"Why", "did", "the", "bicycle", "fall", "over?"},
        new List<string> {"Because", "it", "was", "two-tired."}
    },

    new List<List<string>>
    {
        new List<string> {"How", "do", "you", "organize", "a", "space", "party?"},
        new List<string> {"You", "planet."}
    },

    new List<List<string>>
    {
        new List<string> {"What", "do", "you", "call", "a", "fish", "with", "no", "eyes?"},
        new List<string> {"Fsh."}
    },

    new List<List<string>>
    {
        new List<string> {"Why", "did", "the", "golfer", "bring", "two", "pairs", "of", "pants?"},
        new List<string> {"In", "case", "he", "got", "a", "hole", "in", "one."}
    },

    new List<List<string>>
    {
        new List<string> {"How", "does", "a", "penguin", "build", "its", "house?"},
        new List<string> {"Igloos", "it", "together."}
    },

    new List<List<string>>
    {
        new List<string> {"What", "did", "the", "left", "eye", "say", "to", "the", "right", "eye?"},
        new List<string> {"Between", "you", "and", "me,", "something", "smells."}
    },

    new List<List<string>>
    {
        new List<string> {"Why", "did", "the", "tomato", "turn", "red?"},
        new List<string> {"Because", "it", "saw", "the", "salad", "dressing."}
    },

    new List<List<string>>
    {
        new List<string> {"I", "told", "my", "wife", "she", "should", "embrace", "her", "mistakes."},
        new List<string> {"She", "gave", "me", "a", "hug."}
    },

    new List<List<string>>
    {
        new List<string> {"What", "did", "one", "hat", "say", "to", "the", "other?"},
        new List<string> {"Stay", "here,", "I'm", "going", "on", "ahead."}
    },

    new List<List<string>>
    {
        new List<string> {"Why", "don't", "skeletons", "fight", "each", "other?"},
        new List<string> {"They", "don't", "have", "the", "guts."}
    },

    new List<List<string>>
    {
        new List<string> {"Why", "did", "the", "math", "book", "look", "sad?"},
        new List<string> {"Because", "it", "had", "too", "many", "problems."}
    },

    new List<List<string>>
    {
        new List<string> {"What", "do", "you", "call", "a", "snowman", "with", "a", "six-pack?"},
        new List<string> {"An", "abdominal", "snowman."}
    },

    new List<List<string>>
    {
        new List<string> {"Why", "did", "the", "scarecrow", "become", "a", "successful", "politician?"},
        new List<string> {"He", "was", "outstanding", "in", "his", "field."}
    },

    new List<List<string>>
    {
        new List<string> {"Why", "don't", "scientists", "trust", "atoms?"},
        new List<string> {"Because", "they", "make", "up", "everything."}
    },

    new List<List<string>>
    {
        new List<string> {"Did", "you", "hear", "about", "the", "cheese", "factory", "that", "exploded?"},
        new List<string> {"There", "was", "nothing", "left", "but", "de-brie."}
    },

    new List<List<string>>
    {
        new List<string> {"Why", "don't", "eggs", "tell", "each", "other", "secrets?"},
        new List<string> {"Because", "they", "might", "crack", "up."}
    },

    new List<List<string>>
    {
        new List<string> {"What", "did", "one", "ocean", "say", "to", "the", "other", "ocean?"},
        new List<string> {"Nothing,", "they", "just", "waved."}
    },

    new List<List<string>>
    {
        new List<string> {"Why", "did", "the", "chicken", "go", "to", "the", "seance?"},
        new List<string> {"To", "talk", "to", "the", "other", "side."}
    },

    new List<List<string>>
    {
        new List<string> {"Why", "was", "the", "belt", "arrested?"},
        new List<string> {"Because", "it", "was", "holding", "up", "a", "pair", "of", "pants."}
    },

    new List<List<string>>
    {
        new List<string> {"What", "do", "you", "call", "a", "pile", "of", "cats?"},
        new List<string> {"A", "meowtain."}
    },

    new List<List<string>>
    {
        new List<string> {"Why", "did", "the", "bicycle", "fall", "over?"},
        new List<string> {"Because", "it", "was", "two-tired."}
    },

    new List<List<string>>
    {
        new List<string> {"How", "does", "a", "penguin", "build", "its", "house?"},
        new List<string> {"Igloos", "it", "together."}
    },

    new List<List<string>>
    {
        new List<string> {"What", "did", "one", "hat", "say", "to", "the", "other?"},
        new List<string> {"Stay", "here,", "I'm", "going", "on", "ahead."}
    } 
};

    void Start()
    {
        /* //say all
        foreach (var joke in terribleJokes)
        {
            Debug.Log(joke[0][0]);
        }*/

    }

    
    // Update is called once per frame
    void Update()
    {
        
    }
}
