using BayesianBlackjack.Application.Objects.Interfaces;

namespace BayesianBlackjack.Application.Objects;
/// <summary>
///		Represents a collection of cards in a hand.
/// </summary>
public class Hand : IHand
{
	private readonly List<ICard> _cards;

	public Hand()
	{
		_cards = new List<ICard>();
	}
	/// <summary>
	///		Adds a given card to this hand.
	/// </summary>
	/// <param name="card">
	///		Card to be added.
	/// </param>
	public void Add(ICard card)
	{
		_cards.Add(card);
	}
	/// <summary>
	///		Removes a specified card - if it exists - from this hand.
	/// </summary>
	/// <param name="card">
	///		Card to be removed.
	/// </param>
	public void Remove(ICard card)
	{
		_cards.Remove(card);
	}
	/// <summary>
	///		Removes all cards from this hand.
	/// </summary>
	public void Clear()
	{
		_cards.Clear();
	}
	/// <summary>
	///		Provides a read-only view of all cards in this hand.
	/// </summary>
	/// <returns>
	///		Read-only view of the cards in this hand.
	/// </returns>
	public IEnumerable<ICard> View()
	{
		return _cards.AsEnumerable();
	}
}
