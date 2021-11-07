using Quizzed.Contracts;
using Quizzed.Entities;
using Quizzed.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzed.Repository
{
    public class ConceptRepository : RepositoryBase<Concept>, IConceptRepository
    {
        public ConceptRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {

        }
    }
}
