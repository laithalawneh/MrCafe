using MrCafe.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MrCafe.Core.Repository
{
    public interface IRollRepository
    {
        public List<Roll> getallRoll();
        public bool insertRoll(Roll roll);
        public bool updateRoll(Roll roll);
        public bool deleteRoll(int id);
        public List<Roll> GetRollById(Roll roll);
        public List<Roll> GetRollByName(Roll roll);

    }
}
