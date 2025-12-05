namespace _0._3_Constructors;

class Quiz {
    internal QuizVraag[] vragen;
    internal QuizVraagAntwoord[] ingevuldeAntwoorden ;
    
    internal Quiz()
    {
vragen = new QuizVraag[int aantalVragen];
}
}

