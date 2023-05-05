
Board _board = new Board();

_board.AddQuote(
    new Quote(
        "Paul",
        "God hath not given us the spirit of fear; but of power, and of love, and of a sound mind.",
        new Source("2 Timothy 1:7")
    )
);

_board.AddQuote(
    new Quote(
        "Sister Elaine S. Dalton",
        "Work hard to achieve your dreams.",
        new Source(
            "how to dare great things",
            "https://www.churchofjesuschrist.org/sutdy/daltonTalk"
        )
    )
);
_board.AddQuote(
    new Quote("Alma", "If ye have faith ye hope for things which are not seen, which are true", new Source("Alma 32:21")));
_board.AddQuote(new Quote("Alma", "Live in thanksgiving daily.", new Source("Alma 34:38")));
_board.AddQuote(new Quote("Alma", "Counsel with the Lord in all thy doing.", new Source("Alma 37:37")));

// _board.GetRandomQuote();
Menu _menu = new Menu(_board);
_menu.Display();