using EasyLearn.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EasyLearn.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Radical> Radicals { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<QuizSession> QuizSessions { get; set; }
        public DbSet<QuizAnswer> QuizAnswers { get; set; }
        public DbSet<RadicalTrainingProgress> RadicalTrainingProgresses { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Ändra denna relation för att undvika "multiple cascade paths"
            builder.Entity<QuizAnswer>()
                .HasOne(qa => qa.SelectedRadical)
                .WithMany()
                .HasForeignKey(qa => qa.SelectedRadicalId)
                .OnDelete(DeleteBehavior.Restrict); // <- Lösningen!

            // Se till att ChineseCharacter och RadicalCharacter tillåter Unicode
            builder.Entity<Character>()
                .Property(c => c.ChineseCharacter)
                .IsUnicode(true);

            builder.Entity<Radical>()
                .Property(r => r.RadicalCharacter)
                .IsUnicode(true);

            // Exempeldata för radikaler
            builder.Entity<Radical>().HasData(
                new Radical { Id = 1, RadicalCharacter = "氵", Meaning = "vatten", Pinyin = "shuǐ" },
                new Radical { Id = 2, RadicalCharacter = "火", Meaning = "eld", Pinyin = "huǒ" },
                new Radical { Id = 3, RadicalCharacter = "木", Meaning = "träd", Pinyin = "mù" }
            );

            // Exempeldata för kinesiska tecken kopplade till radikaler
            builder.Entity<Character>().HasData(
                new Character { Id = 1, ChineseCharacter = "河", Meaning = "flod", Pinyin = "hé", RadicalId = 1 },
                new Character { Id = 2, ChineseCharacter = "湖", Meaning = "sjö", Pinyin = "hú", RadicalId = 1 },
                new Character { Id = 3, ChineseCharacter = "火", Meaning = "eld", Pinyin = "huǒ", RadicalId = 2 },
                new Character { Id = 4, ChineseCharacter = "林", Meaning = "skog", Pinyin = "lín", RadicalId = 3 }
            );
        }

    }


}
