using BayesianBlackjack.Application.Objects;
using BayesianBlackjack.Application.Objects.Interfaces;

namespace BayesianBlackjack.Application.Actors.Interfaces;

public interface IPlayer
{
	IHand Hand { get; }

	double CalcProbToBust();
	List<Result> BinomialDistribution();
}
