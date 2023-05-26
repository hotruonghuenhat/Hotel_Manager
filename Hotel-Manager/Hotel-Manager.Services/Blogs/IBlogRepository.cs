﻿using TatBlog.Core.Contracts;
using TatBlog.Core.DTO;
using TatBlog.Core.Entities;

namespace TatBlog.Services.Blogs {
    public interface IBlogRepository {              
        Task<IList<Author>> GetAuthorsAsync(AuthorQuery condition = null, CancellationToken cancellationToken = default);
        Task<Author> FindAuthorBySlugAsync(string slug, CancellationToken cancellationToken = default);
        Task<IList<AuthorItem>> GetAuthorsMostPost(int number, CancellationToken cancellationToken = default);
        Task<Author> FindAuthorByIdAsync(int id, CancellationToken cancellationToken = default);
        Task<bool> AddOrEditAuthorAsync(Author author, CancellationToken cancellationToken = default);
        Task<bool> DeleteAuthorByIdAsync(int id, CancellationToken cancellationToken = default);
        Task<bool> IsAuthorSlugExistedAsync(int id, string slug, CancellationToken cancellationToken = default);

        Task<IList<CategoryItem>> GetCategoriesAsync(bool showOnMenu = false, CancellationToken cancellationToken = default);
        Task<Category> FindCategoryBySlugAsync(string slug, CancellationToken cancellationToken = default);
        Task<Category> FindCategoryByIdAsync(int id, CancellationToken cancellationToken = default);
        Task<bool> AddOrEditCategoryAsync(Category newCategory, CancellationToken cancellationToken = default);
        Task<bool> DeleteCategoryByIdAsync(int id, CancellationToken cancellationToken = default);
        Task<bool> IsSlugOfCategoryExist(string slug, CancellationToken cancellationToken = default);
        Task<IPagedList<CategoryItem>> GetPagedCategoriesAsync(IPagingParams pagingParams, CancellationToken cancellationToken = default);
        Task<IPagedList<Category>> GetCategoriesByQuery(CategoryQuery condition, int pageNumber = 1, int pageSize = 10, CancellationToken cancellationToken = default);
        Task<bool> IsCategorySlugExistedAsync(int id, string slug, CancellationToken cancellationToken = default);

        Task<Post> CreateOrUpdatePostAsync(Post post, IEnumerable<string> tags, CancellationToken cancellationToken = default);
        Task<bool> IsPostSlugExistedAsync(int postId, string slug, CancellationToken cancellationToken = default);
        Task IncreaseViewCountAsync(int postId, CancellationToken cancellationToken = default);
        Task<Object> CountByMostRecentMonthAsync(int month, CancellationToken cancellationToken = default);
        Task<Post> FindPostByIdAsync(int id, CancellationToken cancellationToken = default);
        Task<bool> AddOrUpdatePostAsync(Post post, CancellationToken cancellationToken = default);
        Task ChangeStatusPublishedOfPostAsync(int id, CancellationToken cancellationToken = default);
        Task<IList<Post>> GetPostsByQualAsync(int num, CancellationToken cancellationToken = default);
        Task<IList<Post>> FindPostByPostQueryAsync(PostQuery query, CancellationToken cancellationToken = default);
        Task<int> CountPostsOfPostQueryAsync(PostQuery query, CancellationToken cancellationToken = default);
        Task<IPagedList<Post>> GetPagedPostByPostQueryAsync(IPagingParams pagingParams, PostQuery query, CancellationToken cancellationToken = default);
        Task<IPagedList<Post>> GetPagedPostsAsync(PostQuery condition, int pageNumber = 1, int pageSize = 10, CancellationToken cancellationToken = default);
        Task<Post> GetPostByIdAsync(int postId, bool includeDetails = false, CancellationToken cancellationToken = default);
        Task<bool> DeletePostByIdAsync(int id, CancellationToken cancellationToken = default);
        Task ChangePostStatusAsync(int id, CancellationToken cancellationToken = default);
        Task<IPagedList<Post>> GetPostByQueryAsync(PostQuery query, int pageNumber = 1, int pageSize = 10, CancellationToken cancellationToken = default);
        Task<IPagedList<Post>> GetPostByQueryAsync(PostQuery query, IPagingParams pagingParams, CancellationToken cancellationToken = default);
        Task<IPagedList<T>> GetPostByQueryAsync<T>(PostQuery query, IPagingParams pagingParams, Func<IQueryable<Post>, IQueryable<T>> mapper, CancellationToken cancellationToken = default);
        Task<IList<Post>> GetPopularArticleAsync(int numPosts, CancellationToken cancellationToken = default);
        Task<Post> GetPostsAsync(PostQuery query, CancellationToken cancellationToken = default);

        Task<IPagedList<TagItem>> GetPagedTagsAsync(IPagingParams pagingParams, CancellationToken cancellationToken = default);
        Task<Tag> FindTagBySlugAsync(string slug, CancellationToken cancellationToken = default);
        Task<IList<TagItem>> FindTagItemSlugAsync(CancellationToken cancellationToken = default);
        Task<bool> DeleteTagByIdAsync(int id, CancellationToken cancellationToken = default);
        Task<IList<TagItem>> GetListTagItemAsync(TagQuery condition = null, CancellationToken cancellationToken = default);
        Task<Tag> GetTagAsync(string slug, CancellationToken cancellationToken = default);      
        Task<bool> IsTagSlugExistedAsync(int id, string slug, CancellationToken cancellationToken = default);
        Task<Tag> FindTagById(int id, CancellationToken cancellationToken = default);
        Task<bool> AddOrEditTagAsync(Tag tag, CancellationToken cancellationToken = default);
    }
}