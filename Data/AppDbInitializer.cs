using eTickets.Data.Static;
using eTickets.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using(var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();
                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>() {
                      new Cinema()
                      {
                          Name = "Cinema 1",
                          Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                          Description = "This is the description of te first cinema"
                      },
                      new Cinema()
                      {
                          Name = "Cinema 2",
                          Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                          Description = "This is the description of te second cinema"
                      },
                      new Cinema()
                      {
                          Name = "Cinema 3",
                          Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                          Description = "This is the description of te third cinema"
                      },
                      new Cinema()
                      {
                          Name = "Cinema 4",
                          Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                          Description = "This is the description of te fourth cinema"
                      },
                      new Cinema()
                      {
                          Name = "Cinema 5",
                          Logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                          Description = "This is the description of te fifth cinema"
                      }
                      
                    });
                    context.SaveChanges();
                }
                //Actor
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>() { 
                        new Actor()
                        {
                            FullName = "Actor 1",
                            Bio ="This is the Bio of te first actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-1.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 2",
                            Bio ="This is the Bio of te second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 3",
                            Bio ="This is the Bio of te third actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-3.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 4",
                            Bio ="This is the Bio of te fourth actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-4.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 5",
                            Bio ="This is the Bio of te fifth actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-5.jpeg"
                        },
                    });
                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>() {
                        new Producer()
                        {
                            FullName = "Producer 1",
                            Bio ="This is the Bio of te first producer",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-1.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 2",
                            Bio ="This is the Bio of te second producer",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-2.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 3",
                            Bio ="This is the Bio of te third producer",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-3.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 4",
                            Bio ="This is the Bio of te fourth producer",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-4.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 5",
                            Bio ="This is the Bio of te fifth producer",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-5.jpeg",
                          
                        },

                    });
                    context.SaveChanges();
                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>() {
                        new Movie()
                        {
                            Name = "Scoob",
                            Price = 39.50,
                            Description = "This is description of col Scoob",
                            ImageURL = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Cartoon
                        },
                        new Movie()
                        {
                            Name = "Cold Soles",
                            Price = 34.20,
                            Description = "This is description of col soles",
                            ImageURL = "http://dotnethow.net/images/movies/movie-2.jpeg",
                            StartDate = DateTime.Now.AddDays(10),
                            EndDate = DateTime.Now.AddDays(2),
                            CinemaId = 1,
                            ProducerId = 5,
                            MovieCategory = MovieCategory.Drama
                        },
                        new Movie()
                        {
                            Name = "Hook",
                            Price = 29.30,
                            Description = "This is description of col Hook",
                            ImageURL = "http://dotnethow.net/images/movies/movie-3.jpeg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(-4),
                            CinemaId = 2,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "Leaf live",
                            Price = 46.32,
                            Description = "This is description of col Live",
                            ImageURL = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            StartDate = DateTime.Now.AddDays(8),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 5,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.Comedy
                        },
                        new Movie()
                        {
                            Name = "Blanket of Ghost",
                            Price = 41.23,
                            Description = "This is description of col Ghost",
                            ImageURL = "http://dotnethow.net/images/movies/movie-5.jpeg",
                            StartDate = DateTime.Now.AddDays(5),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = 4,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Doumentary
                        },
                        new Movie()
                        {
                            Name = "Oil spill",
                            Price = 15.8,
                            Description = "This is description of col Spill",
                            ImageURL = "http://dotnethow.net/images/movies/movie-6.jpeg",
                            StartDate = DateTime.Now.AddDays(2),
                            EndDate = DateTime.Now.AddDays(15),
                            CinemaId = 1,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "Pillow can ride",
                            Price = 29.30,
                            Description = "This is description of col ride",
                            ImageURL = "http://dotnethow.net/images/movies/movie-7.jpeg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(-4),
                            CinemaId = 3,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.Cartoon
                        },
                        new Movie()
                        {
                            Name = "My heart is hurt",
                            Price = 29.30,
                            Description = "This is description of col My heart",
                            ImageURL = "http://dotnethow.net/images/movies/movie-8.jpeg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(-4),
                            CinemaId = 1,
                            ProducerId = 4,
                            MovieCategory = MovieCategory.Action
                         
                        },

                    });
                    context.SaveChanges();
                }
                //Actors & Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 3,
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 3,
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 4,
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 1,
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 7,
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 5,
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 1,
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 2,
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 7,
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 1,
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 2,
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 7,
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 8,
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 6,
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 6,
                        },
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 5,
                        },
                    });
                    context.SaveChanges();
                }
            }
            
        }
        public static async Task SeedUserAndRoleAsync(IApplicationBuilder applicationBuilder)
        {
            using(var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                //Roles Section
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));
                //Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                string adminUserEmail = "admin@etickets.com";
                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if (adminUser == null)
                {
                    var newAdminUser = new ApplicationUser()
                    {
                        FullName = "Admin User",
                        UserName = "admin-user",
                        Email = adminUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAdminUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }

              
                string appUserEmail = "user@etickets.com";
                var appUser = await userManager.FindByEmailAsync(appUserEmail);
                if (appUser == null)
                {
                    var newAppUser = new ApplicationUser()
                    {
                        FullName = "Application User",
                        UserName = "app-user",
                        Email = appUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAppUser, "UserCoding@1234?");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }

            }
        }
    }
}
