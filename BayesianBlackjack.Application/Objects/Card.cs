using BayesianBlackjack.Application.Objects.Interfaces;

namespace BayesianBlackjack.Application.Objects;
/// <summary>
///		Represents a card in a standard 52-card deck.
/// </summary>
public class Card : ICard
{
	public SuitEnum Suit { get; }
	public RankEnum Rank { get; }
	public int Value { get; }
	/// <summary>
	///		Constructs a card instance with a given suit and rank.
	/// </summary>
	/// <param name="suit">
	///		Suit of card.
	/// </param>
	/// <param name="rank">
	///		Rank of card.
	/// </param>
	public Card(SuitEnum suit, RankEnum rank)
	{
		Suit = suit;
		Rank = rank;
		Value = MapRankToValue.Get(Rank);
	}
	/// <summary>
	///		Provides a read-only view of possible card suits.
	/// </summary>
	/// <returns>
	///		Read-only view of possible suits.
	/// </returns>
	public static IEnumerable<SuitEnum> PossibleSuits()
	{
		// How disgusting - we need better enums for C#.
		return Enum.GetValues(typeof(SuitEnum)).Cast<SuitEnum>();
	}
	/// <summary>
	///		Provides a read-only view of possible card ranks.
	/// </summary>
	/// <returns>
	///		Read-only view of possible ranks.
	/// </returns>
	public static IEnumerable<RankEnum> PossibleRanks()
	{
		return Enum.GetValues(typeof(RankEnum)).Cast<RankEnum>();
	}
	/// <summary>
	///		Provides a read-only view of possible card values.
	/// </summary>
	/// <returns>
	///		Read-only view of possible card values.
	/// </returns>
	public static IEnumerable<int> PossibleValues()
	{
		return MapRankToValue.Values();
	}
	/// <summary>
	///     Enumeration representing possible suits for a card.
	/// </summary>
	public enum SuitEnum
	{
		Clubs,
		Diamonds,
		Hearts,
		Spades
	}
	/// <summary>
	///     Enumeration representing possible ranks for a card, and
	///     their corresponding card value.
	/// </summary>
	public enum RankEnum
	{
		Ace,
		Two,
		Three,
		Four,
		Five,
		Six,
		Seven,
		Eight,
		Nine,
		Ten,
		Jack,
		Queen,
		King
	}
	public override bool Equals(object? obj)
	{
		if(obj == null)
		{
			return false;
		}
		Card? card = obj as Card;
		return Suit.Equals(card?.Suit) && Rank.Equals(card?.Rank);
	}
	public override int GetHashCode()
	{
		return base.GetHashCode();
	}
	/// <summary>
	///		Static inner class used to map a valid card rank to a value.
	/// </summary>
	private static class MapRankToValue
	{
		private static readonly Dictionary<RankEnum, int> _dictionary;

		static MapRankToValue()
		{
			_dictionary = new();

			_dictionary.Add(RankEnum.Ace, 1);
			_dictionary.Add(RankEnum.Two, 2);
			_dictionary.Add(RankEnum.Three, 3);
			_dictionary.Add(RankEnum.Four, 4);
			_dictionary.Add(RankEnum.Five, 5);
			_dictionary.Add(RankEnum.Six, 6);
			_dictionary.Add(RankEnum.Seven, 7);
			_dictionary.Add(RankEnum.Eight, 8);
			_dictionary.Add(RankEnum.Nine, 9);
			_dictionary.Add(RankEnum.Ten, 10);
			_dictionary.Add(RankEnum.Jack, 10);
			_dictionary.Add(RankEnum.Queen, 10);
			_dictionary.Add(RankEnum.King, 10);
		}
		/// <summary>
		///		Given a valid card rank will return a mapped value.
		/// </summary>
		/// <param name="rank">
		///		Mapped card rank.
		/// </param>
		/// <returns>
		///		Mapped value.
		/// </returns>
		public static int Get(RankEnum rank)
		{
			return _dictionary[rank];
		}
		/// <summary>
		///		Provides a read-only view of possible card values.
		/// </summary>
		/// <returns>
		///		Read-only view of possible card values.
		/// </returns>
		public static IEnumerable<int> Values()
		{
			return _dictionary.Values.AsEnumerable();
		}
	}
}
