
In Entity Framework Core, Eager Loading and Lazy Loading are two techniques for loading related data.

EAGER LOADING - 

Eager Loading is a technique where related data is loaded from the database as part of the initial 
query. This is achieved by using the Include method in LINQ queries. Eager Loading is beneficial when 
you know that you'll need related data immediately, as it reduces the number of database calls.

Simple Example of Eager Loading :

public class Blog
{
	public int BlogId { get; set; }
	public string Url { get;set; }
	public List<Post> Posts { get; set; }
}

public class Post
{
	public int PostId { get; set; }
	public string Title { get; set; }
	public int BlogId { get; set; }
	public Blog Blog { get; set; }
}

// Example of Eager Loading

using (var context = new ApplicationDbContext())
{
	var blogs = context.Blogs
						.Include(b => b.Posts)
						.ToList();
}

In this example, the Include method is used to specify that related Posts should be loaded along with 
each Blog. This results in a single database query that joins the Blogs and Posts tables, fetching all 
necessary data at once.

LAZY LOADING -

Lazy Loading is a technique where related data is not loaded from the database until it is explicitly 
accessed. This can lead to multiple database queries if related data is accessed multiple times. 

Lazy Loading is useful when you don't know upfront if you'll need the related data, as it can save 
resources by not loading unnecessary data.

// Example of Lazy Loading

To enable Lazy Loading in the Entity Framework Core, you need to install the
`Microsoft.EntityFrameworkCore.Proxies` package and configure it in your `DbContext`:

1. Install Package - `Microsoft.EntityFrameworkCore.Proxies`

2. Configure you `DbContext` :

	public class ApplicationDbContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder
				.UseLazyLoadingProxies()
				.UseSqlServer("YourConnectionString");
		}

		public DbSet<Blog> Blogs { get; set; }
		public DbSet<Post> Posts { get; set; }
	}

3. Enable Lazy Loading for Navigation properties:

	public class Blog
	{
		public int BlogId { get; set; }
		public string Url { get; set; }
		public virtual List<Post> Posts { get; set; }
	}
	public class Post
	{
		public int PostId { get; set; }
		public string Title { get; set; }
		public int BlogId { get; set; }
		public virtual Blog Blog { get; set; }
	}

	Now, When you access a related property, EF Core will automatically load the data from the database.

	using (var context = new ApplictionDbContext())
	{
		var blog = context.Blogs.First();
		var posts = blog.Posts;	// This triggers a database query to load the related posts
	}