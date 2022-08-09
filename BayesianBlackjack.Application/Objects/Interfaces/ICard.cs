namespace BayesianBlackjack.Application.Objects.Interfaces;

public interface ICard
{
    Card.RankEnum Rank { get; }
    Card.SuitEnum Suit { get; }
    int Value { get; }
}