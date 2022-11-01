using ASM1670.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASM1670.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Book> Books { get; set; }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //Note: add dữ liệu cho bảng chứa PK trước (University)
            //rồi add dữ liệu cho bảng chứa FK sau (Student)

            //add dữ liệu khởi tạo cho bảng University
            Category(builder);

            //add dữ liệu khởi tạo (initial data) cho bảng Student
            Book(builder);
            //add dữ liệu cho bảng User
            SeedUser(builder);

            //add dữ liệu cho bảng Role
            SeedRole(builder);

            //add dữ liệu cho bảng UserRole
            SeedUserRole(builder);
        }
        private void SeedRole(ModelBuilder builder)
        {
            //1. tạo các role cho hệ thống
            var admin = new IdentityRole
            {
                Id = "A",
                Name = "Administrator",
                NormalizedName = "Administrator"
            };
            var customer = new IdentityRole
            {
                Id = "B",
                Name = "Customer",
                NormalizedName = "Customer"
            };
            var storeowner = new IdentityRole
            {
                Id = "C",
                Name = "Storeowner",
                NormalizedName = "Storeowner"
            };

            //2. add role vào trong DB
            builder.Entity<IdentityRole>().HasData(admin, customer, storeowner);

        }
        private void SeedUserRole(ModelBuilder builder)
        {
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    UserId = "1",
                    RoleId = "A"
                },
                new IdentityUserRole<string>
                {
                    UserId = "2",
                    RoleId = "B"
                },
                new IdentityUserRole<string>
                {
                    UserId= "3",
                    RoleId= "C"
                }
             );
        }
        private void SeedUser(ModelBuilder builder)
        {
            //1. tạo tài khoản ban đầu để add vào DB
            var admin = new IdentityUser
            {
                Id = "1",
                UserName = "admin@fpt.com",
                Email = "admin@fpt.com",
                NormalizedUserName = "admin@fpt.com",
                EmailConfirmed = true
            };

            var customer = new IdentityUser
            {
                Id = "2",
                UserName = "customer@fpt.com",
                Email = "customer@fpt.com",
                NormalizedUserName = "customer@fpt.com",
                EmailConfirmed = true
            };

            var storeowner = new IdentityUser
            {
                Id = "3",
                UserName = "storeowner@fpt.com",
                Email = "storeowner@fpt.com",
                NormalizedUserName = "storeowner@fpt.com",
                EmailConfirmed = true
            };
            //2. khai báo thư viện để mã hóa mật khẩu
            var hasher = new PasswordHasher<IdentityUser>();

            //3. thiết lập và mã hóa mật khẩu   từng tài khoản
            admin.PasswordHash = hasher.HashPassword(admin, "123456");
            customer.PasswordHash = hasher.HashPassword(customer, "123456");
            storeowner.PasswordHash = hasher.HashPassword(storeowner, "123456");

            //4. add tài khoản vào db
            builder.Entity<IdentityUser>().HasData(admin, customer, storeowner);
        }

        private void Book(ModelBuilder builder)
        {
            builder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    Name = "OnePiece",
                    Price = 200000,
                    Language = "English",
                    Author = "DA",
                    Publisher = "XC",
                    Image = "https://bvhttdl.mediacdn.vn/291773308735864832/2021/3/16/photo-1-1615870720601745881145-1615882898863-16158828989761108660908-1615883538504-1615883539327865048813.jpg",
                    CategoryId = 10,
                    Quantity = 20,
                },
                new Book
                {
                    Id = 2,
                    Name = "Kimesu no yaba",
                    Price = 100000,
                    Language = "Japan",
                    Author = "AD",
                    Publisher = "CX",
                    Image = "https://thpttranhungdao.edu.vn/wp-content/uploads/2022/10/Shounen-la-gi-Phan-biet-Shounen-manga-va-Shoujo-manga-780x450.jpg",
                    CategoryId = 10,
                    Quantity = 20,
                },
                new Book
                {
                    Id = 3,
                    Name = "Harry Potter and the Half Blood Prince",
                    Price = 300000,
                    Language = "English",
                    Author = "RC",
                    Publisher = "QC",
                    Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTmoV20nsZR0IHjEWaLb6La24V73Jr2MfE_yYoUuizC572VG4v8D8646BMkNqtKqEWsRgk&usqp=CAU",
                    CategoryId = 30,
                    Quantity = 20,
                }
                );
        }

        private void Category(ModelBuilder builder)
        {
            var manga = new Category
            {
                Id = 10,
                Name = "Manga",
                Description = "Truyện tranh",
            };
            var novel = new Category
            {
                Id = 30,
                Name = "Novel",
                Description = "Tiểu thuyết",
            };
            builder.Entity<Category>().HasData(manga, novel);
        }
    }
}

