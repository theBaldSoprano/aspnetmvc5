using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyAuto.stastasks {
    class Program {
        public virtual HashSet<Tasks> tasks { get; set; }
        public virtual HashSet<RoleInTask> rolesTask { get; set; }
        public virtual HashSet<Roles> roles { get; set; }
        public virtual HashSet<UserInRole> usersRole { get; set; }
        public virtual HashSet<Users> users { get; set; }

        public static void Main(string[] d) {

        }

        public string[] getNamesOfRolesAndTasks(int id) {
            //var xx =
            return
            usersRole
                .Where(x => x.UserId == id)
                // тут юзерРоли нашего юзера
                .SelectMany(uroles => roles.Where(x => x.RoleId == uroles.RoleId), (ur, r) => r)
                // тут только роли нашего юзера
                .Select(r => new {
                    rolename = r.RoleName,
                    tasknames = r.RoleInTask.SelectMany(rt => tasks.Where(x => x.TaskId == rt.TaskId), (rt, t) => t.TaskName).ToList()
                })
                //тут набор объектов. в каждом имя роли + все имена тасков связанных с ролью
                .Select(a => {
                    a.tasknames.Add(a.rolename);
                    return a.tasknames;
                })
                //тут листы стрингов с именами роль+таски
                .SelectMany(x => x)
                .ToArray();

        }

    }
}

