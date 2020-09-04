using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BookShifting.Processes
{
    class UpdatingProfile : DatabaseQuery
    {
        private string specialism;
        private string firstname;
        private int surname;
        private int reviewerId;

        public UpdatingProfile(int reviewerId)
        {
            this.reviewerId = reviewerId;
        }

        // Get Specialisation for a specific reviewer
        public DataTable getSpecialismForUser()
        {
            string sqlQuery = "SELECT specialism from reviewerspecialisms where reviewerId = "+reviewerId+";";
            return Read(sqlQuery);
        }
    }
}
