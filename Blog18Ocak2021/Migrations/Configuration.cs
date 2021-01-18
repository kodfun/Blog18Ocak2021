namespace Blog18Ocak2021.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Blog18Ocak2021.Models.BlogContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Blog18Ocak2021.Models.BlogContext context)
        {
            if (!context.Yazilar.Any())
            {
                context.Yazilar.Add(new Models.Yazi()
                {
                    Baslik = "Örnek Yazı 1",
                    KisaAciklama = "Sapien elit in malesuada semper mi, id sollicitudin urna fermentum.",
                    Icerik = "<p>Ut fusce varius nisl ac ipsum gravida vel pretium tellus tincidunt integer eu augue augue nunc elit dolor, luctus placerat.</p><p>Scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel.</p>",
                    Foto = "ornek1.jpg"
                });
                context.Yazilar.Add(new Models.Yazi()
                {
                    Baslik = "Örnek Yazı 2",
                    KisaAciklama = "Sapien elit in malesuada semper mi, id sollicitudin urna fermentum.",
                    Icerik = "<p>Ut fusce varius nisl ac ipsum gravida vel pretium tellus tincidunt integer eu augue augue nunc elit dolor, luctus placerat.</p><p>Scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel.</p>",
                    Foto = "ornek2.jpg"
                });
            }
        }
    }
}
