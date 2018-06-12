using System.Collections.Generic;

namespace PawelMultipleEditor.Models
{
    public class SampleParent
    {
        public string Name { get; set; }

        public List<SampleChild> Children { get; set; }
    }
}
