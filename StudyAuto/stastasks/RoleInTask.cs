using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyAuto.stastasks {
    class RoleInTask {

        public int Id { get; set; }

        public int RoleId { get; set; }

        public int TaskId { get; set; }

        public virtual Roles Roles { get; set; }

        public virtual Tasks Tasks { get; set; }
    }
}
