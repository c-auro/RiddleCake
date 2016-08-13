using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiddleCake.Theory
{
    class KeyConfig
    {
        enum minor
        {
            
        }
    }
    class KeySignature
    {
        private int clef;
        private char key;
        private Note[][] scale; 
        //integer representation of each type of scale
        //use offsets to determine octave if threaded mp3 octaves, or integer offesets for literal frequency
        //the key signature is determined per measure, so at the beginning of each measure, all of the scales 
        //will be calculated if the key signature changes, this allows quick 'fingering' such as 135 or i-iii-v or some similar notation
        //user can input a type of scale and the numbers or a default of major

        public KeySignature(char k)
        {
            clef = 4; 
            key = k;
            switch (k)
            {
                //system could instead be based on the number of steps for major and minor chords
                //but the scale would still be determined at that point
                case 'A': GetScale('A');  break; 
                case 'a': break;
                case 'B': break;
                case 'b': GetScale('b');  break;
                default: break; 
            }
        }

        private Note[][] GetScale(char k)
        {
           
            return new Note[5][6];
        }
    }
    class TimeSignature
    {
        private int beatsPerMeasure;
        private int tempo; 
        //beats per measure 
        //note that gets one beat
        //need to create an algorithm to calculate this
    }
    class Note
    {
        private int duration;
        private int pitch;
        private char letter; 
    }
    class Measure
    {
        public Measure(TimeSignature t, KeySignature k, Note[] n)
        {

        }
    }
    class Score
    {
        public Score(Measure[] m)
        {
            
        }
    }

}
