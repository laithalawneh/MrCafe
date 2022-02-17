using MrCafe.Core.Data;
using MrCafe.Core.Repository;
using MrCafe.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace MrCafe.Infra.Service
{
    public class RollService : IRollService
    {
        private readonly IRollRepository _rollRepository;

        public RollService(IRollRepository rollService)
        {
            _rollRepository = rollService;
        }
        public bool CreateRoll(Roll roll)
        {
            return _rollRepository.insertRoll(roll);
        }

        public bool DeleteRoll(int id)
        {
            return _rollRepository.deleteRoll(id);
        }

        public List<Roll> GetAllRolls()
        {
            return _rollRepository.getallRoll();
        }

        public List<Roll> GetRollById(Roll roll)
        {
            return _rollRepository.GetRollById(roll);
        }

        public List<Roll> GetRollByName(Roll roll)
        {
            return _rollRepository.GetRollByName(roll);
        }

        public bool UpdateRoll(Roll roll)
        {
            return _rollRepository.updateRoll(roll);
        }
    }
}
