using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyAuto.stastasks {
    class Roles {

        public virtual ICollection<RoleInTask> RoleInTask { get; set; }

        public Roles() {
            RoleInTask = new HashSet<RoleInTask>();
        }

        public int RoleId { get; set; }

        public string RoleName { get; set; }

    }
}
