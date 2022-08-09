namespace _2ND_Backend_Exam.DATA.Context.Seeder
{
    public static class Seeder01
    {
        public static void RunSeeder(this ModelBuilder builder)
        {
            List<Author> authorList = new List<Author>();
            List<MaterialType> materialTypeList = new List<MaterialType>();
            List<EduMaterial> eduMaterials = new List<EduMaterial>();
            List<Review> reviews = new List<Review>();

            authorList.AddRange(
                new List<Author>()
                {
                    new Author(){ Id = 1, Name = "Author01", Description = "Very old one Author", },
                    new Author(){ Id= 2, Name = "Author02", Description = "Very young one Author", },
                    new Author(){ Id= 3, Name = "Author03", Description = "Middle one Author", },
                    new Author(){ Id= 4, Name = "Corpo", Description = "Some no name working for Mexico government", }
                });

            materialTypeList.AddRange(
                new List<MaterialType>()
                {
                    new MaterialType(){ Id= 1, Type = "YouTube" },
                    new MaterialType(){ Id= 2, Type = "Article" },
                    new MaterialType(){ Id= 3, Type = "Book" },
                    new MaterialType(){ Id= 4, Type = "Boot camp" },
                    new MaterialType(){ Id= 5, Type = "Meet up" },
                });

            eduMaterials.AddRange(
                new List<EduMaterial>()
                {
                    new EduMaterial()
                    {
                        Id = 1,
                        MaterialTypeId = 1,
                        AuthorId = 1,
                        Title = "Step By Step How To Step",
                        Description = "Step By Step How To Step",
                        Location = "yt.com/aaaaaa",
                        PublicationDate = DateTime.Now,
                    },
                    new EduMaterial()
                    {
                        Id = 2,
                        MaterialTypeId = 1,
                        AuthorId = 2,
                        Description = "bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb",
                        Location = "yt.com/bbbbbb",
                        PublicationDate = new DateTime(1999, 09, 09),
                        Title = "bbbbbbbbbbbbbbbbbb",
                    },
                    new EduMaterial()
                    {
                        Id = 3,
                        MaterialTypeId = 1,
                        AuthorId = 2,
                        Description = "ccccccccccccccccccccccccccccccccccccccccccccccc",
                        Location = "yt.com/ccccccccccccccccccccccccccccccccccccc",
                        PublicationDate = new DateTime(2020, 09, 09),
                        Title = "ccccccccccccccccccccccccc",
                    },
                    new EduMaterial()
                    {
                        Id = 4,
                        MaterialTypeId = 2,
                        AuthorId = 1,
                        Description = "some some soem",
                        Location = "onet.pl/some",
                        PublicationDate = new DateTime(2022, 09, 09),
                        Title = "some",
                    },
                    new EduMaterial()
                    {
                        Id = 5,
                        MaterialTypeId = 3,
                        AuthorId = 3,
                        Description = "Book Book Book Book Book Book Book ",
                        Location = $"ISBN:{new Guid()}",
                        PublicationDate = new DateTime(2022, 10, 10),
                        Title = "Book ",
                    },
                    new EduMaterial()
                    {
                        Id = 6,
                        MaterialTypeId = 3,
                        AuthorId = 2,
                        Description = "Other Book Other Book Other Book Other Book Other Book Other Book Other Book Other Book Other Book Other Book ",
                        Location = "Other Book in library",
                        PublicationDate = new DateTime(2022, 09, 11),
                        Title = "Other Book ",
                    }
                });

            reviews.AddRange(
                new List<Review>()
                {
                    new Review()
                    {
                        Id=1,
                        NameOfAuthor = "Bartek",
                        Description = "Very good",
                        Rate = 3,
                        EduMaterialId = 1,
                    },new Review()
                    {
                        Id=2,
                        NameOfAuthor = "Slawek",
                        Description = "Very bad",
                        Rate = 7,
                        EduMaterialId = 1,
                    },new Review()
                    {
                        Id=3,
                        NameOfAuthor = "Bartlomiej",
                        Description = "IDK",
                        Rate = 8,
                        EduMaterialId = 1,
                    },new Review()
                    {
                        Id=4,
                        NameOfAuthor = "Smok wawelski",
                        Description = "Czadowo",
                        Rate = 10,
                        EduMaterialId = 1,
                    },new Review()
                    {
                        Id=5,
                        NameOfAuthor = "Kon na bialym rycerzu",
                        Description = "To byl on",
                        Rate = 2,
                        EduMaterialId = 2,
                    },new Review()
                    {
                        Id=6,
                        NameOfAuthor = "Jaki typ",
                        Description = "Jako tako",
                        Rate = 3,
                        EduMaterialId = 2,
                    },new Review()
                    {
                        Id=7,
                        NameOfAuthor = "Bartek",
                        Description = "Very good",
                        Rate = 3,
                        EduMaterialId = 2,
                    },
                });

            builder.Entity<Author>()
                    .HasData(authorList);
            builder.Entity<MaterialType>()
                    .HasData(materialTypeList);
            builder.Entity<EduMaterial>()
                    .HasData(eduMaterials);
            builder.Entity<Review>()
                    .HasData(reviews);
        }
        
    }
}
