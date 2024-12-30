using BlogProject.Models;
using BlogProject.Models.Comments;
using BlogProject.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogProject.Data.Repository
{
    public interface IRepository
    {
        Post GetPost(int id);
        FrontPostViewModel GetFrontPost(int id);
        List<Post> GetAllPosts();
        IndexViewModel GetAllPosts(int pageNumber, string category, string search);
        void AddPost(Post post);
        void UpdatePost(Post post);
        void RemovePost(int id);
        void AddSubComment(SubComment comment);
        Task<bool> SaveChangesAsync();
    }
}