﻿namespace TatBlog.Core.Contracts;
public interface IPagedList {
    int PageCount { get; }
    int TotalItemCount { get; }
    int PageIndex { get; }
    int PageNumber { get; }
    int PageSize { get; }
    bool HasPreviousPage { get; }
    bool HasNextPage { get; }
    bool IsFirstPage { get; }
    bool IsLastPage { get; }
    int FirstItemIndex { get; }
    int LastItemIndex { get; }
}

public interface IPagedList<out T> : IPagedList, IEnumerable<T> {
    // Lấy phần tử tại vị trí index (bắt đầu từ 0)
    T this[int index] { get; }

    // Đếm số lượng phần tử chứa trong trang
    int Count { get; }
}