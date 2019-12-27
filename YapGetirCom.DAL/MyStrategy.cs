﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetirCom.Model;

namespace YapGetirCom.DAL
{
    class MyStrategy : DropCreateDatabaseIfModelChanges<YapGetirComDbContext>
    {
        protected override void Seed(YapGetirComDbContext context)
        {

            List<CategoryType> categoryTypes = new List<CategoryType>()
            {
                new CategoryType(){CategoryTypeName="Restaurant", IsActive=true,CreateDate=DateTime.Now},
                new CategoryType(){CategoryTypeName="Recipe", IsActive=true,CreateDate=DateTime.Now},
                new CategoryType(){CategoryTypeName="Product", IsActive=true,CreateDate=DateTime.Now}
            };

            List<UserType> userTypes = new List<UserType>()
            {
                new UserType(){TypeName="Customer",IsActive=true,CreateDate=DateTime.Now},
                new UserType(){TypeName="Restaurant",IsActive=true,CreateDate=DateTime.Now},
                new UserType(){TypeName="Supplier",IsActive=true,CreateDate=DateTime.Now},
                new UserType(){TypeName="Admin",IsActive=true,CreateDate=DateTime.Now},
            };
            List<Payment> payments = new List<Payment>()
            {
                new Payment(){PaymentType="Kredi kartı",CreateDate=DateTime.Now,IsActive=true},
                new Payment(){PaymentType="Kapıda Ödeme",CreateDate=DateTime.Now,IsActive=true}
            };

            List<User> users = new List<User>()
            {
                new User(){
                    FirstName="Ümit",
                    LastName="Sonar",
                    EMail="sonar.umit@gmail.com",
                    Password="umit1234",
                    Region="Başakşehir",
                    BirthDate=DateTime.Now.AddYears(-25),
                    UserTypeID=1,
                    IsActive=true,
                    CreateDate=DateTime.Now
                },
                new User(){
                    FirstName="Nebiye",
                    LastName="Şevik",
                    EMail="sevik.nebiye@gmail.com",
                    Password="nebiye1234",
                    Region="Sancaktepe",
                    BirthDate=DateTime.Now.AddYears(-24),
                    UserTypeID=2,
                    IsActive=true,
                    CreateDate=DateTime.Now
                },
                new User(){
                    FirstName="Can",
                    LastName="Dincel",
                    EMail="mcandincel@gmail.com",
                    Password="can1234",
                    Region="Bahçelievler",
                    BirthDate=DateTime.Now.AddYears(-22),
                    UserTypeID=3,
                    IsActive=true,
                    CreateDate=DateTime.Now
                },
                new User(){
                    FirstName="İsmail",
                    LastName="Aydoğdu",
                    EMail="ismailaydoggdu@gmail.com",
                    Password="ismail1234",
                    Region="Ataşehir",
                    BirthDate=DateTime.Now.AddYears(-21),
                    UserTypeID=4,
                    IsActive=true,
                    CreateDate=DateTime.Now
                }
            };
            List<Category> categories = new List<Category>()
            {
                new Category
                {
                    CategoryName="Ev Yemekleri",
                    CategoryTypeID=2,
                    IsActive=true,
                    CreateDate=DateTime.Now
                 },
                new Category
                {
                    CategoryName="Pizza",
                    CategoryTypeID=2,
                    IsActive=true,
                    CreateDate=DateTime.Now

                },
                new Category()
                {
                    CategoryName="Et ürünleri",
                    CategoryTypeID=3,
                    IsActive=true,
                    CreateDate=DateTime.Now

                },
                new Category()
                {
                    CategoryName="Süt ürünleri",
                    CategoryTypeID=3,
                    IsActive=true,
                    CreateDate=DateTime.Now

                },
                new Category()
                {
                    CategoryName="Sebze",
                    CategoryTypeID=3,
                    IsActive=true,
                    CreateDate=DateTime.Now

                },
                new Category()
                {
                    CategoryName="Meyve",
                    CategoryTypeID=3,
                    IsActive=true,
                    CreateDate=DateTime.Now

                }

            };
            Restaurant restaurant = new Restaurant()
            {
                CompanyName = "Bilge Kadın Ev Yemekleri",
                CategoryID = 1,
                IsFavourite = true,
                UserID = 2,
                Image = "restaurant1.jpg",
                IsActive = true,
                CreateDate = DateTime.Now

            };

            Supplier supplier = new Supplier()
            {
                CompanyName = "Dincel Gıda",
                Address = "Bahçelievler",
                City = "İstanbul",
                Phone = "05123456789",
                Country = "Türkiye",
                UserID = 3,
                IsActive = true,
                CreateDate = DateTime.Now
            };
            context.CategoryTypes.AddRange(categoryTypes);
            context.UserTypes.AddRange(userTypes);
            context.Payments.AddRange(payments);
            context.Users.AddRange(users);
            context.Categories.AddRange(categories);
            context.Restaurants.Add(restaurant);
            context.Suppliers.Add(supplier);
            base.Seed(context);
            context.SaveChanges();
        }
    }
}