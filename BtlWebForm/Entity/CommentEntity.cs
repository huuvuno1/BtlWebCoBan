using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BtlWebForm.Entity
{
    public class CommentEntity
    {
        public int IDProduct { get; set; }
        public SimpleComment Comment { get; set; }
        public List<SimpleComment> ListReply { get; set; }
    }
}