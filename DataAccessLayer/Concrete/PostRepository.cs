using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class PostRepository : IPostRepository
    {
        wallContext _wallContext;
        public PostRepository(wallContext wallContext)
        {
            _wallContext = wallContext;
        }

        public post CreatePost(post post)
        {
            using (_wallContext)
            {
                _wallContext.posts.Add(post);
                _wallContext.SaveChanges();
                return post;
            }
        }

        public void DeletePost(int id)
        {
            using (_wallContext)
            {
                var post = _wallContext.posts.Find(id);
                _wallContext.posts.Remove(post);
                _wallContext.SaveChanges();
            }
        }

        public List<post> GetAllPosts()
        {
            using (_wallContext)
            {
                var posts = _wallContext.posts.ToList();
                return posts;
            }
        }

        public post GetPostById(int id)
        {
            using (_wallContext)
            {
                var post = _wallContext.posts.Find(id);
                return post;
            }
        }

        public post UpdatePost(post post)
        {
            using (_wallContext)
            {
                var updatedpost = _wallContext.posts.Update(post);
                _wallContext.SaveChanges();
                return post;
            }
        }
    }
}
