namespace BayesianBlackjack.Application.Objects.Interfaces;

public interface IHand
{
    void Add(ICard card);
    void Clear();
    void Remove(ICard card);
    IEnumerable<ICard> View();
}
