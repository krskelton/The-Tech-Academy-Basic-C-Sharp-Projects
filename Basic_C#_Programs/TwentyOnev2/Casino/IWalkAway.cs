using System;
using System.Collections.Generic;
using System.Text;

namespace Casino
{
    interface IWalkAway
    {
        //There must be some way for the user to stand up and walk away in this game
        void WalkAway(Player player);
    }
}
