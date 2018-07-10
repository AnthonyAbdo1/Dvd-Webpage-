namespace DVDStore.db.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq; 
   
    internal sealed class Configuration : DbMigrationsConfiguration<DVDStore.db.DVDStoreContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DVDStore.db.DVDStoreContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            

            context.Genres.AddOrUpdate(i => i.Category,

            new Genre()
            {
                Category = "Comedy",
            },

            new Genre()
            {
                Category = "Western",
            },

            new Genre()
            {
                Category = "Action",
            },

            new Genre()
            {
                Category = "Family",
            },

            new Genre()
            {
                Category = "SciFi",
            });

            context.SaveChanges();

            context.Actors.AddOrUpdate(i => i.LName,
            new Actor()
            {
                FName = "Anna",
                LName = "Kendrick",

            },

            new Actor()
            {
                FName = "Rebel",
                LName = "Wilson",
            },

            new Actor()
            {
                FName = "Hailee",
                LName = "Steinfeld",
            },

            new Actor()
            {
                FName = "George",
                LName = "Strait",
            },

            new Actor()
            {
                FName = "Lesley",
                LName = "Warren",
            },

            new Actor()
            {
                FName = "Isabel",
                LName = "Glasser",
            },

            new Actor()
            {
                FName = "Dwayne",
                LName = "Johnson",
            },

            new Actor()
            {
                FName = "Jack",
                LName = "Black",
            },

            new Actor()
            {
                FName = "Kevin",
                LName = "Hart",
            },

            new Actor()
            {
                FName = "Joe",
                LName = "Kingman",
            },

            new Actor()
            {
                FName = "Marv",
                LName = "Albert",
            },

            new Actor()
            {
                FName = "Channing",
                LName = "Tatum",
            },

            new Actor()
            {
                FName = "Justin",
                LName = "Long",
            },

            new Actor()
            {
                FName = "Timothy",
                LName = "Olyphant",
            },

            new Actor()
            {
                FName = "Lily",
                LName = "Tomlin",
            },

            new Actor()
            {
                FName = "Clay",
                LName = "Walker",
            },

            new Actor()
            {
                FName = "John",
                LName = "Bailey",
            },

            new Actor()
            {
                FName = "John",
                LName = "Wayne",
            },

            new Actor()
            {
                FName = "Richard",
                LName = "Boone",
            },

            new Actor()
            {
                FName = "Maureen",
                LName = "O'Hara",
            },

            new Actor()
            {
                FName = "Steve",
                LName = "McQueen",
            },

            new Actor()
            {
                FName = "John",
                LName = "Benson",
            },

            new Actor()
            {
                FName = "Stephen",
                LName = "Chase",
            },

            new Actor()
            {
                FName = "Scatman",
                LName = "Crother",
            },

            new Actor()
            {
                FName = "Eva",
                LName = "Gabor",
            },

            new Actor()
            {
                FName = "Serling",
                LName = "Holloway",
            },

            new Actor()
            {
                FName = "Will",
                LName = "Smith",
            },

            new Actor()
            {
                FName = "Bill",
                LName = "Pullman",
            },

            new Actor()
            {
                FName = "Jeff",
                LName = "Goldblum",
            },

             new Actor()
             {
                 FName = "Bruce",
                 LName = "Willis",
             });

            //System.Collections.Generic.List<Actor> actors = new System.Collections.Generic.List<Actor>()
            //{
            //    context.Actors.Where(a => a.LName == "Kendrick").First(),
            //              context.Actors.Where(a => a.LName == "Wilson").First(),
            //              context.Actors.Where(a => a.LName == "Steinfeld").First()
            //};
            ////An error occurred while updating the entries. See the inner exception for details.


            context.DVDS.AddOrUpdate(i => i.Title,
            new DVD()
            {
                Title = "Pitch Perfect 3",
                Price = "$16.99",
                YearReleased = 2018,
                RunTime = "1 hour, 33 mins",
                TotalSalesCount = 1,
                Summary = "Now graduated from college, realizing it takes more than acappella to get by, all the Bellas return in the final chapter in the beloved series. After the highs of winning the World Championships, the Bellas find themselves split apart and discovering there are no job prospects for making music with only your mouth. But when they get the chance to reunite for a European USO tour, this group of awesome nerds will come together to make some music, and some questionable decisions, one last time.",
                Rating = "PG-13",
                Genre = context.Genres.Where(g => g.Category == "Comedy").First()
                //, Actors = actors.ToList()
            },
            

            new DVD()
            {
                Title = "Pure Country",
                Price = "$12.99",
                YearReleased = 1992,
                RunTime = "1 hour, 52 mins",
                TotalSalesCount = 1,
                Summary = "Country music superstar George Strait plays Dusty Chandler, a singer who, after struggling for years singing in small honky-tonks, suddenly discovers that with success he has lost something important in his life. After cutting his hair and shaving his beard, Dusty takes a job on a ranch where no one recognizes him, reconnects with people who must struggle each day to survive--and finds love. Now, can he balance the life he lost--and found again--with the lifelong dream he has attained of being a country music star?",
                Rating = "PG",
                Genre = context.Genres.Where(g => g.Category == "Western").First()

            },

            new DVD()
            {
                Title = "Jumanji",
                Price = "$15.99",
                YearReleased = 2018,
                RunTime = "1 hour, 59 mins",
                TotalSalesCount = 1,
                Summary = "Four teenagers in detention discover an old video game console with a game they’ve never heard of. When they decide to play, they are immediately sucked into the jungle world of Jumanji in the bodies of their avatars (Dwayne Johnson, Jack Black, Kevin Hart, and Karen Gillan). They’ll have to complete the adventure of their lives filled with fun, thrills and danger or be stuck in the game forever!",
                Rating = "PG-13",
                Genre = context.Genres.Where(g => g.Category == "Comedy").First()

            },

            new DVD()
            {
                Title = "The Game Plan",
                Price = "$17.99",
                YearReleased = 2008,
                RunTime = "1 hour, 59 mins",
                TotalSalesCount = 1,
                Summary = "In the hilarious and heartwarming family comedy, one of sports toughest players ever takes on his biggest challenge yet fatherhood! A superstar with an ego bigger than a football field, Joe Kingman (Dwayne The Rock Johnson) is getting ready for a run at the big championship game when the 8-year-old daughter he never knew existed shows up at his not-so-family-friendly bachelor pad. As the big game gets closer, he begins to realize the most meaningful win he can achieve is the heart of the one little fan who counts the most.",
                Rating = "PG",
                Genre = context.Genres.Where(g => g.Category == "Family").First()

            },

            new DVD()
            {
                Title = "G.I. Joe Retaliation",
                Price = "$17.99",
                YearReleased = 2013,
                RunTime = "1 hour, 50 mins",
                TotalSalesCount = 1,
                Summary = "For everyone who rolled their eyes even as they were secretly digging 2009's G.I. Joe: The Rise of Cobra as a guilty pleasure (not to mention giving it big box-office clout), this rejiggered sequel will probably prove irresistible. Hasbro and Hollywood have successfully created a franchise based on toy action figures that were introduced almost 50 years ago, now featuring all the guns, glory, and apocalyptic politics of the modern age. Along with that come the heights of preposterous circumstances and childish fantasy that any $200-plus million action movie requires. ",
                Rating = "PG-13",
                Genre = context.Genres.Where(g => g.Category == "Action").First()

            },

            new DVD()
            {
                Title = "Live Free or Die Hard",
                Price = "$20.00",
                YearReleased = 2007,
                RunTime = "2 hours, 8 mins",
                TotalSalesCount = 1,
                Summary = "Live Free or Die Hard uses some of the cat-and-mouse elements of Die Hard with a Vengeance along with some of the pick-'em-off-one-by-one elements of the now-classic original movie. And it's the most consistently enjoyable installment of the franchise since the original, with eye-popping stunts (directed by Len Wiseman of the Underworld franchise), good humor, and Willis's ability to toss off a quip while barely alive. There was some controversy over the film's PG-13 rating--there might be less blood than usual, and McClane's famous tag line is somewhat obscured--but there's still has plenty of action and a high body count. Yippee-ki-ay!",
                Rating = "PG-13",
                Genre = context.Genres.Where(g => g.Category == "Action").First()

            },

            new DVD()
            {
                Title = "The Kid",
                Price = "$14.00",
                YearReleased = 2001,
                RunTime = "1 hour, 44 mins",
                TotalSalesCount = 1,
                Summary = "Russ Duritz (Bruce Willis) is an ultracynical, 40-year-old L.A. image consultant who fashions bogus façades for scumbag clients. Oblivious to his own need for a makeover, he's a tyrant in the office (to the chagrin of his sarcastic assistant, played to perfection by Lily Tomlin), and he's emotionally unavailable to the morally centered woman (Emily Mortimer) who senses goodness beneath Russ's hardened veneer. Not a moment too soon, a pudgy kid (Spencer Breslin) mysteriously appears in Russ's life, revealing himself to be Rusty Duritz--that is, Russ's 8-year-old self, arriving by some magic to put the adult Russ's life into beneficial perspective. This variation on A Christmas Carol has Rusty guiding Russ on a tour of his past to reveal how he became a loveless, hard-shelled loser.",
                Rating = "PG",
                Genre = context.Genres.Where(g => g.Category == "Family").First()

            },

            new DVD()
            {
                Title = "The Search for Signs of Intelligent Life in the Universe",
                Price = "$10.00",
                YearReleased = 200,
                RunTime = "2 hours, 2 mins",
                TotalSalesCount = 1,
                Summary = "Lily Tomlin, one of America's foremost comediennes, continues to venture across an ever-widening range of media, starring in television, theater, motion pictures, animation, video, and personal appearances throughout the United States. During her extraordinary entertainment career, Tomlin has received numerous awards, including: six Emmys; a Tony for her one woman Broadway show, Appearing Nitely; a second Tony as Best Actress, Drama Desk Award and Outer Critics' Circle Award for her one woman performance in Jane Wagner's The Search for Signs of Intelligent Life in the Universe",
                Rating = "PG-13",
                Genre = context.Genres.Where(g => g.Category == "Comedy").First()
            },

            new DVD()
            {
                Title = "Big Jake",
                Price = "$10.00",
                YearReleased = 1971,
                RunTime = "1 hour, 50 mins",
                TotalSalesCount = 1,
                Summary = "John Wayne playing the Role of Big Jake as only he can. If you look closely at the ensemble cast, you'll see actors Like Bruce Cabot who played with John Wayne since at least the 40s, in B&W films like Angel And The Bad Man. Harry Carey Jr. who literally grew up acting in John Wayne films. The Ever Radiant Maureen O'Hara who goes all the way back with John Wayne to She Wore A Yellow Ribbon, Rio Grande, Mclintock and the Unforgettable The Quiet Man.",
                Rating = "PG-13",
                Genre = context.Genres.Where(g => g.Category == "Western").First()

            },

            new DVD()
            {
                Title = "The Blob",
                Price = "$7.00",
                YearReleased = 1958,
                RunTime = "1 hour, 30 mins",
                TotalSalesCount = 1,
                Summary = "In this campy thriller, small-town teens Steve (Steve McQueen) and Jane (Aneta Corsaut) see a meteorite land nearby and go off to find it. Before they can, however, an old hermit finds the strange little ball, pokes it, and out comes an oozy, jelly-like substance that proceeds to attack and consume him. Steve and Jane take him to a doctor, who becomes the blob's next victim. The blob grows bigger and bigger and slides all over town looking for prey. Steve tries to convince the local police of this horror, but no one believes him (Kids!). With the help of all of the town's teenagers, Steve finally gets the adults to listen to him, but will it be too late?",
                Rating = "PG",
                Genre = context.Genres.Where(g => g.Category == "SciFi").First()
            },

            new DVD()
            {
                Title = "THE ARISTOCATS",
                Price = "$19.99",
                YearReleased = 2012,
                RunTime = "1 hour, 30 mins",
                TotalSalesCount = 1,
                Summary = "Everybody wants to be a cat! Disney's unforgettable classic THE ARISTOCATS swings like never before in high definition. Share all the heart, humor and irresistible music with your family in this jazzy Special Edition 2-Disc Combo Pack! In the heart of Paris, a kind and eccentric millionairess wills her entire estate to Duchess, her high-society cat, and her three kittens. When her greedy, bumbling butler attempts the ultimate catnap caper, the rough-and-tumble alley cat Thomas O'Malley and his band of swingin' jazz cats must save the day. It's the purr-fect blend of comedy and adventure. This timeless treasure boasts remarkable picture and sound quality, fun-filled bonus features and memorable songs the whole family will enjoy. It's the cat's pajamas in Disney High Definition!",
                Rating = "G",
                Genre = context.Genres.Where(g => g.Category == "Family").First()

            },

            new DVD()
            {
                Title = "Independence Day",
                Price = "$18.99",
                YearReleased = 2013,
                RunTime = "2 hours, 25 mins",
                TotalSalesCount = 1,
                Summary = "One of the biggest box office hits of all time, Independence Day delivers the ultimate encounter when mysterious and powerful aliens launch an all out invasion against the human race. The spectacle begins when massive spaceships appear in Earth's skies. But wonder turns to terror as the ships blast destructive beams of fire down on cities all over the planet. Now the world's only hope lies with a determined band of survivors, uniting for one last strike against the invaders -- before it's the end of mankind.",
                Rating = "PG-13",
                Genre = context.Genres.Where(g => g.Category == "Action").First()
            });

                        
        }


    }
}
