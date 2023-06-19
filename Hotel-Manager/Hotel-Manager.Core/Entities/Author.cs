using TatBlog.Core.Contracts;

namespace TatBlog.Core.Entities;

// Biểu diễn Chủ Khách Sạn của một Khách Sạn 
public class Author : IEntity {
    // Mã Chủ Khách Sạn Khách Sạn 
    public int Id { get; set; }
    // Tên Chủ Khách Sạn
    public string FullName { get; set; }
    // Tên định danh dùng để tạo URL 
    public string UrlSlug { get; set; }
    // Đường dẫn tới file hình ảnh
    public string ImageUrl { get; set; }
    // Ngày bắt đầu
    public DateTime JoinedDate { get; set; }
    // Địa chỉ email
    public string Email { get; set; }
    // Ghi chú
    public string Notes { get; set; }
    // Danh sách các Khách Sạn của Chủ Khách Sạn
    public IList<Post> Posts { get; set; }
}