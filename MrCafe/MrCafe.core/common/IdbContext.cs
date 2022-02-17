using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

namespace MrCafe.core.common
{
    public interface IdbContext
    {
        public DbConnection connection { get; }
    }
}
