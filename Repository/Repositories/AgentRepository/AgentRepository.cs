using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Repository.Data;
using System.Linq;

namespace Repository.Repositories.AgenRepository
{
    public class AgentRepository : IAgentRepository
    {
        private readonly ThemegeniuslabDbContext _context;

        public AgentRepository(ThemegeniuslabDbContext context)
        {
            _context = context;
        }


        public IEnumerable<Agent> GetAgents()
        {
            return _context.Agents.Where(s => s.Status)
                                    .OrderBy(o => o.OrderBy)
                                    .ToList();
        }
    }
}
