using BayesianBlackjack.Application.Objects;
using System.Collections;

namespace BayesianBlackjack.Interface.Utilities;
/// <summary>
///		Static class used to map a given card suit to a corresponding icon.
/// </summary>
public static class MapSuitToIcon
{
    private static readonly Dictionary<Card.SuitEnum, string> _dictionary;

    static MapSuitToIcon()
    {
        _dictionary = new();

        _dictionary.Add(Card.SuitEnum.Clubs, "Clubs");
        _dictionary.Add(Card.SuitEnum.Diamonds, "Diamonds");
        _dictionary.Add(Card.SuitEnum.Hearts, "Hearts");
        _dictionary.Add(Card.SuitEnum.Spades, "Spades");
    }
    /// <summary>
    ///		Given a valid card suit will return a mapped icon.
    /// </summary>
    /// <param name="suit">
    ///		Mapped card suit.
    /// </param>
    /// <returns>
    ///		Mapped icon.
    /// </returns>
    public static string Get(Card.SuitEnum suit)
    {
        return _dictionary[suit];
    }
}
