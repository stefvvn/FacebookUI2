using Facebook.Data.SQL;
using Facebook.Entities;
using Facebook.Interface;
using System.Linq;

namespace Facebook.Data.EntityFramework
{
    public class PostsEF : SqlBaseData, IPost
    {
        public PostEntities DeletePostById(int Id)
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            Db.Post.Where(u => u.PostId == Id);
            return DeletePostById(Id);
        }

        public List<PostEntities> GetPostList()
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            return Db.Post.ToList();
        }


        public PostEntities InsertPost(PostEntities post)
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            Db.Post.Add(post);
            Db.SaveChanges();
            return post;
        }
        public PostEntities UpdatePost(PostEntities post)
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            Db.Post.Update(post);
            Db.SaveChanges();
            return post;
        }
        public List<PostEntities> GetPostsByUser(int Id)
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            return (List<PostEntities>)Db.Post.Where(u => u.UserId == Id);
        }


    }
}