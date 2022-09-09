using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodNewsAggregator.Entities
{
    public class Article
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string ShortDecription { get; set; }

        public string FullText { get; set; }
        public DateTime PublicationDate { get; set; }

        public List<Comment> Comments { get; set; }

        public Guid SourceId { get; set; }
        public Source Source { get; set; }

        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
