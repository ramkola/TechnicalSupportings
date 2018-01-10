using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MattyEditors.Models
{
    public class ParentModel
    {
        public int Id { get; set; }
        public string Property { get; set; }
        public List<ChildModel> Children { get; set; } = new List<ChildModel>();
    }
}