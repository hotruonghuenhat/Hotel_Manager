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
                FullName ="Nguyen Van A",
                UrlSlug ="Nguyen-Van-A",
                Email ="NguyenVanA.com",
                JoinedDate = new DateTime(2022, 10, 21)
            },
            new()
            {
                 FullName ="Nguyen Van B",
                UrlSlug ="Nguyen-Van-B",
                Email ="NguyenVanB.com",
                JoinedDate = new DateTime(2022, 4, 19)
            },
            new()
            {
                FullName ="Nguyen Van C",
                UrlSlug ="Nguyen-Van-C",
                Email ="NguyenVanC.com",
                JoinedDate = new DateTime(2010, 9, 06)
            },
            new() {
                FullName ="Nguyen Van D",
                UrlSlug ="Nguyen-Van-D",
                Email ="NguyenVanD.com",
                JoinedDate = new DateTime(2022, 12, 1)
            },
            new() {
                 FullName ="Nguyen Van E",
                UrlSlug ="Nguyen-Van-E",
                Email ="NguyenVanE.com",
                JoinedDate = new DateTime(2023, 1, 22)
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
        new() {Name = "ViewNui", Description = "ViewNui", UrlSlug = "View-Nui"},
        new() {Name = "Party", Description ="Party", UrlSlug ="Party"},
        new() {Name = "SanVuon", Description ="SanVuon", UrlSlug ="San-Vuon"},
        new() {Name = "HoBoi", Description = "HoBoi", UrlSlug = "Ho-Boi"},
        new() {Name = "PhongGym", Description = "PhongGym", UrlSlug = "Phong-Gym"},
        new() {Name = "Buffet", Description = "Buffet", UrlSlug = "Buffet"}
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
            Description = "Sofitel Dalat Palace nơi nghĩ dưỡng tuyệt vời",
            Meta = "Ngoài tiêu chuẩn Sanitised Stays, tất cả khách đều được truy cập Wi-Fi miễn phí trong tất cả các phòng và đỗ xe miễn phí nếu đến bằng ô tô. Nằm ở vị trí trung tâm tại Khu vực hồ Xuân Hương của Đà Lạt, chỗ nghỉ này đặt quý khách ở gần các điểm thu hút và tùy chọn ăn uống thú vị. Đừng rời đi trước khi ghé thăm Crazy House nổi tiếng. Chỗ nghỉ 3 sao này có nhà hàng giúp cho kỳ nghỉ của quý khách thêm thư thái và đáng nhớ.",
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
            ShortDescription = "20 Kim Đồng Street, 09 Ward, Da Lat City, Lâm Đồng Province " ,
            Description = "Novotel Dalat là ngôi nhà thứ 2 của bạn",
            Meta = "Novotel Dalat ",
            UrlSlug ="Novotel-Dalat",
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
            ShortDescription = "20 Kim Đồng Street, 09 Ward, Da Lat City, Lâm Đồng Province " ,
            Description = "Resort Evason Ana Mandara Villans Dalat Khách hàng là thượng đế",
            Meta = "Resort Evason Ana Mandara Villans Dalat ",
            UrlSlug ="Resort-Evason-Ana-Mandara-Villans-Dalat",
            Published = true,
            PostedDate = new DateTime (2022, 8, 25, 10, 20, 0),
            ModifiedDate = null,
            Author= authors[0],
            ViewCount = 30,
            Category = categories[7],
            Tags = new List<Tag>()
            { tags[3] }
        },
        new()
        {
            Title = "Đà Lạt Wonder Resort (Dalat Wonder Resort)",
            ShortDescription = "Số 19, đường Hoa Hồng, hồ Tuyền Lâm, phường 4, thành phố Đà Lạt, Lâm Đồng, Hồ Tuyền Lâm, Đà Lạt, Việt Nam, 670000 " ,
            Description = "Đà Lạt Wonder Resort (Dalat Wonder Resort) là ngôi nhà thứ 2 của bạn",
            Meta = "Đỗ xe và Wi-Fi luôn miễn phí, vì vậy quý khách có thể giữ liên lạc, đến và đi tùy ý. Nằm ở vị trí trung tâm tại Hồ Tuyền Lâm của Đà Lạt, chỗ nghỉ này đặt quý khách ở gần các điểm thu hút và tùy chọn ăn uống thú vị. Đừng rời đi trước khi ghé thăm Crazy House nổi tiếng. Được xếp hạng 4 sao, chỗ nghỉ chất lượng cao này cho phép khách nghỉ sử dụng mát-xa, bể bơi ngoài trời và xông khô ngay trong khuôn viên.",
            UrlSlug ="Dalat-Wonder-Resort",
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
            Title = "Khách Sạn Capital O 585 Sài Gòn Book Đà Lạt",
            ShortDescription = "20 Kim Đồng Street, 09 Ward, Da Lat City, Lâm Đồng Province " ,
            Description = "Khách Sạn Capital là ngôi nhà thứ 2 của bạn",
            Meta = "Ngoài tiêu chuẩn Sanitised Stays, tất cả khách đều được truy cập Wi-Fi miễn phí trong tất cả các phòng và đỗ xe miễn phí nếu đến bằng ô tô. Nằm ở vị trí trung tâm tại Khu vực hồ Xuân Hương của Đà Lạt, chỗ nghỉ này đặt quý khách ở gần các điểm thu hút và tùy chọn ăn uống thú vị. Đừng rời đi trước khi ghé thăm Crazy House nổi tiếng. Chỗ nghỉ 3 sao này có nhà hàng giúp cho kỳ nghỉ của quý khách thêm thư thái và đáng nhớ. ",
            UrlSlug ="Capital",
            Published = true,
            PostedDate = new DateTime (2022, 8, 25, 10, 20, 0),
            ModifiedDate = null,
            Author= authors[0],
            ViewCount = 30,
            Category = categories[4],
            Tags = new List<Tag>()
            { tags[3] }
        }
    };

        _dbContext.AddRange(posts);
        _dbContext.SaveChanges();
        return posts;

    }
}