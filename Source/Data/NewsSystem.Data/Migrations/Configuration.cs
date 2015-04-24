namespace NewsSystem.Data.Migrations
{
    using NewsSystem.Data.Models;
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<NewsSystem.Data.NewsSystemDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(NewsSystem.Data.NewsSystemDbContext context)
        {
            context.News.Add(new News 
            { 
                Title = "Test title", 
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent eget tristique mi. Sed blandit ac urna at tincidunt. Nullam aliquam eu libero non eleifend. Vestibulum et ex suscipit ex vulputate ullamcorper. Praesent egestas magna in quam bibendum, in fermentum sapien ultricies. Nullam in vestibulum dui, semper molestie libero. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse vulputate velit sagittis sem ultrices rhoncus. Aenean ullamcorper nisl vel turpis semper placerat. Integer a enim sit amet erat auctor scelerisque vitae nec urna. Nam vestibulum, est et bibendum imperdiet, magna est egestas nibh, venenatis venenatis orci lorem sed elit. Vivamus dignissim odio sit amet varius viverra. Nulla in consequat libero, non varius arcu. Praesent tincidunt dignissim nulla, at sodales est convallis id. Nulla sollicitudin sodales justo eu sagittis. Ut egestas nulla eu metus dignissim fermentum non a sem. Aliquam aliquet at neque a bibendum. Quisque sollicitudin ante eu elementum accumsan. Aliquam id nisl sagittis, dignissim justo sed, eleifend nisl. Sed sapien quam, congue non ultricies at, lobortis eu nunc. Suspendisse potenti. Sed a velit vitae dolor vulputate fermentum. Vestibulum ut porta urna, at egestas urna. Cras massa lorem, sodales vel lorem at, faucibus malesuada nisl. Quisque lobortis nulla consectetur volutpat sodales. Praesent eu urna bibendum, varius libero sit amet, egestas nulla. Vestibulum et vulputate sem. Donec metus tellus, interdum in purus convallis, vulputate aliquam velit. Fusce ac ultricies nunc, ac imperdiet arcu. Praesent eu elit euismod, ultricies felis tempor, placerat tellus. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Sed at efficitur tortor. Donec vestibulum leo in ante ultrices consequat. Aenean finibus dui id maximus ultrices. Mauris a tempor odio. Cras sit amet ipsum semper, rutrum neque a, luctus lectus. Nulla sodales risus vel ultrices porttitor. In id eleifend urna, et convallis massa. Nam eu arcu enim. Aenean in ornare nisl, imperdiet efficitur velit. Cras porta purus ac ipsum viverra, et consectetur ex imperdiet. Sed rhoncus ultricies felis, in ultricies erat luctus pretium. Aliquam eu nunc et nunc posuere interdum. Proin eu leo ante. Vivamus gravida nibh ac tortor ultrices, ac egestas purus congue. Morbi volutpat turpis a ex aliquet, posuere luctus est rhoncus. Etiam in libero non lorem dictum porttitor. Fusce sit amet velit bibendum, consequat tortor non, consequat ante. Integer vitae tempor urna. Fusce lacinia lacus non quam maximus maximus. Ut facilisis lobortis est eu cursus. Curabitur sit amet feugiat ipsum, in pulvinar urna. Etiam sodales tortor convallis purus convallis cursus. Nam quis purus vel enim porttitor maximus in pharetra eros. Ut quis urna sodales, vestibulum mi vitae, ultrices mauris. Nulla eget ipsum eu erat luctus consequat. Nullam eros eros, dapibus non euismod sed, mollis ut purus. Nunc commodo est vel augue fermentum ornare id in nisl.", 
                Category = Category.Business, 
                Link = "www.test112233.com" });
            context.SaveChanges();
        }
    }
}
