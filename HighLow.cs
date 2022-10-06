//Hello world

private static Random rnd = new Random();

class cards {
    List<int> deck = new List<int>();

    public List<int> card(List<int> deck) {
        for (int i=1; i<=13; i++) {
            deck.Add(i);
            deck.Add(i);
            deck.Add(i);
            deck.Add(i);
        }
        return deck;
    }

    public void refill(){
        
    }

}

class game {
    
    
    //calls player to set points

    cards cards = new cards(); //calls cards to set cards, do cards get modified in functions without needing to do a return function

    int points = 300;
    public game() {
        string answer = "";

        while (answer != "N") {
        Console.WriteLine("Welcome to HighLow the game! Would you like to play?: (Y/N) ");
        answer = Console.ReadLine() ?? "";
        
        if (answer.ToUpper() == "Y")
        {
            play();
            Console.WriteLine("Thanks for playing");
        }
        else if (answer.ToUpper() == "N")
        {
            Console.WriteLine("Please come again!");
        }
        else
        {
            Console.WriteLine("Unrecognized command");
        }
        }
    }

    public void play()
    {
        //initial card with draw card
        int initial = 
        //
        //guess
        string guess = Console.ReadLine() ?? "";
        //draw card and run game <- draw card can be changed into the initial card to be printed
        int draw = DrawCard();
        if (HighLow(initial, draw, guess))
        {
            //player AddPoints();
        }
        else 
        {
            //player SubtractPoints();
        }
        //if true, add points function, if false, subtract points function
        
    }



    public bool HighLow(int card, int previous, string guess){
        //maybe takes in the card and previous and the guess and spits out true or false
        if ((card >= previous) & (guess.ToLower() == "h")){
            return true;
        }
        else if ((card <= previous) & (guess.ToLower() == "l")){
            return true;
        }
        return false;
    }

    //and then add a "IF TRUE ADD" else "IF FALSE SUBTRACT" there might be a thing that warns us if we have a void, actually nvm, it will be false as default

    public int DrawCard(List<int> cards){

        Random r = new Random();
        int amount= cards.Count();
        if (amount == 0)
        {
            Console.WriteLine("Need Card refill");
            
        }
        int genRand = r.Next(1,amount);
        int chosen = cards[genRand];
        cards.RemoveAt(genRand);

        return chosen;
    }



    public int draw(int points, int last, List<int> cards){
        Console.WriteLine($"Points: {points}");
        Console.WriteLine($"Last card is: {last}");
        Console.WriteLine($"Higher or Lower? [h/n]");

        Console.Read();
        int card = DrawCard(cards);
        Console.WriteLine($"The card was {card}");
        Console.WriteLine($"You now have {points} points");
        return card;
    }
}