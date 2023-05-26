﻿using FluentValidation;
using TatBlog.WebApi.Models;

namespace TatBlog.WebApi.Validations;

public class AuthorValidator : AbstractValidator<AuthorEditModel> {
    public AuthorValidator() {
        RuleFor(a => a.FullName)
        .NotEmpty()
        .WithMessage("Tên tác giả không được để trống")
        .MaximumLength(100)
        .WithMessage("Tên tác giả dài tối đa '{MaxLength}' kí tự");

        RuleFor(a => a.UrlSlug)
        .NotEmpty()
        .WithMessage("Slug của tác giả không được để trống")
        .MaximumLength(100)
        .WithMessage("Slug dài tối đa '{MaxLength}' kí tự");

        RuleFor(a => a.JoinedDate)
        .GreaterThan(DateTime.MinValue)
        .WithMessage("Ngày tham gia không hợp lệ");

        RuleFor(a => a.Email)
        .NotEmpty()
        .WithMessage("Email của tác giả không được để trống")
        .MaximumLength(100)
        .WithMessage("Email dài tối đa '{MaxLength}' kí tự");

        RuleFor(a => a.Notes)
        .MaximumLength(500)
        .WithMessage("Ghi chú dài tối đa '{MaxLength}' kí tự");
    }
}