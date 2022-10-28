using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogMvcApp.Models
{
    public class BlogInitializer : DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            List<Category> kategoriler = new List<Category>()
            {
                new Category() { KategoriAdi = "C#" },
                new Category() { KategoriAdi = "Asp.net MVC" },
                new Category() { KategoriAdi = "Asp.net WebForm" },
                new Category() { KategoriAdi = "Windows Form" },
            };
            foreach (var item in kategoriler)
            {
                context.Kategoriler.Add(item);
            }
            context.SaveChanges();

            List<Blog> bloglar = new List<Blog>()
            {
                new Blog() { Baslik = "c# Delegates Hakkında", Aciklama = "c# Delegates Hakkında" , Eklenmetarihi = DateTime.Now.AddDays(-10), Anasayfa = true, Onay=true ,
                Icerik = "c# Delegates Hakkındac# Delegates Hakkındac# Delegates Hakkında",Resim="1.jpg",CategoryId = 1},
                 new Blog() { Baslik = "c# Delegates Hakkında", Aciklama = "c# Delegates Hakkında" , Eklenmetarihi = DateTime.Now.AddDays(-10), Anasayfa = true, Onay=true ,
                Icerik = "c# Delegates Hakkındac# Delegates Hakkındac# Delegates Hakkında",Resim="1.jpg",CategoryId = 2},
                  new Blog() { Baslik = "c# Delegates Hakkında", Aciklama = "c# Delegates Hakkında" , Eklenmetarihi = DateTime.Now.AddDays(-17), Anasayfa = false, Onay=true ,
                Icerik = "c# Delegates Hakkındac# Delegates Hakkındac# Delegates Hakkında",Resim="1.jpg",CategoryId = 3},
                  new Blog() { Baslik = "c# Delegates Hakkında", Aciklama = "c# Delegates Hakkında" , Eklenmetarihi = DateTime.Now.AddDays(-19), Anasayfa = true, Onay=false ,
                Icerik = "c# Delegates Hakkındac# Delegates Hakkındac# Delegates Hakkında",Resim="1.jpg",CategoryId = 4},
            };

            foreach (var item in bloglar)
            {
                context.Bloglar.Add(item);
            }
            context.SaveChanges();



            base.Seed(context);
        }
    }
}