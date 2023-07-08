

Video vid1 = new Video("We gave away $1,000,000!", "Mr. Beast", 600);
Video vid2 = new Video("We traveled the country in 3 days!", "Danny Duncan", 620);
Video vid3 = new Video("What poptarts taste the best?", "Rhett and Link", 700);

vid1.AddComment(new Comment("Joe Brown", "Wow, that is a lot of money"));
vid1.AddComment(new Comment("Susan Smith", "I love this video a lot!"));
vid1.AddComment(new Comment("Jim Thomas", "I wish I had all that money."));

vid2.AddComment(new Comment("Cornelius Swingerton", "I live in Alabama."));
vid2.AddComment(new Comment("John Smith", "I'm 45 and wish I could travel the country."));
vid2.AddComment(new Comment("Brandon Johnson", "My favorite state is Texas"));

vid3.AddComment(new Comment("Carol Bird", "I love strawberry the best."));
vid3.AddComment(new Comment("Jordan Belfort", "I love poptarts alot. I wish I had the smores kind."));
vid3.AddComment(new Comment("Levi Wallace", "Wow, this is just what I needed."));


vid1.DisplayVideoInfo();
vid2.DisplayVideoInfo();
vid3.DisplayVideoInfo();