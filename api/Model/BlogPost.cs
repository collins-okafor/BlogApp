using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace api.Model
{
    public class BlogPost
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime TimeStamp { get; set; } = DateTime.Now;

        //Navigation properties
        [JsonIgnore]
        public Author Author { get; set; }
    }
}