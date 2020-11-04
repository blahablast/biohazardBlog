using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog_template_practice.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public virtual ICollection<Content> Contents { get; set; }

        public Category()
        {

        }

        public Category(int id, string name, string image)
        {
            Id = id;
            Name = name;
            Image = image;
        }
        
    }

    
}
