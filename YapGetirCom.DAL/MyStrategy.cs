using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetirCom.Model;

namespace YapGetirCom.DAL
{
    class MyStrategy : DropCreateDatabaseAlways<YapGetirComDbContext>
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
                    new UserType(){TypeName="Admin",IsActive=true,CreateDate=DateTime.Now,},

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
                        CategoryName="Süt ürünleri & Yumurta",
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
                CreateDate = DateTime.Now,
                UpdateDate = DateTime.Now.AddHours(-5),

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
            List<Product> products = new List<Product>()
            {
                new Product(){
                    ProductName="Yumurta",
                    CategoryID = 4,
                    Image="yumurta.jpg",
                    SupplierID=1,
                    Price=15,
                    Unit="30'lu Koli",
                    Stock=13,
                    IsActive=true,
                    CreateDate=DateTime.Now,
                },
                new Product(){
                    ProductName="Tam Yağlı Süt",
                    CategoryID = 4,
                    Image="sut1.jpg",
                    SupplierID=1,
                    Price=4,
                    Unit="1Lt",
                    Stock=75,
                    IsActive=true,
                    CreateDate=DateTime.Now,
                },
                new Product(){
                    ProductName="Yarım Yağlı Süt",
                    CategoryID = 4,
                    Image="sut1.jpg",
                    SupplierID=1,
                    Price=3.75m,
                    Unit="1Lt",
                    Stock=55,
                    IsActive=true,
                    CreateDate=DateTime.Now,
                },
                new Product(){
                    ProductName="Bütün Tavuk L",
                    CategoryID = 3,
                    Image="tavukL.jpg",
                    SupplierID=1,
                    Price=7.75m,
                    Unit="Adet",
                    Stock=25,
                    IsActive=true,
                    CreateDate=DateTime.Now,
                },
                new Product(){
                    ProductName="Dana Kuşbaşı",
                    CategoryID = 3,
                    Image="kusbasi.jpg",
                    SupplierID=1,
                    Price=37.75m,
                    Unit="Kg",
                    Stock=46,
                    IsActive=true,
                    CreateDate=DateTime.Now,
                },
                new Product(){
                    ProductName="Marul",
                    CategoryID = 5,
                    Image="marul.jpg",
                    SupplierID=1,
                    Price=1.75m,
                    Unit="Demet",
                    Stock=12,
                    IsActive=true,
                    CreateDate=DateTime.Now,
                },
                new Product(){
                    ProductName="Kuru Soğan",
                    CategoryID = 3,
                    Image="kurusagan.jpg",
                    SupplierID=1,
                    Price=3.75m,
                    Unit="Demet",
                    Stock=16,
                    IsActive=true,
                    CreateDate=DateTime.Now,
                },
                new Product(){
                    ProductName="Çilek",
                    CategoryID = 6,
                    Image="çilek.jpg",
                    SupplierID=1,
                    Price=7.75m,
                    Unit="Kg",
                    Stock=14,
                    IsActive=true,
                    CreateDate=DateTime.Now,
                },

                new Product(){
                    ProductName="Muz",
                    CategoryID = 6,
                    Image="muz.jpg",
                    SupplierID=1,
                    Price=6.75m,
                    Unit="Kg",
                    Stock=36,
                    IsActive=true,
                    CreateDate=DateTime.Now,
                },

            };

            context.CategoryTypes.AddRange(categoryTypes);
            context.SaveChanges();
            context.Categories.AddRange(categories);
            context.SaveChanges();
            context.UserTypes.AddRange(userTypes);
            context.SaveChanges();
            context.Payments.AddRange(payments);
            context.SaveChanges();
            context.Users.AddRange(users);
            context.SaveChanges();
            context.Restaurants.Add(restaurant);
            context.SaveChanges();
            context.Suppliers.Add(supplier);
            context.SaveChanges();
            context.Products.AddRange(products);
            context.SaveChanges();



        }
    }
}
