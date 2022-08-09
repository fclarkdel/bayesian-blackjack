using BayesianBlackjack.Application.Objects;

namespace BayesianBlackjack.Interface.Utilities;
/// <summary>
///		Static class used to map a given card rank to a corresponding string.
/// </summary>
public static class MapRankToString
{
    private static readonly Dictionary<Card.RankEnum, string> _dictionary;

    static MapRankToString()
    {
        _dictionary = new();

        _dictionary.Add(Card.RankEnum.Ace, "A");
        _dictionary.Add(Card.RankEnum.Two, "2");
        _dictionary.Add(Card.RankEnum.Three, "3");
        _dictionary.Add(Card.RankEnum.Four, "4");
        _dictionary.Add(Card.RankEnum.Five, "5");
        _dictionary.Add(Card.RankEnum.Six, "6");
        _dictionary.Add(Card.RankEnum.Seven, "7");
        _dictionary.Add(Card.RankEnum.Eight, "8");
        _dictionary.Add(Card.RankEnum.Nine, "9");
        _dictionary.Add(Card.RankEnum.Ten, "10");
        _dictionary.Add(Card.RankEnum.Jack, "J");
        _dictionary.Add(Card.RankEnum.Queen, "Q");
        _dictionary.Add(Card.RankEnum.King, "K");
    }
    /// <summary>
    ///		Given a valid card rank will return a mapped string.
    /// </summary>
    /// <param name="rank">
    ///		Mapped card rank.
    /// </param>
    /// <returns>
    ///		Mapped string.
    /// </returns>
    public static string Get(Card.RankEnum rank)
    {
        return _dictionary[rank];
    }
}
