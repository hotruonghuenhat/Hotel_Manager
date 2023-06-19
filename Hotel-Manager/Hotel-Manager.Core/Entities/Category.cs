using TatBlog.Core.Contracts;

namespace TatBlog.Core.Entities;

// Biểu diễn các chuyên mục hay Loại 
public class Category : IEntity {
    // Mã chuyên mục
    public int Id { get; set; }
    // Tên chuyên mục, Loại
    public string Name { get; set; }
    // Tên định danh dùng để tạo URL
    public string UrlSlug { get; set; }
    // Mô tả thêm về chuyên mục
    public string Description { get; set; }
    // Đánh dấu chuyên mục được hiển thị trên menu
    public bool ShowOnMenu { get; set; }
    // Danh sách các Khách Sạn thuộc chuyên mục www mem
    public IList<Post> Posts { get; set; }
}