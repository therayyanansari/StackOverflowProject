using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflowProject.Repositories.Interface
{
    interface IVotesRepository
    {
        void UpdateVote(int aid, int uid, int value);
    }
}
