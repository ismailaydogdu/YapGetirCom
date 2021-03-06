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
                    new UserType(){TypeName="Kullanıcı",IsActive=true,CreateDate=DateTime.Now},
                    new UserType(){TypeName="Restoran",IsActive=true,CreateDate=DateTime.Now},
                    new UserType(){TypeName="Tedarikçi",IsActive=true,CreateDate=DateTime.Now},
                    new UserType(){TypeName="Yönetici",IsActive=true,CreateDate=DateTime.Now,},

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
                        CategoryTypeID=1,
                        IsActive=true,
                        CreateDate=DateTime.Now
                     },
                     new Category
                    {
                        CategoryName="Balık Restoranları",
                        CategoryTypeID=1,
                        IsActive=true,
                        CreateDate=DateTime.Now
                     },
                    new Category
                    {
                        CategoryName="İtalyan Mutfağı",
                        CategoryTypeID=1,
                        IsActive=true,
                        CreateDate=DateTime.Now
                     },
                    new Category
                    {
                        CategoryName="Çin Mutfağı",
                        CategoryTypeID=1,
                        IsActive=true,
                        CreateDate=DateTime.Now
                     },
                    new Category
                    {
                        CategoryName="Pizzacı",
                        CategoryTypeID=2,
                        IsActive=true,
                        CreateDate=DateTime.Now

                    },
                    new Category
                    {
                        CategoryName="Ev Yemekleri",
                        CategoryTypeID=2,
                        IsActive=true,
                        CreateDate=DateTime.Now

                    },
                    new Category
                    {
                        CategoryName="Hamburgerci",
                        CategoryTypeID=2,
                        IsActive=true,
                        CreateDate=DateTime.Now

                    },
                    new Category
                    {
                        CategoryName="Simitçi",
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
            List<Restaurant> restaurants = new List<Restaurant>()
            {
                new Restaurant
                {
                    CompanyName = "Bilge Kadın Ev Yemekleri",
                    CategoryID = 1,
                    IsFavourite = true,
                    UserID = 2,
                    Image = "restaurant1.jpg",
                    IsActive = true,
                    CreateDate = DateTime.Now,
                },

                new Restaurant()
                {
                    CompanyName = "Bilge Adam Restoran",
                    CategoryID = 1,
                    IsFavourite = true,
                    UserID = 2,
                    Image = "bilgeadamrestoran.jpg",
                    IsActive = true,
                    CreateDate = DateTime.Now,
                },

                new Restaurant()
                {
                    CompanyName = "Balkanlar Et Lokantası",
                    CategoryID = 1,
                    IsFavourite = false,
                    UserID = 2,
                    Image = "balkanlarlokanta.jpg",
                    IsActive = true,
                    CreateDate = DateTime.Now,
                }
            };
            List<Supplier> suppliers = new List<Supplier>()
            {
                new Supplier()
                {
                    CompanyName = "Dincel Gıda",
                    Address = "Bahçelievler",
                    City = "İstanbul",
                    Phone = "05123456789",
                    Country = "Türkiye",
                    UserID = 3,
                    IsActive = true,
                    CreateDate = DateTime.Now
                },

                new Supplier()
                {
                    CompanyName = "Sonar A.S.",
                    Address = "Başakşehir",
                    City = "İstanbul",
                    Phone = "05373363534",
                    Country = "Türkiye",
                    UserID = 3,
                    IsActive = true,
                    CreateDate = DateTime.Now
                },

                new Supplier()
                {
                    CompanyName = "Bilge Adam Catering",
                    Address = "Kadıköy",
                    City = "İstanbul",
                    Phone = "02128541212",
                    Country = "Türkiye",
                    UserID = 3,
                    IsActive = false,
                    CreateDate = DateTime.Now
                }
            };
            List<Product> products = new List<Product>()
            {
                new Product(){
                    ProductName="Yumurta",
                    CategoryID = 10,
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
                    CategoryID = 10,
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
                    CategoryID = 10,
                    Image="sut1.jpg",
                    SupplierID=1,
                    Price=3.75m,
                    Unit="1Lt",
                    Stock=55,
                    IsActive=true,
                    CreateDate=DateTime.Now,
                },
                new Product(){
                    ProductName="Tavuk (Büyük Boy)",
                    CategoryID = 9,
                    Image="tavukL.jpg",
                    SupplierID=3,
                    Price=17.75m,
                    Unit="Adet",
                    Stock=25,
                    IsActive=true,
                    CreateDate=DateTime.Now,
                },
                new Product(){
                    ProductName="Tavuk (Orta Boy)",
                    CategoryID = 9,
                    Image="tavukL.jpg",
                    SupplierID=3,
                    Price=12.75m,
                    Unit="Adet",
                    Stock=25,
                    IsActive=true,
                    CreateDate=DateTime.Now,
                },
                new Product(){
                    ProductName="Tavuk (Küçük Boy)",
                    CategoryID = 9,
                    Image="tavukL.jpg",
                    SupplierID=3,
                    Price=7.75m,
                    Unit="Adet",
                    Stock=25,
                    IsActive=true,
                    CreateDate=DateTime.Now,
                },
                new Product(){
                    ProductName="Dana Kuşbaşı",
                    CategoryID = 9,
                    Image="kusbasi.jpg",
                    SupplierID=3,
                    Price=50M,
                    Unit="Kg",
                    Stock=46,
                    IsActive=true,
                    CreateDate=DateTime.Now,
                },
                new Product(){
                    ProductName="Marul",
                    CategoryID = 11,
                    Image="marul.jpg",
                    SupplierID=3,
                    Price=1.75m,
                    Unit="Demet",
                    Stock=12,
                    IsActive=true,
                    CreateDate=DateTime.Now,
                },
                new Product(){
                    ProductName="Kuru Soğan",
                    CategoryID = 11,
                    Image="kurusagan.jpg",
                    SupplierID=2,
                    Price=3.75m,
                    Unit="Demet",
                    Stock=16,
                    IsActive=true,
                    CreateDate=DateTime.Now,
                },
                new Product(){
                    ProductName="Çilek",
                    CategoryID = 12,
                    Image="çilek.jpg",
                    SupplierID=2,
                    Price=7.75m,
                    Unit="Kg",
                    Stock=14,
                    IsActive=true,
                    CreateDate=DateTime.Now,
                },

                new Product(){
                    ProductName="Muz",
                    CategoryID = 12,
                    Image="muz.jpg",
                    SupplierID=2,
                    Price=6.75m,
                    Unit="Kg",
                    Stock=36,
                    IsActive=true,
                    CreateDate=DateTime.Now,
                },
            };
            List<Campaign> campaigns = new List<Campaign>()
            {
                new Campaign()
                {
                    CampaignName = "Yılbaşı indirimi",
                    CampaignStartTime = DateTime.Now.AddDays(5),
                    CampaignFinishTime = DateTime.Now.AddDays(15),
                    IsActive = true,
                    CreateDate = DateTime.Now,
                },

                new Campaign()
                {
                    CampaignName = "Yaz indirimi",
                    CampaignStartTime = DateTime.Now.AddDays(150),
                    CampaignFinishTime = DateTime.Now.AddDays(155),
                    IsActive = true,
                    CreateDate = DateTime.Now,
                }
            };
            List<Cook> cooks = new List<Cook>()
            {
                new Cook()
                {
                    FirstName = "Somer",
                    LastName = "Sivrioglu",
                    RestaurantID = 2,
                    IsActive = true,
                    CreateDate = DateTime.Now
                },

                new Cook()
                {
                    FirstName = "Danilo",
                    LastName = "Zanna",
                    RestaurantID = 1,
                    IsActive = true,
                    CreateDate = DateTime.Now
                },

                new Cook()
                {
                    FirstName = "Nusret",
                    LastName = "Gökçe",
                    RestaurantID = 3,
                    IsActive = true,
                    CreateDate = DateTime.Now
                },

                new Cook()
                {
                    FirstName = "Czn",
                    LastName = "Burak",
                    RestaurantID = 3,
                    IsActive = true,
                    CreateDate = DateTime.Now
                }
            };
            List<UnitOfProduct> unitOfProducts = new List<UnitOfProduct>()
            {
                new UnitOfProduct()
                {
                    Name = "Çay bardağı"
                },
                new UnitOfProduct()
                {
                    Name = "Su bardağı"
                },
                new UnitOfProduct()
                {
                    Name = "Çay kaşığı"
                },
                new UnitOfProduct()
                {
                    Name = "Tatlı kaşığı"
                },
                new UnitOfProduct()
                {
                    Name = "Yemek kaşığı"
                },
                new UnitOfProduct()
                {
                    Name = "Paket"
                },
                new UnitOfProduct()
                {
                    Name = "Kase"
                },
                new UnitOfProduct()
                {
                    Name = "Adet"
                },
                new UnitOfProduct()
                {
                    Name="Demet"
                },
                new UnitOfProduct()
                {
                    Name="Gram"
                }

            };
            List<UnitAndProduct> unitAndProducts = new List<UnitAndProduct>()
            {
                new UnitAndProduct()
                {
                    ProductID = 1,
                    UnitOfProductID = 8,
                    Price = 1M,

                },
                new UnitAndProduct()
                {
                    ProductID = 2,
                    UnitOfProductID = 1,
                    Price = 1M,

                },
                new UnitAndProduct()
                {
                    ProductID = 2,
                    UnitOfProductID = 2,
                    Price = 2M,

                },
                new UnitAndProduct()
                {
                    ProductID = 2,
                    UnitOfProductID = 6,
                    Price = 5M,

                },
                new UnitAndProduct()
                {
                    ProductID = 2,
                    UnitOfProductID = 7,
                    Price = 3M,

                },
                new UnitAndProduct()
                {
                    ProductID = 3,
                    UnitOfProductID = 1,
                    Price = 1M,

                },
                new UnitAndProduct()
                {
                    ProductID = 3,
                    UnitOfProductID = 2,
                    Price = 2M,

                },
                new UnitAndProduct()
                {
                    ProductID = 3,
                    UnitOfProductID = 6,
                    Price = 5M,

                },
                new UnitAndProduct()
                {
                    ProductID = 3,
                    UnitOfProductID = 7,
                    Price = 3M,

                },
                new UnitAndProduct()
                {
                    ProductID = 4,
                    UnitOfProductID = 8,
                    Price = 30M,
                },
                new UnitAndProduct()
                {
                    ProductID = 4,
                    UnitOfProductID = 10,
                    Price = 0.01m,
                },
                new UnitAndProduct()
                {
                    ProductID = 5,
                    UnitOfProductID = 8,
                    Price = 25M,

                },
                new UnitAndProduct()
                {
                    ProductID = 5,
                    UnitOfProductID = 8,
                    Price = 0.01m,

                },
                new UnitAndProduct()
                {
                    ProductID = 6,
                    UnitOfProductID = 8,
                    Price = 20M,

                },
                new UnitAndProduct()
                {
                    ProductID = 6,
                    UnitOfProductID = 8,
                    Price = 0.01m,

                },
                new UnitAndProduct()
                {
                    ProductID = 7,
                    UnitOfProductID = 10,
                    Price = 0.05M,

                },
                new UnitAndProduct()
                {
                    ProductID = 8,
                    UnitOfProductID = 9,
                    Price = 3M,

                },
                
                new UnitAndProduct()
                {
                    ProductID = 9,
                    UnitOfProductID = 8,
                    Price = 1M,
                },

                new UnitAndProduct()
                {
                    ProductID = 9,
                    UnitOfProductID = 10, 
                    Price = 0.005M,
                },

                new UnitAndProduct()
                {
                    ProductID = 10,
                    UnitOfProductID = 8,
                    Price = 1M,
                },    
                new UnitAndProduct()
                {
                    ProductID = 11,
                    UnitOfProductID = 8,
                    Price = 5M,
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
            context.Restaurants.AddRange(restaurants);
            context.SaveChanges();
            context.Suppliers.AddRange(suppliers);
            context.SaveChanges();
            context.Products.AddRange(products);
            context.SaveChanges();
            context.Cooks.AddRange(cooks);
            context.SaveChanges();
            context.UnitOfProducts.AddRange(unitOfProducts);
            context.SaveChanges();
            context.UnitAndProducts.AddRange(unitAndProducts);
            context.SaveChanges();


        }
    }
}
