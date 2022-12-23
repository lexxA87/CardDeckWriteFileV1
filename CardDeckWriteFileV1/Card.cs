namespace CardDeckWriteFileV1
{
    public class Card : IComparable<Card>
    {
        public Card(Values value, Suits suit)
        {
            Value = value;
            Suit = suit;
        }
        public Suits Suit { get; private set; }
        public Values Value { get; private set; }

        public string Name
        {
            get
            {
                return $"{Value} of {Suit}";
            }
        }

        public int CompareTo(Card? other)
        {
            return new CardCompererByValue().Compare(this, other);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
