using MrCafe.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MrCafe.Core.Service
{
    public interface IRollService
    {
        public List<Roll> GetAllRolls();
        public bool CreateRoll(Roll roll);
        public bool UpdateRoll(Roll roll);
        public bool DeleteRoll(int id);
        public List<Roll> GetRollById(Roll roll);
        public List<Roll> GetRollByName(Roll roll);
    }
}
