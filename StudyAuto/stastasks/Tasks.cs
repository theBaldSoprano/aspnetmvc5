using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyAuto.stastasks {
    class Tasks {

        public virtual ICollection<RoleInTask> RoleInTask { get; set; }

        public Tasks() {
            RoleInTask = new HashSet<RoleInTask>();
        }

        public int TaskId { get; set; }

        public string TaskName { get; set; }
    }
}
