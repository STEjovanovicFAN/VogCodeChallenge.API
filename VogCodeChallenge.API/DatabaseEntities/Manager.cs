using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VogCodeChallenge.API.DatabaseEntities
{
    public class Manager : Employee
    {
        public int ManagerBudget { get; set; }
    }
}
