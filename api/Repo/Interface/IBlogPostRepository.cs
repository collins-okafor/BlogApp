using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dto;
using api.Model;

namespace api.Repo.Interface
{
    public interface IBlogPostRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveAll();

        Task<BlogPost> AddBlogPost(BlogPostForCreation field);
        Task<IEnumerable<BlogPost>> GetBlogPostsAll();
        Task<IEnumerable<object>> GetBlogPostWithId(int id);
        Task<IEnumerable<object>> GetBlogPostWithTitle(string title);
        Task <BlogPost> UpdateBlogPost(BlogPostForUpdate model);
         Task <bool> DeletePost(int id);
    }
}