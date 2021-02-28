using BtlWebForm.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BtlWebForm.Repository
{
    public class CommentRepository
    {
        FileIO file = new FileIO();
        public List<CommentEntity> FindAllComments()
        {
            string commentJson = file.ReadFileJson(Constant.DATA_COMMENT);
            return JsonConvert.DeserializeObject<List<CommentEntity>>(commentJson);
        }

        public List<CommentEntity> FindCommentsByIDProduct(int IDProduct)
        {
            List<CommentEntity> comments = FindAllComments();
            if (comments == null)
                return null;
            List<CommentEntity> results = new List<CommentEntity>();
            foreach (CommentEntity comment in comments)
            {
                if (comment.IDProduct == IDProduct)
                    results.Add(comment);
            }
            if (results.Count == 0)
                return null;
            return results;
        }

        public void SaveCommentLevel1(CommentEntity comment)
        {
            List<CommentEntity> comments = FindAllComments();
            if (comments == null)
                comments = new List<CommentEntity>();
            comments.Add(comment);
            file.WriteFileJson(Constant.DATA_COMMENT, JsonConvert.SerializeObject(comments));
        }

        public void SaveCommentLevel2(SimpleComment simpleComment, int IDProduct)
        {
            List<CommentEntity> comments = FindAllComments();

            // nếu ko có comment cấp 1 thì làm j có comment cấp 2 =))
            if (comments == null)
                return;

            foreach (CommentEntity comment in comments)
            {
                if (comment.IDProduct == IDProduct)
                {
                    if (comment.ListReply == null)
                        comment.ListReply = new List<SimpleComment>();
                    comment.ListReply.Add(simpleComment);
                    return;
                }
            }    
        }
    }
}