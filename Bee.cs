using System;
using System.Collections.Generic;

namespace BeeKeeping_DanDavison
{
    public class Bee
    {
        //Attributes
        public string BeeName;
        public float BeeSize;

        //Constructor
        public Bee(string beename, float beesize)
        {
            BeeName = beename;
            BeeSize = beesize;
        }
    }
}