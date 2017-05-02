using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Domain
{
    public enum NewsStatus
    {
        Silindi = -2,
        HaGayret = 0,
        YeniOnerge = 2,
        KoskeGonderildi = 4,
        YururlugeGirdi = 6,
    }
    public enum UserRole
    {
        Muhabir = 0,
        Yazar = 2,
        Editor = 4,
        Moderator = 6,
    }
}
