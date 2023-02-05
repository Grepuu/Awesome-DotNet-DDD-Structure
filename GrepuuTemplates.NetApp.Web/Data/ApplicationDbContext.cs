using GrepuuTemplates.NetApp.Web.Areas.Articles.Models.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GrepuuTemplates.NetApp.Web.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public DbSet<ArticleEntity> Articles { get; set; }
    public DbSet<ArticleAuthorEntity> ArticleAuthors { get; set; }
    public DbSet<ArticleContentEntity> ArticleContents { get; set; }
    
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<ArticleEntity>()
            .HasOne(n => n.Author)
            .WithOne(n => n.Article)
            .HasForeignKey<ArticleEntity>(n => n.AuthorForeignKey);

        builder.Entity<ArticleEntity>()
            .HasOne(n => n.Content)
            .WithOne(n => n.Article)
            .HasForeignKey<ArticleEntity>(n => n.AuthorForeignKey);
    }
}