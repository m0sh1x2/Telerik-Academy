namespace _09.StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Groups
    {
        public string GroupNumber { public get; public set; }
        public string DepartmentName { public get; public set; }
        public Groups(string number, string department)
        {
            this.GroupNumber = number;
            this.DepartmentName = department;
        }
    }
}
