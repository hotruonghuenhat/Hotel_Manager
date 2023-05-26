using TatBlog.Core.Entities;
using TatBlog.Data.Contexts;

namespace TatBlog.Data.Seeders;

public class DataSeeder : IDataSeeder {
    private readonly BlogDbContext _dbContext;

    public DataSeeder(BlogDbContext dbContext) {
        _dbContext = dbContext;
    }

    public void Initialize() {
        _dbContext.Database.EnsureCreated();

        if (_dbContext.Posts.Any()) return;

        var authors = AddAuthors();
        var categories = AddCategories();
        var tags = AddTags();
        var posts = AddPosts(authors, categories, tags);
    }
    private IList<Author> AddAuthors() {
        {

            var authors = new List<Author>()
        {
            new()
            {
                FullName ="Jason Mouth",
                UrlSlug ="jason-mouth",
                Email ="json@gmail.com",
                JoinedDate = new DateTime(2022, 10, 21)
            },
            new()
            {
                FullName ="Jessica Wonder",
                UrlSlug ="jessica-wonder",
                Email ="jessica665@gmotip.com",
                JoinedDate = new DateTime(2022, 4, 19)
            },
            new()
            {
                FullName ="Kathy Smith",
                UrlSlug ="Kathy-Smith",
                Email ="KathySmith@gmotip.com",
                JoinedDate = new DateTime(2010, 9, 06)
            },
            new() {
                FullName = "Leanne Graham",
                UrlSlug = "leanne-graham",
                Email = "leanne@gmail.com",
                JoinedDate = new DateTime(2022, 12, 1)
            },
            new() {
                FullName = "Ervin Howell",
                UrlSlug = "ervin-howell",
                Email = "ervin@gmail.com",
                JoinedDate = new DateTime(2023, 1, 22)
            },
            new() {
                FullName = "Clementine Bauch",
                UrlSlug = "clementine-bauch",
                Email = "clementine@gmail.com",
                JoinedDate = new DateTime(2022, 11, 23)
            },
            new() {
                FullName = "Patricia Lebsack",
                UrlSlug = "patricia-lebsack",
                Email = "patricia@gmail.com",
                JoinedDate = new DateTime(2021, 7, 8)
            },
            new() {
                FullName = "Chelsey Dietrich",
                UrlSlug = "chelsey-dietrich",
                Email = "chelsey@gmail.com",
                JoinedDate = new DateTime(2022, 3, 14)
            }
};
            _dbContext.Authors.AddRange(authors);
            _dbContext.SaveChanges();

            return authors;
        }
    }
    private IList<Category> AddCategories() {
        var categories = new List<Category>()
        {
           new() {Name = "hotel", Description = "hotel", UrlSlug = "hotel"},
           new() {Name ="1 Sao", Description ="1 Sao", UrlSlug ="1 Sao", ShowOnMenu =true},
           new() {Name ="2 Sao", Description = "2 Sao", UrlSlug = "2 Sao",ShowOnMenu =true },
           new() {Name ="3 Sao", Description = "3 Sao", UrlSlug = "3 Sao",ShowOnMenu =true },
           new() {Name ="4 Sao", Description = "4 Sao", UrlSlug = "4 Sao",ShowOnMenu =true},
           new() {Name ="5 Sao", Description = "5 Sao", UrlSlug = "5 Sao",ShowOnMenu =true},
           new() {Name = "HomeStay", Description = "HomeStay", UrlSlug = "HomeStay"},
           new() {Name = "Resort", Description = "Resort", UrlSlug = "Resort"}
        };
        _dbContext.AddRange(categories);
        _dbContext.SaveChanges();
        return categories;
    }

    private IList<Tag> AddTags() {

        var tags = new List<Tag>()
    {
        new() {Name = "HotView", Description ="HotView", UrlSlug ="Hot-View"},
        new() {Name = "ViewBien", Description = "ViewBien", UrlSlug = "View-Bien"},
        new() {Name = "ViewNui", Description = "razor page", UrlSlug = "razor-page"},
        new() {Name = "Party", Description ="deep learning", UrlSlug ="deep-learning"},
        new() {Name = "SanVuon", Description ="neural network", UrlSlug ="neural-network"},
        new() {Name = "HoBoi", Description = "Front-End Applications", UrlSlug = "font-end-application"},
        new() {Name = "PhongGym", Description = "Visual Studio", UrlSlug = "visual-studio"},
        new() {Name = "Buffet", Description = "SQL Server", UrlSlug = "sql-server"}      
    };
        _dbContext.AddRange(tags);
        _dbContext.SaveChanges();

        return tags;
    }

    private IList<Post> AddPosts(IList<Author> authors, IList<Category> categories, IList<Tag> tags) {
        var posts = new List<Post>()
    {
        new()
        {
            Title = "Sofitel Dalat Palace",
            ShortDescription = "16 Trạng Trình Street, 09 Ward, Da Lat City, Lâm Đồng Province " ,
            Description = "Sofitel Dalat Palace ",
            Meta = "Sofitel Dalat Palace ",
            UrlSlug ="Sofitel-Dalat-Palace",
            Published = true,
            PostedDate = new DateTime (2021, 9, 30, 10, 20, 0),
            ModifiedDate = null,
            Author= authors[0],
            ViewCount = 10,
            Category = categories[5],
            Tags = new List<Tag>()
            { tags[1] ,tags[2] }
        },
        new()
        {
            Title = "Novotel Dalat",
            ShortDescription = "David and friends has a great repos " ,
            Description = "Here's a few great DON'T and DO examples ",
            Meta = "David and friends has a great repository filled ",
            UrlSlug ="aspnet-core-diagnostic-scenarios",
            Published = true,
            PostedDate = new DateTime (2022, 8, 25, 10, 20, 0),
            ModifiedDate = null,
            Author= authors[0],
            ViewCount = 30,
            Category = categories[4],
            Tags = new List<Tag>()
            { tags[3] }
        },
        new()
        {
            Title = "Resort Evason Ana Mandara Villans Dalat",
            ShortDescription = "David and friends has a great repos " ,
            Description = "Here's a few great DON'T and DO examples ",
            Meta = "David and friends has a great repository filled ",
            UrlSlug ="aspnet-core-diagnostic-scenarios",
            Published = true,
            PostedDate = new DateTime (2022, 8, 25, 10, 20, 0),
            ModifiedDate = null,
            Author= authors[0],
            ViewCount = 30,
            Category = categories[7],
            Tags = new List<Tag>()
            { tags[3] }
        }
    };

        _dbContext.AddRange(posts);
        _dbContext.SaveChanges();
        return posts;

    }
}