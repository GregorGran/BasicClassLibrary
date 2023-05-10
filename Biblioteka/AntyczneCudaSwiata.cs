using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    [System.Flags]
    public enum AntyczneCudaSwiata : byte
    {
        Brak                        = 0b_0000_0000,
        PiramidaCheopsa             = 0b_0000_0001,
        WiszaceOgrody               = 0b_0000_0010,
        ZeusWOlimpii                = 0b_0000_0100,
        SwiatyniaArtemidy           = 0b_0000_1000,
        MauzoleumWHalikarnasie      = 0b_0001_0000,
        KolosRodyjski               = 0b_0010_0000,
        LatarniaMorskaNaFaros       = 0b_0100_0000
    }
}
