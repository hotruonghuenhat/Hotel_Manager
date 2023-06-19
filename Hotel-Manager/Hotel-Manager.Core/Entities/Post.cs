using TatBlog.Core.Contracts;

namespace TatBlog.Core.Entities;

// Biểu diễn một Khách Sạn của blog
public class Post : IEntity {
    // Mã Khách Sạn
    public int Id { get; set; }
    // Tiêu đề Khách Sạn
    public string Title { get; set; }
    // Mô tả hay giới thiệu ngắn về nội dung
    public string ShortDescription { get; set; }
    // Nội dung chi tiết của Khách Sạn 
    public string Description { get; set; }
    // Metadata
    public string Meta { get; set; }
    // Tên định danh để tạo URL
    public string UrlSlug { get; set; }
    // Đường dẫn đến tập tin hình 
    public string ImageUrl { get; set; }
    // Số lượt xem, đọc Khách Sạn 
    public int ViewCount { get; set; }
    // Trạng thái của Khách Sạn 
    public bool Published { get; set; }
    // Ngày giờ đăng bài
    public DateTime PostedDate { get; set; }
    // Ngày giờ cập nhật lần cuối
    public DateTime? ModifiedDate { get; set; }
    // Mã chuyên mục
    public int CategoryId { get; set; }
    // Mã Chủ Khách Sạn của Khách Sạn
    public int AuthorId { get; set; }
    // Chuyên mục của Khách Sạn 
    public Category Category { get; set; }
    // Chủ Khách Sạn của Khách Sạn
    public Author Author { get; set; }
    // Danh sách các từ khóa của Khách Sạn 
    public IList<Tag> Tags { get; set; }
}