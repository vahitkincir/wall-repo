using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IPostService
    {
        List<post> GetAllPosts();
        post GetPostById(int id);
        post CreatePost(post post);
        post UpdatePost(post post);
        void DeletePost(int id);
    }
}
