using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class PostService : IPostService
    {
        private IPostRepository _postRepository;
        public PostService(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }
        public post CreatePost(post post)
        {
            return _postRepository.CreatePost(post);
        }

        public void DeletePost(int id)
        {
            _postRepository.DeletePost(id);
        }

        public List<post> GetAllPosts()
        {
            return _postRepository.GetAllPosts();
        }

        public post GetPostById(int id)
        {
            return _postRepository.GetPostById(id);
        }

        public post UpdatePost(post post)
        {
            return _postRepository.UpdatePost(post);
        }
    }
}
