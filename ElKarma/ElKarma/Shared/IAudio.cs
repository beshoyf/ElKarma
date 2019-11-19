using System;
using System.Collections.Generic;
using System.Text;

namespace ElKarma.Shared
{
    public interface IAudio
    {
        bool Play_Pause(string url);
        bool Stop(bool val);
    }
}
